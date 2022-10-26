using System.Text;

namespace WordModel
{
    public class WordList
    {
        private static string path = @$"C:\Users\{Environment.UserName}\AppData\Local\lab3SaveFiles";

        private readonly List<Word> _words = new List<Word>();

        public string Name { get; }
        public string[] Languages { get; }

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        public static string[] GetLists()
        {
            var fileNames = new List<string>();
            var fileObjects = new DirectoryInfo(path);

            FileInfo[] files = fileObjects.GetFiles("*.dat");

            fileNames.AddRange(files.Select(f => f.Name.Replace(".dat", "")));

            return fileNames.ToArray();
        }

        public static WordList LoadList(string name)
        {
            string filePath = @$"{path}\{name}.dat";

            using StreamReader sr = File.OpenText(filePath);

            string[] languages = sr.ReadLine().Split(';').SkipLast(1).ToArray();

            var loadList = new WordList(name, languages);

            while (!sr.EndOfStream)
            {
                string[] wordTranslations = (sr.ReadLine() ?? string.Empty).Split(";").SkipLast(1).ToArray();

                loadList.Add(wordTranslations);
            }
            return loadList;
        }

        public void Save()
        {
            var fileContent = new List<string>();
            var lineContent = new StringBuilder();

            Array.ForEach(Languages, s => lineContent.Append(s + ";"));

            fileContent.Add(lineContent.ToString());

            lineContent.Clear();

            foreach (var word in _words)
            {
                Array.ForEach(word.Translations, s => lineContent.Append(s + ";"));

                fileContent.Add(lineContent.ToString().ToLower());
                lineContent.Clear();
            }

            using var sw = new StreamWriter(path + @$"\{Name}.dat");

            Array.ForEach(fileContent.ToArray(), s => sw.WriteLine(s));
        }

        public void Add(params string[] translations)
        {
            if (Languages.Length % translations.Length != 0) throw new ArgumentException("The number of languages and number of _words in this dictionary is not equal."); // lika många ord som språk
            _words.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (_words[i].Translations[translation] != word) continue;

                _words.RemoveAt(i);
                Save();
                return true;
            }

            return false;
        }

        public int Count()
        {
            return _words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslation)
        {
            Word[] sortedWords = _words.OrderBy(x => x.Translations[sortByTranslation]).ToArray();

            var returnValues = new List<string>();

            foreach (var word in sortedWords)
            {
                Array.ForEach(word.Translations, s => returnValues.Add(s));
            }

            showTranslation(returnValues.ToArray());
        }
        public Word GetWordToPractice()
        {
            var random = new Random();

            int randomFromLanguage = random.Next(0, Languages.Length);
            int randomToLanguage = random.Next(0, Languages.Length);

            while (randomFromLanguage == randomToLanguage)
            {
                randomToLanguage = random.Next(0, Languages.Length);
            }

            return new Word(randomFromLanguage, randomToLanguage, _words[random.Next(0, _words.Count)].Translations);
        }
    }
}
