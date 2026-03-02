namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "asd daaffaf a ff a f fad dasasaafasdss";
            int count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    if (text[i] == text[i + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Кол-во пар одинаковых соседних букв: {count}");
        }
    }
}
