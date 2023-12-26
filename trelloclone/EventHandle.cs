using DAT;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ui;
using DTO;
using Microsoft.EntityFrameworkCore;


namespace trelloclone
{
    public class EventHandlers
    {
        private Form1 mainForm;

        //WorkSpace
        private Panel workSpace;
        //TableSpace
        private Panel tableSpace;
        private List<Guna2Button> buttons;
        private List<RJButton> otpBtn;
        private Guna2Button myTableButton;
        private Guna2Panel textBoxPanel;
        //find board
        private Guna2Button findTableBtn;
        private Guna2Button findBtn = new Guna2Button();
        Guna2TextBox text = new Guna2TextBox();
        private Guna2Panel findTablePnl;
        //private Guna2Panel findID;
        private string textBoxContent = "";
        //MenuSpace
        private Timer sideBarTimer;
        private FlowLayoutPanel sideBar;
        private Guna2Button iconButton;
        bool sidebarExpand = true;
        //listOfDataTable
        static List<InsideTable> listOfTable = new List<InsideTable>();

        //database
        DBController dbctrl = new DBController();
        UserDAT userDAT = new UserDAT();
        ViewerDAT viewerDAT = new ViewerDAT();
        ListCardDAT listCardDAT = new ListCardDAT();
        CardDAT cardDAT = new CardDAT();

        //save board ID
        List<int> listOfBoardID = new List<int>();
        // check for retrieve done or not yet
        bool retrieveProcess = true;


        public Panel WorkSpace { get => workSpace; set => workSpace = value; }
        public Guna2Button MyTableButton { get => myTableButton; set => myTableButton = value; }
        public List<Guna2Button> Buttons { get => buttons; set => buttons = value; }
        public Panel TableSpace { get => tableSpace; set => tableSpace = value; }
        public List<RJButton> OtpBtn { get => otpBtn; set => otpBtn = value; }
        internal static List<InsideTable> ListOfTable { get => listOfTable; set => listOfTable = value; }
        public Guna2Button FindTableBtn { get => findTableBtn; set => findTableBtn = value; }
        public Guna2Panel FindTablePnl { get => findTablePnl; set => findTablePnl = value; }
        public DBController Dbctrl { get => dbctrl; set => dbctrl = value; }
        public UserDAT UserDAT { get => userDAT; set => userDAT = value; }
        public ViewerDAT ViewerDAT { get => viewerDAT; set => viewerDAT = value; }
        public ListCardDAT ListCardDAT { get => listCardDAT; set => listCardDAT = value; }
        public CardDAT CardDAT { get => cardDAT; set => cardDAT = value; }


        //public Guna2Panel FindID { get => findID; set => findID = value; }

        public EventHandlers(Form1 form, Panel WorkSpace, Panel TableSpace, Guna2Button myTableButton, Timer timer, FlowLayoutPanel sideBar, Guna2Button iconButton, Guna2Button btnFindTable)
        {
            this.mainForm = form;
            //WorkSpace
            this.workSpace = WorkSpace;

            //TableSpace
            this.tableSpace = TableSpace;
            this.myTableButton = myTableButton;
            this.myTableButton.Click += myTableButton_Click;
            this.FindTableBtn = btnFindTable;
            this.FindTableBtn.Click += FindTableBtn_Click;
            
            Buttons = new List<Guna2Button>();
            OtpBtn = new List<RJButton>();
            //MenuSpace
            this.sideBarTimer = timer;
            this.sideBarTimer.Interval = 1;
            this.sideBarTimer.Tick += Timer_Tick;
            this.sideBar = sideBar;
            this.iconButton = iconButton;
            this.iconButton.Click += IconButton_Click;

            form.Load += Form_Load;
            form.FormClosed += Form_FormClosed;
        }

