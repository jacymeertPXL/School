// voorbeeld ajax
$.ajax({
    url: 'https://randomuser.me/api/',
    dataType: 'json',
    success: function(data) {
      console.log(data);
    }
  });


// Voorbeeld curses
fetch('https://randomuser.me/api/')

.then(Response => Response.json())

.then(data => console.log(data))

.catch(error => console.log(error))