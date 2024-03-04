namespace Presentation
{
    partial class datau
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.texId = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Insertar = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.DateBirth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Name = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxSeleccionar = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.btnSearch);
            this.Tab.Controls.Add(this.search);
            this.Tab.Controls.Add(this.Data);
            this.Tab.Location = new System.Drawing.Point(4, 22);
            this.Tab.Name = "Tab";
            this.Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Tab.Size = new System.Drawing.Size(786, 407);
            this.Tab.TabIndex = 0;
            this.Tab.Text = "List";
            this.Tab.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(227, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(18, 16);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 20);
            this.search.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.AllowUserToOrderColumns = true;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.Data.Location = new System.Drawing.Point(19, 51);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(746, 337);
            this.Data.TabIndex = 0;
            this.Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellContentClick);
            this.Data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.update);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.texId);
            this.tabPage2.Controls.Add(this.Cancel);
            this.tabPage2.Controls.Add(this.Insertar);
            this.tabPage2.Controls.Add(this.Gender);
            this.tabPage2.Controls.Add(this.DateBirth);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.Name);
            this.tabPage2.Controls.Add(this.Nombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Acciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(212, 249);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // texId
            // 
            this.texId.Location = new System.Drawing.Point(442, 21);
            this.texId.Name = "texId";
            this.texId.Size = new System.Drawing.Size(100, 20);
            this.texId.TabIndex = 9;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(349, 249);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(212, 249);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(75, 23);
            this.Insertar.TabIndex = 6;
            this.Insertar.Text = "Insertar ";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(214, 152);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Género";
            this.Gender.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateBirth
            // 
            this.DateBirth.AutoSize = true;
            this.DateBirth.Location = new System.Drawing.Point(209, 112);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.Size = new System.Drawing.Size(108, 13);
            this.DateBirth.TabIndex = 4;
            this.DateBirth.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(209, 66);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(47, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "Nombre ";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AcceptsReturn = true;
            this.Nombre.Location = new System.Drawing.Point(351, 59);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(172, 20);
            this.Nombre.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBoxSeleccionar
            // 
            this.checkBoxSeleccionar.AutoSize = true;
            this.checkBoxSeleccionar.Location = new System.Drawing.Point(13, 440);
            this.checkBoxSeleccionar.Name = "checkBoxSeleccionar";
            this.checkBoxSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.checkBoxSeleccionar.TabIndex = 12;
            this.checkBoxSeleccionar.Text = "Seleccionar";
            this.checkBoxSeleccionar.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionar.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionar_CheckedChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(111, 436);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // datau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.checkBoxSeleccionar);
            this.Controls.Add(this.tabControl1);
            this.Name.Name = "datau";
            this.Text = "datau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label DateBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.TextBox texId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxSeleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}

