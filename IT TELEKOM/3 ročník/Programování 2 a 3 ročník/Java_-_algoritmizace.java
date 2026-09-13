import javax.swing.*;
import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {


        //větvení
        //Na vstupu je číslo, napište, zda je sudé nebo liché.
        Scanner sc = new Scanner(System.in);
        System.out.print("Zadej číslo: ");
        int cislo = Integer.parseInt(sc.nextLine());    //int cislo = sc.nextInt();
        if (cislo % 2 == 0)
            System.out.println("Sudé");
        else
            System.out.println("Liché");




        //Zadávejte slova tak dlouho, dokud uživatel nenapíše slovo ok.
        //Poté vypište počet slov, které napsal (OK se do toho nepočítá)
        String text;
        int pocet = -1;
        do {
            System.out.print("Text: ");
            text = sc.nextLine().toLowerCase();
            pocet++;
        } while (!text.equals("ok"));
        System.out.printf("Počet slov: %d\n", pocet);





        //Uživatel zadá 2 čísla (nevíte které je větší a které je menší)
        //Napište všechna celá čísla z intervalu <max, min> (vedle sebe) na conoli SESTUPNĚ
        System.out.print("Zadej min: ");
        int min = sc.nextInt();
        System.out.print("Zadej max: ");
        int max = sc.nextInt();

        if (min > max) {
            int pom = min;
            min = max;
            max = pom;
        }

        for (int i = max; i >= min; i--)
            System.out.print(i + ", ");


        //Generování náhodných čísel
        Random nahoda = new Random();
        int c;
        for(int ii = 0; ii<100;ii++)
        {
            c = nahoda.nextInt(5, 15 + 1);
            System.out.print(c + ", ");
        }


        //Uživatel zadá na vstupu 2 znaky abecedy a program vypíše, které z
        // těchto písmen je v abecedě výše

        //Vygenerujte náhodně 2 celá čísla, poté vypište součet všech čísel
        // z rozsahu těchto dvou čísel

        //Určete faktoriál daného čísla ze vstupu. Pokud je výsledek moc velký,
        // vypište hlášení o problému

        //Uživatel zadá kladné celé číslo. Napište fibonacciho posloupnost
        //až po zadané číslo.
        //Fibonacciho posloupnost je posloupnost čísel, kde první dva členy jsou 0 a 1
        //a každý následující člen je součtem dvou předchozích členů.
        //zda máte část posloupnosti: 0,1,1,2,3,5,8,13,21,34,…










    }


}