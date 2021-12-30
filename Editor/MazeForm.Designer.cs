namespace TextWorld.Editor
{
    partial class MazeForm
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.cb_roomsList = new System.Windows.Forms.ComboBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lb_description = new System.Windows.Forms.Label();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.lb_Relation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Objects = new System.Windows.Forms.Label();
            this.lb_roomsList = new System.Windows.Forms.Label();
            this.lb_typeRoom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Back.Location = new System.Drawing.Point(129, 325);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(86, 30);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Вернуться";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // cb_roomsList
            // 
            this.cb_roomsList.FormattingEnabled = true;
            this.cb_roomsList.Location = new System.Drawing.Point(100, 36);
            this.cb_roomsList.Name = "cb_roomsList";
            this.cb_roomsList.Size = new System.Drawing.Size(121, 21);
            this.cb_roomsList.TabIndex = 8;
            this.cb_roomsList.SelectedIndexChanged += new System.EventHandler(this.cb_roomsList_SelectedIndexChanged);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(257, 34);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 9;
            this.btn_Enter.Text = "Перейти";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Location = new System.Drawing.Point(3, 4);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(57, 13);
            this.lb_description.TabIndex = 10;
            this.lb_description.Text = "Описание";
            // 
            // rtb_description
            // 
            this.rtb_description.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_description.Location = new System.Drawing.Point(3, 20);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.ReadOnly = true;
            this.rtb_description.Size = new System.Drawing.Size(320, 96);
            this.rtb_description.TabIndex = 11;
            this.rtb_description.Text = "";
            // 
            // lb_Relation
            // 
            this.lb_Relation.AutoSize = true;
            this.lb_Relation.Location = new System.Drawing.Point(3, 135);
            this.lb_Relation.Name = "lb_Relation";
            this.lb_Relation.Size = new System.Drawing.Size(50, 13);
            this.lb_Relation.TabIndex = 12;
            this.lb_Relation.Text = "Связь с:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_Objects);
            this.panel1.Controls.Add(this.rtb_description);
            this.panel1.Controls.Add(this.lb_Relation);
            this.panel1.Controls.Add(this.lb_description);
            this.panel1.Location = new System.Drawing.Point(9, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 220);
            this.panel1.TabIndex = 13;
            // 
            // lb_Objects
            // 
            this.lb_Objects.AutoSize = true;
            this.lb_Objects.Location = new System.Drawing.Point(3, 178);
            this.lb_Objects.Name = "lb_Objects";
            this.lb_Objects.Size = new System.Drawing.Size(56, 13);
            this.lb_Objects.TabIndex = 13;
            this.lb_Objects.Text = "Объекты:";
            // 
            // lb_roomsList
            // 
            this.lb_roomsList.AutoSize = true;
            this.lb_roomsList.Location = new System.Drawing.Point(12, 39);
            this.lb_roomsList.Name = "lb_roomsList";
            this.lb_roomsList.Size = new System.Drawing.Size(69, 13);
            this.lb_roomsList.TabIndex = 14;
            this.lb_roomsList.Text = "ID комнаты:";
            // 
            // lb_typeRoom
            // 
            this.lb_typeRoom.AutoSize = true;
            this.lb_typeRoom.Location = new System.Drawing.Point(12, 69);
            this.lb_typeRoom.Name = "lb_typeRoom";
            this.lb_typeRoom.Size = new System.Drawing.Size(74, 13);
            this.lb_typeRoom.TabIndex = 15;
            this.lb_typeRoom.Text = "Тип комнаты";
            // 
            // MazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 366);
            this.Controls.Add(this.lb_typeRoom);
            this.Controls.Add(this.lb_roomsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.cb_roomsList);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MazeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обзор лабиринта";
            this.Load += new System.EventHandler(this.MazeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox cb_roomsList;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.Label lb_Relation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Objects;
        private System.Windows.Forms.Label lb_roomsList;
        private System.Windows.Forms.Label lb_typeRoom;
    }
}