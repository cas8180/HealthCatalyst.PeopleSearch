(function () {

    var options = {
        url: function (phrase) {
            $("#Loading").show();
            return "/home/search?q=" + phrase + "&format=json";
        },
        getValue: "Name",
        template: {
            type: "custom",
            method: function (value, item) {
                $("#Loading").hide();
                return  "<img src='" + item.Image + "' />" + " | " + value + " " + item.Age + " <br /> <span style='font-size:x-small'>" + item.Interests + "</span>";
            }
        }
    };
    
    $("#search").easyAutocomplete(options);

})();

