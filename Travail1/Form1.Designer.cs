namespace Travail1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.depemployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compagnieXDataSet = new Travail1.CompagnieXDataSet();
            this.compagnieXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departementsTableAdapter = new Travail1.CompagnieXDataSetTableAdapters.DepartementsTableAdapter();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new Travail1.CompagnieXDataSetTableAdapters.EmployesTableAdapter();
            this.compagnieXDataSet1 = new Travail1.CompagnieXDataSet();
            this.dep_employeTableAdapter = new Travail1.CompagnieXDataSetTableAdapters.Dep_employeTableAdapter();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departementsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.depemployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // depemployeBindingSource
            // 
            this.depemployeBindingSource.DataMember = "Dep_employe";
            this.depemployeBindingSource.DataSource = this.compagnieXDataSet;
            // 
            // compagnieXDataSet
            // 
            this.compagnieXDataSet.DataSetName = "CompagnieXDataSet";
            this.compagnieXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compagnieXDataSetBindingSource
            // 
            this.compagnieXDataSetBindingSource.DataSource = this.compagnieXDataSet;
            this.compagnieXDataSetBindingSource.Position = 0;
            // 
            // departementsBindingSource
            // 
            this.departementsBindingSource.DataMember = "Departements";
            this.departementsBindingSource.DataSource = this.compagnieXDataSet;
            // 
            // departementsTableAdapter
            // 
            this.departementsTableAdapter.ClearBeforeFill = true;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.compagnieXDataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // compagnieXDataSet1
            // 
            this.compagnieXDataSet1.DataSetName = "CompagnieXDataSet";
            this.compagnieXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dep_employeTableAdapter
            // 
            this.dep_employeTableAdapter.ClearBeforeFill = true;
            // 
            // departementsBindingSource1
            // 
            this.departementsBindingSource1.DataMember = "Departements";
            this.departementsBindingSource1.DataSource = this.dBDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depemployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CompagnieXDataSet compagnieXDataSet;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private CompagnieXDataSetTableAdapters.DepartementsTableAdapter departementsTableAdapter;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private CompagnieXDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private CompagnieXDataSet compagnieXDataSet1;
        private System.Windows.Forms.BindingSource compagnieXDataSetBindingSource;
        private System.Windows.Forms.BindingSource depemployeBindingSource;
        private CompagnieXDataSetTableAdapters.Dep_employeTableAdapter dep_employeTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        //private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource departementsBindingSource1;
        //private DBDataSetTableAdapters.DepartementsTableAdapter departementsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

