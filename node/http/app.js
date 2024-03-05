const os = require("path");
const fs = require("fs");
const {Person, Car} = require("./person.js");
let person = new Person("Daniel", "L", 1);
let a = 1;
console.log(person); 
console.log();
fs.readFile(
    path.join(_dirname, "person.js"),
    (error, data) => {
        if (error) {
            console.log(error);
        } else {
            console.log(data);
        }
    }
)
