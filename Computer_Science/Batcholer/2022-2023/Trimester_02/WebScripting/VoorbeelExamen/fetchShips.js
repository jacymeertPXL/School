const btnGetShips = document.getElementById('btn_get_ships');
const shipList = document.getElementById('ship_list');

function loadCountries() {
    fetch('http://localhost:3000/country')
        .then(response => response.json())
        .then(data => {
            for (let country of data) {
                const option = document.createElement('option');
                option.value = country.id;
                option.textContent = country.name;
                selectCountry.appendChild(option);
            }
        })
        .catch(error => console.error(error));
}

function loadShips() {
    const countryId = document.getElementById('select_country').value;
    fetch(`http://localhost:3000/ship/?country_id=${countryId}`)
        .then(response => response.json())
        .then(data => {
            data.sort((a, b) => b.speed - a.speed);

                shipList.innerHTML = '';

            for (let ship of data) {
                const li = document.createElement('li');
                li.textContent = `${ship.id}, ${ship.name}`;

                if (ship.speed === data[0].speed) {
                    li.style.color = 'red';
                }

                shipList.appendChild(li);
            }
        })
        .catch(error => console.error(error));
}


window.addEventListener('load', loadCountries);
selectCountry.addEventListener('change', loadShips);
btnGetShips.addEventListener('click', loadShips);
