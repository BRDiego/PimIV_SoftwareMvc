var btnSingnin = document.querySelector("#signin");
var btnSingnup = document.querySelector("#signup");


var body = document.querySelector("body");

btnSingnin.addEventListener("click", function () {
    body.className = "signin-js";
});

btnSingnup.addEventListener("click", function () {
    body.className = "signup-js";
});
