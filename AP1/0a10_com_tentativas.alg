algoritmo "2n 0 - 10 contando tentativas"

var
   soma, num, tentativas, tentativasCorretas: inteiro
inicio
      Enquanto tentativasCorretas < 2 faca
          Escreva("Digite um número, entre (0 - 10): ")
          leia(num)

          se(num >= 0) e (num <= 10) entao
                 soma:= soma + num
                 tentativasCorretas:= tentativasCorretas + 1
          fimse

          tentativas:= tentativas + 1
      fimEnquanto

      Escreval("Soma final: ", soma)
      Escreval("Número de tentativas: ", tentativas)
Fimalgoritmo

