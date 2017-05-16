/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.
function presentialDivs() {
<<<<<<< HEAD
    $("#presidents").children().filter("Div").addClass("president");
=======
    $("#presidents div").addClass("president");
>>>>>>> db4216478a42a4c13166ccc88631c47333f917b0
}

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
<<<<<<< HEAD
    $("#george-washington").addClass("founding-father");
=======


>>>>>>> db4216478a42a4c13166ccc88631c47333f917b0
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
    $(".Republican").addClass("red");
}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
    $(".Democratic").addClass("blue");
}

//Locate all Federalist presidents and add the 'gold' class.
function otherPresidents() {
    $(".Federalist, .Whig, .Democratic-Republican, .Nonpartisan, .National, .Union").addClass("gold");
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
    $("[id*='james']").addClass("james");
}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
    //$("#thomas-jefferson, #theodore-roosevelt, [id*='george-w'], #george-washington").addClass("beginningOfCentury");
    $("h2 + div").addClass("beginningOfCentury")
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    $("#john-adams, #william-mckinley, #bill-clinton, #donald-trump").addClass("endOfCentury");

    //$("h2").prev().addClass("endOfCentury");
    //$("donald-trump").addClass("endOfCentury");
}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
    //if (($("#presidents div p").length = 4) >= 1900 && ($("#presidents div p").length = 4) < 2000) {
    //
    //}
    //$("#presidents").find("h2:contains('1900s')").nextAll(".currency").addClass("appearOnCurrency");
    $("#presidents").find("h2:contains('1900s')").nextAll(".currency").addClass("appearOnCurrency");
    //.nextUntil("h2:contains('2000s'), .currency")
    //

}