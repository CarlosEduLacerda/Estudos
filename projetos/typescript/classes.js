"use strict";
class Person {
    constructor(id, name, age) {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    sayMyName() {
        return this.name;
    }
}
// const person1 = new Person(1, "nada", 5);
class Employee extends Person {
    constructor(id, name, age) {
        super(id, name, age);
    }
    whoAmI() {
        return this.name;
        // return this.age; -> 'age' não aparece por este ser 'private' só pondendo ser acessado na própria classe
    }
}
// Forma mais eficiente de definir uma Classe // Refatorada
class PersonRefact {
    constructor(id, name, age) {
        this.id = id;
        this.name = name;
        this.age = age;
    }
}
