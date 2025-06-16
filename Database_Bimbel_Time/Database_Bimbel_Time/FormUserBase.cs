using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Database_Bimbel_Time
{
    public abstract class FormUserBase : Form
    {
        protected User user;

        public FormUserBase(User u)
        {
            this.user = u;
        }

        // Buat abstract property panelMain
        protected abstract Panel panelMain { get; }

        protected void TampilkanKonten(UserControl uc)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}

