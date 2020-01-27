
package Examen_1_parcial;
import java.util.Scanner;

public class Test_Habitacion {
    public static void main(String[] args){
        Scanner t = new Scanner(System.in);
        Habitacion habitacion1 = new Habitacion(2.75f, 4.0f);
        System.out.println("area " +  habitacion1.getarea());
        Tapiz tapiz1 =new Tapiz(3.5f);
        System.out.println("costo" +  );
        Calculadora calculadora1 = new Calculadora(habitacion1 , tapiz1);
        
        System.out.println("costo total");
        
      //  calculadora1.tapiz1 = tapiz1;
        System.out.println("Datos a ingresar de la habitacion");
        System.out.println("Ingrese el largo de la habitacion");
        habitacion1.Largo = t.nextFloat();
        System.out.println("Ingrese el ancho de la habitacion");
        habitacion1.Ancho = t.nextFloat();
        
        habitacion1.calcularArea();
        System.out.println("  El area de la habitacion  "+ habitacion1.Area );
       // calcular1.T
        System.out.println(" El costo total  de la habitacion es: " + calculadora1.TotalCost);
        
        
    }
    
}
