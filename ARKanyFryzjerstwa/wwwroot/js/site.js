var sidebarToggleAction = function () {
    document.body.classList.toggle('sb-sidenav-toggled');
    localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
};

var initSidebar = function () {
    const isMobile = window.matchMedia("(max-width: 991px)").matches;

    if (isMobile) {
        const sidenavContent = document.body.querySelector('#layoutSidenav_content');
        sidenavContent.addEventListener('click', event => {
            document.body.classList.remove('sb-sidenav-toggled');
        });
        return;
    }

    if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
        document.body.classList.toggle('sb-sidenav-toggled');
    }
}

window.addEventListener('DOMContentLoaded', event => {
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
        sidebarToggle.addEventListener('click', event => {
            sidebarToggleAction();
        });

        initSidebar();
    }
});

var dateFormat = function (date) {
    var year = date.getFullYear();
    var month = date.getMonth() + 1;
    var day = date.getDate();
    return year + '-' + month + '-' + day;
};

var getViewport = function () {
    // https://andylangton.co.uk/blog/development/get-viewportwindow-size-width-and-height-javascript

    var e = window, a = 'inner';

    if (!('innerWidth' in window)) {
        a = 'client';
        e = document.documentElement || document.body;
    }

    return { width: e[a + 'Width'], height: e[a + 'Height'] }
}

toastr.options = {
    "closeButton": true,
    "debug": false,
    "newestOnTop": false,
    "progressBar": true,
    "positionClass": "toast-bottom-right",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "5000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
}

const NotificationTypes = {
    0: "Info",
    1: "Success",
    2: "Warning",
    3: "Error"
};

var notify = function(message, type, title) {
    if (type == 'Success') {
        return toastr.success(message, title);
    }
    if (type == 'Warning') {
        return toastr.warning(message, title);
    }
    if (type == 'Info') {
        return toastr.info(message, title);
    }
    if (type == 'Error') {
        return toastr.error(message, title);
    }
};


const hiddenAttr = "hidden";
var show = function(element) {
    $(element).removeAttr(hiddenAttr);
}
var hide = function (element) {
    $(element).attr(hiddenAttr, hiddenAttr);
}

var getBorderColor = function (color) {
    const colorDarkenAmount = 40;
    return '#' + color.replace(/^#/, '').replace(/../g, color => ('0' + Math.min(255, Math.max(0, parseInt(color, 16) - colorDarkenAmount)).toString(16)).substr(-2));
}

/* validation */
var onlyLetters = function (e) {
    if (!e.key.match(/\p{L}/gu)) {
        e.preventDefault();
    }
};

var withoutWhiteSpaces = function (e) {
    if (e.key.match(/\s/gu)) {
        e.preventDefault();
    }
};

var clampNumber = function (num, min, max) {
    return Math.min(Math.max(num, min), max);
}

var toTwoDecimalPlaces = function (number) {
    number = number.toString().replace(',', '.');
    return Number.parseFloat(number).toFixed(2);
}