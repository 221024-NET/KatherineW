var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Human = /** @class */ (function () {
    function Human(nm) {
        this.name = nm;
    }
    Human.prototype.display = function () {
        console.log("".concat(this.name, " is from ").concat(this.city));
    };
    return Human;
}());
//var h = new Human;  // cannot creat an instance of an abstract class
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(nm, code, ct) {
        var _this = _super.call(this, nm) || this;
        _this.name = nm;
        _this.city = ct;
        _this.empCode = code;
        return _this;
    }
    Employee.prototype.find = function (nameOfPerson) {
        return new Employee(nameOfPerson, 125, "Reston");
    };
    return Employee;
}(Human));
var emp1 = new Employee("James", 200, "Dallas");
emp1.display();
var emp2 = emp1.find("Steve");
emp2.display();
