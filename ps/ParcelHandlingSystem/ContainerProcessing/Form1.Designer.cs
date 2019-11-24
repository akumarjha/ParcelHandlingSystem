namespace ContainerProcessing
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
            this.ParcelSystem = new System.Windows.Forms.TabControl();
            this.Processor = new System.Windows.Forms.TabPage();
            this.ProcessContainer = new System.Windows.Forms.Button();
            this.Insurance = new System.Windows.Forms.TabPage();
            this.InsuranceGridView = new System.Windows.Forms.DataGridView();
            this.Mail = new System.Windows.Forms.TabPage();
            this.Regular = new System.Windows.Forms.TabPage();
            this.Heavy = new System.Windows.Forms.TabPage();
            this.MailGridView = new System.Windows.Forms.DataGridView();
            this.HeavyGridView = new System.Windows.Forms.DataGridView();
            this.RegularGridView = new System.Windows.Forms.DataGridView();
            this.SignedOff = new System.Windows.Forms.Button();
            this.ParcelSystem.SuspendLayout();
            this.Processor.SuspendLayout();
            this.Insurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceGridView)).BeginInit();
            this.Mail.SuspendLayout();
            this.Regular.SuspendLayout();
            this.Heavy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeavyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegularGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ParcelSystem
            // 
            this.ParcelSystem.Controls.Add(this.Processor);
            this.ParcelSystem.Controls.Add(this.Insurance);
            this.ParcelSystem.Controls.Add(this.Mail);
            this.ParcelSystem.Controls.Add(this.Regular);
            this.ParcelSystem.Controls.Add(this.Heavy);
            this.ParcelSystem.Location = new System.Drawing.Point(12, 21);
            this.ParcelSystem.Name = "ParcelSystem";
            this.ParcelSystem.SelectedIndex = 0;
            this.ParcelSystem.Size = new System.Drawing.Size(841, 461);
            this.ParcelSystem.TabIndex = 0;
            // 
            // Processor
            // 
            this.Processor.Controls.Add(this.ProcessContainer);
            this.Processor.Location = new System.Drawing.Point(4, 25);
            this.Processor.Name = "Processor";
            this.Processor.Padding = new System.Windows.Forms.Padding(3);
            this.Processor.Size = new System.Drawing.Size(833, 432);
            this.Processor.TabIndex = 0;
            this.Processor.Text = "Processor";
            this.Processor.UseVisualStyleBackColor = true;
            // 
            // ProcessContainer
            // 
            this.ProcessContainer.Location = new System.Drawing.Point(18, 95);
            this.ProcessContainer.Name = "ProcessContainer";
            this.ProcessContainer.Size = new System.Drawing.Size(139, 49);
            this.ProcessContainer.TabIndex = 0;
            this.ProcessContainer.Text = "ProcessContainer";
            this.ProcessContainer.UseVisualStyleBackColor = true;
            this.ProcessContainer.Click += new System.EventHandler(this.ProcessContainer_Click);
            // 
            // Insurance
            // 
            this.Insurance.Controls.Add(this.SignedOff);
            this.Insurance.Controls.Add(this.InsuranceGridView);
            this.Insurance.Location = new System.Drawing.Point(4, 25);
            this.Insurance.Name = "Insurance";
            this.Insurance.Padding = new System.Windows.Forms.Padding(3);
            this.Insurance.Size = new System.Drawing.Size(833, 432);
            this.Insurance.TabIndex = 1;
            this.Insurance.Text = "Insurance";
            this.Insurance.UseVisualStyleBackColor = true;
            // 
            // InsuranceGridView
            // 
            this.InsuranceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsuranceGridView.Location = new System.Drawing.Point(0, 6);
            this.InsuranceGridView.Name = "InsuranceGridView";
            this.InsuranceGridView.Size = new System.Drawing.Size(812, 136);
            this.InsuranceGridView.TabIndex = 0;
            this.InsuranceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsuranceGridView_CellContentClick);
            // 
            // Mail
            // 
            this.Mail.Controls.Add(this.MailGridView);
            this.Mail.Location = new System.Drawing.Point(4, 25);
            this.Mail.Name = "Mail";
            this.Mail.Padding = new System.Windows.Forms.Padding(3);
            this.Mail.Size = new System.Drawing.Size(833, 432);
            this.Mail.TabIndex = 2;
            this.Mail.Text = "Mail";
            this.Mail.UseVisualStyleBackColor = true;
            // 
            // Regular
            // 
            this.Regular.Controls.Add(this.RegularGridView);
            this.Regular.Location = new System.Drawing.Point(4, 25);
            this.Regular.Name = "Regular";
            this.Regular.Padding = new System.Windows.Forms.Padding(3);
            this.Regular.Size = new System.Drawing.Size(833, 432);
            this.Regular.TabIndex = 3;
            this.Regular.Text = "Regular";
            this.Regular.UseVisualStyleBackColor = true;
            // 
            // Heavy
            // 
            this.Heavy.Controls.Add(this.HeavyGridView);
            this.Heavy.Location = new System.Drawing.Point(4, 25);
            this.Heavy.Name = "Heavy";
            this.Heavy.Padding = new System.Windows.Forms.Padding(3);
            this.Heavy.Size = new System.Drawing.Size(833, 432);
            this.Heavy.TabIndex = 4;
            this.Heavy.Text = "Heavy";
            this.Heavy.UseVisualStyleBackColor = true;
            // 
            // MailGridView
            // 
            this.MailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MailGridView.Location = new System.Drawing.Point(10, 9);
            this.MailGridView.Name = "MailGridView";
            this.MailGridView.Size = new System.Drawing.Size(812, 136);
            this.MailGridView.TabIndex = 1;
            // 
            // HeavyGridView
            // 
            this.HeavyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeavyGridView.Location = new System.Drawing.Point(3, 7);
            this.HeavyGridView.Name = "HeavyGridView";
            this.HeavyGridView.RowTemplate.Height = 24;
            this.HeavyGridView.Size = new System.Drawing.Size(824, 150);
            this.HeavyGridView.TabIndex = 0;
            // 
            // RegularGridView
            // 
            this.RegularGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegularGridView.Location = new System.Drawing.Point(10, 12);
            this.RegularGridView.Name = "RegularGridView";
            this.RegularGridView.Size = new System.Drawing.Size(812, 136);
            this.RegularGridView.TabIndex = 1;
            // 
            // SignedOff
            // 
            this.SignedOff.Location = new System.Drawing.Point(220, 308);
            this.SignedOff.Name = "SignedOff";
            this.SignedOff.Size = new System.Drawing.Size(285, 29);
            this.SignedOff.TabIndex = 1;
            this.SignedOff.Text = "SignedOff";
            this.SignedOff.UseVisualStyleBackColor = true;
            this.SignedOff.Click += new System.EventHandler(this.SignedOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 660);
            this.Controls.Add(this.ParcelSystem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ParcelSystem.ResumeLayout(false);
            this.Processor.ResumeLayout(false);
            this.Insurance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceGridView)).EndInit();
            this.Mail.ResumeLayout(false);
            this.Regular.ResumeLayout(false);
            this.Heavy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeavyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegularGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ParcelSystem;
        private System.Windows.Forms.TabPage Processor;
        private System.Windows.Forms.TabPage Insurance;
        private System.Windows.Forms.TabPage Mail;
        private System.Windows.Forms.TabPage Regular;
        private System.Windows.Forms.Button ProcessContainer;
        private System.Windows.Forms.TabPage Heavy;
        private System.Windows.Forms.DataGridView InsuranceGridView;
        private System.Windows.Forms.DataGridView MailGridView;
        private System.Windows.Forms.DataGridView HeavyGridView;
        private System.Windows.Forms.DataGridView RegularGridView;
        private System.Windows.Forms.Button SignedOff;
    }
}

