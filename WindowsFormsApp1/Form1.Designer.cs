namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.selectorPriority = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTimeSlice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimeMax = new System.Windows.Forms.TextBox();
            this.lblTimeSlice = new System.Windows.Forms.Label();
            this.lblTimeMax = new System.Windows.Forms.Label();
            this.btnMetriche = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(72, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(72, 52);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(122, 29);
            this.txtTime.TabIndex = 3;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(206, 23);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(92, 32);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnEsegui
            // 
            this.btnEsegui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEsegui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsegui.Location = new System.Drawing.Point(652, 249);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(110, 51);
            this.btnEsegui.TabIndex = 5;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = false;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.IndianRed;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(506, 30);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(256, 121);
            this.lblError.TabIndex = 8;
            this.lblError.Visible = false;
            // 
            // selector
            // 
            this.selector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selector.FormattingEnabled = true;
            this.selector.Items.AddRange(new object[] {
            "First Come First Served",
            "Shortest Job First",
            "Round Robin",
            "Round Robin Limitato"});
            this.selector.Location = new System.Drawing.Point(23, 173);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(188, 28);
            this.selector.TabIndex = 9;
            this.selector.SelectedIndexChanged += new System.EventHandler(this.selector_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(23, 323);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(739, 292);
            this.listBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleziona la politica\r\nche vuoi utilizzare";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(29, 215);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(56, 20);
            this.lblPriority.TabIndex = 13;
            this.lblPriority.Text = "Priority";
            this.lblPriority.Visible = false;
            // 
            // selectorPriority
            // 
            this.selectorPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectorPriority.FormattingEnabled = true;
            this.selectorPriority.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Bassa"});
            this.selectorPriority.Location = new System.Drawing.Point(90, 209);
            this.selectorPriority.Name = "selectorPriority";
            this.selectorPriority.Size = new System.Drawing.Size(121, 32);
            this.selectorPriority.TabIndex = 17;
            this.selectorPriority.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(536, 249);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 51);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTimeSlice
            // 
            this.txtTimeSlice.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeSlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeSlice.Location = new System.Drawing.Point(229, 173);
            this.txtTimeSlice.Name = "txtTimeSlice";
            this.txtTimeSlice.Size = new System.Drawing.Size(103, 29);
            this.txtTimeSlice.TabIndex = 19;
            this.txtTimeSlice.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 99);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati Processi";
            // 
            // txtTimeMax
            // 
            this.txtTimeMax.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeMax.Location = new System.Drawing.Point(348, 173);
            this.txtTimeMax.Name = "txtTimeMax";
            this.txtTimeMax.Size = new System.Drawing.Size(103, 29);
            this.txtTimeMax.TabIndex = 21;
            this.txtTimeMax.Visible = false;
            // 
            // lblTimeSlice
            // 
            this.lblTimeSlice.AutoSize = true;
            this.lblTimeSlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSlice.Location = new System.Drawing.Point(237, 138);
            this.lblTimeSlice.Name = "lblTimeSlice";
            this.lblTimeSlice.Size = new System.Drawing.Size(92, 32);
            this.lblTimeSlice.TabIndex = 22;
            this.lblTimeSlice.Text = "Inserisci il\r\ntime slice (ms)";
            this.lblTimeSlice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeSlice.Visible = false;
            // 
            // lblTimeMax
            // 
            this.lblTimeMax.AutoSize = true;
            this.lblTimeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMax.Location = new System.Drawing.Point(356, 138);
            this.lblTimeMax.Name = "lblTimeMax";
            this.lblTimeMax.Size = new System.Drawing.Size(89, 32);
            this.lblTimeMax.TabIndex = 23;
            this.lblTimeMax.Text = "Inserisci il\r\ntime max (ms)";
            this.lblTimeMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeMax.Visible = false;
            // 
            // btnMetriche
            // 
            this.btnMetriche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMetriche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetriche.Location = new System.Drawing.Point(23, 249);
            this.btnMetriche.Name = "btnMetriche";
            this.btnMetriche.Size = new System.Drawing.Size(151, 51);
            this.btnMetriche.TabIndex = 24;
            this.btnMetriche.Text = "Visualizza metriche";
            this.btnMetriche.UseVisualStyleBackColor = false;
            this.btnMetriche.Visible = false;
            this.btnMetriche.Click += new System.EventHandler(this.btnMetriche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(791, 627);
            this.Controls.Add(this.btnMetriche);
            this.Controls.Add(this.lblTimeMax);
            this.Controls.Add(this.lblTimeSlice);
            this.Controls.Add(this.txtTimeMax);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimeSlice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.selectorPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnEsegui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox selector;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox selectorPriority;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTimeSlice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimeMax;
        private System.Windows.Forms.Label lblTimeSlice;
        private System.Windows.Forms.Label lblTimeMax;
        private System.Windows.Forms.Button btnMetriche;
    }
}

