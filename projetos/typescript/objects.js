"use strict";
// Type - Semelhante ao dicionário do Python -> Definir um objeto
// '?' -> Corresponde a ser opcional informar os dados
const user = {
    firstName: "Nada",
    age: 2,
    orders: [{ productId: "1", price: 800 }],
    register() {
        return "a";
    },
};
const nadada = (message) => { };
nadada(user.password); // '!' -> Retira o erro de undefined, pois informa ao TS que tal informação foi definida
const author = {
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
const emailUser = {
    email: "nadaxnada",
    firstName: "Nasa",
    login() {
        return 2;
    },
};
const newauthor = {
    email: "nadaxnada",
    firstName: "Nasa",
    books: [],
    login() {
        return 3;
    },
};
