namespace Practica7
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPregunta1 = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.pbAciertos = new System.Windows.Forms.ProgressBar();
            this.btEvaluar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numPregunta2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mCalendario = new System.Windows.Forms.MonthCalendar();
            this.lbAciertos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta 1.- ¿Cual es el Planeta mas grande del Sistema Solar?";
            // 
            // tbPregunta1
            // 
            this.tbPregunta1.Location = new System.Drawing.Point(15, 25);
            this.tbPregunta1.Name = "tbPregunta1";
            this.tbPregunta1.Size = new System.Drawing.Size(100, 20);
            this.tbPregunta1.TabIndex = 1;
            this.tbPregunta1.TextChanged += new System.EventHandler(this.tbPregunta1_TextChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(10, 172);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(76, 17);
            this.rb1.TabIndex = 2;
            this.rb1.TabStop = true;
            this.rb1.Text = "Caracteres";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // pbAciertos
            // 
            this.pbAciertos.Location = new System.Drawing.Point(15, 427);
            this.pbAciertos.Maximum = 10;
            this.pbAciertos.Name = "pbAciertos";
            this.pbAciertos.Size = new System.Drawing.Size(100, 23);
            this.pbAciertos.TabIndex = 3;
            // 
            // btEvaluar
            // 
            this.btEvaluar.Location = new System.Drawing.Point(470, 427);
            this.btEvaluar.Name = "btEvaluar";
            this.btEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btEvaluar.TabIndex = 5;
            this.btEvaluar.Text = "Calificar";
            this.btEvaluar.UseVisualStyleBackColor = true;
            this.btEvaluar.Click += new System.EventHandler(this.btEvaluar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pregunta 2.- ¿Cuanto es 2 + 2 / 2?";
            // 
            // numPregunta2
            // 
            this.numPregunta2.Location = new System.Drawing.Point(12, 73);
            this.numPregunta2.Name = "numPregunta2";
            this.numPregunta2.Size = new System.Drawing.Size(50, 20);
            this.numPregunta2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pregunta 3.- ¿Cuales ciudades pertenecen a México?";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(12, 126);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(83, 17);
            this.cb1.TabIndex = 9;
            this.cb1.Text = "Guadalajara";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(101, 126);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(73, 17);
            this.cb2.TabIndex = 10;
            this.cb2.Text = "Monterrey";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(180, 126);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(61, 17);
            this.cb3.TabIndex = 11;
            this.cb3.Text = "Cansas";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(239, 126);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(57, 17);
            this.cb4.TabIndex = 12;
            this.cb4.Text = "Florida";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(302, 126);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(81, 17);
            this.cb5.TabIndex = 13;
            this.cb5.Text = "Guanajuato";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pregunta 4.- ¿Que valores acepta un Int?";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(101, 172);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(61, 17);
            this.rb2.TabIndex = 15;
            this.rb2.TabStop = true;
            this.rb2.Text = "Enteros";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(192, 172);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(68, 17);
            this.rb3.TabIndex = 16;
            this.rb3.TabStop = true;
            this.rb3.Text = "Flotantes";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pregunta 5.- ¿En que fecha se lanzo C# ?";
            // 
            // mCalendario
            // 
            this.mCalendario.Location = new System.Drawing.Point(10, 214);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.TabIndex = 18;
            // 
            // lbAciertos
            // 
            this.lbAciertos.AutoSize = true;
            this.lbAciertos.Location = new System.Drawing.Point(12, 411);
            this.lbAciertos.Name = "lbAciertos";
            this.lbAciertos.Size = new System.Drawing.Size(20, 13);
            this.lbAciertos.TabIndex = 19;
            this.lbAciertos.Text = "\" \"";
            this.lbAciertos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 462);
            this.Controls.Add(this.lbAciertos);
            this.Controls.Add(this.mCalendario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPregunta2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEvaluar);
            this.Controls.Add(this.pbAciertos);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.tbPregunta1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPregunta1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.ProgressBar pbAciertos;
        private System.Windows.Forms.Button btEvaluar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPregunta2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar mCalendario;
        public System.Windows.Forms.Label lbAciertos;
    }
}

