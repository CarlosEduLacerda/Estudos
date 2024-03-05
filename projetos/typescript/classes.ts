interface IPerson {
  id: number;
  sayMyName(): string;
}

class Person implements Person {
  readonly id: number;
  protected name: string;
  private age: number;

  constructor(id: number, name: string, age: number) {
    this.id = id;
    this.name = name;
    this.age = age;
  }
  sayMyName(): string {
    return this.name;
  }
}

// const person1 = new Person(1, "nada", 5);

class Employee extends Person {
  constructor(id: number, name: string, age: number) {
    super(id, name, age);
  }

  whoAmI() {
    return this.name;
    // return this.age; -> 'age' não aparece por este ser 'private' só pondendo ser acessado na própria classe
  }
}

// Forma mais eficiente de definir uma Classe // Refatorada

class PersonRefact {
  constructor(
    readonly id: number,
    protected name: string,
    private age: number
  ) {}
}
