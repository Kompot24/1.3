namespace ConsoleApp1
{
    public class Logic
    {
        public static string Compare(string text)
        {
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
            string outMessage = $"Кол-во пар одинаковых соседних букв: {count}";
            return outMessage;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            string text = "asd daaffaf a ff a f fad dasasaafasdss";
            string message = Logic.Compare(text);

            Console.WriteLine(message);
        }
    }
}
