
package Examen_1_parcial;


public class Calculadora {
    Habitacion habitacion1;
    Tapiz tapiz1;
    
    float TotalCost=0;
    
    void calcularArea(){
        habitacion1.calcularArea();
        
        TotalCost=tapiz1.CostoXmetro * habitacion1.getarea() ; 
    }
    
   
    
}
