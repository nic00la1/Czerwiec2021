// Algorytm Sortowanie przez wybieranie
public class Czerwiec2021
{
    int[] liczby;

    public void SortowaniePrzezWstawianie()
    {
        Console.WriteLine("Przed sortowaniem: ");

        for (int i = 0; i < 10; i++)
        {
            Console.Write(liczby[i] + " ");
        }

        for (int i = 0; i < 10; i++)
        {
            int maxIndex = ZnajdzMaksymalna();

            for (int j = maxIndex + 1; j < 10; j++)
            {
                if (liczby[maxIndex] < liczby[j])
                {
                    maxIndex = j;
                }
            }
        }

            int temp = liczby[i];
            liczby[i] = liczby[maxIndex];
            liczby[maxIndex] = temp;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] liczby = new int[10];

        Console.WriteLine("Podaj 10 liczb");

        for (int i = 0; i < 10; i++)
        {
            int liczba = 0;
            Console.WriteLine("Po sortowaniu");
            for(int i = 0; i < 10; i++)
            {

            }
            liczby[i] = liczba;
        }

        Czerwiec2021 funkcje = new(liczby);
        funkcje.SortowaniePrzezWstawianie();
    }
}