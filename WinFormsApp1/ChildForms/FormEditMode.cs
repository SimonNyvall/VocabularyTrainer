using System.Data;
using System.Reflection.Metadata.Ecma335;
using VocabularyTrainer;
using WordModel;

namespace WinFormsApp1.Forms;

public partial class FormEditMode : Form
{
    public WordList LoadedWordList;

    public string WordListName { get; set; }

    public FormEditMode()
    {
        InitializeComponent();

        MainForm.instance._menuLabel.Text = "Edit Mode";

        MainForm.instance.HighLightCurrentMenuButton(MainForm.instance._EditModeBtn);

        FillComboBox();
    }

    private void FillComboBox()
    {
        string[] wl = WordList.GetLists();

        foreach (var wordList in wl)
        {
            WordListComboBox.Items.Add(wordList);
        }
    }

    private void WordListComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        WordListName = WordListComboBox.SelectedItem.ToString() ?? string.Empty;
        LoadWordListIntoGridView();
    }

    #region Print Columns and rows to datagridview

    public void LoadWordListIntoGridView()
    {
        DataTable table = new DataTable();

        LoadedWordList = WordList.LoadList(WordListName);

        table = AddLanguageColumns(table);
        table = AddWordRows(table);

        WordListDataGridView.DataSource = table;

        WordListComboBox.Text = WordListName;
    }

    private DataTable AddLanguageColumns(DataTable table)
    {
        foreach (var language in LoadedWordList.Languages)
        {
            table.Columns.Add(language.ToTitel(), typeof(string));
        }

        return table;
    }

    private DataTable AddWordRows(DataTable table)
    {
        void ShowTranslation(string[] input)
        {
            List<string> rowWords = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                rowWords.Add(input[i].ToTitel());

                if (rowWords.Count != LoadedWordList.Languages.Length || i == 0) continue;
                if (rowWords == null) continue;

                table.Rows.Add(rowWords.ToArray());
                rowWords.Clear();
            }
        }

        LoadedWordList.List(0, ShowTranslation);

        return table;
    }
   
    #endregion

    private void AddWordBtn_Click(object sender, EventArgs e)
    {
        if (LoadedWordList == null)
        {
            MessageBox.Show("You must selected a language first.");
            return;
        }

        FormAdd.LoadedWordList = LoadedWordList;
        var form = new FormAdd();
        form.ShowDialog();

        LoadWordListIntoGridView();
    }

    #region Remove word

    private void RemoveWordBtn_Click(object sender, EventArgs e)
    {
        string removeWord = GetSelectedWords();
        int languageIndex = GetIndexOfCellColumn();

        LoadedWordList.Remove(languageIndex, removeWord);

        LoadWordListIntoGridView();
    }
    private string GetSelectedWords()
    {
        DataGridViewSelectedCellCollection selectedCells = WordListDataGridView.SelectedCells;

        var cellValue = selectedCells[0].FormattedValue;
        var cellValueText = cellValue.ToString() ?? string.Empty;
        return cellValueText.ToLower();
    }
    private int GetIndexOfCellColumn()
    {
        return WordListDataGridView.SelectedCells[0].ColumnIndex;
    }

    #endregion

    private void PracticeBtn_Click(object sender, EventArgs e)
    {
        const int comboBoxEmpty = -1;

        if (WordListComboBox.SelectedIndex == comboBoxEmpty)
        {
            MessageBox.Show("You must select a word list first");
            return;
        }

        if (this.Parent is not Panel p) return;

        var myForm = new FormPractice();
        myForm.FormBorderStyle = FormBorderStyle.None;
        myForm.TopLevel = false;
        myForm.AutoScroll = true;
        p.Controls.Add(myForm);
        myForm.Show();
        myForm.StartPractice(WordListName);
        this.Close();
    }

    private void WordListDataGridView_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right) return;

        var hti = WordListDataGridView.HitTest(e.X, e.Y);

        if (hti.RowIndex < 0) return;

        WordListDataGridView.ClearSelection();
        WordListDataGridView.CurrentCell = WordListDataGridView[hti.ColumnIndex, hti.RowIndex];
    }
}
