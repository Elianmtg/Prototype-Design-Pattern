using System;
using System.Collections.Generic;
using System.Text;

namespace CentroEducativo
{
    class Alumnos : ICloneable//IClonar
    {
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string Genero { get; set; }
        public Padres NombreP { get; set; } //COMPOSICION
        public Padres Telefono { get; set; }//COMPOSICION
        public Padres padreComposicion;//COMPOSICION

        public Alumnos()//CONSTRUCTOR
        {
            padreComposicion = new Padres();
        }

        public object Clone()
        {
            Alumnos clon = new Alumnos();
            MemberwiseClone();//CLONADO PROFUNDO
            clon.padreComposicion.NombreP = padreComposicion.NombreP;
            clon.padreComposicion.Telefono = padreComposicion.Telefono;
            return clon;
        }
        public override string ToString()
        {
            //return $"NOMBRE: {Nombre}, GENERO: {Genero}, FECHA DE NACIMIENTO: {FechaNacimiento}, EDAD: {Edad}, MATRICULA: {Matricula}, CARRERA: {Carrera} NOMBRE PADRE: {padreComposicion.NombreP}, TELEFONO PADRE: {padreComposicion.Telefono}.";
            return $"NOMBRE: {Nombre}\nGENERO: {Genero}\nFECHA DE NACIMIENTO: {FechaNacimiento}\nEDAD: {Edad}\nMATRICULA: {Matricula}\nCARRERA: {Carrera}\nNOMBRE PADRE: {padreComposicion.NombreP}\nTELEFONO PADRE: {padreComposicion.Telefono}.";
        }
        public void Presentacion()
        {
            if (Genero == "M")
            {
                Console.WriteLine($"\nMI NOMBRE ES: {Nombre}, DE GENERO: {Genero}, HOMBRES AL PODER :) !!!");
            }
            else if (Genero == "F")
            {
                Console.WriteLine($"\nMI NOMBRE ES: {Nombre}, DE GENERO: {Genero}, MUJERES AL PODER :) !!!");
            }
            else
            {
                Console.WriteLine("\nNO ESPECIFICO SU GENERO :( ");
            }
        }
        public void Cumpleanos()
        {
            Console.WriteLine($"NACI EL {FechaNacimiento}, TENGO {Edad} AÑOS DE EDAD Y PARA MI PROXIMO CUMPLEAÑOS TENDRE {Edad+1}.");
        }
        public void CarreraM()
        {
            Console.WriteLine($"ELEGI LA CARRERA DE {Carrera} YA QUE DESDE PEQUENO HE ESTADO APASIONADO Y TENIDO AFINIDADES POR LA MISMA.\n");
        }
    }
}
