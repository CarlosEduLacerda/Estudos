const { isUtf8 } = require("buffer");
const { error } = require("console");
const fs = require("fs");
const path = require("path");

// Criar uma pasta
// fs.mkdir(path.join(__dirname, "/test"), (error) => {
//   if (error) {
//     return console.log("Erro ", error);
//   }

//   console.log("Pasta criada com sucesso!");
// });

// Criar um arquivo
fs.writeFile(
  path.join(__dirname, "/test", "teste.txt"),
  "Hello Node!",
  (error) => {
    if (error) {
      return console.log("Erro ", error);
    }

    console.log("Arquivo criado com sucesso!");
  }
);

// Adicionar informação à um arquivo
fs.appendFile(
  path.join(__dirname, "/test", "teste.txt"),
  " Hello Wolrd!!",
  (error) => {
    if (error) {
      return console.log("Erro: ", error);
    }

    console.log("Arquivo modificado com sucesso!");
  }
);

// Ler arquivo
fs.readFile(
  path.join(__dirname, "/test", "teste.txt"),
  "utf8",
  (error, data) => {
    if (error) {
      return console.log("Erro ", error);
    }

    console.log(data);
  }
);
