// class Animal {
	// constructor(nm) {
		// this.name = nm;
		// this.speed = 0;
	// }
	
	// run(speed) {
		// this.speed = speed;
		// alert(`${this.name} runs at a speed of ${this.speed}`);
	// }
	
	// stop() {
		// this.speed = 0;
		// alert(`${this.name} stopped running.`);
	// }
// }

// let dog = new Animal("Max");
// dog.run(10);
// dog.stop();

// class Rabbit extends Animal {
	// hide() {
		// alert(`${this.name} is now hidden!`);
	// }
// }

// let rabbit = new Rabbit('White Rabbit');
// rabbit.run(5);
// rabbit.hide();
// rabbit.stop();

// dog.hide();		// Error.

// Override methods.
// class Animal {
	// constructor(nm) {
		// this.name = nm;
		// this.speed = 0;
	// }
	
	// run(speed) {
		// this.speed = speed;
		// alert(`${this.name} runs at a speed of ${this.speed}`);
	// }
	
	// stop() {
		// this.speed = 0;
		// alert(`${this.name} stopped running.`);
	// }
// }

// let dog = new Animal("Max");
// dog.run(10);
// dog.stop();

// class Rabbit extends Animal {
	// hide() {
		// alert(`${this.name} is now hidden!`);
	// }
	
	// stop() {
		// this.speed = this.speed - 1;
		// alert(`${this.name} is slowing down.`);
	// }
	
// }

// let rabbit = new Rabbit('White Rabbit');
// rabbit.run(5);
// rabbit.hide();
// rabbit.stop();

// Override the ctor:
class Animal {
	constructor(nm) {
		this.name = nm;
		this.speed = 0;
	}
	
	run(speed) {
		this.speed = speed;
		alert(`${this.name} runs at a speed of ${this.speed}`);
	}
	
	stop() {
		this.speed = 0;
		alert(`${this.name} stopped running.`);
	}
}

let dog = new Animal("Max");
dog.run(10);
dog.stop();


let earLength = "default";
class Rabbit extends Animal {
	// override the ctor.
	constructor(nm, earLength) {
		super(nm);	// mandatory to call ctor of the base class.
		// These 2 are not required as they are done in the ctor of the base class.
		// this.speed = 0;
		// this.name = nm;
		this.earLength = earLength;
	}
	
	hide() {
		alert(`${this.name} is now hidden! It's ear is ${this.earLength} inches long.`);
	}
	
	stop() {
		this.speed = this.speed - 1;
		alert(`${this.name} is slowing down to ${this.speed}.`);
	}
	
}

let rabbit = new Rabbit('White Rabbit', 7);		// Error.
rabbit.run(5);
rabbit.hide();
rabbit.stop();

