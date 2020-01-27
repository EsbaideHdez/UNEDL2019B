/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Examen_Totalizador;

import java.util.Scanner;


public class Examen_tercer_parcial {
    public static void main(String [ ]args){
     Scanner teclado = new Scanner(System.in);
     
     int dinero;
     int precios=4;
     int resultado=0;
     
     
     System.out.println("Ingrese la cantidad de dinero que tiene : ");
     dinero = teclado.nextInt();
     
        System.out.println("La cantidad de precios que tiene son 7 ");
       
        System.out.println("Los elementos son 1 , 12 ,5 ,111,200 ,1000, 10");
        
        if(dinero - 1>=0){
            resultado ++;
        }
        if(dinero - 12>=0){
            resultado ++;
        }
        if(dinero - 5>=0){
            resultado ++;
        }
        if(dinero - 10>=0){
            resultado ++;
        }
        
     
        System.out.println("La cantidad de dinero qe tiene es : " + dinero);
        System.out.println("Resultado para los elemtos que le alcanzan :" + resultado);
        
     
     
    }
     
}
