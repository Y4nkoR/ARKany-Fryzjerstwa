var PasswordReset = function (config) {
    const disabled = "disabled";
    var $sendCodeBtn = $("#sendCodeBtn");
    var $showDetailsBtn = $("#showDetailsBtn");
    var $passwordResetOptions = $("#passwordResetOptions");
    var $passwordResetDetails = $("#passwordResetDetails");
    var $login = $("#login");

    var initOptionsBtns = function () {
        $sendCodeBtn.click(function () {
            disableOptionsBtns(true);
            var login = $login.val();
            if (!login.trim()) {
                toastr.warning(config.texts.incompleteDataWarningMsg, config.texts.warningTitle);
                disableOptionsBtns(false);
                return;
            }

            var param = { login: login };
            $.post(config.urls.sendCode, param, function (result) {
                if (result.type == 1) {
                    showPasswordDetails();
                }
                notify(result.message, NotificationTypes[result.type], result.title);
                disableOptionsBtns(false);
            }, "json")
                .fail(function () {
                    toastr.error(config.texts.unknowErrorMsg, "Błąd");
                    disableOptionsBtns(false);
                });
        });

        $showDetailsBtn.click(function () {
            showPasswordDetails();
        });
    };

    var disableOptionsBtns = function (disable) {
        if (disable) {
            $sendCodeBtn.addClass(disabled);
            $showDetailsBtn.addClass(disabled);
        } else {
            $sendCodeBtn.removeClass(disabled);
            $showDetailsBtn.removeClass(disabled);
        }
    };

    var showPasswordDetails = function () {
        $passwordResetOptions.hide();
        $passwordResetDetails.show();
    };

    var init = function () {
        initOptionsBtns();
    };

    return {
        init: init
    };
};

