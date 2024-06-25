//Desafio
//Faça um programa com as características abaixo:

//Leia 10 nomes, sem espaço em branco;
//Imprima o terceiro nome da lista;
//Imprima o sétimo nome da lista;
//Imprima o nono nome da lista.

let nomes = new Array(10);

for(let i = 0; i < 10; i++) {
    nomes[i] = gets();
}

print(nomes[2]);  // Terceiro nome (índice 2)
print(nomes[6]);  // Sétimo nome (índice 6)
print(nomes[8]);  // Nono nome (índice 8)
