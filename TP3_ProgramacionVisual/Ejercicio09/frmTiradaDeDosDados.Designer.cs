namespace Ejercicio09
{
    partial class frmTiradaDeDosDados
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
            txtValorDado1 = new TextBox();
            btnTirarDados = new Button();
            txtValorDado2 = new TextBox();
            dataGridView1 = new DataGridView();
            valor1DelDado = new DataGridViewTextBoxColumn();
            valor2DelDado = new DataGridViewTextBoxColumn();
            valor3DelDado = new DataGridViewTextBoxColumn();
            valor4DelDado = new DataGridViewTextBoxColumn();
            valor5DelDado = new DataGridViewTextBoxColumn();
            valor6DelDado = new DataGridViewTextBoxColumn();
            porcentajeDado1 = new DataGridViewTextBoxColumn();
            porcentajeDado2 = new DataGridViewTextBoxColumn();
            porcentajeDado3 = new DataGridViewTextBoxColumn();
            porcentajeDado4 = new DataGridViewTextBoxColumn();
            porcentajeDado5 = new DataGridViewTextBoxColumn();
            porcentajeDado6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtValorDado1
            // 
            txtValorDado1.Font = new Font("Segoe UI", 14F);
            txtValorDado1.Location = new Point(478, 147);
            txtValorDado1.Name = "txtValorDado1";
            txtValorDado1.Size = new Size(141, 32);
            txtValorDado1.TabIndex = 3;
            // 
            // btnTirarDados
            // 
            btnTirarDados.BackColor = Color.FromArgb(0, 0, 192);
            btnTirarDados.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTirarDados.ForeColor = Color.White;
            btnTirarDados.Location = new Point(270, 173);
            btnTirarDados.Name = "btnTirarDados";
            btnTirarDados.Size = new Size(188, 67);
            btnTirarDados.TabIndex = 2;
            btnTirarDados.Text = "Tirar 2 dados";
            btnTirarDados.UseVisualStyleBackColor = false;
            btnTirarDados.Click += btnTirarDados_Click;
            // 
            // txtValorDado2
            // 
            txtValorDado2.Font = new Font("Segoe UI", 14F);
            txtValorDado2.Location = new Point(478, 238);
            txtValorDado2.Name = "txtValorDado2";
            txtValorDado2.Size = new Size(141, 32);
            txtValorDado2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { valor1DelDado, valor2DelDado, valor3DelDado, valor4DelDado, valor5DelDado, valor6DelDado, porcentajeDado1, porcentajeDado2, porcentajeDado3, porcentajeDado4, porcentajeDado5, porcentajeDado6 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(947, 112);
            dataGridView1.TabIndex = 5;
            // 
            // valor1DelDado
            // 
            valor1DelDado.HeaderText = "Veces que salió 1";
            valor1DelDado.Name = "valor1DelDado";
            valor1DelDado.ReadOnly = true;
            valor1DelDado.Width = 75;
            // 
            // valor2DelDado
            // 
            valor2DelDado.HeaderText = "Veces que salió 2";
            valor2DelDado.Name = "valor2DelDado";
            valor2DelDado.ReadOnly = true;
            valor2DelDado.Width = 75;
            // 
            // valor3DelDado
            // 
            valor3DelDado.HeaderText = "Veces que salió 3";
            valor3DelDado.Name = "valor3DelDado";
            valor3DelDado.ReadOnly = true;
            valor3DelDado.Width = 75;
            // 
            // valor4DelDado
            // 
            valor4DelDado.HeaderText = "Veces que salió 4";
            valor4DelDado.Name = "valor4DelDado";
            valor4DelDado.ReadOnly = true;
            valor4DelDado.Width = 75;
            // 
            // valor5DelDado
            // 
            valor5DelDado.HeaderText = "Veces que salió 5";
            valor5DelDado.Name = "valor5DelDado";
            valor5DelDado.ReadOnly = true;
            valor5DelDado.Width = 75;
            // 
            // valor6DelDado
            // 
            valor6DelDado.HeaderText = "Veces que salió 6";
            valor6DelDado.Name = "valor6DelDado";
            valor6DelDado.ReadOnly = true;
            valor6DelDado.Width = 75;
            // 
            // porcentajeDado1
            // 
            porcentajeDado1.HeaderText = "Porcentaje del dado 1";
            porcentajeDado1.Name = "porcentajeDado1";
            porcentajeDado1.ReadOnly = true;
            porcentajeDado1.Width = 75;
            // 
            // porcentajeDado2
            // 
            porcentajeDado2.HeaderText = "Porcentaje del dado 2";
            porcentajeDado2.Name = "porcentajeDado2";
            porcentajeDado2.ReadOnly = true;
            porcentajeDado2.Width = 75;
            // 
            // porcentajeDado3
            // 
            porcentajeDado3.HeaderText = "Porcentaje del dado 3";
            porcentajeDado3.Name = "porcentajeDado3";
            porcentajeDado3.ReadOnly = true;
            porcentajeDado3.Width = 75;
            // 
            // porcentajeDado4
            // 
            porcentajeDado4.HeaderText = "Porcentaje del dado 4";
            porcentajeDado4.Name = "porcentajeDado4";
            porcentajeDado4.ReadOnly = true;
            porcentajeDado4.Width = 75;
            // 
            // porcentajeDado5
            // 
            porcentajeDado5.HeaderText = "Porcentaje del dado 5";
            porcentajeDado5.Name = "porcentajeDado5";
            porcentajeDado5.ReadOnly = true;
            porcentajeDado5.Width = 75;
            // 
            // porcentajeDado6
            // 
            porcentajeDado6.HeaderText = "Porcentaje del dado 6";
            porcentajeDado6.Name = "porcentajeDado6";
            porcentajeDado6.ReadOnly = true;
            porcentajeDado6.Width = 75;
            // 
            // frmTiradaDeDosDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 298);
            Controls.Add(dataGridView1);
            Controls.Add(txtValorDado2);
            Controls.Add(txtValorDado1);
            Controls.Add(btnTirarDados);
            Name = "frmTiradaDeDosDados";
            Text = "Tirada de 2 dados";
            Load += frmTiradaDeDosDados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorDado1;
        private Button btnTirarDados;
        private TextBox txtValorDado2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn valor1DelDado;
        private DataGridViewTextBoxColumn valor2DelDado;
        private DataGridViewTextBoxColumn valor3DelDado;
        private DataGridViewTextBoxColumn valor4DelDado;
        private DataGridViewTextBoxColumn valor5DelDado;
        private DataGridViewTextBoxColumn valor6DelDado;
        private DataGridViewTextBoxColumn porcentajeDado1;
        private DataGridViewTextBoxColumn porcentajeDado2;
        private DataGridViewTextBoxColumn porcentajeDado3;
        private DataGridViewTextBoxColumn porcentajeDado4;
        private DataGridViewTextBoxColumn porcentajeDado5;
        private DataGridViewTextBoxColumn porcentajeDado6;
    }
}
