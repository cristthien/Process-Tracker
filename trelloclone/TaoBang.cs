//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
////using DTO;
//using BLL;
//using ui;
//using Guna.UI2.WinForms;

//namespace trelloclone
//{
//    public partial class TaoBang : Form
//    {
//        TableBLL tableBLL = new TableBLL();
//        Table table = new Table();
//        EventHandlers eventHandlers;
//        private List<InsideTable> listOfTableSpace = new List<InsideTable>();
//        public Color tempColorTable;
//        public TaoBang(EventHandlers eventHandlers)
//        {
//            InitializeComponent();
//            this.eventHandlers = eventHandlers;
//        }

//        private void exitButton_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        public void createButton_Click(object sender, EventArgs e)
//        {
//            table.Name_Of_Table = txtNameOfTable.Text;
//            string getName = tableBLL.CheckLogicNameOfTable(table);
//            if (getName == "require_Name")
//            {
//                MessageBox.Show("Tên bảng không được để trống");
//                return;
//            }
//            else
//            {
//                //Table button
//                Guna2Button newButton = new Guna2Button()
//                {
//                    Width = eventHandlers.MyTableButton.Width,
//                    Height = eventHandlers.MyTableButton.Height,
//                    BorderRadius = 0,
//                    BackColor = Color.Transparent,
//                    Text = getName,
//                    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
//                    Tag = eventHandlers.Buttons.Count
//                };
//                if (eventHandlers.Buttons.Count == 0)
//                {
//                    newButton.Location = new Point(eventHandlers.MyTableButton.Location.X, eventHandlers.MyTableButton.Location.Y + eventHandlers.MyTableButton.Height);
//                }
//                else
//                {
//                    int lastIndex = eventHandlers.Buttons.Count - 1;
//                    newButton.Location = new Point(eventHandlers.Buttons[lastIndex].Location.X, eventHandlers.Buttons[lastIndex].Location.Y + eventHandlers.Buttons[lastIndex].Height);
//                }
//                eventHandlers.TableSpace.Controls.Add(newButton);
//                //newButton.Click += eventHandlers.NewButton_Click;
//                //eventHandlers.Buttons.Add(newButton); //Nhet button Table vua tao vao trong mang de quan ly

//                //eventHandlers.CreateFunctionTable(newButton);
//                //this.Hide(); //Tao xong thi form nay se bi an di

//                for (int i = 0; i < EventHandlers.ListOfTable.Count; i++)
//                {
//                    EventHandlers.ListOfTable[i].PnlAllList.Visible = false;
//                }
//                this.Hide();


//                //InsideTable createdTable = getTable(sender, e);
//                //listOfTableSpace.Add(createdTable);
//            }

//        }

//        //private InsideTable getTable(object sender, EventArgs e)
//        //{
//        //    //InsideTable Table1 = new InsideTable(eventHandlers.MainForm, eventHandlers.WorkSpace, eventHandlers.TableSpace);

//        //    //return Table1;
//        //    return new InsideTable();
//        //}

//        private void blueButton_Click(object sender, EventArgs e)
//        {
//            Guna2Button btn = (Guna2Button)sender;
//            tempColorTable = btn.FillColor;
//        }

//        private void purpleButton_Click(object sender, EventArgs e)
//        {
//            Guna2Button btn = (Guna2Button)sender;
//            tempColorTable = btn.FillColor;
//        }

//        private void pinkButton_Click(object sender, EventArgs e)
//        {
//            Guna2Button btn = (Guna2Button)sender;
//            tempColorTable = btn.FillColor;
//        }

//        private void redButton_Click(object sender, EventArgs e)
//        {
//            Guna2Button btn = (Guna2Button)sender;
//            tempColorTable = btn.FillColor;
//        }

//        private void headLabel_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBoxPanel_Paint(object sender, PaintEventArgs e)
//        {

//        }
//    }
//}
