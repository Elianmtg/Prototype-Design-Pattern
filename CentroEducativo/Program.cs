using System;
using System.IO;

namespace CentroEducativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Padres padres0 = new Padres();
            Alumnos alumnos0 = new Alumnos();

            ////CLON PADRE CON CASTEO
            Padres padres1 = (Padres)padres0.Clone();
            Padres padres2 = (Padres)padres0.Clone();
            Padres padres3 = (Padres)padres0.Clone();

            //CLON ALUMNOS CON CASTEO
            Alumnos alumnos1 = (Alumnos)alumnos0.Clone();
            Alumnos alumnos2 = (Alumnos)alumnos0.Clone();
            Alumnos alumnos3 = (Alumnos)alumnos0.Clone();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                  CENTRO EDUCATIVO:                               ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            Console.ResetColor();

            Console.WriteLine("                                  INSERTE LOS DATOS DEL PADRE:                                  \n");
            Console.WriteLine("INGRESE EL NOMBRE:");
            padres0.NombreP = Console.ReadLine();
            Console.WriteLine("INGRESE EL TELEFONO:");
            padres0.Telefono = Console.ReadLine();
            Console.WriteLine("INGRESE LA CEDULA:");
            padres0.Cedula = Console.ReadLine();
            Console.WriteLine("INGRESE EL PAIS:");
            padres0.Pais = Console.ReadLine();
            Console.WriteLine("INGRESE EL SEGURO MEDIDO:");
            padres0.SeguroMedico = Console.ReadLine();
            Console.WriteLine("TRABAJA, INGRESE SI O NO:");
            padres0.Trabajo = Console.ReadLine();
            Console.WriteLine("\n                                 INSERTE LOS DATOS DEL ALUMNO:                                  \n");
            Console.WriteLine("INGRESE EL NOMBRE:");
            alumnos0.Nombre = Console.ReadLine();
            Console.WriteLine("INGRESE LA FECHA DE NACIMIENTO:");
            alumnos0.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("INGRESE LA EDAD:");
            alumnos0.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE LA MATRICULA:");
            alumnos0.Matricula = Console.ReadLine();
            Console.WriteLine("INGRESE LA CARRERA:");
            alumnos0.Carrera = Console.ReadLine();
            Console.WriteLine("INGRESE EL GENERO, M-F:");
            alumnos0.Genero = Console.ReadLine();
            #region DATOS ORIGINALES DEL PADRE
            /*-----------------------------------------DATOS ORIGINALES DEL PADRE-----------------------------------------*/
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n                                  DATOS ORIGINALES DEL PADRE:                                  \n");
            ////SI DESEA QUE EL PROGRAMA CORRA DIRECTO DESCOMENTE ESTA PARTE Y COMENTE LA PARTE DE INGRESAR
            //padres0.NombreP = "Jesus";
            //padres0.Telefono = "809-000-1111";
            //padres0.Cedula = "402-1234567-8";
            //padres0.Pais = "Republica Dominicana";
            //padres0.SeguroMedico = "ARS Humano";
            //padres0.Trabajo = "Si";

            Console.WriteLine($"{padres0.ToString()}\n");

            padres0.Vacunar();
            padres0.Residir();
            padres0.Llamar();

            Console.ResetColor();
            Console.ReadKey();
            #endregion
            #region DATOS ORIGINALES DEL ALUMNO
            /*-----------------------------------------DATOS ORIGINALES DEL ALUMNO-----------------------------------------*/
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n                                    DATOS ORIGINALES DEL ALUMNO:                                  \n");
            ////LO MISMO AQUI, SI DESEA QUE EL PROGRAMA CORRA DIRECTO DESCOMENTE ESTA PARTE Y COMENTE LA PARTE DE INGRESAR
            //alumnos0.Nombre = "Elian";
            //alumnos0.FechaNacimiento = "19/10/2001";
            //alumnos0.Edad = 19;
            //alumnos0.Matricula = "2019-8498";
            //alumnos0.Carrera = "Software";
            //alumnos0.Genero = "M";

            alumnos0.padreComposicion.NombreP = padres0.NombreP;
            alumnos0.padreComposicion.Telefono = padres0.Telefono;

            Console.WriteLine($"{alumnos0.ToString()}");

            alumnos0.Presentacion();
            alumnos0.Cumpleanos();
            alumnos0.CarreraM();

            Console.ResetColor();
            Console.ReadKey();
            #endregion

            #region CLONES DEL PADRE
            /*-----------------------------------------CLONES DEL PADRE-----------------------------------------*/

            //Padres padres1 = (Padres)padres0.Clone();//CLON 1 DEL PADRE CON CASTEO

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n                                  CLONES DEL PADRE:                                  \n");

            padres1.NombreP = "Joaquin";
            padres1.Telefono = "809-111-5555";
            padres1.Cedula = "037-1234567-8";
            padres1.Pais = "Republica Dominicana";
            padres1.SeguroMedico = "ARS Palic";
            padres1.Trabajo = "Si";

            Console.WriteLine($"{padres1.ToString()}\n");

            padres1.Vacunar();
            padres1.Residir();
            padres1.Llamar();

            //Padres padres2 = (Padres)padres0.Clone();//CLON 2 DEL PADRE CON CASTEO

            padres2.NombreP = "Arison";
            padres2.Telefono = "809-000-4444";
            padres2.Cedula = "402-1234568-9";
            padres2.Pais = "Republica Dominicana";
            padres2.SeguroMedico = "ARS Humano";
            padres2.Trabajo = "No";

            Console.WriteLine($"{padres2.ToString()}\n");

            padres2.Vacunar();
            padres2.Residir();
            padres2.Llamar();

            //Padres padres3 = (Padres)padres0.Clone();//CLON 3 DEL PADRE CON CASTEO

            padres3.NombreP = "Santiago";
            padres3.Telefono = "809-000-2222";
            padres3.Cedula = "032-1234567-8";
            padres3.Pais = "Republica Dominicana";
            padres3.SeguroMedico = "ARS Universal";
            padres3.Trabajo = "Si";

            Console.WriteLine($"{padres3.ToString()}\n");

            padres3.Vacunar();
            padres3.Residir();
            padres3.Llamar();

            Console.ResetColor();
            Console.ReadKey();
            #endregion
            #region CLONES DEL ALUMNO
            /*-----------------------------------------CLONES DEL ALUMNO-----------------------------------------*/
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                  CLONES DEL ALUMNO:                                  \n");

            //Alumnos alumnos1 = (Alumnos)alumnos0.Clone();//CLON 1 DEL ALUMNO CON CASTEO

            alumnos1.Nombre = "Elian";
            alumnos1.FechaNacimiento = "19/10/2001";
            alumnos1.Edad = 19;
            alumnos1.Matricula = "2019-8498";
            alumnos1.Carrera = "Software";
            alumnos1.Genero = "M";

            alumnos1.padreComposicion.NombreP = padres1.NombreP;
            alumnos1.padreComposicion.Telefono = padres1.Telefono;

            Console.WriteLine($"{alumnos1.ToString()}");

            alumnos1.Presentacion();
            alumnos1.Cumpleanos();
            alumnos1.CarreraM();

            //Alumnos alumnos2 = (Alumnos)alumnos0.Clone();//CLON 2 DEL ALUMNO CON CASTEO

            alumnos2.Nombre = "Elian";
            alumnos2.FechaNacimiento = "19/10/2001";
            alumnos2.Edad = 19;
            alumnos2.Matricula = "2019-8498";
            alumnos2.Carrera = "Software";
            alumnos2.Genero = "M";

            alumnos2.padreComposicion.NombreP = padres2.NombreP;
            alumnos2.padreComposicion.Telefono = padres2.Telefono;

            Console.WriteLine($"{alumnos2.ToString()}");

            alumnos2.Presentacion();
            alumnos2.Cumpleanos();
            alumnos2.CarreraM();

            //Alumnos alumnos3 = (Alumnos)alumnos0.Clone();//CLON 3 DEL ALUMNO CON CASTEO

            alumnos3.Nombre = "Elian";
            alumnos3.FechaNacimiento = "19/10/2001";
            alumnos3.Edad = 19;
            alumnos3.Matricula = "2019-8498";
            alumnos3.Carrera = "Software";
            alumnos3.Genero = "M";

            alumnos3.padreComposicion.NombreP = padres3.NombreP;
            alumnos3.padreComposicion.Telefono = padres3.Telefono;

            Console.WriteLine($"{alumnos3.ToString()}");

            alumnos3.Presentacion();
            alumnos3.Cumpleanos();
            alumnos3.CarreraM();

            Console.ResetColor();
            Console.ReadKey();
            #endregion
            #region TXT
            TextWriter TXT = new StreamWriter("PROTOTYPE.txt");
            TXT.WriteLine("                                  DATOS ORIGINALES DEL PADRE:                                  \n");
            TXT.WriteLine($"{padres0.ToString()}\n");
            TXT.WriteLine("                                  DATOS ORIGINALES DEL ALUMNO:                                  \n");
            TXT.WriteLine($"{alumnos0.ToString()}\n");
            TXT.WriteLine("                                  CLONES DEL PADRE:                                  \n");
            TXT.WriteLine($"{padres1.ToString()}\n");
            TXT.WriteLine($"{padres2.ToString()}\n");
            TXT.WriteLine($"{padres3.ToString()}\n");
            TXT.WriteLine("                                  CLONES DEL ALUMNO:                                  \n");
            TXT.WriteLine($"{alumnos1.ToString()}\n");
            TXT.WriteLine($"{alumnos2.ToString()}\n");
            TXT.WriteLine($"{alumnos3.ToString()}\n");
            TXT.Close();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TXT GUARDADO CON EXITO!!!");
            Console.ResetColor();
            #endregion
        }
    }
}
