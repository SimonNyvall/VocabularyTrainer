using WordModel;

namespace VocabularyTrainer;
internal class VocabularyTrainerConsole
{
    private static void Main(string[] args)
    {
        CreateSaveFileDirectory();

        const string usage =
            "-list" + "\n" +
            "-new <list name> <language 1> <language 2> .. <language n>" + "\n" +
            "-add <list name>" + "\n" +
            "-remove <list name> <language> <word 1> <word 2> .. <word n>" + "\n" +
            "-words <list name> <sortByLanguage>" + "\n" +
            "-count <list name>" + "\n" +
            "-practice <list name>";

        if (!IsArgsParametersValid(args, usage)) Environment.Exit(1);

        int runTimeResult = ExecuteArgsZeroCommand(args, usage);

        if (runTimeResult > 1) Environment.Exit(runTimeResult);
    }
    private static void CreateSaveFileDirectory()
    {
        string path = @$"C:\Users\{Environment.UserName}\AppData\Local\lab3SaveFiles";

        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }
    private static bool IsArgsParametersValid(string[] args, string usage)
    {
        if (args.Length == 0)
        {
            PrintFaultMessage(usage);
            return false;
        }

        var validParameterAmount = new (string command, int min, int max)[]
        {
                ("-list", 1, 1),
                ("-new", 4, 0),
                ("-remove", 4, 0),
                ("-add", 2, 2),
                ("-words", 2, 3),
                ("-count", 2, 2),
                ("-practice", 2, 2)
        };

        if (validParameterAmount.All(v => v.command != args[0]))
        {
            PrintFaultMessage(usage);
            return false;
        }

        // Name
        if (args.Length < 2 && args[0] != "-list")
        {
            PrintFaultMessage(usage, 0);
            return false;
        }

        if (args.Length < 3 && (args[0] == "-new" || args[0] == "-remove"))
        {
            PrintFaultMessage(usage, 1);
            return false;
        }

        if (args.Length < 4 && (args[0] == "-new" || args[0] == "-remove"))
        {
            PrintFaultMessage(usage, args[0] == "-new" ? 2 : 3);
        }

        var match = validParameterAmount.Where(c => c.command == args[0]).ToArray();

        if (args.Length < match[0].min)
        {
            PrintFaultMessage(usage, 4, match[0].command);
            return false;
        }
        else if (args.Length > match[0].max && match[0].max != 0)
        {
            PrintFaultMessage(usage, 5, match[0].command);
            return false;
        }

        return true;
    }
    static void PrintFaultMessage(string usage, int faultMessageIndex = -1, string command = "")
    {
        string[] faultMessages =
        {
                "Name of WordList is missing",
                "Missing a selection of language - ",
                "Missing a selection of second language",
                "Missing a selection of word or words",
                $"Command {command} had too few parameters",
                $"Command {command} had too many parameters"
        };

        Console.WriteLine(faultMessageIndex == -1 ? usage : faultMessages[faultMessageIndex]);
    }

    private static int ExecuteArgsZeroCommand(string[] args, string usage)
    {
        string name = (args.Length > 1) ? args[1] : string.Empty;

        int runTimeResult = args[0] switch
        {
            "-list" => PrintAllWordLists(),
            "-new" => CreateNewWordList(name, args.Skip(2).ToArray()),
            "-add" => AddWordsToList(name),
            "-remove" => RemoveWordsFromList(name, args[2], args.Skip(3).ToArray()),
            "-words" => PrintSortedList(name),
            "-count" => PrintWordListCount(name),
            "-practice" => PracticeWords(name),
            _ => PrintUsage(usage)
        };

        return runTimeResult;
    }
    private static int PrintAllWordLists() // -lists
    {
        string[] wordListNames = WordList.GetLists();

        foreach (var listName in wordListNames)
            Console.WriteLine(listName);

        if (wordListNames.Length != 0) return 1;

        Console.WriteLine("There are no WordLists to print.");
        Console.WriteLine("Create a new WordList with the -new command");

        return 0;
    }

    private static int CreateNewWordList(string name, string[] languages) // -new
    {
        var newWordList = new WordList(name, languages);

        newWordList.Save();

        AddWordsToList(name);

        return 0;
    }

