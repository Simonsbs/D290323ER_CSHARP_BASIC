using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops {
	internal static class MyFunctions {
		public static string hostURL = "https://bestdev.co.il";

		public static int Sqr(int x) {
			return x * x;
		}

		public static decimal Add(decimal a, decimal b) {
			return a + b;
		}

		public static string Encode(string value, string key) {
			return value + "_" + key;
		}
	}
}
