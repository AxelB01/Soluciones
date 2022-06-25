namespace WinFormsApp.ListaEnlazada
{
    partial class ListaEnlazada
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
            this.estudiantesGridView = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estudiantesGridView
            // 
            this.estudiantesGridView.AllowUserToAddRows = false;
            this.estudiantesGridView.AllowUserToDeleteRows = false;
            this.estudiantesGridView.AllowUserToResizeColumns = false;
            this.estudiantesGridView.AllowUserToResizeRows = false;
            this.estudiantesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estudiantesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.estudiantesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudiantesGridView.Location = new System.Drawing.Point(12, 70);
            this.estudiantesGridView.MultiSelect = false;
            this.estudiantesGridView.Name = "estudiantesGridView";
            this.estudiantesGridView.ReadOnly = true;
            this.estudiantesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.estudiantesGridView.RowTemplate.Height = 25;
            this.estudiantesGridView.RowTemplate.ReadOnly = true;
            this.estudiantesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.estudiantesGridView.Size = new System.Drawing.Size(610, 297);
            this.estudiantesGridView.TabIndex = 1;
            this.estudiantesGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.estudiantesGridView_MouseClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(384, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(520, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moverToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // moverToolStripMenuItem
            // 
            this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
            this.moverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moverToolStripMenuItem.Text = "Mover";
            this.moverToolStripMenuItem.Click += new System.EventHandler(this.moverToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(12, 12);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(384, 23);
            this.txtEstudiante.TabIndex = 8;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(412, 12);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(102, 23);
            this.btnPrimero.TabIndex = 9;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(520, 12);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(102, 23);
            this.btnUltimo.TabIndex = 10;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // ListaEnlazada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 379);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.estudiantesGridView);
            this.Name = "ListaEnlazada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaEnlazada";
            this.Load += new System.EventHandler(this.ListaEnlazada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView estudiantesGridView;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem moverToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private TextBox txtEstudiante;
        private Button btnPrimero;
        private Button btnUltimo;
    }
}