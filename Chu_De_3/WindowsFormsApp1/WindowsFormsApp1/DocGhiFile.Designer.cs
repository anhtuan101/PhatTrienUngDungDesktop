namespace WindowsFormsApp1
{
    partial class DocGhiFile
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
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnTXT = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJSON
            // 
            this.btnJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSON.Location = new System.Drawing.Point(45, 37);
            this.btnJSON.Margin = new System.Windows.Forms.Padding(4);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(213, 59);
            this.btnJSON.TabIndex = 0;
            this.btnJSON.Text = "JSon";
            this.btnJSON.UseVisualStyleBackColor = true;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnTXT
            // 
            this.btnTXT.Location = new System.Drawing.Point(327, 37);
            this.btnTXT.Margin = new System.Windows.Forms.Padding(4);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(213, 59);
            this.btnTXT.TabIndex = 0;
            this.btnTXT.Text = "TXT";
            this.btnTXT.UseVisualStyleBackColor = true;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(599, 37);
            this.btnXML.Margin = new System.Windows.Forms.Padding(4);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(213, 59);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // DocGhiFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 175);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.btnJSON);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocGhiFile";
            this.Text = "DocGhiFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.Button btnXML;
    }
}