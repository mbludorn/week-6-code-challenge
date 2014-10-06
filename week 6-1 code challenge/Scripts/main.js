$(document).ready(function () {

    $('#contactform').on('click', '.ajax-get', function () {
        //get the url from the data-url attribute
        var urlRequest = $(this).data('url');
        $.get(urlRequest, function (data) {
            $('#contentform').html(data);
        });
    });
});