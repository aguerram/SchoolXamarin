using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GAb.models
{
	public class Option
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }
		public String title { set; get; }

		public Option(string title)
		{
			this.title = title;
		}

		public Option()
		{
		}
	}

}
