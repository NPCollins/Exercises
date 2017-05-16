/// <reference path="../jquery-3.1.1.js" />

$(document).ready(function () {

    var fNameField = $("#SameShipping");
    fNameField.on("change", function (event) {
        if ($(this).is(':checked')) {
            var billingAddress1 = $("#BillingAddress1").val();
            $("#ShippingAddress1").val(billingAddress1);

            var billingAddress2 = $("#BillingAddress2").val();
            $("#ShippingAddress2").val(billingAddress2);

            var billingCity = $("#BillingCity").val();
            $("#ShippingCity").val(billingCity);

            var billingState = $("#BillingState").val();
            $("#ShippingState").val(billingState);

            var billingPostalCode = $("#BillingPostalCode").val();
            $("#ShippingPostalCode").val(billingPostalCode);
        }
        else if ($(this).not(':checked')) {
            $("#ShippingAddress1").val("");
            $("#ShippingAddress2").val("");
            $("#ShippingCity").val("");
            $("#ShippingState").val("");
            $("#ShippingPostalCode").val("");
        }
    });

    var dataCostField = $("#data_cost");
    dataCostField.on("change", function (event) {
        $("#data_cost");
    });

});







