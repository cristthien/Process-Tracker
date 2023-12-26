using DAT;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace trelloclone
{
    public partial class Form1 : Form
    {
        EventHandlers eventHandlers;
       // List<Guna2Button> listOfBtn = new List<Guna2Button>();
        
        
        //public TaoBang TaoBang { get; set; }
        public EventHandlers EventHandlers { get => eventHandlers; set => eventHandlers = value; }
        public Form1()
        {
            InitializeComponent();
            sizeBar.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            EventHandlers = new EventHandlers(this, WorkSpacePanel, myTablePanel, myTableButton, timerMyTable, sizeBar, iconButton, btnFindTable);

            WindowState = FormWindowState.Maximized;

        }

        private void btnAddNewCard_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
