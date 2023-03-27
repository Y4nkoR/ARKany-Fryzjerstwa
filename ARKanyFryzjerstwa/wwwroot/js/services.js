var Services = function (config) {
    var $formModal = $("#serviceModal");
    var $formServiceName = $("#formServiceName");
    var $formServiceDuration = $("#formServiceDuration");
    var $formServicePrice = $("#formServicePrice");
    var $formServiceIsActive = $("#isServiceActive");
    var $serviceResourcesPopup = $("#serviceResourcesPopup");
    var $serviceResourcesLoadingDiv = $("#serviceResourcesLoadingDiv");
    var $serviceResourcesSelect = $("#serviceResourcesSelect");
    var $serviceResourcesContent = $("#serviceResourcesContent");
    var $serviceResourcesPopupServiceName = $("#serviceResourcesPopupServiceName");
    var $serviceResourcesPopupServiceId = $("#serviceResourcesPopupServiceId");
    var $serviceResourcesPopupCancelBtn = $("#serviceResourcesPopupCancelBtn");
    var $serviceResourcesPopupSaveBtn = $("#serviceResourcesPopupSaveBtn");
    var $resourcesUsageBody = $("#resourcesUsageBody");
    var $resourcesUsegeEditor = $("#resourcesUsegeEditor");
    var allSalonResources = [];
    var serviceTable;
    var showOnlyLowServices = false;
    var hasSalonResources = false;
    const newInClass = "new-input";
    const invalidClass = "invalid";
    const invalidValueClass = "invalid-value";
    const animRowClass = "anim-row";
    const inEditModeClass = "inEditMode";
    const invalidChars = ['-', '+', 'e', 'E'];
    const rowActiveClass = 'service-table-row-active';
    const serviceResourceOptIdName = "serviceResourceOpt_";
    const serviceResourceRowIdName = "serviceResourceRow_";
    const activeIco = '<i class="fa-solid fa-check anim-icon table-icons" style="color:green" title="Tak">Tak</i>';
    const inactiveIco = '<i class="fa-solid fa-xmark anim-icon table-icons" style="color:red" title="Nie">Nie</i>';
    const emptyResourcesTableRow = '<tr id="emptyServiceResourcesTableInfo"><td></td><td colspan="4"> Brak przypisanych zasobów </td></tr>';

    $(function () {
        initServiceTable();
    });

    var addService = function (button) {
        var $button = $(button);
        var $inputs = $([
            $formServiceName,
            $formServiceDuration,
            $formServicePrice,
            $formServiceIsActive
        ]);
        if (validateInputs($inputs) == false) {
            return;
        }

        $button.css("pointer-events", "none");

        var serviceData = {
            id: '',
            name: $formServiceName.val(),
            duration: $formServiceDuration.val(),
            price: $formServicePrice.val().replace('.', ','),
            isActive: $formServiceIsActive.prop("checked")
        };
        $.post(config.urls.addNewService, serviceData, function (result) {
            var status = result.isActive ? activeIco : inactiveIco;
            var title = result.isActive ? "Tak" : "Nie";
            var $newRow = $('<tr id="service-' + result.id + '"><td class="service-id">' +
                result.id + '<td class="service-name">' +
                result.name + '</td><td class="service-duration text-center">' +
                result.duration + '</td><td class="service-price text-center">' +
                result.price + '</td><td class="service-isActive text-center" title="' + title +'">' +
                status +
                '</td><td class="service-btns text-center">' +
                '<i class="fa-solid fa-pen anim-icon table-icons service-edit-btn" title="Edytuj"></i>' +
                '<i class="fa-solid fa-floppy-disk anim-icon table-icons service-save-btn" style="display: none" title="Zapisz"></i>' +
                '<i class="fa-solid fa-xmark anim-icon table-icons service-cancel-btn" style="display: none" title="Anuluj"></i>' +
                '<i class="fa-solid fa-repeat anim-icon table-icons service-change-btn" title="Zmień status"></i>' + 
                '<i class="fa-solid fa-spray-can-sparkles anim-icon table-icons service-resources-btn" title="Zasoby przypisane do usługi"></i>'
            );

            checkRowStatus($newRow);

            $formModal.modal("hide");
            serviceTable.row.add($newRow).draw().show().draw(false);
            $newRow.addClass(animRowClass);
            setTimeout(function () { $newRow.removeClass(animRowClass) }, 2000);
            clearForm();
            $button.css("pointer-events", "auto");
            toastr.success("Pomyślnie zapisano dane.", "Sukces");
        }, "json")
            .fail(function () {
                $button.css("pointer-events", "auto");
                toastr.error("Zapisanie danych nie powiodło się.", "Błąd");
            });
    }

    var enableServiceEdit = function (button) {
        var row = button.parentElement.parentElement;
        $(row).addClass(inEditModeClass);
        createInputsInRow(row);
        toggleRowButtonsVisibility(row);
    }

    var cancelServiceEdit = function (button) {
        var $row = $(button.parentElement.parentElement);
        var $cells = $($row.find('td'));
        serviceTable.cell($cells.eq(1)).data($cells.eq(1).find("input")[0].defaultValue);
        serviceTable.cell($cells.eq(2)).data($cells.eq(2).find('.servicesTableInput').attr('name'));
        serviceTable.cell($cells.eq(3)).data($cells.eq(3).find("input")[0].defaultValue.replace(".", ",")+" zł");
        var status;
        if ($cells.eq(4).find('.form-check-input').attr('name') == "active") {
            status = activeIco;          
        }
        else {
            status = inactiveIco;
        }
        serviceTable.cell($cells.eq(4)).data(status);
  
        $row.removeClass(inEditModeClass);
        toggleRowButtonsVisibility($row[0]);
    }

    var updateService = function (button) {
        var $row = $(button.parentElement.parentElement);
        var $buttonCell = $(button.parentElement);
        var $cells = $($row.find('td'));

        var $inputs = $([
            $cells.eq(1).find("input").eq(0),
            $cells.eq(2).find("input").eq(0),
            $cells.eq(3).find("input").eq(0),
            $cells.eq(4).prop("checked"),
        ]);

        if (validateInputs($inputs) == false) {
            return;
        }

        $buttonCell.css("pointer-events", "none");
        var $cells = $($row.find('td'));
        var $nameCell = $cells.eq(1);
        var $durationCell = $cells.eq(2);
        var $priceCell = $cells.eq(3);
        var $isActiveCell = $cells.eq(4);

        var serviceData = {
            id: $cells.eq(0).text(),
            name: $nameCell.find('input').val(),
            duration: $durationCell.find('input').val(),
            price: $priceCell.find('input').val().replace('.', ','),
            isActive: $isActiveCell.find('.form-check-input').prop("checked")
        };
        $.post(config.urls.updateService, serviceData, function (result) {
            serviceTable.cell($nameCell).data(result.name);
            serviceTable.cell($durationCell).data(result.duration);
            serviceTable.cell($priceCell).data(result.price);
            if (result.isActive == true) {
                var status = activeIco;
                serviceTable.cell($isActiveCell).data(status);
            }
            else {
                var status = inactiveIco;
                serviceTable.cell($isActiveCell).data(status);
            }
            checkRowStatus($row);

            serviceTable.row($row).draw().show().draw(false);
            $row.addClass(animRowClass);
            $row.removeClass(inEditModeClass);
            setTimeout(function () { $row.removeClass(animRowClass) }, 2000);

            $buttonCell.css("pointer-events", "auto");

            toggleRowButtonsVisibility($row[0]);
            toastr.success("Pomyślnie zapisano dane.", "Sukces");
        }, "json")
            .fail(function () {
                $buttonCell.css("pointer-events", "auto");
                toastr.error("Zapisanie danych nie powiodło się.", "Błąd");
            });
    }

    var changeStatusOfService = function (button) {

        var $button = $(button);
        $button.css("pointer-events", "none");
        var $row = $(button.parentElement.parentElement);
        var $cells = $($row.find('td'));
        var $nameCell = $cells.eq(1);
        var $durationCell = $cells.eq(2);
        var $priceCell = $cells.eq(3);
        var $isActiveCell = $cells.eq(4);
        var status;
        if ($isActiveCell.find('.fa-check').hasClass('fa-check')) {
            status = false;
        }
        if ($isActiveCell.find('.fa-xmark').hasClass('fa-xmark')) {
            status = true;
        }
        var serviceData = {
            id: $cells.eq(0).text(),
            name: $nameCell.text(),
            duration: $durationCell.text(),
            price: $priceCell.text().replace(' zł', '').replace(",", "."),
            isActive: status
        }
        $.post(config.urls.updateService, serviceData, function (result) {
            var changedStatus;
            if (result.isActive == true) {
                changedStatus = activeIco;
            }
            if (result.isActive == false) {
                changedStatus = inactiveIco;
            }
            serviceTable.cell($isActiveCell).data(changedStatus);
            checkRowStatus($row);

            serviceTable.row($row).draw().show().draw(false);
            $row.addClass(animRowClass);
            setTimeout(function () { $row.removeClass(animRowClass) }, 2000);
            $button.css("pointer-events", "auto");
            toastr.success("Pomyślnie zmieniono status usługi", "Sukces");
        })
            .fail(function () {
                $button.css("pointer-events", "auto");
                toastr.error("Zmiana statusu nie powiodła się.", "Błąd");
            });
    }

    var changeStatusOfSelectedServices = function () {
        $serviceRemoveSelectedBtn = $("serviceRemoveSelectedBtn");
        $serviceRemoveSelectedBtn.css("pointer-events", "none");
        $('.serviceRemoveSelectedBtn').attr('disabled', true);
        var selectedRows = serviceTable.rows({ selected: true });
        var $selectedRowsData = $(selectedRows.data());
        var servicesData = {
            services: []
        };

        $selectedRowsData.each(function () {
            var status = this[4].includes("fa-xmark");
            var serviceData = {
                id: this[0],
                name: this[1],
                duration: this[2],
                price: this[3].replace(' zł', '').replace(",", "."),
                isActive: status
            }
            servicesData.services.push(serviceData);
        });

        $.post(config.urls.updateServices, servicesData, function (results) {
            $selectedRows = $(selectedRows);

            $(results).each(function () {
                var changedStatus = this.isActive ? activeIco : inactiveIco;
                var $rowCell = $("#service-" + this.id + " > td.service-isActive");
                serviceTable.cell($rowCell).data(changedStatus);
                checkRowStatus($("#service-" + this.id));
            });
            
            toastr.success("Pomyślnie zmieniono status wybranych usług.", "Sukces");
            $serviceRemoveSelectedBtn.css("pointer-events", "auto");
        })
            .fail(function () {
                toastr.error("Zmiana statusu wybranych usług nie powiodła się.", "Błąd");
                $serviceRemoveSelectedBtn.css("pointer-events", "auto");
                $('.serviceRemoveSelectedBtn').attr('disabled', false);
            });
    }

    var createInputsInRow = function (row) {
        var cells = $(row).find('td');
        var $nameCell = $(cells[1]);
        var $durationCell = $(cells[2]);
        var $priceCell = $(cells[3]);
        var $isActiveCell = $(cells[4]);

        var $nameInput = $("<input>");
        $nameInput.attr("value", $nameCell.text());
        $nameInput.attr("type", "text");
        $nameInput.addClass("servicesTableInput form-control expandable");
        $nameInput.addClass(newInClass);
        $nameInput.prop("required", true);
        $nameCell.empty();
        $nameCell.append($nameInput);

        var $durationInput = $("<input>");
        var duration = $durationCell.text();
        $durationInput.addClass("servicesTableInput text-center form-control");
        $durationInput.addClass(newInClass);
        $durationInput.attr("name", $durationCell.text());
        $durationInput.prop("required", true);
        
        $durationCell.empty();
        $durationCell.append($durationInput);
        $durationInput.flatpickr({
            enableTime: true,
            noCalendar: true,
            dateFormat: "H:i",
            time_24hr: true,
            defaultDate: duration,
            minTime: "00:10",
            maxTime: "05:00",
            onOpen: function (selectedDates, dateStr, instance) {
                var dateToSet = dateStr.trim() ? dateStr : "00:10";
                instance.setDate(dateToSet);
            },
            onClose: function (selectedDates, dateStr, instance) {
                var duration = dateStr.trim();
                if (!duration || duration < '00:10') {
                    $durationInput.addClass(invalidClass);
                } else {
                    $durationInput.removeClass(invalidClass);
                }
            }
        });

        var $priceInput = $("<input>");
        $priceInput.attr("value", $priceCell.text().replace(' zł', '').replace(",", "."));
        $priceInput.attr("type", "number");
        $priceInput.attr("step", "0.01");
        $priceInput.attr("min", "0.0");
        $priceInput.attr("max", "9999.9");
        $priceInput.addClass("servicesTableInput text-center form-control");
        $priceInput.addClass(newInClass);
        $priceInput.prop("required", true)
        $priceCell.empty();
        $priceCell.append($priceInput);
        $priceCell.on("keydown", function (e) {
            if (invalidChars.includes(e.key)) {
                e.preventDefault();
            }
        });

        var $isActiveInput = $("<input>");
        $isActiveInput.attr("type", "checkbox");
        if ($isActiveCell.find('.fa-check').hasClass('fa-check')) {
            
            $isActiveInput.prop('checked', true);
            $isActiveInput.attr("name", "active");
        }
        else {
            $isActiveInput.attr("name", 'inactive');
        }
        $isActiveInput.addClass("servicesTableInput form-check-input ");
        $isActiveInput.addClass(newInClass);
        $isActiveCell.empty();
        $isActiveCell.append($isActiveInput);
    }

    var validateInputs = function ($inputs) {
        const invalidSelector = ":invalid";
        var result = true;
        if ($inputs[0].eq(0).is(invalidSelector)) {
            result = false;
            $inputs[0].eq(0).removeClass(newInClass);
        }
        if ($inputs[2].eq(0).is(invalidSelector)) {
            result = false;
            $inputs[2].eq(0).removeClass(newInClass);
        }
        if ($inputs[1].eq(0).hasClass(invalidClass) || $inputs[1].eq(0).val() < '00:10') {
            result = false;
            $inputs[1].eq(0).removeClass(newInClass);
            $inputs[1].eq(0).addClass(invalidValueClass);
            setTimeout(function () {
                $inputs[1].eq(0).removeClass("invalid-value");
            }, 2000);
            
        }
        return result;
    }

    var toggleRowButtonsVisibility = function (row) {
        var $btns = $(row).find(".service-btns > svg");
        $btns.toggle();
    }

    var clearForm = function () {
        $formServiceName.val("");
        $formServiceDuration.val("00:10");
        $formServicePrice.val(0);
        $formServiceIsActive.prop('checked',true);
        addClassToInputs(newInClass);
    }

    var addClassToInputs = function (classToAdd) {
        $formServiceName.addClass(classToAdd);
        $formServiceDuration.addClass(classToAdd);
        $formServicePrice.addClass(classToAdd);
    }

    var showLoadingDiv = function () {
        $("#servicesContentDiv").hide();
        $("#servicesLoadingDiv").show();
    }

    var hideLoadingDiv = function () {
        $("#servicesContentDiv").show();
        $("#servicesLoadingDiv").hide();
    }

    var checkRowStatus = function ($row) {
        var $cells = $($row.find('td'));
        var isActive = $cells.eq(4).find('.fa-check').hasClass('fa-check');
        if (isActive == true) {
            $row.addClass(rowActiveClass);
        } else {
            $row.removeClass(rowActiveClass);
        }
    }

    var initServiceButtons = function () {
        $(document).on('click', '.service-edit-btn', function () {
            enableServiceEdit(this);
        });

        $(document).on('click', '.service-save-btn', function () {
            updateService(this);
        });

        $(document).on('click', '.service-cancel-btn', function () {
            cancelServiceEdit(this);
        });

        $(document).on('click', '.service-change-btn', function () {
            changeStatusOfService(this);
        });

        $(document).on('click', '.service-resources-btn', function () {
            openServiceResourcesPopup(this);
        });

        $("#serviceAddBtn").click(function () {
            addService(this);
        });

        $("#serviceCancelBtn").click(function () {
            clearForm();
        });
    }

    var initForm = function () {
        $formServiceDuration.flatpickr({
            enableTime: true,
            noCalendar: true,
            dateFormat: "H:i",
            time_24hr: true,
            defaultDate: "00:10",
            minTime: "00:10",
            maxTime: "05:00",
            onOpen: function (selectedDates, dateStr, instance) {
                var dateToSet = dateStr.trim() ? dateStr : "00:10";
                instance.setDate(dateToSet);
            },
            onClose: function (selectedDates, dateStr, instance) {
                var duration = dateStr.trim();
                if (!duration || duration < '00:10') {
                    $formServiceDuration.addClass(invalidClass);
                } else {
                    $formServiceDuration.removeClass(invalidClass);
                }
            }
        });
        $formServicePrice.on("keydown", function (e) {
            if (invalidChars.includes(e.key)) {
                e.preventDefault();
            }
        });
    }

    var initServiceTable = function () {
        serviceTable = $('#servicesTable').DataTable({
            language: {
                url: config.urls.ROOT + '/lib/DataTables/pl.json',
                searchBuilder: {
                    title: {
                        '_': '<h5>Zaawansowane wyszukiwanie</h5>',
                        '0': '<h5>Zaawansowane wyszukiwanie</h5>'
                    },
                },
                select: {
                    rows: {
                        _: 'Wybranych wierszy: <b>%d</b>',
                        0: '',
                    },
                    columns: {
                        _: '',
                        0: '',
                        1: ''
                    },
                    cells: {
                        _: '',
                        0: '',
                        1: ''
                    }
                },
                search: ''
            },
            paging: true,
            ordering: true,
            searching: true,
            autoWidth: false,
            select: true,
            dom: '<"#tableTopRow.container-fluid"\
                    <"row"\
                        <"col-12 col-xl-9 py-1"\
                            <"tableButtons row"B>\
                        >\
                        <"col-12 col-xl-3 d-flex justify-content-center justify-content-xl-center align-items-center py-2"\
                            <"row w-100"\
                                <"col d-flex justify-content-center justify-content-xl-end align-items-center"f>\
                                <"col-1 col-xl-2 d-flex justify-content-center justify-content-xl-center align-items-center"\
                                    <"#tableAdvSearchButtonDiv">\
                                >\
                            >\
                        >\
                    >\
                    <"row"\
                        <"#advSearch.col collapse"Q>\
                    >\
                    <hr>\
                > rt \
                <"container-fluid" \
                    <"row"\
                        <"col-12 col-xl-4 py-1 order-2 order-xl-1 d-flex align-items-center justify-content-center justify-content-xl-start"i>\
                        <"col-12 col-xl-4 py-1 order-1 order-xl-2 d-flex align-items-center justify-content-center"p>\
                        <"col-12 col-xl-4 py-1 order-3 order-xl-3 d-flex align-items-center justify-content-center justify-content-xl-end"l>\
                    >\
                > ',
            buttons: {
                buttons: [],
            },
            columnDefs: [
                { orderable: false, targets: 5 },
                { searchable: false, targets: 0 }
            ],
            searchBuilder: {
                columns: [1, 2, 3, 4]
            },
            select: {
                style: 'multi',
                selector: 'tr:not(".inEditMode") td:not(:last-child)',
                items: 'row'
            },
            "initComplete": function (settings, json) {
                initServiceTableButtons();
                initActiveServiceSearch();
                hideLoadingDiv();
            }
        });

        var initServiceTableButtons = function () {
            var $tableButtonsDiv = $('.tableButtons');
            $tableButtonsDiv.empty();

            new $.fn.dataTable.Buttons(serviceTable, {
                name: 'addServiceButton',
                buttons: [
                    {
                        text: config.txts.addBtn,
                        attr: {
                            'data-bs-toggle': 'modal',
                            'data-bs-target': '#serviceModal'
                        },
                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-primary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(serviceTable, {
                name: 'selectVisibleButton',
                buttons: [
                    {
                        text: config.txts.selectVisibleBtn,
                        action: function (e, dt, button, config) {
                            dt.rows({ page: 'current' }).select();
                        }
                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-secondary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(serviceTable, {
                name: 'deselectAllButton',
                buttons: [
                    {
                        extend: 'selectNone',
                        text: config.txts.deselectAllBtn

                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-secondary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(serviceTable, {
                name: 'changeStatusOfSelectedButton',
                buttons: [
                    {
                        text: config.txts.changeStatusOfSelectedBtn,
                        className: 'serviceChangeStatusOfSelectedBtn',
                        attr: {
                            'disabled': 'true',
                        },
                        action: function (e, dt, node, config) {
                            changeStatusOfSelectedServices();
                        }
                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-secondary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(serviceTable, {
                name: 'exportButtons',
                buttons: [
                    {
                        extend: 'collection',
                        text: 'Eksportuj',
                        buttons: [
                            {
                                extend: 'copyHtml5',
                                exportOptions: {
                                    columns: [1, 2, 3, 4]
                                },
                            },
                            {
                                extend: 'excelHtml5',
                                exportOptions: {
                                    columns: [1, 2, 3, 4],
                                    format: {
                                        body: function (data, row, column, node) {
                                            data = $('<p>' + data + '</p>').text();
                                            return $.isNumeric(data.replace(',', '.')) ? data.replace(',', '.') : data;
                                        }
                                    }
                                },
                            },
                            {
                                extend: 'pdfHtml5',
                                exportOptions: {
                                    columns: [1, 2, 3, 4]
                                },
                            },
                            {
                                extend: 'print',
                                exportOptions: {
                                    columns: [0, 1, 2, 3, 4]
                                },
                            },
                        ]
                    }
                ],
                dom: {
                    button: {
                        className: 'btn btn-secondary'
                    },
                },
            });

            // AddService button
            var $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-2 px-2 py-1');
            serviceTable.buttons('addServiceButton', null).container().addClass('w-100 service-table-btn-group');
            $buttonsGroupCol.append(serviceTable.buttons('addServiceButton', null).container());
            $tableButtonsDiv.append($buttonsGroupCol);

            // Selection buttons
            $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-7 px-2 py-1 h-100');
            var $buttonsRow = $('<div>');
            $buttonsRow.addClass('row w-100')

            var $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0');
            serviceTable.buttons('selectVisibleButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(serviceTable.buttons('selectVisibleButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0 px-sm-1');
            serviceTable.buttons('deselectAllButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(serviceTable.buttons('deselectAllButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0');
            serviceTable.buttons('changeStatusOfSelectedButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(serviceTable.buttons('changeStatusOfSelectedButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupCol.append($buttonsRow);
            $tableButtonsDiv.append($buttonsGroupCol);

            // Export buttons
            $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-2 px-2 py-1');
            serviceTable.buttons('exportButtons', null).container().find('.btn-group').addClass('w-100 service-table-btn-group');
            serviceTable.buttons('exportButtons', null).container().addClass('w-100 service-table-btn-group');

            $buttonsGroupCol.append(serviceTable.buttons('exportButtons', null).container());
            $tableButtonsDiv.append($buttonsGroupCol);

            // Advanced search
            var $advSearchDiv = $('#advSearch');
            var $advSearchBtn = $("<button>");
            var $AdvSearchButtonDiv = $("#tableAdvSearchButtonDiv");

            $advSearchBtn.attr('title', 'Wyszukiwanie zaawansowane');
            $advSearchBtn.append('<i class="fa-solid fa-chevron-down"></i>');
            $advSearchBtn.addClass('btn btn-outline-secondary');
            $advSearchBtn.on('click', function () {
                $advSearchDiv.collapse("toggle");
            })

            $advSearchDiv.on("hide.bs.collapse", function () {
                $advSearchBtn.html('<i class="fa-solid fa-chevron-down"></i>');
            });
            $advSearchDiv.on("show.bs.collapse", function () {
                $advSearchBtn.html('<i class="fa-solid fa-chevron-up"></i>');
            });

            $advSearchDiv.prepend('<hr>');
            $AdvSearchButtonDiv.append($advSearchBtn);

            // Show only low checkbox
            var $tableTopRow = $('#tableTopRow');
            var $checkboxDiv = $('<div class="d-flex align-items-center py-1">');
            var $checkbox = $('<input id="showOnlyLowCheckbox" type="checkbox">');
            var $label = $('<label class="fw-bold" for="showOnlyLowCheckbox">' + config.txts.showLowServicesCheckbox + '</label>')

            $checkbox.on('change', function () {
                showOnlyLowServices = $(this).prop('checked');
                serviceTable.draw();
            })

            $checkboxDiv.append($checkbox);
            $checkboxDiv.append($label);
            $tableTopRow.append($checkboxDiv)
        }

        var initActiveServiceSearch = function () {
            $.fn.dataTable.ext.search.push(function (settings, data, dataIndex) {
                if (showOnlyLowServices == true) {
                    var $row = $(serviceTable.rows(dataIndex).nodes());

                    if ($row.hasClass(rowActiveClass)) {
                        return true;
                    }
                    return false;
                } else {
                    return true;
                }
            });
        }

        serviceTable.on('select', function (e, dt, type, indexes) {
            if (type === 'row') {
                $('.serviceChangeStatusOfSelectedBtn').removeAttr('disabled');
            }
        });
        serviceTable.on('deselect', function (e, dt, type, indexes) {
            if (serviceTable.rows({ selected: true }).count() == 0) {
                $('.serviceChangeStatusOfSelectedBtn').attr('disabled', true);
            }
        });
    }

    // service resources

    var initServiceResourcesPopup = function () {
        $serviceResourcesPopupCancelBtn.click(function () {
            closeServiceResourcesPopup();
        });

        $serviceResourcesPopupSaveBtn.click(function () {
            saveServiceResources();
        });

        $(document).on('click', '.remove-resource-btn', function () {
            removeServiceResource($(this).data('id'));
        });
    };

    var initServiceResourcesTable = function (resources) {
        $resourcesUsageBody.empty();

        if (resources.length == 0) {
            $resourcesUsageBody.append(emptyResourcesTableRow);
        }

        $(resources).each(function () {
            let resourceId = this.id;
            let resourceUsage = this.usage;
            var newRow = getResourceRow(resourceId, resourceUsage);
            $resourcesUsageBody.append(newRow);
            $("#" + serviceResourceOptIdName + resourceId).prop("disabled", true);
        });
    }

    var getResourceRow = function (id, usage) {
        var current = allSalonResources.filter(x => { return x.id == id })[0];
        let $newResourceRow = $("<tr>").attr("id", serviceResourceRowIdName + id);
        $newResourceRow.append("<td>" + id + "</td>");
        $newResourceRow.append("<td>" + current.name + "</td>");
        let $usageTd = $("<td>");
        let $usageInput = $("<input class='form-control service-resource-usage-input' type='number' min='0.00' max='9999.99' step='0.01' value='" + usage + "' />");
        $usageInput.keydown(function (e) {
            if (invalidChars.includes(e.key)) {
                e.preventDefault();
            }
        });
        $usageInput.keyup(function () {
            if ($usageInput.val().match(/\.[0-9]{3,}/g)) {
                $usageInput.val(parseFloat($usageInput.val()).toFixed(2));
            }
        });
        $usageInput.on('paste', function () {
            return false;
        });
        $usageTd.append($usageInput);
        $newResourceRow.append($usageTd);
        $newResourceRow.append("<td>" + current.unit + "</td>")
        let $removeResourceBtn = $("<td><i data-id='" + id + "' class='fa-solid fa-xmark anim-icon table-icons remove-resource-btn' title='Usuń przypisanie'></i></td>");
        $newResourceRow.append($removeResourceBtn);
        return $newResourceRow;
    }

    var getAllResources = function () {
        $.ajax({
            type: "POST",
            url: config.urls.getSalonResources,
            data: null,
            success: function (result) {
                hasSalonResources = true;
                allSalonResources = result;
                $(result).each(function () {
                    $serviceResourcesSelect.append('<option id="' + serviceResourceOptIdName + this.id + '" class="service-resource-opt" value="' + this.id + '">' + this.name + '</option>');
                });
                $serviceResourcesSelect.val([]);
            },
            dataType: "json",
            async: false,
            error: function () {
                hasSalonResources = false;
                toastr.error("Pobranie danych o istniejących zasobach nie powiodło się.", "Błąd");
            }
        });

        $serviceResourcesSelect.change(function () {
            var resourceId = $serviceResourcesSelect.val();
            let newResourceRow = getResourceRow(resourceId, 0);
            $("#emptyServiceResourcesTableInfo").remove();
            $resourcesUsageBody.append(newResourceRow);
            $("#" + serviceResourceOptIdName + resourceId).prop("disabled", true);
            $serviceResourcesSelect.val([]);
        });
    };

    var openServiceResourcesPopup = function (button) {
        var $row = $(button.parentElement.parentElement);
        var $cells = $($row.find('td'));
        var name = $cells.eq(1).text();
        $serviceResourcesPopupServiceName.text(name);
        $serviceResourcesPopupServiceName.attr('title', name);

        showServiceResourcesLoading(true);
        $serviceResourcesPopup.show();

        var id = $cells.eq(0).text();
        $serviceResourcesPopupServiceId.val(id);

        if (!hasSalonResources) {
            getAllResources();
        } else {
            $("option.service-resource-opt").prop("disabled", false);
        }

        if (!hasSalonResources) {
            showServiceResourcesLoading(false);
            return false;
        }

        var params = {
            serviceId: id
        };
        $.post(config.urls.getServiceResources, params, function (result) {
            initServiceResourcesTable(result);
            showServiceResourcesLoading(false);
        }, "json")
            .fail(function () {
                toastr.error("Pobranie danych o zasobach przypisanych do usługi nie powiodło się.", "Błąd");
                showServiceResourcesLoading(false);
            });
    }

    var closeServiceResourcesPopup = function () {
        $serviceResourcesPopup.hide();
        clearPopupData();
    }

    var clearPopupData = function () {
        $serviceResourcesPopupServiceId.val(null);
        $serviceResourcesPopupServiceName.text(null);
        $serviceResourcesPopupServiceName.attr('title', null);
        $("option.service-resource-opt").prop("disabled", true);
    }

    var showServiceResourcesLoading = function (show) {
        const disabled = 'disabled';
        if (show) {
            $serviceResourcesPopupSaveBtn.addClass(disabled);
            $serviceResourcesPopupCancelBtn.addClass(disabled);
            $serviceResourcesContent.hide();
            $resourcesUsegeEditor.hide();
            $serviceResourcesLoadingDiv.show();
        } else {
            $serviceResourcesLoadingDiv.hide();
            $resourcesUsegeEditor.show()
            $serviceResourcesContent.show();
            $serviceResourcesPopupSaveBtn.removeClass(disabled);
            $serviceResourcesPopupCancelBtn.removeClass(disabled);
        }
    } 

    var animServiceRow = function (serviceId) {
        let $serviceRow = $("#service-" + serviceId);
        $serviceRow.addClass(animRowClass);
        setTimeout(function () { $serviceRow.removeClass(animRowClass) }, 2000);
    };

    var saveServiceResources = function () {
        showServiceResourcesLoading(true);
        $("#emptyServiceResourcesTableInfo").remove();
        var id = $serviceResourcesPopupServiceId.val();
        var resources = [];
        $resourcesUsageBody.children().each(function () {
            let obj = {
                id: this.children[0].textContent,
                usage: this.children[2].children[0].value.replace('.', ',')
            };
            resources.push(obj);
        });
        var params = {
            serviceId: id,
            resources: resources
        };
        $.post(config.urls.saveServiceResources, params, function (result) {
            closeServiceResourcesPopup();
            animServiceRow(id);
            toastr.success("Pomyślnie zapisano dane.", "Sukces");
        }, "json")
            .fail(function () {
                setEmptyInfoTable();
                showServiceResourcesLoading(false);
                toastr.error("Zapisanie danych o zasobach przypisanych do usługi nie powiodło się. Spróbuj ponownie po odświeżeniu strony.", "Błąd");
            });
    };

    var removeServiceResource = function (id) {
        $("#" + serviceResourceRowIdName + id).remove();
        $("#" + serviceResourceOptIdName + id).prop("disabled", false);
        setEmptyInfoTable();
    };

    var setEmptyInfoTable = function () {
        var len = $resourcesUsageBody.children().length;
        if (len == 0) {
            $resourcesUsageBody.append(emptyResourcesTableRow);
        }
    };

    var init = function () {
        initServiceButtons();
        initForm();
        initServiceResourcesPopup();
    };

    return {
        init: init
    };
};