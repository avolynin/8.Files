
namespace final.project
{
	partial class LogControl
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._txtLog = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _txtLog
			// 
			this._txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtLog.Location = new System.Drawing.Point(4, 4);
			this._txtLog.Name = "_txtLog";
			this._txtLog.Size = new System.Drawing.Size(768, 148);
			this._txtLog.TabIndex = 0;
			this._txtLog.Text = "";
			// 
			// LogControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._txtLog);
			this.Name = "LogControl";
			this.Size = new System.Drawing.Size(775, 155);
			this.Load += new System.EventHandler(this.LogControl_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox _txtLog;
	}
}
