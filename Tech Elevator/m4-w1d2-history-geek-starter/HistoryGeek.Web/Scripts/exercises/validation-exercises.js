/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {

    $("#loginform").validate({

        debug: false,
        rules: {

            EmailAddress: {
                email: true
                },
            },
            Password: {
                required: true
            },
        messages: {

        },
        errorClass: "error",
        validClass: "valid"

    });

    $("#registerform").validate({

        debug: false,
        rules: {

            EmailAddress: {
                email: true,            //require this field to only accept email                
                //required: {
                //    depends: function (element) {
                //        return $("#chkEmail").is(":checked");
                //    }
                //},
                //GovernmentEmail: true
            },
            Password: {
                required: true,
                minlength: 8,
                strongpassword: true
            },
            ConfirmPassword: {
                equalTo: "#Password"
            },
        },
        messages: {
            EmailAddress: {
                required: "You need an Email"
            },
            Password: {
                required: "You must provide a password",
                minlength: "Must be at least 8 characters",
            }
        },
        errorClass: "error",
        validClass: "valid"

    });

    $("#checkout").validate({

        debug: false,
        rules: {

            BillingAddress1: {
                required: true
            },
            BillingCity: {
                required: true
            },
            BillingState: {
                required: true
            },
            BillingPostalCode: {
                required: true
            },
            ShippingAddress1: {
                required: true
            },
            ShippingCity: {
                required: true
            },
            ShippingState: {
                required: true
            },
            ShippingPostalCode: {
                required: true
            },
            ShippingType: {
                required: true
            },
            NameOnCard: {
                required: true
            },
            CreditCardNumber: {
                required: true,
                minlength: 16,
                maxlength: 16
            },
            ExpirationDate: {
                required: true,
                minlength: 5,
                maxlength: 5
            }
        },
        
        messages: {
            CreditCardNumber: {
                minlength: "Number too short",
                maxlength: "Number too long"
            },
            ExpirationDate: {
                minlength: "Date too short",
                maxlength: "Date too long"
            }
        },
        errorClass: "error",
        validClass: "valid"

    });

});

//https://jqueryvalidation.org/jQuery.validator.addMethod
$.validator.addMethod("GovernmentEmail", function (value, index) {
    return value.toLowerCase().endsWith(".gov");  // it would be safer to consider a regex here. 
}, "Please enter a .gov email");

$.validator.addMethod("strongpassword", function (value, index) {
    return value.match(/[A-Z]/) && value.match(/[a-z]/) && value.match(/\d/);  //check for one capital letter, one lower case letter, one num
}, "Please enter a strong password (one capital, one lower case, and one number");


