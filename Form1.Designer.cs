﻿namespace DBIIRecordCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbcGestion = new TabControl();
            tpRegistroEmpresa = new TabPage();
            pnlRegistroEmpresa = new Panel();
            btnEmpresaGuardar = new Button();
            rbEmpresaCasaMatriz = new RadioButton();
            rbEmpresaSubsidiaria = new RadioButton();
            txtEmpresaNombre = new TextBox();
            txtEmpresaId = new TextBox();
            lbEmpresaTipo = new Label();
            lbEmpresaNombre = new Label();
            lbEmpresaId = new Label();
            tpRegistroArtista = new TabPage();
            pnlRegistroArtista = new Panel();
            btnProductorGuardarR = new Button();
            cbxProductorClasificacion = new ComboBox();
            cbxProductorAniosExp = new ComboBox();
            label1 = new Label();
            txtProductorNombre = new TextBox();
            txtProductorTarjeta = new TextBox();
            lbProductorAñosExp = new Label();
            lbProductorNombre = new Label();
            lbProductorTarjeta = new Label();
            tpRegistroEmpresaProductor = new TabPage();
            panel1 = new Panel();
            dtpVinculacionFechaFin = new DateTimePicker();
            dtpVinculacionFechaIni = new DateTimePicker();
            lbVinculacionFechaFin = new Label();
            label5 = new Label();
            btnVincualacionGuardar = new Button();
            txtVinculacionTarjetaProfesional = new TextBox();
            txtVinculacionIdentificacion = new TextBox();
            lbVinculacionFechaIni = new Label();
            label3 = new Label();
            label4 = new Label();
            tpBuscarVinculacion = new TabPage();
            panel2 = new Panel();
            dvgConsultaVinculacion = new DataGridView();
            lbVinculacionNumContratos = new Label();
            dtpBuscarVincFecha = new DateTimePicker();
            btnVinculacionBuscar = new Button();
            lbVinculacionFecha = new Label();
            label8 = new Label();
            tpConsultaContrato = new TabPage();
            panel3 = new Panel();
            lbConsultaContratoNum = new Label();
            btnConsultaContrato = new Button();
            label6 = new Label();
            tbcGestion.SuspendLayout();
            tpRegistroEmpresa.SuspendLayout();
            pnlRegistroEmpresa.SuspendLayout();
            tpRegistroArtista.SuspendLayout();
            pnlRegistroArtista.SuspendLayout();
            tpRegistroEmpresaProductor.SuspendLayout();
            panel1.SuspendLayout();
            tpBuscarVinculacion.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgConsultaVinculacion).BeginInit();
            tpConsultaContrato.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tbcGestion
            // 
            tbcGestion.Controls.Add(tpRegistroEmpresa);
            tbcGestion.Controls.Add(tpRegistroArtista);
            tbcGestion.Controls.Add(tpRegistroEmpresaProductor);
            tbcGestion.Controls.Add(tpBuscarVinculacion);
            tbcGestion.Controls.Add(tpConsultaContrato);
            tbcGestion.Location = new Point(12, 12);
            tbcGestion.Name = "tbcGestion";
            tbcGestion.RightToLeft = RightToLeft.Yes;
            tbcGestion.SelectedIndex = 0;
            tbcGestion.Size = new Size(768, 426);
            tbcGestion.TabIndex = 0;
            // 
            // tpRegistroEmpresa
            // 
            tpRegistroEmpresa.BackColor = Color.LightBlue;
            tpRegistroEmpresa.BackgroundImage = (Image)resources.GetObject("tpRegistroEmpresa.BackgroundImage");
            tpRegistroEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
            tpRegistroEmpresa.BorderStyle = BorderStyle.FixedSingle;
            tpRegistroEmpresa.Controls.Add(pnlRegistroEmpresa);
            tpRegistroEmpresa.ForeColor = SystemColors.ActiveCaptionText;
            tpRegistroEmpresa.Location = new Point(4, 24);
            tpRegistroEmpresa.Name = "tpRegistroEmpresa";
            tpRegistroEmpresa.Padding = new Padding(3);
            tpRegistroEmpresa.Size = new Size(760, 398);
            tpRegistroEmpresa.TabIndex = 0;
            tpRegistroEmpresa.Text = "Registro Empresa";
            // 
            // pnlRegistroEmpresa
            // 
            pnlRegistroEmpresa.BackColor = SystemColors.ButtonFace;
            pnlRegistroEmpresa.BackgroundImage = (Image)resources.GetObject("pnlRegistroEmpresa.BackgroundImage");
            pnlRegistroEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRegistroEmpresa.BorderStyle = BorderStyle.Fixed3D;
            pnlRegistroEmpresa.Controls.Add(btnEmpresaGuardar);
            pnlRegistroEmpresa.Controls.Add(rbEmpresaCasaMatriz);
            pnlRegistroEmpresa.Controls.Add(rbEmpresaSubsidiaria);
            pnlRegistroEmpresa.Controls.Add(txtEmpresaNombre);
            pnlRegistroEmpresa.Controls.Add(txtEmpresaId);
            pnlRegistroEmpresa.Controls.Add(lbEmpresaTipo);
            pnlRegistroEmpresa.Controls.Add(lbEmpresaNombre);
            pnlRegistroEmpresa.Controls.Add(lbEmpresaId);
            pnlRegistroEmpresa.Location = new Point(54, 27);
            pnlRegistroEmpresa.Name = "pnlRegistroEmpresa";
            pnlRegistroEmpresa.Size = new Size(513, 345);
            pnlRegistroEmpresa.TabIndex = 1;
            // 
            // btnEmpresaGuardar
            // 
            btnEmpresaGuardar.BackgroundImageLayout = ImageLayout.None;
            btnEmpresaGuardar.FlatStyle = FlatStyle.Popup;
            btnEmpresaGuardar.Location = new Point(218, 221);
            btnEmpresaGuardar.Name = "btnEmpresaGuardar";
            btnEmpresaGuardar.Size = new Size(75, 23);
            btnEmpresaGuardar.TabIndex = 7;
            btnEmpresaGuardar.Text = "Guardar";
            btnEmpresaGuardar.UseVisualStyleBackColor = true;
            btnEmpresaGuardar.Click += btnEmpresaGuardar_Click;
            // 
            // rbEmpresaCasaMatriz
            // 
            rbEmpresaCasaMatriz.AutoSize = true;
            rbEmpresaCasaMatriz.BackColor = Color.NavajoWhite;
            rbEmpresaCasaMatriz.Location = new Point(284, 144);
            rbEmpresaCasaMatriz.Name = "rbEmpresaCasaMatriz";
            rbEmpresaCasaMatriz.Size = new Size(86, 19);
            rbEmpresaCasaMatriz.TabIndex = 6;
            rbEmpresaCasaMatriz.TabStop = true;
            rbEmpresaCasaMatriz.Text = "Casa Matriz";
            rbEmpresaCasaMatriz.UseVisualStyleBackColor = false;
            // 
            // rbEmpresaSubsidiaria
            // 
            rbEmpresaSubsidiaria.AutoSize = true;
            rbEmpresaSubsidiaria.BackColor = Color.NavajoWhite;
            rbEmpresaSubsidiaria.Location = new Point(172, 144);
            rbEmpresaSubsidiaria.Name = "rbEmpresaSubsidiaria";
            rbEmpresaSubsidiaria.Size = new Size(82, 19);
            rbEmpresaSubsidiaria.TabIndex = 5;
            rbEmpresaSubsidiaria.TabStop = true;
            rbEmpresaSubsidiaria.Text = "Subsidiaria";
            rbEmpresaSubsidiaria.UseVisualStyleBackColor = false;
            // 
            // txtEmpresaNombre
            // 
            txtEmpresaNombre.Location = new Point(172, 101);
            txtEmpresaNombre.Name = "txtEmpresaNombre";
            txtEmpresaNombre.Size = new Size(206, 23);
            txtEmpresaNombre.TabIndex = 4;
            // 
            // txtEmpresaId
            // 
            txtEmpresaId.Location = new Point(172, 72);
            txtEmpresaId.Name = "txtEmpresaId";
            txtEmpresaId.Size = new Size(206, 23);
            txtEmpresaId.TabIndex = 3;
            // 
            // lbEmpresaTipo
            // 
            lbEmpresaTipo.AutoSize = true;
            lbEmpresaTipo.BackColor = Color.Transparent;
            lbEmpresaTipo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmpresaTipo.Location = new Point(35, 146);
            lbEmpresaTipo.Name = "lbEmpresaTipo";
            lbEmpresaTipo.Size = new Size(40, 17);
            lbEmpresaTipo.TabIndex = 2;
            lbEmpresaTipo.Text = " :Tipo";
            lbEmpresaTipo.TextAlign = ContentAlignment.TopRight;
            // 
            // lbEmpresaNombre
            // 
            lbEmpresaNombre.AutoSize = true;
            lbEmpresaNombre.BackColor = Color.Transparent;
            lbEmpresaNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmpresaNombre.Location = new Point(35, 110);
            lbEmpresaNombre.Name = "lbEmpresaNombre";
            lbEmpresaNombre.Size = new Size(62, 17);
            lbEmpresaNombre.TabIndex = 1;
            lbEmpresaNombre.Text = " :Nombre";
            lbEmpresaNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEmpresaId
            // 
            lbEmpresaId.AutoSize = true;
            lbEmpresaId.BackColor = Color.Transparent;
            lbEmpresaId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmpresaId.Location = new Point(35, 78);
            lbEmpresaId.Name = "lbEmpresaId";
            lbEmpresaId.Size = new Size(96, 17);
            lbEmpresaId.TabIndex = 0;
            lbEmpresaId.Text = " :Identificación";
            lbEmpresaId.TextAlign = ContentAlignment.TopRight;
            // 
            // tpRegistroArtista
            // 
            tpRegistroArtista.BackgroundImage = (Image)resources.GetObject("tpRegistroArtista.BackgroundImage");
            tpRegistroArtista.BackgroundImageLayout = ImageLayout.Stretch;
            tpRegistroArtista.BorderStyle = BorderStyle.FixedSingle;
            tpRegistroArtista.Controls.Add(pnlRegistroArtista);
            tpRegistroArtista.Location = new Point(4, 24);
            tpRegistroArtista.Name = "tpRegistroArtista";
            tpRegistroArtista.Padding = new Padding(3);
            tpRegistroArtista.Size = new Size(760, 398);
            tpRegistroArtista.TabIndex = 1;
            tpRegistroArtista.Text = "Registro Productor";
            tpRegistroArtista.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroArtista
            // 
            pnlRegistroArtista.BackgroundImage = (Image)resources.GetObject("pnlRegistroArtista.BackgroundImage");
            pnlRegistroArtista.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRegistroArtista.BorderStyle = BorderStyle.Fixed3D;
            pnlRegistroArtista.Controls.Add(btnProductorGuardarR);
            pnlRegistroArtista.Controls.Add(cbxProductorClasificacion);
            pnlRegistroArtista.Controls.Add(cbxProductorAniosExp);
            pnlRegistroArtista.Controls.Add(label1);
            pnlRegistroArtista.Controls.Add(txtProductorNombre);
            pnlRegistroArtista.Controls.Add(txtProductorTarjeta);
            pnlRegistroArtista.Controls.Add(lbProductorAñosExp);
            pnlRegistroArtista.Controls.Add(lbProductorNombre);
            pnlRegistroArtista.Controls.Add(lbProductorTarjeta);
            pnlRegistroArtista.Location = new Point(57, 28);
            pnlRegistroArtista.Name = "pnlRegistroArtista";
            pnlRegistroArtista.Size = new Size(513, 345);
            pnlRegistroArtista.TabIndex = 2;
            // 
            // btnProductorGuardarR
            // 
            btnProductorGuardarR.BackColor = Color.WhiteSmoke;
            btnProductorGuardarR.FlatStyle = FlatStyle.Popup;
            btnProductorGuardarR.Location = new Point(217, 229);
            btnProductorGuardarR.Name = "btnProductorGuardarR";
            btnProductorGuardarR.Size = new Size(75, 23);
            btnProductorGuardarR.TabIndex = 11;
            btnProductorGuardarR.Text = "Guardar";
            btnProductorGuardarR.UseVisualStyleBackColor = false;
            btnProductorGuardarR.Click += btnProductorGuardarR_Click;
            // 
            // cbxProductorClasificacion
            // 
            cbxProductorClasificacion.FormattingEnabled = true;
            cbxProductorClasificacion.Items.AddRange(new object[] { "Rock", "Pop", "Metal" });
            cbxProductorClasificacion.Location = new Point(172, 172);
            cbxProductorClasificacion.Name = "cbxProductorClasificacion";
            cbxProductorClasificacion.Size = new Size(206, 23);
            cbxProductorClasificacion.TabIndex = 10;
            // 
            // cbxProductorAniosExp
            // 
            cbxProductorAniosExp.FormattingEnabled = true;
            cbxProductorAniosExp.Items.AddRange(new object[] { "Menor a 5 años", "Entre 5 y 10 años", "De 10 a 20 años", "Mas de 20 años" });
            cbxProductorAniosExp.Location = new Point(172, 136);
            cbxProductorAniosExp.Name = "cbxProductorAniosExp";
            cbxProductorAniosExp.Size = new Size(206, 23);
            cbxProductorAniosExp.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 178);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 8;
            label1.Text = " :Clasificación";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txtProductorNombre
            // 
            txtProductorNombre.Location = new Point(172, 101);
            txtProductorNombre.Name = "txtProductorNombre";
            txtProductorNombre.Size = new Size(206, 23);
            txtProductorNombre.TabIndex = 4;
            // 
            // txtProductorTarjeta
            // 
            txtProductorTarjeta.Location = new Point(172, 72);
            txtProductorTarjeta.Name = "txtProductorTarjeta";
            txtProductorTarjeta.Size = new Size(206, 23);
            txtProductorTarjeta.TabIndex = 3;
            // 
            // lbProductorAñosExp
            // 
            lbProductorAñosExp.AutoSize = true;
            lbProductorAñosExp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbProductorAñosExp.Location = new Point(35, 142);
            lbProductorAñosExp.Name = "lbProductorAñosExp";
            lbProductorAñosExp.Size = new Size(117, 17);
            lbProductorAñosExp.TabIndex = 2;
            lbProductorAñosExp.Text = " :Años Experiencia";
            lbProductorAñosExp.TextAlign = ContentAlignment.TopRight;
            // 
            // lbProductorNombre
            // 
            lbProductorNombre.AutoSize = true;
            lbProductorNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbProductorNombre.Location = new Point(35, 110);
            lbProductorNombre.Name = "lbProductorNombre";
            lbProductorNombre.Size = new Size(116, 17);
            lbProductorNombre.TabIndex = 1;
            lbProductorNombre.Text = " :Nombre Artistico";
            lbProductorNombre.TextAlign = ContentAlignment.TopRight;
            // 
            // lbProductorTarjeta
            // 
            lbProductorTarjeta.AutoSize = true;
            lbProductorTarjeta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbProductorTarjeta.Location = new Point(35, 78);
            lbProductorTarjeta.Name = "lbProductorTarjeta";
            lbProductorTarjeta.Size = new Size(126, 17);
            lbProductorTarjeta.TabIndex = 0;
            lbProductorTarjeta.Text = " :Tarjeta Profesional";
            lbProductorTarjeta.TextAlign = ContentAlignment.TopRight;
            // 
            // tpRegistroEmpresaProductor
            // 
            tpRegistroEmpresaProductor.BackgroundImage = (Image)resources.GetObject("tpRegistroEmpresaProductor.BackgroundImage");
            tpRegistroEmpresaProductor.BackgroundImageLayout = ImageLayout.Stretch;
            tpRegistroEmpresaProductor.BorderStyle = BorderStyle.FixedSingle;
            tpRegistroEmpresaProductor.Controls.Add(panel1);
            tpRegistroEmpresaProductor.Location = new Point(4, 24);
            tpRegistroEmpresaProductor.Name = "tpRegistroEmpresaProductor";
            tpRegistroEmpresaProductor.Size = new Size(760, 398);
            tpRegistroEmpresaProductor.TabIndex = 2;
            tpRegistroEmpresaProductor.Text = "Vinculacion Empresa-Productor";
            tpRegistroEmpresaProductor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dtpVinculacionFechaFin);
            panel1.Controls.Add(dtpVinculacionFechaIni);
            panel1.Controls.Add(lbVinculacionFechaFin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnVincualacionGuardar);
            panel1.Controls.Add(txtVinculacionTarjetaProfesional);
            panel1.Controls.Add(txtVinculacionIdentificacion);
            panel1.Controls.Add(lbVinculacionFechaIni);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(56, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 345);
            panel1.TabIndex = 2;
            // 
            // dtpVinculacionFechaFin
            // 
            dtpVinculacionFechaFin.Location = new Point(172, 168);
            dtpVinculacionFechaFin.Name = "dtpVinculacionFechaFin";
            dtpVinculacionFechaFin.Size = new Size(200, 23);
            dtpVinculacionFechaFin.TabIndex = 11;
            // 
            // dtpVinculacionFechaIni
            // 
            dtpVinculacionFechaIni.Location = new Point(172, 136);
            dtpVinculacionFechaIni.Name = "dtpVinculacionFechaIni";
            dtpVinculacionFechaIni.Size = new Size(200, 23);
            dtpVinculacionFechaIni.TabIndex = 10;
            // 
            // lbVinculacionFechaFin
            // 
            lbVinculacionFechaFin.AutoSize = true;
            lbVinculacionFechaFin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVinculacionFechaFin.Location = new Point(35, 174);
            lbVinculacionFechaFin.Name = "lbVinculacionFechaFin";
            lbVinculacionFechaFin.Size = new Size(66, 17);
            lbVinculacionFechaFin.TabIndex = 9;
            lbVinculacionFechaFin.Text = "Fecha Fin";
            lbVinculacionFechaFin.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 110);
            label5.Name = "label5";
            label5.Size = new Size(126, 17);
            label5.TabIndex = 8;
            label5.Text = " :Tarjeta Profesional";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // btnVincualacionGuardar
            // 
            btnVincualacionGuardar.BackColor = Color.WhiteSmoke;
            btnVincualacionGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVincualacionGuardar.FlatStyle = FlatStyle.Popup;
            btnVincualacionGuardar.Location = new Point(219, 221);
            btnVincualacionGuardar.Name = "btnVincualacionGuardar";
            btnVincualacionGuardar.Size = new Size(75, 23);
            btnVincualacionGuardar.TabIndex = 7;
            btnVincualacionGuardar.Text = "Guardar";
            btnVincualacionGuardar.UseVisualStyleBackColor = false;
            btnVincualacionGuardar.Click += btnVincualacionGuardar_Click;
            // 
            // txtVinculacionTarjetaProfesional
            // 
            txtVinculacionTarjetaProfesional.Location = new Point(172, 104);
            txtVinculacionTarjetaProfesional.Name = "txtVinculacionTarjetaProfesional";
            txtVinculacionTarjetaProfesional.Size = new Size(206, 23);
            txtVinculacionTarjetaProfesional.TabIndex = 4;
            // 
            // txtVinculacionIdentificacion
            // 
            txtVinculacionIdentificacion.Location = new Point(172, 72);
            txtVinculacionIdentificacion.Name = "txtVinculacionIdentificacion";
            txtVinculacionIdentificacion.Size = new Size(206, 23);
            txtVinculacionIdentificacion.TabIndex = 3;
            // 
            // lbVinculacionFechaIni
            // 
            lbVinculacionFechaIni.AutoSize = true;
            lbVinculacionFechaIni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVinculacionFechaIni.Location = new Point(35, 142);
            lbVinculacionFechaIni.Name = "lbVinculacionFechaIni";
            lbVinculacionFechaIni.Size = new Size(80, 17);
            lbVinculacionFechaIni.TabIndex = 2;
            lbVinculacionFechaIni.Text = "Fecha Inicio";
            lbVinculacionFechaIni.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 110);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 1;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 78);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 0;
            label4.Text = "Identificación";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // tpBuscarVinculacion
            // 
            tpBuscarVinculacion.BackgroundImage = (Image)resources.GetObject("tpBuscarVinculacion.BackgroundImage");
            tpBuscarVinculacion.BackgroundImageLayout = ImageLayout.Stretch;
            tpBuscarVinculacion.BorderStyle = BorderStyle.FixedSingle;
            tpBuscarVinculacion.Controls.Add(panel2);
            tpBuscarVinculacion.Location = new Point(4, 24);
            tpBuscarVinculacion.Name = "tpBuscarVinculacion";
            tpBuscarVinculacion.Size = new Size(760, 398);
            tpBuscarVinculacion.TabIndex = 3;
            tpBuscarVinculacion.Text = "Buscar Vinculación";
            tpBuscarVinculacion.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dvgConsultaVinculacion);
            panel2.Controls.Add(lbVinculacionNumContratos);
            panel2.Controls.Add(dtpBuscarVincFecha);
            panel2.Controls.Add(btnVinculacionBuscar);
            panel2.Controls.Add(lbVinculacionFecha);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(48, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 345);
            panel2.TabIndex = 3;
            // 
            // dvgConsultaVinculacion
            // 
            dvgConsultaVinculacion.BackgroundColor = SystemColors.ScrollBar;
            dvgConsultaVinculacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgConsultaVinculacion.Location = new Point(59, 144);
            dvgConsultaVinculacion.Name = "dvgConsultaVinculacion";
            dvgConsultaVinculacion.Size = new Size(394, 174);
            dvgConsultaVinculacion.TabIndex = 13;
            // 
            // lbVinculacionNumContratos
            // 
            lbVinculacionNumContratos.AutoSize = true;
            lbVinculacionNumContratos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVinculacionNumContratos.Location = new Point(195, 110);
            lbVinculacionNumContratos.Name = "lbVinculacionNumContratos";
            lbVinculacionNumContratos.Size = new Size(124, 17);
            lbVinculacionNumContratos.TabIndex = 12;
            lbVinculacionNumContratos.Text = " :Numero Contratos";
            lbVinculacionNumContratos.TextAlign = ContentAlignment.TopRight;
            // 
            // dtpBuscarVincFecha
            // 
            dtpBuscarVincFecha.Location = new Point(166, 40);
            dtpBuscarVincFecha.Name = "dtpBuscarVincFecha";
            dtpBuscarVincFecha.Size = new Size(200, 23);
            dtpBuscarVincFecha.TabIndex = 10;
            // 
            // btnVinculacionBuscar
            // 
            btnVinculacionBuscar.BackColor = Color.WhiteSmoke;
            btnVinculacionBuscar.FlatStyle = FlatStyle.Popup;
            btnVinculacionBuscar.Location = new Point(217, 84);
            btnVinculacionBuscar.Name = "btnVinculacionBuscar";
            btnVinculacionBuscar.Size = new Size(75, 23);
            btnVinculacionBuscar.TabIndex = 7;
            btnVinculacionBuscar.Text = "Buscar";
            btnVinculacionBuscar.UseVisualStyleBackColor = false;
            btnVinculacionBuscar.Click += btnVinculacionBuscar_Click;
            // 
            // lbVinculacionFecha
            // 
            lbVinculacionFecha.AutoSize = true;
            lbVinculacionFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVinculacionFecha.Location = new Point(57, 44);
            lbVinculacionFecha.Name = "lbVinculacionFecha";
            lbVinculacionFecha.Size = new Size(87, 17);
            lbVinculacionFecha.TabIndex = 2;
            lbVinculacionFecha.Text = " :Fecha Inicio";
            lbVinculacionFecha.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 110);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 1;
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tpConsultaContrato
            // 
            tpConsultaContrato.BackgroundImage = (Image)resources.GetObject("tpConsultaContrato.BackgroundImage");
            tpConsultaContrato.BackgroundImageLayout = ImageLayout.Stretch;
            tpConsultaContrato.BorderStyle = BorderStyle.FixedSingle;
            tpConsultaContrato.Controls.Add(panel3);
            tpConsultaContrato.Location = new Point(4, 24);
            tpConsultaContrato.Name = "tpConsultaContrato";
            tpConsultaContrato.Size = new Size(760, 398);
            tpConsultaContrato.TabIndex = 4;
            tpConsultaContrato.Text = "Consulta Contrato Vigente";
            tpConsultaContrato.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lbConsultaContratoNum);
            panel3.Controls.Add(btnConsultaContrato);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(49, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(513, 345);
            panel3.TabIndex = 4;
            // 
            // lbConsultaContratoNum
            // 
            lbConsultaContratoNum.AutoSize = true;
            lbConsultaContratoNum.BackColor = Color.WhiteSmoke;
            lbConsultaContratoNum.BorderStyle = BorderStyle.FixedSingle;
            lbConsultaContratoNum.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbConsultaContratoNum.Location = new Point(230, 177);
            lbConsultaContratoNum.MinimumSize = new Size(50, 50);
            lbConsultaContratoNum.Name = "lbConsultaContratoNum";
            lbConsultaContratoNum.Size = new Size(50, 50);
            lbConsultaContratoNum.TabIndex = 8;
            lbConsultaContratoNum.TextAlign = ContentAlignment.TopRight;
            lbConsultaContratoNum.Click += lbConsultaContratoNum_Click;
            // 
            // btnConsultaContrato
            // 
            btnConsultaContrato.BackColor = Color.WhiteSmoke;
            btnConsultaContrato.FlatStyle = FlatStyle.Popup;
            btnConsultaContrato.Location = new Point(204, 99);
            btnConsultaContrato.Name = "btnConsultaContrato";
            btnConsultaContrato.Size = new Size(109, 40);
            btnConsultaContrato.TabIndex = 7;
            btnConsultaContrato.Text = "Consultar Contratos";
            btnConsultaContrato.UseVisualStyleBackColor = false;
            btnConsultaContrato.Click += btnConsultaContrato_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 110);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 1;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(796, 450);
            Controls.Add(tbcGestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Record Company";
            tbcGestion.ResumeLayout(false);
            tpRegistroEmpresa.ResumeLayout(false);
            pnlRegistroEmpresa.ResumeLayout(false);
            pnlRegistroEmpresa.PerformLayout();
            tpRegistroArtista.ResumeLayout(false);
            pnlRegistroArtista.ResumeLayout(false);
            pnlRegistroArtista.PerformLayout();
            tpRegistroEmpresaProductor.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpBuscarVinculacion.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgConsultaVinculacion).EndInit();
            tpConsultaContrato.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcGestion;
        private TabPage tpRegistroEmpresa;
        private TabPage tpRegistroArtista;
        private TabPage tpRegistroEmpresaProductor;
        private TabPage tpBuscarVinculacion;
        private TabPage tpConsultaContrato;
        private Panel pnlRegistroEmpresa;
        private Label lbEmpresaId;
        private Label lbEmpresaNombre;
        private Label lbEmpresaTipo;
        private TextBox txtEmpresaNombre;
        private TextBox txtEmpresaId;
        private RadioButton rbEmpresaCasaMatriz;
        private Button btnEmpresaGuardar;
        private RadioButton rbEmpresaSubsidiaria;
        private Panel pnlRegistroArtista;
        private Button btnProductorGuardar;
        private TextBox txtProductorNombre;
        private TextBox txtProductorTarjeta;
        private Label lbProductorAñosExp;
        private Label lbProductorNombre;
        private Label lbProductorTarjeta;
        private Label label1;
        private ComboBox cbxProductorAniosExp;
        private ComboBox cbxProductorClasificacion;
        private Panel panel1;
        private Label lbVinculacionFechaFin;
        private Label label5;
        private Button btnVincualacionGuardar;
        private TextBox txtVinculacionTarjetaProfesional;
        private TextBox txtVinculacionIdentificacion;
        private Label lbVinculacionFechaIni;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpVinculacionFechaFin;
        private DateTimePicker dtpVinculacionFechaIni;
        private Panel panel2;
        private DateTimePicker dtpBuscarVincFecha;
        private Button btnVinculacionBuscar;
        private Label lbVinculacionFecha;
        private Label label8;
        private Panel panel3;
        private Button btnConsultaContrato;
        private Label label6;
        private Label lbVinculacionNumContratos;
        private Button btnProductorGuardarR;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        #endregion

        private DataGridView dvgConsultaVinculacion;
        private Label lbConsultaContratoNum;
    }

}
