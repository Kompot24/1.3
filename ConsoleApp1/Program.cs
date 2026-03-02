namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "asd daaffaf a ff a f fad 123 ssdfdfgfgg";
            int count = 0;
            for (int i = 0; i < text.Length-1; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    if (text[i] == text[i+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Кол-во одинаковых букв: {count}");
        }
    }
}