        private void FindTableBtn_Click(object sender, EventArgs e)
        {
            findTablePnl = new Guna2Panel()
            {
                Size = new Size(220, 280),
                Location = new Point(180, 5),
                BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/myTablePanel.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                BorderRadius = 5,
            };
            WorkSpace.Controls.Add(findTablePnl);
            findTablePnl.BringToFront();

            Label headLabel = new Label()
            {
                Text = "Tìm bảng",
                Width = Const.panelTextBoxWidth,
                Location = new Point(55, 18),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Size = new Size(106, 25)
            };

            text = new Guna2TextBox()
            {
                Size = new Size(180, 30),
                Location = new Point(24, textBoxPanel.Location.Y + 85),
                PlaceholderText = "Nhập ID bảng",
                BorderThickness = 1,
                ForeColor = Color.Black
            };

            findBtn = new Guna2Button()
            {
                //BackColor = Color.MidnightBlue,
                Location = new Point(20, 210),
                Text = "Tìm bảng",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Size = new Size(180, 30),
                FillColor = Color.FromArgb(94, 148, 255),
                ForeColor = Color.White,
                BorderRadius = 5,
                TextAlign = HorizontalAlignment.Center,
            };
            Guna2Button closeBtn1 = new Guna2Button()
            {
                Size = new Size(20, 20),
                Location = new Point(185, 18),
                Image = Image.FromFile(Application.StartupPath + "/Resources/tab_close.png"),
                ImageAlign = HorizontalAlignment.Center,
                BackColor = Color.Transparent,
                FillColor = Color.WhiteSmoke,

            };
            //newBtn.Click += CreateTable_Click;
            closeBtn1.Click += CloseBtn1_Click;
            findTablePnl.Controls.Add(headLabel);
            //textBoxPanel.Controls.Add(titleLabel);
            findTablePnl.Controls.Add(text);
            //textBoxPanel.Controls.Add(noteLineLabel);
            findTablePnl.Controls.Add(findBtn);
            findTablePnl.Controls.Add(closeBtn1);

            findBtn.Click += FindBtn_Click;

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (text.Text == "")
                MessageBox.Show("ID bảng không được để trống!");
            else
            {
                try 
                {
                    int idBoard = int.Parse(text.Text);
                    /////
                    ViewerDAT viewerDAT = new ViewerDAT();
                    bool kq = viewerDAT.InsertViewer(Login.userID, idBoard);
                    if(kq)
                    {
                        MessageBox.Show($"Thêm bảng thành công!");
                        retrieveProcess = true;
                        retrieveData(sender, e);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm bảng không thành công!");
                    }
                }
                catch 
                {
                    MessageBox.Show("ID bảng thuộc kiểu số nguyên!");
                }
            }
        }

        private void CloseBtn1_Click(object sender, EventArgs e)
        {
            WorkSpace.Controls.Remove(findTablePnl);
            findTablePnl.Visible = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            retrieveData(sender, e);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            string filePath1 = "table.txt";
            string filePath2 = "data.txt";
            using (StreamWriter writer = new StreamWriter(filePath1))
            {
                foreach (var table in ListOfTable)
                {
                    int indexTable = ListOfTable.IndexOf(table);
                    writer.WriteLine($"{table.ToString()}");
                }
            }
            using (StreamWriter writer = new StreamWriter(filePath2))
            {
                foreach (var table in ListOfTable)
                {
                    int indexTable = ListOfTable.IndexOf(table);
                    foreach (list danhSach in table.ListOfDanhSach)
                    {
                        int indexDanhSach = table.ListOfDanhSach.IndexOf(danhSach);
                        foreach (AppData dataToWrite in danhSach.ListOfData)
                        {
                            int indexCard = danhSach.ListOfData.IndexOf(dataToWrite);
                            dataToWrite.IndexTable = indexTable;
                            dataToWrite.IndexDanhSach = indexDanhSach;
                            dataToWrite.IndexCard = indexCard;
                            writer.WriteLine($"{dataToWrite.ToString()}");
                        }
                    }
                }
            }
        }

