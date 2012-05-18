(function () {
    $(document).on('thingsGotten', function (e, result) {
        var ids = _.map(result.ThingOwners, function (it) {
            return it.Id;
        });

        $.ajax({
            url: "/Silo2/GetPersons",
            data: JSON.stringify({ ids: ids }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $(document).trigger('personsGotten', data);
            },
            type: "POST",
            datatype: "json"
        });
    });
})();