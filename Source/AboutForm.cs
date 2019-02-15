using System;
using System.Windows.Forms;

namespace NamuDarbaiForm1
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}