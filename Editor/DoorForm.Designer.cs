namespace TextWorld.Editor
{
    partial class DoorForm
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_Position = new System.Windows.Forms.ComboBox();
            this.cb_Relation = new System.Windows.Forms.ComboBox();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_Relation = new System.Windows.Forms.Label();
            this.lb_Color = new System.Windows.Forms.Label();
            this.cb_Color = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(0, 179);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(234, 82);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_Position
            // 
            this.cb_Position.FormattingEnabled = true;
            this.cb_Position.Location = new System.Drawing.Point(94, 36);
            this.cb_Position.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Position.Name = "cb_Position";
            this.cb_Position.Size = new System.Drawing.Size(129, 21);
            this.cb_Position.TabIndex = 20;
            // 
            // cb_Relation
            // 
            this.cb_Relation.FormattingEnabled = true;
            this.cb_Relation.Location = new System.Drawing.Point(94, 109);
            this.cb_Relation.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Relation.Name = "cb_Relation";
            this.cb_Relation.Size = new System.Drawing.Size(129, 21);
            this.cb_Relation.TabIndex = 25;
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Location = new System.Drawing.Point(11, 44);
            this.lb_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(51, 13);
            this.lb_Position.TabIndex = 21;
            this.lb_Position.Text = "Позиция";
            // 
            // lb_Relation
            // 
            this.lb_Relation.AutoSize = true;
            this.lb_Relation.Location = new System.Drawing.Point(11, 117);
            this.lb_Relation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Relation.Name = "lb_Relation";
            this.lb_Relation.Size = new System.Drawing.Size(47, 13);
            this.lb_Relation.TabIndex = 24;
            this.lb_Relation.Text = "Связь с";
            // 
            // lb_Color
            // 
            this.lb_Color.AutoSize = true;
            this.lb_Color.Location = new System.Drawing.Point(11, 79);
            this.lb_Color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Color.Name = "lb_Color";
            this.lb_Color.Size = new System.Drawing.Size(32, 13);
            this.lb_Color.TabIndex = 22;
            this.lb_Color.Text = "Цвет";
            // 
            // cb_Color
            // 
            this.cb_Color.FormattingEnabled = true;
            this.cb_Color.Location = new System.Drawing.Point(94, 71);
            this.cb_Color.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Color.Name = "cb_Color";
            this.cb_Color.Size = new System.Drawing.Size(129, 21);
            this.cb_Color.TabIndex = 23;
            // 
            // DoorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.cb_Position);
            this.Controls.Add(this.cb_Relation);
            this.Controls.Add(this.lb_Position);
            this.Controls.Add(this.lb_Relation);
            this.Controls.Add(this.lb_Color);
            this.Controls.Add(this.cb_Color);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DoorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Установка двери";
            this.Load += new System.EventHandler(this.DoorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cb_Position;
        private System.Windows.Forms.ComboBox cb_Relation;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Label lb_Relation;
        private System.Windows.Forms.Label lb_Color;
        private System.Windows.Forms.ComboBox cb_Color;
    }
}