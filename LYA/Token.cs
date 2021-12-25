using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYA
{
    //Lista de constantes
    public enum Tokens
    {
        Id,
        NumeroEntero,
        NumeroDecimal,
        Cadena,
        Caracter,
        SimboloSimple,
        SimboloDoble,
        OperadorLogico,
        OperadorAritmetico,
        OperadorAsignacion,
        OperadorRelacional,
        PalabraReservada,
        Desconocido
    }
    public class Token 
    {
        private Tokens tipoToken;
        private int valorToken;
        private String lexema;
        private int linea;

        public Tokens TipoToken { get => tipoToken; set => tipoToken = value; }
        public int ValorToken { get => valorToken; set => valorToken = value; }
        public string Lexema { get => lexema; set => lexema = value; }
        public int Linea { get => linea; set => linea = value; }
    }
}
