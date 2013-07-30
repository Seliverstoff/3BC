using System;
using Gtk;
using System.IO;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using System.Globalization;

public partial class MainWindow: Gtk.Window
{	

	static BBB.CmdDialog dlgOut;
	private String cmdName = String.Empty;
	private String cmdArg = String.Empty;
	private Boolean erroStatus = false;
	private String engineName = String.Empty;
	public BBB.Renders render = new BBB.Renders ();
	private String tmpStr = String.Empty;
	private String[] groupList = {};
	public Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
	private Dictionary<String, BBB.GUI_renders> GUI_render_settings_list = new Dictionary<string, BBB.GUI_renders> ();
	private Dictionary<String, String> blender_def_param = new Dictionary<String, String> ();
	private Dictionary<String, String> vray_def_param = new Dictionary<String, String> ();
	private Dictionary<String, String> vue_def_param = new Dictionary<String, String> ();
	private Dictionary<String, String> as_def_param = new Dictionary<String, String> ();


	public String strGroup = String.Empty;
	public String strServers = String.Empty;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		// Add GUI setting for Renders
		// Vray, Blender, Vue, AS
		GUI_render_settings_list.Add ("Vray", gui_vray);
		GUI_render_settings_list.Add ("Blender", gui_blender);
		GUI_render_settings_list.Add ("Vue", gui_vue);
		GUI_render_settings_list.Add ("AS", gui_as);

		CreateDefParam ();

		entry_cmdjob_path.Text = System.Configuration.ConfigurationManager.AppSettings["bb_path"];
		entry_list_path.Text = System.Configuration.ConfigurationManager.AppSettings["list_path"];
		entry_bat_path.Text = System.Configuration.ConfigurationManager.AppSettings["bat_path"];
		spin_start_frame.Value = int.Parse (System.Configuration.ConfigurationManager.AppSettings ["default_start_frame"]);
		spin_end_frame.Value = int.Parse (System.Configuration.ConfigurationManager.AppSettings ["default_end_frame"]);
		spin_step_frame.Value = int.Parse (System.Configuration.ConfigurationManager.AppSettings ["default_step_frame"]);
		//default_timeout

		strGroup = System.Configuration.ConfigurationManager.AppSettings["group"];
		strServers = System.Configuration.ConfigurationManager.AppSettings["servers"];

		groupList = System.Configuration.ConfigurationManager.AppSettings ["group"].Split (';');
		for(int i=0; i<groupList.Length; ++i){
			combobox_group.AppendText (groupList[i]);
		}

		combobox_group.Active = int.Parse (System.Configuration.ConfigurationManager.AppSettings["default_group"]);

		foreach(KeyValuePair<String, BBB.en> kvp in render.engine )
		{
			combobox_render.AppendText (render.engine [kvp.Key].engineName);
		} 

		combobox_render.Active = int.Parse(System.Configuration.ConfigurationManager.AppSettings["default_renders"]);
		entry_scene_path.Text = System.Configuration.ConfigurationManager.AppSettings[engineName+"_scene_path"];
		entry_render_path.Text = System.Configuration.ConfigurationManager.AppSettings[engineName+"_path"];


		gui_blender.SetDef (blender_def_param);
		gui_vray.SetDef (vray_def_param);
		gui_vue.SetDef (vue_def_param);
		gui_as.SetDef (as_def_param);

