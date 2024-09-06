namespace NguyenVanTan_buoi1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblketqua1 = new ProgressBar();
            groupBox2 = new GroupBox();
            btnthoat = new Button();
            btnxoatrang = new Button();
            btngiai = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 33);
            label1.Name = "label1";
            label1.Size = new Size(288, 32);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình Bậc 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(181, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 116);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập a, b, c";
            // 
            // txtC
            // 
            txtC.Location = new Point(88, 79);
            txtC.Name = "txtC";
            txtC.Size = new Size(123, 23);
            txtC.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(88, 45);
            txtB.Name = "txtB";
            txtB.Size = new Size(123, 23);
            txtB.TabIndex = 4;
            // 
            // txtA
            // 
            txtA.Location = new Point(88, 15);
            txtA.Name = "txtA";
            txtA.Size = new Size(124, 23);
            txtA.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 82);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 2;
            label4.Text = "c :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 53);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 1;
            label3.Text = "b :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 23);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 0;
            label2.Text = "a :";
            // 
            // lblketqua1
            // 
            lblketqua1.Location = new Point(181, 249);
            lblketqua1.Name = "lblketqua1";
            lblketqua1.Size = new Size(341, 23);
            lblketqua1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnthoat);
            groupBox2.Controls.Add(btnxoatrang);
            groupBox2.Controls.Add(btngiai);
            groupBox2.Location = new Point(176, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 61);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn thao tác";
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(243, 22);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxoatrang
            // 
            btnxoatrang.Location = new Point(137, 22);
            btnxoatrang.Name = "btnxoatrang";
            btnxoatrang.Size = new Size(75, 23);
            btnxoatrang.TabIndex = 1;
            btnxoatrang.Text = "Xóa Trắng";
            btnxoatrang.UseVisualStyleBackColor = true;
            // 
            // btngiai
            // 
            btngiai.Location = new Point(25, 22);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(75, 23);
            btngiai.TabIndex = 0;
            btngiai.Text = "Giải";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(lblketqua1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtA;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtC;
        private TextBox txtB;
        private ProgressBar lblketqua1;
        private GroupBox groupBox2;
        private Button btnthoat;
        private Button btnxoatrang;
        private Button btngiai;
    }
}
