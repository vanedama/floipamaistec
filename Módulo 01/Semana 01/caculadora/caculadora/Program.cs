﻿// Importação de bibliotecas

// Nome da classe

// Declaração de método

// Declaração de variáveis
int opção, numero1 = 0, numero2 = 0;
float resultado = 0;

    // Entradas
Console.WriteLine("Escolha uma operação: \n\n" +
    "1 - soma\n2 - subtração\n3 - multiplicação\n4 - divisão\n" +
    "5 - sair\n\nDigite a opção escolhida: ");

opção = int.Parse  (Console.ReadLine());

    // Processamento
    switch(opção)
{
    // Bloco de instruções da estrutura condicional
    case 1: 
        Console.WriteLine("Operação somar.");
        Console.Write("Digite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número 2: ");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 + numero2;
        break;
    case 2:
        Console.WriteLine("Operação subtrair.");
        break;
    case 3:
        Console.WriteLine("Operação multiplicar.");
        break;
    case 4:
        Console.WriteLine("Operação dividir.");
        break;
    case 5:
        Console.WriteLine("Saindo do sistema.");
        break;
}
    Console.WriteLine("Resultado: " + resultado);

    // Saídas
    