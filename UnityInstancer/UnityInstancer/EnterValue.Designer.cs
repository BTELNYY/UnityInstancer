namespace UnityInstancer
{
    partial class EnterValue
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
            btnSave = new Button();
            btnCancel = new Button();
            txtValue = new TextBox();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(230, 63);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(149, 63);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(12, 30);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(293, 23);
            txtValue.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 9);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(74, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Enter a value";
            // 
            // EnterValue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(317, 98);
            ControlBox = false;
            Controls.Add(lblDescription);
            Controls.Add(txtValue);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            ForeColor = SystemColors.ControlLightLight;
            MinimizeBox = false;
            Name = "EnterValue";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Enter Value";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        public TextBox txtValue;
        public Label lblDescription;
    }
}