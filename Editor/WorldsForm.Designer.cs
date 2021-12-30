namespace TextWorld.Editor
{
    partial class WorldsForm
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
            this.listOfWorlds = new System.Windows.Forms.ListBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(26, 28);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(86, 30);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // listOfWorlds
            // 
            this.listOfWorlds.FormattingEnabled = true;
            this.listOfWorlds.Location = new System.Drawing.Point(26, 76);
            this.listOfWorlds.Margin = new System.Windows.Forms.Padding(2);
            this.listOfWorlds.Name = "listOfWorlds";
            this.listOfWorlds.Size = new System.Drawing.Size(528, 147);
            this.listOfWorlds.TabIndex = 1;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(26, 248);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(116, 53);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Создать";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(162, 248);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(116, 53);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(302, 248);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(116, 53);
            this.btn_Del.TabIndex = 4;
            this.btn_Del.Text = "Удалить";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(438, 248);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(116, 53);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Обновить";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // WorldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 324);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.listOfWorlds);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WorldsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор мира";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldsForm_FormClosed);
            this.Load += new System.EventHandler(this.WorldsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ListBox listOfWorlds;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Refresh;
    }
}