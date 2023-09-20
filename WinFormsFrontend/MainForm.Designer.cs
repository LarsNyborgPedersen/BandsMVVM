namespace WinFormsFrontend
{
    partial class MainForm
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
            bandListBox = new ListBox();
            personListBox = new ListBox();
            TbBandName = new TextBox();
            personNameTextBox = new TextBox();
            addBandButton = new Button();
            addPersonButton = new Button();
            SuspendLayout();
            // 
            // bandListBox
            // 
            bandListBox.ItemHeight = 20;
            bandListBox.Location = new Point(13, 13);
            bandListBox.Name = "bandListBox";
            bandListBox.Size = new Size(120, 84);
            bandListBox.TabIndex = 0;
            // 
            // personListBox
            // 
            personListBox.ItemHeight = 20;
            personListBox.Location = new Point(150, 13);
            personListBox.Name = "personListBox";
            personListBox.Size = new Size(120, 84);
            personListBox.TabIndex = 1;
            // 
            // TbBandName
            // 
            TbBandName.Location = new Point(13, 115);
            TbBandName.Name = "TbBandName";
            TbBandName.Size = new Size(100, 27);
            TbBandName.TabIndex = 2;
            // 
            // personNameTextBox
            // 
            personNameTextBox.Location = new Point(150, 115);
            personNameTextBox.Name = "personNameTextBox";
            personNameTextBox.Size = new Size(100, 27);
            personNameTextBox.TabIndex = 3;
            // 
            // addBandButton
            // 
            addBandButton.Location = new Point(13, 145);
            addBandButton.Name = "addBandButton";
            addBandButton.Size = new Size(75, 23);
            addBandButton.TabIndex = 4;
            addBandButton.Text = "Add Band";
            addBandButton.Click += addBandButton_Click;
            // 
            // addPersonButton
            // 
            addPersonButton.Location = new Point(150, 145);
            addPersonButton.Name = "addPersonButton";
            addPersonButton.Size = new Size(75, 23);
            addPersonButton.TabIndex = 5;
            addPersonButton.Text = "Add Person";
            addPersonButton.Click += addPersonButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(300, 200);
            Controls.Add(bandListBox);
            Controls.Add(personListBox);
            Controls.Add(TbBandName);
            Controls.Add(personNameTextBox);
            Controls.Add(addBandButton);
            Controls.Add(addPersonButton);
            Name = "MainForm";
            Text = "Band Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox bandListBox;
        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.TextBox TbBandName;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.Button addBandButton;
        private System.Windows.Forms.Button addPersonButton;
    }
}
