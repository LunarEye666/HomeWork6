namespace HomeWork6
{
    class Program
    {
        static void writening()
        {
            string path = @"C:\Users\Admin\Desktop\prot.txt";
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Unicode))
            {
                char key = 'д';
                do
                {
                    string note = string.Empty;
                    Console.WriteLine("ID: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Время внесения сохранено");
                    string now = DateTime.Now.ToString();
                    note += ($"{now}\t");
                    Console.WriteLine("Введите Ф.И.О: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Возраст: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Рост: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Дата Рождения: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Место Рождения: ");
                    note += $"{Console.ReadLine()}\t";
                    sw.WriteLine($"{note}");

                    Console.WriteLine("Продолжить?");
                    key = Console.ReadKey(true).KeyChar;
                }
                while (char.ToLower(key) == 'д');
            }
        }

        static void reading()
        {
            string path = @"C:\Users\Admin\Desktop\prot.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Unicode))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('\t');
                    foreach (string word in data) //в столбик)
                    {
                        Console.WriteLine($"{word}");
                    }
                }
                sr.ReadLine();
            }
        }
        //Solution 
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! 1 - внести новую заметку, 2 -считать файл: ");
            string key = Console.ReadLine();
            char keyw = Convert.ToChar(key);
            if (keyw == '1')
            {
                writening();
            }
            else if (keyw == '2')
            {
                Console.Clear();
                reading();
                Console.ReadKey();
            }
        }
    }
}