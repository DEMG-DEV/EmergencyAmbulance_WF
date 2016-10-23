namespace EmergencyAmbulance_WF
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idReporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportemedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergencyDataSet1 = new EmergencyAmbulance_WF.emergencyDataSet1();
            this.reporte_medicoTableAdapter = new EmergencyAmbulance_WF.emergencyDataSet1TableAdapters.reporte_medicoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ambulancia:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(134, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte N°:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(9, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(329, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Reporte";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 244);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Paciente";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox11.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox11.Location = new System.Drawing.Point(7, 151);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox11.Size = new System.Drawing.Size(747, 87);
            this.textBox11.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Diagnostico:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tipo de Sangre:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox10.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox10.Location = new System.Drawing.Point(476, 93);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pulso:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox9.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox9.Location = new System.Drawing.Point(329, 93);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(130, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox8.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox8.Location = new System.Drawing.Point(177, 93);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(130, 20);
            this.textBox8.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Presion:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox7.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox7.Location = new System.Drawing.Point(7, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(150, 20);
            this.textBox7.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(645, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(75, 20);
            this.textBox6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Edad:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(329, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(300, 20);
            this.textBox5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido(s):";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(7, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(300, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre(s):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReporteDataGridViewTextBoxColumn,
            this.fechaReporteDataGridViewTextBoxColumn,
            this.nombrePacienteDataGridViewTextBoxColumn,
            this.apellidoPacienteDataGridViewTextBoxColumn,
            this.sexoPacienteDataGridViewTextBoxColumn,
            this.edadPacienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportemedicoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 212);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idReporteDataGridViewTextBoxColumn
            // 
            this.idReporteDataGridViewTextBoxColumn.DataPropertyName = "idReporte";
            this.idReporteDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idReporteDataGridViewTextBoxColumn.Name = "idReporteDataGridViewTextBoxColumn";
            this.idReporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idReporteDataGridViewTextBoxColumn.Width = 50;
            // 
            // fechaReporteDataGridViewTextBoxColumn
            // 
            this.fechaReporteDataGridViewTextBoxColumn.DataPropertyName = "fechaReporte";
            this.fechaReporteDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaReporteDataGridViewTextBoxColumn.Name = "fechaReporteDataGridViewTextBoxColumn";
            this.fechaReporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaReporteDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombrePacienteDataGridViewTextBoxColumn
            // 
            this.nombrePacienteDataGridViewTextBoxColumn.DataPropertyName = "nombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.HeaderText = "Nombre Paciente";
            this.nombrePacienteDataGridViewTextBoxColumn.Name = "nombrePacienteDataGridViewTextBoxColumn";
            this.nombrePacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePacienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // apellidoPacienteDataGridViewTextBoxColumn
            // 
            this.apellidoPacienteDataGridViewTextBoxColumn.DataPropertyName = "apellidoPaciente";
            this.apellidoPacienteDataGridViewTextBoxColumn.HeaderText = "Apellido Paciente";
            this.apellidoPacienteDataGridViewTextBoxColumn.Name = "apellidoPacienteDataGridViewTextBoxColumn";
            this.apellidoPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoPacienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // sexoPacienteDataGridViewTextBoxColumn
            // 
            this.sexoPacienteDataGridViewTextBoxColumn.DataPropertyName = "sexoPaciente";
            this.sexoPacienteDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoPacienteDataGridViewTextBoxColumn.Name = "sexoPacienteDataGridViewTextBoxColumn";
            this.sexoPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadPacienteDataGridViewTextBoxColumn
            // 
            this.edadPacienteDataGridViewTextBoxColumn.DataPropertyName = "edadPaciente";
            this.edadPacienteDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadPacienteDataGridViewTextBoxColumn.Name = "edadPacienteDataGridViewTextBoxColumn";
            this.edadPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadPacienteDataGridViewTextBoxColumn.Width = 50;
            // 
            // reportemedicoBindingSource
            // 
            this.reportemedicoBindingSource.DataMember = "reporte_medico";
            this.reportemedicoBindingSource.DataSource = this.emergencyDataSet1;
            // 
            // emergencyDataSet1
            // 
            this.emergencyDataSet1.DataSetName = "emergencyDataSet1";
            this.emergencyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_medicoTableAdapter
            // 
            this.reporte_medicoTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportemedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private emergencyDataSet1 emergencyDataSet1;
        private System.Windows.Forms.BindingSource reportemedicoBindingSource;
        private emergencyDataSet1TableAdapters.reporte_medicoTableAdapter reporte_medicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadPacienteDataGridViewTextBoxColumn;
    }
}