namespace PriorityPlanner
{
    partial class AddTaskWindow
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
            label1 = new Label();
            entTitle = new TextBox();
            label2 = new Label();
            txtDescription = new RichTextBox();
            label3 = new Label();
            cmbPriority = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // entTitle
            // 
            entTitle.Location = new Point(78, 6);
            entTitle.Name = "entTitle";
            entTitle.Size = new Size(433, 23);
            entTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 45);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(78, 45);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(433, 124);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 191);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbPriority.Location = new Point(78, 188);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(61, 23);
            cmbPriority.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(436, 233);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(355, 233);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // AddTaskWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 268);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cmbPriority);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(entTitle);
            Controls.Add(label1);
            Name = "AddTaskWindow";
            Text = "Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox entTitle;
        private Label label2;
        private RichTextBox txtDescription;
        private Label label3;
        private ComboBox cmbPriority;
        private Button btnCancel;
        private Button btnSave;
    }
}