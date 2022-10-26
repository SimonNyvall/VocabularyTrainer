using WordModel;

namespace WinFormsApp1.Forms;
public partial class FormAddNewList : Form
{
    private const string placeHolderStringName = "My New WordList";
    private const string placeHolderStringLanguage = "Language<1>\r\nLanguage<2>";

    public static bool ShowEditMode { get; set; } = false;


    public FormAddNewList()
    {
        InitializeComponent();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        ShowEditMode = false;
        this.Close();
    }

    private void OKBtn_Click(object sender, EventArgs e)
    {
        ShowEditMode = true;
        
        string name = ListNameTextBox.Text;

        string[] languages = LanguagesTextBox.Text.Split("\r\n");

        if (name == placeHolderStringName)
        {
            MessageBox.Show("The list must have name");
            return;
        }

        if (languages.Length < 2 || LanguagesTextBox.Text == placeHolderStringLanguage)
        {
            MessageBox.Show("The list must have at least two languages");
            return;
        }

        CreateWordList(name, languages);
        
        Close();
    }
    private void CreateWordList(string name, string[] languages)
    {
        languages = languages.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

        languages = languages.Select(s => s.ToLower()
            .TrimStart()
            .TrimEnd())
            .ToArray();

        var newWordList = new WordList(name, languages);
        
        LoadInWordListInEditMode(newWordList);           
    }
    private void LoadInWordListInEditMode(WordList newWordList)
    {
        FormAdd.LoadedWordList = newWordList;
        var form = new FormAdd();
        form.ShowDialog();
    }

    #region Text Place Holder For TextBox 

    private void FormAddNewList_Load(object sender, EventArgs e)
    {
        ListNameTextBox.ForeColor = Color.Gray;
        LanguagesTextBox.ForeColor = Color.Gray;

        ListNameTextBox.Text = placeHolderStringName;
        LanguagesTextBox.Text = placeHolderStringLanguage;
    }

    private void ListNameTextBox_Enter(object sender, EventArgs e)
    {
        if (ListNameTextBox.Text != placeHolderStringName) return;

        ListNameTextBox.ForeColor = Color.Black;
        ListNameTextBox.Text = string.Empty;
    }

    private void LanguagesTextBox_Enter(object sender, EventArgs e)
    {
        if (LanguagesTextBox.Text != placeHolderStringLanguage) return;

        LanguagesTextBox.ForeColor = Color.Black;
        LanguagesTextBox.Text = string.Empty;
    }

    private void ListNameTextBox_Leave(object sender, EventArgs e)
    {
        if (ListNameTextBox.Text != string.Empty) return;

        ListNameTextBox.ForeColor = Color.Gray;
        ListNameTextBox.Text = placeHolderStringName;
    }

    private void LanguagesTextBox_Leave(object sender, EventArgs e)
    {
        if (LanguagesTextBox.Text != string.Empty) return;

        LanguagesTextBox.ForeColor = Color.Gray;
        LanguagesTextBox.Text = placeHolderStringLanguage;
    }
    #endregion
}
