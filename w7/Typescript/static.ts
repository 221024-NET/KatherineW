class Circle {
    static pi: number = 3.14;

    static calculateArea(radius: number) {
        return this.pi * radius * radius;
    }

    calculateCircumference(radius: number) {
        return 2 * Circle.pi * radius;
    }
}

console.log(Circle.pi);
console.log("Area of the circle is " + Circle.calculateArea(5));

var shape = new Circle();
// shape.  // whoops! no area available - static methods can't be called from instances
console.log("Area of the circle is " + shape.calculateCircumference(5));