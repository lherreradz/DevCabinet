// Express server on port 3000


var express = require('express');
var app = express(), bodyParser = require('body-parser'), fs = require('fs'), port = 3000;

app.get('/', function(req, res) {
    console.log('GET /');
    return res.send('Hello World!');
});

app.listen(port, () => {
    console.log(`Server listening on the port::::::${port}`);
});