 /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package diagonaldifference;
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;


/**
 *
 * @author Esbaide Hdez
 */

    class Result {

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<Integer>> arr) {
    // Write your code here
        int suma1=0;
        int suma2=0;
        int resta=0;
        int x= arr.size();
        
        for(int f=0; f<arr.size();f++) {
		for(int c=0; c< arr.size();c++) {
			if(f==c) {
			
				suma1= suma1 + arr.get(c).get(f);
			}
			if(f+ c == (x-1)){
                           // x--;
					
					suma2 = suma2 +  arr.get(f).get(c)  ;
                                        
				}
		}
		resta=suma1-suma2;
               
             }
        if(resta < 0){
            resta=resta*-1;
        System.out.println(resta );
       
            }
         return resta;
        }
    }

public class DiagonalDifference {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(("C:\\Users\\Esbaide Hdez\\diaginal.txt")));

        int n = Integer.parseInt(bufferedReader.readLine().trim());

        List<List<Integer>> arr = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            String[] arrRowTempItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

            List<Integer> arrRowItems = new ArrayList<>();

            for (int j = 0; j < n; j++) {
                int arrItem = Integer.parseInt(arrRowTempItems[j]);
                arrRowItems.add(arrItem);
            }

            arr.add(arrRowItems);
        }

        int result = Result.diagonalDifference(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
 }

