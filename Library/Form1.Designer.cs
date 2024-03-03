namespace Library
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
            labelName = new Label();
            labelAuthor = new Label();
            labelN_copies = new Label();
            labelCost = new Label();
            label5 = new Label();
            lbltitle = new Label();
            lblAuthor = new Label();
            lblCopies = new Label();
            lblTotal = new Label();
            btnBuy = new Button();
            txtName = new TextBox();
            txtAuthor = new TextBox();
            txtCopies = new TextBox();
            txtCost = new TextBox();
            label10 = new Label();
            lblCost = new Label();
            button1 = new Button();
            txtTOTAL = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(55, 91);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 16);
            labelName.TabIndex = 0;
            labelName.Text = "Title:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.BackColor = Color.Transparent;
            labelAuthor.Font = new Font("PMingLiU-ExtB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAuthor.ForeColor = SystemColors.ActiveCaptionText;
            labelAuthor.Location = new Point(55, 121);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(51, 15);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Author:";
            // 
            // labelN_copies
            // 
            labelN_copies.AutoSize = true;
            labelN_copies.BackColor = Color.Transparent;
            labelN_copies.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelN_copies.ForeColor = SystemColors.ActiveCaptionText;
            labelN_copies.Location = new Point(55, 160);
            labelN_copies.Name = "labelN_copies";
            labelN_copies.Size = new Size(123, 16);
            labelN_copies.TabIndex = 2;
            labelN_copies.Text = "Number of copies:";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.BackColor = Color.Transparent;
            labelCost.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCost.ForeColor = SystemColors.ActiveCaptionText;
            labelCost.Location = new Point(55, 194);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(39, 16);
            labelCost.TabIndex = 3;
            labelCost.Text = "Cost:";
            labelCost.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 157);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(444, 91);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(0, 15);
            lbltitle.TabIndex = 5;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(444, 129);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 15);
            lblAuthor.TabIndex = 6;
            // 
            // lblCopies
            // 
            lblCopies.AutoSize = true;
            lblCopies.Location = new Point(444, 166);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(0, 15);
            lblCopies.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(444, 253);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 8;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(175, 271);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(66, 32);
            btnBuy.TabIndex = 9;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 23);
            txtName.TabIndex = 10;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(151, 118);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(197, 23);
            txtAuthor.TabIndex = 11;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(184, 157);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(164, 23);
            txtCopies.TabIndex = 12;
            txtCopies.TextChanged += txtCopies_TextChanged;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(151, 187);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(197, 23);
            txtCost.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Perpetua Titling MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(142, 32);
            label10.Name = "label10";
            label10.Size = new Size(144, 32);
            label10.TabIndex = 14;
            label10.Text = "LIBRARY";
            label10.Click += label10_Click;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(444, 202);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(0, 15);
            lblCost.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 271);
            button1.Name = "button1";
            button1.Size = new Size(72, 32);
            button1.TabIndex = 16;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnExit_Click;
            // 
            // txtTOTAL
            // 
            txtTOTAL.Location = new Point(151, 218);
            txtTOTAL.Name = "txtTOTAL";
            txtTOTAL.Size = new Size(197, 23);
            txtTOTAL.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(55, 225);
            label1.Name = "label1";
            label1.Size = new Size(72, 16);
            label1.TabIndex = 18;
            label1.Text = "Total cost:";
            // 
            // button2
            // 
            button2.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(278, 271);
            button2.Name = "button2";
            button2.Size = new Size(70, 32);
            button2.TabIndex = 19;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(433, 330);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txtTOTAL);
            Controls.Add(button1);
            Controls.Add(lblCost);
            Controls.Add(label10);
            Controls.Add(txtCost);
            Controls.Add(txtCopies);
            Controls.Add(txtAuthor);
            Controls.Add(txtName);
            Controls.Add(btnBuy);
            Controls.Add(lblTotal);
            Controls.Add(lblCopies);
            Controls.Add(lblAuthor);
            Controls.Add(lbltitle);
            Controls.Add(label5);
            Controls.Add(labelCost);
            Controls.Add(labelN_copies);
            Controls.Add(labelAuthor);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelAuthor;
        private Label labelN_copies;
        private Label labelCost;
        private Label label5;
        private Label lbltitle;
        private Label lblAuthor;
        private Label lblCopies;
        private Label lblTotal;
        private Button btnBuy;
        private TextBox txtName;
        private TextBox txtAuthor;
        private TextBox txtCopies;
        private TextBox txtCost;
        private Label label10;
        private Label lblCost;
        private Button button1;
        private TextBox txtTOTAL;
        private Label label1;
        private Button button2;
    }
}
