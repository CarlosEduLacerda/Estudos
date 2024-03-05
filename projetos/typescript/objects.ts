// Type - Semelhante ao dicionário do Python -> Definir um objeto

type Order = {
  productId: string;
  price: number;
};

type User = {
  firstName: string;
  age: number;
  email?: string;
  password?: string;
  orders: Order[];
  register?(): string;
};

// '?' -> Corresponde a ser opcional informar os dados

const user: User = {
  firstName: "Nada",
  age: 2,
  orders: [{ productId: "1", price: 800 }],
  register() {
    return "a";
  },
};

const nadada = (message: string) => {};

nadada(user.password!); // '!' -> Retira o erro de undefined, pois informa ao TS que tal informação foi definida

// Unions -> Unir 2 Types

type Author = {
  books: string[];
};

const author: Author & User = {
  firstName: "Nada",
  age: 200,
  email: "nada123",
  books: ["Nada x nada"],
  orders: [],
  password: "098123123",
  register() {
    return "b";
  },
};

// Interfaces -> Permite 'readonly' diferente de Types. readonly = apenas leitura

interface UserInterface {
  readonly firstName: string;
  email: string;
  login(): number;
}

const emailUser: UserInterface = {
  email: "nadaxnada",
  firstName: "Nasa",
  login() {
    return 2;
  },
};

interface AuthorInterface {
  books: string[];
}

const newauthor: UserInterface & AuthorInterface = {
  email: "nadaxnada",
  firstName: "Nasa",
  books: [],
  login() {
    return 3;
  },
};
