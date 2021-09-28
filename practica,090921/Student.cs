using System;
using System.Collections.Generic;
using System.Text;

namespace practica_090921
{
    class Student
    {
        public int idStudent { get; set; }

        public string fistName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public string Nacionality { get; set; }

        //metodo con la coleccion de datos

        public static List<Student> GetStudents()
        {

            List<Student> students = new List<Student>
            {
                new Student { idStudent = 1001, fistName = "Jose", lastName = "Robles", age = 25, Nacionality = "Europeo" },
                new Student { idStudent = 1002, fistName = "Ana", lastName = "Lopez", age = 20, Nacionality = "Argetino" },
                new Student { idStudent = 1003, fistName = "Rafael", lastName = "Gonzalez", age = 21, Nacionality = "Estado Unidense" },
                new Student { idStudent = 1004, fistName = "Alfredo", lastName = "Valladares", age = 23, Nacionality = "Canadiense" },
                new Student { idStudent = 1005, fistName = "Amanda", lastName = "Flores", age = 22, Nacionality = "Salvadoreñ" }

            };

            return students; //reotrno de la coleccion


        }
    }
}
