namespace TextWorld.Editor
{
    partial class ObjectForm
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
            this.lb_Object = new System.Windows.Forms.Label();
            this.cb_Object = new System.Windows.Forms.ComboBox();
            this.cb_Color = new System.Windows.Forms.ComboBox();
            this.lb_Color = new System.Windows.Forms.Label();
            this.lb_KColor = new System.Windows.Forms.Label();
            this.cb_KColor = new System.Windows.Forms.ComboBox();
            this.chb_IsHaveKey = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Object
            // 
            this.lb_Object.AutoSize = true;
            this.lb_Object.Location = new System.Drawing.Point(11, 37);
            this.lb_Object.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Object.Name = "lb_Object";
            this.lb_Object.Size = new System.Drawing.Size(45, 13);
            this.lb_Object.TabIndex = 0;
            this.lb_Object.Text = "Объект";
            // 
            // cb_Object
            // 
            this.cb_Object.FormattingEnabled = true;
            this.cb_Object.Location = new System.Drawing.Point(94, 34);
            this.cb_Object.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Object.Name = "cb_Object";
            this.cb_Object.Size = new System.Drawing.Size(129, 21);
            this.cb_Object.TabIndex = 1;
            // 
            // cb_Color
            // 
            this.cb_Color.FormattingEnabled = true;
            this.cb_Color.Location = new System.Drawing.Point(94, 66);
            this.cb_Color.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Color.Name = "cb_Color";
            this.cb_Color.Size = new System.Drawing.Size(129, 21);
            this.cb_Color.TabIndex = 2;
            // 
            // lb_Color
            // 
            this.lb_Color.AutoSize = true;
            this.lb_Color.Location = new System.Drawing.Point(11, 69);
            this.lb_Color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Color.Name = "lb_Color";
            this.lb_Color.Size = new System.Drawing.Size(32, 13);
            this.lb_Color.TabIndex = 3;
            this.lb_Color.Text = "Цвет";
            // 
            // lb_KColor
            // 
            this.lb_KColor.AutoSize = true;
            this.lb_KColor.Location = new System.Drawing.Point(11, 130);
            this.lb_KColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_KColor.Name = "lb_KColor";
            this.lb_KColor.Size = new System.Drawing.Size(66, 13);
            this.lb_KColor.TabIndex = 4;
            this.lb_KColor.Text = "Цвет ключа";
            // 
            // cb_KColor
            // 
            this.cb_KColor.FormattingEnabled = true;
            this.cb_KColor.Location = new System.Drawing.Point(94, 127);
            this.cb_KColor.Margin = new System.Windows.Forms.Padding(2);
            this.cb_KColor.Name = "cb_KColor";
            this.cb_KColor.Size = new System.Drawing.Size(129, 21);
            this.cb_KColor.TabIndex = 5;
            // 
            // chb_IsHaveKey
            // 
            this.chb_IsHaveKey.AutoSize = true;
            this.chb_IsHaveKey.Location = new System.Drawing.Point(14, 101);
            this.chb_IsHaveKey.Name = "chb_IsHaveKey";
            this.chb_IsHaveKey.Size = new System.Drawing.Size(52, 17);
            this.chb_IsHaveKey.TabIndex = 7;
            this.chb_IsHaveKey.Text = "Ключ";
            this.chb_IsHaveKey.UseVisualStyleBackColor = true;
            this.chb_IsHaveKey.CheckedChanged += new System.EventHandler(this.chb_IsHaveKey_CheckedChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(0, 179);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(234, 82);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.chb_IsHaveKey);
            this.Controls.Add(this.cb_KColor);
            this.Controls.Add(this.lb_KColor);
            this.Controls.Add(this.lb_Color);
            this.Controls.Add(this.cb_Color);
            this.Controls.Add(this.cb_Object);
            this.Controls.Add(this.lb_Object);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Установка объекта";
            this.Load += new System.EventHandler(this.ObjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Object;
        private System.Windows.Forms.ComboBox cb_Object;
        private System.Windows.Forms.ComboBox cb_Color;
        private System.Windows.Forms.Label lb_Color;
        private System.Windows.Forms.Label lb_KColor;
        private System.Windows.Forms.ComboBox cb_KColor;
        private System.Windows.Forms.CheckBox chb_IsHaveKey;
        private System.Windows.Forms.Button btn_Save;
    }
}