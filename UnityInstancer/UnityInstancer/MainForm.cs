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
            string dir = Path.Combine(Program.GamePath);
            foreach (string file in Directory.GetFiles(dir))
            {
                if (Directory.Exists(Path.GetFileNameWithoutExtension(file) + "_Data"))
                {
                    //Unity game?
                    this.ExePath.Text = file;
                }
            }

            foreach (Instance instance in Program.Instances)
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
            Instance instance = Program.Instances[Instances.SelectedIndex];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? file = Utility.OpenFileDialog(Program.TargetDir, "Exe files (*.exe)|*.exe");
            if(file == null)
            {
                return;
            }
            string? dir = Path.GetDirectoryName(file);
            if(dir == null)
            {
                return;
            }
            
            foreach (Instance instance in Program.Instances)
            {
                Instances.Items.Add(instance.Name);
            }
        }
    }
}
