var Student = /** @class */ (function () {
    function Student(firstname, middlename, lastname) {
        this.firstname = firstname;
        this.middlename = middlename;
        this.lastname = lastname;
        this.fullname = firstname + " " + middlename + " " + lastname;
    }
    return Student;
}());
function greeter(person) {
    return "Hello there.\n" + person.firstname + " " + person.lastname; // adding person.middlename would throw an error because Person doesn't have a middlename property
}
var user = new Student("General", "Obi-Wan", "Kenobi");
console.log(greeter(user));
function printName(individual) {
    console.log(individual.name);
}
printName({ name: "Kate" });
printName({ label: "Me" });
function printName2(individual) {
    console.log(individual.name);
}
printName2({ name: "Kate" });
printName2({ label: "Me" });
