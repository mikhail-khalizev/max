"use strict";

function onMouseMove(e) {
    event.preventDefault();
    if (connection.connectionState === 1 /* Connected */) {
        connection.send("MouseEvent", { x: e.offsetX, y: e.offsetY, buttons: e.buttons });
    }

    //document.getElementById("mouse").innerHTML = stringifyEvent(e);
}

function onMouseOut() {
    if (connection.connectionState === 1 /* Connected */) {
        connection.send("MouseEvent", {});
    }

    //document.getElementById("mouse").innerHTML = "";
}

function onKeyboard(e) {
    if (connection.connectionState === 1 /* Connected */) {
        connection.send("KeyboardEvent", { key: e.key });
    }

    //document.getElementById("keyboard").innerHTML = stringifyEvent(e);
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

// ---

var connection = new signalR.HubConnectionBuilder().withUrl("/signalr").build();

connection.on("UpdateImage", function (url) {
    $("#screen").attr("src", url);
});

async function start() {
    try {
        await connection.start();
    } catch (err) {
        console.log(err);
        setTimeout(() => start(), 5000);
    }
};

connection.onclose(() => {
    setTimeout(() => start(), 5000);
});

start();


$("#screen").on('contextmenu', function(e) {
    e.preventDefault();
});

$("body").keyup(onKeyboard);
$("body").keypress(onKeyboard);
$("body").keydown(onKeyboard);
