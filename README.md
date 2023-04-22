Добро пожаловать в программу калькулятор!

Данная программа способна считывать примеры с вашего текстового файла и выводить ответ прямо в консоли,
за считывание отвечает данный метод:

  public static bool isTxt(string path)
        {
            string ex = path.Substring(path.Length - 4);
            if (ex == ".txt" | ex == ".TXT")
                return true;
            Console.WriteLine("Имя файла задано неверно!");
            return false;
        }

  public static bool Exists(string path)
        {
            if (File.Exists(path))
                return true;
            Console.WriteLine("Файл не существует");
            return false;
        }
        
За решение и выполнение базовых операций отвечает метод Calculate, а за выбор операции - функция ContUp
Основная же программа выполняется в методе Main:
 static void Main(string[] args)
        {
            string path = args[0];
            if (isTxt(path) && Exists(path))
            {
                FileStream file = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(file);
                string line = reader.ReadToEnd();
                reader.Close();
                Console.WriteLine(Calculate(line));
            }
        }
