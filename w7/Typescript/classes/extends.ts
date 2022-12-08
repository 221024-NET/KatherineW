class NormalPerson {
    name: string;

    constructor(nm: string) {
        this.name = nm;
    }

    dance() {
        console.log(`${this.name} is dancing.`)
    }
}

var aPerson = new NormalPerson("John");
aPerson.dance();

class AwesomePerson extends NormalPerson {
    dance() {
        console.log("Sooooo awesome.");
        super.dance(); // call the function of the base class
    }
}

var rob = new AwesomePerson("Rob");
rob.dance();