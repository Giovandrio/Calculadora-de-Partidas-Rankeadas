function main() {
    const quantidadeVitorias = 100;
    const quantidadeDerrotas = 15;

    calculadorRanked(quantidadeVitorias, quantidadeDerrotas);
}

function calculadorRanked(vitorias, derrotas) {
    const saldoRanked = vitorias - derrotas;
    let nivel = "";

    if (saldoRanked <= 10) {
        nivel = "Ferro";
    } else if (saldoRanked <= 20) {
        nivel = "Bronze";
    } else if (saldoRanked <= 50) {
        nivel = "Prata";
    } else if (saldoRanked <= 80) {
        nivel = "Ouro";
    } else if (saldoRanked <= 90) {
        nivel = "Diamante";
    } else if (saldoRanked <= 100) {
        nivel = "Lendário";
    } else if (saldoRanked >= 101) {
        nivel = "Imortal";
    }

    console.log(`O Herói tem um saldo de ${saldoRanked} e está no nível de ${nivel}`);
}

main();