using System;
using BibliotecaMatriz;

class Program
{
public static double calcularPercentuaDesmatamento(int[,] matriz)
{
    double somaDesmatamento = 0;
    int totalCelulas = matriz.GetLength(0) * matriz.GetLength(1); 

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            
            if (matriz[i, j] == 1)
            {
                somaDesmatamento++;
            }
        }
    }

    double percentualDesmatamento = (somaDesmatamento / totalCelulas) * 100.0;
    double percentualPreservacao = 100.0 - percentualDesmatamento;

   
    return new double[] { percentualDesmatamento, percentualPreservacao };
}
public static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual)
{
    
	
    double[] dadosAnterior = calcularPercentuaDesmatamento(matrizAnterior);
    double[] dadosAtual = calcularPercentuaDesmatamento(matrizAtual);

    double percAnterior = dadosAnterior[0];
    double percAtual = dadosAtual[0];
    double diferenca = percAtual - percAnterior;

    Console.WriteLine($"Percentual de desmatamento há 6 meses era de : {percAnterior:F2}%");
    Console.WriteLine($"Percentual de desmatamento atualmente é :      {percAtual:F2}%");


    if (diferenca > 0)
    {
        Console.WriteLine($"Tendência: ALERTA! O desmatamento AUMENTOU em {diferenca:F2}%.");
    }
    else if (diferenca < 0)
    {
        Console.WriteLine($"Tendência: POSITIVO! O desmatamento REDUZIU em {Math.Abs(diferenca):F2}%.");
    }
    else
    {
        Console.WriteLine("Tendência: ESTÁVEL. O percentual manteve-se igual.");
    }
   
}
static void Main()
{
int[,] matrizPassado = Matriz.carregarMatriz("dados_matriz_6meses_atras.csv");
    int[,] matrizAtual = Matriz.carregarMatriz("dados_matriz_atual.csv"); // ou gerada por outra função
    
    Console.WriteLine("Matrizes carregadas com sucesso!");
    
   Matriz.mostrarMatriz(Matriz);
    analisarAumento(matrizPassado, matrizAtual);	
}
