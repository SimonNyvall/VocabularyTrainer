using System.Data;
using WordModel;

namespace WinFormsApp1.Forms;

public partial class FormAdd : Form
{

    private static WordList _loadedWordList;

    public static WordList LoadedWordList
    {
        get { return _loadedWordList; }
        set { _loadedWordList = value; }
    }


    public FormAdd()
    {
        InitializeComponent();

        FillDataTable();
    }

    private void FillDataTable()
    {
        var table = new DataTable();

        foreach (var language in _loadedWordList.Languages)
        {
            table.Columns.Add(language, typeof(string));
        }

        table.Rows.Add();

        dataGridView1.DataSource = table;

        ReSizeWidowToGridViewsSize();
    }

    private void ReSizeWidowToGridViewsSize()
    {
        int width = 2;

        width += Size.Width - dataGridView1.Width;

        width += dataGridView1.RowHeadersWidth;

        for (int i = 0; i < dataGridView1.ColumnCount; i++)
        {
            if (dataGridView1.Columns[i].Visible)
            {
                width += dataGridView1.Columns[i].Width;
            }
        }

        Size = new Size(width, Size.Height);
        LabelPanel.Size = new Size(width, LabelPanel.Size.Height);
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
        AddWordsToList();
    }

    private void AddWordsToList()
    {
        var row = dataGridView1.Rows[0];

        string[] cellValues = GetCellValues(row);

        if (cellValues.Length % _loadedWordList.Languages.Length != 0)
        {
            MessageBox.Show("Words not added! Ether a semicolon was used or a call is empty.");
            return;
        }


        _loadedWordList.Add(cellValues);

        _loadedWordList.Save();

        dataGridView1.Columns.Clear();

        FillDataTable();

        AddedWords.Text = $"The Words {string.Join(", ", cellValues)} has been added!";
    }

    private static string[] GetCellValues(DataGridViewRow row)
    {
        var cellValues = new List<string>();

        foreach (DataGridViewCell cell in row.Cells)
        {
            var cellText = cell.FormattedValue.ToString() ?? string.Empty;

            if (cellText == string.Empty) continue; 
            if (cellText.Contains(";")) continue;

            cellValues.Add(cellText.ToLower().TrimStart().TrimEnd());
        }

        return cellValues.ToArray();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void OKBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        AddWordsToList();
    }
}
