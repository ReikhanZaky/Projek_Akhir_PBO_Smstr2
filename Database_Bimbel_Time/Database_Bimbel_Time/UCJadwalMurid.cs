using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Bimbel_Time
{
    public partial class UCJadwalMurid : UserControl
    {
        private User user;

        public UCJadwalMurid(User u)
        {
            InitializeComponent();
            this.user = u;

            lblNamaLengkap.Text = user.NamaLengkap; // Contoh isi data
            lblUsername.Text = user.Username;
        }




        private void UCJadwalMurid_Load(object sender, EventArgs e)
        {

        }

        

    }
}
