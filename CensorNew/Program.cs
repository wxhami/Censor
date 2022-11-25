using CensorNew;
const string goodWord = "уточка";
List<string> BadWords = new List<string>()
{
    "бля",
    "хуй",
    "хуя",
    "ебан",
    "муд",
    "ебу",
    "ебал"
};

Console.Write("specify the path to the directory: ");
string Path = Console.ReadLine();

FileInfo fileInfo = new FileInfo(Path);

if (fileInfo.Exists)
{
    File.WriteAllText(fileInfo.DirectoryName + "\\CensorNext.txt", CensorWords(Path));
}
else
{
    Console.WriteLine("Not found");
}



string CensorWords(string path)
{
    string censor = File.ReadAllText(path);
    
    foreach (var word  in BadWords)
    {
      censor =  censor.Replace(word.ToLower(), goodWord);
      censor = censor.Replace(word.ToUpper(), goodWord);
      censor = censor.Replace(word.ToUpperFirstChar(), goodWord);
    }

    return censor;
}

