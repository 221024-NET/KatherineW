// let year = prompt('In which year was the ECMAScript 2015 specification published?:');
// if(year == 2015) {
	// alert('This is correct');
	// alert('Awesome!');
// } else {
	// alert('The correct year is 2015.');
// }

//let year = prompt('In which year was the ECMAScript 2015 specification published?:');
// if(year == 2015) {
	// alert('This is correct');
// } else if (year < 2015){
	// alert('Too early.');
// } else if (year > 2015){
	// alert('Too late.');
// }

// // Alternative:
// let year = prompt('In which year was the ECMAScript 2015 specification published?:');
// if (year < 2015){
	// alert('Too early.');
// } else if (year > 2015){
	// alert('Too late.');
// } else {
	// alert('Exactly! This is correct');
// }

// Conditional operator "?":
// Using if-else.
// let isAdult;
// let age = prompt('How old are you?:');
// if(age > 18) {
	// isAdult = true;
// } else {
	// isAdult = false;
// }
// alert('Can you vote?: ' + isAdult);

// // using ?:
// let age = prompt('How old are you?:');
// //let isAdult = (age > 18) ? "Yes you can vote" : "No you cannot vote";
// //let isAdult = (age > 18) ? true : false;
// let isAdult = (age > 18);
// alert('Can you vote?: ' + isAdult);

// Logical operator: OR ||
// alert(true || true);		// true.
// alert(true || false);		// true.
// alert(false || true);		// true;
// alert(false || false);		// false;

// let hour = prompt('Enter a number:');
// if(hour < 10 || hour > 18) {
	// alert('Office is closed.');
// } else {
	// alert('Office is open');
// }

// // AND: &&
// alert(true && true);		// true.
// alert(true && false);		// false.
// alert(false && true);		// false;
// alert(false && false);		// false;
// alert(true && true && true && false);	// false.

// The NOT operator: !
// let isValid = true;
// alert(!isValid);	// false.
// let isAdult = false;
// alert(!isAdult);	// true.

// alert(!0);	// true.
// alert(!1);	// false.
// alert(!2);	// false. Any non-0 number treated like "true".

// while loop:
// let i = 0;
// while(i < 10) {
	// alert(i);
	// //i = i + 1;
	// i++;
// }

// let i = 10;
// while(i > 0) {
	// alert(i);
	// i--;
	// // i = i - 1;
// }

//do-while loop:
// prints 0 and stops.
// let i = 0;
// do {
 // alert(i);
 // i++;
// } while(i > 10);

// Infinite loop.
// let i = 20;
// do {
 // alert(i);
 // i++;
// } while(i > 10);

// This works.
// let i = 0;
// do {
	// alert(i);
	// i++;
// } while(i < 10);

// for loop:
// for(let i = 0; i < 10; i++) {
	// alert(i);
// }
// for(let i = 10; i > 0; i--) {
	// alert(i);
// }

//Breaking out of a loop:
// let sum = 0;
// while(true) {
	// let num = prompt("Enter a number (0 to exit): ");
	// if(num == 0) {
		// break;
	// }
	// sum += num;	// sum = sum + num;
	// alert(sum);
// }

// Continue:
for(let i = 0;i < 10; i++) {
	if(i % 2 == 0) {
		continue;
	}
	alert(i);
}
