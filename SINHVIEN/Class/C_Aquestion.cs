using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SINHVIEN.Class
{
    public class C_Aquestion
    {

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Số lượng câu trả lời
        /// </summary>
        private int numberAns = 0;

        public int NumberAns
        {
            get { return numberAns; }
            set { numberAns = value; }
        }

        //danh sach cau tra loi
        private DA[] listAns = new DA[6];

        public DA[] ListAns
        {
            get { return listAns; }
            set { listAns = value; }
        }
      
        /// <summary>
        /// câu hỏi
        /// </summary>
        private string question;

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        

        /// <summary>
        /// câu này có được trộn hay k o
        /// </summary>
        private bool isMix;

        public bool IsMix
        {
            get { return isMix; }
            set { isMix = value; }
        }
    }
}

public struct DA
{
    public  char frefix;
    public  string answer;
    public  bool status;
    public  bool isCheck;
};
