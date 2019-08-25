"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/ws").build();

//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("UpdateImage", function (url) {
    document.getElementById("screen").src = url;
});

connection.start().then(function () {
    //document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").value;
//    var message = document.getElementById("messageInput").value;
//    connection.invoke("SendMessage", user, message).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});

// ---

function onMouseMove(e) {
    document.getElementById("mouse").innerHTML = stringifyEvent(e);
}

function onMouseOut() {
    document.getElementById("mouse").innerHTML = "";
}

function onKeyboard(e) {
    document.getElementById("keyboard").innerHTML = stringifyEvent(e);
}

function stringifyEvent(e) {
    var obj = {};
    for (let k in e) {
        obj[k] = e[k];
    }
    return JSON.stringify(obj, (k, v) => {
        if (v instanceof Node) return 'Node';
        if (v instanceof Window) return 'Window';
        return v;
    }, " ");
}