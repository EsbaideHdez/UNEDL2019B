
package Herencias_Ejercicio;


public class Hija extends Padres implements Habilidades{
    public Hija(){
        
    }
    
    public static void main (String[]args){
        Hija referencia = new Hija();
        
        
        System.out.println("Herede de mi madre el color de piel : " + referencia.getcPiel());
        System.out.println("Herede de mi padre el color de ojos : " + referencia.getcOjos());
        System.out.println("Herede de mi madre el color de cabello : " + referencia.getcCabello());
        System.out.println("Herede de mi madre la estatura : " + referencia.estatura);
        
        System.out.println("Herede de mi madre bailar Taitiano : " + referencia.bailarTaitiano());
        System.out.println("herede de mi padre bailar : " + referencia.bailar());
        System.out.println("Herede de ambos lo ordenado : " + referencia.ordenado());
        
        System.out.println(referencia.manualidades());
        System.out.println(referencia.hacerArreglo());
        
    }
    
    public String manualidades(){
        return "Aprendi a hacer pulseras por mi maestra de arte";
    }
    public String hacerArreglo(){
        return "Aprendi a hacer arreglos en el negocio familiar gracias a mi abuelita ";
    }
    
}
