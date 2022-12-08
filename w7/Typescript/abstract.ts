abstract class Human {
    name: string;
    abstract city: string;

    constructor(nm: string) {
        this.name = nm;
    }

    display(): void {
        console.log(`${this.name} is from ${this.city}`);
    }

    abstract find(string): Human;
}

//var h = new Human;  // cannot creat an instance of an abstract class
class Employee extends Human {
    empCode: number;
    city: string;

    constructor(nm: string, code: number, ct:string) {
        super(nm);
        this.name = nm;
        this.city = ct;
        this.empCode = code;
    }

    find(nameOfPerson: string) : Human {
        return new Employee(nameOfPerson, 125, "Reston");
    }
}

let emp1: Employee = new Employee("James", 200, "Dallas");
emp1.display();
let emp2 = emp1.find("Steve");
emp2.display();