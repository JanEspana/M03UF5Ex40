namespace M03UF5Ex40
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            student_title = new Label();
            textBox1 = new TextBox();
            notas = new Label();
            NOTA1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            NOTA2 = new Label();
            textBox4 = new TextBox();
            NOTA3 = new Label();
            textBox5 = new TextBox();
            NOTA4 = new Label();
            exit = new Button();
            calc = new Button();
            clean = new Button();
            label2 = new Label();
            LowerText = new Label();
            conditionText = new Label();
            condition = new Label();
            label4 = new Label();
            label5 = new Label();
            lowestGrade = new Label();
            average = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 19);
            label1.TabIndex = 0;
            label1.Text = "CONTROL PROMEDIO DE NOTAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // student_title
            // 
            student_title.AutoSize = true;
            student_title.Location = new Point(16, 104);
            student_title.Name = "student_title";
            student_title.Size = new Size(67, 15);
            student_title.TabIndex = 1;
            student_title.Text = "ALUMNO/A";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 21);
            textBox1.TabIndex = 2;
            textBox1.Validating += textBox1_Validating;
            // 
            // notas
            // 
            notas.AutoSize = true;
            notas.Location = new Point(338, 105);
            notas.Name = "notas";
            notas.Size = new Size(105, 15);
            notas.TabIndex = 3;
            notas.Text = "Registro de notas";
            // 
            // NOTA1
            // 
            NOTA1.AutoSize = true;
            NOTA1.Location = new Point(358, 140);
            NOTA1.Name = "NOTA1";
            NOTA1.Size = new Size(45, 15);
            NOTA1.TabIndex = 4;
            NOTA1.Text = "NOTA1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(53, 21);
            textBox2.TabIndex = 5;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(417, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(53, 21);
            textBox3.TabIndex = 7;
            textBox3.Validating += textBox3_Validating;
            // 
            // NOTA2
            // 
            NOTA2.AutoSize = true;
            NOTA2.Location = new Point(417, 140);
            NOTA2.Name = "NOTA2";
            NOTA2.Size = new Size(45, 15);
            NOTA2.TabIndex = 6;
            NOTA2.Text = "NOTA2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(476, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(53, 21);
            textBox4.TabIndex = 9;
            textBox4.Validating += textBox4_Validating;
            // 
            // NOTA3
            // 
            NOTA3.AutoSize = true;
            NOTA3.Location = new Point(476, 140);
            NOTA3.Name = "NOTA3";
            NOTA3.Size = new Size(45, 15);
            NOTA3.TabIndex = 8;
            NOTA3.Text = "NOTA3";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(535, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(53, 21);
            textBox5.TabIndex = 11;
            textBox5.Validating += textBox5_Validating;
            // 
            // NOTA4
            // 
            NOTA4.AutoSize = true;
            NOTA4.Location = new Point(535, 140);
            NOTA4.Name = "NOTA4";
            NOTA4.Size = new Size(45, 15);
            NOTA4.TabIndex = 10;
            NOTA4.Text = "NOTA4";
            // 
            // exit
            // 
            exit.Location = new Point(513, 243);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 12;
            exit.Text = "SALIR";
            exit.UseVisualStyleBackColor = true;
            exit.MouseClick += exit_MouseClick;
            // 
            // calc
            // 
            calc.Location = new Point(16, 149);
            calc.Name = "calc";
            calc.Size = new Size(115, 30);
            calc.TabIndex = 13;
            calc.Text = "CALCULAR";
            calc.UseVisualStyleBackColor = true;
            calc.MouseClick += calc_MouseClick;
            // 
            // clean
            // 
            clean.Location = new Point(137, 148);
            clean.Name = "clean";
            clean.Size = new Size(115, 31);
            clean.TabIndex = 14;
            clean.Text = "LIMPIAR";
            clean.UseVisualStyleBackColor = true;
            clean.MouseClick += clean_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 207);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 15;
            label2.Text = "PROMEDIO DE NOTAS";
            // 
            // LowerText
            // 
            LowerText.AutoSize = true;
            LowerText.ImageAlign = ContentAlignment.MiddleRight;
            LowerText.Location = new Point(54, 234);
            LowerText.Name = "LowerText";
            LowerText.Size = new Size(95, 15);
            LowerText.TabIndex = 16;
            LowerText.Text = "NOTA MÁS BAJA";
            // 
            // conditionText
            // 
            conditionText.AutoSize = true;
            conditionText.ImageAlign = ContentAlignment.MiddleRight;
            conditionText.Location = new Point(73, 260);
            conditionText.Name = "conditionText";
            conditionText.Size = new Size(76, 15);
            conditionText.TabIndex = 17;
            conditionText.Text = "CONDICIÓN";
            // 
            // condition
            // 
            condition.AutoSize = true;
            condition.ImageAlign = ContentAlignment.MiddleRight;
            condition.Location = new Point(177, 260);
            condition.Name = "condition";
            condition.Size = new Size(10, 15);
            condition.TabIndex = 20;
            condition.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(177, 234);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 207);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 18;
            // 
            // lowestGrade
            // 
            lowestGrade.AutoSize = true;
            lowestGrade.ImageAlign = ContentAlignment.MiddleRight;
            lowestGrade.Location = new Point(177, 234);
            lowestGrade.Name = "lowestGrade";
            lowestGrade.Size = new Size(10, 15);
            lowestGrade.TabIndex = 21;
            lowestGrade.Text = " ";
            // 
            // average
            // 
            average.AutoSize = true;
            average.ImageAlign = ContentAlignment.MiddleRight;
            average.Location = new Point(177, 207);
            average.Name = "average";
            average.Size = new Size(10, 15);
            average.TabIndex = 22;
            average.Text = " ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 303);
            Controls.Add(average);
            Controls.Add(lowestGrade);
            Controls.Add(condition);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(conditionText);
            Controls.Add(LowerText);
            Controls.Add(label2);
            Controls.Add(clean);
            Controls.Add(calc);
            Controls.Add(exit);
            Controls.Add(textBox5);
            Controls.Add(NOTA4);
            Controls.Add(textBox4);
            Controls.Add(NOTA3);
            Controls.Add(textBox3);
            Controls.Add(NOTA2);
            Controls.Add(textBox2);
            Controls.Add(NOTA1);
            Controls.Add(notas);
            Controls.Add(textBox1);
            Controls.Add(student_title);
            Controls.Add(label1);
            Font = new Font("Arial", 9F);
            Name = "Form1";
            Text = "t";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label student_title;
        private TextBox textBox1;
        private Label notas;
        private Label NOTA1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label NOTA2;
        private TextBox textBox4;
        private Label NOTA3;
        private TextBox textBox5;
        private Label NOTA4;
        private Button exit;
        private Button calc;
        private Button clean;
        private Label label2;
        private Label LowerText;
        private Label conditionText;
        private Label condition;
        private Label label4;
        private Label label5;
        private Label lowestGrade;
        private Label average;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}
