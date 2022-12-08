var ClassB = /** @class */ (function () {
    function ClassB() {
    }
    ClassB.prototype.display = function () {
        console.log("This is ClassB");
    };
    return ClassB;
}());
var ClassC = /** @class */ (function () {
    function ClassC() {
    }
    ClassC.prototype.display = function () {
        console.log("This is ClassC");
    };
    return ClassC;
}());
var b = new ClassB();
var c = new ClassC();
b.display();
c.display();
