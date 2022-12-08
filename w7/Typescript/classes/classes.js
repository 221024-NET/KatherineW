var Person = /** @class */ (function () {
    function Person() {
        this.name = "Brandon"; // default value
        this.saying = "Winterfell";
    }
    return Person;
}());
var ned = new Person();
ned.name = "Ned";
ned.saying = "Winter is coming";
var abc = new Person();
console.log(ned.name + " " + ned.saying);
console.log(abc.name + " " + abc.saying);
