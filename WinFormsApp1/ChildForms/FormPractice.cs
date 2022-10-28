using WordModel;

namespace WinFormsApp1.Forms;

public partial class FormPractice : Form
{
    private double _totalAwnsersRight = 0, _totalWords = 0;

    private Word randomWord;

    WordList _loadedWordListPractice;

    public string WordListName;

    public FormPractice()
    {
        InitializeComponent();

        MainForm.instance._menuLabel.Text = "Practice";

        MainForm.instance.HighLightCurrentMenuButton(MainForm.instance._PracticeBtn);

        FillComboBoxWithWordListNames();
    }

    private void FillComboBoxWithWordListNames()
    {
        string[] wordListNames = WordList.GetLists();

        foreach (var list in wordListNames)
            LanguageSelectionComboBox.Items.Add(list);
    }

    private void StartPracticeBtn_Click(object sender, EventArgs e)
    {
        if (LanguageSelectionComboBox.SelectedItem == null)
            return;

        StatsLabel.Text = "0 of 0 words were correct.";
        WordListName = LanguageSelectionComboBox.SelectedItem.ToString() ?? string.Empty;
        StartPractice(WordListName);

    }

    public void StartPractice(string practiceName)
    {
        _loadedWordListPractice = WordList.LoadList(practiceName);
        randomWord = _loadedWordListPractice.GetWordToPractice();

        LanguageSelectionComboBox.Text = practiceName;

        WordListName = practiceName;

        string translateWordFrom = _loadedWordListPractice.Languages[randomWord.FromLanguage];

        string translateWord = randomWord.Translations[randomWord.FromLanguage];

        string translateWordTo = _loadedWordListPractice.Languages[randomWord.ToLanguage];

        TranslationLabel.Text = $"Translate the {translateWordFrom} word '{translateWord}' to {translateWordTo}";
    }

    private void RestartBtn_Click(object sender, EventArgs e)
    {
        if (_totalWords == 0) return;

        StatsLabel.Text = $"You got {_totalAwnsersRight / _totalWords * 100:0}% of the right awnsers!";

        _totalWords = 0;
        _totalAwnsersRight = 0;

        StartPractice(WordListName);
    }

    private void AwnserTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        e.Handled = e.SuppressKeyPress = true;

        _totalWords++;

        string rightAnswer = randomWord.Translations[randomWord.ToLanguage].ToLower();

        string userAnswer = AwnserTextBox.Text.TrimStart().TrimEnd().ToLower();

        IsAnswerCorrect(userAnswer, rightAnswer);

        AwnserTextBox.Text = string.Empty;      

        StartPractice(WordListName);
    }

    private void IsAnswerCorrect(string userAnswer, string rightAnswer)
    {
        if (userAnswer == rightAnswer)
        {
            _totalAwnsersRight++;
            StatsLabel.Text = $"{_totalAwnsersRight} of {_totalWords} words were correct.";
            labelRightAwnser.Text = string.Empty;

            return;
        }

        StatsLabel.Text = $"{_totalAwnsersRight} of {_totalWords} words were correct.";
        labelRightAwnser.Text = $"The right answer was '{rightAnswer}'";
    }

    private void EndPracticeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
