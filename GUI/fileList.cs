using System;
using Gtk;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class fileList : Gtk.Bin
	{
		public String Text { set; get; }

		public fileList ()
		{
			this.Build ();
		}
		
		protected void OnButtonOpenEditorClicked (object sender, EventArgs e)
		{
			FileListEditor flDlg = new FileListEditor ();

			if (flDlg.Run() == (int)ResponseType.Accept) 
			{
				// Обработка
			} 
			flDlg.Destroy();
		}
	}
}

