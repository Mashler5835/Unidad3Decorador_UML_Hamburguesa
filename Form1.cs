using System.Text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Drawing.Imaging;

namespace Carlsjr_Patrones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatosIniciales();
            pictureBoxPreview.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void CargarDatosIniciales()
        {
            cmbHamburguesa.Items.Add("Famous Star");
            cmbHamburguesa.Items.Add("Western Bacon");
            cmbHamburguesa.Items.Add("Super Star");
            cmbHamburguesa.SelectedIndex = 0;

            cmbPapas.Items.Add("Sin papas");
            cmbPapas.Items.Add("Papas a la francesa");
            cmbPapas.Items.Add("Papas Crisscut");
            cmbPapas.Items.Add("Papas Curly");
            cmbPapas.SelectedIndex = 0;

            cmbBebida.Items.Add("Sin bebida");
            cmbBebida.Items.Add("Refresco chico");
            cmbBebida.Items.Add("Refresco mediano");
            cmbBebida.Items.Add("Refresco grande");
            cmbBebida.SelectedIndex = 0;

            cmbEntrega.Items.Add("En restaurante");
            cmbEntrega.Items.Add("Para llevar");
            cmbEntrega.Items.Add("Drive Thru");
            cmbEntrega.SelectedIndex = 0;
        }

        private Hamburguesa CrearHamburguesaBase()
        {
            switch (cmbHamburguesa.Text)
            {
                case "Famous Star":
                    return new FamousStar();
                case "Western Bacon":
                    return new WesternBacon();
                case "Super Star":
                    return new SuperStar();
                default:
                    return new FamousStar();
            }
        }

        private Papas CrearPapas()
        {
            switch (cmbPapas.Text)
            {
                case "Papas a la francesa":
                    return new PapasFrancesa();
                case "Papas Crisscut":
                    return new PapasCrisscut();
                case "Papas Curly":
                    return new PapasCurly();
                default:
                    return new SinPapas();
            }
        }


        private Bebida CrearBebida()
        {
            switch (cmbBebida.Text)
            {
                case "Refresco chico":
                    return new RefrescoChico();
                case "Refresco mediano":
                    return new RefrescoMediano();
                case "Refresco grande":
                    return new RefrescoGrande();
                default:
                    return new SinBebida();
            }
        }

        private ITipoEntrega CrearTipoEntrega()
        {
            switch (cmbEntrega.Text)
            {
                case "En restaurante":
                    return new EnRestaurante();
                case "Para llevar":
                    return new ParaLlevar();
                case "Drive Thru":
                    return new DriveThru();
                default:
                    return new EnRestaurante();
            }
        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = CrearHamburguesaBase();

            if (chkQueso.Checked)
                hamburguesa = new ExtraQueso(hamburguesa);

            if (chkTocino.Checked)
                hamburguesa = new ExtraTocino(hamburguesa);

            if (chkJalapenos.Checked)
                hamburguesa = new Jalapenos(hamburguesa);

            if (chkArosCebolla.Checked)
                hamburguesa = new ArosDeCebolla(hamburguesa);

            if (chkGuacamole.Checked)
                hamburguesa = new Guacamole(hamburguesa);

            if (chkSinCebolla.Checked)
                hamburguesa = new SinCebolla(hamburguesa);

            if (chkSinTomate.Checked)
                hamburguesa = new SinTomate(hamburguesa);

            if (chkSinPepinillos.Checked)
                hamburguesa = new SinPepinillos(hamburguesa);

            Papas papas = CrearPapas();
            Bebida bebida = CrearBebida();
            ITipoEntrega entrega = CrearTipoEntrega();

            Pedido pedido = new PedidoCarlsJr(hamburguesa, papas, bebida, entrega);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(pedido.MostrarResumen());
            sb.AppendLine($"TOTAL: ${pedido.CalcularTotal():0.00}");

            txtResumen.Text = sb.ToString();
            lblTotal.Text = $"Total: ${pedido.CalcularTotal():0.00}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbHamburguesa.SelectedIndex = 0;
            cmbPapas.SelectedIndex = 0;
            cmbBebida.SelectedIndex = 0;
            cmbEntrega.SelectedIndex = 0;

            chkQueso.Checked = false;
            chkTocino.Checked = false;
            chkJalapenos.Checked = false;
            chkArosCebolla.Checked = false;
            chkGuacamole.Checked = false;

            chkSinCebolla.Checked = false;
            chkSinTomate.Checked = false;
            chkSinPepinillos.Checked = false;

            txtResumen.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbHamburguesa_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Skip if no item is selected

            ComboBox comboBox = sender as ComboBox;
            Brush textBrush;
            Brush backgroundBrush;

            // Check if the current item is selected
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Customize colors for selected item (e.g., blue background, yellow text)
                backgroundBrush = new SolidBrush(Color.FromArgb(254, 198, 39));
                textBrush = new SolidBrush(Color.Black);
            }
            else
            {
                // Customize colors for non-selected items (e.g., white background, black text)
                backgroundBrush = new SolidBrush(Color.FromArgb(95, 95, 95));
                textBrush = new SolidBrush(Color.FromArgb(254, 198, 39));
            }

            // Draw the background of the item
            e.Graphics.FillRectangle(backgroundBrush, e.Bounds);

            // Draw the item text
            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

            // Draw the focus rectangle if the item has focus
            e.DrawFocusRectangle();

            // Clean up the brushes
            textBrush.Dispose();
            backgroundBrush.Dispose();
        }

        private void txtResumen_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxExtras_Enter(object sender, EventArgs e)
        {
            // vacío, no hace nada
        }

        private void chkSinTomate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxQuitar_Enter(object sender, EventArgs e)
        {

        }
        //Extras
        private bool extrasExpandido = false;
        private bool quitarExpandido = false;



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!extrasExpandido)
            {
                // EXPANDIR
                groupBoxExtras.Size = new Size(250, 193);
                groupBoxQuitar.Location = new Point(608, 120);
                pictureBox5.BringToFront();


                label1.Text = "-";

                extrasExpandido = true;
            }
            else
            {
                // CONTRAER
                groupBoxExtras.Size = new Size(250, 32);
                groupBoxQuitar.Location = new Point(608, 120);
                pictureBox5.BringToFront();


                label1.Text = "+";

                extrasExpandido = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!quitarExpandido)
            {
                // EXPANDIR
                groupBoxQuitar.Size = new Size(250, 129);
                label2.Text = "-";

                quitarExpandido = true;
            }
            else
            {
                // CONTRAER
                groupBoxQuitar.Size = new Size(250, 32);
                label2.Text = "+";

                quitarExpandido = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Pedido_CarlsJr.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;

                using (PdfWriter writer = new PdfWriter(path))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    // Título
                    document.Add(new Paragraph("===== PEDIDO CARL'S JR =====")
                        //.SetBold()
                        .SetFontSize(16));

                    // Contenido (tu resumen)
                    document.Add(new Paragraph(txtResumen.Text));

                    // Total
                    document.Add(new Paragraph(lblTotal.Text));


                    document.Close();
                }

                MessageBox.Show("Recibo creado correctamente ✅");
            }
        }

        // Designer-referenced event handler stubs (prevent designer/CodeDom parsing errors)
        private void cmbHamburguesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHamburguesa.Text)
            {
                case "Famous Star":
                    pictureBoxPreview.Visible = true;

                    pictureBoxPreview.Image = Properties.Resources.Famous;
                    break;

                case "Western Bacon":
                    pictureBoxPreview.Visible = true;

                    pictureBoxPreview.Image = Properties.Resources.Western;
                    break;

                case "Super Star":
                    pictureBoxPreview.Visible = true;

                    pictureBoxPreview.Image = Properties.Resources.Super;
                    break;
            }
        }

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBebida.Text == "Sin bebida")
            {
                pictureBox7.Visible = false;
            }
            else
            {
                pictureBox7.Image = Properties.Resources.Bebida; // una sola imagen
                pictureBox7.Visible = true;
            }
        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {
            // Optional: show a larger preview or no-op. Kept to satisfy designer wiring.
        }

        private void cmbPapas_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (cmbPapas.Text)
    {
        case "Sin papas":
                    pictureBox6.Visible = false;
                    break;

        case "Papas a la francesa":
                    pictureBox6.Visible = true;

                    pictureBox6.Image = Properties.Resources.French;
            break;

        case "Papas Crisscut":
                    pictureBox6.Visible = true;

                    pictureBox6.Image = Properties.Resources.Crisscut;
            break;

        case "Papas Curly":
                    pictureBox6.Visible = true;

                    pictureBox6.Image = Properties.Resources.Curly;
            break;
    }
        }
    }
}
