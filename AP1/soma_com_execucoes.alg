var
   condicao, num, soma, i: inteiro
inicio
      repita
         Escreval("Digite o valor da execução desejada: ")
         Escreval("[1] Soma de dois Nº")
         Escreval("[2] Soma de três Nº")
         Escreval("[3] Fim da execução")
         leia(condicao)

         i:= 1

         escolha condicao
                 caso 1
                      Escreval("[1] - SELECIONADO - Soma de dois Nº")
                      repita
                            Escreva("Digite o ", i, "º valor: ")
                            leia(num)
                            soma:= soma + num
                            i:= i + 1
                      ate(i>2)
                      escreval("Soma final: ", soma)

                 caso 2
                      Escreval("[2] - SELECIONADO - Soma de três Nº")
                      repita
                            Escreva("Digite o ", i, "º valor: ")
                            leia(num)
                            soma:= soma + num
                            i:= i + 1
                      ate(i>3)
                      escreval("Soma final: ", soma)

                 caso 3
                      Escreval("[3] - SELECIONADO - Fim de execução")
         fimescolha
    ate (condicao = 1) ou (condicao = 2) ou (condicao = 3)
fimalgoritmo

