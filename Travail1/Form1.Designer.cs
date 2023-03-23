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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numEmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depemployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compagnieXDataSet = new Travail1.CompagnieXDataSet();
            this.compagnieXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departementsTableAdapter = new Travail1.CompagnieXDataSetTableAdapters.DepartementsTableAdapter();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new Travail1.CompagnieXDataSetTableAdapters.EmployesTableAdapter();
            this.compagnieXDataSet1 = new Travail1.CompagnieXDataSet();
            this.dep_employeTableAdapter = new Travail1.CompagnieXDataSetTableAdapters.Dep_employeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depemployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numEmpDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.depemployeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // numEmpDataGridViewTextBoxColumn
            // 
            this.numEmpDataGridViewTextBoxColumn.DataPropertyName = "numEmp";
            this.numEmpDataGridViewTextBoxColumn.HeaderText = "numEmp";
            this.numEmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numEmpDataGridViewTextBoxColumn.Name = "numEmpDataGridViewTextBoxColumn";
            this.numEmpDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depemployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagnieXDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CompagnieXDataSet compagnieXDataSet;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private CompagnieXDataSetTableAdapters.DepartementsTableAdapter departementsTableAdapter;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private CompagnieXDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private CompagnieXDataSet compagnieXDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource compagnieXDataSetBindingSource;
        private System.Windows.Forms.BindingSource depemployeBindingSource;
        private CompagnieXDataSetTableAdapters.Dep_employeTableAdapter dep_employeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
    }
}

