/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 19/04/2022
 * Time: 21:52
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
				MessageBox.Show("Data tidak dapat dimasukkan");
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
		
		
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
				textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
				textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			/* tombol update data */
			// Memeriksa apakah kolom text kosong?
			if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" )
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* update data */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="update tbl_barang set KodeBarang='"+textBox1.Text+"', NamaBarang='"+textBox2.Text+"', HargaJual='"+textBox3.Text+"', HargaBeli='"+textBox4.Text+"', JumlahBarang='"+textBox5.Text+"', SatuanBarang='"+textBox6.Text+"' where KodeBarang='"+textBox1.Text+"'";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Update data berhasil","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
