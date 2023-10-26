namespace Assignment4._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.comboCupSize = new System.Windows.Forms.ComboBox();
            this.cbToGo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEsp = new System.Windows.Forms.Label();
            this.lblMilk = new System.Windows.Forms.Label();
            this.lblIced = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToGo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumEsp = new System.Windows.Forms.TextBox();
            this.comboMilk = new System.Windows.Forms.ComboBox();
            this.checkIce = new System.Windows.Forms.CheckBox();
            this.comboCoffeeType = new System.Windows.Forms.ComboBox();
            this.CustGrid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(228, 50);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(122, 41);
            this.txtCustName.TabIndex = 0;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            this.txtCustName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustName_Validating);
            // 
            // comboCupSize
            // 
            this.comboCupSize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCupSize.FormattingEnabled = true;
            this.comboCupSize.Location = new System.Drawing.Point(228, 123);
            this.comboCupSize.Name = "comboCupSize";
            this.comboCupSize.Size = new System.Drawing.Size(121, 41);
            this.comboCupSize.TabIndex = 1;
            this.comboCupSize.SelectedIndexChanged += new System.EventHandler(this.comboCupSize_SelectedIndexChanged);
            // 
            // cbToGo
            // 
            this.cbToGo.AutoSize = true;
            this.cbToGo.BackColor = System.Drawing.Color.Transparent;
            this.cbToGo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToGo.Location = new System.Drawing.Point(228, 97);
            this.cbToGo.Name = "cbToGo";
            this.cbToGo.Size = new System.Drawing.Size(15, 14);
            this.cbToGo.TabIndex = 2;
            this.cbToGo.UseVisualStyleBackColor = false;
            this.cbToGo.CheckedChanged += new System.EventHandler(this.cbToGo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblEsp);
            this.groupBox1.Controls.Add(this.lblMilk);
            this.groupBox1.Controls.Add(this.lblIced);
            this.groupBox1.Controls.Add(this.lblCoffee);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.lblToGo);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtNumEsp);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.comboMilk);
            this.groupBox1.Controls.Add(this.checkIce);
            this.groupBox1.Controls.Add(this.comboCoffeeType);
            this.groupBox1.Controls.Add(this.cbToGo);
            this.groupBox1.Controls.Add(this.comboCupSize);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.Location = new System.Drawing.Point(32, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 392);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblEsp
            // 
            this.lblEsp.AutoSize = true;
            this.lblEsp.BackColor = System.Drawing.Color.Transparent;
            this.lblEsp.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsp.Location = new System.Drawing.Point(61, 298);
            this.lblEsp.Name = "lblEsp";
            this.lblEsp.Size = new System.Drawing.Size(161, 33);
            this.lblEsp.TabIndex = 15;
            this.lblEsp.Text = "Espresso Shots:";
            this.lblEsp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.BackColor = System.Drawing.Color.Transparent;
            this.lblMilk.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilk.Location = new System.Drawing.Point(161, 251);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(61, 33);
            this.lblMilk.TabIndex = 14;
            this.lblMilk.Text = "Milk:";
            this.lblMilk.Click += new System.EventHandler(this.lblMilk_Click);
            // 
            // lblIced
            // 
            this.lblIced.AutoSize = true;
            this.lblIced.BackColor = System.Drawing.Color.Transparent;
            this.lblIced.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIced.Location = new System.Drawing.Point(158, 209);
            this.lblIced.Name = "lblIced";
            this.lblIced.Size = new System.Drawing.Size(64, 33);
            this.lblIced.TabIndex = 13;
            this.lblIced.Text = "Iced?";
            this.lblIced.Click += new System.EventHandler(this.lblIced_Click);
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.BackColor = System.Drawing.Color.Transparent;
            this.lblCoffee.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffee.Location = new System.Drawing.Point(89, 173);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(133, 33);
            this.lblCoffee.TabIndex = 12;
            this.lblCoffee.Text = "Coffee Type:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(163, 126);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(59, 33);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Size:";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblToGo
            // 
            this.lblToGo.AutoSize = true;
            this.lblToGo.BackColor = System.Drawing.Color.Transparent;
            this.lblToGo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToGo.Location = new System.Drawing.Point(139, 87);
            this.lblToGo.Name = "lblToGo";
            this.lblToGo.Size = new System.Drawing.Size(83, 33);
            this.lblToGo.TabIndex = 10;
            this.lblToGo.Text = "To Go?";
            this.lblToGo.Click += new System.EventHandler(this.lblToGo_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(93, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 33);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "First Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtNumEsp
            // 
            this.txtNumEsp.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumEsp.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEsp.Location = new System.Drawing.Point(228, 295);
            this.txtNumEsp.Name = "txtNumEsp";
            this.txtNumEsp.Size = new System.Drawing.Size(41, 41);
            this.txtNumEsp.TabIndex = 8;
            this.txtNumEsp.TextChanged += new System.EventHandler(this.txtNumEsp_TextChanged);
            this.txtNumEsp.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumEsp_Validating);
            // 
            // comboMilk
            // 
            this.comboMilk.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMilk.FormattingEnabled = true;
            this.comboMilk.Location = new System.Drawing.Point(229, 248);
            this.comboMilk.Name = "comboMilk";
            this.comboMilk.Size = new System.Drawing.Size(121, 41);
            this.comboMilk.TabIndex = 4;
            // 
            // checkIce
            // 
            this.checkIce.AutoSize = true;
            this.checkIce.BackColor = System.Drawing.Color.Transparent;
            this.checkIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIce.Location = new System.Drawing.Point(229, 220);
            this.checkIce.Name = "checkIce";
            this.checkIce.Size = new System.Drawing.Size(15, 14);
            this.checkIce.TabIndex = 5;
            this.checkIce.UseVisualStyleBackColor = false;
            this.checkIce.CheckedChanged += new System.EventHandler(this.checkIce_CheckedChanged);
            // 
            // comboCoffeeType
            // 
            this.comboCoffeeType.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCoffeeType.FormattingEnabled = true;
            this.comboCoffeeType.Location = new System.Drawing.Point(228, 170);
            this.comboCoffeeType.Name = "comboCoffeeType";
            this.comboCoffeeType.Size = new System.Drawing.Size(121, 41);
            this.comboCoffeeType.TabIndex = 3;
            this.comboCoffeeType.SelectedIndexChanged += new System.EventHandler(this.comboCoffeeType_SelectedIndexChanged);
            // 
            // CustGrid
            // 
            this.CustGrid.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.CustGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustGrid.Location = new System.Drawing.Point(360, 35);
            this.CustGrid.Name = "CustGrid";
            this.CustGrid.Size = new System.Drawing.Size(739, 184);
            this.CustGrid.TabIndex = 4;
            this.CustGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustGrid_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(544, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(544, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(749, 252);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(501, 334);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 635);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.CustGrid);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.ComboBox comboCupSize;
        private System.Windows.Forms.CheckBox cbToGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCoffeeType;
        private System.Windows.Forms.DataGridView CustGrid;
        private System.Windows.Forms.ComboBox comboMilk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkIce;
        private System.Windows.Forms.TextBox txtNumEsp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblToGo;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblIced;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label lblEsp;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

