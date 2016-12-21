using System;
using MediaToolkit.Model;

namespace MediaToolkit.Util
{
	public class MediaFileEventArgs : EventArgs
	{
		public bool IsVideo { get; private set; }
		public bool IsOutput { get; private set; }
		public MediaFile MediaFile { get; private set; }

		public MediaFileEventArgs(bool isVideo, bool isOutput, MediaFile mediaFile)
		{
			MediaFile = mediaFile;
			IsOutput = isOutput;
			IsVideo = isVideo;
		}
	}
}