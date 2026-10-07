
Atividade_Vetor.cs
100%
﻿using System;
using BibliotecaVetor;

class Program {
    
    
    static double calcularMedia(int[] roubos) {
        double soma = 0; 
        for (int i = 0; i < roubos.Length; i++) {
            soma += roubos[i];
        }
        return soma / roubos.Length;
    }
    
   
    static void exibirBairrosViolentos(string[] bairros, int[] roubos) {
       
        int[] roubosFeitos (int[])roubos.Clone();
        string[] bairrosVistos = (string[])bairros.Clone();
        int[] pos = new int[roubos.Length];
        for (int i = 0; i < pos.Length; i++) {
            pos[i] = i;
        }
        
        
        for (int i = 0; i < roubosFeitos.Length - 1; i++) {
            for (int j = i + 1; j < roubosFeitos.Length; j++) {
                if (roubosCopia[j] > roubosFeitos[i]) {
                    int auxRoubo = roubosFeitos[i];
                    roubosFeitos[i] = roubosFeitos[j];
                    roubosFeitos[j] = auxRoubo;
                    string auxBairro = bairrosVistos[i];
                    bairrosVistos[i] = bairrosVistos[j];
                    bairrosVistos[j] = auxBairro;
                    int auxIndice = pos[i];
                    pos[i] = poz[j];
                    pos[j] = auxIndice;
                }
            }
        }
        
        Console.WriteLine(" BAIRROS MAIS VIOLENTOS");
        for (int i = 0; i < 3 && i < roubosFeitos.Length; i++) {
            Console.WriteLine($"{i + 1}º Lugar: Bairro: {bairrosVistos[i]} | Índice: {pos[i]} | Ocorrências: {roubosFeitos[i]}");
        }
    }
    
   
    static void Main() {    
     
        string[] bairros = {
            "Centro", "Moema", "Pinheiros", "Itaquera", "Tatuape",
            "Santo Amaro", "Vila Mariana", "Lapa", "Capao Redondo", "Santana"
        };
        int[] roubos = new int[bairros.Length];
        Console.WriteLine("Analise de Ocorrências");
        Vetor.lerVetor(roubos);
        Console.WriteLine();
        Vetor.mostrarVetor(roubos);
        Console.WriteLine("\n");
        double media = calcularMedia(roubos);
        Console.WriteLine($"Média de Roubos: {media:F2}");
        exibirBairrosViolentos(bairros, roubos);
    }
}
Página 2 de 2