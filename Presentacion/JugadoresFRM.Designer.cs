
namespace Presentacion
{
    partial class JugadoresFRM
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
            this.grilla_jugadores = new System.Windows.Forms.DataGridView();
            this.altabtn = new System.Windows.Forms.Button();
            this.modbtn = new System.Windows.Forms.Button();
            this.bajabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_jugadores
            // 
            this.grilla_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_jugadores.Location = new System.Drawing.Point(115, 92);
            this.grilla_jugadores.MultiSelect = false;
            this.grilla_jugadores.Name = "grilla_jugadores";
            this.grilla_jugadores.ReadOnly = true;
            this.grilla_jugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_jugadores.Size = new System.Drawing.Size(407, 238);
            this.grilla_jugadores.TabIndex = 0;
            // 
            // altabtn
            // 
            this.altabtn.Location = new System.Drawing.Point(601, 92);
            this.altabtn.Name = "altabtn";
            this.altabtn.Size = new System.Drawing.Size(75, 23);
            this.altabtn.TabIndex = 1;
            this.altabtn.Text = "Alta";
            this.altabtn.UseVisualStyleBackColor = true;
            this.altabtn.Click += new System.EventHandler(this.altabtn_Click);
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(601, 157);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(75, 23);
            this.modbtn.TabIndex = 2;
            this.modbtn.Text = "Modificacion";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // bajabtn
            // 
            this.bajabtn.Location = new System.Drawing.Point(601, 217);
            this.bajabtn.Name = "bajabtn";
            this.bajabtn.Size = new System.Drawing.Size(75, 23);
            this.bajabtn.TabIndex = 3;
            this.bajabtn.Text = "Baja";
            this.bajabtn.UseVisualStyleBackColor = true;
            this.bajabtn.Click += new System.EventHandler(this.bajabtn_Click);
            // 
            // JugadoresFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bajabtn);
            this.Controls.Add(this.modbtn);
            this.Controls.Add(this.altabtn);
            this.Controls.Add(this.grilla_jugadores);
            this.Name = "JugadoresFRM";
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.JugadoresFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_jugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_jugadores;
        private System.Windows.Forms.Button altabtn;
        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.Button bajabtn;
    }
}