var foodUrl = 'https://raw.githubusercontent.com/bear80416/LocalFoods/main/data.json';
var data = new XMLHttpRequest();
data.open('GET', foodUrl);
data.responseType = 'json';
data.send();

data.onload = function () {
    var localFood = data.response;
    showFood(localFood);
    showCity(localFood);
    var menuCity = document.getElementById('menuCity');
    var menuTown = document.getElementById('menuTown');
    var foodsData = document.getElementById('foodsData');
    menuCity.addEventListener('change', function () {
        let selectedCity = localFood.filter((i) => i.City == menuCity.value);
        showTown(selectedCity);
        foodsData.innerHTML = '';
        showFood(selectedCity);
    })
    menuTown.addEventListener('change', function () {
        foodsData.innerHTML = '';
        searchFoods(localFood)
    })
}

function loading() {
    var loading = document.getElementById('loading');
    loading.style.display = 'flex';
    let timeOut = setTimeout(function () {
        loading.style.display = 'none';
        clearTimeout(timeOut);
    }, 2000);
}

function showCity(Obj) {
    var areaList = [];
    for (var i = 0; i < Obj.length; i++) {
        var area = Obj[i].City;
        areaList.push(area);
    }
    var result = areaList.filter(function (element, index, arr) {
        return arr.indexOf(element) === index;
    })
    console.log(result);

    for (var i = 0; i < result.length; i++) {
        menuCity.options.add(new Option(result[i], result[i]));
    }
}

function showTown(Obj) {
    menuTown.options.length = 0;
    var townList = [];
    for (var i = 0; i < Obj.length; i++) {
        var area = Obj[i].Town;
        townList.push(area);
    }
    var result = townList.filter(function (element, index, arr) {
        return arr.indexOf(element) === index;
    })

    console.log(result);

    for (let i = 0; i < result.length; i++) {
        menuTown.options.add(new Option(result[i], result[i]));
    }
}

function searchFoods(data) {
    let searchFoods = [];
    data.forEach((i) => {
        if (i.City == menuCity.value && i.Town == menuTown.value) {
            searchFoods.push(i);
        }
    });
    console.log(searchFoods)
    showFood(searchFoods)
}

function showFood(Obj) {
    loading();
    var foods = Obj;
    for (var i = 0; i < foods.length; i++) {
        var card = document.createElement('div');
        var h2 = document.createElement('h2');
        var city = document.createElement('div');
        var cardHead = document.createElement('div');
        var cardBody = document.createElement('div');
        var area = document.createElement('i');
        var cardInfo = document.createElement('div');
        var text = document.createElement('p');
        var cardImg = document.createElement('div');
        var cardCover = document.createElement('div');

        h2.textContent = foods[i].Name;
        city.textContent = foods[i].City;
        area.textContent = foods[i].Town;

        var str = foods[i].HostWords;
        var strLen = str.length;
        if (strLen > 40) {
            str = str.slice(0, 40) + "...";
        }
        text.innerHTML = str;
        cardImg.innerHTML = `<img src="${foods[i].PicURL}">`;

        card.appendChild(cardHead);
        card.appendChild(city);
        card.appendChild(cardBody);
        cardHead.appendChild(cardCover);
        cardHead.appendChild(cardImg);
        cardBody.appendChild(area);
        cardBody.appendChild(h2);
        cardBody.appendChild(cardInfo);
        cardInfo.appendChild(text);

        foodsData.appendChild(card);
        card.className = ('col-12 col-md-6 col-lg-4 col-xl-4 fcard');
        city.className = 'City';
        cardHead.className = 'fcard-head';
        cardImg.className = 'fcard-img';
        cardCover.className = 'fcard-cover';
        cardBody.className = 'fcard-body';
        cardInfo.className = 'fcard-info';
    }
}
