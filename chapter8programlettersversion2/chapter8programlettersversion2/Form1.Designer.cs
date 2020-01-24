namespace chapter8programlettersversion2
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
            this.txtInput = new System.Windows.Forms.ListView();
            this.lblText = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.HideSelection = false;
            this.txtInput.Location = new System.Drawing.Point(12, 62);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(297, 173);
            this.txtInput.TabIndex = 0;
            this.txtInput.UseCompatibleStateImageBehavior = false;
            this.txtInput.SelectedIndexChanged += new System.EventHandler(this.txtInput_SelectedIndexChanged);
            // 
            // lblText
            // 
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblText.Location = new System.Drawing.Point(12, 27);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(297, 23);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Enter text:";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 242);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(233, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Letter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(209, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstOutput
            // 
            this.lstOutput.HideSelection = false;
            this.lstOutput.Location = new System.Drawing.Point(13, 344);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(296, 179);
            this.lstOutput.TabIndex = 6;
            this.lstOutput.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 535);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "ColumnHeader Collection Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView txtInput;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstOutput;
    }
}

