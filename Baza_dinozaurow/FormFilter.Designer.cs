namespace Baza_dinozaurow
{
    partial class FormFilter
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
            this.groupBoxEpoch = new System.Windows.Forms.GroupBox();
            this.radioKenozoik = new System.Windows.Forms.RadioButton();
            this.radioKreda = new System.Windows.Forms.RadioButton();
            this.radioJura = new System.Windows.Forms.RadioButton();
            this.radioTrias = new System.Windows.Forms.RadioButton();
            this.buttonFilterAnimals = new System.Windows.Forms.Button();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.groupBoxEpoch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEpoch
            // 
            this.groupBoxEpoch.Controls.Add(this.radioKenozoik);
            this.groupBoxEpoch.Controls.Add(this.radioKreda);
            this.groupBoxEpoch.Controls.Add(this.radioJura);
            this.groupBoxEpoch.Controls.Add(this.radioTrias);
            this.groupBoxEpoch.Location = new System.Drawing.Point(70, 31);
            this.groupBoxEpoch.Name = "groupBoxEpoch";
            this.groupBoxEpoch.Size = new System.Drawing.Size(356, 231);
            this.groupBoxEpoch.TabIndex = 0;
            this.groupBoxEpoch.TabStop = false;
            this.groupBoxEpoch.Text = "Wybor epoki ";
            this.groupBoxEpoch.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioKenozoik
            // 
            this.radioKenozoik.AutoSize = true;
            this.radioKenozoik.Location = new System.Drawing.Point(17, 181);
            this.radioKenozoik.Name = "radioKenozoik";
            this.radioKenozoik.Size = new System.Drawing.Size(99, 24);
            this.radioKenozoik.TabIndex = 3;
            this.radioKenozoik.TabStop = true;
            this.radioKenozoik.Text = "Kenozoik";
            this.radioKenozoik.UseVisualStyleBackColor = true;
            // 
            // radioKreda
            // 
            this.radioKreda.AutoSize = true;
            this.radioKreda.Location = new System.Drawing.Point(17, 138);
            this.radioKreda.Name = "radioKreda";
            this.radioKreda.Size = new System.Drawing.Size(76, 24);
            this.radioKreda.TabIndex = 2;
            this.radioKreda.TabStop = true;
            this.radioKreda.Text = "Kreda";
            this.radioKreda.UseVisualStyleBackColor = true;
            this.radioKreda.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioJura
            // 
            this.radioJura.AutoSize = true;
            this.radioJura.Location = new System.Drawing.Point(17, 97);
            this.radioJura.Name = "radioJura";
            this.radioJura.Size = new System.Drawing.Size(65, 24);
            this.radioJura.TabIndex = 1;
            this.radioJura.TabStop = true;
            this.radioJura.Text = "Jura";
            this.radioJura.UseVisualStyleBackColor = true;
            // 
            // radioTrias
            // 
            this.radioTrias.AutoSize = true;
            this.radioTrias.Location = new System.Drawing.Point(17, 49);
            this.radioTrias.Name = "radioTrias";
            this.radioTrias.Size = new System.Drawing.Size(68, 24);
            this.radioTrias.TabIndex = 0;
            this.radioTrias.TabStop = true;
            this.radioTrias.Text = "Trias";
            this.radioTrias.UseVisualStyleBackColor = true;
            // 
            // buttonFilterAnimals
            // 
            this.buttonFilterAnimals.Location = new System.Drawing.Point(87, 280);
            this.buttonFilterAnimals.Name = "buttonFilterAnimals";
            this.buttonFilterAnimals.Size = new System.Drawing.Size(176, 50);
            this.buttonFilterAnimals.TabIndex = 1;
            this.buttonFilterAnimals.Text = "Filtruj ";
            this.buttonFilterAnimals.UseVisualStyleBackColor = true;
            this.buttonFilterAnimals.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 20;
            this.listBoxAnimals.Location = new System.Drawing.Point(536, 41);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(206, 224);
            this.listBoxAnimals.TabIndex = 2;
            this.listBoxAnimals.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimals_SelectedIndexChanged);
            // 
            // labelDetails
            // 
            this.labelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDetails.Location = new System.Drawing.Point(536, 294);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(206, 50);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "Szczegoly ";
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.buttonFilterAnimals);
            this.Controls.Add(this.groupBoxEpoch);
            this.Name = "FormFilter";
            this.Text = "FormFilter";
            this.Load += new System.EventHandler(this.FormFilter_Load);
            this.groupBoxEpoch.ResumeLayout(false);
            this.groupBoxEpoch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEpoch;
        private System.Windows.Forms.RadioButton radioKenozoik;
        private System.Windows.Forms.RadioButton radioKreda;
        private System.Windows.Forms.RadioButton radioJura;
        private System.Windows.Forms.RadioButton radioTrias;
        private System.Windows.Forms.Button buttonFilterAnimals;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Label labelDetails;
    }
}