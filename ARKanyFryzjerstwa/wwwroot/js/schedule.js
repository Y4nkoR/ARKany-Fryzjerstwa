var Schedule = function (config) {

    var $days = $("#days");
    var $title = $("#scheduleTitle");
    var $timeIntervals = $("#timeIntervals");
    var $appointmentMenu = $("#appointmentMenu");
    var $appointmentMenuDate = $("#appointmentMenuDate");
    var $appointmentMenuTime = $("#appointmentMenuTime");
    var $appointmentMenuId = $("#appointmentMenuId");
    var $cancelAppointmentPopup = $("#cancelAppointmentPopup");
    var $completeAppointmentPopup = $("#completeAppointmentPopup");
    var $appointmentDetailsPopup = $("#appointmentDetailsPopup");

    var isWeekView = true;
    var hours = { start: 0, end: 0 };
    var getAppointmentsParam = {
        date: '',
        employees: [],
        forceCacheRefresh: false
    };

    const completedClass = "completed";
    const disabledClass = "disabled";
    const invalidSelector = ":invalid";
    const newInClass = "new-input";
    const invalidNumericChars = ['-', '+', 'e', 'E'];
    const currencyAbbr = 'zł';

    var daySelection = function () {
        $(".day").click(function () {
            if (isAppointmentMenuHidden() == false) {
                return;
            }
            if (isWeekView) {
                $(".day").not($(this)).each(function () {
                    $(this).hide()
                });
            } else {
                $(".day").each(function () {
                    $(this).show()
                });
            }
            isWeekView = !isWeekView;
        });
    };

    var createTimeIntervals = function (start, end) {
        $timeIntervals.empty();
        var header = document.createElement("div");
        $(header).addClass("scheduleHeader");
        $timeIntervals.append(header);
        hours.start = start;
        hours.end = end;

        for (let hour = hours.start; hour <= hours.end; hour++) {
            var timeLabel = document.createElement("div");
            $(timeLabel).addClass("timeLabel border-bottom border-top");
            $(timeLabel).text(hour + ":00");
            $timeIntervals.append(timeLabel);
        };
    }

    var createDays = function (days) {
        $(days).each(function () {
            var date = this.title.split(", ");
            var day = document.createElement("div");
            $(day).attr("id", "day-" + date[1]);
            $(day).addClass("day shadow-sm");

            var dayHeader = document.createElement("div");
            $(dayHeader).addClass("scheduleHeader");
            $("<div>" + date[0] + "</div><div>" + date[1] + "</div>").appendTo(dayHeader);
            day.appendChild(dayHeader);

            for (var l = 0; l < 2 * (hours.end - hours.start + 1); l++) {
                var c = document.createElement("div");
                $(c).attr("class", "timeInterval border");
                day.appendChild(c)
            }
            $days.append(day);

            createAppointments(this.appointments, date[1]);
        });

        daySelection();
    };

    var removeDays = function () {
        $days.empty();
    };

    var setTitle = function (txt) {
        $title.text(txt);
    };

    var calcAppointmentPosition = function(headerHeight, hourHeight, timeString) {
        var timeNums = timeString.split(":").map(Number);
        return headerHeight +
            hourHeight * (timeNums[0] - hours.start) +
            hourHeight / 60 * timeNums[1];
    };

    var getAppointmentsOverlapData = function (appointments) {
        var appointmentsOverlapData = {};
        appointments.sort((a, b) => (a.startTime > b.startTime) ? 1 : -1);

        $(appointments).each(function () {
            var currentAppointment = this;
            var usedColumns = new Set();
            appointmentsOverlapData[this.appointmentId] = { column: 0, overlapWidth: 0, overlapIds: [], usedColumns: new Set() };

            $(appointments).each(function () {
                if (new Date('1999-01-01 ' + currentAppointment.startTime) < new Date('1999-01-01 ' + this.endTime)
                    && new Date('1999-01-01 ' + this.startTime) < new Date('1999-01-01 ' + currentAppointment.endTime)
                    && currentAppointment.appointmentId != this.appointmentId) {
                    appointmentsOverlapData[currentAppointment.appointmentId].overlapIds.push(this.appointmentId);

                    if (this.appointmentId in appointmentsOverlapData) {
                        usedColumns.add(appointmentsOverlapData[this.appointmentId].column);
                    }
                }
            });

            for (i = 0; i <= appointmentsOverlapData[currentAppointment.appointmentId].overlapIds.length; i++) {
                if (!(usedColumns.has(i))) {
                    appointmentsOverlapData[currentAppointment.appointmentId].column = i;
                    break;
                }
            }
        });

        Object.keys(appointmentsOverlapData).forEach(key => {
            var overlapColumns = new Set();

            $(appointmentsOverlapData[key].overlapIds).each(function () {
                overlapColumns.add(appointmentsOverlapData[this].column);
            });

            appointmentsOverlapData[key].overlapWidth = overlapColumns.size + 1;
            appointmentsOverlapData[key].usedColumns = overlapColumns;
        });

        Object.keys(appointmentsOverlapData).forEach(key => {
            var maxWidth = 1;

            $(appointmentsOverlapData[key].overlapIds).each(function () {
                var newWidth = appointmentsOverlapData[this].overlapWidth;
                maxWidth = newWidth > maxWidth ? newWidth : maxWidth;
            });

            appointmentsOverlapData[key].overlapWidth = maxWidth;
        });

        return appointmentsOverlapData;
    };

    var getAppointmentPosition = function (appointmentsOverlapData, headerHeight, hourHeight, appointment, margin) {
        var top = calcAppointmentPosition(headerHeight, hourHeight, appointment.startTime) + margin;
        var height = calcAppointmentPosition(headerHeight, hourHeight, appointment.endTime) - top - margin;
        var overlapWidth = appointmentsOverlapData[appointment.appointmentId].overlapWidth;
        var left = (100 / (overlapWidth)) * appointmentsOverlapData[appointment.appointmentId].column;
        var width = (100 / overlapWidth);

        var currentColumn = appointmentsOverlapData[appointment.appointmentId].column;
        for (let i = currentColumn + 1; i < overlapWidth; i++) {
            if (appointmentsOverlapData[appointment.appointmentId].usedColumns.has(i)) {
                break;
            }
            width += (100 / overlapWidth);
        }

        return { top: top, height: height, left: left, width: width };
    };

    var showAppointmentMenu = function (e, id) {
        var appointmentData = $("#appointment-" + id).data();
        $appointmentMenuDate.text(appointmentData.date);
        $appointmentMenuTime.text(appointmentData.time);
        $appointmentMenuId.val(id);

        if (appointmentData.isCompleted == true) {
            $("#cancelAppointmentOpt").addClass(disabledClass);
        } else {
            $("#cancelAppointmentOpt").removeClass(disabledClass);
        }

        if (appointmentData.isCompleted == true || isPastOrTodaysAppointment(appointmentData.date) == false) {
            $("#completeAppointmentOpt").addClass(disabledClass);
        } else {
            $("#completeAppointmentOpt").removeClass(disabledClass);
        }

        var viewport = getViewport();
        const boundaryMargin = 20;

        var offsetLeft = e.pageX +
            $appointmentMenu.innerWidth() -
            viewport.width + boundaryMargin;
        var offsetTop = e.pageY +
            $appointmentMenu.innerHeight() - 
            viewport.height + boundaryMargin;

        var currentTop = offsetTop > 0 ? e.pageY - offsetTop : e.pageY;
        var currentLeft = offsetLeft > 0 ? e.pageX - offsetLeft : e.pageX;

        $appointmentMenu.show().css({
            top: currentTop + "px",
            left: currentLeft + "px"
        });
    };

    var isPastOrTodaysAppointment = function (appointmentDate) {
        var todaysDate = new Date();
        appointmentDate = appointmentDate.split('.');
        appointmentDate = new Date(appointmentDate[2], appointmentDate[1] - 1, appointmentDate[0]);
        return appointmentDate <= todaysDate;
    }

    var createAppointments = function (appointments, date) {
        var headerHeight = $($(".scheduleHeader")[0]).outerHeight();
        var hourHeight = 2 * $($(".timeInterval")[0]).outerHeight();
        const appointmentTopBottomMargin = 1;
        var day = document.getElementById("day-" + date);
        var appointmentsOverlapInfo = getAppointmentsOverlapData(appointments);

        $(appointments).each(function () {
            var appointmentDiv = document.createElement("div");
            $(appointmentDiv).addClass("appointment");

            if (this.isCompleted == true) {
                $(appointmentDiv).addClass(completedClass);
            };

			var id = this.appointmentId;
            $(appointmentDiv).attr("id", "appointment-" + id);
            var appointmentTime = this.startTime + " - " + this.endTime;
            $(appointmentDiv).data({
                service: this.serviceName,
                date: this.date,
                time: appointmentTime,
                client: this.clientName,
                employee: this.employeeName,
                isCompleted: this.isCompleted,
                standardPrice: this.standardPrice,
                finalPrice: this.finalPrice
            });

            $(appointmentDiv).css("background-color", this.employeeColor); //color of appointment
            var position = getAppointmentPosition(appointmentsOverlapInfo, headerHeight, hourHeight, this, appointmentTopBottomMargin);
            $(appointmentDiv).css("top", position.top + "px");
            $(appointmentDiv).css("height", position.height + "px");
            $(appointmentDiv).css("left", "calc(" + position.left + "% + 2px)");
            $(appointmentDiv).css("width", "calc(" + position.width + "% - 4px)");
            $(appointmentDiv).css("border-color", getBorderColor(this.employeeColor));

            var appointmentServiceDiv = document.createElement("div");
            $(appointmentServiceDiv).addClass("appointmentService");
            $(appointmentServiceDiv).text(this.serviceName);
            appointmentDiv.appendChild(appointmentServiceDiv);

            if (position.height >= ((hourHeight - 2 * appointmentTopBottomMargin)/ 3)) {
                var appointmentClientDiv = document.createElement("div");
                $(appointmentClientDiv).addClass("appointmentClient");
                $(appointmentClientDiv).text(this.clientName);
                appointmentDiv.appendChild(appointmentClientDiv);
            }

            if (position.height >= (hourHeight / 2 - 2 * appointmentTopBottomMargin)) {
                var appointmentTimeDiv = document.createElement("div");
                $(appointmentTimeDiv).addClass("appointmentTime");
                $(appointmentTimeDiv).text(appointmentTime);
                appointmentDiv.appendChild(appointmentTimeDiv);
            }

            $(appointmentDiv).contextmenu(function (e) {
                e.preventDefault();
                showAppointmentMenu(e, id);
            });
            day.appendChild(appointmentDiv);
        });
    };

    var getEmployees = function () {
        var employeeIds = [];
        $("#employeeSelect :selected").each(function () {
            employeeIds.push(this.value);
        });
        getAppointmentsParam.employees = employeeIds;
    };

    var getAppointments = function (forceCacheRefresh = false) {
        getEmployees();
        getAppointmentsParam.forceCacheRefresh = forceCacheRefresh;
        if (getAppointmentsParam.date == '') {
            getAppointmentsParam.date = $('#scheduleDatePicker').data('today').split(' ')[0];
        }

        if (getAppointmentsParam.employees.length < 1) {
            toastr.warning("Należy wybrać przynajmniej jednego pracownika.", "Uwaga");
            $(".selectize-input").addClass("invalid")
            return;
        }
        showScheduleLoadingDiv();

        $.post(config.urls.getAppointments, getAppointmentsParam, function (res) {
            removeDays();
            createTimeIntervals(res.startHour, res.endHour);
            setTitle(res.title);
            isWeekView = true;
            createDays(res.days);
            hideScheduleLoadingDiv();
        }, "json")
            .fail(function () {
                toastr.error("Nie udało się pobrać harmonogramu.", "Błąd");
            });
    };

    var showScheduleLoadingDiv = function () {
        $("#schedule").hide();
        $("#scheduleLoadingDiv").show();
    }

    var hideScheduleLoadingDiv = function () {
        $("#schedule").show();
        $("#scheduleLoadingDiv").hide();
    }

    var initDatePicker = function () {
        $("#scheduleDatePicker").flatpickr({
            locale: "pl",
            disableMobile: "true",
            onValueUpdate: function (selectedDates, dateStr, instance) {
                getAppointmentsParam.date = dateFormat(selectedDates[0]);
                getAppointments();
            }
        });
    };

    var initEmployeeSelect = function () {
        $("#employeeSelect").selectize({
            render: {
                item: function (data, escape) {
                    return '<div class="option" style="background-color: ' +
                        data.employeeColor +
                        ';"><b>' +
                        escape(data.text) +
                        '</b></div>';
                }
            },
            onBlur: function () {
                getAppointments();
            }
        });
    };

    var isAppointmentMenuHidden = function () {
        return $appointmentMenu.is(":hidden");
    };

    var hideAppointmentMenu = function () {
            $appointmentMenu.hide();
            $appointmentMenuId.val("");
    }

    $("#refreshButton").click(function () {
        getAppointments(true);
    })

    var initCancelAppointmetPopup = function () {
        var $confirmAppointmentId = $("#confirmAppointmentId");

        $("#cancelAppointmentOpt").click(function () {
            if ($(this).hasClass(disabledClass)) {
                return;
            }
            var appointmentId = $appointmentMenuId.val();
            var appointmentData = $("#appointment-" + appointmentId).data();
            $("#confirmAppointmentEmployee").text(appointmentData.employee);
            $("#confirmAppointmentDate").text(appointmentData.date);
            $("#confirmAppointmentTime").text(appointmentData.time);
            $("#confirmAppointmentService").text(appointmentData.service);
            $("#confirmAppointmentClient").text(appointmentData.client);
            $confirmAppointmentId.val(appointmentId);

            show($cancelAppointmentPopup);
            hideAppointmentMenu();
        });

        var hideCancelAppointmentPopup = function () {
            hide($cancelAppointmentPopup);
            $confirmAppointmentId.val("");
        };

        $cancelAppointmentPopup.find(".yes-btn").click(function () {
            var $button = $(this);
            $button.addClass(disabledClass);
            var url = config.urls.cancelAppointment;
            var appointmentId = $confirmAppointmentId.val();
            var param = { appointmentId: appointmentId };
            $.post(url, param, function (canceledId) {
                hideCancelAppointmentPopup();
                $("#appointment-" + canceledId).remove();
                $button.removeClass(disabledClass);
                toastr.success("Pomyślnie odwołano wizytę.", "Sukces");
            }, "json")
                .fail(function () {
                    $button.removeClass(disabledClass);
                    toastr.error("Odwołanie wizyty nie powiodło się.", "Błąd");
                });
        });

        $cancelAppointmentPopup.find(".no-btn").click(function () {
            hideCancelAppointmentPopup();
        });
    };

    var initCompleteAppointmentPopup = function () {
        var $standardPriceInput = $("#completeAppointmentStandardPrice");
        var $discountPercentInput = $("#completeAppointmentDiscountPercent");
        var $discountAmountInput = $("#completeAppointmentDiscountAmount");
        var $finalPriceInput = $("#completeAppointmentFinalPrice");
        var $completeAppointmentId = $("#completeAppointmentId");
        var $completeAppointmentResourceTable = $("#completeAppointmentResourceTable");
        var $completeBtn = $completeAppointmentPopup.find(".complete-btn");
        var $cancelBtn = $completeAppointmentPopup.find(".cancel-btn");
        var $addResourceBtn = $("#completeAppointmentResourceTableAddButton");

        const quantitiesDelimeter = '→';
        const sessionStorageResourcesKey = 'resources';
        const resourceUnits = ['ml', 'szt'];

        var appointmentId;
        var appointmentData;
        var appointmentServiceData;

        $("#completeAppointmentOpt").click(function () {
            if ($(this).hasClass(disabledClass)) {
                return;
            }
            appointmentId = $appointmentMenuId.val();
            appointmentData = $("#appointment-" + appointmentId).data();
            $("#completeAppointmentEmployee").text(appointmentData.employee);
            $("#completeAppointmentDate").text(appointmentData.date);
            $("#completeAppointmentTime").text(appointmentData.time);
            $("#completeAppointmentService").text(appointmentData.service);
            $("#completeAppointmentService").attr("title", appointmentData.service);
            $("#completeAppointmentClient").text(appointmentData.client);
            $completeAppointmentId.val(appointmentId);

            getAppointmentServiceData(appointmentId);
            showCompleteAppointmentLoadingDiv();
            show($completeAppointmentPopup);
            hideAppointmentMenu();
        });

        $completeBtn.click(function () {
            $completeBtn.addClass(disabledClass);

            if (validateCompleteAppointmentInputs() == false) {
                $completeBtn.removeClass(disabledClass);
                return;
            }

            var appointmentId = $completeAppointmentId.val();
            var resources = []

            $($completeAppointmentResourceTable.find('tr').slice(1)).each(function () {
                var $cells = $(this).find('td');
                var $inputs = $cells.eq(2).find('input');

                if ($inputs.length > 0) {
                    var resource = {
                        id: $cells.eq(0).text(),
                        usage: $inputs.eq(0).val().replace('.', ','),
                    }
                    resources.push(resource);
                }
            });

            var appointmentCompletionData = {
                appointmentId: appointmentId,
                standardPrice: $standardPriceInput.val(),
                finalPrice: $finalPriceInput.val(),
                resources: resources
            };

            $.post(config.urls.completeAppointment, appointmentCompletionData, function (completedId) {
                $("#appointment-" + completedId).data({
                    isCompleted: true,
                    standardPrice: appointmentCompletionData.standardPrice,
                    finalPrice: appointmentCompletionData.finalPrice
                });
                $("#appointment-" + completedId).addClass(completedClass);
                hideCompleteAppointmentPopup();
                clearCompleteAppointmentInputs();
                $completeBtn.removeClass(disabledClass);
                toastr.success("Pomyślnie zakończono wizytę.", "Sukces");
            }, "json")
                .fail(function () {
                    $completeBtn.removeClass(disabledClass);
                    toastr.error("Zakończenie wizyty nie powiodło się.", "Błąd");
                });
        });

        var hideCompleteAppointmentPopup = function () {
            hide($completeAppointmentPopup);
            $completeAppointmentId.val("");
        };

        var getAppointmentServiceData = function (appointmentId) {
            var param = { appointmentId: appointmentId };
            $.post(config.urls.getServiceData, param, function (result) {
                appointmentServiceData = result;
                initResourceTable(result.resources);
                initCompleteAppointmentInputs();
                hideCompleteAppointmentLoadingDiv();
            }, "json")
                .fail(function () {
                    toastr.error("Pobranie danych o usłudze nie powiodło się.", "Błąd");
                });
        }

        var initResourceTable = function (resources) {
            var $tableBody = $($completeAppointmentResourceTable.find("tbody"));
            $tableBody.empty();

            if (resources.length == 0) {
                var newRow = '<tr><td></td><td colspan="4"> Brak użytych zasobów </td></tr>';
                $tableBody.append(newRow);
            }

            for (var resource in resources) {
                var resourceUsed;

                if (resources[resource].usage > resources[resource].quantity) {
                    resourceUsed = resources[resource].quantity;
                } else {
                    resourceUsed = resources[resource].usage
                }

                var resourceLeft = resources[resource].quantity - resourceUsed;
                var newRow = '<tr><td>' + resources[resource].id
                    + '</td><td>' + resources[resource].name
                    + '</td><td><input class="form-control complete-appointment-resource-input" \
                            type="number" step="0.01" min="0.00" max="' + resources[resource].quantity + '" value="' + resourceUsed
                    + '"></td><td class="complete-appointment-resource-quantities">' + resources[resource].quantity + ' ' + quantitiesDelimeter + ' ' + resourceLeft
                    + '</td><td>' + resources[resource].unit
                    + '</td></tr>';
                $tableBody.append(newRow);
            }
        }

        var updateResourceTableQuantities = function ($row) {
            var $quantitiesCell = $row.find('.complete-appointment-resource-quantities');
            var usage = parseFloat(($row.find('.complete-appointment-resource-input').eq(0).val()));
            var quantity = parseFloat(($quantitiesCell.eq(0).text().split(quantitiesDelimeter)[0].trim()));
            var resourceLeft = Math.round((quantity - usage) * 100) / 100;

            $quantitiesCell.text(quantity + ' ' + quantitiesDelimeter + ' ' + resourceLeft);
        }

        var initCompleteAppointmentInputs = function () {
            $(document).on('keydown', '.complete-appointment-resource-input', function (e) {
                if (invalidNumericChars.includes(e.key)) {
                    e.preventDefault();
                }
            });

            $discountPercentInput.on("keydown", function (e) {
                if (invalidNumericChars.includes(e.key)) {
                    e.preventDefault();
                }
            });
            $discountAmountInput.on("keydown", function (e) {
                if (invalidNumericChars.includes(e.key)) {
                    e.preventDefault();
                }
            });
            $finalPriceInput.on("keydown", function (e) {
                if (invalidNumericChars.includes(e.key)) {
                    e.preventDefault();
                }
            });

            $(document).on('focusout', '.complete-appointment-resource-input', function () {
                var $input = $(this);

                if ($input.val() == '') {
                    $input.val(0);
                }

                if (parseFloat($input.val()) > parseFloat(($input.attr('max')))) {
                    $input.val($input.attr('max'));
                }

                updateResourceTableQuantities($(this.parentElement.parentElement));
            });

            $discountPercentInput.on("focusout", function (e) {
                var standardPrice = $standardPriceInput.val();
                var discountPercent = clampNumber($discountPercentInput.val(), 0, 100);
                var discountAmount = clampNumber((discountPercent / 100) * standardPrice, 0, standardPrice);
                $discountPercentInput.val(discountPercent);
                $discountAmountInput.val(toTwoDecimalPlaces(discountAmount));
                $finalPriceInput.val(toTwoDecimalPlaces(standardPrice - discountAmount));
            });
            $discountAmountInput.on("focusout", function (e) {
                var standardPrice = $standardPriceInput.val();
                if (standardPrice > 0) {
                    var discountAmount = clampNumber($discountAmountInput.val(), 0, standardPrice);
                    var discountPercent = clampNumber(Math.round((100 / standardPrice) * discountAmount), 0, 100);
                    $discountPercentInput.val(discountPercent);
                    $discountAmountInput.val(toTwoDecimalPlaces(discountAmount));
                    $finalPriceInput.val(toTwoDecimalPlaces(standardPrice - discountAmount));

                }
            });
            $finalPriceInput.on("focusout", function (e) {
                var standardPrice = $standardPriceInput.val();
                var finalPrice = $finalPriceInput.val();
                if (standardPrice > 0) {
                    var discountAmount = clampNumber(standardPrice - finalPrice, 0, standardPrice);
                    var discountPercent = clampNumber(Math.round((100 / standardPrice) * discountAmount), 0, 100);
                    $discountAmountInput.val(toTwoDecimalPlaces(discountAmount));
                    $discountPercentInput.val(discountPercent);
                    $finalPriceInput.val(toTwoDecimalPlaces(finalPrice));
                }
            });

            var standardPrice = appointmentServiceData.price.split(" ")[0].replace(',', '.');
            $standardPriceInput.val(standardPrice);
            $finalPriceInput.val(standardPrice);
        }

        var clearCompleteAppointmentInputs = function () {
            $standardPriceInput.val();
            $discountPercentInput.val(0);
            $discountAmountInput.val(0);
            $finalPriceInput.val();
        }

        var validateCompleteAppointmentInputs = function () {
            var result = true;

            if ($discountAmountInput.is(invalidSelector)) {
                result = false;
            }

            if ($discountPercentInput.is(invalidSelector)) {
                result = false;
            }

            if ($finalPriceInput.is(invalidSelector)) {
                result = false;
            }

            if ($('.complete-appointment-resource-input' + invalidSelector).length > 0) {
                result = false;
            }

            return result;
        }

        var showCompleteAppointmentLoadingDiv = function () {
            $("#completeAppointmentContent").hide();
            $("#completeAppointmentLoadingDiv").show();
            $completeBtn.addClass(disabledClass);
        }

        var hideCompleteAppointmentLoadingDiv = function () {
            $("#completeAppointmentContent").show();
            $("#completeAppointmentLoadingDiv").hide();
            $completeBtn.removeClass(disabledClass);
        }

        var addNewResourceRow = function ($button) {
            $button.addClass(disabledClass);
            var $resourceSelect = $('<select class="form-control complete-appointment-resource-select"></select>');
            var $resourceTableBody = $completeAppointmentResourceTable.find('tbody').eq(0);
            var alreadyAddedResourcesIds = $resourceTableBody.find('td:first-child').map(function () {
                var returnValue = $.trim($(this).text());
                if (returnValue == '') {
                    return null;
                } else {
                    return parseFloat(returnValue);
                }
            }).get();

            if (alreadyAddedResourcesIds.length == 0) {
                $resourceTableBody.empty();
            }

            $.post(config.urls.getResources, null, function (result) {
                var resources = result.resources;

                resources = resources.filter(function (el) {
                    return !alreadyAddedResourcesIds.includes(el.id);
                });

                sessionStorage.setItem(sessionStorageResourcesKey, JSON.stringify(resources));

                $(resources).each(function () {
                    $resourceSelect.append('<option value="' + this.id + '">' + this.name + '</option>');
                });

                var $newRow = $('<tr><td>' + $resourceSelect.val() + '</td><td>' +
                    $resourceSelect[0].outerHTML +
                    '</td><td><input class="form-control complete-appointment-resource-input" type="number" step="0.01" min="0.00" value="0">' +
                    '</td><td class="complete-appointment-resource-quantities">  </td><td>  </td>');

                $completeAppointmentResourceTable.find('tbody').append($newRow);
                updateNewResourceRow($newRow[0]);
                $button.removeClass(disabledClass);
            }, "json")
                .fail(function () {
                    $button.removeClass(disabledClass);
                    toastr.error("Nie udało się pobrać danych o zasobach.", "Błąd");
                });
        }

        var updateNewResourceRow = function (row) {
            var $cells = $(row).find('td');
            var $idCell = $cells.eq(0);
            var $quantityCell = $cells.eq(3);
            var $unitCell = $cells.eq(4);
            var $usageInput = $(row).find('.complete-appointment-resource-input').eq(0);
            var $resourceSelect = $(row).find('select').eq(0);
            var resourceData = JSON.parse(sessionStorage.getItem(sessionStorageResourcesKey)).find(x => x.id == $resourceSelect.val());
            var resourceQuantity = resourceData.quantity.replace(',', '.');

            $idCell.text($resourceSelect.val());
            $quantityCell.text(resourceQuantity);
            $unitCell.text(resourceUnits[resourceData.unit]);
            $usageInput.attr('max', resourceQuantity);

            if (parseFloat($usageInput.val()) > parseFloat(resourceQuantity)) {
                $usageInput.val(resourceQuantity);
            }

            updateResourceTableQuantities($(row));
        }

        $(document).on('change', '.complete-appointment-resource-select', function () {
            updateNewResourceRow(this.parentElement.parentElement);
        });

        $cancelBtn.click(function () {
            hideCompleteAppointmentPopup();
            clearCompleteAppointmentInputs();
        });

        $addResourceBtn.click(function () {
            addNewResourceRow($(this));
        });
    };

    var initAppointmentDetailsPopup = function () {
        var $appointmentDetailsId = $("#appointmentDetailsId");
        var $appointmentDetailsResourceTableDiv = $('#appointmentDetailsResourceTableDiv');
        var $appointmentDetailsResourceTable = $("#appointmentDetailsResourceTable")
        var $appointmentDetailsStandardPriceCell = $("#appointmentDetailsStandardPrice");
        var $appointmentDetailsDiscountCell = $("#appointmentDetailsDiscount");
        var $appointmentDetailsFinalPriceCell = $("#appointmentDetailsFinalPrice");

        $("#appointmentDetailsOpt").click(function () {
            if ($(this).hasClass(disabledClass)) {
                return;
            }

            var appointmentId = $appointmentMenuId.val();
            var appointmentData = $("#appointment-" + appointmentId).data();

            showAppointmentDetailsLoadingDiv();
            getAppointmentServiceData(appointmentId, appointmentData.isCompleted);

            $("#appointmentDetailsEmployee").text(appointmentData.employee);
            $("#appointmentDetailsDate").text(appointmentData.date);
            $("#appointmentDetailsTime").text(appointmentData.time);
            $("#appointmentDetailsService").text(appointmentData.service);
            $("#appointmentDetailsClient").text(appointmentData.client);

            if (appointmentData.isCompleted) {
                var standardPrice = toTwoDecimalPlaces(appointmentData.standardPrice);
                var finalPrice = toTwoDecimalPlaces(appointmentData.finalPrice);
                var discountAmount = toTwoDecimalPlaces(parseFloat(standardPrice) - parseFloat(finalPrice));
                var discountPercent = clampNumber(Math.round((100 / standardPrice) * discountAmount), 0, 100);

                $appointmentDetailsStandardPriceCell.text(standardPrice.replace('.', ',') + ' ' + currencyAbbr);
                $appointmentDetailsDiscountCell.text(discountAmount.replace('.', ',') + ' ' + currencyAbbr + ' (' + discountPercent + '%)');
                $appointmentDetailsFinalPriceCell.text(finalPrice.replace('.', ',') + ' ' + currencyAbbr);

                hide($appointmentDetailsResourceTableDiv);
                show($appointmentDetailsDiscountCell.parent());
                show($appointmentDetailsFinalPriceCell.parent());
            } else {
                show($appointmentDetailsResourceTableDiv);
                hide($appointmentDetailsDiscountCell.parent());
                hide($appointmentDetailsFinalPriceCell.parent());
            }

            $appointmentDetailsId.val(appointmentId);

            show($appointmentDetailsPopup);
            hideAppointmentMenu();
        });

        var getAppointmentServiceData = function (appointmentId, isAppointmentCompleted) {
            var param = { appointmentId: appointmentId };
            $.post(config.urls.getServiceData, param, function (result) {
                initResourceTable(result.resources);

                if (isAppointmentCompleted == false) {
                    $appointmentDetailsStandardPriceCell.text(result.price);
                }

                hideAppointmentDetailsLoadingDiv();
            }, "json")
                .fail(function () {
                    toastr.error("Pobranie danych o usłudze nie powiodło się.", "Błąd");
                });
        }

        var initResourceTable = function (resources) {
            var $tableBody = $($appointmentDetailsResourceTable.find("tbody"));
            $tableBody.empty();

            if (resources.length == 0) {
                var newRow = '<tr><td></td><td colspan="4"> Brak przypisanych zasobów </td></tr>';
                $tableBody.append(newRow);
            }

            for (const resource in resources) {
                var newRow = '<tr><td>' + resources[resource].id
                    + '</td><td>' + resources[resource].name
                    + '</td><td>' + resources[resource].usage
                    + '</td><td class="complete-appointment-resource-quantities">' + resources[resource].quantity
                    + '</td><td>' + resources[resource].unit
                    + '</td></tr>';
                $tableBody.append(newRow);
            }
        }

        var hideAppointmentDetailsPopup = function () {
            hide($appointmentDetailsPopup);
            clearServiceData();
            $appointmentDetailsId.val("");
        };

        var showAppointmentDetailsLoadingDiv = function () {
            $("#appointmentDetailsContent").hide();
            $("#appointmentDetailsLoadingDiv").show();
        }

        var hideAppointmentDetailsLoadingDiv = function () {
            $("#appointmentDetailsContent").show();
            $("#appointmentDetailsLoadingDiv").hide();
        }

        var clearServiceData = function () {
            var $tableBody = $($appointmentDetailsResourceTable.find("tbody"));
            $tableBody.empty();

            $appointmentDetailsStandardPriceCell.text('');
            $appointmentDetailsDiscountCell.text('');
            $appointmentDetailsFinalPriceCell.text('');

        }

        $appointmentDetailsPopup.find(".close-btn").click(function () {
            hideAppointmentDetailsPopup();
        });
    }

    var initAppointmentMenu = function () {
        window.addEventListener('click', function (e) {
            if (isAppointmentMenuHidden() || $appointmentMenu[0].contains(e.target)) {
                return;
            }

            hideAppointmentMenu();
        });

        initCancelAppointmetPopup();
        initCompleteAppointmentPopup();
        initAppointmentDetailsPopup();
    };

    var createSchedule = function () {
        getAppointments();
        initEmployeeSelect();
        initDatePicker();
        initAppointmentMenu();
    };

    var init = function () {
        createSchedule();
    };

    return {
        init: init
    };
};

