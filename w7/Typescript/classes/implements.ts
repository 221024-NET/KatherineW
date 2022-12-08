interface A {
    display(): void;
}

class ClassB implements A {
    display(): void {
        console.log("This is ClassB");
    }
}

class ClassC implements A {
    display(): void {
        console.log("This is ClassC");
    }
}

var b = new ClassB();
var c = new ClassC();
b.display();
c.display();