using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejercicio02;

partial class frmColaDePrioridades
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
        txtNombre = new TextBox();
        txtPrioridad = new TextBox();
        btnEncolar = new Button();
        btnDesencolar = new Button();
        lblId = new Label();
        lstCola = new ListBox();
        lblPrioridad = new Label();
        SuspendLayout();
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(126, 50);
        txtNombre.Margin = new Padding(5, 5, 5, 5);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(312, 32);
        txtNombre.TabIndex = 0;
        // 
        // txtPrioridad
        // 
        txtPrioridad.Location = new Point(126, 117);
        txtPrioridad.Margin = new Padding(5, 5, 5, 5);
        txtPrioridad.Name = "txtPrioridad";
        txtPrioridad.Size = new Size(312, 32);
        txtPrioridad.TabIndex = 1;
        // 
        // btnEncolar
        // 
        btnEncolar.Location = new Point(95, 198);
        btnEncolar.Margin = new Padding(5, 5, 5, 5);
        btnEncolar.Name = "btnEncolar";
        btnEncolar.Size = new Size(128, 55);
        btnEncolar.TabIndex = 2;
        btnEncolar.Text = "Encolar";
        btnEncolar.UseVisualStyleBackColor = true;
        btnEncolar.Click += btnEncolar_Click;
        // 
        // btnDesencolar
        // 
        btnDesencolar.Location = new Point(255, 198);
        btnDesencolar.Margin = new Padding(5, 5, 5, 5);
        btnDesencolar.Name = "btnDesencolar";
        btnDesencolar.Size = new Size(128, 55);
        btnDesencolar.TabIndex = 3;
        btnDesencolar.Text = "Desencolar";
        btnDesencolar.UseVisualStyleBackColor = true;
        btnDesencolar.Click += btnDesencolar_Click;
        // 
        // lblId
        // 
        lblId.AutoSize = true;
        lblId.Location = new Point(31, 50);
        lblId.Margin = new Padding(5, 0, 5, 0);
        lblId.Name = "lblId";
        lblId.Size = new Size(81, 25);
        lblId.TabIndex = 4;
        lblId.Text = "Nombre";
        // 
        // lstCola
        // 
        lstCola.FormattingEnabled = true;
        lstCola.ItemHeight = 25;
        lstCola.Location = new Point(31, 292);
        lstCola.Margin = new Padding(5, 5, 5, 5);
        lstCola.Name = "lstCola";
        lstCola.Size = new Size(407, 179);
        lstCola.TabIndex = 5;
        // 
        // lblPrioridad
        // 
        lblPrioridad.AutoSize = true;
        lblPrioridad.Location = new Point(31, 122);
        lblPrioridad.Margin = new Padding(5, 0, 5, 0);
        lblPrioridad.Name = "lblPrioridad";
        lblPrioridad.Size = new Size(90, 25);
        lblPrioridad.TabIndex = 6;
        lblPrioridad.Text = "Prioridad";
        // 
        // frmColaDePrioridades
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(482, 530);
        Controls.Add(lblPrioridad);
        Controls.Add(lstCola);
        Controls.Add(lblId);
        Controls.Add(btnDesencolar);
        Controls.Add(btnEncolar);
        Controls.Add(txtPrioridad);
        Controls.Add(txtNombre);
        Font = new System.Drawing.Font("Segoe UI", 14F);
        Margin = new Padding(5, 5, 5, 5);
        Name = "frmColaDePrioridades";
        Text = "Cola de prioridades";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtNombre;
    private TextBox txtPrioridad;
    private Button btnEncolar;
    private Button btnDesencolar;
    private Label lblId;
    private ListBox lstCola;
    private Label lblPrioridad;
}
