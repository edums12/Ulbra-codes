algoritmo "2n 0 - 10"

var
   soma, num, tentativa: inteiro
inicio
      Enquanto tentativa < 2 faca
          Escreva("Digite um número, entre (0 - 10): ")
          leia(num)

          se(num >= 0) e (num <= 10) entao
                 soma:= soma + num
                 tentativa:= tentativa + 1
          fimse
      fimEnquanto

      Escreva("Soma final: ", soma)
Fimalgoritmo

