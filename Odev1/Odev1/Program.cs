// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        Task4();
    }

    /*
     * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
     * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
     * Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
     */
    public static void Task1()
    {
        Console.Write("Adet sayısını giriniz : ");
        int n = Int32.Parse(Console.ReadLine()!);
        int[] nums = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write((i+1) + ". sayıyı giriniz : ");
            nums[i] = Int32.Parse(Console.ReadLine());
        }
        
        Console.Write("Girdiğiniz sayılardan çift olanlar : ");
 
        foreach (var indis in nums)
        {
            if (indis % 2 == 0)
                Console.Write(indis + ", ");
        }
    }

    /*
     * Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
     * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
     * Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
     */
    public static void Task2()
    {
        Console.Write("Adet sayısını giriniz : ");
        int n = Int32.Parse(Console.ReadLine()!);
        Console.Write("Gireceğiniz sayılar kaça tam bölünecek : ");
        int m = Int32.Parse(Console.ReadLine()!);
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write((i + 1) + ". sayıyı giriniz : ");
            nums[i] = Int32.Parse(Console.ReadLine()!);
        }

        Console.Write($"Girdiğiniz sayılardan {m}'e tam bölünenler : ");
        
        foreach (var num in nums)
        {
            if (num % m == 0)
                Console.Write(num + ", ");
        }
    }

    /*
     * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
     * Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
     * Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
     */
    public static void Task3()
    {
        Console.Write("Kelime adet sayısını giriniz : ");
        int n = Int32.Parse(Console.ReadLine()!);
        string[] words = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i+1}. kelimeyi giriniz : ");
            words[i] = Console.ReadLine()!;
        }
        
        for (int i = (n - 1); i >= 0; i--)
        {
            Console.Write($"{words[i]}, ");
        }
    }
    
    /*
     * Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
     * Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
     */
    public static void Task4()
    {
        Console.Write($"Cümleyi giriniz : ");
        string sentence = Console.ReadLine()!;
        string[] wordsInSentence = sentence.Split(" ");
        int wordCount = 0;
        int totalCharCount = 0;
        foreach (var words in wordsInSentence)
        {
            wordCount++;
            foreach (var chars in words)
            {
                totalCharCount++;
            }
        }
        Console.WriteLine($"Toplam kelime sayısı : {wordCount}\nToplam karakter sayısı : {totalCharCount}");
    }
}
