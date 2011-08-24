using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LPTMonitor
{
	/// <summary>
	/// Main form.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox chkData0;
		private System.Windows.Forms.CheckBox chkData1;
		private System.Windows.Forms.CheckBox chkData2;
		private System.Windows.Forms.CheckBox chkData3;
		private System.Windows.Forms.CheckBox chkData7;
		private System.Windows.Forms.CheckBox chkData6;
		private System.Windows.Forms.CheckBox chkData5;
		private System.Windows.Forms.CheckBox chkData4;
		private System.Windows.Forms.CheckBox chkStatus7;
		private System.Windows.Forms.CheckBox chkStatus6;
		private System.Windows.Forms.CheckBox chkStatus5;
		private System.Windows.Forms.CheckBox chkStatus4;
		private System.Windows.Forms.CheckBox chkStatus3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox chkControl3;
		private System.Windows.Forms.CheckBox chkControl2;
		private System.Windows.Forms.CheckBox chkControl1;
		private System.Windows.Forms.CheckBox chkControl0;
		private System.Timers.Timer timerRefresh;
		private System.Windows.Forms.ComboBox comboAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel lblAbout;
		private System.Windows.Forms.CheckBox chkControl4;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.TextBox txtControl;
		private System.Windows.Forms.CheckBox chkControl5;
		private System.Windows.Forms.CheckBox chkStatus2;
		private System.Windows.Forms.CheckBox chkStatus1;
		private System.Windows.Forms.CheckBox chkStatus0;
		private System.Windows.Forms.CheckBox chkControl7;
		private System.Windows.Forms.CheckBox chkControl6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtData = new System.Windows.Forms.TextBox();
			this.chkData7 = new System.Windows.Forms.CheckBox();
			this.chkData6 = new System.Windows.Forms.CheckBox();
			this.chkData5 = new System.Windows.Forms.CheckBox();
			this.chkData4 = new System.Windows.Forms.CheckBox();
			this.chkData3 = new System.Windows.Forms.CheckBox();
			this.chkData2 = new System.Windows.Forms.CheckBox();
			this.chkData1 = new System.Windows.Forms.CheckBox();
			this.chkData0 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkStatus2 = new System.Windows.Forms.CheckBox();
			this.chkStatus1 = new System.Windows.Forms.CheckBox();
			this.chkStatus0 = new System.Windows.Forms.CheckBox();
			this.chkStatus7 = new System.Windows.Forms.CheckBox();
			this.chkStatus6 = new System.Windows.Forms.CheckBox();
			this.chkStatus5 = new System.Windows.Forms.CheckBox();
			this.chkStatus4 = new System.Windows.Forms.CheckBox();
			this.chkStatus3 = new System.Windows.Forms.CheckBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkControl7 = new System.Windows.Forms.CheckBox();
			this.chkControl6 = new System.Windows.Forms.CheckBox();
			this.chkControl5 = new System.Windows.Forms.CheckBox();
			this.chkControl4 = new System.Windows.Forms.CheckBox();
			this.chkControl3 = new System.Windows.Forms.CheckBox();
			this.chkControl2 = new System.Windows.Forms.CheckBox();
			this.chkControl1 = new System.Windows.Forms.CheckBox();
			this.chkControl0 = new System.Windows.Forms.CheckBox();
			this.txtControl = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.comboAddress = new System.Windows.Forms.ComboBox();
			this.timerRefresh = new System.Timers.Timer();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAbout = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timerRefresh)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtData);
			this.groupBox1.Controls.Add(this.chkData7);
			this.groupBox1.Controls.Add(this.chkData6);
			this.groupBox1.Controls.Add(this.chkData5);
			this.groupBox1.Controls.Add(this.chkData4);
			this.groupBox1.Controls.Add(this.chkData3);
			this.groupBox1.Controls.Add(this.chkData2);
			this.groupBox1.Controls.Add(this.chkData1);
			this.groupBox1.Controls.Add(this.chkData0);
			this.groupBox1.Location = new System.Drawing.Point(8, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 248);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data register";
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(8, 216);
			this.txtData.Name = "txtData";
			this.txtData.ReadOnly = true;
			this.txtData.Size = new System.Drawing.Size(120, 20);
			this.txtData.TabIndex = 8;
			this.txtData.Text = "";
			// 
			// chkData7
			// 
			this.chkData7.Location = new System.Drawing.Point(8, 184);
			this.chkData7.Name = "chkData7";
			this.chkData7.Size = new System.Drawing.Size(120, 24);
			this.chkData7.TabIndex = 7;
			this.chkData7.Text = "(pin 9, bit 7) Data 7";
			this.chkData7.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkData6
			// 
			this.chkData6.Location = new System.Drawing.Point(8, 160);
			this.chkData6.Name = "chkData6";
			this.chkData6.Size = new System.Drawing.Size(120, 24);
			this.chkData6.TabIndex = 6;
			this.chkData6.Text = "(pin 8, bit 6) Data 6";
			this.chkData6.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkData5
			// 
			this.chkData5.Location = new System.Drawing.Point(8, 136);
			this.chkData5.Name = "chkData5";
			this.chkData5.Size = new System.Drawing.Size(120, 24);
			this.chkData5.TabIndex = 5;
			this.chkData5.Text = "(pin 7, bit 5) Data 5";
			this.chkData5.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkData4
			// 
			this.chkData4.Location = new System.Drawing.Point(8, 112);
			this.chkData4.Name = "chkData4";
			this.chkData4.Size = new System.Drawing.Size(120, 24);
			this.chkData4.TabIndex = 4;
			this.chkData4.Text = "(pin 6, bit 4) Data 4";
			this.chkData4.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkData3
			// 
			this.chkData3.Location = new System.Drawing.Point(8, 88);
			this.chkData3.Name = "chkData3";
			this.chkData3.Size = new System.Drawing.Size(120, 24);
			this.chkData3.TabIndex = 3;
			this.chkData3.Text = "(pin 5, bit 3) Data 3";
			this.chkData3.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkData2
			// 
			this.chkData2.Location = new System.Drawing.Point(8, 64);
			this.chkData2.Name = "chkData2";
			this.chkData2.Size = new System.Drawing.Size(120, 24);
			this.chkData2.TabIndex = 2;
			this.chkData2.Text = "(pin 4, bit 2) Data 2";
			this.chkData2.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkData1
			// 
			this.chkData1.Location = new System.Drawing.Point(8, 40);
			this.chkData1.Name = "chkData1";
			this.chkData1.Size = new System.Drawing.Size(120, 24);
			this.chkData1.TabIndex = 1;
			this.chkData1.Text = "(pin 3, bit 1) Data 1";
			this.chkData1.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkData0
			// 
			this.chkData0.Location = new System.Drawing.Point(8, 16);
			this.chkData0.Name = "chkData0";
			this.chkData0.Size = new System.Drawing.Size(120, 24);
			this.chkData0.TabIndex = 0;
			this.chkData0.Text = "(pin 2, bit 0) Data 0";
			this.chkData0.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkStatus2);
			this.groupBox2.Controls.Add(this.chkStatus1);
			this.groupBox2.Controls.Add(this.chkStatus0);
			this.groupBox2.Controls.Add(this.chkStatus7);
			this.groupBox2.Controls.Add(this.chkStatus6);
			this.groupBox2.Controls.Add(this.chkStatus5);
			this.groupBox2.Controls.Add(this.chkStatus4);
			this.groupBox2.Controls.Add(this.chkStatus3);
			this.groupBox2.Controls.Add(this.txtStatus);
			this.groupBox2.Location = new System.Drawing.Point(152, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(160, 248);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Status register";
			// 
			// chkStatus2
			// 
			this.chkStatus2.Enabled = false;
			this.chkStatus2.Location = new System.Drawing.Point(8, 64);
			this.chkStatus2.Name = "chkStatus2";
			this.chkStatus2.Size = new System.Drawing.Size(144, 24);
			this.chkStatus2.TabIndex = 12;
			this.chkStatus2.Text = "(bit 2) nIRQ";
			this.chkStatus2.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkStatus1
			// 
			this.chkStatus1.Enabled = false;
			this.chkStatus1.Location = new System.Drawing.Point(8, 40);
			this.chkStatus1.Name = "chkStatus1";
			this.chkStatus1.Size = new System.Drawing.Size(144, 24);
			this.chkStatus1.TabIndex = 11;
			this.chkStatus1.Text = "(bit 1) Reserved";
			this.chkStatus1.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkStatus0
			// 
			this.chkStatus0.Enabled = false;
			this.chkStatus0.Location = new System.Drawing.Point(8, 16);
			this.chkStatus0.Name = "chkStatus0";
			this.chkStatus0.Size = new System.Drawing.Size(144, 24);
			this.chkStatus0.TabIndex = 10;
			this.chkStatus0.Text = "(bit 0) Reserved";
			this.chkStatus0.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkStatus7
			// 
			this.chkStatus7.Enabled = false;
			this.chkStatus7.Location = new System.Drawing.Point(8, 184);
			this.chkStatus7.Name = "chkStatus7";
			this.chkStatus7.Size = new System.Drawing.Size(144, 24);
			this.chkStatus7.TabIndex = 9;
			this.chkStatus7.Text = "(pin 11, bit 7) Busy";
			this.chkStatus7.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkStatus6
			// 
			this.chkStatus6.Enabled = false;
			this.chkStatus6.Location = new System.Drawing.Point(8, 160);
			this.chkStatus6.Name = "chkStatus6";
			this.chkStatus6.Size = new System.Drawing.Size(144, 24);
			this.chkStatus6.TabIndex = 8;
			this.chkStatus6.Text = "(pin 10, bit 6) nAck";
			this.chkStatus6.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkStatus5
			// 
			this.chkStatus5.Enabled = false;
			this.chkStatus5.Location = new System.Drawing.Point(8, 136);
			this.chkStatus5.Name = "chkStatus5";
			this.chkStatus5.Size = new System.Drawing.Size(144, 24);
			this.chkStatus5.TabIndex = 7;
			this.chkStatus5.Text = "(pin 12, bit 5) Paper-Out";
			this.chkStatus5.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkStatus4
			// 
			this.chkStatus4.Enabled = false;
			this.chkStatus4.Location = new System.Drawing.Point(8, 112);
			this.chkStatus4.Name = "chkStatus4";
			this.chkStatus4.Size = new System.Drawing.Size(144, 24);
			this.chkStatus4.TabIndex = 6;
			this.chkStatus4.Text = "(pin 13, bit 4) Select";
			this.chkStatus4.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkStatus3
			// 
			this.chkStatus3.Enabled = false;
			this.chkStatus3.Location = new System.Drawing.Point(8, 88);
			this.chkStatus3.Name = "chkStatus3";
			this.chkStatus3.Size = new System.Drawing.Size(144, 24);
			this.chkStatus3.TabIndex = 5;
			this.chkStatus3.Text = "(pin 15, bit 3) nError";
			this.chkStatus3.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(8, 216);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(144, 20);
			this.txtStatus.TabIndex = 9;
			this.txtStatus.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chkControl7);
			this.groupBox3.Controls.Add(this.chkControl6);
			this.groupBox3.Controls.Add(this.chkControl5);
			this.groupBox3.Controls.Add(this.chkControl4);
			this.groupBox3.Controls.Add(this.chkControl3);
			this.groupBox3.Controls.Add(this.chkControl2);
			this.groupBox3.Controls.Add(this.chkControl1);
			this.groupBox3.Controls.Add(this.chkControl0);
			this.groupBox3.Controls.Add(this.txtControl);
			this.groupBox3.Location = new System.Drawing.Point(320, 64);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 248);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Control register";
			// 
			// chkControl7
			// 
			this.chkControl7.Location = new System.Drawing.Point(8, 184);
			this.chkControl7.Name = "chkControl7";
			this.chkControl7.Size = new System.Drawing.Size(168, 24);
			this.chkControl7.TabIndex = 16;
			this.chkControl7.Text = "(bit 7) Unused";
			this.chkControl7.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkControl6
			// 
			this.chkControl6.Location = new System.Drawing.Point(8, 160);
			this.chkControl6.Name = "chkControl6";
			this.chkControl6.Size = new System.Drawing.Size(168, 24);
			this.chkControl6.TabIndex = 15;
			this.chkControl6.Text = "(bit 6) Unused";
			this.chkControl6.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkControl5
			// 
			this.chkControl5.Location = new System.Drawing.Point(8, 136);
			this.chkControl5.Name = "chkControl5";
			this.chkControl5.Size = new System.Drawing.Size(168, 24);
			this.chkControl5.TabIndex = 14;
			this.chkControl5.Text = "(bit 5) Enable Bidirectional";
			this.chkControl5.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkControl4
			// 
			this.chkControl4.Location = new System.Drawing.Point(8, 112);
			this.chkControl4.Name = "chkControl4";
			this.chkControl4.Size = new System.Drawing.Size(168, 24);
			this.chkControl4.TabIndex = 13;
			this.chkControl4.Text = "(bit 4) Enable IRQ Via Ack";
			this.chkControl4.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkControl3
			// 
			this.chkControl3.Location = new System.Drawing.Point(8, 88);
			this.chkControl3.Name = "chkControl3";
			this.chkControl3.Size = new System.Drawing.Size(168, 24);
			this.chkControl3.TabIndex = 12;
			this.chkControl3.Text = "(pin 17, bit 3) nSelect-Printer";
			this.chkControl3.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkControl2
			// 
			this.chkControl2.Location = new System.Drawing.Point(8, 64);
			this.chkControl2.Name = "chkControl2";
			this.chkControl2.Size = new System.Drawing.Size(168, 24);
			this.chkControl2.TabIndex = 11;
			this.chkControl2.Text = "(pin 16, bit 2) nInitialize";
			this.chkControl2.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkControl1
			// 
			this.chkControl1.Location = new System.Drawing.Point(8, 40);
			this.chkControl1.Name = "chkControl1";
			this.chkControl1.Size = new System.Drawing.Size(168, 24);
			this.chkControl1.TabIndex = 10;
			this.chkControl1.Text = "(pin 14, bit 1) Linefeed";
			this.chkControl1.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// chkControl0
			// 
			this.chkControl0.Location = new System.Drawing.Point(8, 16);
			this.chkControl0.Name = "chkControl0";
			this.chkControl0.Size = new System.Drawing.Size(168, 24);
			this.chkControl0.TabIndex = 9;
			this.chkControl0.Text = "(pin 1, bit 0) nStrobe";
			this.chkControl0.Click += new System.EventHandler(this.checkBox_Click);
			// 
			// txtControl
			// 
			this.txtControl.Location = new System.Drawing.Point(8, 216);
			this.txtControl.Name = "txtControl";
			this.txtControl.ReadOnly = true;
			this.txtControl.Size = new System.Drawing.Size(168, 20);
			this.txtControl.TabIndex = 10;
			this.txtControl.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.comboAddress);
			this.groupBox4.Location = new System.Drawing.Point(8, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(496, 48);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Port";
			// 
			// comboAddress
			// 
			this.comboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAddress.Items.AddRange(new object[] {
															  "278",
															  "378",
															  "3BC"});
			this.comboAddress.Location = new System.Drawing.Point(8, 16);
			this.comboAddress.Name = "comboAddress";
			this.comboAddress.Size = new System.Drawing.Size(480, 21);
			this.comboAddress.TabIndex = 0;
			// 
			// timerRefresh
			// 
			this.timerRefresh.Enabled = true;
			this.timerRefresh.SynchronizingObject = this;
			this.timerRefresh.Elapsed += new System.Timers.ElapsedEventHandler(this.timerRefresh_Elapsed);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 336);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Pins labeled nXXX (e.g. nStrobe) are hardware inverted";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(288, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Pinout for DB25  connector";
			// 
			// lblAbout
			// 
			this.lblAbout.Location = new System.Drawing.Point(456, 336);
			this.lblAbout.Name = "lblAbout";
			this.lblAbout.Size = new System.Drawing.Size(48, 16);
			this.lblAbout.TabIndex = 6;
			this.lblAbout.TabStop = true;
			this.lblAbout.Text = "About...";
			this.lblAbout.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAbout_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(514, 360);
			this.Controls.Add(this.lblAbout);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "LPTMonitor.NET 1.0";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timerRefresh)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region Event handlers

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			comboAddress.SelectedIndex = 1; // default port address = 378
		}

		private void timerRefresh_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			RefreshCheckboxes();
		}

		private void checkBox_Click(object sender, System.EventArgs e)
		{
			string name = ((Control) sender).Name;
			bool isChecked = ((CheckBox) sender).Checked;
			int address = GetPortAddress();
			int bit = 0;

			if(name.StartsWith("chkData"))
			{
				bit = Convert.ToInt32(name.Substring(7, 1));
			}

			if(name.StartsWith("chkStatus"))
			{
				bit = Convert.ToInt32(name.Substring(9, 1));
				address = address + 1;
			}

			if(name.StartsWith("chkControl"))
			{
				bit = Convert.ToInt32(name.Substring(10, 1));
				address = address + 2;
			}

			byte mybyte = SetBit((byte)PortAccess.Input(address), bit, isChecked);
			PortAccess.Output(address, mybyte);
		}

		private void lblAbout_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show(
				"LPTMonitor.NET 1.0\n" +
				"\n" +
				"A .NET parallel port input/output test tool.\n" +
				"\n" +
				"Copyright (C) 2006 by Leandro Ezequiel Lovisolo <cafesolo@gmail.com>\n" +
				"http://www.cafesolo.com.ar\n" +
				"\n" +
				"This software is published under the terms of the Apache License, Version 2.0.\n" +
                "\n" +
				"Visit http://www.apache.org/licenses/LICENSE-2.0 for details",
				
				"About...",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		#endregion


		#region Methods

		private int GetPortAddress()
		{
			int address = 0;

			switch(comboAddress.SelectedIndex)
			{
				case 0:
					address = 0x278;
					break;

				case 1:
					address = 0x378;
					break;

				case 2:
					address = 0x3BC;
					break;
			}

			return address;
		}

		private void RefreshCheckboxes()
		{
			int address = GetPortAddress();

			byte data = (byte) PortAccess.Input(address);
			byte status = (byte) PortAccess.Input(address + 1);
			byte control = (byte) PortAccess.Input(address + 2);

            chkData0.Checked = GetBit(data, 0);
			chkData1.Checked = GetBit(data, 1);
			chkData2.Checked = GetBit(data, 2);
			chkData3.Checked = GetBit(data, 3);
			chkData4.Checked = GetBit(data, 4);
			chkData5.Checked = GetBit(data, 5);
			chkData6.Checked = GetBit(data, 6);
			chkData7.Checked = GetBit(data, 7);

			chkStatus0.Checked = GetBit(status, 0);
			chkStatus1.Checked = GetBit(status, 1);
			chkStatus2.Checked = GetBit(status, 2);
			chkStatus3.Checked = GetBit(status, 3);
			chkStatus4.Checked = GetBit(status, 4);
			chkStatus5.Checked = GetBit(status, 5);
			chkStatus6.Checked = GetBit(status, 6);
			chkStatus7.Checked = GetBit(status, 7);

			chkControl0.Checked = GetBit(control, 0);
			chkControl1.Checked = GetBit(control, 1);
			chkControl2.Checked = GetBit(control, 2);
			chkControl3.Checked = GetBit(control, 3);
			chkControl4.Checked = GetBit(control, 4);
			chkControl5.Checked = GetBit(control, 5);
			chkControl6.Checked = GetBit(control, 6);
			chkControl7.Checked = GetBit(control, 7);

			txtData.Text = data.ToString();
			txtStatus.Text = status.ToString();
			txtControl.Text = control.ToString();
		}

		private bool GetBit(byte mybyte, int bit)
		{
			mybyte >>= bit;
			mybyte &= 1;

			if(mybyte == 0) return false;
			return true;
		}

		private byte SetBit(byte mybyte, int bit, bool val)
		{
			byte mask = (byte) Math.Pow(2, bit);

			if(val == true)
			{
				mybyte |= mask;
			}
			else
			{
				mybyte &= (byte) ~mask;
			}

			return mybyte;
		}

		#endregion

	}
}
