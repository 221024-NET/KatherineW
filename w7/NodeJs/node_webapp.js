var http = require("http");
var uc = require("upper-case");

http.createServer(function (req, res) {
    // send an http request
    res.writeHead(200, {'Content-Type': 'text/plain'});
    res.write(uc.upperCase("This should be printed in upper case.\n"));
    res.end("This is an example of a node.js web app.\n");
}).listen(5000, () => console.log("Server running at http://localhost:5000"));