using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Model
{
    /// <summary>
    /// This class represents a track in the music library.
    /// </summary>
    public class Track
    {
        public int TrackID { get; private set; }
        public string Title { get; set; }
        public string AlbumName { get; set; }
        public string ComposerName { get; set; }
        
        public static Dictionary<string, int> albumTrackIds = new Dictionary<string, int>();

        public Track(string albumName, string composerName)
        {
            AlbumName = albumName;
            ComposerName = composerName;

            string key = albumName + composerName;
            if (!albumTrackIds.ContainsKey(key))
            {
                albumTrackIds[key] = 0;
            }
            TrackID = ++albumTrackIds[key];
        }
    }
}

