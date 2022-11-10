using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace BasedeDatosconFirebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret= "bDmLAoS4EBlwFzJfzwwvAfGwPaXuR95MPHMG5Dcw",
            BasePath= "https://bdcsharp-64849-default-rtdb.firebaseio.com/"//poner link de firebase
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
