// Nathan Saccon
// Created: Jan 18, 2019


// Checks which effects to apply to the entered text

function boxChecker() {

    var enteredText = document.getElementById("input").value;

    document.getElementById("text").innerText = enteredText;

    if (document.getElementById("green").checked == true) {
        document.getElementById("text").style.backgroundColor = "green";
    }
}