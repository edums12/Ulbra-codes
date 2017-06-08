using System;

class Calculator{
    public static void Main(){
        float g1 = 0;
        float g2 = 0;
        float media = 0;
        
        Console.Write("Nota da G1: ");
        g1 = float.Parse(Console.ReadLine());

        Console.Write("Nota da G2: ");
        g2 = float.Parse(Console.ReadLine());

        media = (g1 + (g2 * 2))/3;

        Console.WriteLine("Sua média final é: " + media);

        if(media >= 6){
            Console.WriteLine("Parabéns Você PASSOU!! UHULL -> Curta as férias!");
        } else{
            Console.WriteLine("Poxa Vida!! Até a Recuperação de Grau");
        }
    }
}