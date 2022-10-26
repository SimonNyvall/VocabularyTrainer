using WordModel;

namespace WinFormsApp1.Forms;
public partial class FormSelectLanguage : Form
{
    public FormSelectLanguage()
    {
        InitializeComponent();

        MainForm.instance._menuLabel.Text = "List Word Lists";

        MainForm.instance.HighLightCurrentMenuButton(MainForm.instance._ListWordListBtn);

        FillListBox();
    }
    private void FillListBox()
    {
        string[] wordListNames = WordList.GetLists();

        foreach (var listName in wordListNames)
        {
            WordListsListBox.Items.Add(listName);
        }
    }

    private void WordListsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedWordList = WordListsListBox.SelectedItem.ToString() ?? string.Empty;

        if (string.IsNullOrEmpty(selectedWordList)) return;

        LanguagesListBox.Items.Clear();

        WordList wordList = WordList.LoadList(selectedWordList);

        foreach (var language in wordList.Languages)
        {
            LanguagesListBox.Items.Add(language);
        }

        PrintLanguageCount(wordList);
    }

    private void PrintLanguageCount(WordList wordList)
    {
        int languageCount = wordList.Count();
        WordListCount.Text = $"Word Count: {languageCount}";
    }

    #region Open Practice session
    private void SelectBtn_Click(object sender, EventArgs e)
    {
        string selectedWordList;
        try
        {
            selectedWordList = WordListsListBox.SelectedItem.ToString() ?? string.Empty;
        }
        catch
        {
            selectedWordList = string.Empty;
        }

        if (string.IsNullOrEmpty(selectedWordList))
        {
            MessageBox.Show("You must select a word list first!");
            return;
        }

        OpenEditModeAsChildForm(selectedWordList);       
    }
    private void OpenEditModeAsChildForm(string selectedWordList)
    {
        Panel p = this.Parent as Panel;

        if (p == null) return;
            
        var childForm = new FormEditMode();
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.TopLevel = false;
        childForm.AutoScroll = true;
        p.Controls.Add(childForm);

        childForm.WordListName = selectedWordList;
        childForm.LoadWordListIntoGridView();

        childForm.Show();
        this.Close();
    }
    #endregion

    private void NewListBtn_Click(object sender, EventArgs e)
    {
        var formAddNewList = new FormAddNewList();
        formAddNewList.ShowDialog();

        if (!FormAddNewList.ShowEditMode) return;

        Panel parent = this.Parent as Panel;

        if (parent == null) return;

        var childForm = new FormEditMode();
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.TopLevel = false;
        childForm.AutoScroll = true;
        parent.Controls.Add(childForm);
        childForm.WordListName = FormAdd.LoadedWordList.Name;
        childForm.LoadWordListIntoGridView();
        childForm.Show();

        this.Close();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
