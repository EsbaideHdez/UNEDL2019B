package Primer_Parcial;
import java.util.Scanner;
public class Ejercicio_2 {
private Scanner teclado; 
	private int [][] matriz;
	private int fila, columna;
	int suma=0 , suma1=0;
	int resta =0;
	
	public void cargar() {
		teclado = new Scanner(System.in);
		System.out.println("           MATRIZ         ");
		System.out.print("Ingrese las filas de la matriz: ");
		fila=teclado.nextInt();
		System.out.print("Ingresr las columnas de la matriz: ");
		columna=teclado.nextInt();
		
		matriz= new int [fila][columna];
		System.out.println("Ingresa los valores de la matriz");
		for(int f=0; f<matriz.length;f++) {
			for(int c=0; c<matriz[f].length;c++) {
				
				System.out.print("Valores "+ "["+f+"]"+"["+c+"]"+": ");
				matriz[f][c]= teclado.nextInt();
			}
		}
		for(int f=0; f<matriz.length;f++) {
			System.out.print("[ ");
			for(int c=0; c<matriz[f].length;c++) {
				System.out.print(matriz[f][c] +  " "); 
				}
			System.out.print("]");//se imprime en pantalla solo para hacer el acomodo
			System.out.print("\n");
		}
	}
	public void suma() {
	
	System.out.println("\n    SUMA PRIMARIA    ");
	for(int f=0; f<matriz.length;f++) {
		for(int c=0; c<matriz[f].length;c++) {
			if(f==c) {
				System.out.println("\t" + matriz[f][c]  + "+");
				suma= suma + matriz[f][c] ;
			}
			
		}
		}
		System.out.println(" = " + suma);
		
		System.out.println("\n    SUMA SECUNDARIA    ");
		for(int f=0; f<matriz.length;f++) {
			for(int c=0; c<matriz[f].length;c++) {
				if(f+c == matriz.length-1){
					System.out.println("\t" + matriz[f][c] + "+");
					suma1 = suma1 +  matriz[f][c]  ;
				}
			}
        }
		System.out.println(" = " + suma1);
	}
	
	public void resta() {
		
		System.out.println("El resultado final es " );
		resta =suma - suma1;
		
		System.out.println(resta * -1);
		
	}

	public static void main(String[] args) {
		Ejercicio_2 mi = new Ejercicio_2();
		mi.cargar();
		mi.suma();
		mi.resta();

	}

}
