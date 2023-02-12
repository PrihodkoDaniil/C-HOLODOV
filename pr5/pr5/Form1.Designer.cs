namespace pr5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRaw = new System.Windows.Forms.DataGridView();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaw
            // 
            this.dgvRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaw.Location = new System.Drawing.Point(435, 215);
            this.dgvRaw.Name = "dgvRaw";
            this.dgvRaw.Size = new System.Drawing.Size(240, 150);
            this.dgvRaw.TabIndex = 0;
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(113, 122);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.Size = new System.Drawing.Size(240, 150);
            this.dgvSummary.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(435, 75);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Загрузить данные";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvSummary);
            this.Controls.Add(this.dgvRaw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaw;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}

