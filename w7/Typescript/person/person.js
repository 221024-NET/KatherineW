var person = /** @class */ (function () {
    function person(fname, lname) {
        this.firstname = fname;
        this.lastname = lname;
    }
    person.prototype.fullname = function () {
        return "".concat(this.firstname, ", ").concat(this.lastname);
    };
    return person;
}());
var aPerson = new person('John', 'Smith');
console.log(aPerson.fullname());
