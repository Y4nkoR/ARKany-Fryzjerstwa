var Resources = function (config) {
    var $formModal = $("#resourceModal");
    var $formResourceName = $("#formResourceName");
    var $formResourceQuantity = $("#formResourceQuantity");
    var $formResourceUnit = $("#formResourceUnit");
    var $formResourceAlertQuantity = $("#formResourceAlertQuantity");
    var resourceTable;
    var showOnlyLowResources = false;
    const newInClass = "new-input";
    const animRowClass = "anim-row";
    const inEditModeClass = "inEditMode";
    const invalidChars = ['-', '+', 'e', 'E'];
    const resourceUnits = ['ml', 'szt'];
    const rowWarningClass = 'resource-table-row-warning';

    $(function () {
        initResourceTable();
    });

    var addResource = function (button) {
        var $button = $(button);
        var $inputs = $([
            $formResourceName,
            $formResourceQuantity,
            $formResourceUnit,
            $formResourceAlertQuantity
        ]);

        if (validateInputs($inputs) == false) {
            return;
        }

        $button.css("pointer-events", "none");

        var resourceData = {
            id: '',
            name: $formResourceName.val(),
            quantity: $formResourceQuantity.val().replace('.', ','),
            unit: $formResourceUnit.val(),
            alertQuantity: $formResourceAlertQuantity.val().replace('.', ',')
        };

        $.post(config.urls.addNewResource, resourceData, function (result) {
            var $newRow = $('<tr id="resource-' + result.id + '"><td class="resource-id">' +
                result.id + '<td class="resource-name">' +
                result.name + '</td><td class="resource-quantity text-center">' +
                result.quantity + '</td><td class="resource-alert-quantity text-center">' +
                result.alertQuantity + '</td><td class="resource-unit text-center">' +
                resourceUnits[result.unit.toString()] + '</td><td class="resource-btns text-center">' +
                '<i class="fa-solid fa-pen anim-icon table-icons resource-edit-btn"></i>' +
                '<i class="fa-solid fa-floppy-disk anim-icon table-icons resource-save-btn" style="display: none"></i>' +
                '<i class="fa-solid fa-xmark anim-icon table-icons resource-cancel-btn" style="display: none"></i>' +
                '<i class="fa-solid fa-trash anim-icon table-icons resource-remove-btn"></i>'
                );

            checkRowCriticalQuantity($newRow);

            $formModal.modal("hide");
            resourceTable.row.add($newRow).draw().show().draw(false);
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

    var enableResourceEdit = function (button) {
        var row = button.parentElement.parentElement;
        $(row).addClass(inEditModeClass);
        createInputsInRow(row);
        toggleRowButtonsVisibility(row);
    }

    var cancelResourceEdit = function (button) {
        var $row = $(button.parentElement.parentElement);
        var $cells = $($row.find('td'));

        resourceTable.cell($cells.eq(1)).data($cells.eq(1).find("input")[0].defaultValue);
        resourceTable.cell($cells.eq(2)).data($cells.eq(2).find("input")[0].defaultValue);
        resourceTable.cell($cells.eq(3)).data($cells.eq(3).find("input")[0].defaultValue);
        resourceTable.cell($cells.eq(4)).data($cells.eq(4).find("select").data("prev"));
        $row.removeClass(inEditModeClass);
        toggleRowButtonsVisibility($row[0]);
    }

    var updateResource = function (button) {
        var $row = $(button.parentElement.parentElement);
        var $buttonCell = $(button.parentElement);
        var $button = $(button);
        var $cells = $($row.find('td'));

        var $inputs = $([
            $cells.eq(1).find("input").eq(0),
            $cells.eq(2).find("input").eq(0),
            $cells.eq(3).find("input").eq(0),
            $cells.eq(4).find("select").eq(0),
        ]);
        
        if (validateInputs($inputs) == false) {
            return;
        }

        $buttonCell.css("pointer-events", "none");

        var $cells = $($row.find('td'));
        var $nameCell = $cells.eq(1);
        var $quantityCell = $cells.eq(2);
        var $alertQuantityCell = $cells.eq(3);
        var $unitCell = $cells.eq(4);

        var resourceData = {
            id: $cells.eq(0).text(),
            name: $nameCell.find('input').val(),
            quantity: $quantityCell.find('input').val().replace('.', ','),
            unit: $unitCell.find('select').val(),
            alertQuantity: $alertQuantityCell.find('input').val().replace('.', ',')
        };

        $.post(config.urls.updateResource, resourceData, function (result) {
            resourceTable.cell($nameCell).data(result.name);
            resourceTable.cell($quantityCell).data(result.quantity);
            resourceTable.cell($unitCell).data(resourceUnits[result.unit]);
            resourceTable.cell($alertQuantityCell).data(result.alertQuantity);

            checkRowCriticalQuantity($row);

            resourceTable.row($row).draw().show().draw(false);
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

    var removeResource = function (button) {
        var $button = $(button);
        $button.css("pointer-events", "none");
        var row = button.parentElement.parentElement;
        var $cells = $($(row).find('td'));
        var resourceData = {
            resourceId: $cells.eq(0).text()
        }
        
        $.post(config.urls.removeResource, resourceData, function () {
            resourceTable.row(row).remove().draw(false);
            toastr.success("Pomyślnie usunięto dane.", "Sukces");
        })
            .fail(function () {
                $button.css("pointer-events", "auto");
                toastr.error("Usuwanie danych nie powiodło się.", "Błąd");
            });
    }

    var removeSelectedResources = function () {
        $resourceRemoveSelectedBtn = $("resourceRemoveSelectedBtn");
        $resourceRemoveSelectedBtn.css("pointer-events", "none");
        $('.resourceRemoveSelectedBtn').attr('disabled', true);
        var selectedRows = resourceTable.rows({ selected: true });
        var $selectedRowsData = $(selectedRows.data());
        var resourcesData = {
            resourcesIds: []
        };

        $selectedRowsData.each(function () {
            resourcesData.resourcesIds.push(this[0]);
        })

        $.post(config.urls.removeResources, resourcesData, function () {
            selectedRows.remove().draw();
            toastr.success("Pomyślnie usunięto dane.", "Sukces");
            $resourceRemoveSelectedBtn.css("pointer-events", "auto");
        })
            .fail(function () {
                toastr.error("Usuwanie danych nie powiodło się.", "Błąd");
                $resourceRemoveSelectedBtn.css("pointer-events", "auto");
                $('.resourceRemoveSelectedBtn').attr('disabled', false);
            });
    }

    var createInputsInRow = function (row) {
        var cells = $(row).find('td');
        var $nameCell = $(cells[1]);
        var $quantityCell = $(cells[2]);
        var $alertQuantityCell = $(cells[3]);
        var $unitCell = $(cells[4]);

        var $nameInput = $("<input>");
        $nameInput.attr("value", $nameCell.text());
        $nameInput.attr("type", "text");
        $nameInput.addClass("resourcesTableInput form-control expandable");
        $nameInput.addClass(newInClass);
        $nameInput.prop("required", true);
        $nameCell.empty();
        $nameCell.append($nameInput);

        var $quantityInput = $("<input>");
        $quantityInput.attr("value", $quantityCell.text().replace(',', '.'));
        $quantityInput.attr("type", "number");
        $quantityInput.attr("step", "0.01");
        $quantityInput.attr("min", "0.00");
        $quantityInput.attr("max", "9999.99");
        $quantityInput.addClass("resourcesTableInput text-center form-control");
        $quantityInput.addClass(newInClass);
        $quantityInput.prop("required", true);
        $quantityCell.empty();
        $quantityCell.append($quantityInput);
        $quantityCell.on("keydown", function (e) {
            if (invalidChars.includes(e.key)) {
                e.preventDefault();
            }
        });

        var $alertQuantityInput = $("<input>");
        $alertQuantityInput.attr("value", $alertQuantityCell.text().replace(',', '.'));
        $alertQuantityInput.attr("type", "number");
        $alertQuantityInput.attr("step", "0.01");
        $alertQuantityInput.attr("min", "0.00");
        $alertQuantityInput.attr("max", "9999.99");
        $alertQuantityInput.addClass("resourcesTableInput text-center form-control");
        $alertQuantityInput.addClass(newInClass);
        $alertQuantityInput.prop("required", true)
        $alertQuantityCell.empty();
        $alertQuantityCell.append($alertQuantityInput);
        $alertQuantityCell.on("keydown", function (e) {
            if (invalidChars.includes(e.key)) {
                e.preventDefault();
            }
        });

        var $unitSelect = $("<select>");
        $unitSelect.addClass("resourcesTableInput text-center form-control");
        $unitSelect.addClass(newInClass);
        $unitSelect.prop("required", true);
        $unitSelect.attr("data-prev", $unitCell.text());

        $(resourceUnits).each(function () {
            $unitSelect.append('<option value="' + resourceUnits.indexOf(this.toString()) + '">' + this + '</option>');
        })

        $unitSelect.val(resourceUnits.indexOf($unitCell.text()));
        $unitCell.empty();
        $unitCell.append($unitSelect);
    }

    var validateInputs = function ($inputs) {
        const invalidSelector = ":invalid";
        var result = true;

        $inputs.each(function () {
            if (this.eq(0).is(invalidSelector)) {
                result = false;
                this.eq(0).removeClass(newInClass);
            }
        })

        return result;
    }

    var toggleRowButtonsVisibility = function (row) {
        var cells = $(row).find('td')
        var $saveButton = $($(cells).find('.resource-save-btn'));
        var $cancelButton = $($(cells).find('.resource-cancel-btn'));
        var $editButton = $($(cells).find('.resource-edit-btn'));

        $editButton.toggle();
        $cancelButton.toggle();
        $saveButton.toggle();
    }

    var clearForm = function () {
        $formResourceName.val("");
        $formResourceQuantity.val("");
        $formResourceUnit.val(0);
        $formResourceAlertQuantity.val("");
        addClassToInputs(newInClass);
    }

    var addClassToInputs = function (classToAdd) {
        $formResourceName.addClass(classToAdd);
        $formResourceQuantity.addClass(classToAdd);
        $formResourceAlertQuantity.addClass(classToAdd);
    }

    var showLoadingDiv = function () {
        $("#resourcesContentDiv").hide();
        $("#resourcesLoadingDiv").show();
    }

    var hideLoadingDiv = function () {
        $("#resourcesContentDiv").show();
        $("#resourcesLoadingDiv").hide();
    }

    var checkRowCriticalQuantity = function ($row) {
        var $cells = $($row.find('td'));
        var quantity = parseFloat($cells.eq(2).text().replace(',', '.'));
        var alertQuantity = parseFloat($cells.eq(3).text().replace(',', '.'));

        if (quantity <= alertQuantity) {
            $row.addClass(rowWarningClass);
        } else {
            $row.removeClass(rowWarningClass);
        }
    }    

    var initResourceButtons = function () {
        $(document).on('click', '.resource-edit-btn', function () {
            enableResourceEdit(this);
        });

        $(document).on('click', '.resource-save-btn', function () {
            updateResource(this);
        });

        $(document).on('click', '.resource-cancel-btn', function () {
            cancelResourceEdit(this);
        });

        $(document).on('click', '.resource-remove-btn', function () {
            removeResource(this);
        });

        $("#resourceAddBtn").click(function () {
            addResource(this);
        });

        $("#resourceCancelBtn").click(function () {
            clearForm();
        });
    }

    var initForm = function () {
        $formResourceQuantity.on("keydown", function (e) {
            if (invalidChars.includes(e.key)) {
                e.preventDefault();
            }
        });
        $formResourceAlertQuantity.on("keydown", function (e) {
            if (invalidChars.includes(e.key)) {
                e.preventDefault();
            }
        });
    }

    var initResourceTable = function () {
        resourceTable = $('#resourcesTable').DataTable({
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
                initResourceTableButtons();
                initLowResourceSearch();
                hideLoadingDiv();
            }
        });

        var initResourceTableButtons = function () {
            var $tableButtonsDiv = $('.tableButtons');
            $tableButtonsDiv.empty();

            new $.fn.dataTable.Buttons(resourceTable, {
                name: 'addResourceButton',
                buttons: [
                    {
                        text: config.txts.addBtn,
                        attr: {
                            'data-bs-toggle': 'modal',
                            'data-bs-target': '#resourceModal'
                        },
                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-primary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(resourceTable, {
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
            new $.fn.dataTable.Buttons(resourceTable, {
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
            new $.fn.dataTable.Buttons(resourceTable, {
                name: 'removeSelectedButton',
                buttons: [
                    {
                        text: config.txts.removeSelectedBtn,
                        className: 'resourceRemoveSelectedBtn',
                        attr: {
                            'disabled': 'true',
                        },
                        action: function (e, dt, node, config) {
                            removeSelectedResources();
                        }
                    },
                ],
                dom: {
                    button: {
                        className: 'btn btn-secondary'
                    },
                },
            });
            new $.fn.dataTable.Buttons(resourceTable, {
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

            // AddResource button
            var $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-2 px-2 py-1');
            resourceTable.buttons('addResourceButton', null).container().addClass('w-100 resource-table-btn-group');
            $buttonsGroupCol.append(resourceTable.buttons('addResourceButton', null).container());
            $tableButtonsDiv.append($buttonsGroupCol);

            // Selection buttons
            $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-7 px-2 py-1 h-100');
            var $buttonsRow = $('<div>');
            $buttonsRow.addClass('row w-100')

            var $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0');
            resourceTable.buttons('selectVisibleButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(resourceTable.buttons('selectVisibleButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0 px-sm-1');
            resourceTable.buttons('deselectAllButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(resourceTable.buttons('deselectAllButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupSubCol = $('<div>');
            $buttonsGroupSubCol.addClass('d-flex justify-content-center col-12 col-sm px-0');
            resourceTable.buttons('removeSelectedButton', null).container().addClass('w-100');
            $buttonsGroupSubCol.append(resourceTable.buttons('removeSelectedButton', null).container());
            $buttonsRow.append($buttonsGroupSubCol);

            $buttonsGroupCol.append($buttonsRow);
            $tableButtonsDiv.append($buttonsGroupCol);

            // Export buttons
            $buttonsGroupCol = $('<div>');
            $buttonsGroupCol.addClass('d-flex justify-content-center col-12 col-xl-2 px-2 py-1');
            resourceTable.buttons('exportButtons', null).container().find('.btn-group').addClass('w-100 resource-table-btn-group');
            resourceTable.buttons('exportButtons', null).container().addClass('w-100 resource-table-btn-group');

            $buttonsGroupCol.append(resourceTable.buttons('exportButtons', null).container());
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
            var $label = $('<label class="fw-bold" for="showOnlyLowCheckbox">' + config.txts.showLowResourcesCheckbox + '</label>')

            $checkbox.on('change', function () {
                showOnlyLowResources = $(this).prop('checked');
                resourceTable.draw();
            })

            $checkboxDiv.append($checkbox);
            $checkboxDiv.append($label);
            $tableTopRow.append($checkboxDiv)
        }

        var initLowResourceSearch = function () {
            $.fn.dataTable.ext.search.push(function (settings, data, dataIndex) {
                if (showOnlyLowResources == true) {
                    var $row = $(resourceTable.rows(dataIndex).nodes());

                    if ($row.hasClass(rowWarningClass)) {
                        return true;
                    }
                    return false;
                } else {
                    return true;
                }
            });
        }

        resourceTable.on('select', function (e, dt, type, indexes) {
            if (type === 'row') {
                $('.resourceRemoveSelectedBtn').removeAttr('disabled');
            }
        });
        resourceTable.on('deselect', function (e, dt, type, indexes) {
            if (resourceTable.rows({ selected: true }).count() == 0) {
                $('.resourceRemoveSelectedBtn').attr('disabled', true);
            }
        });
    }

    var init = function () {
        initResourceButtons();
        initForm();
    };

    return {
        init: init
    };
};