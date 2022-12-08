class Person {
    name: string = "Brandon"; // default value
    saying: string;

    constructor() {
        this.saying = "Winterfell";
    }
}

var ned = new Person();
ned.name = "Ned";
ned.saying = "Winter is coming";

var abc = new Person();
console.log(ned.name + " " + ned.saying);
console.log(abc.name + " " + abc.saying);