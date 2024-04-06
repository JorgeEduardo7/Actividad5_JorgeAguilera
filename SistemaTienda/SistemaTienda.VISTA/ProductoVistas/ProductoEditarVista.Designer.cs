namespace SistemaTienda.VISTA.ProductoVistas
{
    partial class ProductoEditarVista
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
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(157, 13, 20);
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Virtue", 9F);
            button2.ForeColor = Color.FromArgb(234, 160, 54);
            button2.Location = new Point(244, 153);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 75;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 13, 20);
            button1.DialogResult = DialogResult.OK;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Virtue", 9F);
            button1.ForeColor = Color.FromArgb(234, 160, 54);
            button1.Location = new Point(94, 153);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 74;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(157, 13, 20);
            label6.Font = new Font("Provicali", 30.25F);
            label6.ForeColor = Color.FromArgb(234, 160, 54);
            label6.Location = new Point(169, 9);
            label6.Name = "label6";
            label6.Size = new Size(152, 46);
            label6.TabIndex = 72;
            label6.Text = "EDITAR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 9F);
            label2.ForeColor = Color.FromArgb(157, 13, 20);
            label2.Location = new Point(67, 118);
            label2.Name = "label2";
            label2.Size = new Size(71, 14);
            label2.TabIndex = 69;
            label2.Text = "PRECIO/U";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(157, 13, 20);
            label1.Location = new Point(59, 85);
            label1.Name = "label1";
            label1.Size = new Size(79, 14);
            label1.TabIndex = 68;
            label1.Text = "PRODUCTO";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(157, 13, 20);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(488, 68);
            label5.TabIndex = 73;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 76;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.caroo;
            pictureBox1.Location = new Point(415, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 94;
            pictureBox1.TabStop = false;
            // 
            // ProductoEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 160, 54);
            ClientSize = new Size(488, 203);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "ProductoEditarVista";
            Text = "ProductoEditarVista";
            Load += ProductoEditarVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}