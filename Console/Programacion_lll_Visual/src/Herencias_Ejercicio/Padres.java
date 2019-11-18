
package Herencias_Ejercicio;


public class Padres {
    
    protected String cPiel;//c=color de piel
    protected String cOjos;
    protected String cCabello;
    protected float estatura;
    
    public Padres(){
        cPiel= "tes Clara";
        cOjos="cafe claro";
        cCabello="Castaño claro";
        estatura= 1.56f;
    }
    protected String bailarTaitiano(){
        return "Bailar Taitiano";
    }
    protected String bailar(){
        return "Bailar";
    }
    protected String ordenado(){
        return "Matener todo ordenado o acomodado";
    }
    public String getcPiel(){
        return cPiel;
    }
    public String getcOjos(){
        return cOjos;
    }
    public String getcCabello(){
        return cCabello;
    }
    public float getEstatura(){
        return estatura;
    }
    
}
