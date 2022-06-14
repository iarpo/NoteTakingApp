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
    // TODO improve UI of dataSource - nice fonts, don't show cells, show a nice editing indicator
    // TODO Write files to the containing folder so they persist between sessions
    
    public partial class NoteTaker : Form
    {

        DataTable notes = new DataTable();
        DataTable deletedNotes = new DataTable();

        bool editing = false;
        bool newDoc = true;

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            notes.Columns.Add("Title");
            notes.Columns.Add("Text");
            deletedNotes.Columns.Add("Title");
            deletedNotes.Columns.Add("Text");

            previousNotes.DataSource = notes;
            recycleBin.DataSource = deletedNotes;

        }

        
        // Button Click Events
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (notes.Rows.Count > 0)
            {
                titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (notes.Rows.Count > 0)
                {
                    deletedNotes.Rows.Add(
                    notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"],
                    notes.Rows[previousNotes.CurrentCell.RowIndex]["Text"]);
                
                    notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
                    SetLastDocAsActiveDoc(sender, e);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Not a valid note: {ex}");
                throw;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (newDoc && !editing)
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
                editing = true;
                newDoc = false;
                SetLastDocAsActiveDoc(sender, e);
            }
            else if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Text"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
                editing = true;
            }
        }

        private void SetLastDocAsActiveDoc(object sender, EventArgs e)
        {
            if (notes.Rows.Count == 0)
                newButton_Click (sender, e);
            else if (notes.Rows.Count > 1)
                previousNotes.CurrentCell = previousNotes.Rows[notes.Rows.Count - 1].Cells[0];
            else
                previousNotes.CurrentCell = previousNotes.Rows[0].Cells[0];
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
            newDoc = true;
            titleBox.Focus();
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.ToString() != String.Empty)
                loadButton_Click(sender, e);
        }

        private void deleteRecycleBinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (deletedNotes.Rows.Count > 0)
                {
                    deletedNotes.Rows[recycleBin.CurrentCell.RowIndex].Delete();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Not a valid note: {ex}");
                throw;
            }
        }


        // Keyboard Events
        private void NoteTaker_KeyDown(object sender, KeyEventArgs e)
        {
            // new
            if (ControlAndLetterKeyboardShortcutCheck(sender, e, Keys.N))
            {
                newButton_Click(sender, e);
                HandleSystemKeyPress(e);
            }

            // save
            if (ControlAndLetterKeyboardShortcutCheck(sender, e, Keys.S))
            {
                saveButton_Click(sender, e);
                HandleSystemKeyPress(e);
            }
            // load
            if (ControlAndLetterKeyboardShortcutCheck(sender, e, Keys.O))
            {
                loadButton_Click(sender, e);
                HandleSystemKeyPress(e);
            }

            // load previous note
            if (ControlAndLetterKeyboardShortcutCheck(sender, e, Keys.Up))
            {
                LoadNextOrPreviousNote(sender, e, false);
                HandleSystemKeyPress(e);
            }

            // load next note
            if (ControlAndLetterKeyboardShortcutCheck(sender, e, Keys.Down))
            {
                LoadNextOrPreviousNote(sender, e, true);
                HandleSystemKeyPress(e);
            }

        }

        private void LoadNextOrPreviousNote(object sender, KeyEventArgs e, bool shouldBeNextNote)
        {
            if (notes.Rows.Count > 0)
            {
                int currentNoteIndex = CurrentNoteIndex();
                

                // get current index
                if (!shouldBeNextNote && CurrentNoteIndex() == 0)
                {
                    currentNoteIndex = notes.Rows.Count;
                }
                else if ( shouldBeNextNote && (currentNoteIndex+2) > notes.Rows.Count)
                {
                    currentNoteIndex = -1;
                }

                // load note
                previousNotes.CurrentCell = shouldBeNextNote ? 
                    previousNotes.Rows[currentNoteIndex + 1].Cells[0] : 
                    previousNotes.Rows[currentNoteIndex - 1].Cells[0];

            }

            loadButton_Click(sender, e);
        }

        private int CurrentNoteIndex()
        {
            return previousNotes.CurrentCell.RowIndex;
        }

        private static void HandleSystemKeyPress(KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private bool ControlAndLetterKeyboardShortcutCheck(object sender, KeyEventArgs e, Keys letter)
        {
            if (e.Control == true && e.KeyCode == letter)
                return true;
            else
                return false;
        }

        private void avatarBlank_Click(object sender, EventArgs e)
        {
            // TO DO let user upload their own avatar
        }


        // Mouse Events
        private void iarpoAvatar_MouseEnter(object sender, EventArgs e)
        {
            iarpoAvatar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void iarpoAvatar_MouseLeave(object sender, EventArgs e)
        {
            iarpoAvatar.BorderStyle = BorderStyle.None;
        }

        private void iarpoAvatar_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://github.com/iarpo/NoteTakingApp";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (deletedNotes.Rows.Count > 0)
            {
                notes.Rows.Add(
                deletedNotes.Rows[recycleBin.CurrentCell.RowIndex]["Title"],
                deletedNotes.Rows[recycleBin.CurrentCell.RowIndex]["Text"]);

                deletedNotes.Rows[recycleBin.CurrentCell.RowIndex].Delete();
                SetLastDocAsActiveDoc(sender, e);
                loadButton_Click(sender, e);
            }
        }
    }
}
