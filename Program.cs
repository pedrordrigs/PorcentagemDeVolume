using System;

namespace PercentageOfVolume {
  class Program {
    static void Main(string[] args) {
      // Verifica se a função está retornando o resultado correto para o primeiro exemplo de teste
      int resultado = funcaoRetornaQuantitadePOV(0.1m, 90);
      if (resultado == 10) {
        Console.WriteLine("Teste 1: PASSED");
      } else {
        Console.WriteLine("Teste 1: FAILED (retornou " + resultado + ")");
      }

      // Verifica se a função está retornando o resultado correto para o segundo exemplo de teste
      resultado = funcaoRetornaQuantitadePOV(0.1m, 100);
      if (resultado == 11) {
        Console.WriteLine("Teste 2: PASSED");
      } else {
        Console.WriteLine("Teste 2: FAILED (retornou " + resultado + ")");
      }

      // Verifica se a função está retornando o resultado correto para o terceiro exemplo de teste
      resultado = funcaoRetornaQuantitadePOV(0.2m, 70);
      if (resultado == 17) {
        Console.WriteLine("Teste 3: PASSED");
      } else {
        Console.WriteLine("Teste 3: FAILED (retornou " + resultado + ")");
      }
    }

    static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado) {
        return (int)(porcentagem * totalNegociado / (1 - porcentagem));
    }
  }
}