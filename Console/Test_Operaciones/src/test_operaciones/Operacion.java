package test_operaciones;

import javax.swing.JOptionPane;

public class Operacion {

    private float N1 = 0;
    private float N2 = 0;
    private String Operaciones;
    private float op;
    private boolean op2;

    public void Operacion(String n1, String n2, String operaciones) {

        // public void setOperadorAritmticos(String n1 , String n2 , String operaciones){
        this.N1 = Float.parseFloat(n1);
        this.N2 = Float.parseFloat(n2);
        this.Operaciones = operaciones;

        switch (Operaciones) {
            case "+":
                op = this.N1 + this.N2;
                JOptionPane.showMessageDialog(null, "Es un operador aritmetico y es una suma +");
                JOptionPane.showMessageDialog(null, "La suma es : " + op);
                break;

            case "-":
                op = this.N1 - this.N2;
                JOptionPane.showMessageDialog(null, "Es un operador aritmetico y es una resta -");
                JOptionPane.showMessageDialog(null, "La resta es : " + op);
                break;

            case "*":
                op = this.N1 * this.N2;
                JOptionPane.showMessageDialog(null, "Es un operador aritmetico y es una multiplicacion *");
                JOptionPane.showMessageDialog(null, "La multiplicacion es : " + op);
                break;

            case "/":
                op = this.N1 / this.N2;
                JOptionPane.showMessageDialog(null, "Es un operador aritmetico y es una division /");
                JOptionPane.showMessageDialog(null, "La division es : " + op);
                break;

            case "%":
                op = this.N1 % this.N2;
                JOptionPane.showMessageDialog(null, "Es un operador aritmetico y es uu residuo %");
                JOptionPane.showMessageDialog(null, "El residuo es : " + op);
                break;
        }
    }

    public boolean setOperacion2(String n1, String n2, String operaciones) {
        op2 = false;
        this.N1 = Float.parseFloat(n1);
        this.N2 = Float.parseFloat(n2);
        this.Operaciones = operaciones;

        switch (operaciones) {
            case "<":
                if (this.N1 < this.N2) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "El primer valor es menor que el segundo valor");
                }else {
   
                    JOptionPane.showMessageDialog(null, "El primer valor es mayor  que el segundo valor");
                }
                break;
            case "<=":
                if (this.N1 <= this.N2) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "El primer valor es menor igual que el segundo valor");
                }else{
                     JOptionPane.showMessageDialog(null, "El primer valor es mayor igual que el segundo valor");
                }
                break;
            case ">":
                if (this.N1 > this.N2) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "El primer valor es mayor que el segundo valor");
                }else{
                    
                   JOptionPane.showMessageDialog(null, "El primer valor es menor que el segundo valor");
                }
                break;
            case ">=":
                if (this.N1 >= this.N2) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "El primer valor es mayor igual que el segundo valor");
                }else{
                    JOptionPane.showMessageDialog(null, "El primer valor es menor igual que el segundo valor");
                }
                break;
            case "!=":
                if (this.N1 != this.N2) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "El primer valor es diferente igual que el segundo valor");
                }else{
                    JOptionPane.showMessageDialog(null, "El segundo valor es diferente igual que el primer valor");
                }
                break;
            case "==":
                if (this.N1 == this.N2) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "Los dos valores son iguales");
                }else{
                    JOptionPane.showMessageDialog(null, "Los valores no son iguales");
                }
                break;
            case "&&":
                JOptionPane.showMessageDialog(null, "La condicion se cumple si ambos son mayores a 5");
                if (this.N1 > 5&& this.N2 > 5) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "Ambos valores son mayores a 5");
                }else{
                    JOptionPane.showMessageDialog(null, "Ambos valores deben ser mayores a 5");
                }
                break;
            case "||":
                JOptionPane.showMessageDialog(null, "La condicion se cumple si uno de los valores es mayor a 10");
                if (this.N1 > 10 || this.N2 < 10) {
                    op2 = true;
                    JOptionPane.showMessageDialog(null, "Al menos uno de los dos valores es mayor a 10");
                }else {
                    JOptionPane.showMessageDialog(null, "Ningunio de los valores es mayor a 10");
                }
                break;
        }
        return op2;
    }
}
