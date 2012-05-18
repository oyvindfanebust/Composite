(function() {
    $(document).on('thingsNeeded', function (e) {
        $.getJSON('/Silo1/GetThings', function (data) {
            $(document).trigger('thingsGotten', data);
        });
    });
})();