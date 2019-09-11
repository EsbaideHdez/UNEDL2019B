/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recorridomatriz;

/**
 *
 * @author Esbaide Hdez
 */
public class RecorridoMatriz {

    int[][] matriz = {{1,3,5,7},{4,7,9,7},{2,6,8,0},{2,4,5,2}};
    int fila, columna;
    int x, y;
    
    public void cargar() {
//		teclado = new Scanner(System.in);
		System.out.println("           MATRIZ         ");
	//System.out.println(matriz);
		for(int f=0; f<matriz.length;f++) {
			System.out.print("[ ");
			for(int c=0; c<matriz[f].length;c++) {
				System.out.print(matriz[f][c] +  " "); 
				}
			System.out.print("]");//se imprime en pantalla solo para hacer el acomodo
			System.out.print("\n");
		}
	}
	public void resultado() {
		for(int z=0; z<3; z++) {
		for(int y=0; y<4;y++) {
			System.out.print(matriz[y][x]);
			if(y==3) {
				x++;
			}
			
			}
		for(int y=3; y>=0;y--) {
			System.out.print(matriz[y][x]);
			if(y==0) {
				x++;
			}
			
		}
		
	}
		
        }
    public static void main(String[] args) {
        RecorridoMatriz mi = new RecorridoMatriz();
		mi.cargar();
		mi.resultado();
    }
    
}

