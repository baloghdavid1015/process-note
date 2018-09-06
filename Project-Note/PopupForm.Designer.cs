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
            this.listViewpopup = new System.Windows.Forms.ListView();
            this.columnHeaderpopupname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderpopupRam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewpopup
            // 
            this.listViewpopup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderpopupname,
            this.columnHeaderpopupRam});
            this.listViewpopup.Location = new System.Drawing.Point(12, 12);
            this.listViewpopup.Name = "listViewpopup";
            this.listViewpopup.Size = new System.Drawing.Size(338, 420);
            this.listViewpopup.TabIndex = 0;
            this.listViewpopup.UseCompatibleStateImageBehavior = false;
            this.listViewpopup.View = System.Windows.Forms.View.Details;
            this.listViewpopup.SelectedIndexChanged += new System.EventHandler(this.listViewpopup_SelectedIndexChanged);
            // 
            // columnHeaderpopupname
            // 
            this.columnHeaderpopupname.Text = "Name";
            // 
            // columnHeaderpopupRam
            // 
            this.columnHeaderpopupRam.Text = "Ram usage(mb)";
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.listViewpopup);
            this.Name = "PopupForm";
            this.Text = "PopupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewpopup;
        private System.Windows.Forms.ColumnHeader columnHeaderpopupname;
        private System.Windows.Forms.ColumnHeader columnHeaderpopupRam;
    }
}