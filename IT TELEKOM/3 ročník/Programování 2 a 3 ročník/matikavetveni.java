import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Zadej kolik ma babka jablek: ");
        int babka_jablko = Integer.parseInt(scanner.nextLine());

        System.out.print("Zadej kolik ma dedek jablek: ");
        int dedek_jablko = Integer.parseInt(scanner.nextLine());

        System.out.println();


        double rozdil = babka_jablko - dedek_jablko;
        rozdil = rozdil/2;
        double rozdil2 = dedek_jablko - babka_jablko;
        rozdil2 = rozdil2/2;

        String babka = "";

        if (rozdil == 1){
            babka = "jablko";
        }
        else if (rozdil > 0 && rozdil < 5){
            babka = "jablka";
        }
        else{
            babka = "jablek";
        }

        String dedek = "";

        if (rozdil2 == 1){
            dedek = "jablko";
        }
        else if (rozdil2 > 0 && rozdil2 < 5){
            dedek = "jablka";
        }
        else{
            dedek = "jablek";
        }


        if (rozdil == 0){
            System.out.println("Oba maji stejne");
        }
        else {
            if (rozdil > 0){
                System.out.println("Babka musi dat dedkovi " + rozdil + " " + babka);
            }
            else {
                System.out.println("Dedek musi dat babce " + rozdil2 + " " + dedek);
            }
        }

    }
}