namespace PrimerProyectoPPS
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
            splitContainer1 = new SplitContainer();
            listaAnimes = new ListBox();
            textBox5 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            botonAvanzar = new Button();
            botonRetroceder = new Button();
            AlturaField = new TextBox();
            EdadField = new TextBox();
            AnimeField = new TextBox();
            label5 = new Label();
            DescripcionField = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NombreField = new TextBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listaAnimes);
            splitContainer1.Panel1.Controls.Add(textBox5);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(botonAvanzar);
            splitContainer1.Panel2.Controls.Add(botonRetroceder);
            splitContainer1.Panel2.Controls.Add(AlturaField);
            splitContainer1.Panel2.Controls.Add(EdadField);
            splitContainer1.Panel2.Controls.Add(AnimeField);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(DescripcionField);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(NombreField);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(pictureBox);
            splitContainer1.Size = new Size(911, 892);
            splitContainer1.SplitterDistance = 272;
            splitContainer1.TabIndex = 0;
            // 
            // listaAnimes
            // 
            listaAnimes.FormattingEnabled = true;
            listaAnimes.ItemHeight = 15;
            listaAnimes.Location = new Point(12, 73);
            listaAnimes.Name = "listaAnimes";
            listaAnimes.Size = new Size(248, 199);
            listaAnimes.TabIndex = 5;
            listaAnimes.SelectedIndexChanged += listaAnimes_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(212, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(48, 23);
            textBox5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 303);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 3;
            label6.Text = "Nº registros";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(170, 377);
            button2.Name = "button2";
            button2.Size = new Size(90, 32);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 377);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 1;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            // 
            // botonAvanzar
            // 
            botonAvanzar.Location = new Point(478, 820);
            botonAvanzar.Name = "botonAvanzar";
            botonAvanzar.Size = new Size(103, 37);
            botonAvanzar.TabIndex = 12;
            botonAvanzar.Text = "SIGUIENTE";
            botonAvanzar.UseVisualStyleBackColor = true;
            botonAvanzar.Click += button4_Click;
            // 
            // botonRetroceder
            // 
            botonRetroceder.Location = new Point(79, 820);
            botonRetroceder.Name = "botonRetroceder";
            botonRetroceder.Size = new Size(107, 37);
            botonRetroceder.TabIndex = 11;
            botonRetroceder.Text = "ANTERIOR";
            botonRetroceder.UseVisualStyleBackColor = true;
            botonRetroceder.Click += button3_Click;
            // 
            // AlturaField
            // 
            AlturaField.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AlturaField.Location = new Point(414, 481);
            AlturaField.Name = "AlturaField";
            AlturaField.Size = new Size(100, 33);
            AlturaField.TabIndex = 10;
            // 
            // EdadField
            // 
            EdadField.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EdadField.Location = new Point(235, 481);
            EdadField.Name = "EdadField";
            EdadField.Size = new Size(66, 33);
            EdadField.TabIndex = 9;
            // 
            // AnimeField
            // 
            AnimeField.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AnimeField.Location = new Point(252, 393);
            AnimeField.Name = "AnimeField";
            AnimeField.Size = new Size(228, 33);
            AnimeField.TabIndex = 8;
            AnimeField.TextChanged += AnimeField_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(326, 479);
            label5.Name = "label5";
            label5.Size = new Size(82, 30);
            label5.TabIndex = 7;
            label5.Text = "Altura";
            // 
            // DescripcionField
            // 
            DescripcionField.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DescripcionField.ForeColor = Color.Black;
            DescripcionField.Location = new Point(170, 588);
            DescripcionField.Multiline = true;
            DescripcionField.Name = "DescripcionField";
            DescripcionField.Size = new Size(344, 199);
            DescripcionField.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(266, 544);
            label4.Name = "label4";
            label4.Size = new Size(155, 30);
            label4.TabIndex = 5;
            label4.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(153, 481);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(136, 400);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 3;
            label2.Text = "Anime";
            label2.Click += label2_Click;
            // 
            // NombreField
            // 
            NombreField.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NombreField.Location = new Point(252, 328);
            NombreField.Name = "NombreField";
            NombreField.Size = new Size(228, 33);
            NombreField.TabIndex = 2;
            NombreField.TextChanged += NombreField_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 331);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(136, 49);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(344, 223);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 892);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox;
        private Label label1;
        private TextBox NombreField;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox DescripcionField;
        private TextBox AlturaField;
        private TextBox EdadField;
        private TextBox AnimeField;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
        private ListBox listaAnimes;
        private Button botonAvanzar;
        private Button botonRetroceder;
    }
}