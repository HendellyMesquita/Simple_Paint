using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FomSimplePaint : Form
    {

        private float espessuraCaneta;
        private bool flagPint = false;
        private bool flagApagar = false;
        private Graphics graphicsPainel;
        private Graphics graphicsImageSave;
        private Image imageSave;
        public FomSimplePaint()
        {
            InitializeComponent();

            PaineldeControle();
        }

        private void PaineldeControle()
        {

            for (int i = 2; i <= 50; i += 2)
            {
                CbTamanho.Items.Add(i);
            }
            CbTamanho.Text = "4";

            CbTamanho.MaxDropDownItems = 5;
            CbTamanho.IntegralHeight = false; //nescessario para que seja possivel definir a quantidade de itens exibidos na combobox

            graphicsPainel = PanelPaint.CreateGraphics();
            espessuraCaneta = float.Parse(CbTamanho.Text);

            imageSave = new Bitmap(PanelPaint.Width, PanelPaint.Height);
            graphicsImageSave = Graphics.FromImage(imageSave);
            graphicsImageSave.Clear(PanelPaint.BackColor);
        }

        private void BtnCor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var cor = colorDialog.ShowDialog();

            if (cor == DialogResult.OK)
                BtnCor.BackColor = colorDialog.Color;
        }

        private void CbTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(CbTamanho.SelectedItem.ToString());
        }

        private void BtnBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if (!flagApagar)
            {
            flagApagar = true;
            }
            else
            {
                flagApagar = false;

            }
        }

        private void PanelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            flagPint = true;
        }
        private void PanelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            flagPint = false;
        }

        private void PanelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPint)
            {
                if (!flagApagar)
                {

                    graphicsPainel.DrawEllipse(new Pen(BtnCor.BackColor, espessuraCaneta),
                   new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));

                    graphicsImageSave.DrawEllipse(new Pen(BtnCor.BackColor, espessuraCaneta),
                    new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    graphicsPainel.DrawRectangle(new Pen(BtnBorracha.BackColor, espessuraCaneta),
                   new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));

                    graphicsImageSave.DrawRectangle(new Pen(BtnBorracha.BackColor, espessuraCaneta),
                   new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Todo trabalho não salvo será deletado.", "Apagar Desenho",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                graphicsPainel.Clear(Color.White);

                imageSave = new Bitmap(PanelPaint.Width, PanelPaint.Height);
                graphicsImageSave = Graphics.FromImage(imageSave);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "png|.png|jpeg|.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imageSave.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imageSave.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void PanelPaint_Resize(object sender, EventArgs e)
        {
            graphicsImageSave = PanelPaint.CreateGraphics();
            var imageTemporaria = new Bitmap(PanelPaint.Width, PanelPaint.Height);
            var graphicsImgTamp = Graphics.FromImage(imageTemporaria);
            graphicsImgTamp.DrawImage(imageTemporaria, 0, 0);
            imageSave = imageTemporaria;
            graphicsImageSave = graphicsImgTamp;
        }
    }
}
