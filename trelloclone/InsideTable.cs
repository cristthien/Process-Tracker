using DAT;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace trelloclone
{
    internal class InsideTable
    {
        private string tableName;
        Guna2Panel pnlAllList = new Guna2Panel();
        Guna2Panel pnlFirstList = new Guna2Panel();

        Guna2Panel addMemberPnl = new Guna2Panel();
        Guna2TextBox memberIDTbx = new Guna2TextBox();
        Guna2Button findMemberBtn = new Guna2Button();

        Guna2Button btnAddNewCard = new Guna2Button();
        Guna2Button btnCard = new Guna2Button();
        Guna2Button btnAddNewList = new Guna2Button();
        Guna2Button btnSaveTable = new Guna2Button();
        Guna2Button btnAddMember = new Guna2Button();
        List<list> listOfDanhSach = new List<list>();
        HScrollBar hScrollBar = new HScrollBar();

        //list card DAT
        ListCardDAT listCardDAT = new ListCardDAT();
        List<int> listOfListCardID = new List<int>();
        int tableID;
        int userID;
        //Process of retrieve data
        bool retrieveListCard = true;
        //Create new table
        bool getNewBoard = true;
        //List of viewer iD
        List<int> listOfViewerID = new List<int>();

        public string TableName { get => tableName; set => tableName = value; }
        public Guna2Panel PnlAllList { get => pnlAllList; set => pnlAllList = value; }
        public Guna2Panel PnlFirstList { get => pnlFirstList; set => pnlFirstList = value; }
        public Guna2Button BtnAddNewCard { get => btnAddNewCard; set => btnAddNewCard = value; }
        public Guna2Button BtnCard { get => btnCard; set => btnCard = value; }
        public Guna2Button BtnAddNewList { get => btnAddNewList; set => btnAddNewList = value; }
        public Guna2Button BtnSaveTable { get => btnSaveTable; set => btnSaveTable = value; }
        public List<list> ListOfDanhSach { get => listOfDanhSach; set => listOfDanhSach = value; }
        public Guna2Button BtnAddMember { get => btnAddMember; set => btnAddMember = value; }
        public int TableID { get => tableID; set => tableID = value; }
        public int UserID { get => userID; set => userID = value; }
        public bool RetrieveListCard { get => retrieveListCard; set => retrieveListCard = value; }
        public List<int> ListOfListCardID { get => listOfListCardID; set => listOfListCardID = value; }
        public bool GetNewBoard { get => getNewBoard; set => getNewBoard = value; }

        public InsideTable(Form1 form, Panel WorkSpace, Panel TableSpace)
        {

            PnlAllList.Size = WorkSpace.Size;
            WorkSpace.Controls.Add(PnlAllList);

            PnlAllList.Controls.Add(BtnAddNewList);
            BtnAddNewList.BorderRadius = 5;
            BtnAddNewList.BackColor = Color.Transparent;
            BtnAddNewList.FillColor = Color.FromArgb(224, 224, 224);
            BtnAddNewList.Size = new Size(115, 30);
            BtnAddNewList.Location = new Point(180, 10);
            BtnAddNewList.Image = Image.FromFile(Application.StartupPath + "/Resources/Add.png");
            BtnAddNewList.ImageAlign = HorizontalAlignment.Left;
            BtnAddNewList.ImageOffset = new Point(-10, 0);
            BtnAddNewList.Text = "Thêm danh sách";
            BtnAddNewList.ForeColor = Color.Black;
            BtnAddNewList.TextOffset = new Point(7, 0);
            BtnAddNewList.Click += btnAddNewList_Click;

            PnlAllList.Controls.Add(BtnSaveTable);
            BtnSaveTable.BorderRadius = 5;
            BtnSaveTable.BackColor = Color.Transparent;
            BtnSaveTable.FillColor = Color.FromArgb(224, 224, 224);
            BtnSaveTable.Size = new Size(52, 30);
            BtnSaveTable.Location = new Point(300, 10);
            BtnSaveTable.Image = Image.FromFile(Application.StartupPath + "/Resources/hide.png");
            BtnSaveTable.ImageAlign = HorizontalAlignment.Left;
            BtnSaveTable.ImageOffset = new Point(-8, 0);
            BtnSaveTable.Text = "Ẩn";
            BtnSaveTable.ForeColor = Color.Black;
            BtnSaveTable.TextOffset = new Point(8, 0);
            BtnSaveTable.Click += BtnSaveTable_Click;

            PnlAllList.Controls.Add(btnAddMember);
            btnAddMember.BorderRadius = 5;
            btnAddMember.BackColor = Color.Transparent; 
            btnAddMember.FillColor = Color.FromArgb(224, 224, 224);
            btnAddMember.Size = new Size(130, 30);
            btnAddMember.Location = new Point(358, 10);
            btnAddMember.Image = Image.FromFile(Application.StartupPath + "/Resources/personAdd.png");
            btnAddMember.ImageAlign = HorizontalAlignment.Left;
            btnAddMember.ImageOffset = new Point(-8, 0);
            btnAddMember.Text = "Thêm thành viên";
            btnAddMember.ForeColor = Color.Black;
            btnAddMember.TextOffset = new Point(6, 0);
            btnAddMember.Click += BtnAddMember_Click;

            PnlAllList.Controls.Add(hScrollBar);
            hScrollBar.Location = new Point(hScrollBar.Location.X + 1370, hScrollBar.Location.Y + 820);
            hScrollBar.Maximum = 260;
            hScrollBar.Scroll += HScrollBar_Scroll;

            //createTheFirstList(pnlAllList, ListOfDanhSach);

            addMemberPnl.Visible = false;
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            if (addMemberPnl.Visible == false)
            {
                addMemberPnl = new Guna2Panel()
                {
                    Location = new Point(btnAddMember.Location.X + btnAddMember.Size.Width + 8, btnAddMember.Location.Y),
                    Size = new Size(200, 30),
                    BackColor = Color.Transparent,
                    FillColor = Color.WhiteSmoke,
                    BorderRadius = 5,
                };
                PnlAllList.Controls.Add(addMemberPnl);

                memberIDTbx = new Guna2TextBox()
                {
                    Location = new Point(4, 4),
                    Size = new Size(170, 22),
                    PlaceholderText = "Nhập tên của thành viên mới",
                    ForeColor = Color.Black,

                };
                addMemberPnl.Controls.Add(memberIDTbx);

                findMemberBtn = new Guna2Button()
                {
                    Location = new Point(180, 7),
                    Image = Image.FromFile(Application.StartupPath + "/Resources/search.png"),
                    //BackColor = Color.Transparent,
                    Size = new Size(17, 17),
                    FillColor = Color.Transparent,
                    BorderRadius = 5,
                };
                addMemberPnl.Controls.Add(findMemberBtn);
                findMemberBtn.Click += FindMemberBtn_Click;             
            }
            else if (addMemberPnl.Visible == true)
                addMemberPnl.Visible = false;
        }

        private void FindMemberBtn_Click(object sender, EventArgs e)
        {
            if (memberIDTbx.Text == "")
                MessageBox.Show("Tên của người dùng không được để trống!");
            else
            {
                UserDAT userDAT = new UserDAT();
                int id =userDAT.GetID(memberIDTbx.Text);
                if (id != -1)
                {
                    ViewerDAT viewerDAT = new ViewerDAT();
                    bool kq = viewerDAT.InsertViewer(id, TableID);
                    if (kq)
                        MessageBox.Show("Thêm thành viên thành công!");
                    else
                        MessageBox.Show("Thêm thành viên thất bại!");
                }
                else
                    MessageBox.Show("Không tìm thấy thành viên!");
            }
        }

        internal void btnAddNewList_Click(object sender, EventArgs e)
        {
            if (ListOfDanhSach.Count != 0)
            {
                list anotherList = new list(PnlAllList, ListOfDanhSach);
                ListOfDanhSach.Add(anotherList);
                anotherList.BtnAddCard.Click += btnAddCard_Click;
                anotherList.BtnFirstCard.Click += DynamicButton_Click;
                anotherList.BtnDeleteList.Click += btnDeleteList_Click;
                anotherList.BtnMoveToLeft.Click += BtnMoveToLeft_Click;
                anotherList.BtnMoveToRight.Click += BtnMoveToRight_Click;

                if (RetrieveListCard == false || getNewBoard == true)
                {
                    int listCardID = listCardDAT.Insert(anotherList.TxtBxTitle.Text, tableID);
                    ListOfListCardID.Add(listCardID);
                   // MessageBox.Show($"Create list at {TableID}");
                    CardDAT cardDAT = new CardDAT();
                    int kq = cardDAT.Insert("Tiêu đề", "", "", listCardID);
                    anotherList.ListCardID = listCardID;
                    anotherList.ListOfCardID.Add(kq);
                    anotherList.ListOfData[anotherList.ListOfData.Count - 1].CardID = kq;
                }
            }
            else
                createTheFirstList(PnlAllList, ListOfDanhSach);
        }
        private void createTheFirstList(Guna2Panel PnlAllList, List<list> listOfDanhSach)
        {

            //MessageBox.Show("Create first list");

            list firstList = new list(PnlAllList, listOfDanhSach);
            listOfDanhSach.Add(firstList);
            firstList.BtnAddCard.Click += btnAddCard_Click;
            firstList.BtnFirstCard.Click += DynamicButton_Click;
            firstList.BtnDeleteList.Click += btnDeleteList_Click;
            firstList.BtnMoveToLeft.Click += BtnMoveToLeft_Click;
            firstList.BtnMoveToRight.Click += BtnMoveToRight_Click;

            //firstList.BtnFirstCard.PerformClick();

            if (RetrieveListCard == false || getNewBoard == true)
            {
                //MessageBox.Show($"create List at {TableID}");
                int listCardID = listCardDAT.Insert(firstList.TxtBxTitle.Text, tableID);
                ListOfListCardID.Add(listCardID);

                CardDAT cardDAT = new CardDAT();
                int kq = cardDAT.Insert("Tiêu đề", "", "", listCardID);
                firstList.ListCardID = listCardID;
                //MessageBox.Show($"Create card: {kq} in {listCardID}");
                firstList.ListOfCardID.Add(kq);
                firstList.ListOfData[firstList.ListOfData.Count - 1].CardID = kq;
                //CardDAT newCard = new CardDAT();
                //newCard.Insert("Tiêu đề", "", listCardID);
                //MessageBox.Show($"Create card at {listCardID}");
                
            }
 
        }

        private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int newPos = e.NewValue;
            int dif = e.NewValue - e.OldValue;
            PnlAllList.Location = new Point(PnlAllList.Location.X - dif, PnlAllList.Location.Y);
            hScrollBar.Location = new Point(hScrollBar.Location.X + dif, hScrollBar.Location.Y);
            BtnAddNewList.Location = new Point(BtnAddNewList.Location.X + dif, BtnAddNewList.Location.Y);
            BtnSaveTable.Location = new Point(BtnSaveTable.Location.X + dif, BtnSaveTable.Location.Y);
        }

        private void BtnSaveTable_Click(object sender, EventArgs e)
        {
            PnlAllList.Visible = false;
        }

        private void BtnMoveToRight_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            list currentList = list.FindForm(clickedButton);

            if (currentList != null)
            {
                int index = ListOfDanhSach.IndexOf(currentList);
                if (index + 1 == ListOfDanhSach.Count) // check for first and last table
                {
                    return;
                }
                else
                {
                    int indexList = listOfDanhSach.IndexOf(currentList);
                    ListCardDAT.MoveRight(tableID, currentList.ListCardID);


                    swap(ListOfDanhSach[index], ListOfDanhSach[index + 1], index, index + 1);
                    list temp = ListOfDanhSach[index];
                    ListOfDanhSach[index] = ListOfDanhSach[index + 1];
                    ListOfDanhSach[index + 1] = temp;
                }
            }
        }

        private void BtnMoveToLeft_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            list currentList = list.FindForm(clickedButton);

            if (currentList != null)
            {
                int index = ListOfDanhSach.IndexOf(currentList);
                if (index == 0) // check for first and last table
                    return;
                else
                {
                    int indexList = listOfDanhSach.IndexOf(currentList);
                    ListCardDAT.MoveLeft(tableID, currentList.ListCardID);

                    swap(ListOfDanhSach[index - 1], ListOfDanhSach[index], index - 1, index);
                    list temp = ListOfDanhSach[index - 1];
                    ListOfDanhSach[index - 1] = ListOfDanhSach[index];
                    ListOfDanhSach[index] = temp;
                }
            }
        }
        private void swap(list a, list b, int index_a, int index_b)
        {
            Point c = a.Location;
            a.Location = b.Location;
            b.Location = c;
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            list currentList = list.FindForm(clickedButton);

            if (currentList != null)
            {
                currentList.createOtherCard(currentList.PnlCurrentList);
                currentList.ListOfBtn[currentList.ListOfBtn.Count - 1].Click += DynamicButton_Click;
                currentList.modifyAddCard(currentList.PnlCurrentList);
                currentList.modifyDeleteList(currentList.PnlCurrentList);

                if (currentList.MoveLeft || currentList.MoveRight)
                    return;

                int index = listOfDanhSach.IndexOf(currentList);
                if (RetrieveListCard == false || getNewBoard == true)
                {
                    CardDAT newCard = new CardDAT();
                    int kq = newCard.Insert("Tiêu đề", "", "", listOfListCardID[index]);
                    //MessageBox.Show($"Create card at {listOfListCardID[index]}");
                    currentList.ListOfData[currentList.ListOfData.Count - 1].CardID = kq;
                    currentList.ListOfCardID.Add(kq);
                }
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            list currentList = list.FindForm(clickedButton);
 
            if (currentList != null)
            {
                DialogResult result = MessageBox.Show("Thực hiện xóa danh sánh?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (ListOfDanhSach.Count >= 1)
                    {
                        int indexList = ListOfDanhSach.IndexOf(currentList);
                        int listCardID = listOfDanhSach[indexList].ListCardID;
                        ListCardDAT listCardDAT = new ListCardDAT();
                        listCardDAT.DeletebyID(listCardID);

                        listOfListCardID.RemoveAt(indexList);
                        ListOfDanhSach.RemoveAt(indexList);
                        Size oldSize = currentList.Size;
                        Point OldLocation = currentList.Location;
                        pnlAllList.Controls.Remove(currentList);
                        list.moveListAfterDelete(OldLocation, oldSize, ListOfDanhSach);
                    }
                }
            }
        }
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            list currentList = list.FindForm(clickedButton);

            if (currentList != null)
            {
                int index = currentList.ListOfBtn.IndexOf(clickedButton);
                WindowsFormsApp1.Card a;

                if (currentList.ListOfData.Count == 0)
                {
                    int indexList = listOfDanhSach.IndexOf(currentList);

                    a = new WindowsFormsApp1.Card(new AppData());
                    currentList.ListOfData.Add(a.AppData);
                    currentList.ListOfData[currentList.ListOfData.Count - 1].CreatedCard = false;
                }
                else
                {
                    currentList.ListOfData[index].CardID = currentList.ListOfCardID[index];
                    
                    a = new WindowsFormsApp1.Card(currentList.ListOfData[index]);
                    a.CardID = currentList.ListOfCardID[index];
                   // MessageBox.Show($"Open card {currentList.ListCardID} - {currentList.ListOfCardID[index]} - {a.AppData.Title} - {a.CardID}");
                }

                a.ShowDialog();
                //MessageBox.Show("Back to main");
                bool deleteCard = !a.Existed;

                if (a.Existed)
                {
                    currentList.ListOfData[index] = a.AppData;
                    //MessageBox.Show($"Close {a.AppData.Title}");
                    currentList.ListOfBtn[index].Text = a.AppData.Title;
                    int indexList = this.ListOfDanhSach.IndexOf(currentList);
                    if (a.MoveToLeft)
                    {
                        if (indexList != 0)
                        {
                            //MessageBox.Show($"Move Left from {listOfDanhSach[indexList].ListCardID} to {listOfDanhSach[indexList-1].ListCardID}");
                            if (listOfDanhSach[indexList - 1] != null)
                            {
                                CardDAT cardDAT = new CardDAT();
                                cardDAT.MoveHorizontally(currentList.ListOfCardID[index], listOfDanhSach[indexList - 1].ListCardID);
                                listOfDanhSach[indexList - 1].ListOfCardID.Add(currentList.ListOfCardID[index]);

                                AppData currentData = currentList.ListOfData[index];
                                deleteCard = true;
                                this.ListOfDanhSach[indexList - 1].MoveLeft = true;
                                this.ListOfDanhSach[indexList - 1].BtnAddCard.PerformClick();
                                this.ListOfDanhSach[indexList - 1].MoveLeft = false;
                                this.ListOfDanhSach[indexList - 1].ListOfData[this.ListOfDanhSach[indexList
                                    - 1].ListOfData.Count - 1] = currentData;
                                this.ListOfDanhSach[indexList - 1].ListOfBtn[this.ListOfDanhSach[indexList
                                    - 1].ListOfBtn.Count - 1].Text = currentData.Title;
                            }
                        }
                    }
                    else if (a.MoveToRight)
                    {
                        if (indexList < this.ListOfDanhSach.Count - 1)
                        {
                            //MessageBox.Show($"Move Right from {listOfDanhSach[indexList].ListCardID} to {listOfDanhSach[indexList + 1].ListCardID}");
                            if (listOfDanhSach[indexList + 1] != null)
                            {
                                CardDAT cardDAT = new CardDAT();
                                cardDAT.MoveHorizontally(currentList.ListOfCardID[index], listOfDanhSach[indexList + 1].ListCardID);
                                listOfDanhSach[indexList + 1].ListOfCardID.Add(currentList.ListOfCardID[index]);

                                AppData currentData = currentList.ListOfData[index];
                                deleteCard = true;
                                this.ListOfDanhSach[indexList + 1].MoveRight = true;
                                this.ListOfDanhSach[indexList + 1].BtnAddCard.PerformClick();
                                this.ListOfDanhSach[indexList + 1].MoveRight = false;
                                this.ListOfDanhSach[indexList + 1].ListOfData[this.ListOfDanhSach[indexList
                                    + 1].ListOfData.Count - 1] = currentData;
                                this.ListOfDanhSach[indexList + 1].ListOfBtn[ListOfDanhSach[indexList + 1].ListOfBtn.Count - 1].Text = currentData.Title;
                            }
                        }
                    }
                    else if (a.MoveUp)
                    {
                        if (index != 0)
                        {
                            //MessageBox.Show("Move up");
                            CardDAT cardDAT = new CardDAT();
                            cardDAT.MoveUpward(currentList.ListCardID, currentList.ListOfCardID[index]);

                            AppData temp = currentList.ListOfData[index];
                            currentList.ListOfData[index] = currentList.ListOfData[index - 1];
                            currentList.ListOfData[index - 1] = temp;

                            int tempCardID = currentList.ListOfCardID[index];
                            currentList.ListOfCardID[index] = currentList.ListOfCardID[index - 1];
                            currentList.ListOfCardID[index-1] = tempCardID;

                            currentList.ListOfBtn[index].Text = currentList.ListOfData[index].Title;
                            currentList.ListOfBtn[index-1].Text = currentList.ListOfData[index-1].Title;
                        }
                    }
                    else if (a.MoveDown)
                    {
                        if (index < currentList.ListOfBtn.Count - 1)
                        {
                            //MessageBox.Show($"Move down");
                            CardDAT cardDAT = new CardDAT();
                            cardDAT.MoveDownward(currentList.ListCardID, currentList.ListOfCardID[index]);

                            AppData temp = currentList.ListOfData[index];
                            currentList.ListOfData[index] = currentList.ListOfData[index + 1];
                            currentList.ListOfData[index + 1] = temp;

                            int tempCardID = currentList.ListOfCardID[index];
                            currentList.ListOfCardID[index] = currentList.ListOfCardID[index + 1];
                            currentList.ListOfCardID[index + 1] = tempCardID;

                            currentList.ListOfBtn[index].Text = currentList.ListOfData[index].Title;
                            currentList.ListOfBtn[index + 1].Text = currentList.ListOfData[index + 1].Title;
                        }
                    }
                    //for (int j = 0; j < EventHandlers.ListOfTable.Count; j++)
                    //{
                    //    for (int k = 0; k < EventHandlers.ListOfTable[j].ListOfDanhSach.Count; k++)
                    //    {
                    //        for (int l = 0; l < EventHandlers.ListOfTable[j].ListOfDanhSach[k].ListOfBtn.Count; l++)
                    //        {
                    //            if (l < EventHandlers.ListOfTable[j].ListOfDanhSach[k].ListOfData.Count)
                    //            {
                    //                EventHandlers.ListOfTable[j].ListOfDanhSach[k].ListOfBtn[l].Text =
                    //                EventHandlers.ListOfTable[j].ListOfDanhSach[k].ListOfData[l].Title;
                    //            }
                    //        }
                    //    }
                    //}
                }
                if (deleteCard)
                {
                    //MessageBox.Show($"Delete card");
                    if (currentList.ListOfBtn.Count == 1)
                    {
                        //currentList.ListOfData.RemoveAt(index);
                        currentList.ListOfData[index] = new AppData();
                        currentList.ListOfBtn[index].Text = "Tiêu đề";
                        currentList.ListOfCardID.RemoveAt(index);
                        //currentList.ListOfBtn.RemoveAt(index);
                        //currentList.ListOfCardID.RemoveAt(index);
                        currentList.RetrieveData = false;
                        //currentList.BtnAddCard.PerformClick();
                        CardDAT newCard = new CardDAT();
                        int kq = newCard.Insert("Tiêu đề", "", "", currentList.ListCardID);
                        //MessageBox.Show($"Create card at {currentList.ListCardID}");
                        currentList.ListOfData[index] = new AppData();
                        currentList.ListOfData[currentList.ListOfData.Count - 1].CardID = kq;
                        currentList.ListOfCardID.Add(kq);
                        
                    }
                    else
                    {
                        currentList.ListOfCardID.RemoveAt(index);
                        Point OldLocation = clickedButton.Location;
                        currentList.Controls.Remove(clickedButton);
                        list.moveCardAfterDelete(currentList, OldLocation);
                        currentList.ListOfData.RemoveAt(index);
                        currentList.ListOfBtn.RemoveAt(index);
                    }
                }
            }
        }
        public override string ToString()
        {
            string a = $"{tableName}/{listOfDanhSach.Count}/";
            foreach (var list in listOfDanhSach)
            {
                if (listOfDanhSach.IndexOf(list) + 1 == listOfDanhSach.Count)
                {
                    a += $"{list.TxtBxTitle.Text}/";
                }
                else
                    a += $"{list.TxtBxTitle.Text}_";
            }
            foreach (var list in listOfDanhSach)
            {
                if (listOfDanhSach.IndexOf(list) + 1 == listOfDanhSach.Count)
                {
                    a += $"{list.ListOfBtn.Count}/";
                }
                else
                    a += $"{list.ListOfBtn.Count}_";
            }
            return a;
        }
    }
}
