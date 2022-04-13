/*
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
		
		
		public void ReadData(){
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
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			ReadData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	}
}
