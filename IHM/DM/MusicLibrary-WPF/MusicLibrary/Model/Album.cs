using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Model
{
    /// <summary>
    /// This class represents an album in the music library.
    /// </summary>
    public class Album
    {
        public string albumName { get; set; }
        public string composerName { get; set; }
        public ObservableCollection<Track> albumTracks { get; set; }
    }
}

