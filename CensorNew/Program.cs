using CensorNew;

const string censorWord = "уточка";

Console.WriteLine("specify the path to the directory");
string Path = Console.ReadLine();
List<string> Words = new List<string>()
{
    "бля",
    "хуй",
    "хуя",
    "ебан",
    "муд",
    "ебу"
};


CensorWords(@"C:\Users\vladu\Desktop\Новая папка\файл для цензуры.txt");

void CensorWords(string path)
{
    Path = path;
    DirectoryInfo directoryInfo = new DirectoryInfo(path);
 
    string censor = File.ReadAllText(path);
    
    foreach (var word  in Words)
    {
      censor =  censor.Replace(word.ToLower(), censorWord);
      censor = censor.Replace(word.ToUpper(), censorWord);
      censor = censor.Replace(word.ToUpperFirstChar(), censorWord);
    }

    Console.WriteLine(censor);
}

