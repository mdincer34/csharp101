internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayiDizisi = {2,4,6,8,23,12,68,34,1};
        
        Console.WriteLine("******* Sırasız dizi *******");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        
        // Sort
        Console.WriteLine("******* Sıralı dizi *******");
        Array.Sort(sayiDizisi);
        // Dizi elemanlarını büyükten küçüğe sıralar.
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        // Clear
        Console.WriteLine("******* Array Clear *******");
        Array.Clear(sayiDizisi, 3, 3);
        // 3. indexten başlayarak 3 elemana sıfır değeri atar.
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            
        // Reverse 
        Console.WriteLine("******* Array Reverse *******");
        Array.Reverse(sayiDizisi);
        // Dizi elemanlarını tersine çevirir.
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        // IndexOf   
        Console.WriteLine("******* Array IndexOf *******"); 
        Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
        
        // Resize
        Console.WriteLine("******* Array Resize *******"); 
        Array.Resize<int>(ref sayiDizisi, 10);
        sayiDizisi[9] = 99;
        
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
    }
}