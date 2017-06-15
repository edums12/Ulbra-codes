using System;

class IAC_CS_Codes{
    public static int Tela_Menu(){ // EXIBIR O MENU PRINCIPAL DO PROGRAMA
        int ler;
        limpar();
        escreva("IAC C# CODES");
        escreva("[1] TABUADA");
        escreva("[2] MEDIA - ULBRA");
        escreva("[3] CALCULADORA");
        escreva("[4] IMC");
        escreva("[5] SAIR");
        ler = int.Parse(leia());
        return ler;
    }

    public static void Funcoes(int Comando){
        // CHAMADOR DE FUNÇÕES <-
        switch (Comando){
            case 1: // Chama Tabuada
                Tabuada();
                break;
            case 2: // Chama média da Ulbra
                MediaUlbra();
                break;
            case 3: // Chama Calculadora
                Calculadora();
                break;
            case 4: // Chama IMC
                IMC();
                break;
        }
    }

    public static void Main(){
        // COMANDO MAIN - INICIALIZANDO O PROGRAMA

        // incializando variáveis
        int Comando;

        // Executando...
        do{
            Comando = Tela_Menu(); // Chama o Menu

            if(Comando != 5 && Comando >= 1 && Comando <= 4){
                Funcoes(Comando); // Chama as funcoes
            }

        } while(Comando != 5);
    }

    // FUNÇÕES
    public static void Tabuada(){ // Mostra a tabuada de um numero desejado
        int numero;
        string Comando = "";

        do{
            limpar();
            escreva("Digite o número a ser tabelado: ");
            numero = int.Parse(leia());

            escreva("");
            escreva("TABELA DO [" + numero + "]");

            for (int i = 0; i <= 10; i++){
                escreva(numero + " x " + i + " = " + numero*i); // Executa a conta - E mostra na tela a tabuada
            }

            escreva("");

            escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
            Comando = leia();

        } while(Comando != "voltar");
    }

    public static void MediaUlbra(){ // Calcula a Média da Ulbra
        float G1, G2, Media;
        string Voltar;

        do{
            limpar();
            escreva("Digite sua nota da [G1]: ");
            G1 = float.Parse(leia());
            
            escreva("Digite sua nota da [G2]: ");
            G2 = float.Parse(leia());

            Media = (G1 + (G2 * 2))/3;

            escreva("");

            escreva("MEDIA FINAL: " + Media);
            if(Media >= 6){
                escreva("APROVADO NO SEMESTRE");
            } else{
                escreva("REPROVADO NO SEMESTRE");
            }

            escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
            Voltar = leia();
        } while(Voltar != "voltar");
    }

    public static void Calculadora(){ // Realiza as operações básicas da matemática
        // Declaração das Variáveis
        int Comando = 0;

        float N1 = 0;
        float N2 = 0;
        float Result = 0;

        string Oper = "";
        string Voltar = "";

        // Executando...
        do{
            limpar();

            escreva("OPERAÇÕES DA CALCULADORA");
            escreva("[1] SOMAR");
            escreva("[2] DIMINUIR");
            escreva("[3] MULTIPLICAR");
            escreva("[4] DIVIDIR");
            escreva("[5] VOLTAR AO MENU PRINCIPAL");
            Comando = int.Parse(leia());

            if(Comando >= 1 && Comando <= 4){
                escreva ("Digite o 1 número: ");
                N1 = float.Parse(leia());

                escreva ("Digite o 2 número: ");
                N2 = float.Parse(leia());

                switch(Comando){
                    case 1:
                        Result = N1 + N2;
                        Oper = " + ";
                        break;
                    case 2:
                        Result = N1 - N2;
                        Oper = " - ";
                        break;
                    case 3:
                        Result = N1 * N2;
                        Oper = " x ";
                        break;
                    case 4:
                        Result = N1 / N2;
                        Oper = " / ";
                        break;
                }

                escreva(N1 + Oper + N2 + " = " + Result);
                escreva("");

                escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
                Voltar = leia();
            } else if(Comando == 5){
                Voltar = "voltar";
            } else{
                escreva("Comando Inválido");
            }

        } while(Voltar != "voltar");
    }

    public static void IMC(){ // Realiza os cálculos de índice de massa corporal
        float Peso, Altura, IMC;
        string Sexo, Voltar;

        do{
            limpar();
            escreva("Digite seu peso: (kg) - ex(60,00)");
            Peso = float.Parse(leia());

            escreva("Digite sua altura: (m) - ex(1,60)");
            Altura = float.Parse(leia());

            escreva("Digite seu sexo: [M] ou [F]");
            Sexo = leia();

            //peso em kg / (altura em metros * altura em metros)
            IMC = (Peso / (Altura * Altura));

            escreva("Seu IMC -> " + IMC);

            if(Sexo == "m" || Sexo == "M"){
                if(IMC < 20.7){
                    escreva("Abaixo do Peso!");
                } else if(IMC < 26.4){
                    escreva("Peso normal!");
                } else if(IMC < 27.8){
                    escreva("Marginalmente acima do peso!");
                } else if(IMC < 31.1){
                    escreva("Acima do Peso ideal!");
                } else{
                    escreva("Obeso!");
                }
            } else if(Sexo == "f" || Sexo == "F"){
                if(IMC < 19.1){
                    escreva("Abaixo do Peso!");
                } else if(IMC < 25.8){
                    escreva("Peso normal!");
                } else if(IMC < 27.3){
                    escreva("Marginalmente acima do peso!");
                } else if(IMC < 32.3){
                    escreva("Acima do Peso ideal!");
                } else{
                    escreva("Obeso!");
                }
            }

            escreva("Digite 'voltar' para voltar ao menu principal - ou qualquer outro para executar novamente");
            Voltar = leia();
        } while(Voltar != "voltar");
    }




    // Funções Rápidas

    static void escreva(string palavra){ // Escreve na tela -- ex escreva("oi");
        Console.WriteLine(palavra);
    }

    static string leia(){ // Lê o parametro -- ex comando = leia();
        return Console.ReadLine();
    }

    static void parar(){ // Para o programa -- ex parar();
        Console.ReadLine();
    }

    static void limpar(){ // Limpa a tela -- ex limpar();
        Console.Clear();
    }
}