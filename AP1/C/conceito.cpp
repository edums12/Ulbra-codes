#include <stdio.h>
#include <conio.h>

main(){
	float media;
	
	printf("CONCEITOS \n");
	
	printf("Digite a media do aluno: ");
	scanf("%f", &media);
	
	printf("\nConceito: ");
	
	if(media >= 6){
		printf("A");
	} else if(media >= 4 && media < 6){
		printf("B");
	} else if(media < 4){
		printf("C");
	}
}
