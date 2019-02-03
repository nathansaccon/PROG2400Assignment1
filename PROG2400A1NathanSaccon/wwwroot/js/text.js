// Nathan Saccon
// Created: Jan 18, 2019


// Checks which effects to apply to the entered text

function boxChecker() {

    var enteredText = document.getElementById("input").value;

    document.getElementById("text").innerText = enteredText;

    // Check if background should be green. 
    if (document.getElementById("green").checked == true) {
        document.getElementById("text").style.backgroundColor = "green";
        document.getElementById("text").style.color = "white";
    } else {
        document.getElementById("text").style.backgroundColor = "transparent";
        document.getElementById("text").style.color = "black";
    }
    // Check if text should be reversed
    if (document.getElementById("reverse").checked == true) {
        document.getElementById("text").innerText = reverseString(enteredText);
    }
    // Check if text should be bold
    if (document.getElementById("bold").checked == true) {
        document.getElementById("text").style.fontWeight = "bold";
    } else {
        document.getElementById("text").style.fontWeight = "normal";
    }
    // Check if text should be italics
    if (document.getElementById("italic").checked == true) {
        document.getElementById("text").style.fontStyle = "italic";
    } else {
        document.getElementById("text").style.fontStyle = "normal";
    }

}

// Reverse the order of a string
function reverseString(str) {
    var splitString = str.split("");
    var reverseArray = splitString.reverse();
    var joinArray = reverseArray.join("");
    return joinArray;
}