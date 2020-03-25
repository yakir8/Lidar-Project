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
    public partial class ProgressBarDialog : Form {
        public ProgressBarDialog(string title, string text) {
            InitializeComponent();
            Text = title;
            label1.Text = text;
        }

        public void updateProgressBar(int value) {
            try {
                progressBar.Increment(value);
            } catch (InvalidOperationException) {
                MethodInvoker action = delegate {
                    progressBar.Increment(0);
                };
                progressBar.BeginInvoke(action);
            }
        }
    }
}
