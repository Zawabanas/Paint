namespace Paint
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            CboxRandom = new CheckBox();
            txtpallete = new Label();
            txTiitulo2 = new Label();
            btnCargar = new Button();
            btnGuardar = new Button();
            pictureCuadro = new PictureBox();
            lbB = new Label();
            lbG = new Label();
            lbR = new Label();
            btnColorRGB = new Button();
            txtR = new TextBox();
            txtB = new TextBox();
            txtG = new TextBox();
            btnColor = new Button();
            btnDibujar = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtTitulo = new Label();
            CboxOvaloRelleno = new CheckBox();
            CboxOvalo = new CheckBox();
            CboxCuadrado = new CheckBox();
            CboxRectangulo = new CheckBox();
            CboxLinea = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCuadro).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Location = new Point(448, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(947, 677);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            pictureBox1.Resize += pictureBox1_Resize;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(CboxRandom);
            panel1.Controls.Add(txtpallete);
            panel1.Controls.Add(txTiitulo2);
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(pictureCuadro);
            panel1.Controls.Add(lbB);
            panel1.Controls.Add(lbG);
            panel1.Controls.Add(lbR);
            panel1.Controls.Add(btnColorRGB);
            panel1.Controls.Add(txtR);
            panel1.Controls.Add(txtB);
            panel1.Controls.Add(txtG);
            panel1.Controls.Add(btnColor);
            panel1.Controls.Add(btnDibujar);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(CboxOvaloRelleno);
            panel1.Controls.Add(CboxOvalo);
            panel1.Controls.Add(CboxCuadrado);
            panel1.Controls.Add(CboxRectangulo);
            panel1.Controls.Add(CboxLinea);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 677);
            panel1.TabIndex = 2;
            // 
            // CboxRandom
            // 
            CboxRandom.AutoSize = true;
            CboxRandom.Location = new Point(29, 273);
            CboxRandom.Name = "CboxRandom";
            CboxRandom.Size = new Size(87, 24);
            CboxRandom.TabIndex = 23;
            CboxRandom.Text = "Random";
            CboxRandom.UseVisualStyleBackColor = true;
            // 
            // txtpallete
            // 
            txtpallete.AutoSize = true;
            txtpallete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtpallete.Location = new Point(38, 346);
            txtpallete.Name = "txtpallete";
            txtpallete.Size = new Size(182, 23);
            txtpallete.TabIndex = 22;
            txtpallete.Text = "Abrir paleta de colores";
            // 
            // txTiitulo2
            // 
            txTiitulo2.AutoSize = true;
            txTiitulo2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txTiitulo2.Location = new Point(17, 300);
            txTiitulo2.Name = "txTiitulo2";
            txTiitulo2.Size = new Size(135, 28);
            txTiitulo2.TabIndex = 20;
            txTiitulo2.Text = "Cambiar color";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(168, 616);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 18;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(41, 616);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureCuadro
            // 
            pictureCuadro.BackColor = Color.White;
            pictureCuadro.Location = new Point(242, 407);
            pictureCuadro.Name = "pictureCuadro";
            pictureCuadro.Size = new Size(146, 94);
            pictureCuadro.TabIndex = 3;
            pictureCuadro.TabStop = false;
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new Point(34, 511);
            lbB.Name = "lbB";
            lbB.Size = new Size(21, 20);
            lbB.TabIndex = 16;
            lbB.Text = "B:";
            // 
            // lbG
            // 
            lbG.AutoSize = true;
            lbG.Location = new Point(34, 464);
            lbG.Name = "lbG";
            lbG.Size = new Size(22, 20);
            lbG.TabIndex = 15;
            lbG.Text = "G:";
            // 
            // lbR
            // 
            lbR.AutoSize = true;
            lbR.Location = new Point(34, 410);
            lbR.Name = "lbR";
            lbR.Size = new Size(21, 20);
            lbR.TabIndex = 14;
            lbR.Text = "R:";
            // 
            // btnColorRGB
            // 
            btnColorRGB.Location = new Point(242, 507);
            btnColorRGB.Name = "btnColorRGB";
            btnColorRGB.Size = new Size(146, 29);
            btnColorRGB.TabIndex = 13;
            btnColorRGB.Text = "Aplicar";
            btnColorRGB.UseVisualStyleBackColor = true;
            btnColorRGB.Click += btnColorRGB_Click;
            // 
            // txtR
            // 
            txtR.Location = new Point(61, 410);
            txtR.Name = "txtR";
            txtR.Size = new Size(125, 27);
            txtR.TabIndex = 12;
            txtR.KeyPress += txtR_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(61, 507);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 11;
            txtB.KeyPress += txtB_KeyPress;
            // 
            // txtG
            // 
            txtG.Location = new Point(61, 457);
            txtG.Name = "txtG";
            txtG.Size = new Size(125, 27);
            txtG.TabIndex = 10;
            txtG.KeyPress += txtG_KeyPress;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(242, 344);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(146, 29);
            btnColor.TabIndex = 9;
            btnColor.Text = "Cambiar color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnDibujar
            // 
            btnDibujar.Location = new Point(281, 177);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(94, 29);
            btnDibujar.TabIndex = 8;
            btnDibujar.Text = "Dibujar";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(281, 124);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(281, 71);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(17, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(78, 38);
            txtTitulo.TabIndex = 5;
            txtTitulo.Text = "Paint";
            // 
            // CboxOvaloRelleno
            // 
            CboxOvaloRelleno.AutoSize = true;
            CboxOvaloRelleno.Location = new Point(29, 232);
            CboxOvaloRelleno.Name = "CboxOvaloRelleno";
            CboxOvaloRelleno.Size = new Size(124, 24);
            CboxOvaloRelleno.TabIndex = 4;
            CboxOvaloRelleno.Text = "Ovalo Relleno";
            CboxOvaloRelleno.UseVisualStyleBackColor = true;
            // 
            // CboxOvalo
            // 
            CboxOvalo.AutoSize = true;
            CboxOvalo.Location = new Point(29, 191);
            CboxOvalo.Name = "CboxOvalo";
            CboxOvalo.Size = new Size(70, 24);
            CboxOvalo.TabIndex = 3;
            CboxOvalo.Text = "Ovalo";
            CboxOvalo.UseVisualStyleBackColor = true;
            // 
            // CboxCuadrado
            // 
            CboxCuadrado.AutoSize = true;
            CboxCuadrado.Location = new Point(29, 145);
            CboxCuadrado.Name = "CboxCuadrado";
            CboxCuadrado.Size = new Size(96, 24);
            CboxCuadrado.TabIndex = 2;
            CboxCuadrado.Text = "Cuadrado";
            CboxCuadrado.UseVisualStyleBackColor = true;
            // 
            // CboxRectangulo
            // 
            CboxRectangulo.AutoSize = true;
            CboxRectangulo.Location = new Point(29, 99);
            CboxRectangulo.Name = "CboxRectangulo";
            CboxRectangulo.Size = new Size(106, 24);
            CboxRectangulo.TabIndex = 1;
            CboxRectangulo.Text = "Rectangulo";
            CboxRectangulo.UseVisualStyleBackColor = true;
            // 
            // CboxLinea
            // 
            CboxLinea.AutoSize = true;
            CboxLinea.Location = new Point(29, 58);
            CboxLinea.Name = "CboxLinea";
            CboxLinea.Size = new Size(66, 24);
            CboxLinea.TabIndex = 0;
            CboxLinea.Text = "Linea";
            CboxLinea.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 701);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCuadro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnDibujar;
        private Button btnDelete;
        private Button btnClear;
        private Label txtTitulo;
        private CheckBox CboxOvaloRelleno;
        private CheckBox CboxOvalo;
        private CheckBox CboxCuadrado;
        private CheckBox CboxRectangulo;
        private CheckBox CboxLinea;
        private Label lbB;
        private Label lbG;
        private Label lbR;
        private Button btnColorRGB;
        private TextBox txtR;
        private TextBox txtB;
        private TextBox txtG;
        private Button btnColor;
        private PictureBox pictureCuadro;
        private Label txtpallete;
        private Label label2;
        private Label txTiitulo2;
        private Button btnCargar;
        private Button btnGuardar;
        private CheckBox CboxRandom;
    }
}