    private static int AddWordsToList(string name) // -add
    {
        if (!DoesListExist(name)) return 1;
        
        WordList loadedWordListAdding = WordList.LoadList(name);

        string userInput = "Empty";
        var words = new List<string>();

        while (userInput != string.Empty)
        {
            foreach (var language in loadedWordListAdding.Languages)
            {
                Console.Write($"Enter a word in {language}: ");
                userInput = Console.ReadLine() ?? string.Empty;

                if (userInput == string.Empty)
                    break;

                words.Add(userInput.TrimStart().TrimEnd().ToLower());
            }

            if (userInput.Contains(";"))
            {
                Console.WriteLine("A word cannot contain the ';' symbol! Retype the words...");
            }
            else if (userInput != string.Empty)
            {
                loadedWordListAdding.Add(words.ToArray());
            }

            words.Clear();
        }

        loadedWordListAdding.Save();

        Console.WriteLine($"The new WordList {name} has been created!");
        PrintSortedList(name);

        return 1;
    }
    private static int RemoveWordsFromList(string name, string language, string[] words) // -remove
    {
        if (!DoesListExist(name)) return 1;
        
        
        var loadedWordListRemoving = WordList.LoadList(name.ToLower());

        var index = Array.FindIndex(loadedWordListRemoving.Languages, row => row.Contains(language.ToLower()));

        const int languageNotFound = -1;

        if (index == languageNotFound)
        {
            Console.WriteLine("The language does not exist in this dictionary.");
            return 1;
        }

        foreach (var word in words)
        {
            Console.WriteLine(loadedWordListRemoving.Remove(index, word.ToLower())
                ? $"Successfully removed the word {word.ToLower()} from {name.ToLower()}"
                : $"The word {word.ToLower()} was not in the dictionary {name.ToLower()}");
        }

        return 0;
    }
    private static int PrintSortedList(string name, string sortByLanguage = "") // -words
    {
        if (!DoesListExist(name)) return 1;
        

        var loadedWordList = WordList.LoadList(name);

        void ShowTranslation(string[] input)
        {
            var altWhiteSpace = loadedWordList.Languages.SkipLast(1).Max(x => x.Length);
            var whiteSpaces = input.SkipLast(1).Max(x => x.Length);

            whiteSpaces = Math.Max(whiteSpaces, altWhiteSpace);

            const int whiteSpaceOffset = 3;

            foreach (var language in loadedWordList.Languages)
            {
                Console.Write(language.ToTitel().PadRight(whiteSpaces + whiteSpaceOffset));
            }

            Console.WriteLine();

            var languageLengthSum = loadedWordList.Languages.Sum(s => s.Length);
            Console.Write(new string('-', languageLengthSum + whiteSpaces + whiteSpaceOffset * (loadedWordList.Languages.Length - 1) - loadedWordList.Languages[0].Length));

            var columnIndex = 0;
            foreach (var word in input)
            {
                if (columnIndex % loadedWordList.Languages.Length == 0) Console.WriteLine();

                Console.Write(word.ToTitel().PadRight(whiteSpaces + whiteSpaceOffset));

                columnIndex++;
            }
        }

        var translationIndex = Array.FindIndex(loadedWordList.Languages, row => row.Contains(sortByLanguage));

        if (translationIndex == -1)
            translationIndex = 0;

        loadedWordList.List(translationIndex, ShowTranslation);

        return 0;
    }
    private static int PrintWordListCount(string name) // -count
    {
        if (!DoesListExist(name)) return 1;
        

        var loadedWordListCount = WordList.LoadList(name);
        Console.WriteLine($"The dictionary contains {loadedWordListCount.Count()} words, with {loadedWordListCount.Count() * loadedWordListCount.Languages.Length - loadedWordListCount.Languages.Length} translations.");

        return 0;
    }
    private static int PracticeWords(string name) // -practice
    {
        if (!DoesListExist(name)) return 1;
        

        WordList loadedWordListPractice = WordList.LoadList(name);

        var userInput = "Default";
        double wordsRight = 0, totalWords = 0;

        while (userInput != string.Empty)
        {
            Word practiceWord = loadedWordListPractice.GetWordToPractice();


            Console.Write($"[{loadedWordListPractice.Languages[practiceWord.FromLanguage].ToTitel()}-{loadedWordListPractice.Languages[practiceWord.ToLanguage].ToTitel()}] Translate the word {practiceWord.Translations[practiceWord.FromLanguage].ToTitel()} to {loadedWordListPractice.Languages[practiceWord.ToLanguage].ToTitel()}: ");
            userInput = Console.ReadLine() ?? string.Empty;

            if (userInput == string.Empty)
            {
                if (totalWords != 0)
                    Console.WriteLine($"You got {wordsRight / totalWords * 100:0}% of the answers right.");
                else
                    Console.WriteLine("You got 0% of the answers right.");
                break;
            }

            totalWords++;

            if (string.Equals(userInput.TrimStart().TrimEnd(), practiceWord.Translations[practiceWord.ToLanguage], StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You Got It Right!!!");
                wordsRight++;
            }
            else
            {
                Console.WriteLine($"Almost, the right answer was {practiceWord.Translations[practiceWord.ToLanguage].ToTitel()}");
            }
        }

        return 0;
    }
    private static bool DoesListExist(string name)
    {
        var wordLists = WordList.GetLists();

        return wordLists.Contains(name);
    }

    private static int PrintUsage(string usage)
    {
        Console.WriteLine(usage);
        return 0;
    }
}
