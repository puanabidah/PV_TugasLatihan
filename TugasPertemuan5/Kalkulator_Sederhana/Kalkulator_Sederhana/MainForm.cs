/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 16/03/2022
 * Time: 16:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka pertama atau angka kedua tidak boleh kosong");
			}
			else 
			{
				//Operasi Penambahan
				float a, b, c;
				a = float.Parse(this.textBox1.Text);
				b = float.Parse(this.textBox2.Text);
				c = a + b;
				this.LBLHasil.Text = c.ToString();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka pertama atau angka kedua tidak boleh kosong");
			}
			else 
			{
				//Operasi Pengurangan
				float a, b, c;
				a = float.Parse(this.textBox1.Text);
				b = float.Parse(this.textBox2.Text);
				c = a - b;
				this.LBLHasil.Text = c.ToString();
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka pertama atau angka kedua tidak boleh kosong");
			}
			else 
			{
				//Operasi Perkalian
				float a, b, c;
				a = float.Parse(this.textBox1.Text);
				b = float.Parse(this.textBox2.Text);
				c = a * b;
				this.LBLHasil.Text = c.ToString();
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Angka pertama atau angka kedua tidak boleh kosong");
			}
			else 
			{
				//Operasi Pembagian
				float a, b, c;
				a = float.Parse(this.textBox1.Text);
				b = float.Parse(this.textBox2.Text);
				c = a / b;
				this.LBLHasil.Text = c.ToString();
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			LBLHasil.Text = "";
		}
	}
}
