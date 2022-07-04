using System.IO.Ports;

namespace COPIA
{
    partial class RecibirDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecibirDatos));
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.comboBox_Select = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Start.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTN_Start.Location = new System.Drawing.Point(234, 119);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(150, 50);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Abrir";
            this.BTN_Start.UseVisualStyleBackColor = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.BackColor = System.Drawing.Color.LightGreen;
            this.BTN_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Stop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTN_Stop.Location = new System.Drawing.Point(392, 119);
            this.BTN_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(150, 50);
            this.BTN_Stop.TabIndex = 4;
            this.BTN_Stop.Text = "Cerrar";
            this.BTN_Stop.UseVisualStyleBackColor = false;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(30, 121);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(185, 44);
            this.comboBox_Port.TabIndex = 5;
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.LightYellow;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(30, 195);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerial.Multiline = true;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(512, 207);
            this.txtSerial.TabIndex = 6;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            // 
            // comboBox_Select
            // 
            this.comboBox_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Select.FormattingEnabled = true;
            this.comboBox_Select.Items.AddRange(new object[] {
            "Wifi",
            "Serial Port"});
            this.comboBox_Select.Location = new System.Drawing.Point(30, 39);
            this.comboBox_Select.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Select.Name = "comboBox_Select";
            this.comboBox_Select.Size = new System.Drawing.Size(185, 44);
            this.comboBox_Select.TabIndex = 7;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightGreen;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSelect.Location = new System.Drawing.Point(234, 33);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(308, 50);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // RecibirDatos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::COPIA.Properties.Resources.FondoSerial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 424);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.comboBox_Select);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.BTN_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 471);
            this.MinimumSize = new System.Drawing.Size(578, 471);
            this.Name = "RecibirDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConectarSerialPort_FormClosed);
            this.Load += new System.EventHandler(this.ConectarSerialPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.ComboBox comboBox_Select;
        private System.Windows.Forms.Button btnSelect;
    }
}