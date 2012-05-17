(function() {
    $(document).on('foo', function (e) {
        $.getJSON('/Silo1/Foo', function (data) {
            $(document).trigger('bar', [data]);
        });
    });
})();