using iTunesLib;
using System.Collections.Generic;
using static KomeTunes.Enums;

namespace KomeTunes
{
	class ChangeList
	{
		private List<object[]> changeList = new List<object[]>();

		public void Add(IITTrack track, DataKind kind, object value)
		{
			changeList.Add(new object[] { track, kind, value });
		}

		public void Reset()
		{
			changeList.Clear();
		}

		public void Apply()
		{
			foreach(var cl in changeList)
			{
				var track = (IITTrack)cl[0];
				var kind = (DataKind)cl[1];
				var value = cl[2];

				if (value == null)
				{
					value = "";
				}
				
				switch (kind)
				{
					case DataKind.Name: 
						track.Name = value.ToString();
						break;

					case DataKind.EQ:
						track.EQ = value.ToString();
						break;

					case DataKind.Artist:
						track.Artist = value.ToString();
						break;

					case DataKind.Composer:
						track.Composer = value.ToString();
						break;

					case DataKind.Album:
						track.Album = value.ToString();
						break;

					case DataKind.Genre:
						track.Genre = value.ToString();
						break;

					case DataKind.Rating:
						track.Rating = (int)value;
						break;

					case DataKind.PlayedCount:
						track.PlayedCount = (int)value;
						break;

					case DataKind.Comment:
						track.Comment = value.ToString();
						break;
				}
			}
		}
	}
}
