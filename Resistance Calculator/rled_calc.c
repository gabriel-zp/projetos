#include <stdio.h>
#include <stdlib.h>
int main(void){
    float vin, vled, iled, res;
    int i = 0;

    printf("CALCULADORA RESISTOR DE CIRCUITO COM LED v1.0\n\n");
    printf("Autor: Gabriel Zimmermann Piccnini");
    printf("------------------------\n");

    printf("\n\nEntre com o valor da tensao de entrada <em volts>\n\n");
    scanf("%f",&vin);

    printf("Entre com os valores da tensao, em volts, e corrente, em amperes, do led. (digite um a um)\n\n");
    scanf("%f %f", &vled, &iled);
    res = (vin-vled)/iled;

    printf("\nO resistor deve possuir %.3f ohms.", res);

    printf("\n\nDADOS\n\n-----------------------------------------------------------------\n|\tVIn\t|\tVLed\t|\tILed\t|\tRES\t|");
    printf("\n|---------------------------------------------------------------|\n");
    printf("|\t%.3f\t|\t%.3f\t|\t%.3f\t|\t%.3f\t|\n", vin,vled,iled,res);
    printf("-----------------------------------------------------------------\n\n");
    system("pause");
}

