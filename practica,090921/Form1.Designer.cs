
namespace practica_090921
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetName = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.listName = new System.Windows.Forms.ListBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(71, 68);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(75, 23);
            this.btnGetName.TabIndex = 0;
            this.btnGetName.Text = "GetName()";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(71, 324);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "GetData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // listName
            // 
            this.listName.FormattingEnabled = true;
            this.listName.ItemHeight = 15;
            this.listName.Location = new System.Drawing.Point(225, 68);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(120, 94);
            this.listName.TabIndex = 2;
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(225, 239);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 25;
            this.dgData.Size = new System.Drawing.Size(516, 159);
            this.dgData.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnGetName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ListBox listName;
        private System.Windows.Forms.DataGridView dgData;
    }
}

