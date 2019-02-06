using System;
using System.IO;
namespace emailreader
{
	public class EmailReader
	{
		public static void Main ()
		{
			int line4 = 0;
			string[] Lines1 = File.ReadAllLines(@"C:\Users\andys\Documents\export1.txt");
			string[] Lines2 = File.ReadAllLines(@"C:\Users\andys\Documents\export.txt");
			string[] Lines3 = new string[Lines1.Length];
			for (int line = 0; line < Lines1.Length; line++)
			{
				
					for (int line2 = 0; line2 < Lines2.Length; line2++) {
						if (Lines1 [line].Equals (Lines2 [line2])) {
							line2 = Lines2.Length;
					} else if (line2 == (Lines2.Length -1)) {
						Lines3 [line4] = Lines1 [line];
						line4++;
						}
					}
					
			}
			for(int value = 0; value< Lines3.Length; value ++){
				if (value <= 500) {
					using (System.IO.StreamWriter file = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport.txt", true))
					{
						file.WriteLine(Lines3[value]);
					}
				} else if (value <= 1000) {
					using (System.IO.StreamWriter file1 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy.txt", true))
					{
						file1.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 1500) {
					using (System.IO.StreamWriter file2 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (2).txt", true))
					{
						file2.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 2000) {
					using (System.IO.StreamWriter file3 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (3).txt", true))
					{
						file3.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 2500) {
					using (System.IO.StreamWriter file4 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (4).txt", true))
					{
						file4.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 3000) {
					using (System.IO.StreamWriter file5 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (5).txt", true))
					{
						file5.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 3500) {
					using (System.IO.StreamWriter file6 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (6).txt", true))
					{
						file6.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 4000) {
					using (System.IO.StreamWriter file7 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (7).txt", true))
					{
						file7.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 4500) {
					using (System.IO.StreamWriter file8 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (8).txt", true))
					{
						file8.WriteLine(Lines3[value]);
					}
				}
				else if (value <= 5000) {
					using (System.IO.StreamWriter file9 = 
						new System.IO.StreamWriter(@"C:\Users\andys\Documents\finalexport - Copy (9).txt", true))
					{
						file9.WriteLine(Lines3[value]);
					}
				}

				
			}
			System.Console.WriteLine (line4);
			System.Console.WriteLine (Lines1.Length);

		}
	
	}
}

