using System;
using System.Collections.Generic;

namespace Generics
{
    public class Student
    {
        int nolista;
        String nombre;
        String apellido;

        public Student()
        {

        }
        public Student(String nombre, String apellido)
        {
            this.nolista = 0;
            this.nombre = nombre;
            this.apellido = apellido;
        }

       public Student(int nolista, String nombre, String apellido)
        {
            this.nolista=nolista;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public int getNolista()
        {
            return nolista;
        }
        public String getNombre()
        {
            return nombre;
        }
        public String getApellido()
        {
            return apellido;
        }
        public void setNolista(int nolista)
        {
            this.nolista = nolista;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentlist = new List<Student>();

            Student unedl1 = new Student(2, "Alejandro", "Ramirez");
            //Console.WriteLine("No lista: " + unedl1.getNolista());

            Student unedl2 = new Student();
            unedl2.setNolista(1);
            unedl2.setNombre("Daniel");
            unedl2.setApellido("Nuno");
            //Console.WriteLine("No lista: " + unedl2.setNolista());

            Student unedl3 = new Student("Juan Pablo", "Garcia ");

            studentlist.Add(new Student(3, "David", "Nuno"));
            studentlist.Add(unedl2);
            studentlist.Add(unedl1);
            studentlist.Add(unedl3);

            foreach(var elemento in studentlist)
            {
                Console.WriteLine(elemento.getNolista());
                Console.WriteLine(elemento.getNombre());
                Console.WriteLine(elemento.getApellido());

            }

        }
    }
}
