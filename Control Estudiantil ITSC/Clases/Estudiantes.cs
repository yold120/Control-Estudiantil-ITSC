using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Estudiantil_ITSC.Clases
{
    public class Estudiantes
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _matricula;
        private string _carrera;
        private string _materia;
        private string _profesor;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Matricula { get => _matricula; set => _matricula = value; }
        public string Carrera { get => _carrera; set => _carrera = value; }
        public string Materia { get => _materia; set => _materia = value; }
        public string Profesor { get => _profesor; set => _profesor = value; }

        public Estudiantes()
        {

        }
        public Estudiantes(int id, string nombre, string apellido, string matricula, string carrera, 
                            string  materia, string profesor)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._matricula = matricula;
            this._carrera = carrera;
            this._materia = materia;
            this._profesor = profesor;



        }


    }
}
