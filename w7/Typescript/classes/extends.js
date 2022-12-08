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
var NormalPerson = /** @class */ (function () {
    function NormalPerson(nm) {
        this.name = nm;
    }
    NormalPerson.prototype.dance = function () {
        console.log("".concat(this.name, " is dancing."));
    };
    return NormalPerson;
}());
var aPerson = new NormalPerson("John");
aPerson.dance();
var AwesomePerson = /** @class */ (function (_super) {
    __extends(AwesomePerson, _super);
    function AwesomePerson() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    AwesomePerson.prototype.dance = function () {
        console.log("Sooooo awesome.");
        _super.prototype.dance.call(this); // call the function of the base class
    };
    return AwesomePerson;
}(NormalPerson));
var rob = new AwesomePerson("Rob");
rob.dance();
