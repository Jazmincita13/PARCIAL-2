// See https://aka.ms/new-console-template for more information
using System;

//Console.WriteLine("Hello, World!");


int dato1 = 16;
string dato2 = "25g";
int resultado;

try
{
    resultado = dato1 + Convert.ToInt32(dato2);
    Console.WriteLine("El resultado es: " + resultado);
}
catch (Exception ex)
{
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}
