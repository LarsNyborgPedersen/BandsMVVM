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
            this.bandListBox = new System.Windows.Forms.ListBox();
            this.personListBox = new System.Windows.Forms.ListBox();
            this.bandNameTextBox = new System.Windows.Forms.TextBox();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.addBandButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();

            // bandListBox
            this.bandListBox.Location = new System.Drawing.Point(13, 13);
            this.bandListBox.Size = new System.Drawing.Size(120, 95);
            this.Controls.Add(this.bandListBox);

            // personListBox
            this.personListBox.Location = new System.Drawing.Point(150, 13);
            this.personListBox.Size = new System.Drawing.Size(120, 95);
            this.Controls.Add(this.personListBox);

            // bandNameTextBox
            this.bandNameTextBox.Location = new System.Drawing.Point(13, 115);
            this.Controls.Add(this.bandNameTextBox);

            // personNameTextBox
            this.personNameTextBox.Location = new System.Drawing.Point(150, 115);
            this.Controls.Add(this.personNameTextBox);

            // addBandButton
            this.addBandButton.Location = new System.Drawing.Point(13, 145);
            this.addBandButton.Text = "Add Band";
            this.addBandButton.Click += new System.EventHandler(this.addBandButton_Click);
            this.Controls.Add(this.addBandButton);

            // addPersonButton
            this.addPersonButton.Location = new System.Drawing.Point(150, 145);
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            this.Controls.Add(this.addPersonButton);

            // MainForm
            this.ClientSize = new System.Drawing.Size(300, 200); // adjust as needed
            this.Name = "MainForm";
            this.Text = "Band Management";
        }

        #endregion

        private System.Windows.Forms.ListBox bandListBox;
        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.TextBox bandNameTextBox;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.Button addBandButton;
        private System.Windows.Forms.Button addPersonButton;
    }
}
