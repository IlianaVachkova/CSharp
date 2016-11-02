(function onButtonClick(events, arguments) {
    var myWindow = window;
    var browser = myWindow.navigator.appCodeName;
    var isMozzila;

    if (browser == "Mozilla") {
        isMozzila = true;
    }
    else {
        isMozzila = false;
    }

    if (isMozzila) {
        alert("Yes");
    }
    else {
        alert("No");
    }

    console.log(window.navigator.appCodeName);
})();