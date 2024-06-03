namespace WindowsFormsApp1
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.grpAddCoffee = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboCoffeeSize = new System.Windows.Forms.ComboBox();
            this.lblCoffeeSize = new System.Windows.Forms.Label();
            this.comboCoffeeType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddOrderTitle = new System.Windows.Forms.TextBox();
            this.btnCloseAddForm = new System.Windows.Forms.Button();
            this.grpAddCoffee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddCoffee
            // 
            this.grpAddCoffee.AutoSize = true;
            this.grpAddCoffee.BackColor = System.Drawing.Color.Tan;
            this.grpAddCoffee.Controls.Add(this.btnCloseAddForm);
            this.grpAddCoffee.Controls.Add(this.btnSubmit);
            this.grpAddCoffee.Controls.Add(this.comboCoffeeSize);
            this.grpAddCoffee.Controls.Add(this.lblCoffeeSize);
            this.grpAddCoffee.Controls.Add(this.comboCoffeeType);
            this.grpAddCoffee.Controls.Add(this.label1);
            this.grpAddCoffee.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddCoffee.Location = new System.Drawing.Point(78, 132);
            this.grpAddCoffee.Name = "grpAddCoffee";
            this.grpAddCoffee.Size = new System.Drawing.Size(780, 268);
            this.grpAddCoffee.TabIndex = 0;
            this.grpAddCoffee.TabStop = false;
            this.grpAddCoffee.Text = "Coffee Order Details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(267, 185);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboCoffeeSize
            // 
            this.comboCoffeeSize.BackColor = System.Drawing.Color.SaddleBrown;
            this.comboCoffeeSize.FormattingEnabled = true;
            this.comboCoffeeSize.Location = new System.Drawing.Point(588, 85);
            this.comboCoffeeSize.Name = "comboCoffeeSize";
            this.comboCoffeeSize.Size = new System.Drawing.Size(121, 29);
            this.comboCoffeeSize.TabIndex = 3;
            // 
            // lblCoffeeSize
            // 
            this.lblCoffeeSize.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblCoffeeSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCoffeeSize.Location = new System.Drawing.Point(432, 85);
            this.lblCoffeeSize.Name = "lblCoffeeSize";
            this.lblCoffeeSize.Size = new System.Drawing.Size(121, 29);
            this.lblCoffeeSize.TabIndex = 2;
            this.lblCoffeeSize.Text = "Coffee Size";
            this.lblCoffeeSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboCoffeeType
            // 
            this.comboCoffeeType.BackColor = System.Drawing.Color.SaddleBrown;
            this.comboCoffeeType.FormattingEnabled = true;
            this.comboCoffeeType.Location = new System.Drawing.Point(221, 85);
            this.comboCoffeeType.Name = "comboCoffeeType";
            this.comboCoffeeType.Size = new System.Drawing.Size(121, 29);
            this.comboCoffeeType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(78, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddOrderTitle
            // 
            this.txtAddOrderTitle.BackColor = System.Drawing.Color.Tan;
            this.txtAddOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddOrderTitle.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddOrderTitle.ForeColor = System.Drawing.Color.Black;
            this.txtAddOrderTitle.Location = new System.Drawing.Point(201, 12);
            this.txtAddOrderTitle.Name = "txtAddOrderTitle";
            this.txtAddOrderTitle.Size = new System.Drawing.Size(543, 44);
            this.txtAddOrderTitle.TabIndex = 2;
            this.txtAddOrderTitle.Text = "Add Coffee Order";
            this.txtAddOrderTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCloseAddForm
            // 
            this.btnCloseAddForm.AutoSize = true;
            this.btnCloseAddForm.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCloseAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddForm.Location = new System.Drawing.Point(436, 185);
            this.btnCloseAddForm.Name = "btnCloseAddForm";
            this.btnCloseAddForm.Size = new System.Drawing.Size(78, 33);
            this.btnCloseAddForm.TabIndex = 5;
            this.btnCloseAddForm.Text = "Close";
            this.btnCloseAddForm.UseVisualStyleBackColor = false;
            this.btnCloseAddForm.Click += new System.EventHandler(this.btnCloseAddForm_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 484);
            this.Controls.Add(this.txtAddOrderTitle);
            this.Controls.Add(this.grpAddCoffee);
            this.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddForm";
            this.Text = "Add Page";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.grpAddCoffee.ResumeLayout(false);
            this.grpAddCoffee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddCoffee;
        private System.Windows.Forms.TextBox txtAddOrderTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCoffeeType;
        private System.Windows.Forms.ComboBox comboCoffeeSize;
        private System.Windows.Forms.Label lblCoffeeSize;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCloseAddForm;
    }
}