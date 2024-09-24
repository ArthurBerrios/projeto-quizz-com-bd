using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static String[] pergunta;
        public static int numPer = 1;
        public static int pontos = 0;
        public static int certa = 5;

        public String[] Conexao(int id)
        {
            SqlConnection cone = new SqlConnection(@"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Quiz; Data Source=" + Environment.MachineName + "\\SQLEXPRESS");

            cone.Open(); // codigo para pesquisar
            SqlCommand sqlCommand = cone.CreateCommand();
            SqlCommand comand = sqlCommand;
            comand.CommandType = CommandType.Text;
            comand.CommandText = "Select * from tblPergunta where id=" + id;
            comand.ExecuteNonQuery();
            cone.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comand);
            da.Fill(dt);
            String[] qualquer = new string[] { dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString() };
            return qualquer;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (certa == 0)
                return;

            pergunta = Conexao(numPer);

            lblpergunta.Text = numPer + pergunta[0];
            rdb1.Text = pergunta[1];
            rdb2.Text = pergunta[2];
            rdb3.Text = pergunta[3];
            rdb4.Text = pergunta[4];
            certa = int.Parse(pergunta[5]);
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (certa== 0)
            {
                numPer = 1;
                pergunta = Conexao(numPer);

                lblpergunta.Text = numPer + " " + pergunta[0];
                rdb1.Text = pergunta[1];
                rdb2.Text = pergunta[2];
                rdb3.Text = pergunta[3];
                rdb4.Text = pergunta[4];
                certa = int.Parse(pergunta[5]);
                return;
            }

            if (rdb1.Checked == true && certa == 1)
            {
                pontos++;
            }
            else if (rdb2.Checked == true && certa == 2)
            {
                pontos++;
            }
            else if (rdb3.Checked == true && certa == 3)
            {
                pontos++;
            }
            else if (rdb4.Checked == true && certa == 4)
            {
                pontos++;
            }

            numPer++;

            try
            {
                pergunta = Conexao(numPer);

                lblpergunta.Text = numPer + pergunta[0];
                rdb1.Text = pergunta[1];
                rdb2.Text = pergunta[2];
                rdb3.Text = pergunta[3];
                rdb4.Text = pergunta[4];
                certa = int.Parse(pergunta[5]);
            }
            catch
            {
                lblpergunta.Text = "Você acertou" + pontos + "pontos";
                pontos = 0;
                certa = 0;
            }
        }
    }
}