namespace Project_Note
{
    partial class PopupForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeaderpopupname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderpopupRam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewpopup = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeaderpopupname
            // 
            this.columnHeaderpopupname.Text = "Name";
            this.columnHeaderpopupname.Width = 200;
            // 
            // columnHeaderpopupRam
            // 
            this.columnHeaderpopupRam.Text = "Ram usage(mb)";
            this.columnHeaderpopupRam.Width = 100;
            // 
            // listViewpopup
            // 
            this.listViewpopup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderpopupname,
            this.columnHeaderpopupRam});
            this.listViewpopup.FullRowSelect = true;
            this.listViewpopup.GridLines = true;
            this.listViewpopup.Location = new System.Drawing.Point(12, 32);
            this.listViewpopup.Name = "listViewpopup";
            this.listViewpopup.Size = new System.Drawing.Size(338, 364);
            this.listViewpopup.TabIndex = 0;
            this.listViewpopup.UseCompatibleStateImageBehavior = false;
            this.listViewpopup.View = System.Windows.Forms.View.Details;
            this.listViewpopup.SelectedIndexChanged += new System.EventHandler(this.listViewpopup_SelectedIndexChanged);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewpopup);
            this.Name = "PopupForm";
            this.Text = "PopupForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeaderpopupname;
        private System.Windows.Forms.ColumnHeader columnHeaderpopupRam;
        private System.Windows.Forms.ListView listViewpopup;
    }
}