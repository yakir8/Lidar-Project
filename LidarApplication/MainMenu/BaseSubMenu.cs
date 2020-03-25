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
#if DEBUG
    public partial class BaseSubMenu : Form
#else
  public abstract class BaseSubMenu : Form
#endif
  {
#if DEBUG
        public virtual void LoadUserConfig() {
            throw new NotImplementedException("This method must be implemented!!!");
        }
        public virtual void SaveFormData() {
            throw new NotImplementedException("This method must be implemented!!!");
        }
#else
    public abstract void LoadUserConfig();
    public abstract void SaveFormData();
#endif
    }
}
