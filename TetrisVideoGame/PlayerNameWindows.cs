﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisVideoGame
{
    public class PlayerNameWindows: Form
	{
		private Label message;
		public TextBox txtName;
		public Label errorMessage;
		private Button btnOk;
		private Button btnCancel;
		public bool flag;

		public PlayerNameWindows()
		{
            this.Width = 450;
            this.Height = 350;
			this.MaximumSize = new Size(450, 300);
            this.BackgroundImage = Image.FromFile("bg.png");
			this.ShowInTaskbar = false;
			this.KeyPreview = true;

			flag = false;
			message = new Label();
			message.Text = "Please enter your name:";
            message.ForeColor = Color.White;
            message.BackColor = Color.Transparent;
			message.Font = new Font("Segoe UI", 22, FontStyle.Bold);
			message.AutoSize = true;
			message.Left = 30;
			message.Top = 70;
			this.Controls.Add(message);

			txtName = new TextBox();
			txtName.Width = 390;
			txtName.Height = 100;
			txtName.Font = new Font("Arial", 20, FontStyle.Regular);
			txtName.Top = 130;
			txtName.Left = 30;
			this.Controls.Add(txtName);


			//not required anymore
			/*
			errorMessage = new Label();
			errorMessage.Text = "The name cannot be empty! Please enter a name.";
			errorMessage.Visible = false;
			errorMessage.ForeColor = Color.Red;
			errorMessage.BackColor = Color.Transparent;
			errorMessage.Font = new Font("Arial", 8, FontStyle.Bold);
			errorMessage.BringToFront();
			errorMessage.AutoSize = true;
			errorMessage.Left = 30;
			errorMessage.Top = 130;
			this.Controls.Add(errorMessage);
			*/

			btnOk = new Button();
			btnOk.Text = "Ok";
			btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.BackColor = Color.FromArgb(72,72,72);
			btnOk.Font = new Font("Segoe UI", 15, FontStyle.Regular);
			btnOk.ForeColor = Color.FromArgb(255,234,234);
			btnOk.AutoSize = true;
			btnOk.Width = 170;
			btnOk.Height = 50;
			btnOk.Left = 30;
			btnOk.Top = 205;
			btnOk.Click += this.BtnOk_Click;
			this.Controls.Add(btnOk);

			btnCancel = new Button();
			btnCancel.Text = "Cancel";
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.BackColor = Color.FromArgb(72,72,72);
			btnCancel.Font = new Font("Segoe UI", 15, FontStyle.Regular);
			btnCancel.ForeColor = Color.FromArgb(255,234,234);
			btnCancel.AutoSize = true;
			btnCancel.Width = 170;
			btnCancel.Height = 50;
			btnCancel.Left = 250;
			btnCancel.Top = 205;
			btnCancel.Click += this.BtnCancel_Click;
			this.Controls.Add(btnCancel);

			this.KeyDown += new KeyEventHandler(this.Form_KeyDown);
		}
		private void BtnOk_Click(object sender, EventArgs e)
		{
			if (txtName.Text == "" || txtName.Text == null)
			{

				//add something here to add a default name
				txtName.Text = "Anon";
				flag = true;
				this.Hide();
				//errorMessage.Visible = true;
			}
			else
			{
				flag = true;
				this.Hide();
			}

		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void Form_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnOk_Click(new object(),new EventArgs());
			}
		}

		#region windows shadow effect
		private const int WM_NCHITTEST = 0x84;
		private const int HTCLIENT = 0x1;
		private const int HTCAPTION = 0x2;

		private bool m_aeroEnabled;

		private const int CS_DROPSHADOW = 0x00020000;
		private const int WM_NCPAINT = 0x0085;
		private const int WM_ACTIVATEAPP = 0x001C;

		[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
		[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
		[System.Runtime.InteropServices.DllImport("dwmapi.dll")]

		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
		[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect,
			int nTopRect,
			int nRightRect,
			int nBottomRect,
			int nWidthEllipse,
			int nHeightEllipse
			);

		public struct MARGINS
		{
			public int leftWidth;
			public int rightWidth;
			public int topHeight;
			public int bottomHeight;
		}
		protected override CreateParams CreateParams
		{
			get
			{
				m_aeroEnabled = CheckAeroEnabled();
				CreateParams cp = base.CreateParams;
				if (!m_aeroEnabled)
					cp.ClassStyle |= CS_DROPSHADOW; return cp;
			}
		}
		private bool CheckAeroEnabled()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int enabled = 0; DwmIsCompositionEnabled(ref enabled);
				return (enabled == 1) ? true : false;
			}
			return false;
		}
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case WM_NCPAINT:
					if (m_aeroEnabled)
					{
						var v = 2;
						DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
						MARGINS margins = new MARGINS()
						{
							bottomHeight = 1,
							leftWidth = 0,
							rightWidth = 0,
							topHeight = 0
						}; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
					}
					break;
				default: break;
			}
			base.WndProc(ref m);
			if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
		}
		#endregion
	}
}
