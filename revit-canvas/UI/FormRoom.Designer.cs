
namespace Econfaire.Monada.UI
{
    partial class FormRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numLengthX = new System.Windows.Forms.NumericUpDown();
            this.numLengthY = new System.Windows.Forms.NumericUpDown();
            this.numLocationX = new System.Windows.Forms.NumericUpDown();
            this.numLocationY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLengthX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLengthY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLocationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLocationY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "LengthX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LengthY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LocationX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LocationY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(74, 330);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRoom.TabIndex = 9;
            this.btnCreateRoom.Text = "Adauga";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 286);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // numLengthX
            // 
            this.numLengthX.Location = new System.Drawing.Point(33, 77);
            this.numLengthX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLengthX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLengthX.Name = "numLengthX";
            this.numLengthX.Size = new System.Drawing.Size(120, 20);
            this.numLengthX.TabIndex = 11;
            this.numLengthX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLengthY
            // 
            this.numLengthY.Location = new System.Drawing.Point(33, 143);
            this.numLengthY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLengthY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLengthY.Name = "numLengthY";
            this.numLengthY.Size = new System.Drawing.Size(120, 20);
            this.numLengthY.TabIndex = 12;
            this.numLengthY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLocationX
            // 
            this.numLocationX.Location = new System.Drawing.Point(33, 189);
            this.numLocationX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLocationX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLocationX.Name = "numLocationX";
            this.numLocationX.Size = new System.Drawing.Size(120, 20);
            this.numLocationX.TabIndex = 13;
            this.numLocationX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLocationY
            // 
            this.numLocationY.Location = new System.Drawing.Point(33, 233);
            this.numLocationY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLocationY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLocationY.Name = "numLocationY";
            this.numLocationY.Size = new System.Drawing.Size(120, 20);
            this.numLocationY.TabIndex = 14;
            this.numLocationY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 450);
            this.Controls.Add(this.numLocationY);
            this.Controls.Add(this.numLocationX);
            this.Controls.Add(this.numLengthY);
            this.Controls.Add(this.numLengthX);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creare incapere";
            ((System.ComponentModel.ISupportInitialize)(this.numLengthX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLengthY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLocationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLocationY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numLengthX;
        private System.Windows.Forms.NumericUpDown numLengthY;
        private System.Windows.Forms.NumericUpDown numLocationX;
        private System.Windows.Forms.NumericUpDown numLocationY;
    }
}