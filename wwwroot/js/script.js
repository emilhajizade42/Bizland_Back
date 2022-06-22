const nav_mob_btn = document.querySelector(".nav_mob_btn");
const nav_mob_box = document.querySelector(".nav_mob_box");
const mob_bg = document.querySelector(".mob_bg");
const nav_mob_close = document.querySelector(".nav_mob_close");
nav_mob_btn.addEventListener("click", function (e) {
    nav_mob_box.style.display = "block";
    mob_bg.style.display = "block";
})
nav_mob_close.addEventListener("click",function (e) {
    nav_mob_box.style.display = "none";
    mob_bg.style.display = "none";
})