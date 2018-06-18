using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
	public class Class1
	{
		private string _connectionString;
		public Class1()
		{
			if (string.IsNullOrWhiteSpace(_connectionString))
				_connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		}
		public void TestConnection()
		{

		}
	}
}
