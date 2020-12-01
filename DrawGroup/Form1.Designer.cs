namespace DrawGroup
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
            this.displayA = new System.Windows.Forms.DataGridView();
            this.displayB = new System.Windows.Forms.DataGridView();
            this.displayC = new System.Windows.Forms.DataGridView();
            this.displayD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayD)).BeginInit();
            this.SuspendLayout();
            // 
            // displayA
            // 
            this.displayA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayA.Location = new System.Drawing.Point(34, 27);
            this.displayA.Name = "displayA";
            this.displayA.RowTemplate.Height = 24;
            this.displayA.Size = new System.Drawing.Size(254, 179);
            this.displayA.TabIndex = 0;
            // 
            // displayB
            // 
            this.displayB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayB.Location = new System.Drawing.Point(335, 27);
            this.displayB.Name = "displayB";
            this.displayB.RowTemplate.Height = 24;
            this.displayB.Size = new System.Drawing.Size(251, 179);
            this.displayB.TabIndex = 1;
            // 
            // displayC
            // 
            this.displayC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayC.Location = new System.Drawing.Point(34, 227);
            this.displayC.Name = "displayC";
            this.displayC.RowTemplate.Height = 24;
            this.displayC.Size = new System.Drawing.Size(254, 179);
            this.displayC.TabIndex = 2;
            // 
            // displayD
            // 
            this.displayD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayD.Location = new System.Drawing.Point(335, 227);
            this.displayD.Name = "displayD";
            this.displayD.RowTemplate.Height = 24;
            this.displayD.Size = new System.Drawing.Size(254, 179);
            this.displayD.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 432);
            this.Controls.Add(this.displayD);
            this.Controls.Add(this.displayC);
            this.Controls.Add(this.displayB);
            this.Controls.Add(this.displayA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.displayA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView displayA;
        private System.Windows.Forms.DataGridView displayB;
        private System.Windows.Forms.DataGridView displayC;
        private System.Windows.Forms.DataGridView displayD;
    }
}

