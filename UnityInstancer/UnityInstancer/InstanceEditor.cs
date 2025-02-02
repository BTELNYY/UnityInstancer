using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityInstancer
{
    public partial class InstanceEditor : Form
    {
        Instance target;

        int index;

        public InstanceEditor(int targetIndex)
        {
            InitializeComponent();
            target = Program.Instances[targetIndex];
        }

        public InstanceEditor()
        {
            InitializeComponent();
            target = new Instance();
        }

        private void InstanceEditor_Load(object sender, EventArgs e)
        {
            Name.Text = target.Name;
            Description.Text = target.Name;
            foreach(string argument in  target.Arguments)
            {
                Arguments.Items.Add(argument);
            }
        }
    }
}
