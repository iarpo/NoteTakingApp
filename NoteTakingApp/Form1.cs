using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {

        DataTable notes = new DataTable();
        DataTable deletedNotes = new DataTable();
        bool editing = false;

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Text");

            previousNotes.DataSource = notes;
            // TODO add a recylce bin (another component with a different data source. Transfer deleted items to recycle bin
            // TODO improve UI of dataSource - nice fonts, don't show cells, show a nice editing indicator
            // TODO Write files to the containing folder so they persist between sessions

            // BUGFIX - App crashes when double clicking empty row of dataTable.
        }

        
        private void loadButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Not a valid note: {ex}");
                throw;
            }

            // TODO: cache deleted notes within this session
            // TODO: show deleted notes in a deleted items area
            // TODO: give the option to restore deleted notes
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            { 
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Text"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.ToString() == String.Empty)
                loadButton_Click(sender, e);

            // BUG: App crashes when trying to load blank column in dataTable
            // if ( string.IsNullOrEmpty(notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"].ToString()) )
        }
    }
}
