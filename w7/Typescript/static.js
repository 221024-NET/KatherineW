var Circle = /** @class */ (function () {
    function Circle() {
    }
    Circle.calculateArea = function (radius) {
        return this.pi * radius * radius;
    };
    Circle.prototype.calculateCircumference = function (radius) {
        return 2 * Circle.pi * radius;
    };
    Circle.pi = 3.14;
    return Circle;
}());
console.log(Circle.pi);
console.log("Area of the circle is " + Circle.calculateArea(5));
var shape = new Circle();
// shape.  // whoops! no area available - static methods can't be called from instances
console.log("Area of the circle is " + shape.calculateCircumference(5));
