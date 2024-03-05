// Tipos básicos TS

let age: number = 5;
const firstName: string = "Carlos";
const isValid: boolean = true;
let idk: any = 5;

idk = "12";
idk = true;

const ids: number[] = [1, 2, 3, 4, 5];
const booleans: boolean[] = [true, false, true, true];
const names: string[] = ["Nada", "Nada", "E Mais Nada"];

// Tuple - Tupla

const person: [number, string] = [1, "Nada"];

// Lista de Tuplas

const people: [number, string][] = [
  [1, "Nada1"],
  [2, "Nada2"],
];

// Intersections

const producId: string | number | boolean = "1";

// Enum

enum Direction {
  Up = 1,
  Down = 2,
  Left = "Esquerda",
  Right = "Direita",
}

const direction = Direction.Right;

// Type Assertions

const productName: any = "Boné";

// let itemId = productName as string;

let itemId = <string>productName;

console.log(direction);
