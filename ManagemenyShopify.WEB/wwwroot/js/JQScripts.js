function GetTest() {
    id = $('#testtext').prop('value');
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/PostTest",
        data: JSON.stringify(id),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            alert(data);
        }
    });
}



function divToggle(id) {
    $('#' + id).toggle('slow');
}




function GetOrder() {
    id = $('#orderId').prop('value');
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/GetOrder",
        data: JSON.stringify(id),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            $('#OrderInfo').text("Результат: ");
            $('#OrderInfo').append(data);
        }
    });
}


function OrdersCount() {
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/OrdersCount",
        data: JSON.stringify(),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            $('#OrderCountInfo').text("Результат: ");
            $('#OrderCountInfo').append(data);
        }
    });
}



function CreateAddress() {
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/CreateAddress",
        data: JSON.stringify(),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            alert(data);
        }
    });
}

function RebornOrder() {
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/RebornOrder",
        data: JSON.stringify(),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            alert(data);
        }
    });
}

function UpdateOrder() {
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/UpdateOrder",
        data: JSON.stringify(),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            alert(data);
        }
    });
}

function TestOrder() {
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Home/TestOrder",
        data: JSON.stringify(),
        contentType: "application/json; charset=utf-8",
        Accept: "application/json",
        dataType: "json",
        async: false,
        success: function (data) {
            alert(data);
        }
    });
}