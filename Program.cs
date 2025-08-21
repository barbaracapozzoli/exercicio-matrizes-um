using System;

class Program
{
    static void Main()
    {
        // Fazer um programa para ler um número inteiro N e uma matriz quadrada (número de linhas e colunas é o mesmo) de ordem N contendo números inteiros.
        // Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.

        int N;
        int[,] A;

        N = int.Parse(Console.ReadLine());
        A = new int[N, N];

        for (int i = 0; i < N; i++) // i menor que o número de linhas que é N
        {
            string[] s = Console.ReadLine().Split(' '); // Aqui é para ler a linha inteira e jogar em cada caixinha (posição) da matriz;
            for (int j = 0; j < N; j++) // j menor que o número de colunas que é N
            {
                A[i, j] = int.Parse(s[j]); // Aqui é para ler cada número da linha e jogar na matriz, ou seja, na matriz A na posiçãi de linha i e coluna J, recebe uma variável do tipo int, do vetor s na posição J.
            }
        }

        // Agora que a matriz está lida e preenchida, vamos mostrar a diagonal principal, a lógica é que sempre será [0,0], [1,1], [2,2]... ou seja, sempre onde o índice da linha é igual ao índice da coluna.

        Console.WriteLine("DIAGONAL PRINCIPAL:");

        for (int i = 0; i < N; i++)
        {
            Console.Write(A[i, i] + " "); // Aqui é para mostrar a diagonal principal, ou seja, onde o índice da linha é igual ao índice da coluna. Na matriz A, na posição [i,i] está o número que queremos mostrar.
        }
        Console.WriteLine(); // Só pra imprimir uma quebra de linha no final.

        // Agora vamos contar a quantidade de valores negativos da matriz.

        // Para entender se os valores são negativos precisamos percorrer todos os valores da matriz e ir estabelecendo uma contagem;

        int cont = 0; // Contador para os valores negativos

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (A[i, j] < 0) // Aqui é para verificar se o valor da matriz A na posição [i,j] é menor que zero, ou seja, se é negativo.
                {
                    cont++; // Se for negativo, incrementa o contador. Lê-se cont = cont + 1;
                }
            }
        }

        Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont); // Aqui é para mostrar a quantidade de valores negativos encontrados na matriz.
        Console.ReadLine();
    }
}
