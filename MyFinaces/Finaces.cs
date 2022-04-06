using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinaces
{
    public partial class Finaces : Form
    {
        public Finaces()
        {
            InitializeComponent();
        }
        private int userID;
        public void SetUserDetails(string firstname, string lastname, int ID)
        {
            Text = $"You are viewing the finaces for {firstname} {lastname}";
            userID = ID;
        }

        public void SetUserDetails(string firstname, string lastname, int ID)
        {
            Text = $"You are viewing the finaces for {firstname} {lastname}";
            userID = ID;
        }



    }
}
