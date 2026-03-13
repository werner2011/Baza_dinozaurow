namespace Baza_dinozaurow
{
    partial class MainForm
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
            this.dataGridViewAnimals = new System.Windows.Forms.DataGridView();
            this.buttonOpenAdd = new System.Windows.Forms.Button();
            this.buttonOpenFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnimals
            // 
            this.dataGridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimals.Location = new System.Drawing.Point(73, 12);
            this.dataGridViewAnimals.Name = "dataGridViewAnimals";
            this.dataGridViewAnimals.RowHeadersWidth = 62;
            this.dataGridViewAnimals.RowTemplate.Height = 28;
            this.dataGridViewAnimals.Size = new System.Drawing.Size(519, 229);
            this.dataGridViewAnimals.TabIndex = 0;
            // 
            // buttonOpenAdd
            // 
            this.buttonOpenAdd.Location = new System.Drawing.Point(163, 315);
            this.buttonOpenAdd.Name = "buttonOpenAdd";
            this.buttonOpenAdd.Size = new System.Drawing.Size(114, 55);
            this.buttonOpenAdd.TabIndex = 1;
            this.buttonOpenAdd.Text = "Dodaj zwierze";
            this.buttonOpenAdd.UseVisualStyleBackColor = true;
            this.buttonOpenAdd.Click += new System.EventHandler(this.buttonOpenAdd_Click);
            // 
            // buttonOpenFilter
            // 
            this.buttonOpenFilter.Location = new System.Drawing.Point(444, 315);
            this.buttonOpenFilter.Name = "buttonOpenFilter";
            this.buttonOpenFilter.Size = new System.Drawing.Size(139, 55);
            this.buttonOpenFilter.TabIndex = 2;
            this.buttonOpenFilter.Text = "Filtruj/Szczegoly";
            this.buttonOpenFilter.UseVisualStyleBackColor = true;
            this.buttonOpenFilter.Click += new System.EventHandler(this.buttonOpenFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenFilter);
            this.Controls.Add(this.buttonOpenAdd);
            this.Controls.Add(this.dataGridViewAnimals);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnimals;
        private System.Windows.Forms.Button buttonOpenAdd;
        private System.Windows.Forms.Button buttonOpenFilter;
    }
}