using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GAb.config
{
	class Config
	{
		public static String DB_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "absence.db3");
	}
}
