package palindromo;

import java.util.Scanner;

public class Palindromo {

    Scanner teclado = new Scanner(System.in);
    private String palabra, reves = "";

    public void Cargar() {

        System.out.println("Un palindromo es una Palabra o expresión que es igual si se lee de izquierda a derecha "
                + "que de derecha a izquierda.");
        System.out.println("------------------------------------------------------------------------------------");
        System.out.println("Ingrese una palabra para determinar si en un palindromo o no");
        palabra = teclado.nextLine();
        palabra = palabra.replace(" ", "");
        palabra = palabra.replace("á", "a");
        palabra = palabra.replace("é", "e");
        palabra = palabra.replace("í", "i");
        palabra = palabra.replace("ó", "o");
        palabra = palabra.replace("ú", "u");
        palabra = palabra.replace(".", "");

        for (int x = palabra.length() - 1; x >= 0; x--) {
            reves += palabra.charAt(x);
        }
        if (palabra.equals(reves)) {
            System.out.println("-------------------------------------------------------");
            System.out.println("Tu palabra es un polindromo");
        } else {
            System.out.println("-------------------------------------------------------");
            System.out.println("Tu palabra no es polindromo");

        }
    }

    public static void main(String[] args) {

        Palindromo mi = new Palindromo();
        mi.Cargar();

    }
}
