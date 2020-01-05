using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GAb.models
{
	public class Student
	{


        [AutoIncrement, PrimaryKey]
		public int ID { set; get; }

		public String f_name { set; get; }
		public String cne { set; get; }
		public String l_name { set; get; }

		[Unique]
		public String email { set; get; }
		public String phone { set; get; }
		
		public int optionID { set; get; }

		public Student(string cne,string f_name, string l_name, string email, string phone, int optionID)
		{
			this.cne = cne;
			this.f_name = f_name;
			this.l_name = l_name;
			this.email = email;
			this.phone = phone;
			this.optionID = optionID;
		}
        public Student(string f_name, string l_name, string email, string phone, int optionID)
        {
            this.cne = cne;
            this.f_name = f_name;
            this.l_name = l_name;
            this.email = email;
            this.phone = phone;
            this.optionID = optionID;
        }
        public Student()
		{
		}


    }
}