		UpdateList (true);
		UpdateBat ();

	}

	protected void CreateDefParam(){
		int count = Enum.GetValues (typeof(BBB.DefParamBlender)).Length;
		String nParam = String.Empty;
		for(int i=0; count>i; ++i){
			nParam = Enum.GetName (typeof(BBB.DefParamBlender), i);
			blender_def_param.Add (nParam, System.Configuration.ConfigurationManager.AppSettings[nParam]);
		}

		count = Enum.GetValues (typeof(BBB.DefParamVray)).Length;
		nParam = String.Empty;
		for(int i=0; count>i; ++i){
			nParam = Enum.GetName (typeof(BBB.DefParamVray), i);
			vray_def_param.Add (nParam, System.Configuration.ConfigurationManager.AppSettings[nParam]);

		}

		count = Enum.GetValues (typeof(BBB.DefParamVue)).Length;
		nParam = String.Empty;
		for(int i=0; count>i; ++i){
			nParam = Enum.GetName (typeof(BBB.DefParamVue), i);
			vue_def_param.Add (nParam, System.Configuration.ConfigurationManager.AppSettings[nParam]);
		}

		count = Enum.GetValues (typeof(BBB.DefParamAS)).Length;
		nParam = String.Empty;
		for(int i=0; count>i; ++i){
			nParam = Enum.GetName (typeof(BBB.DefParamAS), i);
			as_def_param.Add (nParam, System.Configuration.ConfigurationManager.AppSettings[nParam]);
		}

	}

	public void UpdateDefParam(){

		int count = Enum.GetValues (typeof(BBB.DefParamBlender)).Length;
		String nParam = String.Empty;
		for(int i=0; count>i; ++i){
			nParam = Enum.GetName (typeof(BBB.DefParamBlender), i);
			config.AppSettings.Settings [nParam].Value = gui_blender.def_out[nParam];
		}


		count = Enum.GetValues (typeof(BBB.DefParamVray)).Length;
		nParam = String.Empty;
		for(int j=0; count>j; ++j){
			nParam = Enum.GetName (typeof(BBB.DefParamVray), j);
			if(gui_vray.def_out.ContainsKey(nParam)){
				config.AppSettings.Settings [nParam].Value = gui_vray.def_out[nParam];
			}
		}

		count = Enum.GetValues (typeof(BBB.DefParamVue)).Length;
		nParam = String.Empty;
		for(int j=0; count>j; ++j){
			nParam = Enum.GetName (typeof(BBB.DefParamVue), j);
			if(gui_vue.def_out.ContainsKey(nParam)){
				//Console.WriteLine ("param = " + nParam);
				config.AppSettings.Settings [nParam].Value = gui_vue.def_out[nParam];
			}
		}

		count = Enum.GetValues (typeof(BBB.DefParamAS)).Length;
		nParam = String.Empty;
		for(int j=0; count>j; ++j){
			nParam = Enum.GetName (typeof(BBB.DefParamAS), j);
			if(gui_as.def_out.ContainsKey(nParam)){
				//Console.WriteLine ("param = " + nParam);
				config.AppSettings.Settings [nParam].Value = gui_as.def_out[nParam];
			}
		}

		config.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection("appSettings");
	}

	protected void SaveAppSettings(String sName, String sValue){
		config.AppSettings.Settings [sName].Value = sValue;
		config.Save(ConfigurationSaveMode.Modified);
		ConfigurationManager.RefreshSection("appSettings");
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnCheckbuttonListOnToggled (object sender, EventArgs e)
	{
		UpdateBat ();

		if (checkbutton_list_on.Active) {
			entry_list_path.Sensitive = true;
			button_list_save.Sensitive = true;
		} else {
			entry_list_path.Sensitive = false;
			button_list_save.Sensitive = false;
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

	private void OpenPath(Gtk.Entry field, String filterName, String filterExec){
		Gtk.FileChooserDialog fc=
			new Gtk.FileChooserDialog("Укажите файл - "+filterName,
			                          this,
			                          FileChooserAction.Open,
			                          "Выход",ResponseType.Cancel,
			                          "Открыть",ResponseType.Accept);

		fc.SetCurrentFolder (System.IO.Path.GetDirectoryName(field.Text));

		if(filterName!=String.Empty && filterExec!=String.Empty){
			Gtk.FileFilter filter = new Gtk.FileFilter(); 
			filter.Name=filterName; 
			filter.AddPattern(filterExec);       
			fc.AddFilter(filter);
		}

		Gtk.FileFilter filter2 = new Gtk.FileFilter(); 
		filter2.Name="Все файлы (*.*)"; 
		filter2.AddPattern("*.*");       
		fc.AddFilter(filter2);

		if (fc.Run() == (int)ResponseType.Accept) 
		{
			System.IO.FileStream file=System.IO.File.OpenRead(fc.Filename);
			field.Text = fc.Filename;
			file.Close();
		}
		fc.Destroy();
	}


	protected void OnButtonRenderFileClicked (object sender, EventArgs e)
	{
		OpenPath(entry_render_path, render.engine [engineName].filter_exec_render_text, render.engine [engineName].filter_exex_render_exec);
	}

	protected void OnButtonCmdjobFileClicked (object sender, EventArgs e)
	{
		OpenPath(entry_cmdjob_path, "Файл программы cmdjob.exe", "cmdjob.exe");
	}

	protected void OnButtonSceneFileClicked (object sender, EventArgs e)
	{
		OpenPath(entry_scene_path, render.engine [engineName].filter_scene_file_text, render.engine [engineName].filter_scene_file_exec);
	}

	protected void OnButtonBatSaveClicked (object sender, EventArgs e)
	{
		OpenPath(entry_bat_path, "Временный *.bat файл", "*.bat");
	}

	protected void OnButtonListSaveClicked (object sender, EventArgs e)
	{
		OpenPath(entry_list_path, "Временный *.list файл", "*.list");
	}

	protected void OnEntryCmdjobPathChanged (object sender, EventArgs e)
	{
		if (CheckPath (entry_cmdjob_path, entry_cmdjob_path.Text, "cmdjob.exe")) {
			SaveAppSettings ("bb_path", entry_cmdjob_path.Text);
		}
		UpdateBat ();
	}

	protected void OnEntryRenderPathChanged (object sender, EventArgs e)
	{
		if(CheckPath (entry_render_path, entry_render_path.Text, "cmdjob.exe"))
		{
			SaveAppSettings (engineName+"_path", entry_render_path.Text);
		}
		UpdateBat ();
	}

	protected void OnEntryScenePathChanged (object sender, EventArgs e)
	{
		if (CheckPath (entry_scene_path, entry_scene_path.Text, "cmdjob.exe")) {
			SaveAppSettings (engineName + "_scene_path", entry_scene_path.Text);
		}
		UpdateBat ();
	}

	protected void OnEntryBatPathChanged (object sender, EventArgs e)
	{
		CheckPath (entry_bat_path, entry_bat_path.Text, "cmdjob.exe");
		SaveAppSettings ("bat_path", entry_bat_path.Text);
		UpdateBat ();
	}

	protected void OnEntryListPathChanged (object sender, EventArgs e)
	{
		CheckPath (entry_list_path, entry_list_path.Text, "cmdjob.exe");
		SaveAppSettings ("list_path", entry_list_path.Text);
		UpdateBat ();
	}

	private Boolean CheckPath(Gtk.Entry field, String path, String fName){
		if (File.Exists (path)) {
			SetBlackColor (field);
			return true;
		} else {
			SetRedColor (field);
			return false;
		}
	}

	private Boolean CheckSettings(){
		return true;
	}

	protected void OnButtonStartClicked (object sender, EventArgs e)
	{
		PrintListFile ();
		PrintBatFile ();
		dlgOut = new BBB.CmdDialog ();


		System.Diagnostics.Process render = new System.Diagnostics.Process ();
		render.StartInfo.UseShellExecute = false;
		render.StartInfo.RedirectStandardOutput = true;
		render.StartInfo.RedirectStandardError = true;;
		render.EnableRaisingEvents = false;
		render.StartInfo.FileName = cmdName;
		render.StartInfo.Arguments = cmdArg;

		render.ErrorDataReceived += new DataReceivedEventHandler(output);
		render.OutputDataReceived += new DataReceivedEventHandler(output);

		render.Start ();
		render.BeginErrorReadLine();
		render.BeginOutputReadLine();
		render.WaitForExit ();

		if (dlgOut.Run() == (int)ResponseType.Ok){

		}

		DeleteListFile ();
		DeleteBatFile ();


		dlgOut.Destroy();


	}

	private void DeleteListFile(){
		String outDir = entry_list_path.Text;
		if (File.Exists (outDir)) {
			File.Delete (outDir);
			//Console.WriteLine ("Delete - " + entry_list_path.Text);
		}else{
			//Console.WriteLine ("Not file delete");
		}
	}

	private void DeleteBatFile(){
		String outDir = entry_bat_path.Text;
		if (File.Exists (outDir)) {
			File.Delete (outDir);
			//Console.WriteLine ("Delete - " + entry_bat_path.Text);
		}else{
			//Console.WriteLine ("Not file delete");
		}
	}

	private void PrintListFile(){
		String outDir = System.IO.Path.GetDirectoryName (entry_list_path.Text);

		using (System.IO.StreamWriter file = new System.IO.StreamWriter(@entry_list_path.Text, false))
		{
			file.WriteLine(textview_list_out.Buffer.Text);
			file.Close ();
		} 

	}

	private void PrintBatFile(){
		String outDir = System.IO.Path.GetDirectoryName (entry_bat_path.Text);
		String content = textview_bat_out.Buffer.Text;
		content = content.Replace ("%", "%%");
		using (System.IO.StreamWriter file = new System.IO.StreamWriter(@entry_bat_path.Text, false))
		{
			file.WriteLine(content);
		} 
	}


	private void output(object sender, DataReceivedEventArgs e) {
		dlgOut.PrintOut (e.Data);
	}

	private void UpdateBat()
	{
		textview_bat_out.Buffer.Text = String.Empty;
		cmdName = String.Empty;
		cmdArg = String.Empty;

		if(File.Exists (entry_cmdjob_path.Text)){
			cmdName = "\""+entry_cmdjob_path.Text+"\"";
			erroStatus = true;
		}else{
			cmdName += "\n\t>>>ERROR PATH, CHECK PATH CMDJOB<<<\n";
			erroStatus = false;
		}

		cmdArg += " -jobName: \""+entry_scene_name.Text+"\"";
		cmdArg += " -description: \""+entry_scene_description.Text+"\"";
		
		if(checkbutton_list_on.Active){
			cmdArg += " -taskList: \""+entry_list_path.Text+"\"";
			cmdArg += " -taskName:1";
		}

		String renderPath = entry_render_path.Text;

		if(File.Exists (renderPath)){
			String workPath = System.IO.Path.GetDirectoryName (renderPath);
			cmdArg += " -workPath: \""+workPath+"\"";
			String workFile = System.IO.Path.GetFileName (entry_render_path.Text);
			cmdArg += " \""+workFile+"\"";
			erroStatus = true;
		}else{
			cmdArg += "\n\t>>>ERROR PATH, CHECK PATH FOR RENDER NODE<<<\n";
			erroStatus = false;
		}

		if(engineName!=String.Empty){
			Console.WriteLine ("engineName = "+engineName);
			cmdArg += render.engine [engineName].atr_scene_file.Replace ("%X%", entry_scene_path.Text);
			cmdArg += " " + GUI_render_settings_list [engineName].argStr[0];
			if(GUI_render_settings_list[engineName].renderEnable==true){
				if(spin_step_frame.Value>1){
					tmpStr = render.engine [engineName].atr_range_frame;
					tmpStr = tmpStr.Replace("%X%", "%tp2");
					tmpStr = tmpStr.Replace("%Y%", "%tp3");
					tmpStr += GUI_render_settings_list [engineName].argStr[1];
				}else{
					tmpStr = render.engine [engineName].atr_single_frame;
					tmpStr = tmpStr.Replace("%X%", "%tp2");
				}
			}else{
				tmpStr = String.Empty;
			}

			cmdArg += tmpStr;

		}
		
		textview_bat_out.Buffer.Text = cmdName + cmdArg;

		if(erroStatus){
			button_start.Sensitive = true;
		}else{
			button_start.Sensitive = false;
		}
		
	}

	private void UpdateList(Boolean refs)
	{
		if(checkbutton_list_refrash.Active || refs==false){
			textview_list_out.Buffer.Text = String.Empty;
		}
		
		int start = Convert.ToInt32(spin_start_frame.Value);
		int end = Convert.ToInt32(spin_end_frame.Value);
		int step = Convert.ToInt32(spin_step_frame.Value);
		int task = 0;
		int _s = 0;
		int _e = 0;
		String ListOut = String.Empty;

		for (int i = start; i <= end; i=i+step) {
			task += 1;
			_s = ((task*step)-step)+start;
			_e = ((task*step)-1)+start;

			if (_e > end) {
				_e = end;
			}

			if(spin_step_frame.Value>1){

				if (i == (end-1)) {
					ListOut += "Task - " + (task+1) + "("+ (_e-1) + "-"+ _e +")"+"\t"+(_e-1)+"\t"+_e+"\n";
				}else{
					ListOut += "Task - " + task + "("+ _s + "-"+ _e +")"+"\t"+_s+"\t"+_e+"\n";
				}

			}else{

				if (i == (end-1)) {
					ListOut += "Task - " + (task+1) + "("+ _e +")"+"\t"+_e+"\n";
				}else{
					ListOut += "Task - " + task + "("+ _e +")"+"\t"+_e+"\n";
				}

			}
		}

		if(checkbutton_list_refrash.Active || refs==false){
			textview_list_out.Buffer.Text = ListOut;
		}

		if(textview_list_out.Buffer.Text.Length>1){
			saveAction_list.Sensitive = true;
			clearAction_list.Sensitive = true;
		}else{
			saveAction_list.Sensitive = true;
			clearAction_list.Sensitive = false;
		}
	
	}

	protected void OnSpinStartFrameChanged (object sender, EventArgs e)
	{
		CheckPins ();
	}

	protected void OnSpinEndFrameChanged (object sender, EventArgs e)
	{
		CheckPins ();
	}

	protected void OnSpinStepFrameChanged (object sender, EventArgs e)
	{
		CheckPins ();
	}

	private void CheckPins()
	{
		if(spin_start_frame.Value>=spin_end_frame.Value){
			spin_start_frame.Value = spin_end_frame.Value - 1;
		}

		if(spin_end_frame.Value<=spin_start_frame.Value){
			spin_end_frame.Value = spin_start_frame.Value + 1;
		}

		if((spin_end_frame.Value-spin_start_frame.Value)<=spin_step_frame.Value){
			spin_step_frame.Value = (spin_end_frame.Value - spin_start_frame.Value);
		}

		if(spin_step_frame.Value==0){
			spin_step_frame.Value = 1;
		}

		//if(spin_step_frame.Value==1){
			UpdateBat ();
		//}
		
		UpdateList (true);
	}

	protected void OnEntrySceneNameChanged (object sender, EventArgs e)
	{
		UpdateBat ();
	}

	protected void OnEntrySceneDescriptionChanged (object sender, EventArgs e)
	{
		UpdateBat ();
	}

	protected void OnSpinStartFrameFocusOutEvent (object o, FocusOutEventArgs args)
	{
		CheckPins ();
	}

	protected void OnSpinEndFrameFocusOutEvent (object o, FocusOutEventArgs args)
	{
		CheckPins ();
	}

	protected void OnSpinStepFrameFocusOutEvent (object o, FocusOutEventArgs args)
	{
		CheckPins ();
	}

	protected void OnCheckbuttonListRefrashToggled (object sender, EventArgs e)
	{
		if (checkbutton_list_refrash.Active) {
			refreshAction_list.Sensitive = false;
		} else {
			refreshAction_list.Sensitive = true;
		}
	}

	protected void OnRefreshActionListActivated (object sender, EventArgs e)
	{
		UpdateList (false);
	}


	protected void OnSaveActionListActivated (object sender, EventArgs e)
	{
		Gtk.FileChooserDialog fc= 
			new Gtk.FileChooserDialog("Сохранение файла", 
			                          this, FileChooserAction.Save, 
			                          "Отмена", ResponseType.Cancel, 
			                          "Сохранить", ResponseType.Accept); 

		//fc.SetCurrentFolder (entry_list_path.Text);

		if (fc.Run() == (int)ResponseType.Accept) 
		{
			// Обработка
		} 
		fc.Destroy();
	}

	protected void OnClearActionListActivated (object sender, EventArgs e)
	{
		textview_list_out.Buffer.Text = String.Empty;
		clearAction_list.Sensitive = false;
		saveAction_list.Sensitive = false;
	}

	protected void OnComboboxRenderChanged (object sender, EventArgs e)
	{
		//Console.WriteLine ("selected - " + combobox_render.Active);
		engineName = Enum.GetName (typeof(BBB.Renders.engEn), combobox_render.Active);
		label_render_path.Text = render.engine [engineName].label_path;
		entry_scene_path.Text = System.Configuration.ConfigurationManager.AppSettings[engineName+"_scene_path"];
		entry_render_path.Text = System.Configuration.ConfigurationManager.AppSettings[engineName+"_path"];
		SaveAppSettings ("default_renders", Convert.ToString(combobox_render.Active));
		GtkLabel_render_settings.LabelProp = "Настройки рендера (" + render.engine[engineName].engineName + ")";
		ShowGuiSettings (engineName);
		//render.engine [engineName].GUI_Settings ();
	}

	private void ShowGuiSettings(String eName){
		foreach( KeyValuePair<String, BBB.GUI_renders> kvp in GUI_render_settings_list )
		{
			//Console.WriteLine (kvp.Value.Name + " - " + kvp.Value.Visible + " - " + kvp.Key + " - " + eName);
			if(kvp.Key==eName){
				kvp.Value.Visible = true;
			}else{
				kvp.Value.Visible = false;
			}
		}

	}
	

	protected void OnAction1Activated (object sender, EventArgs e)
	{
		BBB.About aboutDlg = new BBB.About ();
		if (aboutDlg.Run () == (int)ResponseType.Ok) {

		}
		aboutDlg.Destroy ();
	}

	protected void OnActionExitActivated (object sender, EventArgs e)
	{
		//SaveAppSettings ();
		Application.Quit ();
		//a.RetVal = true;
	}

	protected void OnActionHelpActivated (object sender, EventArgs e)
	{
		BBB.Help helpDlg = new BBB.Help ();
		if (helpDlg.Run () == (int)ResponseType.Ok) {

		}
		helpDlg.Destroy ();
	}

	protected void OnButtonEditServersClicked (object sender, EventArgs e)
	{
		BBB.ListEditor listDlg = new BBB.ListEditor (strServers);
		if(listDlg.Run() == (int)ResponseType.Ok){

		}
		listDlg.Destroy ();
	}

	protected void OnButtonEditGroupClicked (object sender, EventArgs e)
	{
		BBB.ListEditor listDlg = new BBB.ListEditor (strGroup);
		if(listDlg.Run() == (int)ResponseType.Ok){

		}
		listDlg.Destroy ();
	}

	protected void OnGuiBlenderChangeWidget (object sender, EventArgs e)
	{
		UpdateBat ();
		UpdateDefParam ();
	}

	protected void OnGuiVrayChangeWidget (object sender, EventArgs e)
	{
		UpdateBat ();
		UpdateDefParam ();
	}


	protected void OnGuiVueChangeWidget (object sender, EventArgs e)
	{
		UpdateBat ();
		UpdateDefParam ();
	}

	protected void OnGuiAsChangeWidget (object sender, EventArgs e)
	{
		UpdateBat ();
		UpdateDefParam ();
	}
}