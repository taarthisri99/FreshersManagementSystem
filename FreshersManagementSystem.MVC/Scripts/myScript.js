$(function () {

    $('#edit').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget)
        var id = button.data('id')

        $.ajax({
            url: "/Trainee/Trainee/GetbyID/" + id,
            type: "GET",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $('#id').val(result.Id);
                $('#name').val(result.Name);
                $('#mobile-number').val(result.MobileNumber);
                $('#date-of-birth').val(formatDate(result.DateOfBirth));
                $('#qualification').val(result.Qualification);
                $('#address').val(result.Address);

                $('#save-edit-button').on('click', function () {
                    var updatedData = $('#edit-form').serialize();
                    $.ajax({
                        url: "/Trainee/Trainee/UpdateTrainee",
                        type: "POST",
                        dataType: 'json',
                        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                        data: updatedData,
                        success: function (result) {
                            if ('1' == result) {
                                $('#message').html("Trainee Updated Successfully");
                                $('#notify').modal('show')
                                $('#ok-button').on('click', function () {
                                    window.location.replace(window.location.href)
                                });
                            } else {
                                $('#message').html("Trainee Updated failed");
                                $('#thumbs-up').hide();
                                $('#notify').modal('show');
                            }
                        },
                        error: function () {
                            alert("Unexcepted Error!!!");
                        }
                    });
                });
            },
            error: function () {
                alert("Unexcepted Error!!!");
            }
        });
    })

    function formatDate(dateOfBirth) {
        var dateString = dateOfBirth.substr(6);
        var currentTime = new Date(parseInt(dateString));
        var month = currentTime.getMonth() + 1;
        var day = currentTime.getDate();
        var year = currentTime.getFullYear();
        day = day < 10 ? "0" + day : day;
        month = month < 10 ? "0" + month : month;

        return day + "-" + month + "-" + year;
    }

    $('#delete').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget)
        var id = button.data('id-to-delete')

        $.ajax({
            url: "/Trainee/Trainee/GetbyID/" + id,
            type: "GET",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $('#name-to-delete').html(result.Name);
                $('#delete-yes-button').on('click', function () {
                    $.ajax({
                        url: "/Trainee/Trainee/Delete/" + id,
                        type: "GET",
                        contentType: "application/json;charset=UTF-8",
                        dataType: "json",
                        success: function (resultForDelete) {
                            if ('1' == resultForDelete) {
                                $('#message').html("Trainee Deleted Successfully");
                                $('#notify').modal('show');
                                $('#ok-button').on('click', function () {
                                    window.location.replace(window.location.href)
                                });
                            } else {
                                $('#message').html(resultForDelete);
                                $('#thumbs-up').hide();
                                $('#notify').modal('show');
                            }
                        },
                        error: function () {
                            alert("Unexcepted Error!!!");
                        }
                    })
                });
            },
            error: function () {
                alert("Unexcepted Error!!!");
            }
        });
    })
})
