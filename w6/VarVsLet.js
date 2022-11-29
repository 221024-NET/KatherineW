// // var is function scoped.
// function greet() {
	// var msg = 'Hello';
	// console.log(msg);
// }
// greet();
// //console.log(msg);		// Error.

// // let is block-scoped.
// function greeting() {
	// let newMsg = 'Hello there!';
	
	// if(newMsg == 'Hello there!') {
		// let text = 'This is JavaScript.';
		// console.log(newMsg + ' ' + text);
	// }

	// console.log(newMsg + ' ' + text);	// Error!
// }
// greeting();
// console.log(newMsg);	// Error!
// console.log(text);		// Error!

// Redeclare variables.
// using var.
// var a = 5;
// console.log(a);		// 5.
// {
	// var a = 3;
	// console.log(a);	// 3.
// }
// console.log(a);		// 3.

// // using let.
// let x = 51;
// console.log(x);		// 51.
// {
	// let x = 31;
	// console.log(x);	// 31.
// }
// console.log(x);		// 51.

// hoisting.
// let x = 51;
// console.log(x);		// 51.
// {
	// x = 41;			// Error! Cannot access 'x' before initialization
	// let x = 31;
	// console.log(x);
// }
// console.log(x);

console.log(x1);
var x1 = 51;

