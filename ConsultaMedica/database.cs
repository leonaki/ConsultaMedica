using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ConsultaMedica
{

    class database
    {
        public SQLiteConnection myConnection;

        public database ()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                MessageBox.Show("Data Base Created", "SQLite", MessageBoxButtons.OK);

            }
        }

        public void InsertarNuevoPaciente(string nombres, string apellido1, string apellido2, string sexo, string fechanacimiento, string tratamiento, string diagnostico, string fechaconsulta, string fechaproximacita)
        {

            string insert1 = "INSERT INTO Paciente (Nombres, Apellido1, Apellido2, Sexo, FechaNacimiento) " +
                "VALUES('" + nombres + "','"+ apellido1 + "','" + apellido2 + "','" + sexo + "','" +fechanacimiento+"')";
            string insert2 = "INSERT INTO ConsultaMedica (Tratamiento, Diagnostico, FechaConsulta, FechaProximaCita , PacienteID) " +
                "VALUES('" + tratamiento + "','"+ diagnostico + "','" + fechaconsulta + "','" + fechaproximacita+ "',(SELECT max(id) FROM Paciente))";
            SQLiteCommand mycommand1 = new SQLiteCommand(insert1, myConnection);
            SQLiteCommand mycommand2 = new SQLiteCommand(insert2, myConnection);
            myConnection.Open();
            mycommand1.ExecuteNonQuery();
            mycommand2.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Datos de nuevo paciente insertados.", "Nuevo Paciente", MessageBoxButtons.OK);


        }
        public void InsertarConsultaPacienteID(int PacienteID, string tratamiento, string diagnostico, string fechaconsulta, string fechaproximacita)
        {

           string insert2 = "INSERT INTO ConsultaMedica (Tratamiento, Diagnostico, FechaConsulta, FechaProximaCita , PacienteID) " +
                "VALUES('" + tratamiento + "','" + diagnostico + "','" + fechaconsulta + "','" + fechaproximacita + "','" + PacienteID + "')";
            SQLiteCommand mycommand2 = new SQLiteCommand(insert2, myConnection);
            myConnection.Open();
            mycommand2.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Nueva Consulta Registrada.", "Nueva Consulta", MessageBoxButtons.OK);


        }

        public List<Pacientes> CargarListaPacientes()
        {
            List<Pacientes> ListaPacientes = new List<Pacientes>();

            string insert1 = "select * from Paciente order by Apellido1";
            SQLiteCommand mycommand1 = new SQLiteCommand(insert1, myConnection);
            myConnection.Open();
            SQLiteDataReader reader = mycommand1.ExecuteReader();
            while (reader.Read())
            {
                Pacientes Pacientes = new Pacientes();
                Pacientes.IDPaciente = int.Parse( reader["ID"].ToString() );
                Pacientes.nombres = reader["Nombres"].ToString();
                Pacientes.apellido1 = reader["Apellido1"].ToString();
                Pacientes.apellido2 = reader["Apellido2"].ToString();
                Pacientes.sexo = reader["Sexo"].ToString();
                Pacientes.fechanacimiento = reader["FechaNacimiento"].ToString();
                ListaPacientes.Add(Pacientes);
            }

                myConnection.Close();
            


            return ListaPacientes;

        }

        public List<Consultas> CargarListaConsultasPorPacienteID(int IDPaciente)
        {
            List<Consultas> ListaConsultas = new List<Consultas>();

            string insert1 = "select * from ConsultaMedica where PacienteID ="+ IDPaciente + " order by ID";
            SQLiteCommand mycommand1 = new SQLiteCommand(insert1, myConnection);
            myConnection.Open();
            SQLiteDataReader reader = mycommand1.ExecuteReader();
            while (reader.Read())
            {
                Consultas Consulta = new Consultas();
                Consulta.IDConsulta = int.Parse(reader["ID"].ToString());
                Consulta.tratamiento = reader["Tratamiento"].ToString();
                Consulta.diagnostico = reader["Diagnostico"].ToString();
                Consulta.fechaconsulta = reader["FechaConsulta"].ToString();
                Consulta.fechaproximacita = reader["FechaProximaCita"].ToString();
                Consulta.IDPaciente = int.Parse(reader["PacienteID"].ToString());
                ListaConsultas.Add(Consulta);

            }

            myConnection.Close();



            return ListaConsultas;

        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
