using DAT;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trelloclone
{
    internal class list : Guna2Panel
    {
        private List<Guna2Button> listOfBtn = new List<Guna2Button>();
        private List<AppData> listOfData = new List<AppData>();
        private List<bool> listOfmodifiedData = new List<bool>();
        private Guna2Button btnFirstCard;
        private Guna2Button btnAddCard;
        private Guna2Button btnDeleteList;
        private Guna2Button btnMoveToLeft;
        private Guna2Button btnMoveToRight;
        private Guna2Panel pnlCurrentList;
        private Guna2TextBox txtBxTitle;
        //database
        private int userID;
        private int tableID;
        private int listCardID;
        private bool retrieveData = true;
        private List<int> listOfCardID = new List<int>();
        //move
        private bool moveLeft = false;
        private bool moveRight = false;

        public List<Guna2Button> ListOfBtn { get => listOfBtn; set => listOfBtn = value; }
        internal List<AppData> ListOfData { get => listOfData; set => listOfData = value; }
        public List<bool> ListOfModifiedData { get => listOfmodifiedData; set => listOfmodifiedData = value; }
        public Guna2Button BtnFirstCard { get => btnFirstCard; set => btnFirstCard = value; }
        public Guna2Button BtnAddCard { get => btnAddCard; set => btnAddCard = value; }
        public Guna2Button BtnDeleteList { get => btnDeleteList; set => btnDeleteList = value; }
        public Guna2Button BtnMoveToLeft { get => btnMoveToLeft; set => btnMoveToLeft = value; }
        public Guna2Button BtnMoveToRight { get => btnMoveToRight; set => btnMoveToRight = value; }
        public Guna2Panel PnlCurrentList { get => pnlCurrentList; set => pnlCurrentList = value; }
        public Guna2TextBox TxtBxTitle { get => txtBxTitle; set => txtBxTitle = value; }
        public int UserID { get => userID; set => userID = value; }
        public int TableID { get => tableID; set => tableID = value; }
        public int ListCardID { get => listCardID; set => listCardID = value; }
        public bool RetrieveData { get => retrieveData; set => retrieveData = value; }
        public List<int> ListOfCardID { get => listOfCardID; set => listOfCardID = value; }
        public bool MoveLeft { get => moveLeft; set => moveLeft = value; }
        public bool MoveRight { get => moveRight; set => moveRight = value; }

        public list(Guna2Panel pnlAllList, List<list> listOfDanhSach)
        {
            PnlCurrentList = createCurrentList(pnlAllList, listOfDanhSach);
            TxtBxTitle = createTitle(PnlCurrentList);
            TxtBxTitle.Tag = this;
            BtnFirstCard = createFirstCard(PnlCurrentList);
            BtnAddCard = modifyAddCard(PnlCurrentList); // create and edit the add card button
            BtnAddCard.Tag = this;
            BtnDeleteList = modifyDeleteList(PnlCurrentList);
            BtnDeleteList.Tag = this;
            BtnMoveToLeft = createBtnMoveLeft(pnlCurrentList);
            BtnMoveToLeft.Tag = this;
            BtnMoveToRight = createBtnMoveRight(pnlCurrentList);
            BtnMoveToRight.Tag = this;
            txtBxTitle.TextChanged += TxtBxTitle_TextChanged;
        }

        private void TxtBxTitle_TextChanged(object sender, EventArgs e)
        {
            ListCardDAT listCardDAT = new ListCardDAT();
            listCardDAT.UpdateName(ListCardID, $"{txtBxTitle.Text}");
        }

        public Guna2Panel createCurrentList(Guna2Panel pnlAllList, List<list> listOfDanhSach)
        {
            pnlAllList.Controls.Add(this); //Add panel for list
            this.Size = new Size(260, 110);
            this.FillColor = Color.White;
            this.BorderRadius = 5;

            if (listOfDanhSach.Count == 0)
                this.Location = new Point(180, 50);
            else
            {
                this.Location = new Point(listOfDanhSach[listOfDanhSach.Count - 1].Location.X +
                   listOfDanhSach[listOfDanhSach.Count - 1].Size.Width + 10, 50);
            }

            this.BackColor = Color.Transparent;

            return this;
        }
        private Guna2TextBox createTitle(Guna2Panel pnlCurrentList)
        {
            txtBxTitle = new Guna2TextBox();
            pnlCurrentList.Controls.Add(txtBxTitle);
            txtBxTitle.Location = new Point(9, 10);
            txtBxTitle.Size = new Size(200, 15);
            txtBxTitle.Text = "Danh sách mới";
            txtBxTitle.TextAlign = HorizontalAlignment.Left;
            txtBxTitle.BorderThickness = 0;
            txtBxTitle.Font = new Font("Segoe UI", 10);
            txtBxTitle.ForeColor = Color.Black;

            return txtBxTitle;
        }

        private Guna2Button createBtnMoveLeft(Guna2Panel pnlCurrentList)
        {
            BtnMoveToLeft = new Guna2Button();
            pnlCurrentList.Controls.Add(BtnMoveToLeft);
            BtnMoveToLeft.BackColor = Color.Transparent;
            BtnMoveToLeft.Location = new Point(230, 10);
            BtnMoveToLeft.Size = new Size(10, 10);
            BtnMoveToLeft.Image = Image.FromFile(Application.StartupPath + "/Resources/backArrow.png");
            BtnMoveToLeft.ImageSize = new Size(10, 10);
            BtnMoveToLeft.ImageAlign = HorizontalAlignment.Center;
            BtnMoveToLeft.ImageOffset = new Point(1, 0);
            BtnMoveToLeft.FillColor = Color.FromArgb(244, 244, 244);

            return BtnMoveToLeft;
        }
        private Guna2Button createBtnMoveRight(Guna2Panel pnlCurrentList)
        {
            BtnMoveToRight = new Guna2Button();
            pnlCurrentList.Controls.Add(BtnMoveToRight);
            BtnMoveToRight.BackColor = Color.Transparent;
            BtnMoveToRight.Location = new Point(243, 10);
            BtnMoveToRight.Size = new Size(10, 10);
            BtnMoveToRight.Image = Image.FromFile(Application.StartupPath + "/Resources/forwardArrow.png");
            BtnMoveToRight.ImageSize = new Size(10, 10);
            BtnMoveToRight.ImageAlign = HorizontalAlignment.Center;
            BtnMoveToRight.FillColor = Color.FromArgb(244, 244, 244);

            return BtnMoveToRight;
        }

        public Guna2Button createFirstCard(Guna2Panel pnlCurrentList)
        {
            Guna2Button btnCard = new Guna2Button();
            pnlCurrentList.Controls.Add(btnCard); //Add the card button for list
            btnCard.BackColor = Color.Transparent;
            btnCard.BorderRadius = 5;
            btnCard.FillColor = Color.FromArgb(224, 224, 224);
            btnCard.Location = new Point(5, 40);
            btnCard.Size = new Size(250, 35);
            btnCard.ForeColor = Color.Black;
            btnCard.Text = "Tiêu đề";
            btnCard.TextAlign = HorizontalAlignment.Left;
            ListOfBtn.Add(btnCard); //add the btn Card to the LIST of button
            ListOfModifiedData.Add(false);
            ListOfData.Add(new AppData());

            //if(retrieveData == false)
            //{
            //    CardDAT cardDAT = new CardDAT();
            //    cardDAT.Insert(btnCard.Text, "", ListCardID);
            //}
            //CardDAT cardDAT = new CardDAT();
            //int kq = cardDAT.Insert(btnCard.Text, "", ListCardID);
            //MessageBox.Show($"Create first Card: {kq} - {ListCardID}");


            btnCard.Tag = this;
            return btnCard;
        }

        public Guna2Button createOtherCard(Guna2Panel pnlCurrentList)
        {
            Guna2Button btnCard_in = new Guna2Button();
            btnCard_in.Location = new Point(listOfBtn[listOfBtn.Count - 1].Location.X,
                listOfBtn[listOfBtn.Count - 1].Location.Y + 40);
            btnCard_in.BackColor = listOfBtn[listOfBtn.Count - 1].BackColor;
            btnCard_in.Size = listOfBtn[listOfBtn.Count - 1].Size;
            btnCard_in.BackColor = Color.Transparent;
            btnCard_in.BorderRadius = listOfBtn[listOfBtn.Count - 1].BorderRadius;
            btnCard_in.FillColor = listOfBtn[listOfBtn.Count - 1].FillColor;
            btnCard_in.TextAlign = HorizontalAlignment.Left;
            btnCard_in.ForeColor = Color.Black;
            btnCard_in.Text = "Tiêu đề";

            this.Controls.Add(btnCard_in);
            listOfBtn.Add(btnCard_in);
            listOfmodifiedData.Add(false);
            ListOfData.Add(new AppData());

            btnCard_in.Tag = this;

            ////////////////////////////them list card o day db
            //if (retrieveData == false)
            //{
            //    CardDAT cardDAT = new CardDAT();
            //    cardDAT.Insert(btnCard_in.Text, "", ListCardID);
            //}
            //CardDAT cardDAT = new CardDAT();
            //cardDAT.Insert(btnCard_in.Text, "", ListCardID);

            return btnCard_in;
        }

        public Guna2Button modifyAddCard(Guna2Panel pnlCurrentList)
        {
            Guna2Button btnAddNewCard = new Guna2Button();

            if (listOfBtn.Count > 1)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + 40);
                BtnAddCard.Location = new Point(BtnAddCard.Location.X, BtnAddCard.Location.Y + 40);
            }
            else
            {
                pnlCurrentList.Controls.Add(btnAddNewCard);
                btnAddNewCard.BorderRadius = 5;
                btnAddNewCard.BackColor = Color.White;
                btnAddNewCard.FillColor = Color.FromArgb(224, 224, 224);
                btnAddNewCard.Size = new Size(90, 20);
                btnAddNewCard.Location = new Point(5, 80);
                btnAddNewCard.Image = Image.FromFile(Application.StartupPath + "/Resources/Add.png");
                btnAddNewCard.ImageAlign = HorizontalAlignment.Left;
                btnAddNewCard.ImageOffset = new Point(-10, 0);
                btnAddNewCard.Text = "Thêm thẻ";
                btnAddNewCard.ForeColor = Color.Black;
                btnAddNewCard.TextOffset = new Point(-1, 0);
                this.Controls.Add(btnAddNewCard);
            }
            return btnAddNewCard;
        }
        public Guna2Button modifyDeleteList(Guna2Panel pnlCurrentList)
        {
            Guna2Button btnRemoveList = new Guna2Button();

            if (listOfBtn.Count > 1)
            {
                btnDeleteList.Location = new Point(btnDeleteList.Location.X, btnDeleteList.Location.Y + 40);
            }
            else
            {
                pnlCurrentList.Controls.Add(btnRemoveList);
                btnRemoveList.BorderRadius = 5;
                btnRemoveList.BackColor = Color.White;
                btnRemoveList.FillColor = Color.FromArgb(224, 224, 224);
                btnRemoveList.Size = new Size(120, 20);
                btnRemoveList.Image = Image.FromFile(Application.StartupPath + "/Resources/delete.png");
                btnRemoveList.ImageAlign = HorizontalAlignment.Left;
                btnRemoveList.Location = new Point(133, 80);
                btnRemoveList.ImageOffset = new Point(-10, 0);
                btnRemoveList.Text = "Xoá danh sách";
                btnRemoveList.ForeColor = Color.Black;
                btnRemoveList.TextOffset = new Point(-1, 0);
                this.Controls.Add(btnRemoveList);
            }
            return btnRemoveList;
        }

        static public list FindForm(Control control)
        {
            while (control != null && !(control is list))
            {
                control = control.Parent;
            }
            return control as list;
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        static public void moveCardAfterDelete(list pnlCurrentList, Point deletedLocation)
        {
            int i = 0;
            while (i < pnlCurrentList.ListOfBtn.Count)
            {
                if (pnlCurrentList.ListOfBtn[i].Location.Y > deletedLocation.Y)
                {
                    pnlCurrentList.ListOfBtn[i].Location = new Point(pnlCurrentList.ListOfBtn[i].Location.X,
                        pnlCurrentList.ListOfBtn[i].Location.Y - 40);
                }
                i += 1;
            }
            pnlCurrentList.btnAddCard.Location = new Point(pnlCurrentList.btnAddCard.Location.X,
                    pnlCurrentList.btnAddCard.Location.Y - 40);
            pnlCurrentList.btnDeleteList.Location = new Point(pnlCurrentList.btnDeleteList.Location.X,
                pnlCurrentList.btnDeleteList.Location.Y - 40);
            pnlCurrentList.Size = new Size(pnlCurrentList.Size.Width, pnlCurrentList.Size.Height - 40);
        }
        static public void moveListAfterDelete(Point deletedLocation, Size deleteSize, List<list> listOfDanhSach)
        {
            int i = 0;
            while (i < listOfDanhSach.Count)
            {
                if (listOfDanhSach[i].Location.X > deletedLocation.X)
                {
                    listOfDanhSach[i].Location = new Point(listOfDanhSach[i].Location.X - deleteSize.Width - 10, 50);
                }
                i++;
            }
        }
    }
}
