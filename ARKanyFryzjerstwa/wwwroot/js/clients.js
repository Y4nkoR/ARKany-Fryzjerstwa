var Clients = function (config) {
    var $formModal = $("#clientModal");
    var $formClientFirstName = $("#formClientFirstName");
    var $formClientLastName = $("#formClientLastName");
    var $formClientPhoneNumber = $("#formClientPhoneNumber");
    var $formClientEmail = $("#formClientEmail");
    var $removeClientPopup = $("#removeClientPopup");
    var $removeSelectedClientsPopup = $("#removeSelectedClientsPopup");
    var clientTable;
    const newInClass = "new-input";
    const animRowClass = "anim-row";
    const inEditModeClass = "inEditMode";
    const invalidClass = "invalid";
    const invalidValueClass = "invalid-value";
    var $formError = $("#clientError");
    const invalidSelector = ":invalid";

    $(function () {
        initClientTable();
    });

    var addClient = function (button) {
        var $button = $(button);
        var $inputs = $([
            $formClientFirstName,
            $formClientLastName,
            $formClientPhoneNumber,
            $formClientEmail
        ]);

        if (validateInputs($inputs, "add") == false) {
            return;
        }

        $button.css("pointer-events", "none");

        var clientData = {
            id: '',
            firstName: $formClientFirstName.val(),
            lastName: $formClientLastName.val(),
            phoneNumber: $formClientPhoneNumber.val(),
            email: $formClientEmail.val()
        };
        $.post(config.urls.duplicateClientVerification, clientData, function (result) {
            if (result == true) {
                $formError.text("Klient z takim samym imieniem,nazwiskiem i telefonem/emailem już istnieje");
            }
            else {
                $.post(config.urls.addNewClient, clientData, function (result) {
                    if (result.phoneNumber == null) {
                        result.phoneNumber = "";
                    }
                    if (result.email == null) {
                        result.email = "";
                    }
                    var $newRow = $('<tr id="client-' + result.id + '"><td class="client-id">' +
                        result.id + '<td class="client-firstName">' +
                        result.firstName + '</td><td class="client-lastName">' +
                        result.lastName + '</td><td class="client-phoneNumber">' +
                        result.phoneNumber + '</td><td class="client-email">' +
                        result.email + '</td><td class="client-btns text-center">' +
                        '<i class="fa-solid fa-pen anim-icon table-icons client-edit-btn"></i>' +
                        '<i class="fa-solid fa-floppy-disk anim-icon table-icons client-save-btn" style="display: none"></i>' +
                        '<i class="fa-solid fa-xmark anim-icon table-icons client-cancel-btn" style="display: none"></i>' +
                        '<i class="fa-solid fa-trash anim-icon table-icons client-remove-btn"></i>'
                    );

                    $formModal.modal("hide");
                    clientTable.row.add($newRow).draw().show().draw(false);
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
        })
            .fail(function () {
                toastr.error("Sprawdzenie czy dane klienta to duplikat nie powiodło się.", "Błąd");
            });
        $button.css("pointer-events", "auto");
        
    }

    var enableClientEdit = function (button) {
        var row = button.parentElement.parentElement;
        $(row).addClass(inEditModeClass);
        createInputsInRow(row);
        toggleRowButtonsVisibility(row);
    }

    var cancelClientEdit = function (button) {
        var $row = $(button.parentElement.parentElement);
        var $cells = $($row.find('td'));

        clientTable.cell($cells.eq(1)).data($cells.eq(1).find("input")[0].defaultValue);
        clientTable.cell($cells.eq(2)).data($cells.eq(2).find("input")[0].defaultValue);
        clientTable.cell($cells.eq(3)).data($cells.eq(3).find("input")[0].defaultValue);
        clientTable.cell($cells.eq(4)).data($cells.eq(4).find("input")[0].defaultValue);
        $row.removeClass(inEditModeClass);
        toggleRowButtonsVisibility($row[0]);
    }

    var updateClient = function (button) {
        var $row = $(button.parentElement.parentElement);
        var $buttonCell = $(button.parentElement);
        var $button = $(button);
        var $cells = $($row.find('td'));

        var $inputs = $([
            $cells.eq(1).find("input").eq(0),
            $cells.eq(2).find("input").eq(0),
            $cells.eq(3).find("input").eq(0),
            $cells.eq(4).find("input").eq(0),
        ]);

        if (validateInputs($inputs, "edit") == false) {
            return;
        }

        $buttonCell.css("pointer-events", "none");

        var $cells = $($row.find('td'));
        var $firstNameCell = $cells.eq(1);
        var $lastNameCell = $cells.eq(2);
        var $phoneNumberCell = $cells.eq(3);
        var $emailCell = $cells.eq(4);

        var clientData = {
            id: $cells.eq(0).text(),
            firstName: $firstNameCell.find('input').val(),
            lastName: $lastNameCell.find('input').val(),
            phoneNumber: $phoneNumberCell.find('input').val(),
            email: $emailCell.find('input').val()
        };

        $.post(config.urls.duplicateClientVerification, clientData, function (result) {
            if (result == true) {
                toastr.error("Klient z takim samym imieniem, nazwiskiem i telefonem/emailem już istnieje.", "Błąd");
            }
            else {
                $.post(config.urls.updateClient, clientData, function (result) {
                    clientTable.cell($firstNameCell).data(result.firstName);
                    clientTable.cell($lastNameCell).data(result.lastName);
                    clientTable.cell($phoneNumberCell).data(result.phoneNumber);
                    clientTable.cell($emailCell).data(result.email);

                    clientTable.row($row).draw().show().draw(false);
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
        })
            .fail(function () {
                toastr.error("Sprawdzenie czy dane klienta to duplikat nie powiodło się.", "Błąd");
            });
        $buttonCell.css("pointer-events", "auto");
    }

    var removeClient = function (clientData,row) {
        $.post(config.urls.removeClient, clientData, function () {
            clientTable.row(row).remove().draw(false);
            toastr.success("Pomyślnie usunięto dane.", "Sukces");
        })
            .fail(function () {
                toastr.error("Usuwanie danych nie powiodło się.", "Błąd");
            });
    }

    var removeSelectedClients = function (clientsData, selectedRows) {  
        $('.clientRemoveSelectedBtn').attr('disabled', true);
        $.post(config.urls.removeClients, clientsData, function () {
            selectedRows.remove().draw();
            toastr.success("Pomyślnie usunięto dane.", "Sukces");
        })
            .fail(function () {
                toastr.error("Usuwanie danych nie powiodło się.", "Błąd");
                $clientRemoveSelectedBtn.css("pointer-events", "auto");
                $('.clientRemoveSelectedBtn').attr('disabled', false);
            });
    }

    var createInputsInRow = function (row) {
        var cells = $(row).find('td');
        var $firstNameCell = $(cells[1]);
        var $lastNameCell = $(cells[2]);
        var $phoneNumberCell = $(cells[3]);
        var $emailCell = $(cells[4]);

        var $firstNameInput = $("<input>");
        $firstNameInput.attr("value", $firstNameCell.text());
        $firstNameInput.attr("type", "text");
        $firstNameInput.attr("max", "20");
        $firstNameInput.addClass("clientsTableInput form-control expandable");
        $firstNameInput.addClass(newInClass);
        $firstNameInput.prop("required", true);
        $firstNameCell.empty();
        $firstNameCell.append($firstNameInput);

        var $lastNameInput = $("<input>");
        $lastNameInput.attr("value", $lastNameCell.text());
        $lastNameInput.attr("type", "text");
        $lastNameInput.attr("max", "20");
        $lastNameInput.addClass("clientsTableInput form-control expandable");
        $lastNameInput.addClass(newInClass);
        $lastNameInput.prop("required", true);
        $lastNameCell.empty();
        $lastNameCell.append($lastNameInput);

        var $phoneNumberInput = $("<input>");
        $phoneNumberInput.attr("value", $phoneNumberCell.text());
        $phoneNumberInput.attr("type", "tel");
        $phoneNumberInput.attr("minlength", "9");
        $phoneNumberInput.attr("maxlength", "11");
        $phoneNumberInput.attr("pattern", "^[0-9]{9}$|^[0-9]{11}$");
        $phoneNumberInput.addClass("clientsTableInput form-control expandable");
        $phoneNumberInput.addClass(newInClass);
        $phoneNumberCell.empty();
        $phoneNumberCell.append($phoneNumberInput);
        $phoneNumberInput.on("input", function () {
            this.value = this.value.replace(/[^0-9]/g, '');
        });

        var $emailInput = $("<input>");
        $emailInput.attr("value", $emailCell.text());
        $emailInput.attr("type", "email");
        $emailInput.addClass("clientsTableInput form-control expandable");
        $emailInput.addClass(newInClass);
        $emailCell.empty();
        $emailCell.append($emailInput);
    }

    var validateInputs = function ($inputs, mode) {
        const invalidSelector = ":invalid";
        var result = true;

        $inputs.each(function () {
            if (this.eq(0).is(invalidSelector)) {
                result = false;
                this.eq(0).removeClass(newInClass);
            }
        })
        var contactValidation = validateEmailAndPhoneNumber($inputs.get(2), $inputs.get(3), mode);
        return result && contactValidation;
    }

    var validateEmailAndPhoneNumber = function (phoneNumber, email, mode) {
        var result = true;
        var errorMsg = "";
        var $phoneNumber = $(phoneNumber);
        var $email = $(email);
        if (!$phoneNumber.val() && !$email.val()) {
            errorMsg += "Należy podać numer telefonu i/lub email klienta.\n";
            $phoneNumber.removeClass(newInClass);
            $email.removeClass(newInClass);
            $phoneNumber.addClass(invalidValueClass);
            $email.addClass(invalidValueClass);
            setTimeout(function () {
                $phoneNumber.removeClass("invalid-value");
                $email.removeClass("invalid-value");
            }, 2000);
            result = false;
        } else {
            if ($phoneNumber.val().length != 9
                && $phoneNumber.val().length != 11
                && $phoneNumber.val().trim().length > 0) {
                errorMsg += "Podano nieprawidłowy numer telefonu.\n";
                result = false;
            }
            if ($email.is(invalidSelector)
                && $email.val().trim().length > 0) {
                errorMsg += "Podano nieprawidłowy email.\n";
                result = false;
            }
        }
        if (mode == "add") {
            $formError.text(errorMsg);
        }
        return result;
    }

    var initRemoveClientPopup = function (button) {
        var $button = $(button);
        $button.css("pointer-events", "none");
        var row = button.parentElement.parentElement;
        var $cells = $($(row).find('td'));
        var clientData = {
            clientId: $cells.eq(0).text()
        }
        $("#confirmClientFirstName").text($cells.eq(1).text());
        $("#confirmClientLastName").text($cells.eq(2).text());
        $("#confirmClientPhoneNumber").text($cells.eq(3).text());
        $("#confirmClientEmail").text($cells.eq(4).text());
        show($removeClientPopup);
        $("#confirmRemoveOneBtn").off().on('click',function () {
            $button.css("pointer-events", "auto");
            hide($removeClientPopup); 
            removeClient(clientData,row);
        });

        $("#cancelRemoveOneBtn").off().on('click',function () {
            $button.css("pointer-events", "auto");
            hide($removeClientPopup);
        });
    };

    var initRemoveSelectedClientsPopup = function () {
        $clientRemoveSelectedBtn = $("clientRemoveSelectedBtn");
        $clientRemoveSelectedBtn.css("pointer-events", "none");
        var selectedRows = clientTable.rows({ selected: true });
        var $selectedRowsData = $(selectedRows.data());
        var clientsData = {
            clientsIds: []
        };

        $selectedRowsData.each(function () {
            clientsData.clientsIds.push(this[0]);
        })

        $("#confirmSelectedNumber").text(clientsData.clientsIds.length);
        show($removeSelectedClientsPopup);
        $("#confirmRemoveSelectedBtn").off().on('click',function(){
            $clientRemoveSelectedBtn.css("pointer-events", "auto");
            hide($removeSelectedClientsPopup);
            removeSelectedClients(clientsData, selectedRows);           
        });

        $("#cancelRemoveSelectedBtn").off().on('click',function () {
            $clientRemoveSelectedBtn.css("pointer-events", "auto");
            hide($removeSelectedClientsPopup);
        });
    };

    var toggleRowButtonsVisibility = function (row) {
        var cells = $(row).find('td')
        var $saveButton = $($(cells).find('.client-save-btn'));
        var $cancelButton = $($(cells).find('.client-cancel-btn'));
        var $editButton = $($(cells).find('.client-edit-btn'));
        var $removeButton = $($(cells).find('.client-remove-btn'));

        $editButton.toggle();
        $cancelButton.toggle();
        $saveButton.toggle();
        $removeButton.toggle();
    }

    var clearForm = function () {
        $formClientFirstName.val("");
        $formClientLastName.val("");
        $formClientPhoneNumber.val("");
        $formClientEmail.val("");
        $formError.text("");
        addClassToInputs(newInClass);
    }

    var addClassToInputs = function (classToAdd) {
        $formClientFirstName.addClass(classToAdd);
        $formClientLastName.addClass(classToAdd);
        $formClientPhoneNumber.addClass(classToAdd);
        $formClientEmail.addClass(classToAdd);
    }

    var showLoadingDiv = function () {
        $("#clientsContentDiv").hide();
        $("#clientsLoadingDiv").show();
    }

    var hideLoadingDiv = function () {
        $("#clientsContentDiv").show();
        $("#clientsLoadingDiv").hide();
    }

    var initClientButtons = function () {
        $(document).on('click', '.client-edit-btn', function () {
            enableClientEdit(this);
        });

        $(document).on('click', '.client-save-btn', function () {
            updateClient(this);
        });

        $(document).on('click', '.client-cancel-btn', function () {
            cancelClientEdit(this);
        });

        $(document).on('click', '.client-remove-btn', function () {
            initRemoveClientPopup(this);
        });

        $("#clientAddBtn").click(function () {
            addClient(this);
        });

        $("#clientCancelBtn").click(function () {
            clearForm();
        });
    }

    var initForm = function () {
        $formClientPhoneNumber.on("input", function () {
            this.value = this.value.replace(/[^0-9]/g, '');
        });       
    }

    var initClientTable = function () {
        clientTable = $('#clientsTable').DataTable({
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
            dom: '<"container-fluid"\
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
                initClientTableButtons();
                hideLoadingDiv();
            }
        });

        var initClientTableButtons = function () {
            var $tableButtonsDiv = $('.tableButtons');
            $tableButtonsDiv.empty();

            new $.fn.dataTable.Buttons(clientTable, {
                name: 'addClientButton',
                buttons: [
                    {
                        text: config.txts.addBtn,
                        attr: {
                            'data-bs-toggle': 'modal',
                            'data-bs-target': '#clientModal'
                        },
                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-primary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(clientTable, {
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
            new $.fn.dataTable.Buttons(clientTable, {
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
            new $.fn.dataTable.Buttons(clientTable, {
                name: 'removeSelectedButton',
                buttons: [
                    {
                        text: config.txts.removeSelectedBtn,
                        className: 'clientRemoveSelectedBtn',
                        attr: {
                            'disabled': 'true',
                        },
                        action: function (e, dt, node, config) {
                            initRemoveSelectedClientsPopup();
                        }
                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-secondary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(clientTable, {
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

            // AddClient button
            var $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-2 px-2 py-1');
            clientTable.buttons('addClientButton', null).container().addClass('w-100 client-table-btn-group');
            $buttonsGroupCol.append(clientTable.buttons('addClientButton', null).container());
            $tableButtonsDiv.append($buttonsGroupCol);

            // Selection buttons
            $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-7 px-2 py-1 h-100');
            var $buttonsRow = $('<div>');
            $buttonsRow.addClass('row w-100')

            var $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0');
            clientTable.buttons('selectVisibleButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(clientTable.buttons('selectVisibleButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0 px-sm-1');
            clientTable.buttons('deselectAllButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(clientTable.buttons('deselectAllButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0');
            clientTable.buttons('removeSelectedButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(clientTable.buttons('removeSelectedButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupCol.append($buttonsRow);
            $tableButtonsDiv.append($buttonsGroupCol);

            // Export buttons
            $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-2 px-2 py-1');
            clientTable.buttons('exportButtons', null).container().find('.btn-group').addClass('w-100 client-table-btn-group');
            clientTable.buttons('exportButtons', null).container().addClass('w-100 client-table-btn-group');

            $buttonsGroupCol.append(clientTable.buttons('exportButtons', null).container());
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
        }

        clientTable.on('select', function (e, dt, type, indexes) {
            if (type === 'row') {
                $('.clientRemoveSelectedBtn').removeAttr('disabled');
            }
        });
        clientTable.on('deselect', function (e, dt, type, indexes) {
            if (clientTable.rows({ selected: true }).count() == 0) {
                $('.clientRemoveSelectedBtn').attr('disabled', true);
            }
        });
    }

    var init = function () {
        initClientButtons();
        initForm();
    };

    return {
        init: init
    };
};