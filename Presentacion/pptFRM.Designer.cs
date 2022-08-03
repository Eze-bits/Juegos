
namespace Presentacion
{
    partial class pptFRM
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
            this.comboelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jugarbtn = new System.Windows.Forms.Button();
            this.resultadotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.respuestatxt = new System.Windows.Forms.TextBox();
            this.puntostxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboelect
            // 
            this.comboelect.FormattingEnabled = true;
            this.comboelect.Location = new System.Drawing.Point(167, 87);
            this.comboelect.Name = "comboelect";
            this.comboelect.Size = new System.Drawing.Size(121, 21);
            this.comboelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eleccion del jugada";
            // 
            // jugarbtn
            // 
            this.jugarbtn.Location = new System.Drawing.Point(179, 137);
            this.jugarbtn.Name = "jugarbtn";
            this.jugarbtn.Size = new System.Drawing.Size(75, 23);
            this.jugarbtn.TabIndex = 4;
            this.jugarbtn.Text = "Jugar";
            this.jugarbtn.UseVisualStyleBackColor = true;
            this.jugarbtn.Click += new System.EventHandler(this.jugarbtn_Click);
            // 
            // resultadotxt
            // 
            this.resultadotxt.Location = new System.Drawing.Point(99, 214);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.ReadOnly = true;
            this.resultadotxt.Size = new System.Drawing.Size(100, 20);
            this.resultadotxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Respuesta de PC";
            // 
            // respuestatxt
            // 
            this.respuestatxt.Location = new System.Drawing.Point(260, 214);
            this.respuestatxt.Name = "respuestatxt";
            this.respuestatxt.ReadOnly = true;
            this.respuestatxt.Size = new System.Drawing.Size(100, 20);
            this.respuestatxt.TabIndex = 8;
            // 
            // puntostxt
            // 
            this.puntostxt.Location = new System.Drawing.Point(340, 86);
            this.puntostxt.Name = "puntostxt";
            this.puntostxt.ReadOnly = true;
            this.puntostxt.Size = new System.Drawing.Size(100, 20);
            this.puntostxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Elija la jugada y presione en jugar";
            // 
            // pptFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.puntostxt);
            this.Controls.Add(this.respuestatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.jugarbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboelect);
            this.Name = "pptFRM";
            this.Text = "Piedra, Papel o Tijera";
            this.Load += new System.EventHandler(this.pptFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jugarbtn;
        private System.Windows.Forms.TextBox resultadotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox respuestatxt;
        private System.Windows.Forms.TextBox puntostxt;
        private System.Windows.Forms.Label label4;
    }
}