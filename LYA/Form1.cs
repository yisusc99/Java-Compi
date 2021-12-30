using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            var lexico = new Lexico(codigo.Text);
            lexico.ejecutarLexico();

            List<Error> listaErroresLexico = lexico.ErrorList;
            var lista = new BindingList<Token>(lexico.tokenList);

           var objSintactico = new Sintactico(lexico.tokenList);
           objSintactico.EjecutarSintactico(objSintactico.listaTokens);

            List<Error> listaErroresSintactico = objSintactico.listaError;
            List<Error> listaErrores =  listaErroresLexico.Union(listaErroresLexico).ToList();

            tablaLexico.DataSource = null;
            tablaLexico.DataSource = lista;

            tablaTokens.DataSource = null;
            tablaTokens.DataSource = listaErrores;

        }
    }
}
