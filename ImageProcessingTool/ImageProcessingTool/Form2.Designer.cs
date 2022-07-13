
namespace ImageProcessingTool
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.penColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returBtn = new System.Windows.Forms.Button();
            this.mousePosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.penWidth = new System.Windows.Forms.NumericUpDown();
            this.undoBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(15, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 659);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // penColor
            // 
            this.penColor.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.penColor.FormattingEnabled = true;
            this.penColor.Location = new System.Drawing.Point(85, 5);
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(121, 27);
            this.penColor.TabIndex = 4;
            this.penColor.Text = "Black";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pen Color";
            // 
            // returBtn
            // 
            this.returBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.returBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.returBtn.Location = new System.Drawing.Point(662, 5);
            this.returBtn.Name = "returBtn";
            this.returBtn.Size = new System.Drawing.Size(113, 32);
            this.returBtn.TabIndex = 6;
            this.returBtn.Text = "Return";
            this.returBtn.UseVisualStyleBackColor = true;
            // 
            // mousePosition
            // 
            this.mousePosition.AutoSize = true;
            this.mousePosition.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mousePosition.Location = new System.Drawing.Point(412, 9);
            this.mousePosition.Name = "mousePosition";
            this.mousePosition.Size = new System.Drawing.Size(98, 19);
            this.mousePosition.TabIndex = 7;
            this.mousePosition.Text = "（??，??）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pen Width";
            // 
            // penWidth
            // 
            this.penWidth.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.penWidth.Location = new System.Drawing.Point(307, 5);
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(50, 27);
            this.penWidth.TabIndex = 9;
            this.penWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // undoBtn
            // 
            this.undoBtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.undoBtn.Location = new System.Drawing.Point(543, 5);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(113, 32);
            this.undoBtn.TabIndex = 10;
            this.undoBtn.Text = "Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 714);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.penWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mousePosition);
            this.Controls.Add(this.returBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.penColor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox penColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returBtn;
        private System.Windows.Forms.Label mousePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown penWidth;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Label label3;
    }
}