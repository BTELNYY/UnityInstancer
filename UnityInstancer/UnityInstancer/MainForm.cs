namespace UnityInstancer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string dir = Path.Combine(InstanceManager.GamePath);
            foreach (string file in Directory.GetFiles(dir))
            {
                if (Directory.Exists(Path.GetFileNameWithoutExtension(file) + "_Data"))
                {
                    //Unity game?
                    this.ExePath.Text = file;
                }
            }

            foreach (Instance instance in InstanceManager.Instances)
            {
                Instances.Items.Add(instance.Name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Instances_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Instances.SelectedIndex == -1)
            {
                EditButton.Enabled = false;
                LaunchButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                EditButton.Enabled = true;
                LaunchButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Instances.SelectedIndex == -1)
            {
                return;
            }
            Instance instance = InstanceManager.Instances[Instances.SelectedIndex];
            InstanceEditor editor = new InstanceEditor(Instances.SelectedIndex);
            editor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? file = Utility.OpenFileDialog(InstanceManager.TargetDir, "Exe files (*.exe)|*.exe");
            if (file == null)
            {
                return;
            }
            string? dir = Path.GetDirectoryName(file);
            if (dir == null)
            {
                return;
            }
            bool found = false;
            foreach (string subFile in Directory.GetFiles(dir))
            {
                if (Directory.Exists(Path.GetFileNameWithoutExtension(subFile) + "_Data"))
                {
                    //Unity game?
                    this.ExePath.Text = subFile;
                    found = true;
                }
            }
            if (!found)
            {
                Utility.ShowMessageBox("Couldn't find a unity game within that folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InstanceManager.LoadInstances();


            foreach (Instance instance in InstanceManager.Instances)
            {
                Instances.Items.Add(instance.Name);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            InstanceEditor editor = new InstanceEditor();
            editor.ShowDialog();
            InstanceManager.LoadInstances();
            Invalidate();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            InstanceManager.Delete(Instances.SelectedIndex);
        }
    }
}
