namespace UnityInstancer
{
    partial class InstanceEditor
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
            InstanceName = new TextBox();
            Description = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Arguments = new ListBox();
            label3 = new Label();
            AddArgs = new Button();
            RemoveArgs = new Button();
            EditArgs = new Button();
            Save = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // InstanceName
            // 
            InstanceName.BackColor = SystemColors.WindowFrame;
            InstanceName.ForeColor = SystemColors.Window;
            InstanceName.Location = new Point(12, 32);
            InstanceName.Name = "InstanceName";
            InstanceName.Size = new Size(357, 23);
            InstanceName.TabIndex = 0;
            // 
            // Description
            // 
            Description.BackColor = SystemColors.WindowFrame;
            Description.ForeColor = SystemColors.Window;
            Description.Location = new Point(12, 99);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Size = new Size(357, 93);
            Description.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Instance Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // Arguments
            // 
            Arguments.BackColor = SystemColors.WindowFrame;
            Arguments.ForeColor = SystemColors.Window;
            Arguments.FormattingEnabled = true;
            Arguments.ItemHeight = 15;
            Arguments.Location = new Point(12, 230);
            Arguments.Name = "Arguments";
            Arguments.Size = new Size(276, 139);
            Arguments.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 212);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Arguments";
            // 
            // AddArgs
            // 
            AddArgs.ForeColor = SystemColors.ControlText;
            AddArgs.Location = new Point(294, 230);
            AddArgs.Name = "AddArgs";
            AddArgs.Size = new Size(75, 23);
            AddArgs.TabIndex = 6;
            AddArgs.Text = "Add";
            AddArgs.UseVisualStyleBackColor = true;
            // 
            // RemoveArgs
            // 
            RemoveArgs.ForeColor = SystemColors.ControlText;
            RemoveArgs.Location = new Point(294, 288);
            RemoveArgs.Name = "RemoveArgs";
            RemoveArgs.Size = new Size(75, 23);
            RemoveArgs.TabIndex = 7;
            RemoveArgs.Text = "Remove";
            RemoveArgs.UseVisualStyleBackColor = true;
            // 
            // EditArgs
            // 
            EditArgs.ForeColor = SystemColors.ControlText;
            EditArgs.Location = new Point(294, 259);
            EditArgs.Name = "EditArgs";
            EditArgs.Size = new Size(75, 23);
            EditArgs.TabIndex = 8;
            EditArgs.Text = "Edit";
            EditArgs.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.ForeColor = SystemColors.ControlText;
            Save.Location = new Point(305, 385);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 9;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // CancelButton
            // 
            CancelButton.ForeColor = SystemColors.ControlText;
            CancelButton.Location = new Point(224, 385);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // InstanceEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(392, 420);
            Controls.Add(CancelButton);
            Controls.Add(Save);
            Controls.Add(EditArgs);
            Controls.Add(RemoveArgs);
            Controls.Add(AddArgs);
            Controls.Add(label3);
            Controls.Add(Arguments);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Description);
            Controls.Add(InstanceName);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "InstanceEditor";
            Text = "Instance Editor";
            Load += InstanceEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InstanceName;
        private TextBox Description;
        private Label label1;
        private Label label2;
        private ListBox Arguments;
        private Label label3;
        private Button AddArgs;
        private Button RemoveArgs;
        private Button EditArgs;
        private Button Save;
        private Button CancelButton;
    }
}