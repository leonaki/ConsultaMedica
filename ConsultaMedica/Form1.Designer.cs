namespace ConsultaMedica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");
       
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNombres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBPaciente = new System.Windows.Forms.GroupBox();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBIDPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBEdad = new System.Windows.Forms.TextBox();
            this.TBApellido2 = new System.Windows.Forms.TextBox();
            this.TBApellido1 = new System.Windows.Forms.TextBox();
            this.TBNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DATEPEdad = new System.Windows.Forms.DateTimePicker();
            this.DATEPFecha = new System.Windows.Forms.DateTimePicker();
            this.DATEPProximaCita = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TBDiagnostico = new System.Windows.Forms.TextBox();
            this.TBTratamiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNBuscarPaciente = new System.Windows.Forms.Button();
            this.DTListaPacientes = new System.Windows.Forms.DataGridView();
            this.BTNInsertarPacienteNuevo = new System.Windows.Forms.Button();
            this.BTNNuevaConsulta = new System.Windows.Forms.Button();
            this.LBLConsultas = new System.Windows.Forms.Label();
            this.BTNConsultaPosterior = new System.Windows.Forms.Button();
            this.BTNConsultaAnterior = new System.Windows.Forms.Button();
            this.GBConsulta = new System.Windows.Forms.GroupBox();
            this.GBPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTListaPacientes)).BeginInit();
            this.GBConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(87, 44);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(74, 18);
            this.labelNombres.TabIndex = 0;
            this.labelNombres.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // GBPaciente
            // 
            this.GBPaciente.Controls.Add(this.CBSexo);
            this.GBPaciente.Controls.Add(this.label8);
            this.GBPaciente.Controls.Add(this.TBIDPaciente);
            this.GBPaciente.Controls.Add(this.label6);
            this.GBPaciente.Controls.Add(this.TBEdad);
            this.GBPaciente.Controls.Add(this.TBApellido2);
            this.GBPaciente.Controls.Add(this.TBApellido1);
            this.GBPaciente.Controls.Add(this.TBNombres);
            this.GBPaciente.Controls.Add(this.label3);
            this.GBPaciente.Controls.Add(this.DATEPEdad);
            this.GBPaciente.Controls.Add(this.label1);
            this.GBPaciente.Controls.Add(this.label2);
            this.GBPaciente.Controls.Add(this.labelNombres);
            this.GBPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.GBPaciente.Location = new System.Drawing.Point(10, 77);
            this.GBPaciente.Name = "GBPaciente";
            this.GBPaciente.Size = new System.Drawing.Size(678, 184);
            this.GBPaciente.TabIndex = 3;
            this.GBPaciente.TabStop = false;
            this.GBPaciente.Text = "Datos de Paciente";
            // 
            // CBSexo
            // 
            this.CBSexo.AllowDrop = true;
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CBSexo.Location = new System.Drawing.Point(166, 98);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(121, 26);
            this.CBSexo.TabIndex = 17;
            this.CBSexo.Text = "Femenino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sexo:";
            // 
            // TBIDPaciente
            // 
            this.TBIDPaciente.Location = new System.Drawing.Point(572, 21);
            this.TBIDPaciente.Name = "TBIDPaciente";
            this.TBIDPaciente.ReadOnly = true;
            this.TBIDPaciente.Size = new System.Drawing.Size(100, 24);
            this.TBIDPaciente.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID Paciente:";
            // 
            // TBEdad
            // 
            this.TBEdad.Location = new System.Drawing.Point(516, 127);
            this.TBEdad.Name = "TBEdad";
            this.TBEdad.ReadOnly = true;
            this.TBEdad.Size = new System.Drawing.Size(30, 24);
            this.TBEdad.TabIndex = 9;
            // 
            // TBApellido2
            // 
            this.TBApellido2.Location = new System.Drawing.Point(294, 68);
            this.TBApellido2.Name = "TBApellido2";
            this.TBApellido2.Size = new System.Drawing.Size(100, 24);
            this.TBApellido2.TabIndex = 8;
            // 
            // TBApellido1
            // 
            this.TBApellido1.Location = new System.Drawing.Point(166, 68);
            this.TBApellido1.Name = "TBApellido1";
            this.TBApellido1.Size = new System.Drawing.Size(121, 24);
            this.TBApellido1.TabIndex = 7;
            // 
            // TBNombres
            // 
            this.TBNombres.Location = new System.Drawing.Point(166, 38);
            this.TBNombres.Name = "TBNombres";
            this.TBNombres.Size = new System.Drawing.Size(121, 24);
            this.TBNombres.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // DATEPEdad
            // 
            this.DATEPEdad.Location = new System.Drawing.Point(164, 127);
            this.DATEPEdad.Name = "DATEPEdad";
            this.DATEPEdad.Size = new System.Drawing.Size(261, 24);
            this.DATEPEdad.TabIndex = 3;
            this.DATEPEdad.ValueChanged += new System.EventHandler(this.DATEPEdad_ValueChanged);
            // 
            // DATEPFecha
            // 
            this.DATEPFecha.Enabled = false;
            this.DATEPFecha.Location = new System.Drawing.Point(406, 22);
            this.DATEPFecha.Name = "DATEPFecha";
            this.DATEPFecha.Size = new System.Drawing.Size(270, 24);
            this.DATEPFecha.TabIndex = 19;
            // 
            // DATEPProximaCita
            // 
            this.DATEPProximaCita.Location = new System.Drawing.Point(105, 329);
            this.DATEPProximaCita.Name = "DATEPProximaCita";
            this.DATEPProximaCita.Size = new System.Drawing.Size(257, 24);
            this.DATEPProximaCita.TabIndex = 15;
            this.DATEPProximaCita.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proxima Cita:";
            this.label7.UseWaitCursor = true;
            // 
            // TBDiagnostico
            // 
            this.TBDiagnostico.Location = new System.Drawing.Point(6, 199);
            this.TBDiagnostico.Multiline = true;
            this.TBDiagnostico.Name = "TBDiagnostico";
            this.TBDiagnostico.Size = new System.Drawing.Size(670, 88);
            this.TBDiagnostico.TabIndex = 11;
            // 
            // TBTratamiento
            // 
            this.TBTratamiento.Location = new System.Drawing.Point(6, 75);
            this.TBTratamiento.Multiline = true;
            this.TBTratamiento.Name = "TBTratamiento";
            this.TBTratamiento.Size = new System.Drawing.Size(670, 88);
            this.TBTratamiento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Diagnostico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tratamiento:";
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNAgregar.BackgroundImage")));
            this.BTNAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNAgregar.Location = new System.Drawing.Point(618, 296);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(58, 56);
            this.BTNAgregar.TabIndex = 4;
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNBuscarPaciente
            // 
            this.BTNBuscarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNBuscarPaciente.BackgroundImage")));
            this.BTNBuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNBuscarPaciente.Location = new System.Drawing.Point(1020, 4);
            this.BTNBuscarPaciente.Name = "BTNBuscarPaciente";
            this.BTNBuscarPaciente.Size = new System.Drawing.Size(34, 32);
            this.BTNBuscarPaciente.TabIndex = 5;
            this.BTNBuscarPaciente.UseVisualStyleBackColor = true;
            this.BTNBuscarPaciente.Click += new System.EventHandler(this.button2_Click);
            // 
            // DTListaPacientes
            // 
            this.DTListaPacientes.AllowUserToAddRows = false;
            this.DTListaPacientes.AllowUserToDeleteRows = false;
            this.DTListaPacientes.AllowUserToResizeRows = false;
            this.DTListaPacientes.BackgroundColor = System.Drawing.Color.Silver;
            this.DTListaPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DTListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTListaPacientes.Location = new System.Drawing.Point(702, 42);
            this.DTListaPacientes.MultiSelect = false;
            this.DTListaPacientes.Name = "DTListaPacientes";
            this.DTListaPacientes.ReadOnly = true;
            this.DTListaPacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DTListaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTListaPacientes.Size = new System.Drawing.Size(352, 646);
            this.DTListaPacientes.TabIndex = 6;
            this.DTListaPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTListaPacientes_CellClick);
            // 
            // BTNInsertarPacienteNuevo
            // 
            this.BTNInsertarPacienteNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNInsertarPacienteNuevo.BackgroundImage")));
            this.BTNInsertarPacienteNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNInsertarPacienteNuevo.Location = new System.Drawing.Point(630, 12);
            this.BTNInsertarPacienteNuevo.Name = "BTNInsertarPacienteNuevo";
            this.BTNInsertarPacienteNuevo.Size = new System.Drawing.Size(58, 59);
            this.BTNInsertarPacienteNuevo.TabIndex = 7;
            this.BTNInsertarPacienteNuevo.UseVisualStyleBackColor = true;
            this.BTNInsertarPacienteNuevo.Click += new System.EventHandler(this.BTNInsertarPacienteNuevo_Click);
            // 
            // BTNNuevaConsulta
            // 
            this.BTNNuevaConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNuevaConsulta.BackgroundImage")));
            this.BTNNuevaConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNNuevaConsulta.Location = new System.Drawing.Point(630, 269);
            this.BTNNuevaConsulta.Name = "BTNNuevaConsulta";
            this.BTNNuevaConsulta.Size = new System.Drawing.Size(58, 59);
            this.BTNNuevaConsulta.TabIndex = 8;
            this.BTNNuevaConsulta.UseVisualStyleBackColor = true;
            this.BTNNuevaConsulta.Click += new System.EventHandler(this.BTNNuevaConsulta_Click);
            // 
            // LBLConsultas
            // 
            this.LBLConsultas.AutoSize = true;
            this.LBLConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLConsultas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLConsultas.Location = new System.Drawing.Point(340, 303);
            this.LBLConsultas.Name = "LBLConsultas";
            this.LBLConsultas.Size = new System.Drawing.Size(72, 25);
            this.LBLConsultas.TabIndex = 9;
            this.LBLConsultas.Text = "0 de 0";
            this.LBLConsultas.Visible = false;
            // 
            // BTNConsultaPosterior
            // 
            this.BTNConsultaPosterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNConsultaPosterior.BackgroundImage")));
            this.BTNConsultaPosterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNConsultaPosterior.Enabled = false;
            this.BTNConsultaPosterior.Location = new System.Drawing.Point(418, 303);
            this.BTNConsultaPosterior.Name = "BTNConsultaPosterior";
            this.BTNConsultaPosterior.Size = new System.Drawing.Size(30, 23);
            this.BTNConsultaPosterior.TabIndex = 10;
            this.BTNConsultaPosterior.UseVisualStyleBackColor = true;
            this.BTNConsultaPosterior.Visible = false;
            this.BTNConsultaPosterior.Click += new System.EventHandler(this.BTNConsultaPosterior_Click);
            // 
            // BTNConsultaAnterior
            // 
            this.BTNConsultaAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNConsultaAnterior.BackgroundImage")));
            this.BTNConsultaAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNConsultaAnterior.Location = new System.Drawing.Point(304, 303);
            this.BTNConsultaAnterior.Name = "BTNConsultaAnterior";
            this.BTNConsultaAnterior.Size = new System.Drawing.Size(30, 22);
            this.BTNConsultaAnterior.TabIndex = 11;
            this.BTNConsultaAnterior.UseVisualStyleBackColor = true;
            this.BTNConsultaAnterior.Visible = false;
            this.BTNConsultaAnterior.Click += new System.EventHandler(this.BTNConsultaAnterior_Click);
            // 
            // GBConsulta
            // 
            this.GBConsulta.Controls.Add(this.DATEPFecha);
            this.GBConsulta.Controls.Add(this.DATEPProximaCita);
            this.GBConsulta.Controls.Add(this.label7);
            this.GBConsulta.Controls.Add(this.TBDiagnostico);
            this.GBConsulta.Controls.Add(this.TBTratamiento);
            this.GBConsulta.Controls.Add(this.label4);
            this.GBConsulta.Controls.Add(this.label5);
            this.GBConsulta.Controls.Add(this.BTNAgregar);
            this.GBConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBConsulta.Location = new System.Drawing.Point(12, 329);
            this.GBConsulta.Name = "GBConsulta";
            this.GBConsulta.Size = new System.Drawing.Size(684, 359);
            this.GBConsulta.TabIndex = 21;
            this.GBConsulta.TabStop = false;
            this.GBConsulta.Text = "Datos de Consulta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1066, 700);
            this.Controls.Add(this.BTNBuscarPaciente);
            this.Controls.Add(this.GBConsulta);
            this.Controls.Add(this.BTNConsultaAnterior);
            this.Controls.Add(this.BTNConsultaPosterior);
            this.Controls.Add(this.LBLConsultas);
            this.Controls.Add(this.BTNNuevaConsulta);
            this.Controls.Add(this.BTNInsertarPacienteNuevo);
            this.Controls.Add(this.DTListaPacientes);
            this.Controls.Add(this.GBPaciente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Consulta Medica";
            this.GBPaciente.ResumeLayout(false);
            this.GBPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTListaPacientes)).EndInit();
            this.GBConsulta.ResumeLayout(false);
            this.GBConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBPaciente;
        private System.Windows.Forms.TextBox TBIDPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBDiagnostico;
        private System.Windows.Forms.TextBox TBTratamiento;
        private System.Windows.Forms.TextBox TBEdad;
        private System.Windows.Forms.TextBox TBApellido2;
        private System.Windows.Forms.TextBox TBApellido1;
        private System.Windows.Forms.TextBox TBNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DATEPEdad;
        private System.Windows.Forms.DateTimePicker DATEPProximaCita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DATEPFecha;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNBuscarPaciente;
        private System.Windows.Forms.DataGridView DTListaPacientes;
        private System.Windows.Forms.Button BTNInsertarPacienteNuevo;
        private System.Windows.Forms.Button BTNNuevaConsulta;
        private System.Windows.Forms.Label LBLConsultas;
        private System.Windows.Forms.Button BTNConsultaPosterior;
        private System.Windows.Forms.Button BTNConsultaAnterior;
        private System.Windows.Forms.GroupBox GBConsulta;
    }
}

