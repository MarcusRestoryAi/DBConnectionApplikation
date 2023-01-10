namespace DBConnectionApplikation
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectOutput = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gridOutput = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(139, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 30);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(139, 86);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(287, 30);
            this.txtAge.TabIndex = 0;
            // 
            // txtPet
            // 
            this.txtPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPet.Location = new System.Drawing.Point(139, 135);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(287, 30);
            this.txtPet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pet name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelectOutput
            // 
            this.lblSelectOutput.AutoSize = true;
            this.lblSelectOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOutput.Location = new System.Drawing.Point(451, 40);
            this.lblSelectOutput.Name = "lblSelectOutput";
            this.lblSelectOutput.Size = new System.Drawing.Size(0, 25);
            this.lblSelectOutput.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 81);
            this.button2.TabIndex = 4;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridOutput
            // 
            this.gridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutput.Location = new System.Drawing.Point(37, 258);
            this.gridOutput.Name = "gridOutput";
            this.gridOutput.RowHeadersWidth = 51;
            this.gridOutput.RowTemplate.Height = 24;
            this.gridOutput.Size = new System.Drawing.Size(681, 272);
            this.gridOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 627);
            this.Controls.Add(this.gridOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSelectOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSelectOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gridOutput;
    }
}

