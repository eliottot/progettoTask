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
            this.lblBorder = new System.Windows.Forms.Label();
            this.lblInfoPriority = new System.Windows.Forms.Label();
            this.selectorPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(70, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(13, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(70, 72);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(122, 29);
            this.txtTime.TabIndex = 3;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(229, 24);
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
            this.selector.Location = new System.Drawing.Point(23, 272);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(188, 28);
            this.selector.TabIndex = 9;
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
            this.label1.Location = new System.Drawing.Point(25, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleziona la politica\r\nche vuoi utilizzare";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(13, 125);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(56, 20);
            this.lblPriority.TabIndex = 13;
            this.lblPriority.Text = "Priority";
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.Transparent;
            this.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBorder.Location = new System.Drawing.Point(12, 9);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(320, 159);
            this.lblBorder.TabIndex = 15;
            // 
            // lblInfoPriority
            // 
            this.lblInfoPriority.AutoSize = true;
            this.lblInfoPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPriority.Location = new System.Drawing.Point(198, 112);
            this.lblInfoPriority.Name = "lblInfoPriority";
            this.lblInfoPriority.Size = new System.Drawing.Size(127, 39);
            this.lblInfoPriority.TabIndex = 16;
            this.lblInfoPriority.Text = "Imposta la priorità\r\nsolo se stai utilizzando\r\nuna politica Round Robin";
            // 
            // selectorPriority
            // 
            this.selectorPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectorPriority.FormattingEnabled = true;
            this.selectorPriority.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Bassa"});
            this.selectorPriority.Location = new System.Drawing.Point(70, 119);
            this.selectorPriority.Name = "selectorPriority";
            this.selectorPriority.Size = new System.Drawing.Size(121, 32);
            this.selectorPriority.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(791, 627);
            this.Controls.Add(this.selectorPriority);
            this.Controls.Add(this.lblInfoPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBorder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Label lblInfoPriority;
        private System.Windows.Forms.ComboBox selectorPriority;
    }
}

