namespace KomeTunes
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.変更を適用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlayedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ウェブで検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Name,
            this.Artist,
            this.Album,
            this.Genre,
            this.Rating,
            this.PlayedCount,
            this.Comment});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 24);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(1264, 657);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新ToolStripMenuItem,
            this.変更を適用ToolStripMenuItem,
            this.ウェブで検索ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 更新ToolStripMenuItem
			// 
			this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
			this.更新ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.更新ToolStripMenuItem.Text = "更新";
			this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
			// 
			// 変更を適用ToolStripMenuItem
			// 
			this.変更を適用ToolStripMenuItem.Name = "変更を適用ToolStripMenuItem";
			this.変更を適用ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.変更を適用ToolStripMenuItem.Text = "変更を適用";
			this.変更を適用ToolStripMenuItem.Click += new System.EventHandler(this.変更を適用ToolStripMenuItem_Click);
			// 
			// _Name
			// 
			this._Name.HeaderText = "曲名";
			this._Name.Name = "_Name";
			this._Name.Width = 200;
			// 
			// Artist
			// 
			this.Artist.HeaderText = "アーティスト名";
			this.Artist.Name = "Artist";
			this.Artist.Width = 150;
			// 
			// Album
			// 
			this.Album.HeaderText = "アルバム";
			this.Album.Name = "Album";
			this.Album.Width = 150;
			// 
			// Genre
			// 
			this.Genre.HeaderText = "ジャンル";
			this.Genre.Name = "Genre";
			// 
			// Rating
			// 
			this.Rating.HeaderText = "レート";
			this.Rating.Name = "Rating";
			// 
			// PlayedCount
			// 
			this.PlayedCount.HeaderText = "再生回数";
			this.PlayedCount.Name = "PlayedCount";
			// 
			// Comment
			// 
			this.Comment.HeaderText = "コメント";
			this.Comment.Name = "Comment";
			this.Comment.Width = 200;
			// 
			// ウェブで検索ToolStripMenuItem
			// 
			this.ウェブで検索ToolStripMenuItem.Name = "ウェブで検索ToolStripMenuItem";
			this.ウェブで検索ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.ウェブで検索ToolStripMenuItem.Text = "ウェブで検索";
			this.ウェブで検索ToolStripMenuItem.Click += new System.EventHandler(this.ウェブで検索ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KomeTunes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 変更を適用ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
		private System.Windows.Forms.DataGridViewTextBoxColumn Album;
		private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlayedCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
		private System.Windows.Forms.ToolStripMenuItem ウェブで検索ToolStripMenuItem;
	}
}

