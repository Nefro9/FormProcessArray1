using System;
using System.Windows.Forms;

namespace NamuDarbaiForm1
{
	public partial class SaveFileForm : Form
	{
		string text;
		
		public SaveFileForm(string saveText)
		{
			InitializeComponent();
			
			text = saveText;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			FileManager FileM  = new FileManager();
			
			text = dateTimePicker1.Text +Environment.NewLine + text;
			FileM.saveFile(text);
			
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
