using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace ConsultaMedica
{
    public partial class Form1 : Form
    {
        database databaseobject = new database();
        public List<Pacientes> ListaPacientes = new List<Pacientes>();
        List<Consultas> ListaConsultas = new List<Consultas>();

        public DataTable table = new DataTable();
        
        int indexconsulta = 0;

        public Form1()
        {
            InitializeComponent();
            BTNNuevaConsulta.Enabled = false;
            BTNInsertarPacienteNuevo.Enabled = false;
            table.Columns.Add("ID Paciente", typeof(int));
            table.Columns.Add("Nombres", typeof(string));
            table.Columns.Add("Primer Apellido", typeof(string));
            table.Columns.Add("Segundo Apellido", typeof(string));
           
        }

        private void DATEPEdad_ValueChanged(object sender, EventArgs e)
        {
            TBEdad.Text = (CalculateAge(Convert.ToDateTime(DATEPEdad.Text))).ToString();
        }


        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (TBNombres.Text == "" || TBApellido1.Text == "" || TBApellido2.Text == "" || TBTratamiento.Text == "" || TBDiagnostico.Text == "" || TBEdad.Text == "")
                {
                    MessageBox.Show("Todos los datos son requeridos.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (TBIDPaciente.Text == "")
                    {
                        databaseobject.InsertarNuevoPaciente(TBNombres.Text, TBApellido1.Text, TBApellido2.Text, CBSexo.Text, DATEPEdad.Text, TBTratamiento.Text, TBDiagnostico.Text, DATEPFecha.Text, DATEPProximaCita.Text);

                    }
                    else
                    {
                        databaseobject.InsertarConsultaPacienteID(int.Parse(TBIDPaciente.Text), TBTratamiento.Text, TBDiagnostico.Text, DATEPFecha.Text, DATEPProximaCita.Text);
                    }

                    resetPaciente();
                    resetConsulta();
                }

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTListaPacientes.DataSource = null;
            table.Clear();
           

            ListaPacientes = databaseobject.CargarListaPacientes();

            int rows = 0;
            foreach (Pacientes element in ListaPacientes)
            {
                table.Rows.Add();

                table.Rows[rows][0] = element.IDPaciente;

                table.Rows[rows][1] = element.nombres ;

                table.Rows[rows][2] = element.apellido1;

                table.Rows[rows][3] = element.apellido2;

                rows++;
            }

            BTNAgregar.Enabled = false;
            BTNInsertarPacienteNuevo.Enabled = true;

            DTListaPacientes.DataSource = table;
            DTListaPacientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            foreach (DataGridViewColumn column in DTListaPacientes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DTListaPacientes.ClearSelection();


        }

        private void BTNInsertarPacienteNuevo_Click(object sender, EventArgs e)
        {
            resetPaciente();
            resetConsulta();


           

            BTNInsertarPacienteNuevo.Enabled = false;
            BTNAgregar.Enabled = true;
            BTNNuevaConsulta.Enabled = false;

            LBLConsultas.Visible = false;
            BTNConsultaAnterior.Visible = false;
            BTNConsultaPosterior.Visible = false;

        }

        private void DTListaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            { 
            LBLConsultas.Visible = true;
            BTNConsultaAnterior.Visible = true;
            BTNConsultaPosterior.Visible = true;
            BTNNuevaConsulta.Enabled = true;
            BTNInsertarPacienteNuevo.Enabled = true;
            BTNAgregar.Enabled = false;
            BTNConsultaPosterior.Enabled = false;
            BTNConsultaAnterior.Enabled = true;

            ListaConsultas = new List<Consultas>();
            ListaConsultas = databaseobject.CargarListaConsultasPorPacienteID(ListaPacientes[e.RowIndex].IDPaciente);
            PopularTBPaciente(e.RowIndex);
            LBLConsultas.Text = ListaConsultas.Count.ToString() + " de " + ListaConsultas.Count.ToString() ;
            indexconsulta = ListaConsultas.Count;
            PopularTBConsulta(indexconsulta);

            if (indexconsulta == 1)
            { BTNConsultaAnterior.Enabled = false; }
            }
        }

        private void PopularTBPaciente(int index)
        {
            GBPaciente.Enabled = false;
            TBIDPaciente.Text = ListaPacientes[index].IDPaciente.ToString();

            TBNombres.Text = ListaPacientes[index].nombres;

            TBApellido1.Text = ListaPacientes[index].apellido1;

            TBApellido2.Text = ListaPacientes[index].apellido2;

            CBSexo.Text = ListaPacientes[index].sexo;

            DATEPEdad.Text = ListaPacientes[index].fechanacimiento;


        }
        private void PopularTBConsulta(int index)
        {
            GBConsulta.Enabled = false;

            TBTratamiento.Text = ListaConsultas[index-1].tratamiento.ToString();

            TBDiagnostico.Text = ListaConsultas[index-1].diagnostico.ToString();

            DATEPFecha.Text = ListaConsultas[index-1].fechaconsulta;

            DATEPProximaCita.Text = ListaConsultas[index-1].fechaproximacita;

        }

        private void BTNNuevaConsulta_Click(object sender, EventArgs e)
        {
            GBConsulta.Enabled = true;
            GBConsulta.Enabled = true;
            foreach (Control ctr in GBConsulta.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

            }
            DATEPFecha.Text = DateTime.Now.ToString();
            DATEPProximaCita.Text = DateTime.Now.ToString();
            BTNAgregar.Enabled = true;


            LBLConsultas.Visible = false;
            BTNConsultaAnterior.Visible = false;
            BTNConsultaPosterior.Visible = false;

        }

        private void resetPaciente()
        {
            GBPaciente.Enabled = true;
            foreach (Control ctr in GBPaciente.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

            }
            DATEPEdad.Text = DateTime.Now.ToString();
        }

        private void resetConsulta()
        {

            GBConsulta.Enabled = true;
            foreach (Control ctr in GBConsulta.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

            }
            DATEPFecha.Text = DateTime.Now.ToString();
            DATEPProximaCita.Text = DateTime.Now.ToString();
        }

        private void BTNConsultaAnterior_Click(object sender, EventArgs e)
        {
            indexconsulta--;
            LBLConsultas.Text = indexconsulta.ToString() + " de " + ListaConsultas.Count.ToString();
            if (indexconsulta == 1) 
            { BTNConsultaAnterior.Enabled = false; BTNConsultaPosterior.Enabled = true; }
            PopularTBConsulta(indexconsulta);

        }

        private void BTNConsultaPosterior_Click(object sender, EventArgs e)
        {
            indexconsulta++;
            LBLConsultas.Text = indexconsulta.ToString() + " de " + ListaConsultas.Count.ToString();

            if (indexconsulta == ListaConsultas.Count)
            { BTNConsultaPosterior.Enabled = false; BTNConsultaAnterior.Enabled = true; }

            PopularTBConsulta(indexconsulta);
        }

       
    }
    public class Pacientes
    {
        public int IDPaciente { get; set; }
        public string nombres { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string sexo { get; set; }
        public string fechanacimiento { get; set; }
        



    }

    public class Consultas
    {
        public int IDConsulta { get; set; }
        public string tratamiento { get; set; }
        public string diagnostico { get; set; }
        public string fechaconsulta { get; set; }
        public string fechaproximacita { get; set; }
        public int IDPaciente { get; set; }


}
}
