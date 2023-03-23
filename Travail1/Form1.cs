using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'compagnieXDataSet.Dep_employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dep_employeTableAdapter.Fill(this.compagnieXDataSet.Dep_employe);
            // TODO: cette ligne de code charge les données dans la table 'compagnieXDataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employesTableAdapter.Fill(this.compagnieXDataSet.Employes);
            // TODO: cette ligne de code charge les données dans la table 'compagnieXDataSet.Departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departementsTableAdapter.Fill(this.compagnieXDataSet.Departements);

        }

    }
}
