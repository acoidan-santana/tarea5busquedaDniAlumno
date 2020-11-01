using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Controlador;

namespace ProyectoInicialClases
{
    static class Program
    {
        [STAThread]

        static void Main()
        {
            ControladorInicial inicio = new ControladorInicial();

            inicio.Iniciar();
        }

    }
}
