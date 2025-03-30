using System.Data;

namespace UnityInstancer
{
    public partial class InstanceEditor : Form
    {
        public Instance? Target;

        public int Index = -1;

        public bool DoSave = false;

        public InstanceEditor(int targetIndex)
        {
            InitializeComponent();
            Target = InstanceManager.Instances[targetIndex];
            Index = targetIndex;
            DoSave = true;
        }

        public InstanceEditor()
        {
            InitializeComponent();
        }

        private void InstanceEditor_Load(object sender, EventArgs e)
        {
            if (Target != null)
            {
                InstanceName.Text = Target.Name;
                Description.Text = Target.Description;
                foreach (string argument in Target.Arguments)
                {
                    Arguments.Items.Add(argument);
                }
            }
            else
            {
                InstanceName.Text = Guid.NewGuid().ToString();
                Description.Text = "A new instance.";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Target = new Instance()
            {
                Name = InstanceName.Text,
                Description = Description.Text,
                Arguments = Arguments.Items.Cast<string>().ToList()
            };
            if (!DoSave && Target != null)
            {
                InstanceManager.CreateInstance(Target);
            }
            if (DoSave && Target != null)
            {
                InstanceManager.EditInstance(Index, Target);
            }
            Close();
        }

        private void AddArgs_Click(object sender, EventArgs e)
        {
            EnterValue value = new();
            value.lblDescription.Text = "Enter a new argument";
            DialogResult result = value.ShowDialog();
            if (result == DialogResult.OK)
            {
                Arguments.Items.Add(value.txtValue.Text);
            }
        }

        private void Arguments_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditArgs.Enabled = true;
            btnRemoveArgs.Enabled = true;
        }

        private void btnEditArgs_Click(object sender, EventArgs e)
        {
            int index = Arguments.SelectedIndex;
            string? currentValue = Arguments.Items[index].ToString();
            if (string.IsNullOrEmpty(currentValue))
            {
                currentValue = "";
            }
            EnterValue value = new();
            value.lblDescription.Text = "Edit Argument";
            value.txtValue.Text = currentValue;
            DialogResult result = value.ShowDialog();
            if (result == DialogResult.OK)
            {
                Arguments.Items[index] = value.txtValue.Text;
            }
        }

        private void btnRemoveArgs_Click(object sender, EventArgs e)
        {
            Arguments.Items.RemoveAt(Arguments.SelectedIndex);
            if (Arguments.Items.Count == 0)
            {
                btnRemoveArgs.Enabled = false;
                btnEditArgs.Enabled = false;
            }
        }
    }
}
