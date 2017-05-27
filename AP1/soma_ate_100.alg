algoritmo "soma até 100 ou valor 0 ou x13"
var
     soma, n, nMaior, nMenor, contador: inteiro
inicio
      contador := 0;
      soma := 0;
      nMaior := 0;
      nMenor := 100;

      repita
          escreva("Digite um valor inteiro: ")
          leia(n)
          soma:= soma + n

          se(n > nMaior)entao
               nMaior := n;
          fimse

          se(n < nMenor)entao
               nMenor := n;
          fimse

          escreval(soma)

          contador := contador + 1;
      ate (soma = 100) ou (n = 0) ou (contador = 13)

      escreval("Menor número digitado: ", nMenor)
      escreval("Maior número digitado: ", nMaior)
fimalgoritmo

