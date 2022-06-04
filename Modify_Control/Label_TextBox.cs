using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modify_Control
{
    public partial class Label_TextBox : UserControl
    {
        public Label_TextBox()
        {
            InitializeComponent();
        }

        public void setName(string labelName,string textboxvalue)
        {
            labelControl1.Text = labelName;
            textEdit1.Text = textboxvalue;
        }
    }
}
