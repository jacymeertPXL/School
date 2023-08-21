**GET-verzoek:**
````javascript
// Een GET-verzoek om gegevens op te halen
fetch('https://jsonplaceholder.typicode.com/posts/1')
    .then(response => response.json())
    .then(data => console.log('GET Response:', data))
    .catch(error => console.error('Fout bij GET-verzoek:', error));

`````

**POST-verzoek:**
````javascript
const newPost = {
    title: 'Nieuwe post',
    body: 'Dit is de inhoud van de nieuwe post',
    userId: 1
};

// Een POST-verzoek om gegevens te maken
fetch('https://jsonplaceholder.typicode.com/posts', {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json'
    },
    body: JSON.stringify(newPost)
})
    .then(response => response.json())
    .then(data => console.log('POST Response:', data))
    .catch(error => console.error('Fout bij POST-verzoek:', error));

`````

**PUT-verzoek:**
````javascript
const updatedPost = {
    id: 1,
    title: 'Bijgewerkte post',
    body: 'Dit is de bijgewerkte inhoud van de post'
};

// Een PUT-verzoek om gegevens bij te werken
fetch('https://jsonplaceholder.typicode.com/posts/1', {
    method: 'PUT',
    headers: {
        'Content-Type': 'application/json'
    },
    body: JSON.stringify(updatedPost)
})
    .then(response => response.json())
    .then(data => console.log('PUT Response:', data))
    .catch(error => console.error('Fout bij PUT-verzoek:', error));

`````

**DELETE-verzoek:**
````javascript
// Een DELETE-verzoek om gegevens te verwijderen
fetch('https://jsonplaceholder.typicode.com/posts/1', {
    method: 'DELETE'
})
    .then(response => {
        if (response.status === 200) {
            console.log('DELETE Succesvol');
        } else {
            console.log('DELETE Mislukt');
        }
    })
    .catch(error => console.error('Fout bij DELETE-verzoek:', error));

`````

#Web-Scripting