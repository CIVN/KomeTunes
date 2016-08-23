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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.変更を適用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ウェブで検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Eq = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Composer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Bit_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Sample_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Date_Added = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Played_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Name,
            this._Time,
            this._Eq,
            this._Artist,
            this._Composer,
            this._Album,
            this._Size,
            this._Bit_Rate,
            this._Sample_Rate,
            this._Date_Added,
            this._Kind,
            this._Genre,
            this._Rating,
            this._Played_Count,
            this._Comment});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 24);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(1264, 657);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
			this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
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
			// ウェブで検索ToolStripMenuItem
			// 
			this.ウェブで検索ToolStripMenuItem.Name = "ウェブで検索ToolStripMenuItem";
			this.ウェブで検索ToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.ウェブで検索ToolStripMenuItem.Text = "ウェブで検索";
			this.ウェブで検索ToolStripMenuItem.Click += new System.EventHandler(this.ウェブで検索ToolStripMenuItem_Click);
			// 
			// _Name
			// 
			this._Name.HeaderText = "名前";
			this._Name.Name = "_Name";
			// 
			// _Time
			// 
			this._Time.HeaderText = "時間";
			this._Time.Name = "_Time";
			this._Time.ReadOnly = true;
			// 
			// _Eq
			// 
			this._Eq.HeaderText = "イコライザ";
			this._Eq.Name = "_Eq";
			// 
			// _Artist
			// 
			this._Artist.HeaderText = "アーティスト";
			this._Artist.Name = "_Artist";
			// 
			// _Composer
			// 
			this._Composer.HeaderText = "作曲者";
			this._Composer.Name = "_Composer";
			// 
			// _Album
			// 
			this._Album.HeaderText = "アルバム";
			this._Album.Name = "_Album";
			// 
			// _Size
			// 
			this._Size.HeaderText = "サイズ";
			this._Size.Name = "_Size";
			this._Size.ReadOnly = true;
			// 
			// _Bit_Rate
			// 
			this._Bit_Rate.HeaderText = "ビットレート";
			this._Bit_Rate.Name = "_Bit_Rate";
			this._Bit_Rate.ReadOnly = true;
			// 
			// _Sample_Rate
			// 
			this._Sample_Rate.HeaderText = "サンプルレート";
			this._Sample_Rate.Name = "_Sample_Rate";
			this._Sample_Rate.ReadOnly = true;
			// 
			// _Date_Added
			// 
			this._Date_Added.HeaderText = "追加日";
			this._Date_Added.Name = "_Date_Added";
			this._Date_Added.ReadOnly = true;
			// 
			// _Kind
			// 
			this._Kind.HeaderText = "種類";
			this._Kind.Name = "_Kind";
			this._Kind.ReadOnly = true;
			// 
			// _Genre
			// 
			this._Genre.HeaderText = "ジャンル";
			this._Genre.Name = "_Genre";
			// 
			// _Rating
			// 
			this._Rating.HeaderText = "レート";
			this._Rating.Name = "_Rating";
			// 
			// _Played_Count
			// 
			this._Played_Count.HeaderText = "再生回数";
			this._Played_Count.Name = "_Played_Count";
			// 
			// _Comment
			// 
			this._Comment.HeaderText = "コメント";
			this._Comment.Name = "_Comment";
			// 
			// Form1
			// 
			this.AccessibleName = "KomeTunes";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(640, 360);
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
		private System.Windows.Forms.ToolStripMenuItem ウェブで検索ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Time;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Eq;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Artist;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Composer;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Album;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Size;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Bit_Rate;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Sample_Rate;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Date_Added;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Kind;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Genre;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Rating;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Played_Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Comment;
	}
}

