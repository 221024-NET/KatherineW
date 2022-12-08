class Student {
    fullname: string;

    constructor(public firstname: string, public middlename: string, public lastname:string) {
        this.fullname = firstname + " " + middlename + " " + lastname;
    }
}

interface Person {
    firstname: string;
    lastname: string;
}

function greeter(person: Person) {
    return "Hello there.\n" + person.firstname + " " + person.lastname; // adding person.middlename would throw an error because Person doesn't have a middlename property
}

let user = new Student("General", "Obi-Wan", "Kenobi");
console.log(greeter(user));

function printName(individual) {
    console.log(individual.name);
}

printName({name:"Kate"});
printName({label:"Me"});

interface Individual {
    name: string;
    age?: string; // 2/2 ? makes it optional
}

function printName2(individual: Individual){
    console.log(individual.name);
}

printName2({name:"Kate"}); // 1/2 error without specifying name unless [ln 30]
printName2({label:"Me"}); // error - interface individual has no label property