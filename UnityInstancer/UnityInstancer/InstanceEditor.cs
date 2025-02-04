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
        public Instance? Target;

        public int Index = -1;

        public bool DoSave = false;

        public InstanceEditor(int targetIndex)
        {
            InitializeComponent();
            Target = InstanceManager.Instances[targetIndex];
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
                Description.Text = Target.Name;
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
            if(!DoSave && Target != null)
            {
                InstanceManager.CreateInstance(Target);
            }
            Close();
        }
    }
}
