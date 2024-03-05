/*

Calculo do valor de uma viagem:

- Preço do Combustível;
- Gasto médio de combustível do carro por KM;
- Distância em KM da viagem;

*/

// const preco_combustivel = 5.58;
// const gasto_carro = 9;
// const distancia = 100;

// resultado = (distancia * preco_combustivel) / gasto_carro;

// console.log(`R$${resultado.toFixed(2)}`);

const preco_etanol = 8;
const preco_gasosa = 6;
const tipo_combustivel = "gasosa";
const gasto_carro = 9;
const distancia = 100;

if (tipo_combustivel === "gasosa") {
  resultado = (distancia * preco_gasosa) / gasto_carro;
} else if (tipo_combustivel === "etanol") {
  resultado = (distancia * preco_etanol) / gasto_carro;
}

console.log(resultado.toFixed(2));
