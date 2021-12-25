
namespace LYA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codigo = new System.Windows.Forms.TextBox();
            this.tablaLexico = new System.Windows.Forms.DataGridView();
            this.tablaTokens = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Compilador = new System.Windows.Forms.ToolStripMenuItem();
            this.run = new System.Windows.Forms.ToolStripMenuItem();
            this.afd = new System.Windows.Forms.ToolStripMenuItem();
            this.ttoken = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Ejecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLexico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTokens)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(12, 62);
            this.codigo.Multiline = true;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(487, 356);
            this.codigo.TabIndex = 1;
            // 
            // tablaLexico
            // 
            this.tablaLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLexico.Location = new System.Drawing.Point(505, 62);
            this.tablaLexico.Name = "tablaLexico";
            this.tablaLexico.RowTemplate.Height = 25;
            this.tablaLexico.Size = new System.Drawing.Size(388, 150);
            this.tablaLexico.TabIndex = 2;
            // 
            // tablaTokens
            // 
            this.tablaTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTokens.Location = new System.Drawing.Point(505, 268);
            this.tablaTokens.Name = "tablaTokens";
            this.tablaTokens.RowTemplate.Height = 25;
            this.tablaTokens.Size = new System.Drawing.Size(387, 150);
            this.tablaTokens.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lexema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Errores";
            // 
            // Archivo
            // 
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(60, 20);
            this.Archivo.Text = "Archivo";
            // 
            // Compilador
            // 
            this.Compilador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.run,
            this.afd,
            this.ttoken});
            this.Compilador.Name = "Compilador";
            this.Compilador.Size = new System.Drawing.Size(82, 20);
            this.Compilador.Text = "Compilador";
            // 
            // run
            // 
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(160, 22);
            this.run.Text = "Ejecutar";
            // 
            // afd
            // 
            this.afd.Name = "afd";
            this.afd.Size = new System.Drawing.Size(160, 22);
            this.afd.Text = "Automata Finito";
            // 
            // ttoken
            // 
            this.ttoken.Name = "ttoken";
            this.ttoken.Size = new System.Drawing.Size(160, 22);
            this.ttoken.Text = "Tabla de Tokens";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Compilador});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1132, 24);
            this.menu.TabIndex = 6;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(12, 27);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.Ejecutar.TabIndex = 7;
            this.Ejecutar.Text = "Ejecutar";
            this.Ejecutar.UseVisualStyleBackColor = true;
            this.Ejecutar.Click += new System.EventHandler(this.Ejecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.Ejecutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaTokens);
            this.Controls.Add(this.tablaLexico);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaLexico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTokens)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.DataGridView tLexico;
        private System.Windows.Forms.DataGridView tablaTokens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Compilador;
        private System.Windows.Forms.ToolStripMenuItem run;
        private System.Windows.Forms.ToolStripMenuItem afd;
        private System.Windows.Forms.ToolStripMenuItem ttoken;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Button Ejecutar;
        private System.Windows.Forms.DataGridView tablaLexico;
    }
}

