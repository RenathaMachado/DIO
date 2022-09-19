
using System.Collections.Generic;
using System;

List<string> estados = new List<string>();

estados.Add("MG");
estados.Add("BA");
estados.Add("SP");

int contador = 0;
foreach (string itens in estados)
{
    Console.WriteLine($"Posição {contador}: {itens}");
    contador++;
}
