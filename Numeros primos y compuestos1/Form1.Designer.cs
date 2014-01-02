namespace Numeros_primos_y_compuestos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_Compuestos = new System.Windows.Forms.ListBox();
            this.ListBox_Primos = new System.Windows.Forms.ListBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox_Final = new System.Windows.Forms.TextBox();
            this.TextBox_Inicial = new System.Windows.Forms.TextBox();
            this.Button_Clean = new System.Windows.Forms.Button();
            this.Button_Run = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_Compuestos
            // 
            this.ListBox_Compuestos.FormattingEnabled = true;
            this.ListBox_Compuestos.Location = new System.Drawing.Point(84, 19);
            this.ListBox_Compuestos.Name = "ListBox_Compuestos";
            this.ListBox_Compuestos.Size = new System.Drawing.Size(64, 251);
            this.ListBox_Compuestos.TabIndex = 3;
            // 
            // ListBox_Primos
            // 
            this.ListBox_Primos.FormattingEnabled = true;
            this.ListBox_Primos.Location = new System.Drawing.Point(15, 19);
            this.ListBox_Primos.Name = "ListBox_Primos";
            this.ListBox_Primos.Size = new System.Drawing.Size(58, 251);
            this.ListBox_Primos.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(39, 98);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 15);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Primos";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(98, 98);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 15);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Compuestos";
            // 
            // TextBox_Final
            // 
            this.TextBox_Final.Location = new System.Drawing.Point(108, 61);
            this.TextBox_Final.Name = "TextBox_Final";
            this.TextBox_Final.Size = new System.Drawing.Size(57, 20);
            this.TextBox_Final.TabIndex = 14;
            // 
            // TextBox_Inicial
            // 
            this.TextBox_Inicial.Location = new System.Drawing.Point(32, 61);
            this.TextBox_Inicial.Name = "TextBox_Inicial";
            this.TextBox_Inicial.Size = new System.Drawing.Size(58, 20);
            this.TextBox_Inicial.TabIndex = 13;
            // 
            // Button_Clean
            // 
            this.Button_Clean.Location = new System.Drawing.Point(108, 426);
            this.Button_Clean.Name = "Button_Clean";
            this.Button_Clean.Size = new System.Drawing.Size(75, 23);
            this.Button_Clean.TabIndex = 12;
            this.Button_Clean.Text = "Clean";
            this.Button_Clean.UseVisualStyleBackColor = true;
            this.Button_Clean.Click += new System.EventHandler(this.Button_Clean_Click);
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(15, 426);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 11;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(115, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 15);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Final";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(39, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 15);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Inicio";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupBox1.Controls.Add(this.ListBox_Compuestos);
            this.GroupBox1.Controls.Add(this.ListBox_Primos);
            this.GroupBox1.Location = new System.Drawing.Point(17, 116);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GroupBox1.Size = new System.Drawing.Size(166, 285);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 480);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox_Final);
            this.Controls.Add(this.TextBox_Inicial);
            this.Controls.Add(this.Button_Clean);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox ListBox_Compuestos;
        internal System.Windows.Forms.ListBox ListBox_Primos;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox_Final;
        internal System.Windows.Forms.TextBox TextBox_Inicial;
        internal System.Windows.Forms.Button Button_Clean;
        internal System.Windows.Forms.Button Button_Run;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}

