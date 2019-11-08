
toggleNavbar: function () {
    var navbar = document.querySelector("#nav");

    if (navbar.classList.contains("collapse")) {
        navbar.classList.remove("collapse");
    } else {
        navbar.classList.add("collapse");
    }
}
