using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTunesLib;
using static KomeTunes.Enums;
using System.Diagnostics;

namespace KomeTunes
{
	public partial class Form1 : Form
	{
		private iTunesApp app;
		private ChangeList changeList;
		private int row;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Reflesh();
		}

		private void Reflesh()
		{
			dataGridView1.Rows.Clear();
			row = 0;

			app = new iTunesApp();
			changeList = new ChangeList();

			var tracks = app.LibraryPlaylist.Tracks.Cast<IITTrack>().OrderBy(n => n.Name).Cast<IITTrack>();

			foreach (var t in tracks)
			{
				dataGridView1.Rows.Add();

				for (int i = 0; i < 6; i++)
				{
					dataGridView1[i, row].Tag = t;
				}

				dataGridView1[0, row].Value = t.Name;
				dataGridView1[0, row].ToolTipText = "Time: " + t.Time + "\nSize: " + t.Size;
				dataGridView1[1, row].Value = t.Artist;
				dataGridView1[2, row].Value = t.Album;
				dataGridView1[3, row].Value = t.Genre;
				dataGridView1[4, row].Value = t.Rating / 20;
				dataGridView1[5, row].Value = t.PlayedCount;
				dataGridView1[6, row].Value = t.Comment;
				row++;
			}
		}

		private void 変更を適用ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var mb = MessageBox.Show("変更を適用します。よろしいですか？\n（iTunes）は再起動します。", "変更を適用", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (mb == DialogResult.OK)
			{
				changeList.Apply();
				app.Resume();
			}
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			//最初のエラー回避
			if (e.ColumnIndex < 0 || e.RowIndex < 0)
			{
				return;
			}

			var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
			var tag = (IITTrack)cell.Tag;

			if (e.ColumnIndex == 0)
			{
				changeList.Add(tag, DataKind.Name, cell.Value);
			}

			else if (e.ColumnIndex == 1)
			{
				changeList.Add(tag, DataKind.Artist, cell.Value);
			}

			else if (e.ColumnIndex == 2)
			{
				changeList.Add(tag, DataKind.Album, cell.Value);
			}

			else if (e.ColumnIndex == 3)
			{
				changeList.Add(tag, DataKind.Genre, cell.Value);
			}

			else if (e.ColumnIndex == 4)
			{
				int _out = 0;
				
				if (!int.TryParse(cell.Value.ToString(), out _out))
				{
					MessageBox.Show("数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (int.Parse(cell.Value.ToString()) > 5)
				{
					MessageBox.Show("値が大きすぎます。\n0~5の間で設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				changeList.Add(tag, DataKind.Rating, int.Parse(cell.Value.ToString()) * 20);
			}

			else if (e.ColumnIndex == 5)
			{
				int _out = 0;

				if (!int.TryParse(cell.Value.ToString(), out _out))
				{
					MessageBox.Show("数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				changeList.Add(tag, DataKind.PlayedCount, int.Parse(cell.Value.ToString()));
			}

			else if (e.ColumnIndex == 6)
			{
				changeList.Add(tag, DataKind.Comment, cell.Value);
			}
		}

		private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var mb = MessageBox.Show("変更は適用されませんが、更新してもよろしいですか？", "更新", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (mb == DialogResult.Yes)
			{
				Reflesh();
			}
		}

		private void ウェブで検索ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedCells[0].Value == null)
			{
				return;
			}

			var selected = dataGridView1.SelectedCells[0].Value.ToString();

			Process.Start("https://www.google.co.jp/#q=" + selected);
		}
	}
}
