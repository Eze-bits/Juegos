
namespace Presentacion
{
    partial class Jugador_juegosFRM
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
            this.grillajugadores = new System.Windows.Forms.DataGridView();
            this.Jugadores = new System.Windows.Forms.Label();
            this.jugarpptbtn = new System.Windows.Forms.Button();
            this.jugatttbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillajugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // grillajugadores
            // 
            this.grillajugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillajugadores.Location = new System.Drawing.Point(51, 42);
            this.grillajugadores.MultiSelect = false;
            this.grillajugadores.Name = "grillajugadores";
            this.grillajugadores.ReadOnly = true;
            this.grillajugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillajugadores.Size = new System.Drawing.Size(380, 192);
            this.grillajugadores.TabIndex = 0;
            // 
            // Jugadores
            // 
            this.Jugadores.AutoSize = true;
            this.Jugadores.Location = new System.Drawing.Point(185, 9);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Size = new System.Drawing.Size(101, 13);
            this.Jugadores.TabIndex = 1;
            this.Jugadores.Text = "Seleccionar jugador";
            this.Jugadores.Click += new System.EventHandler(this.Jugadores_Click);
            // 
            // jugarpptbtn
            // 
            this.jugarpptbtn.Location = new System.Drawing.Point(168, 249);
            this.jugarpptbtn.Name = "jugarpptbtn";
            this.jugarpptbtn.Size = new System.Drawing.Size(140, 23);
            this.jugarpptbtn.TabIndex = 2;
            this.jugarpptbtn.Text = "Jugar piedra papel tijera";
            this.jugarpptbtn.UseVisualStyleBackColor = true;
            this.jugarpptbtn.Click += new System.EventHandler(this.jugarpptbtn_Click);
            // 
            // jugatttbtn
            // 
            this.jugatttbtn.Location = new System.Drawing.Point(168, 284);
            this.jugatttbtn.Name = "jugatttbtn";
            this.jugatttbtn.Size = new System.Drawing.Size(140, 23);
            this.jugatttbtn.TabIndex = 3;
            this.jugatttbtn.Text = "Jugar Ta - Te - Ti";
            this.jugatttbtn.UseVisualStyleBackColor = true;
            this.jugatttbtn.Click += new System.EventHandler(this.jugatttbtn_Click);
            // 
            // Jugador_juegosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 319);
            this.Controls.Add(this.jugatttbtn);
            this.Controls.Add(this.jugarpptbtn);
            this.Controls.Add(this.Jugadores);
            this.Controls.Add(this.grillajugadores);
            this.Name = "Jugador_juegosFRM";
            this.Text = "Juegos";
            this.Load += new System.EventHandler(this.JugadorpptFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillajugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillajugadores;
        private System.Windows.Forms.Label Jugadores;
        private System.Windows.Forms.Button jugarpptbtn;
        private System.Windows.Forms.Button jugatttbtn;
    }
}