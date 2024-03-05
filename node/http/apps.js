const path = require("path");
const fs = require("fs/promises");
const http = require("http");

http.createServer(
    (req, res) => {
        if (req.url === "/") {
            fs.readFile(path.join(_dirname, "index.html")).then(
            (file) => {
                res.writeHead(200,
                    {
                        "Content - Type" : "text/html"
                    }
                );
                res.write(file);
                res.end();
            }
            
            )
        } else if (req.url.match(".css")) {
            fs.readFile(path.join(_dirname, req.url)).then(
                (file) => {
                    res.writeHead(200,
                        {
                            "Content - Type" : "text/css"
                        }
                    );
                    res.write(file);
                    res.end();
                }
                
                ).catch(
                    (error) => {
                        console.log(error);
                        res.end();
                    }
                )
        }
    }
).listen(5500);