        private void IconButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Set the Minimum and maxim
            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    reSizeTableSpace(false);
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    reSizeTableSpace(true);
                    sideBarTimer.Stop();
                }
            }
        }

        public void myTableButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            CreateTextBox(btn, "");
        }

        private void CreateTextBox(RJButton btn, string oldTitle)
        {
            textBoxPanel = new Guna2Panel()
            {
                Size = new Size(220, 280),
                Location = new Point(180, 5),
                BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/myTablePanel.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
                BorderRadius = 5,
            };
            WorkSpace.Controls.Add(textBoxPanel);
            textBoxPanel.BringToFront();

            Label headLabel = new Label()
            {
                Text = "Tạo Bảng",
                Width = Const.panelTextBoxWidth,
                Location = new Point(55, 18),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Size = new Size(106, 25)
            };

            Label titleLabel = new Label()
            {
                Text = "Tiêu đề bảng",
                Width = Const.panelTextBoxWidth,
                Font = new Font("Microsoft Sans Serif", 9),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(20, textBoxPanel.Location.Y + 60),
            };

            TextBox text = new TextBox()
            {
                Size = new Size(180, 150),
                Location = new Point(24, textBoxPanel.Location.Y + 85),
            };

            //new code
            if (oldTitle == "")
                text.TextChanged += Text_TextChanged;
            else
            {
                text.TextChanged += Text_TextChanged;
                text.Text = oldTitle;
            }

            Label noteLineLabel = new Label()
            {
                Text = "Tiêu đề bảng là bắt buộc",
                Width = Const.panelTextBoxWidth,
                Location = new Point(20, text.Location.Y + text.Height + 10),
            };

            Guna2Button newBtn = new Guna2Button()
            {
                //BackColor = Color.MidnightBlue,
                Location = new Point(20, 210),
                Text = "Tạo Bảng Mới",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Size = new Size(180, 30),
                FillColor = Color.FromArgb(94, 148, 255),
                ForeColor = Color.White,
                BorderRadius = 5,
                TextAlign = HorizontalAlignment.Center,
            };
            Guna2Button closeBtn = new Guna2Button()
            {
                Size = new Size(20, 20),
                Location = new Point(185, 18),
                Image = Image.FromFile(Application.StartupPath + "/Resources/tab_close.png"),
                ImageAlign = HorizontalAlignment.Center,
                BackColor = Color.Transparent,
                FillColor = Color.WhiteSmoke,

            };
            //new code
            if (oldTitle == "")
                newBtn.Click += CreateTable_Click;
            else
            {
                newBtn.Click += CreateTable_Click;
                newBtn.PerformClick();
            }
            closeBtn.Click += CloseBtn_Click;
            textBoxPanel.Controls.Add(headLabel);
            textBoxPanel.Controls.Add(titleLabel);
            textBoxPanel.Controls.Add(text);
            textBoxPanel.Controls.Add(noteLineLabel);
            textBoxPanel.Controls.Add(newBtn);
            textBoxPanel.Controls.Add(closeBtn);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            WorkSpace.Controls.Remove(textBoxPanel);
            textBoxPanel.Visible = false;
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            textBoxContent = ((TextBox)sender).Text;
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            if (textBoxContent == "")
            {
                MessageBox.Show("Tiêu đề không được để trống");
            }
            else
            {
                Guna2Button newButton = new Guna2Button()
                {
                    Width = myTableButton.Width,
                    Height = myTableButton.Height,
                    BorderRadius = 0,
                    //BorderSize = 0,
                    BackColor = Color.Transparent,
                    Text = textBoxContent,
                    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                    //Font = new Font("Microsoft Sans Serif", 10),
                    //TextAlign = ContentAlignment.TopCenter,
                    FillColor = Color.Transparent,
                    Tag = Buttons.Count
                };
                if (Buttons.Count == 0)
                {
                    newButton.Location = new Point(myTableButton.Location.X, myTableButton.Location.Y + myTableButton.Height + 34);
                }
                else
                {
                    int lastIndex = Buttons.Count - 1;
                    newButton.Location = new Point(Buttons[lastIndex].Location.X, Buttons[lastIndex].Location.Y + Buttons[lastIndex].Height);

                    //Hide the last table
                    for (int i = 0; i < ListOfTable.Count; i++)
                    {
                        ListOfTable[i].PnlAllList.Visible = false;
                    }
                }
                TableSpace.Controls.Add(newButton);
                RJButton optBtn = new RJButton()
                {
                    Width = 25,
                    Height = 20,
                    BorderRadius = 10,
                    BorderSize = 0,
                    Location = new Point(newButton.Location.X + newButton.Width - 30, newButton.Location.Y + 10),
                    BackColor = Color.Transparent,
                    BackgroundImage = Image.FromFile(Application.StartupPath + "/Resources/....png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Tag = newButton.Tag
                };
                newButton.Click += NewButton_Click;
                optBtn.Click += OptBtn_Click;
                TableSpace.Controls.Add(optBtn);
                optBtn.BringToFront();
                WorkSpace.Controls.Remove(textBoxPanel);

                getTable(sender, e);

                textBoxContent = "";
                Buttons.Add(newButton); //Nhet button Table vua tao vao trong mang de quan ly
                OtpBtn.Add(optBtn);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            int index = buttons.IndexOf(clickedButton);
            if (index >= 0)
            {
                //MessageBox.Show("New btn");
                for (int i = 0; i < ListOfTable.Count; i++)
                {
                    //MessageBox.Show($"Off {i}");
                    if (i != index)
                    {
                        ListOfTable[i].PnlAllList.Visible = false;
                    }
                }
                ListOfTable[index].PnlAllList.Visible = true;
            }

        }

        private void OptBtn_Click(object sender, EventArgs e)
        {          
            RJButton btn = (RJButton)sender;
            Guna2GradientButton deleteTableButton = new Guna2GradientButton()
            {
                Text = "Xóa bảng",
                Location = new Point(btn.Location.X, btn.Location.Y + btn.Height + 55),
                BorderRadius = 10,
                FillColor = Color.White,
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Size = new Size(80, 20),
                Tag = btn.Tag,
            };
            mainForm.Controls.Add(deleteTableButton);
            deleteTableButton.BringToFront();
            deleteTableButton.Click += DeleteTableButton_Click;
        }

        private void Update_Location_After_Remove(int index)
        {
            if (index == Buttons.Count - 1)
            {
                Buttons.RemoveAt(Convert.ToInt32(index));
                OtpBtn.RemoveAt(Convert.ToInt32(index));
            }
            else
            {
                for (int i = Buttons.Count - 1; i > index; i--)
                {
                    Buttons[i].Location = Buttons[i - 1].Location;
                    Buttons[i].Tag = Buttons[i - 1].Tag;
                    OtpBtn[i].Location = OtpBtn[i - 1].Location;
                    OtpBtn[i].Tag = OtpBtn[i - 1].Tag;
                }
                Buttons.RemoveAt(Convert.ToInt32(index));
                OtpBtn.RemoveAt(Convert.ToInt32(index));
            }
        }

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bảng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"{Convert.ToInt32(btn.Tag)} - {listOfBoardID.Count} - {listOfTable.Count}");
                int index = Convert.ToInt32(btn.Tag);
                //MessageBox.Show($"Delete Table {listOfBoardID[index]}");
                ListOfTable[index].PnlAllList.Visible = false;
                ListOfTable.RemoveAt(index);
                BoardDAT.DeleteBoard(listOfBoardID[index], Login.userID);
                listOfBoardID.RemoveAt(index);
                

                TableSpace.Controls.Remove(Buttons[Convert.ToInt32(btn.Tag)]);
                TableSpace.Controls.Remove(OtpBtn[Convert.ToInt32(btn.Tag)]);
                Update_Location_After_Remove(Convert.ToInt32(btn.Tag));
            }
            btn.Visible = false;
            mainForm.Controls.Remove(btn);
        }
        private InsideTable getTable(object sender, EventArgs e)
        {
            InsideTable Table1 = new InsideTable(this.mainForm, this.workSpace, this.tableSpace);
            Table1.TableName = textBoxContent;
            ListOfTable.Add(Table1);

            if (retrieveProcess == false)
            {
                int boardID = BoardDAT.Insert($"{textBoxContent}", "255, 255, 255", Login.userID);
                Table1.UserID = Login.userID;
                Table1.TableID = boardID;
                listOfBoardID.Add(boardID);
                ViewerDAT viewer = new ViewerDAT();
                viewer.InsertViewer(Login.userID, boardID);
            }
            return Table1;
        }
        private void reSizeTableSpace(bool expand)
        {
            int resize_length = 0;
            if (expand)
            {
                resize_length = 160;
            }
            else
            {
                resize_length = -160;
            }
            foreach (var table in ListOfTable)
            {
                if (table.PnlAllList.Visible)
                {
                    for (int index = 0; index < table.ListOfDanhSach.Count; index++)
                    {
                        table.ListOfDanhSach[index].Location = new Point(table.ListOfDanhSach[index].Location.X + resize_length,
                        table.ListOfDanhSach[index].Location.Y);
                    }
                    table.BtnAddNewList.Location = new Point(table.BtnAddNewList.Location.X + resize_length,
                             table.BtnAddNewList.Location.Y);
                    table.BtnSaveTable.Location = new Point(table.BtnSaveTable.Location.X + resize_length,
                             table.BtnSaveTable.Location.Y);
                    table.BtnAddMember.Location = new Point(table.BtnAddMember.Location.X + resize_length,
                        table.BtnAddMember.Location.Y);
                }
            }
        }

        void retrieveData(object sender, EventArgs e)
        {
            List<Board> boards = viewerDAT.GetViwerBoards(Login.userID);
            RJButton btn = new RJButton();
            
            foreach (var b in boards)
            {
                int indexOfB = boards.IndexOf(b);
                if (listOfTable.Count <= indexOfB)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}\n", b.id, b.name, b.OnwerID, b.color);
                    CreateTextBox(btn, $"{b.name}");
                    listOfTable[listOfTable.Count - 1].TableID = b.id;
                    listOfTable[listOfTable.Count - 1].UserID = Login.userID;
                    listOfBoardID.Add(b.id);

                    ListCardDAT listCardDAT = new ListCardDAT();
                    List<ListCard> listCardFromTable = listCardDAT.Get(b.id);
                    listOfTable[listOfTable.Count - 1].GetNewBoard = false;

                    for (int i = 0; i < listCardFromTable.Count; i++)
                    {
                        for (int j = 0; j < listCardFromTable.Count - 1; j++)
                        {
                            if (listCardFromTable[i].location < listCardFromTable[j].location)
                            {
                                ListCard temp = listCardFromTable[i];
                                listCardFromTable[i] = listCardFromTable[j];
                                listCardFromTable[j] = temp;
                            }
                        }
                    }
                    //MessageBox.Show($"NUmber of list card: {listCardFromTable.Count}");
                    foreach (var ListCard in listCardFromTable)
                    {
                        //MessageBox.Show($"Get list card from table {b.id} - {ListCard.id} - {ListCard.location}");

                        listOfTable[listOfTable.Count - 1].ListOfListCardID.Add(ListCard.id);
                        listOfTable[listOfTable.Count - 1].BtnAddNewList.PerformClick();
                        listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].UserID = Login.userID;
                        listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].ListCardID = ListCard.id;
                        listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].TableID = b.id;
                        listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].TxtBxTitle.Text = ListCard.name;

                        var dbcontext = new Context();
                        List<Card> cards = dbcontext.cards.Where(c => c.listCardid == ListCard.id).ToList();
                        //listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].ListOfData
                        for (int i = 0; i < cards.Count; i++)
                        {
                            for (int j = 0; j < cards.Count - 1; j++)
                            {
                                if (cards[i].location < cards[j].location)
                                {
                                    Card temp = cards[i];
                                    cards[i] = cards[j];
                                    cards[j] = temp;
                                }
                            }
                        }
                        for (int i = 0; i < cards.Count; i++)
                        {

                            if (i != 0)
                            {
                                //MessageBox.Show($"add {i} card to {ListCard.id}");
                                listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].BtnAddCard.PerformClick();
                            }
                            AppData appData = new AppData();
                            appData.Title = cards[i].tittle;
                            appData.DescribeContent = cards[i].desciption;
                            appData.ActivityContent = cards[i].activity;
                            appData.UserID = Login.userID;
                            appData.CardID = cards[i].id;
                            listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].ListOfData[listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].ListOfData.Count - 1] = appData;
                            listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].ListOfBtn[listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].ListOfBtn.Count - 1].Text = cards[i].tittle;
                            listOfTable[listOfTable.Count - 1].ListOfDanhSach[listOfTable[listOfTable.Count - 1].ListOfDanhSach.Count - 1].ListOfCardID.Add(cards[i].id);
                        }
                    }
                    //MessageBox.Show("Retrieve data done!");

                    listOfTable[listOfTable.Count - 1].RetrieveListCard = false;
                    listOfTable[listOfTable.Count - 1].GetNewBoard = true;
                }
            }
            retrieveProcess = false;

            
        }
    }
}
