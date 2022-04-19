﻿/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 01/04/2022
 * Time: 7:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//tambahkan ini 
using System.Data;
using MySql.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Kasir
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = kasir; Uid = root;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		
		public void TampilBarang(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from tbl_barang";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"tbl_barang") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_barang";
				}
				else {
					MessageBox.Show("Data tabel sedang kosong");
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		} 
		
		public void Bersihkan(){
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
			textBox4.Text="";
			textBox5.Text="";
			textBox6.Text="";
		}
		
		
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			TampilBarang();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/* Membuat Event Tombol Simpan */
		void Button1Click(object sender, EventArgs e)
		{
			// Memeriksa apakah kolom text kosong?
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" )
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* insert data */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="insert into tbl_barang values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						TampilBarang();
						Bersihkan();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
	}
}
