const btn = document.getElementById("btn");
const xhr = new XMLHttpRequest();
const tmp = new XMLHttpRequest();
let search_city, index, j;

const error = document.getElementById("error-404");
const main = document.getElementById("main");
error.style.visibility = "hidden";

btn.addEventListener("click", (event) => {
    event.preventDefault();
    
    search_city = (document.getElementById("search-city").value).toLowerCase();
    const api_url = `https://api.openweathermap.org/data/2.5/weather?q=${search_city}&appid=c7ddc5e4eec2098deecc3642c7d61151&units=metric`;
    
    xhr.open("GET", api_url);
    xhr.send();
});

xhr.onload = () => {
    const city = document.getElementById("city");
    const date = document.getElementById("date");
    const weather_type = document.getElementById("weather-type");
    const main_img = document.getElementById("main-img");
    const temperature = document.getElementById("temperature");
    const min_temperature = document.getElementById("min-temperature");
    const max_temperature = document.getElementById("max-temperature");
    const wind_speed = document.getElementById("wind-speed");
    
    let result = JSON.parse(xhr.responseText);

    if (result.message == "city not found")
    {
        error.style.visibility = "visible";
        main.style.visibility = "hidden";
        return;
    }
    else {
        error.style.visibility = "hidden";
        main.style.visibility = "visible";
    }

    let date_now = new Date(result.dt * 1000);

    main_img.src = `images/${result.weather[0].icon}.png`;
    main_img.style.width = '200%';
    city.textContent = result.name;
    date.textContent = date_now.toDateString();
    weather_type.textContent = result.weather[0].main;
    temperature.textContent = Math.round(result.main.temp) + "°C"; 
    min_temperature.textContent = "Min temperature " + Math.round(result.main.temp_min) + "°C"; 
    max_temperature.textContent = "Max temperature " + Math.round(result.main.temp_max) + "°C"; 
    wind_speed.textContent = "Wind speed " + result.wind.speed;
    
    let time = [8, 11, 14, 16, 19, 22];
    for (let i = 0; i < 6; i++) {
        const url = `https://api.openweathermap.org/data/2.5/onecall?lat=${result.coord.lat}&lon=${result.coord.lon}&appid=c7ddc5e4eec2098deecc3642c7d61151&exclude=daily&units=metric`;
        index = i;
        j = time[i];

        tmp.open("GET", url, false);
        tmp.send();
    }
    
    search_city.value = "";
}

tmp.onload = () => {
    let result = JSON.parse(tmp.responseText);

    const day = document.getElementById(`day`);
    const type = document.getElementById(`type-${index + 1}`);
    const img = document.getElementById(`img-${index + 1}`);
    const temp = document.getElementById(`temp-${index + 1}`);
    const wind = document.getElementById(`wind-${index + 1}`);

    day.textContent = new Date(result.current.dt * 1000).toLocaleString('en-us', {  weekday: 'long' });
    type.textContent = result.hourly[j].weather[0].main;
    temp.textContent = Math.round(result.hourly[j].temp) + "°C";
    wind.textContent = result.hourly[j].wind_speed;
    img.src = `images/${result.hourly[j].weather[0].icon}.png`;
}