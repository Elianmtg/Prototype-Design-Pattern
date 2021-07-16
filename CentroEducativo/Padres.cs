using System;
using System.Collections.Generic;
using System.Text;

namespace CentroEducativo
{
    class Padres : ICloneable
    {
        public string NombreP { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Pais { get; set; }
        public string SeguroMedico { get; set; }
        public string Trabajo { get; set; }

        public object Clone()
        {
            return MemberwiseClone();//CLONADO SUPERFICIAL
        }

        public override string ToString()
        {
            //return $"NOMBRE: {NombreP}, TELEFONO: {Telefono}, CEDULA: {Cedula}, PAIS: {Pais}, SEGURO MEDICO: {SeguroMedico}, TRABAJA: {Trabajo}.";
            return $"NOMBRE: {NombreP}\nTELEFONO: {Telefono}\nCEDULA: {Cedula}\nPAIS: {Pais}\nSEGURO MEDICO: {SeguroMedico}\nTRABAJA: {Trabajo}.";
        }
        public void Vacunar()
        {
            Console.WriteLine($"MI SEGURO MEDICO {SeguroMedico} CUBRIRA LA VACUNA CONTRA EL COVID-19.");
        }
        public void Residir()
        {
            Console.WriteLine($"YO RESIDO EN {Pais} PORQUE ME ENCANTA ESTE MARAVILLOSO PAIS.");
        }
        public void Llamar()
        {
            Console.WriteLine($"LLAMAME CUANDO GUSTES MI NUMERO TELEFONICO ES: {Telefono}.\n");
        }
    }
}
