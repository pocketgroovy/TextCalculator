namespace YoshiMiyamoto
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
            this.import = new System.Windows.Forms.Button();
            this.fileContents = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(109, 21);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 0;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // fileContents
            // 
            this.fileContents.AutoSize = true;
            this.fileContents.Location = new System.Drawing.Point(82, 85);
            this.fileContents.Name = "fileContents";
            this.fileContents.Size = new System.Drawing.Size(0, 13);
            this.fileContents.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input from a file shown below";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(100, 154);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(99, 23);
            this.process.TabIndex = 3;
            this.process.Text = "Calculate&&Store";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(79, 208);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 405);
            this.Controls.Add(this.result);
            this.Controls.Add(this.process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileContents);
            this.Controls.Add(this.import);
            this.Name = "Form1";
            this.Text = "ThermoFisher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Label fileContents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label result;
    }
}

