using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
#if DEBUG
    public partial class BaseTerminal : Form
#else
  public abstract class BaseTerminal : Form
#endif
  {
#if DEBUG
        public virtual void insertData(string data) {
            throw new NotImplementedException("This method must be implemented!!!");
        }
#else
    public abstract void insertData(string data);
#endif
    }
}
