using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTunesLib;
using System.Diagnostics;
using System.Collections.Generic;
using static KomeTunes.Enums;

namespace KomeTunes
{
	public partial class Form1 : Form
	{
		#region #region Global Functions
		private iTunesApp app;
		private ChangeList changeList;
		private int row;
		#endregion

		#region #region URLs
		private const string GOOGLE_URL = "https://www.google.co.jp/#q=";
		private const string ITUNES_URL = "http://www.apple.com/jp/itunes/download/";
		#endregion

		#region #region Index
		private const int NAME = 0;
		private const int TIME = 1;
		private const int EQ = 2;
		private const int ARTIST = 3;
		private const int COMPOSER = 4;
		private const int ALBUM = 5;
		private const int SIZE = 6;
		private const int BIT_RATE = 7;
		private const int SAMPLE_RATE = 8;
		private const int DATE_ADDED = 9;
		private const int KIND = 10;
		private const int GENRE = 11;
		private const int RATING = 12;
		private const int PLAYED_COUNT = 13;
		private const int COMMENT = 14;
		# endregion

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Reflesh();
		}

		private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			var item = e.ClickedItem.Text;

			try
			{
				dataGridView1.CurrentCell.Value = item;
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n原因: " + ex.Source + "\nヘルプ: " + ex.HelpLink, "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				return;
			}
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex < 0 || e.RowIndex < 0)
			{
				return;
			}

			var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
			var tag = (IITTrack)cell.Tag;

			switch (e.ColumnIndex)
			{
				case NAME:
					changeList.Add(tag, DataKind.Name, cell.Value);
					break;

				case EQ:
					changeList.Add(tag, DataKind.EQ, cell.Value);
					break;

				case ARTIST:
					changeList.Add(tag, DataKind.Artist, cell.Value);
					break;

				case COMPOSER:
					changeList.Add(tag, DataKind.Composer, cell.Value);
					break;

				case ALBUM:
					changeList.Add(tag, DataKind.Album, cell.Value);
					break;

				case GENRE:
					changeList.Add(tag, DataKind.Genre, cell.Value);
					break;

				case RATING:
					if (CheckInt(cell, DataKind.Rating))
					{
						changeList.Add(tag, DataKind.Rating, int.Parse(cell.Value.ToString()) * 20);
					}
					break;

				case PLAYED_COUNT:
					if (CheckInt(cell, DataKind.PlayedCount))
					{
						changeList.Add(tag, DataKind.PlayedCount, int.Parse(cell.Value.ToString()));
					}
					break;

				case COMMENT:
					changeList.Add(tag, DataKind.Comment, cell.Value);
					break;
			}
		}

		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (!(e.ColumnIndex < 0 || e.RowIndex < 0))
			{
				try
				{
					dataGridView1[e.ColumnIndex, e.RowIndex].Selected = true;
					dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
				}

				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + "\n原因: " + ex.Source + "\nヘルプ: " + ex.HelpLink, "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
					return;
				}

				if (e.ColumnIndex == EQ)
				{
					if (e.Button == MouseButtons.Right && !(e.Clicks > 1))
					{
						var location = dataGridView1.PointToClient(Cursor.Position);

						try
						{
							contextMenuStrip1.Show(dataGridView1, location);
						}

						catch (Exception ex)
						{
							MessageBox.Show(ex.Message + "\n原因: " + ex.Source + "\nヘルプ: " + ex.HelpLink, "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
							return;
						}
					}
				}
			}
		}

		private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				var cell = dataGridView1[e.ColumnIndex, e.RowIndex];

				if (cell.ColumnIndex == NAME)
				{
					var track = (IITTrack)cell.Tag;

					if (app.CurrentTrack.trackID == track.trackID)
					{
						if (app.PlayerState == ITPlayerState.ITPlayerStatePlaying)
						{
							app.Pause();
						}

						else
						{
							app.Play();
						}
					}

					else
					{
						track.Play();
					}
				}

				else
				{
					if (cell.Value != null)
					{
						var value = cell.Value.ToString();

						Process.Start(GOOGLE_URL + value);
					}
				}
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

		private void 変更を適用ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var mb = MessageBox.Show("変更を適用します。よろしいですか？", "変更を適用", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (mb == DialogResult.OK)
			{
				changeList.Apply();
				app.Resume();
			}
		}

		private void ウェブで検索ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedCells[0].Value == null)
			{
				return;
			}

			var selected = dataGridView1.SelectedCells[0].Value.ToString();

			try
			{
				Process.Start("https://www.google.co.jp/#q=" + selected);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n原因: " + ex.Source + "\nヘルプ: " + ex.HelpLink, "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				return;
			}
		}

		/// <summary>
		/// iTunesとの情報を同期、更新します。
		/// </summary>
		private void Reflesh()
		{
			dataGridView1.Rows.Clear();
			row = 0;

			try
			{
				app = new iTunesApp();
			}

			catch
			{
				var mb = MessageBox.Show("iTunesがインストールされていません。\niTunesをダウンロードしますか？", "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

				if (mb == DialogResult.Yes)
				{
					try
					{
						Process.Start(ITUNES_URL);
					}

					catch (Exception ex)
					{
						MessageBox.Show(ex.Message + "\n原因: " + ex.Source + "\nヘルプ: " + ex.HelpLink, "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
						return;
					}
				}

				return;
			}

			changeList = new ChangeList();

			IEnumerable<IITTrack> tracks = null;

			try
			{
				tracks = app.LibraryPlaylist.Tracks.Cast<IITTrack>().OrderBy(n => n.Name).Cast<IITTrack>();
			}

			catch
			{
				var _mb = DialogResult.None;

				do
				{
					_mb = MessageBox.Show("トラックの取得に失敗しました。\nリトライしますか？", "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				}
				while (_mb == DialogResult.Yes);

				return;
			}

			foreach (var t in tracks)
			{
				try
				{
					dataGridView1.Rows.Add();
				}

				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + "\n原因: " + ex.Source + "\nヘルプ: " + ex.HelpLink, "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
					return;
				}

				for (int i = 0; i < 15; i++)
				{
					dataGridView1[i, row].Tag = t;
				}

				try
				{
					dataGridView1[NAME, row].Value = t.Name;
					dataGridView1[NAME, row].ToolTipText = "TrackID: " + t.trackID + "\nSourceID: " + t.sourceID;
					dataGridView1[TIME, row].Value = t.Time;
					dataGridView1[EQ, row].Value = t.EQ;
					dataGridView1[ARTIST, row].Value = t.Artist;
					dataGridView1[COMPOSER, row].Value = t.Composer;
					dataGridView1[ALBUM, row].Value = t.Album;
					dataGridView1[SIZE, row].Value = ByteToMegabyte(t.Size, 2).ToString() + " MB";
					dataGridView1[BIT_RATE, row].Value = t.BitRate + " kbps";
					dataGridView1[SAMPLE_RATE, row].Value = t.SampleRate + " kHz";
					dataGridView1[DATE_ADDED, row].Value = t.DateAdded.ToString("yyyy/MM/dd");
					dataGridView1[KIND, row].Value = t.KindAsString;
					dataGridView1[GENRE, row].Value = t.Genre;
					dataGridView1[RATING, row].Value = t.Rating / 20;
					dataGridView1[PLAYED_COUNT, row].Value = t.PlayedCount;
					dataGridView1[COMMENT, row].Value = t.Comment;
				}

				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + "\n原因: " + ex.Source + "\nヘルプ: " + ex.HelpLink, "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
					return;
				}

				row++;
			}

			IEnumerable<IITEQPreset> eqs = null;

			try
			{
				eqs = app.EQPresets.Cast<IITEQPreset>();
			}

			catch
			{
				var _mb = DialogResult.None;

				do
				{
					_mb = MessageBox.Show("イコライザの取得に失敗しました。\nリトライしますか？", "エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				}
				while (_mb == DialogResult.Yes);

				return;
			}

			foreach (var eq in eqs)
			{
				var item = contextMenuStrip1.Items.Add(eq.Name);
				item.Tag = eq;
			}
		}

		/// <summary>
		/// データの数値として適しているかをチェックします。
		/// </summary>
		/// <param name="cell">セル</param>
		/// <param name="kind">データの種類</param>
		/// <returns>適合しているか</returns>
		private bool CheckInt(DataGridViewCell cell, DataKind kind)
		{
			if (cell.Value == null)
			{
				MessageBox.Show("値が入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			var _out = 0;

			if (!int.TryParse(cell.Value.ToString(), out _out))
			{
				MessageBox.Show("数値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (kind == DataKind.Rating)
			{
				if (int.Parse(cell.Value.ToString()) > 5)
				{
					MessageBox.Show("値が大きすぎます。\n0~5の間で設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// バイトをメガバイトに変換します。
		/// </summary>
		/// <param name="b">バイト</param>
		/// <param name="digits">桁数</param>
		/// <returns>メガバイト</returns>
		private double ByteToMegabyte(int b, int digits)
		{
			var mb = (double)b / 1000000;
			double result;

			try
			{
				result = Math.Round(mb, digits);
			}

			catch
			{
				return 0;
			}

			return result;
		}
	}
}