namespace SerialComm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.btAbrirCon = new System.Windows.Forms.Button();
            this.lbConState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNivel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAbrirCon
            // 
            this.btAbrirCon.Location = new System.Drawing.Point(12, 12);
            this.btAbrirCon.Name = "btAbrirCon";
            this.btAbrirCon.Size = new System.Drawing.Size(75, 23);
            this.btAbrirCon.TabIndex = 0;
            this.btAbrirCon.Text = "Abrir Porta";
            this.btAbrirCon.UseVisualStyleBackColor = true;
            this.btAbrirCon.Click += new System.EventHandler(this.btAbrirCon_Click);
            // 
            // lbConState
            // 
            this.lbConState.AutoSize = true;
            this.lbConState.Location = new System.Drawing.Point(12, 38);
            this.lbConState.Name = "lbConState";
            this.lbConState.Size = new System.Drawing.Size(94, 13);
            this.lbConState.TabIndex = 1;
            this.lbConState.Text = "Conexão fechada.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNivel);
            this.groupBox1.Location = new System.Drawing.Point(112, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nível";
            // 
            // lbNivel
            // 
            this.lbNivel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbNivel.BackColor = System.Drawing.Color.Red;
            this.lbNivel.Location = new System.Drawing.Point(10, 25);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(52, 256);
            this.lbNivel.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbConState);
            this.Controls.Add(this.btAbrirCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Button btAbrirCon;
        private System.Windows.Forms.Label lbConState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

