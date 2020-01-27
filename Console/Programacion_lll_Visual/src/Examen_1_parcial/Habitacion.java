package Examen_1_parcial;

public class Habitacion {

   private  float Ancho = 0;
   private  float Largo = 0;
    
   // float Area =0;
    
    public Habitacion(float ancho,float largo, float area){
        if(Largo<0){
            
        }
        this.Ancho = ancho;
        this.Largo = largo; 
        //this.Area = area;
        
    }

  public float getArea(){
      return Largo * Ancho;
      
  } 
    
//    public void setAncho(float ancho){
//        this.Ancho = ancho;
//    }
//    public float getAncho(){
//        return Ancho;
//    }
//    public void setLargo(float largo){
//        this.Largo = largo;
//    }
//    public float getLargo(){
//        return Largo;
//    }
//    public void setArea(float area){
//        this.Area = area;
//    }
//    public float getarea(){
//        return Area;
//    }
//    
//    void calcularArea(){
//       this.Area = this.Ancho * this.Largo;
//        
//    }

}
