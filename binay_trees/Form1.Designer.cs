namespace binay_trees
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
            btn_Creator = new Button();
            txtbx_array = new TextBox();
            cbOrder = new ComboBox();
            btnContains = new Button();
            btndelete = new Button();
            btnInsert = new Button();
            btnView = new Button();
            pbTree = new PictureBox();
            btnDrop = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtboxOrder = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Creator
            // 
            btn_Creator.Location = new Point(597, 61);
            btn_Creator.Name = "btn_Creator";
            btn_Creator.Size = new Size(113, 27);
            btn_Creator.TabIndex = 0;
            btn_Creator.Text = "Create Tree";
            btn_Creator.UseVisualStyleBackColor = true;
            btn_Creator.Click += btn_Creator_Click;
            // 
            // txtbx_array
            // 
            txtbx_array.Location = new Point(535, 32);
            txtbx_array.Name = "txtbx_array";
            txtbx_array.Size = new Size(263, 23);
            txtbx_array.TabIndex = 1;
            // 
            // cbOrder
            // 
            cbOrder.FormattingEnabled = true;
            cbOrder.Items.AddRange(new object[] { "In Order ", "Pre Order ", "Post Order" });
            cbOrder.Location = new Point(804, 32);
            cbOrder.Name = "cbOrder";
            cbOrder.Size = new Size(123, 23);
            cbOrder.TabIndex = 4;
            cbOrder.TabStop = false;
            cbOrder.Text = "Select Order";
            cbOrder.SelectedIndexChanged += cbOrder_SelectedIndexChanged;
            // 
            // btnContains
            // 
            btnContains.Location = new Point(716, 61);
            btnContains.Name = "btnContains";
            btnContains.Size = new Size(105, 27);
            btnContains.TabIndex = 5;
            btnContains.Text = "Search";
            btnContains.UseVisualStyleBackColor = true;
            btnContains.Click += btnContains_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(827, 61);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(77, 27);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(492, 61);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(99, 27);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert number";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(910, 61);
            btnView.Name = "btnView";
            btnView.Size = new Size(108, 27);
            btnView.TabIndex = 8;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // pbTree
            // 
            pbTree.Anchor = AnchorStyles.None;
            pbTree.Location = new Point(329, 114);
            pbTree.Name = "pbTree";
            pbTree.Size = new Size(1102, 607);
            pbTree.TabIndex = 11;
            pbTree.TabStop = false;
            // 
            // btnDrop
            // 
            btnDrop.Location = new Point(409, 61);
            btnDrop.Name = "btnDrop";
            btnDrop.Size = new Size(77, 27);
            btnDrop.TabIndex = 12;
            btnDrop.Text = "Drop Tree";
            btnDrop.UseVisualStyleBackColor = true;
            btnDrop.Click += btnDrop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(116, 142);
            label1.Name = "label1";
            label1.Size = new Size(14, 14);
            label1.TabIndex = 13;
            label1.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.toppng_com_circle_1000x1000;
            pictureBox1.Location = new Point(87, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // txtboxOrder
            // 
            txtboxOrder.Location = new Point(67, 189);
            txtboxOrder.Multiline = true;
            txtboxOrder.Name = "txtboxOrder";
            txtboxOrder.Size = new Size(110, 77);
            txtboxOrder.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 656);
            Controls.Add(txtboxOrder);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnDrop);
            Controls.Add(pbTree);
            Controls.Add(btnView);
            Controls.Add(btnInsert);
            Controls.Add(btndelete);
            Controls.Add(btnContains);
            Controls.Add(cbOrder);
            Controls.Add(txtbx_array);
            Controls.Add(btn_Creator);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Creator;
        private TextBox txtbx_array;
        private ComboBox cbOrder;
        private Button btnContains;
        private Button btndelete;
        private Button btnInsert;
        private Button btnView;
        private PictureBox pbTree;
        private Button btnDrop;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtboxOrder;
    }
}
