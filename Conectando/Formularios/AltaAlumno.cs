using Backend;
using Backend.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Net;

namespace Conectando
{
    public partial class AltaAlumno : Form
    {
        public object Text1 { get; }

        public AltaAlumno()
        {
            InitializeComponent();




        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void txtTelP_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
//     private SqlConnection conexion;
//     private DataSet datos;
//     private SqlDataAdapter adaptador;
//     private SqlDataAdapter adaptador1;
//     private void AltaAlumno_Load(object sender, EventArgs e)
//     {
//         Conexion conexion = new Conexion();
//         DataSet dataSet = conexion.Consulta();
//         DataView dv = dataSet.Tables[0].DefaultView;

//         cmbInscripcion.DataSource = dv;
//         cmbInscripcion.DisplayMember = "descripcion";
//         cmbInscripcion.ValueMember = "IdEstadoInscripcion";


//         DataSet dataSet1 = conexion.ConsultaGrado();
//         DataView dv1 = dataSet1.Tables[0].DefaultView;
//         cmbCurso.DataSource = dv1;
//         cmbCurso.DisplayMember = "Grado";
//         cmbCurso.ValueMember = "IdGrado";


//         DataSet dataSet2 = conexion.ConsultaDivision();
//         DataView dv2 = dataSet2.Tables[0].DefaultView;
//         cmbDivision.DataSource = dv2;
//         cmbDivision.DisplayMember = "Division";
//         cmbDivision.ValueMember = "IdDivision";


//         DataSet dataSet3 = conexion.ConsultaTurno();
//         DataView dv3 = dataSet3.Tables[0].DefaultView;
//         cmbTurno.DataSource = dv3;
//         cmbTurno.DisplayMember = "Turno";
//         cmbTurno.ValueMember = "IdTurno";

//         DataSet dataSet4 = conexion.ConsultaGenero();
//         DataView dv4 = dataSet4.Tables[0].DefaultView;
//         cmbGenero.DataSource = dv4;
//         cmbGenero.DisplayMember = "Genero";
//         cmbGenero.ValueMember = "IdGenero";

//         DataSet dataSet5 = conexion.ConsultaProvincia();
//         DataView dv5 = dataSet5.Tables[0].DefaultView;
//         cmbProvincia.DataSource = dv5;
//         cmbProvincia.DisplayMember = "Provincia";
//         cmbProvincia.ValueMember = "IdProvincia";

//         DataSet dataSet6 = conexion.ConsultaLocalidad();
//         DataView dv6 = dataSet6.Tables[0].DefaultView;
//         cmbLocalidad.DataSource = dv6;
//         cmbLocalidad.DisplayMember = "Localidad";
//         cmbLocalidad.ValueMember = "IdLocalidad";

//         DataSet dataSet7 = conexion.ConsultaRelacion();
//         DataView dv7 = dataSet7.Tables[0].DefaultView;
//         cmbRelacion.DataSource = dv7;
//         cmbRelacion.DisplayMember = "Descripcion";
//         cmbRelacion.ValueMember = "IdParentesco";



//         //DATAGRID PARA CARGA AUMNOS...
//         DataSet dataSet8 = conexion.ConsultaAlumnos();
//         dvgAlumno.DataSource = dataSet8.Tables[0];
//         dvgAlumno.Update();



//     }
///*private void Alta (object sender, EventArgs e)
//     {
//      conexion = new SqlConnection("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = Conectando; Integrated Security = True");


//     }*/




//     private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//     { conexion = new SqlConnection("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = Conectando; Integrated Security = True");
//         adaptador = new SqlDataAdapter();
//         datos = new DataSet();

//         SqlCommand consulta = new SqlCommand("SELECT Persona.dni, Persona.nombre, Persona.apellido, Persona.FechaNacimiento, Persona.Edad,Persona.NroOrden,Genero.IdGenero, estadoInscripcion.IdEstadoInscripcion,Grado.IdGrado, Division.IdDivision, Turno.IdTurno, Domicilio.Calle,Domicilio.Nro, Barrio.Descripcion, Barrio.Cp, Localidad.IdLocalidad, Provincia.IdProvincia, Contacto.nombre, Contacto.telefono,  Parentesco.IdParentesco FROM Persona, Estudiante, Genero, estadoInscripcion, Grado, Division, Turno, Domicilio, Barrio, Localidad, Provincia, Contacto, Parentesco WHERE Persona.IdGenero = Genero.IdGenero AND Estudiante.IdPersona = Persona.IdPersona AND estadoInscripcion.IdEstadoInscripcion = Estudiante.IdEstadoInscripcion AND Estudiante.IdGrado= Grado.IdGrado  AND Division.IdDivision= Estudiante.IdDivision AND Persona.IdDomicilio = Domicilio.IdDomicilio AND Barrio.IdBarrio = Domicilio.IdBarrio AND Localidad.IdLocalidad= Barrio.IdLocalidad AND Provincia.IdProvincia= Localidad.IdProvincia AND Turno.IdTurno= Estudiante.IdTurno AND Contacto.IdContacto= Persona.IdContacto AND Contacto.IdParentesco= Parentesco.IdParentesco AND Persona.dni =@dni", conexion);
//         adaptador.SelectCommand = consulta;
//         adaptador.SelectCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
//         try
//         {
//             conexion.Open();
//             string DNI = dvgAlumno.CurrentRow.Cells[0].Value.ToString();
//             adaptador.SelectCommand.Parameters["@dni"].Value = int.Parse(DNI);
//             adaptador.Fill(datos, "Persona");

//             //Traigo los datos del Usuario
//             int registro = int.Parse(datos.Tables["Persona"].Rows.Count.ToString());

//             if (registro == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Persona"].Rows)
//                 {
//                     txtNombre.Text = fila["nombre"].ToString();
//                     txtApellido.Text = fila["apellido"].ToString();
//                     txtDni.Text = fila["dni"].ToString();
//                     dateTimeNacimiento.Value = DateTime.Parse(fila["FechaNacimiento"].ToString());
//                     txtEdad.Text = fila["Edad"].ToString();
//                     txtOrden.Text = fila["NroOrden"].ToString();

//                 }
//             }
//             adaptador.Fill(datos, "Genero");

//             //Traigo los datos del Usuario
//             int registroGenero = int.Parse(datos.Tables["Genero"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Genero"].Rows)
//                 {
//                     cmbGenero.SelectedValue = fila["IdGenero"];
//                 }
//             }
//             adaptador.Fill(datos, "estadoInscripcion");

//             //Traigo los datos del Usuario
//             int registroInsripcion = int.Parse(datos.Tables["estadoInscripcion"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["estadoInscripcion"].Rows)
//                 {
//                     cmbInscripcion.SelectedValue = fila["IdEstadoInscripcion"];
//                 }
//             }

//             adaptador.Fill(datos, "Grado");

//             //Traigo los datos del Usuario
//             int registroGrado = int.Parse(datos.Tables["estadoInscripcion"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Grado"].Rows)
//                 {
//                     cmbCurso.SelectedValue = fila["IdGrado"];
//                 }
//             }

//             adaptador.Fill(datos, "Division");

//             //Traigo los datos del Usuario
//             int registroDivision = int.Parse(datos.Tables["Division"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Division"].Rows)
//                 {
//                     cmbDivision.SelectedValue = fila["IdDivision"];
//                 }
//             }

//             adaptador.Fill(datos, "Turno");

//             //Traigo los datos del Usuario
//             int registroTurno = int.Parse(datos.Tables["Turno"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Turno"].Rows)
//                 {
//                     cmbTurno.SelectedValue = fila["IdTurno"];
//                 }
//             }
//             adaptador.Fill(datos, "Domicilio");
//             int registroDomicilio = int.Parse(datos.Tables["Domicilio"].Rows.Count.ToString());

//             if (registro == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Domicilio"].Rows)
//                 {
//                     txtCalle.Text = fila["Calle"].ToString();
//                     txtNro.Text = fila["Nro"].ToString();

//                     }
//             }

//            adaptador.Fill(datos, "Barrio");
//             int registroBarrio = int.Parse(datos.Tables["Barrio"].Rows.Count.ToString());

//             if (registro == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Barrio"].Rows)
//                 {
//                     txtBarrio.Text = fila["Descripcion"].ToString();
//                     txtCP.Text = fila["Cp"].ToString();
//                 }
//             }

//             adaptador.Fill(datos, "Localidad");

//             //Traigo los datos del Usuario
//             int registroLocalidad = int.Parse(datos.Tables["Localidad"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Localidad"].Rows)
//                 {
//                     cmbLocalidad.SelectedValue = fila["IdLocalidad"];
//                 }
//             }

//             adaptador.Fill(datos, "Provincia");

//             //Traigo los datos del Usuario
//             int registroProvincia = int.Parse(datos.Tables["Provincia"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Provincia"].Rows)
//                 {
//                     cmbProvincia.SelectedValue = fila["IdProvincia"];
//                 }
//             }

//             adaptador.Fill(datos, "Contacto");
//             int registroContacto = int.Parse(datos.Tables["Contacto"].Rows.Count.ToString());

//             if (registro == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Contacto"].Rows)
//                 {
//                     txtApellidoContacto.Text = fila["apellido"].ToString();
//                     txtNombreContacto.Text = fila["nombre"].ToString();
//                     txtTelP.Text = fila["telefono"].ToString();
//                 }
//             }
//             adaptador.Fill(datos, "Parentesco");

//             int registroParentesco = int.Parse(datos.Tables["Parentesco"].Rows.Count.ToString());

//             if (registroGenero == 1)
//             {
//                 foreach (DataRow fila in datos.Tables["Parentesco"].Rows)
//                 {
//                     cmbRelacion.SelectedValue = fila["IdParentesco"];
//                 }
//             }
//         }
//         catch (SqlException excepcion)
//         {
//             //MessageBox.Show(excepcion.ToString());
//         }
//         finally
//         {
//             conexion.Close();
//         }

//     }



//     private void cmbInscripcion_SelectedIndexChanged(object sender, EventArgs e)
//     {

//     }

//     private void txtFiltro_TextChanged(object sender, EventArgs e)
//   {
//         Conexion conexion = new Conexion();
//         string query = "";

//         if (txtFiltro.Text.Length >= 3)
//         {
//             //aca vamos a filtrar a partir del texto ingresado
//             query = $"SELECT dni, nombre, apellido FROM Persona where dni like '%{txtFiltro.Text}%' or nombre like '%{txtFiltro.Text}%' or apellido like '%{txtFiltro.Text}%'";

//         }
//         else if (txtFiltro.Text.Length <1)
//         {
//             query = $"SELECT dni, nombre, apellido FROM Persona";

//         }
//         if (query!= "")
//         {


//         DataSet dataSet = conexion.ConsultaGenerica(query);
//         dvgAlumno.DataSource = dataSet.Tables[0];
//         dvgAlumno.Update();
//         }
//     }

//     private void label38_Click(object sender, EventArgs e)
//     {

//     }

//     private void btnCancelar_Click(object sender, EventArgs e)
//     {
//         this.Close();
//     }

//     private void btnAlta_Click(object sender, EventArgs e)
//     {
//         DialogResult resultado = MessageBox.Show("¿Desea Generar el Alta de Estudiante?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
//         if (resultado == DialogResult.Yes)
//         {
//             conexion = new SqlConnection("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = Conectando; Integrated Security = True");
//             adaptador = new SqlDataAdapter();
//             datos = new DataSet();

//             SqlCommand alta = new SqlCommand("insert into Persona (dni, nombre, apellido, IdGenero, FechaNacimiento, Edad, IdEstadoInscripcion,NroOrden, IdGrado, IdDivision, IdTurno, Calle, Nro, Barrio, Cp, IdLocalidad, IdProvincia, ApellidoContacto, NombreContacto, Telefono, IdParentesco) " +
//                                              "values (@dni, @nombre, @apellido, @IdGenero, @FechaNacimiento, @Edad, @IdEstadoInscripcion,@NroOrden, @IdGrado, @IdDivision, @IdTurno,  @Calle, @Nro, @Barrio, @Cp, @IdLocalidad, @IdProvincia, @ApellidoContacto, @NombreContacto, @Telefono, @IdParentesco)", conexion);
//             adaptador.InsertCommand = alta;

//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdGenero", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.Date));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdEstadoInscripcion", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@NroOrden", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdGrado", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdDivision", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdTurno", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Nro", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Barrio", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Cp", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdLocalidad", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdProvincia", SqlDbType.Int));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@ApellidoContacto", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@NombreContacto", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
//             adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdParentesco", SqlDbType.Int));
//             //adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdContacto", SqlDbType.Int));

//             adaptador.InsertCommand.Parameters["@dni"].Value = int.Parse(txtDni.Text);
//             adaptador.InsertCommand.Parameters["@apellido"].Value = txtApellido.Text;
//             adaptador.InsertCommand.Parameters["@nombre"].Value = txtNombre.Text;
//             adaptador.InsertCommand.Parameters["@IdGenero"].Value = cmbGenero.SelectedValue;
//             adaptador.InsertCommand.Parameters["@FechaNacimiento"].Value = dateTimeNacimiento.Value;
//             adaptador.InsertCommand.Parameters["@Edad"].Value = int.Parse(txtEdad.Text);
//             adaptador.InsertCommand.Parameters["@IdEstadoInscripcion"].Value = cmbInscripcion.SelectedValue;
//             adaptador.InsertCommand.Parameters["@NroOrden"].Value = int.Parse(txtOrden.Text);
//             adaptador.InsertCommand.Parameters["@IdGrado"].Value = cmbCurso.SelectedValue;
//             adaptador.InsertCommand.Parameters["@IdDivision"].Value = cmbDivision.SelectedValue;
//             adaptador.InsertCommand.Parameters["@IdTurno"].Value = cmbTurno.SelectedValue;
//             adaptador.InsertCommand.Parameters["@Calle"].Value = txtCalle.Text;
//             adaptador.InsertCommand.Parameters["@Nro"].Value = txtNro.Text;
//             adaptador.InsertCommand.Parameters["@Barrio"].Value = txtBarrio.Text;
//             adaptador.InsertCommand.Parameters["@Cp"].Value = txtCP.Text;
//             adaptador.InsertCommand.Parameters["@IdLocalidad"].Value = cmbLocalidad.SelectedValue;
//             adaptador.InsertCommand.Parameters["@IdProvincia"].Value = cmbProvincia.SelectedValue;
//             adaptador.InsertCommand.Parameters["@ApellidoContacto"].Value = txtApellidoContacto.Text;
//             adaptador.InsertCommand.Parameters["@NombreContacto"].Value = txtNombreContacto.Text;
//             adaptador.InsertCommand.Parameters["@Telefono"].Value = txtTelP.Text;
//             adaptador.InsertCommand.Parameters["@IdParentesco"].Value = cmbRelacion.SelectedValue;


//             try
//             {
//                 conexion.Open();
//                 adaptador.InsertCommand.ExecuteNonQuery();
//                 MessageBox.Show("Se registró el Estudiante Correctamente!");
//                 AltaAlumno menu = new AltaAlumno();
//                 menu.Show();
//             }
//             catch (SqlException excepcion)
//             {
//                 MessageBox.Show(excepcion.ToString());
//             }
//             finally
//             {
//                 conexion.Close();
//             }
//         }
//         else
//         {
//             this.Close();
//         }

//     }

//     private void btnModificar_Click(object sender, EventArgs e)
//     {
//         DialogResult resultado = MessageBox.Show("¿Confirma la modificación realizada para el Estudiante?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
//         if (resultado == DialogResult.Yes)
//         {
//             conexion = new SqlConnection("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = Conectando; Integrated Security = True");
//             adaptador = new SqlDataAdapter();
//             datos = new DataSet();

//             SqlCommand modificacion = new SqlCommand("update Persona set " +
//                 "dni=@dni," +
//                 "nombre=@nombre," +
//                 "apellido=@apellido, " +
//                 "IdGenero=@IdGenero," +
//                 "FechaNacimiento=@FechaNacimiento, " +
//                 "Edad=@Edad," +
//                 "IdEstadoInscripcion=@IdEstadoInscripcion, " +
//                 "NroOrden=@NroOrden, " +
//                 "IdGrado=@IdGrado, " +
//                 "IdDivision=@IdDivision," +
//                 "IdTurno=@IdTurno," +
//                 "Calle=@Calle, " +
//                 "Nro=@Nro, " +
//                 "Barrio=@Barrio, " +
//                 "Cp=@Cp, " +
//                 "IdLocalidad=@IdLocalidad, " +
//                 "IdProvincia=@IdProvincia, " +
//                 "ApellidoContacto=@ApellidoContacto, " +
//                 "NombreContacto=@NombreContacto, " +
//                 "Telefono=@Telefono, " +
//                 "IdParentesco=@IdParentesco " +
//                 "Where dni=@dni", conexion);

//             adaptador.UpdateCommand = modificacion;

//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdGenero", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.Date));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdEstadoInscripcion", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@NroOrden", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdGrado", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdDivision", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdTurno", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Calle", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Nro", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Barrio", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Cp", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdLocalidad", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdProvincia", SqlDbType.Int));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@ApellidoContacto", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@NombreContacto", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
//             adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@IdParentesco", SqlDbType.Int));
//             //adaptador.InsertCommand.Parameters.Add(new SqlParameter("@IdContacto", SqlDbType.Int));

//             adaptador.UpdateCommand.Parameters["@dni"].Value = int.Parse(txtDni.Text);
//             adaptador.UpdateCommand.Parameters["@apellido"].Value = txtApellido.Text;
//             adaptador.UpdateCommand.Parameters["@nombre"].Value = txtNombre.Text;
//             adaptador.UpdateCommand.Parameters["@IdGenero"].Value = cmbGenero.SelectedValue;
//             adaptador.UpdateCommand.Parameters["@FechaNacimiento"].Value = dateTimeNacimiento.Value;
//             adaptador.UpdateCommand.Parameters["@Edad"].Value = int.Parse(txtEdad.Text);
//             adaptador.UpdateCommand.Parameters["@IdEstadoInscripcion"].Value = cmbInscripcion.SelectedValue;
//             adaptador.UpdateCommand.Parameters["@NroOrden"].Value = int.Parse(txtOrden.Text);
//             adaptador.UpdateCommand.Parameters["@IdGrado"].Value = cmbCurso.SelectedValue;
//             adaptador.UpdateCommand.Parameters["@IdDivision"].Value = cmbDivision.SelectedValue;
//             adaptador.UpdateCommand.Parameters["@IdTurno"].Value = cmbTurno.SelectedValue;
//             adaptador.UpdateCommand.Parameters["@Calle"].Value = txtCalle.Text;
//             adaptador.UpdateCommand.Parameters["@Nro"].Value = txtNro.Text;
//             adaptador.UpdateCommand.Parameters["@Barrio"].Value = txtBarrio.Text;
//             adaptador.UpdateCommand.Parameters["@Cp"].Value = txtCP.Text;
//             adaptador.UpdateCommand.Parameters["@IdLocalidad"].Value = cmbLocalidad.SelectedValue;
//             adaptador.UpdateCommand.Parameters["@IdProvincia"].Value = cmbProvincia.SelectedValue;
//             adaptador.UpdateCommand.Parameters["@ApellidoContacto"].Value = txtApellidoContacto.Text;
//             adaptador.UpdateCommand.Parameters["@NombreContacto"].Value = txtNombreContacto.Text;
//             adaptador.UpdateCommand.Parameters["@Telefono"].Value = txtTelP.Text;
//             adaptador.UpdateCommand.Parameters["@IdParentesco"].Value = cmbRelacion.SelectedValue;


//             try
//             {
//                 conexion.Open();
//                 adaptador.UpdateCommand.ExecuteNonQuery();
//                 MessageBox.Show("Se registró la modificación Correctamente!");
//                 AltaAlumno menu = new AltaAlumno();
//                 menu.Show();
//             }
//             catch (SqlException excepcion)
//             {
//                 MessageBox.Show(excepcion.ToString());
//             }
//             finally
//             {
//                 conexion.Close();
//             }
//         }
//         else
//         {
//             this.Close();
//         }


//     }

//     private void label35_Click(object sender, EventArgs e)
//     {

//     }

//     private void btnEliminar_Click(object sender, EventArgs e)
//     {
//         DialogResult resultado = MessageBox.Show("¿Confirma que quiere eliminar el registro del Estudiante?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
//         if (resultado == DialogResult.Yes)
//         {
//             conexion = new SqlConnection("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = Conectando; Integrated Security = True");
//             adaptador = new SqlDataAdapter();
//             adaptador1 = new SqlDataAdapter();

//             datos = new DataSet();
//             SqlCommand bajaEstudiante = new SqlCommand("DELETE FROM Estudiante WHERE Estudiante.IdPersona = (SELECT Persona.IdPersona FROM Persona WHERE Persona.dni = @dni)", conexion);

//             adaptador1.DeleteCommand = bajaEstudiante;
//             adaptador1.DeleteCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
//             adaptador1.DeleteCommand.Parameters["@dni"].Value = int.Parse(txtDni.Text);

//             SqlCommand bajaPersona = new SqlCommand("DELETE FROM Persona WHERE dni = @dni", conexion);

//             adaptador.DeleteCommand = bajaPersona;
//             adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
//             adaptador.DeleteCommand.Parameters["@dni"].Value = int.Parse(txtDni.Text);

//             try
//             {
//                 conexion.Open();
//                 adaptador1.DeleteCommand.ExecuteNonQuery();
//                 adaptador.DeleteCommand.ExecuteNonQuery();
//                 MessageBox.Show("Se registró la modificación Correctamente!");
//                 AltaAlumno menu = new AltaAlumno();
//                 menu.Show();
//             }
//             catch (SqlException excepcion)
//             {
//                 MessageBox.Show(excepcion.ToString());
//             }
//             finally
//             {
//                 conexion.Close();
//             }
//         }
//         else
//         {
//             this.Close();
//         }

//     }
// }

