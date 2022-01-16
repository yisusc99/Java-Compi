
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
            this.tablaLexico = new System.Windows.Forms.DataGridView();
            this.tablaTokens = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ejecutar = new System.Windows.Forms.Button();
            this.cajadeCodigo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLexico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaLexico
            // 
            this.tablaLexico.AllowDrop = true;
            this.tablaLexico.AllowUserToAddRows = false;
            this.tablaLexico.AllowUserToDeleteRows = false;
            this.tablaLexico.AllowUserToOrderColumns = true;
            this.tablaLexico.AllowUserToResizeColumns = false;
            this.tablaLexico.AllowUserToResizeRows = false;
            this.tablaLexico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaLexico.BackgroundColor = System.Drawing.Color.White;
            this.tablaLexico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaLexico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLexico.GridColor = System.Drawing.Color.LightGray;
            this.tablaLexico.Location = new System.Drawing.Point(22, 386);
            this.tablaLexico.Name = "tablaLexico";
            this.tablaLexico.ReadOnly = true;
            this.tablaLexico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaLexico.RowTemplate.Height = 25;
            this.tablaLexico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaLexico.ShowCellToolTips = false;
            this.tablaLexico.Size = new System.Drawing.Size(395, 156);
            this.tablaLexico.TabIndex = 2;
            // 
            // tablaTokens
            // 
            this.tablaTokens.AllowDrop = true;
            this.tablaTokens.AllowUserToAddRows = false;
            this.tablaTokens.AllowUserToDeleteRows = false;
            this.tablaTokens.AllowUserToOrderColumns = true;
            this.tablaTokens.AllowUserToResizeColumns = false;
            this.tablaTokens.AllowUserToResizeRows = false;
            this.tablaTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTokens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tablaTokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaTokens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTokens.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaTokens.Location = new System.Drawing.Point(506, 386);
            this.tablaTokens.Name = "tablaTokens";
            this.tablaTokens.ReadOnly = true;
            this.tablaTokens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaTokens.RowTemplate.Height = 25;
            this.tablaTokens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTokens.Size = new System.Drawing.Size(387, 154);
            this.tablaTokens.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tokens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Errores";
            // 
            // Ejecutar
            // 
            this.Ejecutar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Ejecutar.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Ejecutar.FlatAppearance.BorderSize = 2;
            this.Ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ejecutar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ejecutar.ForeColor = System.Drawing.Color.White;
            this.Ejecutar.Location = new System.Drawing.Point(22, 10);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(98, 32);
            this.Ejecutar.TabIndex = 7;
            this.Ejecutar.Text = "Ejecutar";
            this.Ejecutar.UseVisualStyleBackColor = false;
            this.Ejecutar.Click += new System.EventHandler(this.Ejecutar_Click);
            // 
            // cajadeCodigo
            // 
            this.cajadeCodigo.BackColor = System.Drawing.Color.White;
            this.cajadeCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajadeCodigo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cajadeCodigo.ForeColor = System.Drawing.Color.Black;
            this.cajadeCodigo.Location = new System.Drawing.Point(22, 49);
            this.cajadeCodigo.Name = "cajadeCodigo";
            this.cajadeCodigo.Size = new System.Drawing.Size(901, 296);
            this.cajadeCodigo.TabIndex = 8;
            this.cajadeCodigo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(932, 552);
            this.Controls.Add(this.cajadeCodigo);
            this.Controls.Add(this.Ejecutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaTokens);
            this.Controls.Add(this.tablaLexico);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaLexico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tLexico;
        private System.Windows.Forms.DataGridView tablaTokens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ejecutar;
        private System.Windows.Forms.DataGridView tablaLexico;
        private System.Windows.Forms.RichTextBox cajadeCodigo;
    }
}

