namespace UnityInstancer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExePath = new TextBox();
            button1 = new Button();
            label1 = new Label();
            Instances = new ListBox();
            NewButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            LaunchButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // ExePath
            // 
            ExePath.BackColor = SystemColors.WindowFrame;
            ExePath.ForeColor = SystemColors.Window;
            ExePath.Location = new Point(12, 40);
            ExePath.Name = "ExePath";
            ExePath.Size = new Size(279, 23);
            ExePath.TabIndex = 0;
            ExePath.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(287, 40);
            button1.Name = "button1";
            button1.Size = new Size(55, 23);
            button1.TabIndex = 1;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Executable Path";
            // 
            // Instances
            // 
            Instances.BackColor = SystemColors.WindowFrame;
            Instances.ForeColor = SystemColors.Window;
            Instances.FormattingEnabled = true;
            Instances.ItemHeight = 15;
            Instances.Location = new Point(12, 117);
            Instances.Name = "Instances";
            Instances.Size = new Size(264, 199);
            Instances.TabIndex = 3;
            Instances.SelectedIndexChanged += Instances_SelectedIndexChanged;
            // 
            // NewButton
            // 
            NewButton.BackColor = SystemColors.Control;
            NewButton.ForeColor = SystemColors.ControlText;
            NewButton.Location = new Point(282, 117);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(57, 23);
            NewButton.TabIndex = 4;
            NewButton.Text = "New...";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.Control;
            EditButton.Enabled = false;
            EditButton.ForeColor = SystemColors.ControlText;
            EditButton.Location = new Point(282, 235);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(57, 23);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.Control;
            DeleteButton.Enabled = false;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(282, 264);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(57, 23);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // LaunchButton
            // 
            LaunchButton.BackColor = SystemColors.Control;
            LaunchButton.Enabled = false;
            LaunchButton.ForeColor = SystemColors.ControlText;
            LaunchButton.Location = new Point(282, 293);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(57, 23);
            LaunchButton.TabIndex = 7;
            LaunchButton.Text = "Launch";
            LaunchButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.Control;
            CloseButton.ForeColor = SystemColors.ControlText;
            CloseButton.Location = new Point(289, 337);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(55, 23);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(356, 372);
            Controls.Add(CloseButton);
            Controls.Add(LaunchButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(NewButton);
            Controls.Add(Instances);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ExePath);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Unity Instancer";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ExePath;
        private Button button1;
        private Label label1;
        private ListBox Instances;
        private Button NewButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button LaunchButton;
        private Button CloseButton;
    }
}
