var http = require("http");
var time = require("./modules/timemodule.js");
var url = require("url");

http
  .createServer(function (req, res) {
    res.writeHead(200, { "Content-Type": "text/plain" });
    res.write("The date and time are currently: " + time.myDateTime());
    res.write("\nHello world\n");
    res.write(req.url);
    var q = url.parse(req.url, true).query;
    var txt = q.year + " " + q.month; // try http://localhost:8080/?year=2017&month=July
    res.write("\n" + txt);
    res.end();
  })
  .listen(8080);
