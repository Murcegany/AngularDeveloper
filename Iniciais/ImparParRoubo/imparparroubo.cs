
// Lê a entrada de uma única linha e divide em um array de strings
let entrada = gets().split(" ");
let p, j1, j2, r, a;

// Converte as strings em inteiros
p = parseInt(entrada[0]);
j1 = parseInt(entrada[1]);
j2 = parseInt(entrada[2]);
r = parseInt(entrada[3]);
a = parseInt(entrada[4]);

// Verifica as condições de roubo e acusação
if (r == 1 && a == 1) {
  print("Jogador 2 ganha!");
} else if (r == 1 && a == 0) {
  print("Jogador 1 ganha!");
} else if (r == 0 && a == 1) {
  print("Jogador 1 ganha!");
} else {
  // Calcula a soma dos números escolhidos pelos jogadores
  let soma = j1 + j2;

  // Verifica quem ganha com base na escolha de par ou ímpar e na soma dos números
  if (p == 1 && soma % 2 == 0) {
    print("Jogador 1 ganha!");
  } else if (p == 0 && soma % 2 != 0) {
    print("Jogador 1 ganha!");
  } else {
    print("Jogador 2 ganha!");
  }
}
