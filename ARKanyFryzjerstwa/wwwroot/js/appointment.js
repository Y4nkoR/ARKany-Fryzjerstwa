var Appointment = function (config) {
    var $formModal = $("#appointmentModal");
    var $formError = $("#appointmentError");
    var $formAppointmentClient = $("#appointmentClientList");
    var $formAppointmentPhoneNumber = $("#appointmentClientPhoneNumber");
    var $formAppointmentEmail = $("#appointmentClientEmail");
    var $formAppointmentDate = $("#appointmentDate");
    var $formAppointmentStartTime = $("#appointmentStartTime");
    var $formAppointmentEndTime = $("#appointmentEndTime");
    var $formAppointmentService = $("#appointmentServiceList");
    var $formAppointmentEmployee = $("#appointmentEmployeeSelect");
    var $formSubmitBtn = $("#appointmentSubmitBtn");
    var $formCancelBtn = $("#appointmentCancelBtn");
    var $confirmPopUp = $("#overlapConfirmPopUp");
    var $anonymousClientBox = $("#appointmentAnonymousClient");
    var $formClientData = $("#appointmentClientData");

    const minServiceDurationInMins = 5;
    const defaultAppointmentDate = "today";
    const defaultAppointmentStartTime = "12:00";
    const newInClass = "new-input";
    const invalidClass = "invalid";
    const invalidValueClass = "invalid-value";
    const invalidSelector = ":invalid";
    const hiddenAttr = "hidden";
    const disabledClass = "disabled";
    var appointmentData = {
        client: '',
        phoneNumber: '',
        email: '',
        isAnonymous: false,
        date: '',
        startTime: '',
        endTime: '',
        serviceId: '',
        employeeId: ''
    };

    var checkAppointmentOverlap = function () {
        if (validateInputs() == false) {
            $formSubmitBtn.attr("disabled", false);
            return;
        }

        appointmentData = {
            client: $formAppointmentClient.val(),
            phoneNumber: $formAppointmentPhoneNumber.val(),
            email: $formAppointmentEmail.val(),
            isAnonymous: $anonymousClientBox[0].checked,
            date: $formAppointmentDate.val(),
            startTime: $formAppointmentStartTime.val(),
            endTime: $formAppointmentEndTime.val(),
            serviceId: $formAppointmentService.val(),
            employeeId: $formAppointmentEmployee.val()
        };

        $.post(config.urls.doAppointmentsOverlap, appointmentData, function (areOverlaping) {
            if (areOverlaping) {
                $confirmPopUp.removeAttr(hiddenAttr);
            } else {
                createAppointment();
            }
        }, "json")
            .fail(function () {
                toastr.error("Sprawdzenie konfliktujących wizyt nie powiodło się.", "Błąd");
            });
    }

    var createAppointment = function () {
        $.post(config.urls.createAppointment, appointmentData, function (result) {
            $formModal.modal("hide");
            clearForm();
            $formSubmitBtn.attr("disabled", false);
            toastr.success("Pomyślnie dodano nową wizytę. Odśwież harmonogram, aby zobaczyć zmiany.", "Sukces");
        }, "json")
            .fail(function () {
                $formSubmitBtn.attr("disabled", false);
                toastr.error("Dodanie nowej wizyty nie powiodło się.", "Błąd");
            });
    };

    var fetchAppointmentCreationData = function () {

        $.post(config.urls.getAppointmentCreationData, function (creationData) {
            Object.keys(creationData.clients).forEach(function (key) {
                $formAppointmentClient[0].selectize.addOption({ value: key, text: creationData.clients[key] });
            })

            Object.keys(creationData.services).forEach(function (key) {
                $formAppointmentService[0].selectize.addOption({ value: creationData.services[key].id, text: creationData.services[key].name });
                delete creationData.services[key].name;
            })

            Object.keys(creationData.employees).forEach(function (key) {
                $formAppointmentEmployee[0].selectize.addOption({ value: key, text: creationData.employees[key] });
            })

            sessionStorage.setItem("services", JSON.stringify(creationData.services));
            hideLoadingDiv();
        }, "json")
            .fail(function () {
                toastr.error("Nie udało się pobrać danych potrzebnych do utworzenia nowej wizyty.", "Błąd");
            });
    }

    var fetchClientPhoneNumberAndEmail = function (clientId) {
        if (isNaN(clientId)) {
            return;
        }

        var clientData = {
            clientId: clientId
        }

        $.post(config.urls.getClientPhoneNumberAndEmail, clientData, function (result) {
            $formAppointmentPhoneNumber.val(result.phoneNumber);
            $formAppointmentEmail.val(result.email);
        }, "json")
            .fail(function () {
                toastr.error("Nie udało się pobrać danych klienta.", "Błąd");
            });
    };

    var setServiceEndTime = function () {
        serviceId = $formAppointmentService[0].value;
        startTime = $formAppointmentStartTime[0].value;
        var minsToAdd = minServiceDurationInMins;

        if (sessionStorage.getItem("services") != null && serviceId != '') {
            minsToAdd = JSON.parse(sessionStorage.getItem("services")).find(x => x.id == serviceId).duration;
        }

        var endTime = new Date(new Date("1970/01/01 " + startTime).getTime() + minsToAdd * 60000).
            toLocaleTimeString('pl-PL', { hour: '2-digit', minute: '2-digit', hour12: false });

        var minEndTime = new Date(new Date("1970/01/01 " + startTime).getTime() + minServiceDurationInMins * 60000).
            toLocaleTimeString('pl-PL', { hour: '2-digit', minute: '2-digit', hour12: false });

        $formAppointmentEndTime[0]._flatpickr.set("minTime", minEndTime);
        $formAppointmentEndTime[0]._flatpickr.setDate(endTime);
    }

    var clearForm = function () {
        $formAppointmentClient[0].selectize.clear();
        $formAppointmentClient[0].selectize.clearOptions();
        $formAppointmentPhoneNumber.val('');
        $formAppointmentEmail.val('');
        $formAppointmentDate[0]._flatpickr.setDate(defaultAppointmentDate);
        $formAppointmentStartTime[0]._flatpickr.setDate(defaultAppointmentStartTime);
        $formAppointmentEndTime[0]._flatpickr.clear();
        $formAppointmentService[0].selectize.clear();
        $formAppointmentEmployee[0].selectize.clear();
        $formError.text("");
        addClassToSelects(newInClass);
        $anonymousClientBox[0].checked = false;
        $formClientData.show();
    }

    var addClassToSelects = function (newClass) {
        $formAppointmentClient[0].selectize.$control.addClass(newClass);
        $formAppointmentService[0].selectize.$control.addClass(newClass);
        $formAppointmentEmployee[0].selectize.$control.addClass(newClass);
    }

    var validateInputs = function () {
        var result = true;

        if ($formAppointmentService[0].selectize.$control.hasClass(invalidClass)) {
            $formAppointmentService[0].selectize.$control.removeClass(newInClass);
            result = false;
        }

        if ($formAppointmentEmployee[0].selectize.$control.hasClass(invalidClass)) {
            $formAppointmentEmployee[0].selectize.$control.removeClass(newInClass);
            result = false;
        }

        if ($anonymousClientBox[0].checked) {
            return result;
        }

        if ($formAppointmentClient[0].selectize.$control.hasClass(invalidClass)) {
            $formAppointmentClient[0].selectize.$control.removeClass(newInClass);
            result = false;
        }
        
        return result && validateEmailAndPhoneNumber();
    }

    var validateEmailAndPhoneNumber = function () {
        var result = true;
        var errorMsg = "";
        $formError.text(errorMsg);

        if (!$formAppointmentPhoneNumber.val() && !$formAppointmentEmail.val()) {
            errorMsg += "Należy podać numer telefonu i/lub email klienta.\n";
            $formAppointmentPhoneNumber.addClass(invalidValueClass);
            $formAppointmentEmail.addClass(invalidValueClass);
            setTimeout(function () {
                $formAppointmentPhoneNumber.removeClass("invalid-value");
                $formAppointmentEmail.removeClass("invalid-value");
            }, 2000);
            result = false;
        } else {
            if ($formAppointmentPhoneNumber.val().length != 9
                && $formAppointmentPhoneNumber.val().length != 11
                && $formAppointmentPhoneNumber.val().trim().length > 0) {
                errorMsg += "Podano nieprawidłowy numer telefonu.\n";
                result = false;
            }

            if ($formAppointmentEmail.is(invalidSelector)
                && $formAppointmentEmail.val().trim().length > 0) {
                errorMsg += "Podano nieprawidłowy email.\n";
                result = false;
            }
        }

        $formError.text(errorMsg);
        return result;
    }

    var hideOverlapConfirmPopUp = function () {
        $confirmPopUp.attr(hiddenAttr, hiddenAttr);
    }

    var hideLoadingDiv = function () {
        $("#newAppointmentContentDiv").show();
        $("#newAppointmentLoadingDiv").hide();
        $formSubmitBtn.removeClass(disabledClass);
    }

    var initButtons = function () {
        $("#newAppointmentButton").click(function () {
            fetchAppointmentCreationData();
        });

        $formSubmitBtn.on('click', function () {
            $formSubmitBtn.attr("disabled", true);
            checkAppointmentOverlap();
        });

        $formCancelBtn.on('click', function () {
            clearForm();
        });

        $confirmPopUp.find(".no-btn").click(function () {
            hideOverlapConfirmPopUp();
            $formSubmitBtn.attr("disabled", false);
        });

        $confirmPopUp.find(".yes-btn").click(function () {
            createAppointment();
            hideOverlapConfirmPopUp();
        });
    };

    var initPhoneNumberInput = function () {
        $formAppointmentPhoneNumber.on("input", function () {
            this.value = this.value.replace(/[^0-9]/g, '');
        });
    }

    var initDateAndTimePickers = function () {
        $formAppointmentDate.flatpickr({
            locale: "pl",
            minDate: "today",
            defaultDate: defaultAppointmentDate,
            dateFormat: "Y.m.d",
        });
        $formAppointmentStartTime.flatpickr({
            enableTime: true,
            noCalendar: true,
            dateFormat: "H:i",
            defaultDate: defaultAppointmentStartTime,
            time_24hr: true,
            static: true,
            onChange: function (selectedTime, dateStr, instance) {
                setServiceEndTime();
            }
        });
        $formAppointmentEndTime.flatpickr({
            enableTime: true,
            noCalendar: true,
            dateFormat: "H:i",
            time_24hr: true,
            static: true
        });
    }

    var initSelects = function () {
        $formAppointmentClient.selectize({
            sortField: 'text',
            create: true,
            createFilter: /([A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ\- '])*/g,
            createOnBlur: true,
            onInitialize: function () {
                this.$control_input.prop('maxlength', 400)
                this.$control.addClass(newInClass);
                this.$control_input.on('input', function () {
                    this.value = this.value.replace(/[^A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ\- ']/g, '')
                })
            },
            maxItems: 1,
            allowEmptyOption: false,
            render: {
                option_create: function (data, escape) {
                    return '<div class="create">Dodaj <strong>' + escape(data.input) + '</strong>&hellip;</div>';
                }
            },
            onChange: function (value, isOnInitialize) {
                fetchClientPhoneNumberAndEmail(value);
            }
        });

        $formAppointmentService.selectize({
            sortField: 'text',
            maxItems: 1,
            allowEmptyOption: false,
            onInitialize: function () {
                this.$control.addClass(newInClass);
            },
            onChange: function (value, isOnInitialize) {
                setServiceEndTime();
            }
        });

        $formAppointmentEmployee.selectize({
            sortField: 'text',
            maxItems: 1,
            allowEmptyOption: false,
            onInitialize: function () {
                this.$control.addClass(newInClass);
            },
        });
    }

    var initAnonymousClient = function () {
        $anonymousClientBox.change(function () {
            if (this.checked) {
                $formClientData.hide();
            } else {
                $formClientData.show();
            }
        });
    };
    
    var init = function () {
        initButtons();
        initPhoneNumberInput();
        initDateAndTimePickers();
        initSelects();
        initAnonymousClient();
    };

    return {
        init: init
    }
}
