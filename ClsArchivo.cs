﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGarcia
{
    internal class ClsArchivo
    {
        public string nombreArchivo = "NuevoEmpleado.txt";
        public void Grabar(string datosConcatenados)
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true);
            AD.WriteLine(datosConcatenados);
            AD.Close();

        }
    }
}
