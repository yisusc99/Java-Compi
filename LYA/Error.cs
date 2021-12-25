using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYA
{
        public enum tipoError { 
            Lexico,
            Sintactico
        }

    public class Error {
        private int codigo;
        private string mensajeError;
        private tipoError tipo;
        private int linea;

        public int Codigo { get => codigo; set => codigo = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public tipoError Tipo { get => tipo; set => tipo = value; }
        public int Linea { get => linea; set => linea = value; }
    }
}
