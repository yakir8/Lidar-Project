using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public partial class Terminal : Form {
        public List<string> data = new List<string>();
        public Terminal() {
            InitializeComponent();
        }

        public void insertData(string input) {
            data.Add(input);
            listBox1.Items.Add(input);
        }
    }
}
