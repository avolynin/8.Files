
namespace final.project
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlVideo = new System.Windows.Forms.Panel();
			this._pnlSettings = new System.Windows.Forms.Panel();
			this._pnlLog = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _pnlVideo
			// 
			this._pnlVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlVideo.Location = new System.Drawing.Point(13, 13);
			this._pnlVideo.Name = "_pnlVideo";
			this._pnlVideo.Size = new System.Drawing.Size(526, 263);
			this._pnlVideo.TabIndex = 0;
			// 
			// _pnlSettings
			// 
			this._pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlSettings.Location = new System.Drawing.Point(546, 13);
			this._pnlSettings.Name = "_pnlSettings";
			this._pnlSettings.Size = new System.Drawing.Size(242, 263);
			this._pnlSettings.TabIndex = 1;
			// 
			// _pnlLog
			// 
			this._pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlLog.Location = new System.Drawing.Point(13, 283);
			this._pnlLog.Name = "_pnlLog";
			this._pnlLog.Size = new System.Drawing.Size(775, 155);
			this._pnlLog.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this._pnlLog);
			this.Controls.Add(this._pnlSettings);
			this.Controls.Add(this._pnlVideo);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlVideo;
		private System.Windows.Forms.Panel _pnlSettings;
		private System.Windows.Forms.Panel _pnlLog;
	}
}

