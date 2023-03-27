var Homepage = function (config) {
    if (config.isSignedIn) {
        var $currentUserPlannedAppointmentsHeader = $('#currentUserPlannedAppointmentsHeader');
        var $currentUserServedClientsHeader = $('#currentUserServedClientsHeader');
        var $currentUserNewClientsHeader = $('#currentUserNewClientsHeader');
        var $overallPlannedAppointmentsHeader = $('#overallPlannedAppointmentsHeader');
        var $overallServedClientsHeader = $('#overallServedClientsHeader');
        var $overallNewClientsHeader = $('#overallNewClientsHeader');
        var $statsLoadingDivs = $(document).find('.homepage-stats-loading-div');
        var $statsDataDivs = $(document).find('.stats-content-div');
        var $resourceTable = $('#homepageResourcesTable');
        var $resourceTableLoadingDiv = $('#resourceTableLoadingDiv');
        var $resourceTableContentDiv = $('#resourceTableContentDiv');
        var $note = $('#userNote');
        var $noteLoadingDiv = $("#noteLoadingDiv");

        const resourceUnits = ['ml', 'szt'];

        var initStatsTiles = function () {
            $.post(config.urls.getStats, null, function (result) {
                $currentUserPlannedAppointmentsHeader.text(result.currentUserPlannedAppointmentsCount);
                $currentUserServedClientsHeader.text(result.currentUserServedClientsCount);
                $currentUserNewClientsHeader.text(result.currentUserNewClientsCount);

                $overallPlannedAppointmentsHeader.text(result.overallPlannedAppointmentsCount);
                $overallServedClientsHeader.text(result.overallServedClientsCount);
                $overallNewClientsHeader.text(result.overallNewClientsCount);

                hideStatsLoadingDivs();
            }, "json")
                .fail(function () {
                    hideStatsLoadingDivs();
                    toastr.error("Pobranie statystyk nie powiodło się.", "Błąd");
                });
        }

        var initResourceTable = function () {
            $.post(config.urls.getLowResources, null, function (result) {

                var $tableBody = $resourceTable.find('tbody').eq(0);
                $(result.resources).each(function () {
                    var $newRow = $('<tr><td class="text-start">' + this.name +
                        '</td><td>' + this.quantity +
                        '</td><td>' + this.alertQuantity +
                        '</td><td>' + resourceUnits[this.unit] + '</td></tr>')

                    $tableBody.append($newRow);
                });
                hideResourcesTableLoadingDiv();
            }, "json")
                .fail(function () {
                    toastr.error("Pobranie danych o zasobach nie powiodło się.", "Błąd");
                });
        }

        var initNote = function () {
            $.post(config.urls.getNote, null, function (result) {
                $note.val(result);

                switchNoteLoading(false);
            });

            $note.focusout(function () {
                $note.val($note.val().trim());

                var param = {
                    note: $note.val()
                };

                switchNoteLoading(true);

                $.post(config.urls.saveNote, param, function () {
                    switchNoteLoading(false);
                    toastr.success("Notatka została zapisana.", "Sukces");
                }).fail(function () {
                    switchNoteLoading(false);
                    toastr.error("Zapisanie notatki nie powiodło się.", "Błąd");
                });
            });
        };

        var hideStatsLoadingDivs = function () {
            $statsLoadingDivs.hide();
            $statsDataDivs.show();
        }

        var hideResourcesTableLoadingDiv = function () {
            $resourceTableLoadingDiv.hide();
            $resourceTableContentDiv.show();
        }

        var switchNoteLoading = function (show) {
            if (show) {
                $noteLoadingDiv.show();
                $note.hide();
            } else {
                $note.show();
                $noteLoadingDiv.hide();
            }
        }

        var init = function () {
            initStatsTiles();
            initResourceTable();
            initNote();
        }

        return {
            init: init
        };

    } else {    // Not signed in version
        window.onscroll = function () {
            changeNavbarColor();
        };

        $("#bottomRegisterSalonBtn").hover(function () {
            $("#summaryArrowLeft").css('transform', 'translateX(30px)');
            $("#summaryArrowRight").css('transform', 'translateX(-30px)');
        }, function () {
            $("#summaryArrowLeft").css('transform', 'translateX(0px)');
            $("#summaryArrowRight").css('transform', 'translateX(0px)');
        })

        var changeNavbarColor = function () {
            if ($('body').scrollTop() > 80 || $(document.documentElement).scrollTop() > 80) {
                $("#topNavbarNotLoggedIn").css('background-color', '#007bff');
            } else {
                $("#topNavbarNotLoggedIn").css('background-color', 'rgb(0, 0, 0, 0.5)');
            }
        }

        var init = function () {
        }

        return {
            init: init
        };
    }
}


