namespace NamuDarbaiForm1
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox ilgis;
		private System.Windows.Forms.TextBox masyvasElement;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem issaugotiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darbasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pakartotiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pabaigaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem atidarytiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem apieToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		private void InitializeComponent() {
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.ilgis = new System.Windows.Forms.TextBox();
			this.masyvasElement = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.atidarytiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.issaugotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darbasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pakartotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pabaigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.apieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(24, 57);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Rodyk masyvą";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(24, 100);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Apdorok masyva";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.Location = new System.Drawing.Point(24, 164);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(119, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Surikiuok did. tvarka";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.Location = new System.Drawing.Point(24, 206);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(119, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Surikiuok maz. tvarka";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(472, 48);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(217, 168);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = "";
			// 
			// ilgis
			// 
			this.ilgis.Location = new System.Drawing.Point(115, 25);
			this.ilgis.Name = "ilgis";
			this.ilgis.Size = new System.Drawing.Size(60, 20);
			this.ilgis.TabIndex = 7;
			this.ilgis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IlgisTextEnter);
			// 
			// masyvasElement
			// 
			this.masyvasElement.Enabled = false;
			this.masyvasElement.Location = new System.Drawing.Point(115, 54);
			this.masyvasElement.Name = "masyvasElement";
			this.masyvasElement.Size = new System.Drawing.Size(60, 20);
			this.masyvasElement.TabIndex = 8;
			this.masyvasElement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasyvasElementTextEnter);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.failasToolStripMenuItem,
			this.darbasToolStripMenuItem,
			this.apieToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(732, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// failasToolStripMenuItem
			// 
			this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.atidarytiToolStripMenuItem,
			this.issaugotiToolStripMenuItem});
			this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
			this.failasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.failasToolStripMenuItem.Text = "Failas";
			// 
			// atidarytiToolStripMenuItem
			// 
			this.atidarytiToolStripMenuItem.Name = "atidarytiToolStripMenuItem";
			this.atidarytiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.atidarytiToolStripMenuItem.Text = "Atidaryti";
			this.atidarytiToolStripMenuItem.Click += new System.EventHandler(this.AtidarytiToolStripMenuItemClick);
			// 
			// issaugotiToolStripMenuItem
			// 
			this.issaugotiToolStripMenuItem.Name = "issaugotiToolStripMenuItem";
			this.issaugotiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.issaugotiToolStripMenuItem.Text = "Issaugoti";
			this.issaugotiToolStripMenuItem.Click += new System.EventHandler(this.IssaugotiToolStripMenuItemClick);
			// 
			// darbasToolStripMenuItem
			// 
			this.darbasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.pakartotiToolStripMenuItem,
			this.pabaigaToolStripMenuItem});
			this.darbasToolStripMenuItem.Name = "darbasToolStripMenuItem";
			this.darbasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.darbasToolStripMenuItem.Text = "Darbas";
			// 
			// pakartotiToolStripMenuItem
			// 
			this.pakartotiToolStripMenuItem.Name = "pakartotiToolStripMenuItem";
			this.pakartotiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.pakartotiToolStripMenuItem.Text = "Pakartoti";
			this.pakartotiToolStripMenuItem.Click += new System.EventHandler(this.PakartotiToolStripMenuItemClick);
			// 
			// pabaigaToolStripMenuItem
			// 
			this.pabaigaToolStripMenuItem.Name = "pabaigaToolStripMenuItem";
			this.pabaigaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.pabaigaToolStripMenuItem.Text = "Pabaiga";
			this.pabaigaToolStripMenuItem.Click += new System.EventHandler(this.PabaigaToolStripMenuItemClick);
			// 
			// apieToolStripMenuItem
			// 
			this.apieToolStripMenuItem.Name = "apieToolStripMenuItem";
			this.apieToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.apieToolStripMenuItem.Text = "Autorius";
			this.apieToolStripMenuItem.Click += new System.EventHandler(this.ApieToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Masyvo ilgis";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.masyvasElement);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.ilgis);
			this.groupBox1.Location = new System.Drawing.Point(219, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(193, 90);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Masyvo ivedimas";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Prideti elementa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 14;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(219, 164);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(193, 79);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Teigiami nelygiai elementai";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 12);
			this.label6.TabIndex = 15;
			this.label6.Text = "Vidurkis";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "Suma";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Masyvas";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 258);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "NamuDarbaiForm1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
