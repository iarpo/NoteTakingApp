namespace NoteTakingApp
{
    partial class NoteTaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteTaker));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iarpoAvatar = new System.Windows.Forms.PictureBox();
            this.avatarBlank = new System.Windows.Forms.PictureBox();
            this.recycleBin = new System.Windows.Forms.DataGridView();
            this.recycleBinLabel = new System.Windows.Forms.Label();
            this.savedNotesLabel = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.Button();
            this.deleteRecycleBinButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iarpoAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBin)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.titleBox.Location = new System.Drawing.Point(17, 35);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(538, 29);
            this.titleBox.TabIndex = 1;
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noteBox.Location = new System.Drawing.Point(18, 98);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(538, 510);
            this.noteBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "TITLE:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "TEXT:";
            // 
            // previousNotes
            // 
            this.previousNotes.AllowUserToAddRows = false;
            this.previousNotes.AllowUserToOrderColumns = true;
            this.previousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousNotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(581, 172);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.ReadOnly = true;
            this.previousNotes.Size = new System.Drawing.Size(310, 156);
            this.previousNotes.TabIndex = 5;
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(581, 334);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(152, 44);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(581, 384);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(152, 44);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(739, 384);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(152, 44);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(739, 334);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(152, 44);
            this.newButton.TabIndex = 9;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(655, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save: Ctrl + S";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label4.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(655, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "New: Ctrl + N";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label5.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(655, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Load: Ctrl + O";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iarpoAvatar
            // 
            this.iarpoAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iarpoAvatar.Image = ((System.Drawing.Image)(resources.GetObject("iarpoAvatar.Image")));
            this.iarpoAvatar.Location = new System.Drawing.Point(820, 37);
            this.iarpoAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.iarpoAvatar.Name = "iarpoAvatar";
            this.iarpoAvatar.Size = new System.Drawing.Size(71, 70);
            this.iarpoAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iarpoAvatar.TabIndex = 13;
            this.iarpoAvatar.TabStop = false;
            this.iarpoAvatar.Click += new System.EventHandler(this.iarpoAvatar_Click);
            this.iarpoAvatar.MouseEnter += new System.EventHandler(this.iarpoAvatar_MouseEnter);
            this.iarpoAvatar.MouseLeave += new System.EventHandler(this.iarpoAvatar_MouseLeave);
            // 
            // avatarBlank
            // 
            this.avatarBlank.Image = ((System.Drawing.Image)(resources.GetObject("avatarBlank.Image")));
            this.avatarBlank.Location = new System.Drawing.Point(581, 37);
            this.avatarBlank.Margin = new System.Windows.Forms.Padding(0);
            this.avatarBlank.Name = "avatarBlank";
            this.avatarBlank.Size = new System.Drawing.Size(71, 70);
            this.avatarBlank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBlank.TabIndex = 14;
            this.avatarBlank.TabStop = false;
            this.avatarBlank.Click += new System.EventHandler(this.avatarBlank_Click);
            // 
            // recycleBin
            // 
            this.recycleBin.AllowUserToAddRows = false;
            this.recycleBin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recycleBin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recycleBin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recycleBin.Location = new System.Drawing.Point(581, 464);
            this.recycleBin.Name = "recycleBin";
            this.recycleBin.ReadOnly = true;
            this.recycleBin.Size = new System.Drawing.Size(310, 92);
            this.recycleBin.TabIndex = 15;
            // 
            // recycleBinLabel
            // 
            this.recycleBinLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.recycleBinLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recycleBinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.recycleBinLabel.Location = new System.Drawing.Point(576, 438);
            this.recycleBinLabel.Name = "recycleBinLabel";
            this.recycleBinLabel.Size = new System.Drawing.Size(315, 23);
            this.recycleBinLabel.TabIndex = 16;
            this.recycleBinLabel.Text = "RECYCLE BIN";
            // 
            // savedNotesLabel
            // 
            this.savedNotesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.savedNotesLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.savedNotesLabel.Location = new System.Drawing.Point(576, 123);
            this.savedNotesLabel.Name = "savedNotesLabel";
            this.savedNotesLabel.Size = new System.Drawing.Size(315, 23);
            this.savedNotesLabel.TabIndex = 17;
            this.savedNotesLabel.Text = "SAVED NOTES";
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(581, 562);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(152, 44);
            this.restoreButton.TabIndex = 18;
            this.restoreButton.Text = "RESTORE";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // deleteRecycleBinButton
            // 
            this.deleteRecycleBinButton.Location = new System.Drawing.Point(739, 562);
            this.deleteRecycleBinButton.Name = "deleteRecycleBinButton";
            this.deleteRecycleBinButton.Size = new System.Drawing.Size(152, 44);
            this.deleteRecycleBinButton.TabIndex = 19;
            this.deleteRecycleBinButton.Text = "DELETE";
            this.deleteRecycleBinButton.UseVisualStyleBackColor = true;
            this.deleteRecycleBinButton.Click += new System.EventHandler(this.deleteRecycleBinButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(581, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Copyright Seb Corson 2022";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label7.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(734, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Prev: Ctrl + Up";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label8.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(734, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Next: Ctrl + Down";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(916, 634);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteRecycleBinButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.savedNotesLabel);
            this.Controls.Add(this.recycleBinLabel);
            this.Controls.Add(this.recycleBin);
            this.Controls.Add(this.avatarBlank);
            this.Controls.Add(this.iarpoAvatar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "NoteTaker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteTaker_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iarpoAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox iarpoAvatar;
        private System.Windows.Forms.PictureBox avatarBlank;
        private System.Windows.Forms.DataGridView recycleBin;
        private System.Windows.Forms.Label recycleBinLabel;
        private System.Windows.Forms.Label savedNotesLabel;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button deleteRecycleBinButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

