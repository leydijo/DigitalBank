using Business;
using Microsoft.Build.Tasks;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class datau : Form
    {
        public datau()
        {
            InitializeComponent();
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("F");
        }
        //llenar el dataGrid
        private void show()
        {
            try
            {
                Data.DataSource = BusinessUser.ShowUSer();
                this.clear();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void format ()
        {
            Data.Columns[0].Visible = false;
            Data.Columns[1].Visible = false;
            Data.Columns[2].Width = 200;//nombre
            Data.Columns[3].Width = 200;//fechaNacimiento
            Data.Columns[4].Width = 200;//genero
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.show();
            this.format();
        }
        private void SearchUser()
        {
            try
            {
                Data.DataSource = BusinessUser.SearchUser(search.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchUser();
        }

        private void clear()
        {
            Nombre.Clear();
            texId.Clear();
            Insertar.Visible = true;
            errorProvider1.Clear();
            update.Visible = false;

            Data.Columns[0].Visible = false;
            buttonDelete.Visible = false;
            checkBoxSeleccionar.Checked = false;
        }

        private void errorsMsj(string msj)
        {
            MessageBox.Show(msj, " Users", MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
        private void successful(string msj)
        {
            MessageBox.Show(msj, " Users", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.clear();
                update.Visible = true;
                Insertar.Visible = false;
                texId.Text = Convert.ToString(Data.CurrentRow.Cells["Id"].Value);
                Nombre.Text = Convert.ToString(Data.CurrentRow.Cells["Name"].Value);
                dateTimePicker1.Text = Convert.ToString(Data.CurrentRow.Cells["DateBirth"].Value);
                comboBox1.Text = Convert.ToString(Data.CurrentRow.Cells["Gender"].Value);
                tabControl1.SelectedIndex = 1;//re-dirige a la vista de acciones
            }
            catch(Exception)
            {
                MessageBox.Show("Selecciona desde la celda Name");
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = "";
               

                if (Nombre.Text == string.Empty)
                {
                    this.errorsMsj("Por favor revisar los datos del registro");
                    errorProvider1.SetError(Nombre,"Ingrese el nombre");
                    return;
                }
                if (string.IsNullOrEmpty(Gender.Text))
                {
                    this.errorsMsj("El campo genero debe tener un solo carácter");
                    errorProvider1.SetError(Gender, "El campo genero debe tenet un solo carácter");
                    return;
              
                }
         
                char gender = Convert.ToChar(comboBox1.Text);

                //coneccion clase user capa negocio
                answer = BusinessUser.InsertUser(Nombre.Text, Convert.ToDateTime(dateTimePicker1.Text), gender);

                if (answer.Equals("Successful"))
                {
             
                    this.successful("Se ingreso de manera correcta");
                    this.clear();
                    this.show();
                }else
                {
                    this.errorsMsj(answer);
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.clear();
            tabControl1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = "";

                if (texId.Text == string.Empty)
                {
                    this.errorsMsj("Por favor revisar el id del usuario");
                    errorProvider1.SetError(Nombre, "Ingrese el id");
                    return;
                }

                if (Nombre.Text == string.Empty)
                {
                    this.errorsMsj("Por favor revisar los datos del registro");
                    errorProvider1.SetError(Nombre, "Ingrese el nombre");
                    return;
                }
                if (string.IsNullOrEmpty(Gender.Text))
                {
                    this.errorsMsj("El campo genero debe tener un solo carácter");
                    errorProvider1.SetError(Gender, "El campo genero debe tenet un solo carácter");
                    return;

                }

                char gender =comboBox1.Text[0];

                //coneccion clase user capa negocio
                answer = BusinessUser.UpdateUser(Convert.ToInt32(texId.Text),Nombre.Text, Convert.ToDateTime(dateTimePicker1.Text), gender);

                if (answer.Equals("Successful"))
                {
                    this.successful("Se actualizo de manera correcta");
                    this.clear();
                    this.show();
                }
                else
                {
                    this.errorsMsj(answer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeleccionar.Checked)
            {
                Data.Columns[0].Visible = true;
                buttonDelete.Visible = true;
            }
            else
            {
                Data.Columns[0].Visible = false;
                buttonDelete.Visible = false;
            }
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.ColumnIndex == Data.Columns["Seleccionar"].Index) 
            {
                DataGridViewCheckBoxCell delete = (DataGridViewCheckBoxCell)Data.Rows[e.RowIndex].Cells["Seleccionar"];
                delete.Value = !Convert.ToBoolean(delete.Value);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                string answer = "";
                int codigo;
                opcion = MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in Data.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            answer = BusinessUser.DeleteUser(codigo);
                            if (answer.Equals("OK"))
                            {
                                this.successful("Se elimo correctamente: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.errorsMsj(answer);
                            }
                        }
                    }
                    this.show();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
