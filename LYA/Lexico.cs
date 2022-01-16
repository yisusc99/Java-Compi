using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYA
{
    public class Lexico{
        public List<Error> ErrorList; //Lista de errores lexico, SALIDA.
        public List<Token> tokenList; // Atributo SALIDA del lexico.
        private String code; // Atributo de entrada del lexico.
        private int getCodeLine; //Atributo para anvanzar lineas en el lexico
                                 
        //Constructor de la clase lexico, inicializador de variables y receptor del codigo.
        public Lexico(String textBox){
            code = textBox + " ";
            tokenList = new List<Token>();
            ErrorList = new List<Error>();
        }

        //Matriz de transicion del automata finito para el analisis lexico
        private int[,] transitionArray =
            {
                /* 0 */  {2,1,7,8,9,10,20,-11,14,15,17,16,19,-30,-31,-32,-33,-34,-35,-36,-37,-38,-39,-40,18,-507,5,4,0,0,0,0,-507},
                /* 1 */  {1,1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,-500},
                /* 2 */  {2,-501,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,3,-2,-2,-2,-2,-2,-2,-2,-2,-2,-501},
                /* 3 */  {3,-502,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-502,-3,-3,-3,-3,-3,-3,-3,-502,-502,-502},
                /* 4 */  {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,-4,4,4,-503,4,-503},
                /* 5 */  {-504,6,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504},
                /* 6 */  {-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-504,-5,-504,-504,-504,-504,-504,-504},
                /* 7 */  {-6,-6,-23,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-6,-25,-6,-6,-6,-6,-6,-6,-6,-507},
                /* 8 */  {-7,-7,-7,-24,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-26,-7,-7,-7,-7,-7,-7,-7,-507},
                /* 9 */  {-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-8,-27,-8,-8,-8,-8,-8,-8,-8,-507},
                /* 10 */ {-9,-9,-9,-9,11,13,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-9,-28,-9,-9,-9,-9,-9,-9,-9,-507},
                /* 11 */ {11,11,11,11,12,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,-507},
                /* 12 */ {11,11,11,11,11,0,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,-507},
                /* 13 */ {13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,0,0,-507},
                /* 14 */ {-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-12,-15,-12,-12,-12,-12,-12,-12,-12,-507},
                /* 15 */ {-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-13,-14,-13,-13,-13,-13,-13,-13,-13,-507},
                /* 16 */ {-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-19,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-21,-507},
                /* 17 */ {-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-18,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-20,-507},
                /* 18 */ {-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-41,-16,-41,-41,-41,-41,-41,-41,-41,-507},
                /* 19 */ {-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-22,-17,-22,-22,-22,-22,-22,-22,-22,-507},
                /* 20 */ {-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-10,-29,-10,-10,-10,-10,-10,-10,-10,-507},
            };

        //Diccionario de palabras reservadas con sus tokens
        private Dictionary<string, int> lenguagesWords = new Dictionary<string, int>() {
                {"abstract",   -45 }, {"assert",     -46 }, {"boolean",    -47 }, {"break",      -48 },
                {"case" ,      -50 }, {"catch" ,     -51 }, {"char" ,      -52 }, {"class",      -53 },
                {"const" ,     -54 }, {"continue",   -55 }, {"default" ,   -56 }, {"do" ,        -57 },
                {"double",     -58 }, {"else" ,      -59 }, {"extends",    -61 }, {"final",      -62 },
                {"finally",    -63 }, {"float",      -64 }, {"for" ,       -65 }, {"if"   ,      -67 },
                {"implements", -68 }, {"import"  ,   -69 }, {"int"  ,      -71 }, {"new" ,       -75 },
                {"package",    -76 }, {"private",    -77 }, {"protected",  -78 }, {"public" ,    -79 },
                {"return" ,    -80 }, {"static",     -82 }, {"super",      -84 }, {"switch" ,    -85 },
                {"this" ,      -87 }, {"throw" ,     -88 }, {"throws" ,    -89 }, {"transient",  -90 },
                {"try" ,       -91 }, {"void" ,      -92 }, {"volatile" ,  -93 }, {"while" ,     -94 }, 
                {"lambda",     -99 }, {"sealed",    -100 }, {"string" ,   -101 }, {"true" ,     -102 },
                {"false" ,    -103 }
            };
       
        //Diccionario de caracteres junto con el numero de columna en la que se ubica en la matriz de transicion
        private Dictionary<char, int> lenguagesChars = new Dictionary<char, int>(){ 
              {'+',    2 }, {'-',    3 }, {'*',    4 }, {'/',    5 }, {'%' ,   6 }, {'^' ,   7 }, {'>',    8 }, {'<',    9 },
              {'&',   10 }, {'|',   11 }, {'!',   12 }, {'{',   13 }, {'}',   14 }, {'[',   15 }, {']',   16 }, {'(',   17 },
              {')',   18 }, {',',   19 }, {';',   20 }, {':',   21 }, {'.',   22 }, {'?',   23 }, {'=',   24 }, {'_',   25 },
              {'\'',  26 }, {'\"',  27 }, {'\t',  28 }, {' ',   29 }, {'\n',  30 }, {'\r',  31 }
            };

        //Diccionario de errores
        private Dictionary<int, string> errorMsg = new Dictionary<int, string>() { 
                {-500,"Identificador no valido."  }, {-501, "Numero entero no valido."},
                {-502, "Numero decimal no valido."}, {-503, "Formato de cadena no valida: se esperaba \"."},
                {-504, "Se esperaba un caracter." }, {-505, "Se esperaba el final de comentario."},
                {-506, "Palabra desconocida."     }, {-507, "Simbolo desconocido."},
                {-508, "Error insperado."}
            };

        //Metodo para obtener una palabra reservada reccorriendo el diccionario
        private int getReservedWords(String lexema){ return (lenguagesWords.ContainsKey(lexema))? lenguagesWords[lexema] : -1; }

        //Metodo para obtener columna en matriz dependiendo del caracter dado
        private int getTransitionMatrixColumns(char actualChar) { return (char.IsLetter(actualChar)) ? 1 : (char.IsDigit(actualChar)) ?   0 : lenguagesChars[actualChar]; }
        
        //Metodo para obtener el tipo de error
        private Error getError(int estado) { return new Error() { Codigo = estado, MensajeError = (estado <= -500 && estado >= -507) ? errorMsg[estado] : errorMsg[-508], Tipo = tipoError.Lexico, Linea = getCodeLine }; }

        //Metodo para obtener el tipo de lexema que esta en analisis    
        private Tokens getLexemeTokenType(int estado)
           {
                if (estado == -1) { return Tokens.Id; }
                else if (estado == -2) { return Tokens.NumeroEntero; }
                else if (estado == -3) { return Tokens.NumeroDecimal; }
                else if (estado == -4) { return Tokens.Cadena; }
                else if (estado == -5) { return Tokens.Caracter; }
                else if (estado<= -6 && estado >= -11) { return Tokens.OperadorAritmetico; }
                else if (estado <= -18 && estado >= -22) { return Tokens.OperadorLogico; }
                else if (estado <= -12 && estado >= -17) { return Tokens.OperadorRelacional; }
                else if (estado <= -23 && estado >= -29) { return Tokens.SimboloDoble; }
                else if (estado <= -30 && estado >= -44) { return Tokens.SimboloSimple; }
                else if (estado <= -45 && estado >= -109) { return Tokens.PalabraReservada; }
                else { return Tokens.Desconocido; }
           }

        //Metodo que hace la ejecucion del lexico, utilizando todo lo anteriormente definido en el programa
        private int getMatrixState = 0, getMatrixColumn = 0, codeLength;
        private char selectedlexemeChar;
        string lexeme = null;

        public List<Token> runLexicon()
        {
            getCodeLine = 1;
            codeLength = code.Length;
            
            for (int index = 0; index < code.ToCharArray().Length; index++){
               
                selectedlexemeChar = Convert.ToChar(code.Substring(index, 1));
                getCodeLine = (selectedlexemeChar.Equals('\n')) ? getCodeLine +  1 : getCodeLine;
                lexeme += selectedlexemeChar;  
                getMatrixColumn = getTransitionMatrixColumns(selectedlexemeChar);
                getMatrixState  = transitionArray[getMatrixState, getMatrixColumn];
            
                if (getMatrixState < 0 && getMatrixState > -500){ //estados finales
                    
                    if (lexeme.Length > 1){
                        if (getMatrixState == -4|| getMatrixState == -5 || getMatrixState  <= -14 && getMatrixState >= -19  || getMatrixState <= -23 && getMatrixState >= -29 ) { }
                        else { lexeme = lexeme.Remove(lexeme.Length - 1); index--; }
                    }

                    Token newToken = new Token() { ValorToken = getMatrixState, Lexema = lexeme, Linea = getCodeLine };
                    newToken.ValorToken = (getMatrixState == -1) ? getReservedWords(newToken.Lexema) : newToken.ValorToken;
                    newToken.TipoToken = getLexemeTokenType(newToken.ValorToken);
                    tokenList.Add(newToken);
                   
                    /*Reinicar variables*/
                    restartVars();

                }
                else if (getMatrixState <= -500) { ErrorList.Add(getError(getMatrixState)); restartVars(); }
                else if (getMatrixState == 0) { getMatrixColumn = 0; lexeme = null; }
                else if (getMatrixState == 10 && index == codeLength - 1 ) { ErrorList.Add(getError(-505) ) ; restartVars(); }
            }
            return tokenList;
        }

        private void restartVars(){
            getMatrixState = 0;
            getMatrixColumn = 0;
            lexeme = null;
        }
    }
}
