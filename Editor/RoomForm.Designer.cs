namespace TextWorld.Editor
{
    partial class RoomForm
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
            this.lb_Door = new System.Windows.Forms.Label();
            this.cb_DoorsList = new System.Windows.Forms.ComboBox();
            this.lb_Object = new System.Windows.Forms.Label();
            this.cb_ObjectsList = new System.Windows.Forms.ComboBox();
            this.btn_Add_Door = new System.Windows.Forms.Button();
            this.lb_Description = new System.Windows.Forms.Label();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Del_Door = new System.Windows.Forms.Button();
            this.btn_Del_Object = new System.Windows.Forms.Button();
            this.btn_Add_Object = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Door
            // 
            this.lb_Door.AutoSize = true;
            this.lb_Door.Location = new System.Drawing.Point(9, 25);
            this.lb_Door.Name = "lb_Door";
            this.lb_Door.Size = new System.Drawing.Size(40, 13);
            this.lb_Door.TabIndex = 31;
            this.lb_Door.Text = "Дверь";
            // 
            // cb_DoorsList
            // 
            this.cb_DoorsList.FormattingEnabled = true;
            this.cb_DoorsList.Location = new System.Drawing.Point(12, 52);
            this.cb_DoorsList.Name = "cb_DoorsList";
            this.cb_DoorsList.Size = new System.Drawing.Size(125, 21);
            this.cb_DoorsList.TabIndex = 32;
            this.cb_DoorsList.SelectedIndexChanged += new System.EventHandler(this.cb_DoorsList_SelectedIndexChanged);
            // 
            // lb_Object
            // 
            this.lb_Object.AutoSize = true;
            this.lb_Object.Location = new System.Drawing.Point(9, 126);
            this.lb_Object.Name = "lb_Object";
            this.lb_Object.Size = new System.Drawing.Size(45, 13);
            this.lb_Object.TabIndex = 33;
            this.lb_Object.Text = "Объект";
            // 
            // cb_ObjectsList
            // 
            this.cb_ObjectsList.FormattingEnabled = true;
            this.cb_ObjectsList.Location = new System.Drawing.Point(12, 151);
            this.cb_ObjectsList.Name = "cb_ObjectsList";
            this.cb_ObjectsList.Size = new System.Drawing.Size(125, 21);
            this.cb_ObjectsList.TabIndex = 34;
            this.cb_ObjectsList.SelectedIndexChanged += new System.EventHandler(this.cb_ObjectsList_SelectedIndexChanged);
            // 
            // btn_Add_Door
            // 
            this.btn_Add_Door.Location = new System.Drawing.Point(12, 79);
            this.btn_Add_Door.Name = "btn_Add_Door";
            this.btn_Add_Door.Size = new System.Drawing.Size(59, 35);
            this.btn_Add_Door.TabIndex = 35;
            this.btn_Add_Door.Text = "Add";
            this.btn_Add_Door.UseVisualStyleBackColor = true;
            this.btn_Add_Door.Click += new System.EventHandler(this.btn_Add_Door_Click);
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Location = new System.Drawing.Point(162, 25);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(57, 13);
            this.lb_Description.TabIndex = 37;
            this.lb_Description.Text = "Описание";
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(165, 52);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(251, 96);
            this.rtb_Description.TabIndex = 38;
            this.rtb_Description.Text = "";
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(165, 152);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(251, 61);
            this.btn_Save.TabIndex = 39;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Del_Door
            // 
            this.btn_Del_Door.Location = new System.Drawing.Point(79, 79);
            this.btn_Del_Door.Name = "btn_Del_Door";
            this.btn_Del_Door.Size = new System.Drawing.Size(58, 35);
            this.btn_Del_Door.TabIndex = 41;
            this.btn_Del_Door.Text = "Del";
            this.btn_Del_Door.UseVisualStyleBackColor = true;
            this.btn_Del_Door.Click += new System.EventHandler(this.btn_Del_Door_Click);
            // 
            // btn_Del_Object
            // 
            this.btn_Del_Object.Location = new System.Drawing.Point(79, 178);
            this.btn_Del_Object.Name = "btn_Del_Object";
            this.btn_Del_Object.Size = new System.Drawing.Size(58, 35);
            this.btn_Del_Object.TabIndex = 44;
            this.btn_Del_Object.Text = "Del";
            this.btn_Del_Object.UseVisualStyleBackColor = true;
            this.btn_Del_Object.Click += new System.EventHandler(this.btn_Del_Object_Click);
            // 
            // btn_Add_Object
            // 
            this.btn_Add_Object.Location = new System.Drawing.Point(12, 178);
            this.btn_Add_Object.Name = "btn_Add_Object";
            this.btn_Add_Object.Size = new System.Drawing.Size(58, 35);
            this.btn_Add_Object.TabIndex = 42;
            this.btn_Add_Object.Text = "Add";
            this.btn_Add_Object.UseVisualStyleBackColor = true;
            this.btn_Add_Object.Click += new System.EventHandler(this.btn_Add_Object_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 239);
            this.Controls.Add(this.btn_Del_Object);
            this.Controls.Add(this.btn_Add_Object);
            this.Controls.Add(this.btn_Del_Door);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.btn_Add_Door);
            this.Controls.Add(this.cb_ObjectsList);
            this.Controls.Add(this.lb_Object);
            this.Controls.Add(this.cb_DoorsList);
            this.Controls.Add(this.lb_Door);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор комнаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Door;
        private System.Windows.Forms.ComboBox cb_DoorsList;
        private System.Windows.Forms.Label lb_Object;
        private System.Windows.Forms.ComboBox cb_ObjectsList;
        private System.Windows.Forms.Button btn_Add_Door;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Del_Door;
        private System.Windows.Forms.Button btn_Del_Object;
        private System.Windows.Forms.Button btn_Add_Object;
    }
}