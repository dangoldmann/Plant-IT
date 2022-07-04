
namespace COPIA
{
    partial class Edicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edicion));
            this.lblIngresarNombre = new System.Windows.Forms.Label();
            this.trackBar_LuzMinima = new System.Windows.Forms.TrackBar();
            this.trackBar_HumedadMinima = new System.Windows.Forms.TrackBar();
            this.lblLuzMinima = new System.Windows.Forms.Label();
            this.lblHumedadMinima = new System.Windows.Forms.Label();
            this.trackBar_HumedadMaxima = new System.Windows.Forms.TrackBar();
            this.lblHumedadMaxima = new System.Windows.Forms.Label();
            this.trackBar_LuzMaxima = new System.Windows.Forms.TrackBar();
            this.lblLuzMaxima = new System.Windows.Forms.Label();
            this.lblTipoPlanta = new System.Windows.Forms.Label();
            this.comboBox_TipoPlanta = new System.Windows.Forms.ComboBox();
            this.pictureBox_Familia = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblValorHumedadMinima = new System.Windows.Forms.Label();
            this.lblValorHumedadMaxima = new System.Windows.Forms.Label();
            this.lblValorLuzMinima = new System.Windows.Forms.Label();
            this.lblValorLuzMaxima = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNombre = new COPIA.Custom_Controls.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LuzMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HumedadMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HumedadMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LuzMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Familia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarNombre
            // 
            this.lblIngresarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIngresarNombre.AutoSize = true;
            this.lblIngresarNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresarNombre.Font = new System.Drawing.Font("Comfortaa", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombre.Location = new System.Drawing.Point(15, 141);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(452, 62);
            this.lblIngresarNombre.TabIndex = 0;
            this.lblIngresarNombre.Text = "Nombre de la planta: ";
            // 
            // trackBar_LuzMinima
            // 
            this.trackBar_LuzMinima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar_LuzMinima.Location = new System.Drawing.Point(335, 523);
            this.trackBar_LuzMinima.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_LuzMinima.Name = "trackBar_LuzMinima";
            this.trackBar_LuzMinima.Size = new System.Drawing.Size(553, 56);
            this.trackBar_LuzMinima.TabIndex = 10;
            this.trackBar_LuzMinima.ValueChanged += new System.EventHandler(this.trackBar_LuzMinima_ValueChanged);
            this.trackBar_LuzMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trackBar_LuzMinima_KeyPress);
            // 
            // trackBar_HumedadMinima
            // 
            this.trackBar_HumedadMinima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar_HumedadMinima.Location = new System.Drawing.Point(335, 323);
            this.trackBar_HumedadMinima.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_HumedadMinima.Name = "trackBar_HumedadMinima";
            this.trackBar_HumedadMinima.Size = new System.Drawing.Size(553, 56);
            this.trackBar_HumedadMinima.TabIndex = 9;
            this.trackBar_HumedadMinima.ValueChanged += new System.EventHandler(this.trackBar_HumedadMinima_ValueChanged);
            this.trackBar_HumedadMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trackBar_HumedadMinima_KeyPress);
            // 
            // lblLuzMinima
            // 
            this.lblLuzMinima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLuzMinima.AutoSize = true;
            this.lblLuzMinima.BackColor = System.Drawing.Color.Transparent;
            this.lblLuzMinima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuzMinima.Location = new System.Drawing.Point(16, 508);
            this.lblLuzMinima.Name = "lblLuzMinima";
            this.lblLuzMinima.Size = new System.Drawing.Size(226, 53);
            this.lblLuzMinima.TabIndex = 7;
            this.lblLuzMinima.Text = "Luz mínima:";
            // 
            // lblHumedadMinima
            // 
            this.lblHumedadMinima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHumedadMinima.AutoSize = true;
            this.lblHumedadMinima.BackColor = System.Drawing.Color.Transparent;
            this.lblHumedadMinima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedadMinima.Location = new System.Drawing.Point(16, 308);
            this.lblHumedadMinima.Name = "lblHumedadMinima";
            this.lblHumedadMinima.Size = new System.Drawing.Size(333, 53);
            this.lblHumedadMinima.TabIndex = 6;
            this.lblHumedadMinima.Text = "Humedad mínima:";
            // 
            // trackBar_HumedadMaxima
            // 
            this.trackBar_HumedadMaxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar_HumedadMaxima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(100)))));
            this.trackBar_HumedadMaxima.Location = new System.Drawing.Point(335, 423);
            this.trackBar_HumedadMaxima.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_HumedadMaxima.Name = "trackBar_HumedadMaxima";
            this.trackBar_HumedadMaxima.Size = new System.Drawing.Size(553, 56);
            this.trackBar_HumedadMaxima.TabIndex = 12;
            this.trackBar_HumedadMaxima.ValueChanged += new System.EventHandler(this.trackBar_HumedadMaxima_ValueChanged);
            this.trackBar_HumedadMaxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trackBar_HumedadMaxima_KeyPress);
            // 
            // lblHumedadMaxima
            // 
            this.lblHumedadMaxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHumedadMaxima.AutoSize = true;
            this.lblHumedadMaxima.BackColor = System.Drawing.Color.Transparent;
            this.lblHumedadMaxima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedadMaxima.Location = new System.Drawing.Point(16, 408);
            this.lblHumedadMaxima.Name = "lblHumedadMaxima";
            this.lblHumedadMaxima.Size = new System.Drawing.Size(341, 53);
            this.lblHumedadMaxima.TabIndex = 11;
            this.lblHumedadMaxima.Text = "Humedad máxima:";
            // 
            // trackBar_LuzMaxima
            // 
            this.trackBar_LuzMaxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar_LuzMaxima.Location = new System.Drawing.Point(335, 623);
            this.trackBar_LuzMaxima.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_LuzMaxima.Name = "trackBar_LuzMaxima";
            this.trackBar_LuzMaxima.Size = new System.Drawing.Size(553, 56);
            this.trackBar_LuzMaxima.TabIndex = 14;
            this.trackBar_LuzMaxima.ValueChanged += new System.EventHandler(this.trackBar_LuzMaxima_ValueChanged);
            this.trackBar_LuzMaxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trackBar_LuzMaxima_KeyPress);
            // 
            // lblLuzMaxima
            // 
            this.lblLuzMaxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLuzMaxima.AutoSize = true;
            this.lblLuzMaxima.BackColor = System.Drawing.Color.Transparent;
            this.lblLuzMaxima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuzMaxima.Location = new System.Drawing.Point(16, 608);
            this.lblLuzMaxima.Name = "lblLuzMaxima";
            this.lblLuzMaxima.Size = new System.Drawing.Size(234, 53);
            this.lblLuzMaxima.TabIndex = 13;
            this.lblLuzMaxima.Text = "Luz máxima:";
            // 
            // lblTipoPlanta
            // 
            this.lblTipoPlanta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoPlanta.AutoSize = true;
            this.lblTipoPlanta.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPlanta.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlanta.Location = new System.Drawing.Point(16, 226);
            this.lblTipoPlanta.Name = "lblTipoPlanta";
            this.lblTipoPlanta.Size = new System.Drawing.Size(289, 53);
            this.lblTipoPlanta.TabIndex = 15;
            this.lblTipoPlanta.Text = "Tipo de planta: ";
            // 
            // comboBox_TipoPlanta
            // 
            this.comboBox_TipoPlanta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_TipoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TipoPlanta.FormattingEnabled = true;
            this.comboBox_TipoPlanta.Items.AddRange(new object[] {
            "Bonsai",
            "Cactus",
            "Flor",
            "Pasto",
            "Suculenta",
            "Otro"});
            this.comboBox_TipoPlanta.Location = new System.Drawing.Point(431, 230);
            this.comboBox_TipoPlanta.Name = "comboBox_TipoPlanta";
            this.comboBox_TipoPlanta.Size = new System.Drawing.Size(457, 50);
            this.comboBox_TipoPlanta.TabIndex = 16;
            this.comboBox_TipoPlanta.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoPlanta_SelectedIndexChanged);
            this.comboBox_TipoPlanta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_TipoPlanta_KeyPress);
            // 
            // pictureBox_Familia
            // 
            this.pictureBox_Familia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Familia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Familia.Location = new System.Drawing.Point(1030, 321);
            this.pictureBox_Familia.Name = "pictureBox_Familia";
            this.pictureBox_Familia.Size = new System.Drawing.Size(300, 240);
            this.pictureBox_Familia.TabIndex = 17;
            this.pictureBox_Familia.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(51, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 65);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseDown);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // lblValorHumedadMinima
            // 
            this.lblValorHumedadMinima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorHumedadMinima.AutoSize = true;
            this.lblValorHumedadMinima.BackColor = System.Drawing.Color.Transparent;
            this.lblValorHumedadMinima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHumedadMinima.Location = new System.Drawing.Point(909, 323);
            this.lblValorHumedadMinima.Name = "lblValorHumedadMinima";
            this.lblValorHumedadMinima.Size = new System.Drawing.Size(86, 53);
            this.lblValorHumedadMinima.TabIndex = 23;
            this.lblValorHumedadMinima.Text = "(0%)";
            // 
            // lblValorHumedadMaxima
            // 
            this.lblValorHumedadMaxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorHumedadMaxima.AutoSize = true;
            this.lblValorHumedadMaxima.BackColor = System.Drawing.Color.Transparent;
            this.lblValorHumedadMaxima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHumedadMaxima.Location = new System.Drawing.Point(909, 423);
            this.lblValorHumedadMaxima.Name = "lblValorHumedadMaxima";
            this.lblValorHumedadMaxima.Size = new System.Drawing.Size(86, 53);
            this.lblValorHumedadMaxima.TabIndex = 24;
            this.lblValorHumedadMaxima.Text = "(0%)";
            // 
            // lblValorLuzMinima
            // 
            this.lblValorLuzMinima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorLuzMinima.AutoSize = true;
            this.lblValorLuzMinima.BackColor = System.Drawing.Color.Transparent;
            this.lblValorLuzMinima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLuzMinima.Location = new System.Drawing.Point(909, 523);
            this.lblValorLuzMinima.Name = "lblValorLuzMinima";
            this.lblValorLuzMinima.Size = new System.Drawing.Size(86, 53);
            this.lblValorLuzMinima.TabIndex = 25;
            this.lblValorLuzMinima.Text = "(0%)";
            // 
            // lblValorLuzMaxima
            // 
            this.lblValorLuzMaxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorLuzMaxima.AutoSize = true;
            this.lblValorLuzMaxima.BackColor = System.Drawing.Color.Transparent;
            this.lblValorLuzMaxima.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLuzMaxima.Location = new System.Drawing.Point(909, 623);
            this.lblValorLuzMaxima.Name = "lblValorLuzMaxima";
            this.lblValorLuzMaxima.Size = new System.Drawing.Size(86, 53);
            this.lblValorLuzMaxima.TabIndex = 26;
            this.lblValorLuzMaxima.Text = "(0%)";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::COPIA.Properties.Resources.btnOk;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(1225, 640);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 70);
            this.btnConfirmar.TabIndex = 27;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnConfirmar_MouseDown);
            this.btnConfirmar.MouseLeave += new System.EventHandler(this.btnConfirmar_MouseLeave);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.BorderColor = System.Drawing.Color.Black;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.Green;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(431, 141);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(457, 68);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // Edicion
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(100)))));
            this.BackgroundImage = global::COPIA.Properties.Resources.FondoForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblValorLuzMaxima);
            this.Controls.Add(this.lblValorLuzMinima);
            this.Controls.Add(this.lblValorHumedadMaxima);
            this.Controls.Add(this.lblValorHumedadMinima);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox_Familia);
            this.Controls.Add(this.comboBox_TipoPlanta);
            this.Controls.Add(this.lblTipoPlanta);
            this.Controls.Add(this.trackBar_LuzMaxima);
            this.Controls.Add(this.lblLuzMaxima);
            this.Controls.Add(this.trackBar_HumedadMaxima);
            this.Controls.Add(this.lblHumedadMaxima);
            this.Controls.Add(this.trackBar_LuzMinima);
            this.Controls.Add(this.trackBar_HumedadMinima);
            this.Controls.Add(this.lblLuzMinima);
            this.Controls.Add(this.lblHumedadMinima);
            this.Controls.Add(this.lblIngresarNombre);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edicion_FormClosed);
            this.Load += new System.EventHandler(this.Edicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LuzMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HumedadMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HumedadMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LuzMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Familia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNombre;
        private System.Windows.Forms.TrackBar trackBar_LuzMinima;
        private System.Windows.Forms.TrackBar trackBar_HumedadMinima;
        private System.Windows.Forms.Label lblLuzMinima;
        private System.Windows.Forms.Label lblHumedadMinima;
        private System.Windows.Forms.TrackBar trackBar_HumedadMaxima;
        private System.Windows.Forms.Label lblHumedadMaxima;
        private System.Windows.Forms.TrackBar trackBar_LuzMaxima;
        private System.Windows.Forms.Label lblLuzMaxima;
        private System.Windows.Forms.Label lblTipoPlanta;
        private System.Windows.Forms.ComboBox comboBox_TipoPlanta;
        private System.Windows.Forms.PictureBox pictureBox_Familia;
        private Custom_Controls.TextBox txtNombre;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblValorHumedadMinima;
        private System.Windows.Forms.Label lblValorHumedadMaxima;
        private System.Windows.Forms.Label lblValorLuzMinima;
        private System.Windows.Forms.Label lblValorLuzMaxima;
        private System.Windows.Forms.Button btnConfirmar;
    }
}