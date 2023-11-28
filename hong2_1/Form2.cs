using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.Odbc;
using System.Xml.Linq;
//using System.Data.OracleClient;

namespace hong2_1
{
    public partial class Form2 : Form
    {
          
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select * from 주문상세";
            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
            DBAdapter.SelectCommand = myCommand;
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "주문상세");
            DataTable 주문상세Table = DS.Tables["주문상세"];
            DataRow newRow = 주문상세Table.NewRow();
            char c = 'A';
            //int i = (int)(c) + 1;
            newRow["일련번호"] = c++;
            newRow["금액"] = 0;
            newRow["구매날짜"] = 0;
            newRow["상품맛코드"] = flavorTB1.Text;
            newRow["사이즈코드"] = null;
            newRow["주문코드"] = 0;
            주문상세Table.Rows.Add(newRow);
            DBAdapter.Update(DS, "주문상세");

            flavordb.DataSource = DS.Tables["주문상세"].DefaultView;
            order_header();
        }

        private void order_header()
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flavorTB1.Text = flavordb.Rows[this.flavordb.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
OracleConnection myConnection = new OracleConnection(connectionString);
                string commandString = "select * from 상품";
                OracleCommand myCommand = new OracleCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;
                OracleDataAdapter DBAdapter = new OracleDataAdapter();
                DBAdapter.SelectCommand = myCommand;
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "상품");

                flavordb.DataSource = DS.Tables["상품"].DefaultView;
                flavor_header();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }


        }

        private void flavor_header()
        {
            flavordb.Columns[0].Visible = false;
            flavordb.Columns[1].HeaderText = "상품이름";
            flavordb.Columns[2].Visible = false;
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
