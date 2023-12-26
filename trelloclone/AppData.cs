using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trelloclone
{
    public class AppData
    {
        private string title;
        private string describeContent;
        private string activityContent;
        private string label;
        private List<string> listOfMember = new List<string>();
        private List<string> listOfToDoList = new List<string>();
        private bool existed;
        private int indexTable;
        private int indexDanhSach;
        private int indexCard;
        private bool createdCard = true; // ktra card tao lan dau hay sao

        //databse
        private int userID;
        private int cardID;

        public string Title { get => title; set => title = value; }
        public string DescribeContent { get => describeContent; set => describeContent = value; }
        public string ActivityContent { get => activityContent; set => activityContent = value; }
        public string Label { get => label; set => label = value; }
        public List<string> ListOfMember { get => listOfMember; set => listOfMember = value; }
        public List<string> ListOfToDoList { get => listOfToDoList; set => listOfToDoList = value; }
        public bool Existed { get => existed; set => existed = value; }
        public int IndexTable { get => indexTable; set => indexTable = value; }
        public int IndexDanhSach { get => indexDanhSach; set => indexDanhSach = value; }
        public int IndexCard { get => indexCard; set => indexCard = value; }
        public bool CreatedCard { get => createdCard; set => createdCard = value; }
        public int UserID { get => userID; set => userID = value; }
        public int CardID { get => cardID; set => cardID = value; }

        public AppData()
        {
            title = "Tiêu đề";
            describeContent = "";
            activityContent = "";
            label = "";
            Existed = true;
        }

        public AppData(string title, string describeContent, string activityContent, string label, List<string> listOfMember,
            List<string> listOfToDoList)
        {
            Title = title;
            DescribeContent = describeContent;
            ActivityContent = activityContent;
            Label = label;
            ListOfMember = listOfMember;
            ListOfToDoList = listOfToDoList;
        }
        public override string ToString()
        {
            string a = $"{IndexTable}/{IndexDanhSach}/{IndexCard}/{title}/{describeContent}/{activityContent}/";
            if (listOfMember.Count == 0)
                a += "/";
            else
            {
                foreach (var member in listOfMember)
                {
                    if (listOfMember.IndexOf(member) + 1 == listOfMember.Count)
                    {
                        a += $"{member}";
                    }
                    else
                        a += $"{member}_";
                }
            }

            a += $"{label}/";

            if (listOfToDoList.Count == 0)
                a += "/";
            else
            {
                foreach (var job in listOfToDoList)
                {
                    if (listOfToDoList.IndexOf(job) + 1 == listOfToDoList.Count)
                    {
                        a += $"{job}/";

                    }
                    else
                        a += $"{job}_";
                }
            }

            return a;

        }
        ~AppData()
        {


        }


    }
}
