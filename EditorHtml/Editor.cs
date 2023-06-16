using System;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("----------------------------------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" Salvar arquivo? S/N");

            String? ComandoSalvar = Console.ReadLine();

            if ((ComandoSalvar == "S") || (ComandoSalvar == "s"))
            {
                Salvar(file.ToString());
            }

            Viewer.Show(file.ToString());
        }

        public static void Salvar(string text)
        {
            Console.WriteLine(" Qual caminho para salvar o arquivo? ");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($" Arquivo {path} salvo com sucesso! ");
            Console.ReadLine();
        }
    }
}