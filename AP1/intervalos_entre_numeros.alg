algoritmo "intervalos"

var
   i, num, cont25, cont50, cont75, cont100, contOutras: inteiro
inicio
      Enquanto i < 10 faca
               Escreva("Digite um valor: ")
               leia(num)

               Se(num >= 0) e (num <= 25) entao
                  cont25:= cont25 + 1
               Senao
                    Se (num <= 50) entao
                       cont50:= cont50 + 1
                    Senao
                        Se (num <= 75) entao
                           cont75:= cont75 + 1
                        Senao
                             Se (num <= 100) entao
                                cont100:= cont100 + 1
                             Senao
                                  contOutras:= contOutras + 1
                             fimse
                        fimse
                    fimse
               FimSe

               i:= i + 1
      fimEnquanto

      Escreval("Quantidade de números: ")
      Escreval("[entre 0 e 25]: ", cont25)
      Escreval("[entre 26 e 50]: ", cont50)
      Escreval("[entre 51 e 75]: ", cont75)
      Escreval("[entre 76 e 100]: ", cont100)
      Escreval("[outras]: ", contOutras)
fimalgoritmo

