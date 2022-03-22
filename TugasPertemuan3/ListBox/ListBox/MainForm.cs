/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 23/02/2022
 * Time: 21:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ListBox
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
			listBox1.Items.Add(textBox1.Text);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}
	}
}
