
using System.Net.Http;

namespace COPIA
{
    partial class Notificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificaciones));
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblOn = new System.Windows.Forms.Label();
            this.txtTelefono = new COPIA.Custom_Controls.TextBox();
            this.toggleButton = new COPIA.Custom_Controls.ToggleButton();
            this.SuspendLayout();
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Font = new System.Drawing.Font("Comfortaa", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefono.Location = new System.Drawing.Point(13, 191);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(211, 62);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::COPIA.Properties.Resources.BtnOk2R;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(662, 323);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 70);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnConfirmar_MouseDown);
            this.btnConfirmar.MouseLeave += new System.EventHandler(this.btnConfirmar_MouseLeave);
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNotificaciones.Font = new System.Drawing.Font("Comfortaa", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNotificaciones.Location = new System.Drawing.Point(13, 57);
            this.lblNotificaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(329, 62);
            this.lblNotificaciones.TabIndex = 15;
            this.lblNotificaciones.Text = "Notificaciones: ";
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.BackColor = System.Drawing.Color.Transparent;
            this.lblOff.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.Location = new System.Drawing.Point(372, 66);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(95, 53);
            this.lblOff.TabIndex = 17;
            this.lblOff.Text = "OFF";
            // 
            // lblOn
            // 
            this.lblOn.AutoSize = true;
            this.lblOn.BackColor = System.Drawing.Color.Transparent;
            this.lblOn.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOn.Location = new System.Drawing.Point(656, 66);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(80, 53);
            this.lblOn.TabIndex = 18;
            this.lblOn.Text = "ON";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.Green;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefono.Location = new System.Drawing.Point(343, 199);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.Size = new System.Drawing.Size(348, 53);
            this.txtTelefono.TabIndex = 20;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // toggleButton
            // 
            this.toggleButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.toggleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toggleButton.Checked = true;
            this.toggleButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton.FlatAppearance.BorderSize = 0;
            this.toggleButton.Location = new System.Drawing.Point(497, 75);
            this.toggleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggleButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.OffBackColor = System.Drawing.Color.IndianRed;
            this.toggleButton.OffToggleColor = System.Drawing.Color.Snow;
            this.toggleButton.OnBackColor = System.Drawing.Color.MediumBlue;
            this.toggleButton.OnToggleColor = System.Drawing.Color.Snow;
            this.toggleButton.Size = new System.Drawing.Size(123, 39);
            this.toggleButton.TabIndex = 19;
            this.toggleButton.UseVisualStyleBackColor = false;
            this.toggleButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toggleButton_KeyPress);
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COPIA.Properties.Resources.FondoSerial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 404);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.lblOn);
            this.Controls.Add(this.lblOff);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 451);
            this.MinimumSize = new System.Drawing.Size(803, 451);
            this.Name = "Notificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Label lblOn;
        static HttpClient client = new HttpClient();
        private Custom_Controls.ToggleButton toggleButton;
        private Custom_Controls.TextBox txtTelefono;
    }
}