using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Carlsjr_Patrones
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            lblHamburguesa = new Label();
            cmbHamburguesa = new ComboBox();
            groupBoxExtras = new GroupBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            chkGuacamole = new CheckBox();
            chkArosCebolla = new CheckBox();
            chkJalapenos = new CheckBox();
            chkTocino = new CheckBox();
            chkQueso = new CheckBox();
            groupBoxQuitar = new GroupBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            chkSinPepinillos = new CheckBox();
            chkSinTomate = new CheckBox();
            chkSinCebolla = new CheckBox();
            lblEntrega = new Label();
            cmbEntrega = new ComboBox();
            btnGenerarPedido = new Button();
            btnLimpiar = new Button();
            txtResumen = new TextBox();
            lblTotal = new Label();
            lblPapas = new Label();
            cmbPapas = new ComboBox();
            lblBebida = new Label();
            cmbBebida = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnImprimir = new Button();
            pictureBoxPreview = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            groupBoxExtras.SuspendLayout();
            ((ISupportInitialize)pictureBox4).BeginInit();
            groupBoxQuitar.SuspendLayout();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBoxPreview).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(254, 198, 39);
            lblTitulo.Location = new Point(509, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ordena aqui";
            // 
            // lblHamburguesa
            // 
            lblHamburguesa.AutoSize = true;
            lblHamburguesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHamburguesa.ForeColor = Color.FromArgb(254, 198, 39);
            lblHamburguesa.Location = new Point(13, 58);
            lblHamburguesa.Name = "lblHamburguesa";
            lblHamburguesa.Size = new Size(217, 28);
            lblHamburguesa.TabIndex = 1;
            lblHamburguesa.Text = "Tipo de hamburguesa";
            // 
            // cmbHamburguesa
            // 
            cmbHamburguesa.BackColor = Color.FromArgb(95, 95, 95);
            cmbHamburguesa.DrawMode = DrawMode.OwnerDrawVariable;
            cmbHamburguesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHamburguesa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cmbHamburguesa.ForeColor = Color.FromArgb(254, 198, 39);
            cmbHamburguesa.FormattingEnabled = true;
            cmbHamburguesa.Location = new Point(13, 89);
            cmbHamburguesa.Name = "cmbHamburguesa";
            cmbHamburguesa.Size = new Size(250, 31);
            cmbHamburguesa.TabIndex = 2;
            cmbHamburguesa.DrawItem += cmbHamburguesa_DrawItem;
            cmbHamburguesa.SelectedIndexChanged += cmbHamburguesa_SelectedIndexChanged;
            // 
            // groupBoxExtras
            // 
            groupBoxExtras.Controls.Add(pictureBox4);
            groupBoxExtras.Controls.Add(label1);
            groupBoxExtras.Controls.Add(chkGuacamole);
            groupBoxExtras.Controls.Add(chkArosCebolla);
            groupBoxExtras.Controls.Add(chkJalapenos);
            groupBoxExtras.Controls.Add(chkTocino);
            groupBoxExtras.Controls.Add(chkQueso);
            groupBoxExtras.FlatStyle = FlatStyle.Flat;
            groupBoxExtras.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxExtras.ForeColor = Color.FromArgb(254, 198, 39);
            groupBoxExtras.Location = new Point(341, 120);
            groupBoxExtras.Name = "groupBoxExtras";
            groupBoxExtras.Size = new Size(250, 32);
            groupBoxExtras.TabIndex = 9;
            groupBoxExtras.TabStop = false;
            groupBoxExtras.Text = "Agregar extras";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.fondo_transparente;
            pictureBox4.Image = Properties.Resources.fondo_transparente;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(254, 198, 39);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(223, -3);
            label1.Name = "label1";
            label1.Size = new Size(27, 27);
            label1.TabIndex = 5;
            label1.Text = "+";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // chkGuacamole
            // 
            chkGuacamole.AutoSize = true;
            chkGuacamole.Font = new Font("Segoe UI", 10F);
            chkGuacamole.Location = new Point(17, 160);
            chkGuacamole.Name = "chkGuacamole";
            chkGuacamole.Size = new Size(118, 27);
            chkGuacamole.TabIndex = 4;
            chkGuacamole.Text = "Guacamole";
            chkGuacamole.UseVisualStyleBackColor = true;
            // 
            // chkArosCebolla
            // 
            chkArosCebolla.AutoSize = true;
            chkArosCebolla.Font = new Font("Segoe UI", 10F);
            chkArosCebolla.Location = new Point(17, 127);
            chkArosCebolla.Name = "chkArosCebolla";
            chkArosCebolla.Size = new Size(149, 27);
            chkArosCebolla.TabIndex = 3;
            chkArosCebolla.Text = "Aros de cebolla";
            chkArosCebolla.UseVisualStyleBackColor = true;
            // 
            // chkJalapenos
            // 
            chkJalapenos.AutoSize = true;
            chkJalapenos.Font = new Font("Segoe UI", 10F);
            chkJalapenos.Location = new Point(17, 94);
            chkJalapenos.Name = "chkJalapenos";
            chkJalapenos.Size = new Size(106, 27);
            chkJalapenos.TabIndex = 2;
            chkJalapenos.Text = "Jalapeños";
            chkJalapenos.UseVisualStyleBackColor = true;
            // 
            // chkTocino
            // 
            chkTocino.AutoSize = true;
            chkTocino.Font = new Font("Segoe UI", 10F);
            chkTocino.Location = new Point(17, 61);
            chkTocino.Name = "chkTocino";
            chkTocino.Size = new Size(81, 27);
            chkTocino.TabIndex = 1;
            chkTocino.Text = "Tocino";
            chkTocino.UseVisualStyleBackColor = true;
            // 
            // chkQueso
            // 
            chkQueso.AutoSize = true;
            chkQueso.Font = new Font("Segoe UI", 10F);
            chkQueso.Location = new Point(17, 28);
            chkQueso.Name = "chkQueso";
            chkQueso.Size = new Size(121, 27);
            chkQueso.TabIndex = 0;
            chkQueso.Text = "Extra queso";
            chkQueso.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuitar
            // 
            groupBoxQuitar.Controls.Add(pictureBox5);
            groupBoxQuitar.Controls.Add(label2);
            groupBoxQuitar.Controls.Add(chkSinPepinillos);
            groupBoxQuitar.Controls.Add(chkSinTomate);
            groupBoxQuitar.Controls.Add(chkSinCebolla);
            groupBoxQuitar.FlatStyle = FlatStyle.Flat;
            groupBoxQuitar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxQuitar.ForeColor = Color.FromArgb(254, 198, 39);
            groupBoxQuitar.Location = new Point(608, 120);
            groupBoxQuitar.Name = "groupBoxQuitar";
            groupBoxQuitar.Size = new Size(250, 32);
            groupBoxQuitar.TabIndex = 10;
            groupBoxQuitar.TabStop = false;
            groupBoxQuitar.Text = "Quitar ingredientes";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.fondo_transparente;
            pictureBox5.Image = Properties.Resources.fondo_transparente;
            pictureBox5.Location = new Point(0, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(250, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(254, 198, 39);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(223, -2);
            label2.Name = "label2";
            label2.Size = new Size(27, 27);
            label2.TabIndex = 18;
            label2.Text = "+";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // chkSinPepinillos
            // 
            chkSinPepinillos.AutoSize = true;
            chkSinPepinillos.Font = new Font("Segoe UI", 10F);
            chkSinPepinillos.Location = new Point(18, 94);
            chkSinPepinillos.Name = "chkSinPepinillos";
            chkSinPepinillos.Size = new Size(132, 27);
            chkSinPepinillos.TabIndex = 2;
            chkSinPepinillos.Text = "Sin pepinillos";
            chkSinPepinillos.UseVisualStyleBackColor = true;
            // 
            // chkSinTomate
            // 
            chkSinTomate.AutoSize = true;
            chkSinTomate.Font = new Font("Segoe UI", 10F);
            chkSinTomate.Location = new Point(18, 61);
            chkSinTomate.Name = "chkSinTomate";
            chkSinTomate.Size = new Size(115, 27);
            chkSinTomate.TabIndex = 1;
            chkSinTomate.Text = "Sin tomate";
            chkSinTomate.UseVisualStyleBackColor = true;
            chkSinTomate.CheckedChanged += chkSinTomate_CheckedChanged;
            // 
            // chkSinCebolla
            // 
            chkSinCebolla.AutoSize = true;
            chkSinCebolla.Font = new Font("Segoe UI", 10F);
            chkSinCebolla.Location = new Point(18, 28);
            chkSinCebolla.Name = "chkSinCebolla";
            chkSinCebolla.Size = new Size(114, 27);
            chkSinCebolla.TabIndex = 0;
            chkSinCebolla.Text = "Sin cebolla";
            chkSinCebolla.UseVisualStyleBackColor = true;
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEntrega.ForeColor = Color.FromArgb(254, 198, 39);
            lblEntrega.Location = new Point(17, 473);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(162, 28);
            lblEntrega.TabIndex = 7;
            lblEntrega.Text = "Tipo de entrega";
            // 
            // cmbEntrega
            // 
            cmbEntrega.BackColor = Color.FromArgb(95, 95, 95);
            cmbEntrega.DrawMode = DrawMode.OwnerDrawVariable;
            cmbEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntrega.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cmbEntrega.ForeColor = Color.FromArgb(254, 198, 39);
            cmbEntrega.FormattingEnabled = true;
            cmbEntrega.Location = new Point(13, 504);
            cmbEntrega.Name = "cmbEntrega";
            cmbEntrega.Size = new Size(250, 31);
            cmbEntrega.TabIndex = 8;
            cmbEntrega.DrawItem += cmbHamburguesa_DrawItem;
            // 
            // btnGenerarPedido
            // 
            btnGenerarPedido.BackColor = Color.FromArgb(254, 198, 39);
            btnGenerarPedido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarPedido.ForeColor = Color.FromArgb(20, 17, 10);
            btnGenerarPedido.Location = new Point(882, 618);
            btnGenerarPedido.Name = "btnGenerarPedido";
            btnGenerarPedido.Size = new Size(161, 45);
            btnGenerarPedido.TabIndex = 11;
            btnGenerarPedido.Text = "Generar pedido";
            btnGenerarPedido.UseVisualStyleBackColor = false;
            btnGenerarPedido.Click += btnGenerarPedido_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(254, 198, 39);
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(20, 17, 10);
            btnLimpiar.Location = new Point(1036, 681);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 45);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResumen
            // 
            txtResumen.BackColor = Color.FromArgb(95, 95, 95);
            txtResumen.Font = new Font("Consolas", 10F);
            txtResumen.ForeColor = Color.Yellow;
            txtResumen.Location = new Point(882, 117);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.ReadOnly = true;
            txtResumen.ScrollBars = ScrollBars.Vertical;
            txtResumen.Size = new Size(294, 495);
            txtResumen.TabIndex = 14;
            txtResumen.TextAlign = HorizontalAlignment.Center;
            txtResumen.TextChanged += txtResumen_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(254, 198, 39);
            lblTotal.Location = new Point(1053, 624);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 28);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: $0.00";
            // 
            // lblPapas
            // 
            lblPapas.AutoSize = true;
            lblPapas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPapas.ForeColor = Color.FromArgb(254, 198, 39);
            lblPapas.Location = new Point(16, 333);
            lblPapas.Name = "lblPapas";
            lblPapas.Size = new Size(67, 28);
            lblPapas.TabIndex = 3;
            lblPapas.Text = "Papas";
            // 
            // cmbPapas
            // 
            cmbPapas.BackColor = Color.FromArgb(95, 95, 95);
            cmbPapas.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPapas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPapas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cmbPapas.ForeColor = Color.FromArgb(254, 198, 39);
            cmbPapas.FormattingEnabled = true;
            cmbPapas.Location = new Point(16, 364);
            cmbPapas.Name = "cmbPapas";
            cmbPapas.Size = new Size(250, 31);
            cmbPapas.TabIndex = 4;
            cmbPapas.DrawItem += cmbHamburguesa_DrawItem;
            cmbPapas.SelectedIndexChanged += cmbPapas_SelectedIndexChanged;
            // 
            // lblBebida
            // 
            lblBebida.AutoSize = true;
            lblBebida.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBebida.ForeColor = Color.FromArgb(254, 198, 39);
            lblBebida.Location = new Point(16, 191);
            lblBebida.Name = "lblBebida";
            lblBebida.Size = new Size(77, 28);
            lblBebida.TabIndex = 5;
            lblBebida.Text = "Bebida";
            // 
            // cmbBebida
            // 
            cmbBebida.BackColor = Color.FromArgb(95, 95, 95);
            cmbBebida.DrawMode = DrawMode.OwnerDrawVariable;
            cmbBebida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBebida.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cmbBebida.ForeColor = Color.FromArgb(254, 198, 39);
            cmbBebida.FormattingEnabled = true;
            cmbBebida.Location = new Point(16, 223);
            cmbBebida.Name = "cmbBebida";
            cmbBebida.Size = new Size(250, 31);
            cmbBebida.TabIndex = 6;
            cmbBebida.DrawItem += cmbHamburguesa_DrawItem;
            cmbBebida.SelectedIndexChanged += cmbBebida_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Linea1;
            pictureBox2.Location = new Point(0, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1188, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Carls_Jr__fondo_2;
            pictureBox3.Location = new Point(147, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1041, 693);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(cmbHamburguesa);
            panel1.Controls.Add(lblHamburguesa);
            panel1.Controls.Add(lblPapas);
            panel1.Controls.Add(cmbPapas);
            panel1.Controls.Add(lblBebida);
            panel1.Controls.Add(cmbBebida);
            panel1.Controls.Add(lblEntrega);
            panel1.Controls.Add(cmbEntrega);
            panel1.Location = new Point(0, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 653);
            panel1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(254, 198, 39);
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 34);
            textBox1.TabIndex = 9;
            textBox1.Text = "Seleccione sus articulos";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(254, 198, 39);
            btnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.FromArgb(20, 17, 10);
            btnImprimir.Location = new Point(882, 681);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(140, 45);
            btnImprimir.TabIndex = 19;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(292, 377);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(273, 183);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview.TabIndex = 20;
            pictureBoxPreview.TabStop = false;
            pictureBoxPreview.Click += pictureBoxPreview_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(597, 377);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(261, 183);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(453, 572);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(273, 180);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1188, 764);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBoxPreview);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(txtResumen);
            Controls.Add(lblTotal);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGenerarPedido);
            Controls.Add(groupBoxQuitar);
            Controls.Add(groupBoxExtras);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carl's Jr - Decorator y Bridge";
            groupBoxExtras.ResumeLayout(false);
            groupBoxExtras.PerformLayout();
            ((ISupportInitialize)pictureBox4).EndInit();
            groupBoxQuitar.ResumeLayout(false);
            groupBoxQuitar.PerformLayout();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBoxPreview).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHamburguesa;
        private System.Windows.Forms.ComboBox cmbHamburguesa;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.CheckBox chkGuacamole;
        private System.Windows.Forms.CheckBox chkArosCebolla;
        private System.Windows.Forms.CheckBox chkJalapenos;
        private System.Windows.Forms.CheckBox chkTocino;
        private System.Windows.Forms.CheckBox chkQueso;
        private System.Windows.Forms.GroupBox groupBoxQuitar;
        private System.Windows.Forms.CheckBox chkSinPepinillos;
        private System.Windows.Forms.CheckBox chkSinTomate;
        private System.Windows.Forms.CheckBox chkSinCebolla;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.ComboBox cmbEntrega;
        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPapas;
        private System.Windows.Forms.ComboBox cmbPapas;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.ComboBox cmbBebida;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnImprimir;
        private PictureBox pictureBoxPreview;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}

