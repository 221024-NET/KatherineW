// // Declare a class with a ctor and a method.
// class User {
	// constructor(nm) {
		// this.name = nm;
		// this.city = 'Dallas';
	// }
	
	// sayHi() {
		// alert(this.name + ' ' + this.city);
	// }
// }

// User.prototype.sayHello = function() {
	// alert(`Hello there ${this.name}`); 
// }

// // Usage of the class.
// let user1 = new User('John');
// user1.sayHi();
// let user2 = new User('Mary');
// user2.sayHi();
// // user1.sayHi();
// // alert(typeof User);		// function.

// // alert(User.prototype.sayHi);				// code of sayHi().
// // alert(User.prototype.constructor);			// code of the ctor.
// // alert(User === User.prototype.constructor);	// true.

// user1.sayHello();

// // Getters and Setters.
// class User {
	// constructor(nm) {
		// this.name = nm;
		// this.lastname = 'Smith';
	// }
	
	// // getter.
	// get name() {
		// return this._name;
	// }
	
	// // setter.
	// set name(value) {
		// if(value.length < 4) {
			// alert(`"${value}" Name is too short. Must be atlest 4 characters.`);
			// return;
		// }
		// this._name = value;
	// }
	
	// // Readonly property.
	// get fullname() {
		// return `${this.lastname}, ${this._name}`;
	// }
// }

// // let user1 = new User('John');
// // alert(user1.name);
// // user1.name = 'Johnathan'
// // alert(user1.name);
// let user1 = new User('John');
// alert(user1.name);
// let user2 = new User('Joe');	// Error.
// alert(user2.name);			// undefined.
// user1.name = 'May';			// Error.
// alert(user1.name);			// John.

// alert(user1.fullname);		// Smith, John.
// user1.fullname = 'Joe Pricey';
// alert(user1.fullname);		// Smith, John.

// Class fields:
class User {
	name = 'John';	// class field. or property.
	
	constructor(ct) {
		this.city = ct;
	}
	
	sayHi() {
		alert(`Hello ${this.name}`);
	}
}

let user1 = new User();
user1.sayHi();
alert(user1.name);				// John.
alert(User.prototype.name);		// undefined.
alert(User.prototype.city);		// undefined.
alert(User.prototype.sayHi);
