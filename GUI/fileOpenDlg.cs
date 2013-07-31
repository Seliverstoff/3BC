//  Backburner Bat Creater (3BC)
//
//  http://seliverstoff.blogspot.ru/search/label/3BC
//
//  Author: Maxim A. Seliverstov (aka Seliverstoff)
//  E-Mail: maxim@seliverstoff.ru
//
//  This program is free software; you can redistribute it and/or
//  modify it under the terms of the GNU General Public License
//  as published by the Free Software Foundation; either version 2
//  of the License, or (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
//  All Rights Reserved. Backburner(R) is a registered trademark of Autodesk, Inc.

using System;
using Gtk;
using Gdk;
using System.IO;
using System.Configuration;

namespace BBB
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class fileOpenDlg : Gtk.Bin
	{

		public event EventHandler Change;
		public event EventHandler OpenDir;

		// Режим работы диалога
		// true  = выбор файлов
		// false = выбор директории
		public Boolean CheckType { get; set; }

		public String filterName { get; set; }
		public String filterExec { get; set; }
		
		public fileOpenDlg ()
		{
			this.Build ();
		}

		public String Text
		{
			get { return entry_path.Text; }
			set { entry_path.Text = value; }
		}

		protected virtual void OnChange(EventArgs e){
			if (Change != null) {
				Change (this, e);
			}
		}

		protected virtual void OnOpenDir(EventArgs e){
			if (OpenDir != null) {
				OpenDir (this, e);
			}
		}

		protected void OnEntryPathChanged (object sender, EventArgs e)
		{
			OnChange (EventArgs.Empty);
			CheckPath (entry_path, entry_path.Text, pathType.File);
		}

		private Boolean CheckPath(Gtk.Entry field, String path, pathType type){

			Boolean check = false;
			if (CheckType == true){
				check = File.Exists (path);
			}else{
				check = Directory.Exists (path);
			}

			if (check) {
				SetBlackColor (field);
				return true;
			} else {
				SetRedColor (field);
				return false;
			}


		}

		private void SetRedColor (Gtk.Entry field)
		{
			field.ModifyText (StateType.Normal, new Gdk.Color (255, 0, 0)); // Red Color
		}

		private void SetBlackColor (Gtk.Entry field)
		{
			field.ModifyText (StateType.Normal, new Gdk.Color (0, 0, 0));  // Black Color
		}

		protected void OnButtonOpenClicked (object sender, EventArgs e)
		{
			OnOpenDir (EventArgs.Empty);

			FileChooserAction ActOp;
			String tmpTitle = String.Empty;

			if (CheckType == true) {
				ActOp = FileChooserAction.Open;
				tmpTitle = "Укажите файл " + filterName;
			} else {
				ActOp = FileChooserAction.SelectFolder;
				tmpTitle = "Укажите директорию";
			}

			Gtk.Window[] tmpWin = Gtk.Window.ListToplevels ();

			Gtk.FileChooserDialog fc=
				new Gtk.FileChooserDialog(tmpTitle,
				                          tmpWin[0],
				                          ActOp,
				                          "Выход",ResponseType.Cancel,
				                          "Открыть",ResponseType.Accept);

			if (entry_path.Text!=String.Empty) {
				fc.SetCurrentFolder (System.IO.Path.GetDirectoryName (entry_path.Text));
			}

			if (CheckType == true) {

				if (filterName != String.Empty && filterExec != String.Empty) {
					Gtk.FileFilter filter = new Gtk.FileFilter (); 
					filter.Name = filterName; 
					filter.AddPattern (filterExec);       
					fc.AddFilter (filter);
				}

				Gtk.FileFilter filter2 = new Gtk.FileFilter (); 
				filter2.Name = "Все файлы (*.*)"; 
				filter2.AddPattern ("*.*");       
				fc.AddFilter (filter2);

			}

			if (fc.Run() == (int)ResponseType.Accept) 
			{
				if (CheckType == true) {
					entry_path.Text = fc.Filename;
				} else {
					entry_path.Text = fc.Filename + "\\";
				}
			}
			fc.Destroy();
		}
		
	}
}

