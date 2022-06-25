namespace WinFormsApp.Pila
{
    partial class StackForm
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
            this.librosGridView = new System.Windows.Forms.DataGridView();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.librosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // librosGridView
            // 
            this.librosGridView.AllowUserToAddRows = false;
            this.librosGridView.AllowUserToDeleteRows = false;
            this.librosGridView.AllowUserToResizeColumns = false;
            this.librosGridView.AllowUserToResizeRows = false;
            this.librosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.librosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosGridView.Location = new System.Drawing.Point(12, 52);
            this.librosGridView.MultiSelect = false;
            this.librosGridView.Name = "librosGridView";
            this.librosGridView.ReadOnly = true;
            this.librosGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.librosGridView.RowTemplate.Height = 25;
            this.librosGridView.RowTemplate.ReadOnly = true;
            this.librosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosGridView.Size = new System.Drawing.Size(610, 315);
            this.librosGridView.TabIndex = 2;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(12, 23);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(343, 23);
            this.txtAgregar.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(392, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(510, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // StackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 379);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.librosGridView);
            this.Name = "StackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StackForm";
            this.Load += new System.EventHandler(this.StackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView librosGridView;
        private TextBox txtAgregar;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}