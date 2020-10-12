var selfie = document.getElementById("selfie");
var c = 1;
setInterval("changeImg()", "5000");

function changeImg() {
    selfie.innerHTML = `<img src="https://raw.githubusercontent.com/bear80416/HenryWuCompany/master/HenryWuCompany/Assets/Img/Index/${c}.jpg" alt="">`;
    c = c + 1;
    if (c == 3) {
        c = c - 2;
    }
}
