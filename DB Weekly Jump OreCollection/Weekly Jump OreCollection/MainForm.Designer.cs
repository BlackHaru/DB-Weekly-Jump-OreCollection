namespace Weekly_Jump_OreCollection
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeOfSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.nameToSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableCharacters = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // typeOfSort
            // 
            this.typeOfSort.AutoCompleteCustomSource.AddRange(new string[] {
            "Serie",
            "Clase",
            "Tipo",
            "Era",
            "Nombre",
            "HP",
            "Ataque",
            "Defensa",
            "Velocidad"});
            this.typeOfSort.FormattingEnabled = true;
            this.typeOfSort.Location = new System.Drawing.Point(444, 10);
            this.typeOfSort.Name = "typeOfSort";
            this.typeOfSort.Size = new System.Drawing.Size(121, 21);
            this.typeOfSort.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(571, 9);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(77, 21);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "FILTRAR";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // nameToSearch
            // 
            this.nameToSearch.Location = new System.Drawing.Point(13, 11);
            this.nameToSearch.Name = "nameToSearch";
            this.nameToSearch.Size = new System.Drawing.Size(155, 20);
            this.nameToSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(173, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tableCharacters
            // 
            this.tableCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCharacters.Location = new System.Drawing.Point(13, 45);
            this.tableCharacters.Name = "tableCharacters";
            this.tableCharacters.Size = new System.Drawing.Size(635, 399);
            this.tableCharacters.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(256, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(21, 21);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 456);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableCharacters);
            this.Controls.Add(this.nameToSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.typeOfSort);
            this.Name = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.tableCharacters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeOfSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox nameToSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView tableCharacters;
        private System.Windows.Forms.Button btnAdd;
    }
}

