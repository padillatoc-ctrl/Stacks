using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> pedidos = new Stack<string>();

    //push agregar pedidos a la pila 
    pedidos.Push("Tacos");
    pedidos.Push("Tortas");
    pedidos.Push("Agua");
    pedidos.Push("Café");
    pedidos.Push("Sancdwich");

    Console.WriteLine(pedidos.Count);
        
    }
}