if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(fetchWeather);
}
async function fetchWeather(position) {
        const response = await fetch(`https://api.openweathermap.org/data/2.5/weather?lat=${position.coords.latitude}&lon=${position.coords.longitude}&appid=4f569a4c86a44e51f713afde65b2b35c&units=metric&lang=nl`);
        const data = await response.json();
        displayWeather(data);
}

function displayWeather(data) {
        const weatherDiv = document.getElementById('weather');

        // Locatie
        const locationP = document.createElement('p');
        const locationStrong = document.createElement('strong');
        locationStrong.appendChild(document.createTextNode('Locatie: '));
        locationP.appendChild(locationStrong);
        locationP.appendChild(document.createTextNode(data.name));
        weatherDiv.appendChild(locationP);

        // Temperatuur
        const temperatureP = document.createElement('p');
        const temperatureStrong = document.createElement('strong');
        temperatureStrong.appendChild(document.createTextNode('Temperatuur: '));
        temperatureP.appendChild(temperatureStrong);
        temperatureP.appendChild(document.createTextNode(data.main.temp + '°C'));
        weatherDiv.appendChild(temperatureP);

        // Vochtigheidsgraad
        const humidityP = document.createElement('p');
        const humidityStrong = document.createElement('strong');
        humidityStrong.appendChild(document.createTextNode('Vochtigheidsgraad: '));
        humidityP.appendChild(humidityStrong);
        humidityP.appendChild(document.createTextNode(data.main.humidity + '%'));
        weatherDiv.appendChild(humidityP);

        // Windsnelheid
        const windSpeedP = document.createElement('p');
        const windSpeedStrong = document.createElement('strong');
        windSpeedStrong.appendChild(document.createTextNode('Windsnelheid: '));
        windSpeedP.appendChild(windSpeedStrong);
        windSpeedP.appendChild(document.createTextNode((data.wind.speed * 3.6).toFixed(2) + ' km/h'));
        weatherDiv.appendChild(windSpeedP);
}
