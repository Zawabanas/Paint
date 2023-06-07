using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {


        int size = 100;
        int size2 = 50;
        Control draggedPiece = null;
        bool resizing = false;
        private Point startDraggingPoint;
        private Size startSize;
        Rectangle rectProposedSize = Rectangle.Empty;
        int resizingMargin = 5;

        Pen Lapiz = new Pen(Color.Black);
        Brush brocha = new SolidBrush(Color.Blue);

        private bool drawing = false;
        private Point lastPoint;
        private Pen currentPen = new Pen(Color.Black, 5);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            size = (int)(pictureBox1.Width * .25);
        }

        /**** Métodos para el resize ****/
        void mouseDown(object sender, MouseEventArgs e)
        {
            draggedPiece = sender as Control;

            if ((e.X <= resizingMargin) || (e.X >= draggedPiece.Width - resizingMargin) ||
            (e.Y <= resizingMargin) || (e.Y >= draggedPiece.Height - resizingMargin))
            {
                resizing = true;
                this.Cursor = Cursors.SizeNWSE;

                this.startSize = new Size(e.X, e.Y);
                Point pt = this.PointToScreen(draggedPiece.Location);
                rectProposedSize = new Rectangle(pt, startSize);
                ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
            }
            else
            {
                resizing = false;
                this.Cursor = Cursors.SizeAll;
            }

            this.startDraggingPoint = e.Location;
        }

        

        void mouseUp(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                try
                {
                    if (rectProposedSize.Width > 0 && rectProposedSize.Height > 0)
                    {
                        ControlPaint.DrawReversibleFrame(rectProposedSize, this.ForeColor, FrameStyle.Dashed);
                    }
                    if (rectProposedSize.Width > 10 && rectProposedSize.Height > 10)
                    {
                        if (this.draggedPiece != null) this.draggedPiece.Size = rectProposedSize.Size;
                    }
                    else
                    {
                        this.draggedPiece.Size = new Size((int)Math.Max(10, rectProposedSize.Width), Math.Max(10, rectProposedSize.Height));
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }

            this.draggedPiece = null;
            this.startDraggingPoint = Point.Empty;
            this.Cursor = Cursors.Default;
        }
        /**** Fin métodos para el resize****/

        /****Métodos de dibujado****/
        void drawPictureBox(PictureBox pictureBox)
        {
            if (pictureBox == pictureBox1)
            {
                size = (int)(pictureBox.Width * .25);
            }


            if (pictureBox.Image != null)
            {
                clearPictureBox(pictureBox);
            }

            Graphics papel = pictureBox.CreateGraphics();
            papel.Clear(pictureBox.BackColor);

            //DIBUJAR
            if (CboxLinea.Checked)
            {
                if (pictureBox == pictureBox1)
                {
                    papel.DrawRectangle(Lapiz, (int)(pictureBox.Width * .1), (int)(pictureBox.Height * .20), 1, size);
                }

            }
            if (CboxRectangulo.Checked)
            {
                if (pictureBox == pictureBox1)
                {
                    papel.DrawRectangle(Lapiz, (int)(pictureBox.Width * .025), (int)(pictureBox.Height * .009), size, size / 2);
                }
            }
            if (CboxCuadrado.Checked)
            {
                if (pictureBox == pictureBox1)
                {
                    papel.DrawRectangle(Lapiz, (int)(pictureBox.Width * .15), (int)(pictureBox.Height * .25), size, size);
                }
            }
            if (CboxOvalo.Checked)
            {
                if (pictureBox == pictureBox1)
                {

                    Rectangle rect = new Rectangle((int)(pictureBox.Width * .20), (int)(pictureBox.Height * .35), (size / 2) + size, size);
                    papel.DrawEllipse(Lapiz, rect);
                }
            }
            if (CboxOvaloRelleno.Checked)
            {
                if (pictureBox == pictureBox1)
                {
                    Rectangle rect = new Rectangle((int)(pictureBox.Width * .30), (int)(pictureBox.Height * .15), (size / 2) + size, size);
                    papel.FillEllipse(brocha, rect);
                }
            }
            if (pictureBox == pictureBox1)
            {
                if (CboxRandom.Checked && CboxLinea.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(1, 1);
                    int alto = rnd.Next(50, 101);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawRectangle(Lapiz, rect);
                }
                if (CboxRandom.Checked && CboxRectangulo.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(80, 80);
                    int alto = rnd.Next(50, 50);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawRectangle(Lapiz, rect);
                }
                if (CboxRandom.Checked && CboxCuadrado.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(50, 50);
                    int alto = rnd.Next(50, 50);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawRectangle(Lapiz, rect);
                }
                if (CboxOvalo.Checked && CboxRandom.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(50, 101);
                    int alto = rnd.Next(50, 101);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.DrawEllipse(Lapiz, rect);
                }
                if (CboxOvaloRelleno.Checked && CboxRandom.Checked)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(pictureBox1.Width - 100);
                    int y = rnd.Next(pictureBox1.Height - 100);
                    int ancho = rnd.Next(50, 101);
                    int alto = rnd.Next(50, 101);
                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    papel.FillEllipse(brocha, rect);
                }
            }
        }

        /**** Fin métodos de dibujado ****/
        void clearPictureBox(PictureBox pictureBox)
        {
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                g.Clear(pictureBox.BackColor);
            }
            pictureBox.Invalidate();
        }


        /**** Color ****/
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentPen.Color = colorDialog.Color;
            }
        }

        private void btnColorRGB_Click(object sender, EventArgs e)
        {
            int r = 0, g = 0, b = 0;
            if (int.TryParse(txtR.Text, out r) && int.TryParse(txtG.Text, out g) && int.TryParse(txtB.Text, out b))
            {
                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    Lapiz.Color = Color.FromArgb(r, g, b);
                    txtB.BackColor = Color.FromArgb(0, 0, b);
                    txtG.BackColor = Color.FromArgb(0, g, 0);
                    txtR.BackColor = Color.FromArgb(r, 0, 0);
                    pictureCuadro.BackColor = Color.FromArgb(r, g, b);
                    if (r == 0 || g == 0 || b == 0)
                    {
                        if (r == 0 && g != 0 && b != 0) txtR.ForeColor = Color.FromArgb(255, 255, 255);

                        if (r != 0 && g == 0 && b != 0) txtG.ForeColor = Color.FromArgb(255, 255, 255);

                        if (r != 0 && g != 0 && b == 0) txtB.ForeColor = Color.FromArgb(255, 255, 255);

                        txtB.ForeColor = Color.FromArgb(255, 255, 255);
                        txtG.ForeColor = Color.FromArgb(255, 255, 255);
                        txtR.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        txtB.ForeColor = Color.FromArgb(255, 255, 255);
                        txtG.ForeColor = Color.FromArgb(255, 255, 255);
                        txtR.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese valores R, G y B válidos (entre 0 y 255).");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos para R, G y B.");
            }
        }


        /* Inicio solo Numeros en txt*/
        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        /* Fin solo Numeros en txt*/

        /**** ColorFin ****/



        private void btnDibujar_Click(object sender, EventArgs e)
        {
            drawPictureBox(pictureBox1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearPictureBox(pictureBox1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            currentPen.Color = pictureBox1.BackColor;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            lastPoint = e.Location;

            mouseDown(sender, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;

            mouseUp(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bmp;
                }
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(currentPen, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
                pictureBox1.Invalidate();

                txtR.Text = 0.ToString();
                txtG.Text = 0.ToString();
                txtB.Text = 0.ToString();
            }
            
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            drawPictureBox(pictureBox1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Guarda la imagen actual en el disco
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Carga la imagen seleccionada en el control PictureBox
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}