import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        //sout
        System.out.println("America");

        //sout - zřetězení
        double castka = 20;
        System.out.println(castka+" Kč");

        //souf - format
        int a = 20;
        int b = 30;
        System.out.printf("strana a je %d cm, strana b je %d, obsah je %d cm2\n",a,b,a*b);

        String jmeno = "Petr";
        int vek = 14;
        double prumer = 3.12381;

        System.out.printf("%s má %d let a průměr známek %.2f\n",jmeno, vek, prumer);

        //System.err.println("Chyba na vstupu");


        System.out.println("Seznam nákupu:\r\n\t- jablko\r\n\t- ananas\r\n\t- pomeranč");

        //Vstupy
        Scanner sc = new Scanner(System.in);
        System.out.print("Zadej jméno :");
        String jm = sc.nextLine();

        //parsování - 2 možnosti
        System.out.print("Zadej věk: ");
        int ve = Integer.parseInt(sc.nextLine());
        //int v = sc.nextInt(); //2. varianta, text před parsováním již nelze editovat

        //.toString
        String veStr = String.valueOf(ve);

        //Random
        Random nahoda = new Random();
        int sleva = nahoda.nextInt(20); //generuje čísla od 0 do 19
        int sleva2 = nahoda.nextInt(5,21); //generuje čísla od 5 do 20

        //na vstupu uživatel zadá 2 znaky, které nejprve uložíte
        //do proměnných a pak jejich obsah prohodíte a znova vypíšte.
        System.out.print("Zadej znak 1: ");
        char znak1= sc.nextLine().trim().charAt(0);
        System.out.print("Zadej znak 2: ");
        char znak2= sc.nextLine().trim().charAt(0);
        System.out.printf("znak1 = %s, znak2 = %s",znak1,znak2);

        char pom = znak1;
           znak1 = znak2;
            znak2=pom;

        System.out.printf("znak1 = %s, znak2 = %s",znak1,znak2);

        //Na vstupu je číslo. Je sudé nebo liché?
        System.out.print("Zadej číslo: ");
        int cislo = Integer.parseInt(sc.nextLine());    //int cislo = sc.nextInt();
        if (cislo % 2 == 0)
            System.out.println("Sudé");
        else
            System.out.println("Liché");




    }
}