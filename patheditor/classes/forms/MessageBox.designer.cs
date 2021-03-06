namespace com.jds.PathEditor.classes.forms
{
	partial class MessageBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            this.picture = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.RichTextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture.Image = Resources.Error;
            this.picture.Location = new System.Drawing.Point(13, 13);
            this.picture.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(48, 48);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.text.Location = new System.Drawing.Point(77, 13);
            this.text.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(353, 241);
            this.text.TabIndex = 0;
            this.text.TabStop = false;
            this.text.Text = "";
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkBtn.Location = new System.Drawing.Point(360, 277);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            // 
            // MessageBox
            // 
            this.AcceptButton = this.OkBtn;
            this.ClientSize = new System.Drawing.Size(447, 312);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.text);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.MessageBox_Load);
            this.Shown += new System.EventHandler(this.MessageBox_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Button OkBtn;
	}
}