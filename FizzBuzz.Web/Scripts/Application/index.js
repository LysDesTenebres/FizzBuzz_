$(function () {
    var fizzFactor = $('#FizzFactor').val();
    var buzzFactor = $('#BuzzFactor').val();
    var lastNumber = $('#LastNumber').val();

    var fizzBuzzUrl = '/api/fizz/' + fizzFactor + '/buzz/' + buzzFactor;
    if (lastNumber) {
        fizzBuzzUrl += '?lastNumber=' + lastNumber;
    }

    $('#fizzBuzzResult').text('Retrieving FizzBuzz text...');
    $('#fizzBuzzResult').addClass('alert-success');
    $('#fizzBuzzResult').removeClass('alert-danger');

    $.ajax({
        dataType: "json",
        url: fizzBuzzUrl,
        success: function (result) {
            $('#fizzBuzzResult').text(result);
            $('#fizzBuzzResult').addClass('alert-success');
            $('#fizzBuzzResult').removeClass('alert-danger');
        },
        error: function () {
            $('#fizzBuzzResult').text('Cannot create FizzBuzz text because of invalid parameter(s)!');
            $('#fizzBuzzResult').addClass('alert-danger');
            $('#fizzBuzzResult').removeClass('alert-success');
        }
    });
});