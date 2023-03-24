using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail1Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anton\OneDrive\Documents\GitHub\Travail1_LinqToSQL\Travail1Final\DB.mdf;Integrated Security=True";

        DBDataContext dataContext = new DBDataContext(chaine);


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dBDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.departementsTableAdapter1.Fill(this.dBDataSet.Departements);
            // TODO: cette ligne de code charge les données dans la table 'compagnieXDataSet.Dep_employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.dep_employeTableAdapter.Fill(this.compagnieXDataSet.Dep_employe);
            // TODO: cette ligne de code charge les données dans la table 'compagnieXDataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.employesTableAdapter.Fill(this.compagnieXDataSet.Employes);
            // TODO: cette ligne de code charge les données dans la table 'compagnieXDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.departementsTableAdapter.Fill(this.compagnieXDataSet.Departements);


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataContext.listeEmployesTravail().ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataContext.listeNoEmployes().ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataContext.DepartementPopulaire().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.modifierPrenomEmp(int.Parse(textBox1.Text), textBox2.Text);
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.supprimerGestionnaire(int.Parse(textBox3.Text),int.Parse(textBox4.Text));
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
