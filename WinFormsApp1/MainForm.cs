namespace WinFormsApp1;

public partial class MainForm : Form
{
    public static MainForm instance;
    public Label _menuLabel;

    public Button _EditModeBtn;
    public Button _PracticeBtn;
    public Button _ListWordListBtn;

    public MainForm()
    {
        InitializeComponent();

        instance = this;
        _menuLabel = MenuLabel;

        _EditModeBtn = EditModeBtn;
        _PracticeBtn = PracticeBtn;
        _ListWordListBtn = ListWordListBtn;
    }    

    private void EditModeBtn_Click(object sender, EventArgs e)
    {
        var childForm = new Forms.FormEditMode();
        OpenChildForm(childForm, sender);
        CloseIdleForms(childForm);
    }

    private void PracticeBtn_Click(object sender, EventArgs e)
    {
        var childForm = new Forms.FormPractice();
        OpenChildForm(childForm, sender);
        CloseIdleForms(childForm);
    }

    private void ListWordListBtn_Click(object sender, EventArgs e)
    {
        var childForm = new Forms.FormSelectLanguage();
        OpenChildForm(childForm, sender);
        CloseIdleForms(childForm);
    }

    public void OpenChildForm(Form childForm, object btnSender)
    {
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        this.panelDeskTop.Controls.Add(childForm);
        this.panelDeskTop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
    }

    private void CloseIdleForms(Form currentChildForm)
    {
        for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
        {
            if (Application.OpenForms[i].Name == "Form1") continue;
            if (Application.OpenForms[i].Name == currentChildForm.Name) continue;

            Application.OpenForms[i].Close();
        }
    }   

    public void HighLightCurrentMenuButton(Button activeButton)
    {
        var activeColor = ColorTranslator.FromHtml("#3C5555");
        var idleColor = ColorTranslator.FromHtml("#3C6464");

        _PracticeBtn.BackColor = idleColor;
        _ListWordListBtn.BackColor = idleColor;
        _EditModeBtn.BackColor = idleColor;

        activeButton.BackColor = activeColor;
    }
}