
namespace Parcial2._0
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabStart = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBookAppointment = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarnetUsername = new System.Windows.Forms.TextBox();
            this.cmbSpeciality = new System.Windows.Forms.ComboBox();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabExistingAppointments = new System.Windows.Forms.TabPage();
            this.dgvQuotes = new System.Windows.Forms.DataGridView();
            this.tabUpdateCancel = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queDeseaRealizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCitasExistentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionYCancelacionDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabStart.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabBookAppointment.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabExistingAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).BeginInit();
            this.tabUpdateCancel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStart
            // 
            this.tabStart.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabStart.Controls.Add(this.tabInicio);
            this.tabStart.Controls.Add(this.tabBookAppointment);
            this.tabStart.Controls.Add(this.tabExistingAppointments);
            this.tabStart.Controls.Add(this.tabUpdateCancel);
            this.tabStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabStart.Location = new System.Drawing.Point(6, 110);
            this.tabStart.Name = "tabStart";
            this.tabStart.SelectedIndex = 0;
            this.tabStart.Size = new System.Drawing.Size(667, 340);
            this.tabStart.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabStart.TabIndex = 1;
            this.tabStart.TabStop = false;
            // 
            // tabInicio
            // 
            this.tabInicio.BackColor = System.Drawing.Color.Turquoise;
            this.tabInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabInicio.BackgroundImage")));
            this.tabInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabInicio.Controls.Add(this.label1);
            this.tabInicio.Location = new System.Drawing.Point(4, 27);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(659, 309);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 269);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenidos!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabBookAppointment
            // 
            this.tabBookAppointment.Controls.Add(this.tableLayoutPanel3);
            this.tabBookAppointment.Location = new System.Drawing.Point(4, 27);
            this.tabBookAppointment.Name = "tabBookAppointment";
            this.tabBookAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookAppointment.Size = new System.Drawing.Size(659, 309);
            this.tabBookAppointment.TabIndex = 1;
            this.tabBookAppointment.Text = "Reservar citas";
            this.tabBookAppointment.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtCarnetUsername, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbSpeciality, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.dtpHour, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpDate, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReserve, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 2, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(656, 269);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carnet de usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(199, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "Especialidad Medica";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCarnetUsername
            // 
            this.txtCarnetUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarnetUsername.Location = new System.Drawing.Point(330, 39);
            this.txtCarnetUsername.Name = "txtCarnetUsername";
            this.txtCarnetUsername.Size = new System.Drawing.Size(125, 21);
            this.txtCarnetUsername.TabIndex = 4;
            // 
            // cmbSpeciality
            // 
            this.cmbSpeciality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeciality.FormattingEnabled = true;
            this.cmbSpeciality.Location = new System.Drawing.Point(330, 183);
            this.cmbSpeciality.Name = "cmbSpeciality";
            this.cmbSpeciality.Size = new System.Drawing.Size(125, 23);
            this.cmbSpeciality.TabIndex = 5;
            // 
            // dtpHour
            // 
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHour.Location = new System.Drawing.Point(330, 135);
            this.dtpHour.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpHour.MinDate = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.Size = new System.Drawing.Size(125, 21);
            this.dtpHour.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(199, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hora";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(330, 87);
            this.dtpDate.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(125, 21);
            this.dtpDate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.label7, 2);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(199, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Reserva tu cita";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReserve
            // 
            this.btnReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReserve.BackColor = System.Drawing.Color.Yellow;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.Black;
            this.btnReserve.Location = new System.Drawing.Point(199, 231);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(125, 35);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "Reservar";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(330, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabExistingAppointments
            // 
            this.tabExistingAppointments.Controls.Add(this.dgvQuotes);
            this.tabExistingAppointments.Location = new System.Drawing.Point(4, 27);
            this.tabExistingAppointments.Name = "tabExistingAppointments";
            this.tabExistingAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabExistingAppointments.Size = new System.Drawing.Size(659, 309);
            this.tabExistingAppointments.TabIndex = 2;
            this.tabExistingAppointments.Text = "Citas existentes";
            this.tabExistingAppointments.UseVisualStyleBackColor = true;
            // 
            // dgvQuotes
            // 
            this.dgvQuotes.AllowUserToAddRows = false;
            this.dgvQuotes.AllowUserToDeleteRows = false;
            this.dgvQuotes.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dgvQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotes.Location = new System.Drawing.Point(0, 27);
            this.dgvQuotes.MultiSelect = false;
            this.dgvQuotes.Name = "dgvQuotes";
            this.dgvQuotes.ReadOnly = true;
            this.dgvQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuotes.Size = new System.Drawing.Size(656, 211);
            this.dgvQuotes.TabIndex = 0;
            // 
            // tabUpdateCancel
            // 
            this.tabUpdateCancel.Controls.Add(this.tableLayoutPanel2);
            this.tabUpdateCancel.Location = new System.Drawing.Point(4, 27);
            this.tabUpdateCancel.Name = "tabUpdateCancel";
            this.tabUpdateCancel.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateCancel.Size = new System.Drawing.Size(659, 309);
            this.tabUpdateCancel.TabIndex = 3;
            this.tabUpdateCancel.Text = "Actualizacion y cancelacion ";
            this.tabUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 269);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasToolStripMenuItem,
            this.queDeseaRealizarToolStripMenuItem,
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(134, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // queDeseaRealizarToolStripMenuItem
            // 
            this.queDeseaRealizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarCitaToolStripMenuItem,
            this.visualizarCitasExistentesToolStripMenuItem,
            this.actualizacionYCancelacionDeCitasToolStripMenuItem});
            this.queDeseaRealizarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queDeseaRealizarToolStripMenuItem.Name = "queDeseaRealizarToolStripMenuItem";
            this.queDeseaRealizarToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.queDeseaRealizarToolStripMenuItem.Text = "?Que desea realizar¿";
            // 
            // reservarCitaToolStripMenuItem
            // 
            this.reservarCitaToolStripMenuItem.Name = "reservarCitaToolStripMenuItem";
            this.reservarCitaToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.reservarCitaToolStripMenuItem.Text = "Reservar cita";
            this.reservarCitaToolStripMenuItem.Click += new System.EventHandler(this.reservarCitaToolStripMenuItem_Click);
            // 
            // visualizarCitasExistentesToolStripMenuItem
            // 
            this.visualizarCitasExistentesToolStripMenuItem.Name = "visualizarCitasExistentesToolStripMenuItem";
            this.visualizarCitasExistentesToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.visualizarCitasExistentesToolStripMenuItem.Text = "Visualizar citas existentes";
            this.visualizarCitasExistentesToolStripMenuItem.Click += new System.EventHandler(this.visualizarCitasExistentesToolStripMenuItem_Click);
            // 
            // actualizacionYCancelacionDeCitasToolStripMenuItem
            // 
            this.actualizacionYCancelacionDeCitasToolStripMenuItem.Name = "actualizacionYCancelacionDeCitasToolStripMenuItem";
            this.actualizacionYCancelacionDeCitasToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.actualizacionYCancelacionDeCitasToolStripMenuItem.Text = "Actualizacion y cancelacion de citas";
            this.actualizacionYCancelacionDeCitasToolStripMenuItem.Click += new System.EventHandler(this.actualizacionYCancelacionDeCitasToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(128, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Turquoise;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(530, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "Clinica UCA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.tabStart);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica UCA -Citas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabStart.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabBookAppointment.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabExistingAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).EndInit();
            this.tabUpdateCancel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabStart;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabBookAppointment;
        private System.Windows.Forms.TabPage tabExistingAppointments;
        private System.Windows.Forms.TabPage tabUpdateCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queDeseaRealizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCitasExistentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionYCancelacionDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarnetUsername;
        private System.Windows.Forms.ComboBox cmbSpeciality;
        private System.Windows.Forms.DateTimePicker dtpHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvQuotes;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
    }
}

