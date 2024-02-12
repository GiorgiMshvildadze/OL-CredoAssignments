fetch('https://reqres.in/api/users?page=2', {
    method: 'GET',
    headers: {
        'Content-Type': 'application/json'
    }
} ).then(value => {
    return value.json();
}).then(json => {
    console.log(json);
}).catch(reason => {
    console.log(reason);
}).finally(() => {
    console.log('fetch completed.');
});




fetch('https://reqres.in/api/users', {
    method: 'POST',
    body: JSON.stringify( {
        "name": "morpheus",
        "job": "leader"
    }),
    headers: {
        'Content-Type': 'application/json'
    }
} ).then(value => {
    return value.json();
}).then(json => {
    console.log(json);
}).catch(reason => {
    console.log(reason);
}).finally(() => {
    console.log('fetch completed.');
});