#include <stdio.h>
#include <stdlib.h>
int main(void){
    float vin, vled, iled, res;
    int i = 0;
    printf("CALCULADORA RESISTOR DE CIRCUITO COM LED v1.0\n\n");
    printf("------------------------\n");
    printf("Entre com o valor da tensao de entrada <em volts>\n\n");
    scanf("%f",&vin);
    for(i=0;i<=2;i++){
        switch(i){
            case 1:
                printf("\nEntre com o corrente do led <em amperes>\n\n");
                scanf("%f",&iled);
                break;
            case 2:
                printf("\nEntre com o tensao do led <em volts>\n\n");
                scanf("%f",&vled);
                break;
            default:
                break;     
        }
    }
    res = (vin-vled)/iled;
    printf("\nA resistencia deve possuir %.3f ohms.", res);
    printf("\n\nDADOS\n\n-----------------------------------------------------------------\n|\tVIn\t|\tVLed\t|\tILed\t|\tRES\t|");
    printf("\n|---------------------------------------------------------------|\n");
    printf("|\t%.3f\t|\t%.3f\t|\t%.3f\t|\t%.3f\t|\n", vin,vled,iled,res);
    printf("-----------------------------------------------------------------\n\n");
    system("pause");
}

