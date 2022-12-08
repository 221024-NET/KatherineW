class person {
    public firstname: string;
    public lastname: string;
    private _fullname: string;

    constructor(fname: string, lname: string) {
        this.firstname = fname;
        this.lastname = lname;
    }

    fullname() :string {
        return `${this.firstname}, ${this.lastname}`;
    }
}

var aPerson = new person('John', 'Smith');
console.log(aPerson.fullname());