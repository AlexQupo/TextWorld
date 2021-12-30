namespace TextWorld.Editor
{
    partial class MazeInfoForm
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.nUD_Size = new System.Windows.Forms.NumericUpDown();
            this.lb_Size = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(45, 38);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(129, 20);
            this.tb_Name.TabIndex = 0;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(5, 41);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(29, 13);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Имя";
            // 
            // bt_Insert
            // 
            this.bt_Insert.Location = new System.Drawing.Point(43, 114);
            this.bt_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(128, 51);
            this.bt_Insert.TabIndex = 2;
            this.bt_Insert.Text = "Подтвердить";
            this.bt_Insert.UseVisualStyleBackColor = true;
            this.bt_Insert.Click += new System.EventHandler(this.bt_Insert_Click);
            // 
            // nUD_Size
            // 
            this.nUD_Size.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nUD_Size.Location = new System.Drawing.Point(97, 74);
            this.nUD_Size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Size.Name = "nUD_Size";
            this.nUD_Size.Size = new System.Drawing.Size(61, 20);
            this.nUD_Size.TabIndex = 3;
            this.nUD_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_Size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_Size
            // 
            this.lb_Size.AutoSize = true;
            this.lb_Size.Location = new System.Drawing.Point(53, 76);
            this.lb_Size.Name = "lb_Size";
            this.lb_Size.Size = new System.Drawing.Size(46, 13);
            this.lb_Size.TabIndex = 5;
            this.lb_Size.Text = "Размер";
            // 
            // MazeInfoForm
            // 
            this.AcceptButton = this.bt_Insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 180);
            this.Controls.Add(this.lb_Size);
            this.Controls.Add(this.nUD_Size);
            this.Controls.Add(this.bt_Insert);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.tb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MazeInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите данные";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.NumericUpDown nUD_Size;
        private System.Windows.Forms.Label lb_Size;
    }
}