namespace EmergencyAmbulance_WF
{
    partial class RecibirAmbulancia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.emergencyDataSet = new EmergencyAmbulance_WF.emergencyDataSet();
            this.ambulanciasemergenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanciasemergenciasTableAdapter = new EmergencyAmbulance_WF.emergencyDataSetTableAdapters.ambulanciasemergenciasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanciasemergenciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ambulanciasemergenciasBindingSource, "idAmbulancia", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // emergencyDataSet
            // 
            this.emergencyDataSet.DataSetName = "emergencyDataSet";
            this.emergencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ambulanciasemergenciasBindingSource
            // 
            this.ambulanciasemergenciasBindingSource.DataMember = "ambulanciasemergencias";
            this.ambulanciasemergenciasBindingSource.DataSource = this.emergencyDataSet;
            // 
            // ambulanciasemergenciasTableAdapter
            // 
            this.ambulanciasemergenciasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recibir Ambulancia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecibirAmbulancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(309, 92);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecibirAmbulancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecibirAmbulancia";
            this.Load += new System.EventHandler(this.RecibirAmbulancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanciasemergenciasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private emergencyDataSet emergencyDataSet;
        private System.Windows.Forms.BindingSource ambulanciasemergenciasBindingSource;
        private emergencyDataSetTableAdapters.ambulanciasemergenciasTableAdapter ambulanciasemergenciasTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}