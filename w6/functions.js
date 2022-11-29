// function showMessage() {
	// alert("Welcome to JavaScript");
// }

// showMessage();

// function showMessageNew(name) {
	// alert(`Hello ${name}. Welcome to JavaScript`);
// }

// showMessageNew("John");
// showMessageNew("Mary");

// Local variables:
// function showMessage() {
	// let msg = "Hello, this is JavaScript.";
	// alert(msg);
// }

// showMessage();
// //alert(msg);		// error.

// function showMessageAnother() {
	// alert(msg);
// }

// showMessageAnother();

// Outer Variables:
// let name = 'John';
// function showMessage() {
	// let msg = "Hello, this is JavaScript. Welcome " + name;
	// alert(msg);
// }

// function foo() {
	// name = 'Mary';
// }

// showMessage();
// //alert(msg);		// Error.
// alert(name);
// foo();
// alert(name);

// Function params:
// function foo(param1, param2) {
	// alert(param1);
	// alert(param2);
// }

// foo("Hello", "there");
// alert(param1);		// Error.

// Default values to function params:
// function showMessage(sender, body = "Please provide text here") {
	// alert(`Message from ${sender} says ${body}`);
// }

// showMessage('John', "Can't wait for the party!");
// showMessage('Mary');		// uses the default value for param "body".

// Return value from function:
// function add(num1, num2) {
	// return num1 + num2;
// }
// alert(add(10,24));

function checkAge(age) {
	if(age > 18) {
		return true;
	} else {
		return confirm("Do you have permission from your parents?")
	}
}

let age = prompt('How old are you?:');
if(checkAge(age)) {
	alert('Access granted.');
} else {
	alert('Access denied');
}
