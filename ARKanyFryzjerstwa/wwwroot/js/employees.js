var Employees = function (config) {
    const newInput = "new-input";
    const disabled = "disabled";
    const hsv = { s: 0.40, v: 0.75 };
    //const hsl = { s: 38, l: 60 };  // calculated from the hsv color constants (saturation  and value) used during generating the employee color
    $allEmpsDiv = $("#allEmpsContainer");
    $addNewEmpBtn = $("#addNewEmpBtn");
    $addNewEmpForm = $("#addEmpPopUp");
    $addEmpCancelBtn = $("#addEmpCancelBtn");
    $addEmpConfirmBtn = $("#addEmpConfirmBtn");
    $addEmpFormInputs = $("#newEmpData :input");
    $allEmpsLoadingPanel = $("#allEmpsLoadingPanel");
    $menu = $("#employeeManagementMenu");
    $menuEmployeeName = $("#menuEmployeeName");
    $menuEmployeeId = $("#menuEmployeeId");
    $menuEmployeeColor = $("#menuEmployeeColor");
    $colorPickerContainer = $("#colorPickerContainer");
    $colorPickerEmployeeName = $("#colorPickerEmployeeName");
    $colorPickerEmpId = $("#colorPickerEmpId");
    $colorPickerEmpColor = $("#colorPickerEmpColor");
    $rangeHuePicker = $("#rangeHuePicker");
    $numberHuePicker = $("#numberHuePicker");
    $undoColorBtn = $("#undoColorbtn");
    $closeColorBtn = $("#closeColorPickerBtn");
    $saveColorBtn = $("#saveEmpColorBtn");

    var initEmployeesSection = function () {
        $.post(config.urls.getEmployees, null, function (result) {
            $(result).each(function () {
                createEmployeeTile(this);
                $allEmpsLoadingPanel.hide();
            });
        }, "json")
            .fail(function () {
                toastr.error(config.texts.getAllEmployeesErrorMsg, "Błąd")
            });
    };

    var isAddEmpFormValid = function () {
        $addEmpFormInputs.removeClass(newInput);
        let result = true;
        $addEmpFormInputs.each(function () {
            let currentResult = this.checkValidity();
            result = (result && currentResult);
        });
        return result;
    }

    var disableAddNewEmployeeBtns = function (disable) {
        if (disable) {
            $addEmpConfirmBtn.addClass(disabled);
            $addEmpCancelBtn.addClass(disabled);
        } else {
            $addEmpConfirmBtn.removeClass(disabled);
            $addEmpCancelBtn.removeClass(disabled);
        }
    }

    var initAddNewEmployeeForm = function () {
        // init open form btn
        $addNewEmpBtn.click(function () {
            clearForm();
            show($addNewEmpForm);
        });
        // init form btns
        let $firstNameInput = $("#newEmpFirstName");
        let $lastNameInput = $("#newEmpLastName");
        let $emailInput = $("#newEmpEmail");
        $addEmpCancelBtn.click(function () {
            if ($addEmpCancelBtn.hasClass(disabled)) {
                return;
            }
            hide($addNewEmpForm);
        });
        $addEmpConfirmBtn.click(function () {
            if ($addEmpConfirmBtn.hasClass(disabled)) {
                return;
            }
            if (!isAddEmpFormValid()) {
                return toastr.error(config.texts.invalidFormErrorMsg, "Błąd");
            }
            disableAddNewEmployeeBtns(true);

            let params = {
                firstName: $firstNameInput.val(),
                lastName: $lastNameInput.val(),
                email: $emailInput.val()
            };
            $.post(config.urls.addEmployee, params, function (result) {
                if (result.error != null) {
                    toastr.error(result.error, "Błąd");
                    return disableAddNewEmployeeBtns(false);
                }
                hide($addNewEmpForm);
                clearForm();
                createEmployeeTile(result);
                return toastr.success(config.texts.addingEmployeeSuccessMsg, "Sukces");
            }, "json")
                .fail(function () {
                    toastr.error(config.texts.unknowErrorMsg, "Błąd");
                    return disableAddNewEmployeeBtns(false);
                });
        });
        //init form inputs behavior
        $addEmpFormInputs.focusout(function (e) {
            $(e.target).removeClass(newInput);
        });
        $firstNameInput.keypress(function (e) {
            onlyLetters(e);
        });
        $lastNameInput.keypress(function (e) {
            onlyLetters(e);
        });
        $emailInput.keypress(function (e) {
            withoutWhiteSpaces(e);
        });
    };

    var createEmployeeTile = function (employee) {
        $tile = $("<div>");
        $tile.attr("id", "empTile-" + employee.id);
        $tile.addClass("emp-tile");
        $tile.css("background-color", employee.color);
        $tile.css("border-color", getBorderColor(employee.color));

        $empName = $("<div>");
        $empName.addClass("emp-name-tile");
        $empName.text(employee.firstName + " " + employee.lastName);
        $tile.append($empName);

        $empLogin = $("<div>");
        $empLogin.addClass("emp-text-tile");
        $empLogin.text(employee.userName);
        $tile.append($empLogin);

        $tile.contextmenu(function (e) {
            e.preventDefault();
            showEmployeeMenu(e, employee);
        });

        $allEmpsDiv.append($tile);
    };

    var clearForm = function () {
        $addEmpFormInputs.val(null);
        $addEmpFormInputs.addClass(newInput);
        disableAddNewEmployeeBtns(false);
    };

    var showEmployeeMenu = function (e, employee) {
        $menuEmployeeId.val(employee.id);
        $menuEmployeeName.text(employee.firstName + " " + employee.lastName);
        $menuEmployeeColor.val(employee.color);

        var viewport = getViewport();
        const boundaryMargin = 20;

        var offsetLeft = e.pageX + $menu.innerWidth() - viewport.width + boundaryMargin;
        var offsetTop = e.pageY + $menu.innerHeight() - viewport.height + boundaryMargin;

        var currentTop = offsetTop > 0 ? e.pageY - offsetTop : e.pageY;
        var currentLeft = offsetLeft > 0 ? e.pageX - offsetLeft : e.pageX;

        $menu.show().css({
            top: currentTop + "px",
            left: currentLeft + "px"
        });
    }
    var hideEmployeeMenu = function () {
        $menu.hide();
        $menuEmployeeId.val("");
        $menuEmployeeName.text("");
        $menuEmployeeColor.val("");
    };

    var initEmployeeMenu = function () {
        window.addEventListener('click', function (e) {
            if (isMenuHidden() || $menu[0].contains(e.target)) {
                return;
            }
            hideEmployeeMenu();
        });

        $("#empColorChangeOpt").click(function () { 
            if ($colorPickerContainer.is(":visible")) {
                updateTileColor($colorPickerEmpColor.val(), $colorPickerEmpId.val());
            }
            $colorPickerEmployeeName.text($menuEmployeeName.text());
            $colorPickerEmpId.val($menuEmployeeId.val());
            var color = $menuEmployeeColor.val();
            $colorPickerEmpColor.val(color);
            var hue = Math.round(Please.HEX_to_HSV(color).h);
            $rangeHuePicker.val(hue);
            $numberHuePicker.val(hue);
            $colorPickerContainer.show();
            hideEmployeeMenu();
        });
    }

    var initColorPickerSection = function () {
        $rangeHuePicker.on("input", function () {
            var hue = $rangeHuePicker.val();
            $numberHuePicker.val(hue);
            updateTileColor(getHexColor(hue), $colorPickerEmpId.val());
        });

        $numberHuePicker.on("input", function () {
            var hue = $numberHuePicker.val();
            $rangeHuePicker.val(hue);
            updateTileColor(getHexColor(hue), $colorPickerEmpId.val());
        });

        $undoColorBtn.click(function () {
            updateTileColor($colorPickerEmpColor.val(), $colorPickerEmpId.val());
        });

        $closeColorBtn.click(function () {
            updateTileColor($colorPickerEmpColor.val(), $colorPickerEmpId.val());
            closeColorPickerContainer();
        });

        $saveColorBtn.click(function () {
            var hue = $numberHuePicker.val();
            disableEmloyeeColorContainerBtns(true);
            var param = {
                color: getHexColor(hue),
                employeeId: $colorPickerEmpId.val()
            };

            $.post(config.urls.saveEmployeeColor, param, function (result) {
                if (result.error != null) {
                    disableEmloyeeColorContainerBtns(false);
                    return toastr.error(result.error, "Błąd");
                }
                closeColorPickerContainer();
                updateTileColor(param.color, param.employeeId);
                toastr.success(config.texts.savingEmployeeColorSuccessMsg, "Sukces");
                disableEmloyeeColorContainerBtns(false);
            }, "json")
                .fail(function () {
                    disableEmloyeeColorContainerBtns(false);
                    toastr.error(config.texts.savingEmployeeColorErrorMsg, "Błąd");
                });
        });
    }

    var disableEmloyeeColorContainerBtns = function (disable) {
        if (disable) {
            $undoColorBtn.addClass(disabled);
            $saveColorBtn.addClass(disabled);
        } else {
            $undoColorBtn.removeClass(disabled);
            $saveColorBtn.removeClass(disabled);
        }
    }

    var closeColorPickerContainer = function () {
        $colorPickerContainer.hide();
        $colorPickerEmployeeName.text("");
        $colorPickerEmpId.val("");
        $colorPickerEmpColor.val("");
    }

    var getHexColor = function (hue) {
        return Please.HSV_to_HEX({ h: hue, s: hsv.s, v: hsv.v });
    }

    var updateTileColor = function (color, empId) {
        var $tile = $("#empTile-" + empId);
        $tile.css("background-color", color);
        $tile.css("border-color", getBorderColor(color));
    }

    var isMenuHidden = function() {
        return $menu.is(":hidden");
    }

    var init = function () {
        initAddNewEmployeeForm();
        initEmployeesSection();
        initColorPickerSection();
        initEmployeeMenu();
    };

    return {
        init: init
    };
};

