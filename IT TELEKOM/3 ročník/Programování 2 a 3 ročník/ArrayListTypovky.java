import java.util.ArrayList;
import java.util.Random;

public class Main {

    public static void vypisSeznam(ArrayList<Integer> seznam)
    {
        for(Integer cislo:seznam)
            System.out.print(cislo + ", ");
    }

    public static void main(String[] args)
    {
//1. Vytvořte seznam celých čísel s názvem cisla a uložte do něho na začátku hodnoty 10,18,15,-5
        ArrayList<Integer> cisla = new ArrayList<>(java.util.Arrays.asList(10, 18, 15, -5));

//2. Do tohoto seznamu nalosujte navíc dalších 100 čísel od -20 do 20
        Random nahoda = new Random();
        for (int i = 0; i < 100; i++) {
            cisla.add(nahoda.nextInt(-20, 21));
        }

//3. Vytvořte samostatnou metodu VypisSeznam – pro výpis položek seznamu vedle sebe
        vypisSeznam(cisla);

//4. Vymažte všechny výskyty čísla 0 ze seznamu
        while(cisla.contains(0))
        {
            cisla.remove((Integer)0);
        }

//5.Vymažte všechny výskyty záporných dvouciferných čísel ze seznamu
        for (int i = 0; i< cisla.size();i++ )
        {
            Integer x = cisla.get(i);
            if (x>=-99 && x<=-10) {
                cisla.remove(i);
                i--; //znova zkontroluju index, na kterém přistála při smazání jiná hodnota
            }
        }

//6.Vymažte každý 5. prvek (počínaje prvkem na indexu 4)
//Pozor, prvky se postupně umazávají a hodnoty na indexech se posouvají!
        for (int i = 4; i< cisla.size(); i+=5) {
            cisla.remove(i);
            i++;
        }
        System.out.println("\n");
        vypisSeznam(cisla);

//7.Vypište číslo indexu, na kterém leží
//   1. hodnota 10, pokud v seznamu hodnota není, napište NENALEZENO

        int index = cisla.indexOf(10);
        if (index != -1)
            System.out.println(index);
        else
            System.out.println("NENALEZENO");

//8. Vypište , kolik hodnot v poli je nezáporných
        int pocet = 0;
        for(Integer cislo:cisla)
            if (cislo >=0)
                pocet++;
        System.out.print(pocet);
    }
    }
