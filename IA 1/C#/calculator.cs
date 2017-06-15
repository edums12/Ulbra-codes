using System;

class Calculator{
    public static void Main(){
        int number1;
        
        Console.WriteLine("Digite um número: ");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("O Usuário Digitou: " + number1);
    }
}