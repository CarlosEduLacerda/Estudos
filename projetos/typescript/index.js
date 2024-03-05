"use strict";
// Tipos básicos TS
let age = 5;
const firstName = "Carlos";
const isValid = true;
let idk = 5;
idk = "12";
idk = true;
const ids = [1, 2, 3, 4, 5];
const booleans = [true, false, true, true];
const names = ["Nada", "Nada", "E Mais Nada"];
// Tuple - Tupla
const person = [1, "Nada"];
// Lista de Tuplas
const people = [
    [1, "Nada1"],
    [2, "Nada2"],
];
// Intersections
const producId = "1";
// Enum
var Direction;
(function (Direction) {
    Direction[Direction["Up"] = 1] = "Up";
    Direction[Direction["Down"] = 2] = "Down";
    Direction["Left"] = "Esquerda";
    Direction["Right"] = "Direita";
})(Direction || (Direction = {}));
const direction = Direction.Right;
// Type Assertions
const productName = "Boné";
// let itemId = productName as string;
let itemId = productName;
console.log(direction);
