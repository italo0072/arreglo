using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_090921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {

            selectName();
        }


        //metodo para obtener los nombre de la coleccion
        private void selectName()
        {
            //consulta
            List<string> query = (
                from student in Student.GetStudents()
                select student.fistName
                ).ToList();

            //recorrer lista y llenas insName
            foreach (var name in query)
            {
                //llenar listname
                listName.Items.Add(name);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //agregar columnas al datagridview
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstname", "NOMBRE");
            dgData.Columns.Add("lastname", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("Nacionality", "NACIONALIDAD");

            foreach(var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.fistName, student.lastName, student.age, student.Nacionality);
            }    
            

        }
        private List<Student> selectAllData()
        {
            List<Student> query = (
                from student in Student.GetStudents()
                select new Student()
                {
                    idStudent = student.idStudent,
                    fistName = student.fistName,
                    lastName = student.lastName,
                    age = student.age,
                    Nacionality = student.Nacionality

                }
                ).ToList();

            return query;

        }
    }
}
