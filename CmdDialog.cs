using System;
using Gtk;
using System.Text.RegularExpressions;

namespace BBB
{
	public partial class CmdDialog : Gtk.Dialog
	{
		public String lineOut = String.Empty;

		public CmdDialog ()
		{
			this.Build ();
		}

		public void PrintOut(String txt){
			label1.Text += txt + "\n";
			//Console.WriteLine (txt);
			//label1.Text = label1.Text.Replace ("  ", "__");
			label1.Text = Regex.Replace(label1.Text,  @"[ ]{2,}", "\t");
			//label1.Text = Regex.Replace(label1.Text,  @"[ ]{2,}", String.Empty);
			//label1.Text = label1.Text.Replace (" ", "_");
		}

	}
}

