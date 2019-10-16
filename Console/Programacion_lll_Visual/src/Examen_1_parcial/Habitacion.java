package Examen_1_parcial;

public class Habitacion {

    float Ancho = 0;
    float Largo = 0;
    
    float Area =0;
    
    public void Habitacion(float ancho,float largo, float area){
        this.Ancho = ancho;
        this.Largo = largo; 
        this.Area = area;
        
    }

   
    
    public void setAncho(float ancho){
        this.Ancho = ancho;
    }
    public float getAncho(){
        return Ancho;
    }
    public void setLargo(float largo){
        this.Largo = largo;
    }
    public float getLargo(){
        return Largo;
    }
    public void setArea(float area){
        this.Area = area;
    }
    public float getarea(){
        return Area;
    }
    
    void calcularArea(){
       this.Area = this.Ancho * this.Largo;
        
    }

}
