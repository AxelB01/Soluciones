
namespace EjercicioColasFilas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasEnlazadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCola = new System.Windows.Forms.Panel();
            this.btnColaEliminar = new System.Windows.Forms.Button();
            this.btnColaAgregar = new System.Windows.Forms.Button();
            this.textBoxCola = new System.Windows.Forms.TextBox();
            this.dataGridViewCola = new System.Windows.Forms.DataGridView();
            this.panelPila = new System.Windows.Forms.Panel();
            this.btnPilaEliminar = new System.Windows.Forms.Button();
            this.btnPilaAgregar = new System.Windows.Forms.Button();
            this.textBoxPila = new System.Windows.Forms.TextBox();
            this.dataGridViewPila = new System.Windows.Forms.DataGridView();
            this.panelListaEnlazada = new System.Windows.Forms.Panel();
            this.btnListaEnlazadaAgregarUltimo = new System.Windows.Forms.Button();
            this.btnListaEnlazadaAgregarPrimero = new System.Windows.Forms.Button();
            this.textBoxListaEnlazada = new System.Windows.Forms.TextBox();
            this.dataGridViewListaEnlazada = new System.Windows.Forms.DataGridView();
            this.contextMenuListaEnlazada = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCola)).BeginInit();
            this.panelPila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPila)).BeginInit();
            this.panelListaEnlazada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaEnlazada)).BeginInit();
            this.contextMenuListaEnlazada.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasEnlazadasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.pilasToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // listasEnlazadasToolStripMenuItem
            // 
            this.listasEnlazadasToolStripMenuItem.Name = "listasEnlazadasToolStripMenuItem";
            this.listasEnlazadasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listasEnlazadasToolStripMenuItem.Text = "Listas Enlazadas";
            this.listasEnlazadasToolStripMenuItem.Click += new System.EventHandler(this.listasEnlazadasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.registroColaToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.registroPilaToolStripMenuItem_Click);
            // 
            // panelCola
            // 
            this.panelCola.Controls.Add(this.btnColaEliminar);
            this.panelCola.Controls.Add(this.btnColaAgregar);
            this.panelCola.Controls.Add(this.textBoxCola);
            this.panelCola.Controls.Add(this.dataGridViewCola);
            this.panelCola.Location = new System.Drawing.Point(12, 27);
            this.panelCola.Name = "panelCola";
            this.panelCola.Size = new System.Drawing.Size(776, 411);
            this.panelCola.TabIndex = 1;
            // 
            // btnColaEliminar
            // 
            this.btnColaEliminar.Location = new System.Drawing.Point(602, 29);
            this.btnColaEliminar.Name = "btnColaEliminar";
            this.btnColaEliminar.Size = new System.Drawing.Size(171, 23);
            this.btnColaEliminar.TabIndex = 3;
            this.btnColaEliminar.Text = "Sacar de la cola";
            this.btnColaEliminar.UseVisualStyleBackColor = true;
            this.btnColaEliminar.Click += new System.EventHandler(this.btnColaEliminar_Click);
            // 
            // btnColaAgregar
            // 
            this.btnColaAgregar.Location = new System.Drawing.Point(425, 29);
            this.btnColaAgregar.Name = "btnColaAgregar";
            this.btnColaAgregar.Size = new System.Drawing.Size(171, 23);
            this.btnColaAgregar.TabIndex = 2;
            this.btnColaAgregar.Text = "Agregar a la cola";
            this.btnColaAgregar.UseVisualStyleBackColor = true;
            this.btnColaAgregar.Click += new System.EventHandler(this.btnColaAgregar_Click);
            // 
            // textBoxCola
            // 
            this.textBoxCola.Location = new System.Drawing.Point(4, 29);
            this.textBoxCola.Name = "textBoxCola";
            this.textBoxCola.Size = new System.Drawing.Size(235, 20);
            this.textBoxCola.TabIndex = 1;
            // 
            // dataGridViewCola
            // 
            this.dataGridViewCola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCola.Location = new System.Drawing.Point(3, 58);
            this.dataGridViewCola.MultiSelect = false;
            this.dataGridViewCola.Name = "dataGridViewCola";
            this.dataGridViewCola.ReadOnly = true;
            this.dataGridViewCola.Size = new System.Drawing.Size(769, 350);
            this.dataGridViewCola.TabIndex = 0;
            // 
            // panelPila
            // 
            this.panelPila.Controls.Add(this.btnPilaEliminar);
            this.panelPila.Controls.Add(this.btnPilaAgregar);
            this.panelPila.Controls.Add(this.textBoxPila);
            this.panelPila.Controls.Add(this.dataGridViewPila);
            this.panelPila.Location = new System.Drawing.Point(12, 27);
            this.panelPila.Name = "panelPila";
            this.panelPila.Size = new System.Drawing.Size(776, 411);
            this.panelPila.TabIndex = 3;
            // 
            // btnPilaEliminar
            // 
            this.btnPilaEliminar.Location = new System.Drawing.Point(602, 29);
            this.btnPilaEliminar.Name = "btnPilaEliminar";
            this.btnPilaEliminar.Size = new System.Drawing.Size(171, 23);
            this.btnPilaEliminar.TabIndex = 3;
            this.btnPilaEliminar.Text = "Sacar de la pila";
            this.btnPilaEliminar.UseVisualStyleBackColor = true;
            this.btnPilaEliminar.Click += new System.EventHandler(this.btnPilaEliminar_Click);
            // 
            // btnPilaAgregar
            // 
            this.btnPilaAgregar.Location = new System.Drawing.Point(425, 29);
            this.btnPilaAgregar.Name = "btnPilaAgregar";
            this.btnPilaAgregar.Size = new System.Drawing.Size(171, 23);
            this.btnPilaAgregar.TabIndex = 2;
            this.btnPilaAgregar.Text = "Agregar a la pila";
            this.btnPilaAgregar.UseVisualStyleBackColor = true;
            this.btnPilaAgregar.Click += new System.EventHandler(this.btnPilaAgregar_Click);
            // 
            // textBoxPila
            // 
            this.textBoxPila.Location = new System.Drawing.Point(4, 29);
            this.textBoxPila.Name = "textBoxPila";
            this.textBoxPila.Size = new System.Drawing.Size(235, 20);
            this.textBoxPila.TabIndex = 1;
            // 
            // dataGridViewPila
            // 
            this.dataGridViewPila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPila.Location = new System.Drawing.Point(3, 58);
            this.dataGridViewPila.MultiSelect = false;
            this.dataGridViewPila.Name = "dataGridViewPila";
            this.dataGridViewPila.ReadOnly = true;
            this.dataGridViewPila.Size = new System.Drawing.Size(769, 350);
            this.dataGridViewPila.TabIndex = 0;
            // 
            // panelListaEnlazada
            // 
            this.panelListaEnlazada.Controls.Add(this.btnListaEnlazadaAgregarUltimo);
            this.panelListaEnlazada.Controls.Add(this.btnListaEnlazadaAgregarPrimero);
            this.panelListaEnlazada.Controls.Add(this.textBoxListaEnlazada);
            this.panelListaEnlazada.Controls.Add(this.dataGridViewListaEnlazada);
            this.panelListaEnlazada.Location = new System.Drawing.Point(12, 27);
            this.panelListaEnlazada.Name = "panelListaEnlazada";
            this.panelListaEnlazada.Size = new System.Drawing.Size(776, 411);
            this.panelListaEnlazada.TabIndex = 4;
            // 
            // btnListaEnlazadaAgregarUltimo
            // 
            this.btnListaEnlazadaAgregarUltimo.Location = new System.Drawing.Point(602, 29);
            this.btnListaEnlazadaAgregarUltimo.Name = "btnListaEnlazadaAgregarUltimo";
            this.btnListaEnlazadaAgregarUltimo.Size = new System.Drawing.Size(171, 23);
            this.btnListaEnlazadaAgregarUltimo.TabIndex = 4;
            this.btnListaEnlazadaAgregarUltimo.Text = "Agregar como ultimo";
            this.btnListaEnlazadaAgregarUltimo.UseVisualStyleBackColor = true;
            this.btnListaEnlazadaAgregarUltimo.Click += new System.EventHandler(this.btnListaEnlazadaAgregarUltimo_Click);
            // 
            // btnListaEnlazadaAgregarPrimero
            // 
            this.btnListaEnlazadaAgregarPrimero.Location = new System.Drawing.Point(425, 29);
            this.btnListaEnlazadaAgregarPrimero.Name = "btnListaEnlazadaAgregarPrimero";
            this.btnListaEnlazadaAgregarPrimero.Size = new System.Drawing.Size(171, 23);
            this.btnListaEnlazadaAgregarPrimero.TabIndex = 3;
            this.btnListaEnlazadaAgregarPrimero.Text = "Agregar como primero";
            this.btnListaEnlazadaAgregarPrimero.UseVisualStyleBackColor = true;
            this.btnListaEnlazadaAgregarPrimero.Click += new System.EventHandler(this.btnListaEnlazadaAgregarPrimero_Click);
            // 
            // textBoxListaEnlazada
            // 
            this.textBoxListaEnlazada.Location = new System.Drawing.Point(3, 32);
            this.textBoxListaEnlazada.Name = "textBoxListaEnlazada";
            this.textBoxListaEnlazada.Size = new System.Drawing.Size(235, 20);
            this.textBoxListaEnlazada.TabIndex = 2;
            // 
            // dataGridViewListaEnlazada
            // 
            this.dataGridViewListaEnlazada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaEnlazada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaEnlazada.Location = new System.Drawing.Point(4, 58);
            this.dataGridViewListaEnlazada.MultiSelect = false;
            this.dataGridViewListaEnlazada.Name = "dataGridViewListaEnlazada";
            this.dataGridViewListaEnlazada.ReadOnly = true;
            this.dataGridViewListaEnlazada.Size = new System.Drawing.Size(768, 350);
            this.dataGridViewListaEnlazada.TabIndex = 0;
            this.dataGridViewListaEnlazada.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewListaEnlazada_CellMouseClick);
            // 
            // contextMenuListaEnlazada
            // 
            this.contextMenuListaEnlazada.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moverToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuListaEnlazada.Name = "contextMenuListaEnlazada";
            this.contextMenuListaEnlazada.Size = new System.Drawing.Size(181, 70);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelListaEnlazada);
            this.Controls.Add(this.panelPila);
            this.Controls.Add(this.panelCola);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCola.ResumeLayout(false);
            this.panelCola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCola)).EndInit();
            this.panelPila.ResumeLayout(false);
            this.panelPila.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPila)).EndInit();
            this.panelListaEnlazada.ResumeLayout(false);
            this.panelListaEnlazada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaEnlazada)).EndInit();
            this.contextMenuListaEnlazada.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelCola;
        private System.Windows.Forms.Button btnColaEliminar;
        private System.Windows.Forms.Button btnColaAgregar;
        private System.Windows.Forms.TextBox textBoxCola;
        private System.Windows.Forms.DataGridView dataGridViewCola;
        private System.Windows.Forms.Panel panelPila;
        private System.Windows.Forms.Button btnPilaEliminar;
        private System.Windows.Forms.Button btnPilaAgregar;
        private System.Windows.Forms.TextBox textBoxPila;
        private System.Windows.Forms.DataGridView dataGridViewPila;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasEnlazadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.Panel panelListaEnlazada;
        private System.Windows.Forms.Button btnListaEnlazadaAgregarUltimo;
        private System.Windows.Forms.Button btnListaEnlazadaAgregarPrimero;
        private System.Windows.Forms.TextBox textBoxListaEnlazada;
        private System.Windows.Forms.DataGridView dataGridViewListaEnlazada;
        private System.Windows.Forms.ContextMenuStrip contextMenuListaEnlazada;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}

