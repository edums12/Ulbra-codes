using System;

class tabuada{
    public static void Main(){
        int numero;
        string Comando = "";

        do{
            limpar();
            escreva("Digite o número a ser tabelado: ");
            numero = int.Parse(leia());

            for (int i = 0; i <= 10; i++){
                escreva(numero + " x " + i + " = " + numero*i);
            }

            escreva("");

            escreva("Digite 'fechar' para encerrar - ou qualquer outro para voltar");
            Comando = leia();

        } while(Comando != "fechar");
    }


    // Funções
    static void escreva(string palavra){
        Console.WriteLine(palavra);
    }

    static string leia(){
        return Console.ReadLine();
    }

    static void parar(){
        Console.ReadLine();
    }

    static void limpar(){
        Console.Clear();
    }
}