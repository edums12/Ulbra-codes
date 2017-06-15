using System;

class CalculadoraMaster{
    public static void Main(){
        // DECLARAÇÃO DAS VARIÁVEIS
        int Comando = 0;

        float N1 = 0;
        float N2 = 0;
        float Result = 0;

        String Oper = "";
        
        // OPERAÇÕES
        do{
            
            Console.WriteLine("OPERAÇÕES:");
            Console.WriteLine("[1] SOMAR");
            Console.WriteLine("[2] DIMINUIR");
            Console.WriteLine("[3] DIVIDIR");
            Console.WriteLine("[4] MULTIPLICAR");

            Comando = int.Parse(Console.ReadLine());
            Console.Clear();

            if(Comando <= 0 || Comando >= 5){
                Console.WriteLine("OPERAÇÃO INVÁLIDA - Onde você leu que existe a operação de número " + Comando);
            }
        } while(Comando <= 0 || Comando >= 5);
        // LEITURA DOS DADOS
        Console.WriteLine("Digite o 1º número: ");
        N1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o 2º número: ");
        N2 = float.Parse(Console.ReadLine());

        
        switch (Comando)
        {
            case 1:
                Result = N1 + N2;
                Oper = " + ";
                break;
            
            case 2:
                Result = N1 - N2;
                Oper = " - ";
                break;
            
            case 3:
                Result = N1 / N2;
                Oper = " / ";
                break;
            
            case 4:
                Result = N1 * N2;
                Oper = " x ";
                break;
        }  

            Console.WriteLine(N1 + Oper + N2 + " = " + Result);
            Console.ReadLine();
               
    }
}