#include <stdio.h>
#include <conio.h>

main(){
	int escolha;
	char cidade[31], estado[31];
	
	printf("Escolha sua cidade: \n");
	printf("[1] TORRES - RS \n");
	printf("[2] CRICIUMA - SC \n");
	printf("[3] OUTRA \n");
	scanf("%i", &escolha);
	
	switch (escolha){
		case 1:
			printf("\nVoce escolheu Torres - RS");
			break;
		case 2:
			printf("\nVoce escolheu Criciuma - SC");
			break;
		case 3:
			printf("\nQual sua cidade: ");
			scanf("%s", &cidade);
		
			printf("\nQual estado: ");
			scanf("%s", &estado);
		
			printf("\nSua cidade: %s - %s", cidade, estado);
			break;
		default:
			printf("USUARIO BURRO! - E DO 1 AO 3 - ONDE VOCE VIU QUE TEM O NUMERO %i", escolha);
			break;
	}	
}
