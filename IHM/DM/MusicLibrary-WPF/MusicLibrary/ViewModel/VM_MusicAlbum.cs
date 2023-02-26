using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MusicLibrary.Helper;
using MusicLibrary.Model;
using MusicLibrary.View;

namespace MusicLibrary.ViewModel
{
    public class VM_MusicAlbum : INotifyPropertyChanged
    {
        private ObservableCollection<Album> _albums;

        public VM_MusicAlbum()
        {
            albums = new ObservableCollection<Album>(AlbumTracks.albums);
            selectedAlbum = albums[0];
        }
        public VM_MusicAlbum(string empty)
        {
            albums = new ObservableCollection<Album>(AlbumTracks.albums);
        }

        private string _composerName;

        public string composerName
        {
            get { return _composerName; }
            set { _composerName = value; OnPropertyChanged(); }
        }

        private string _albumName;

        public string albumName
        {
            get { return _albumName; }
            set { _albumName = value; OnPropertyChanged(); }
        }


        public ObservableCollection<Album> albums
        {
            get { return _albums; }
            set { _albums = value; OnPropertyChanged(); }
        }

        private Album _selectedAlbum;

        public Album selectedAlbum
        {
            get { return _selectedAlbum; }
            set
            {
                _selectedAlbum = value;
                if (value != null)
                {
                    trackList = _selectedAlbum.albumTracks;
                    albumName = _selectedAlbum.albumName;
                    composerName = _selectedAlbum.composerName;
                    if (selectedTrack != null)
                    {
                        if (_selectedAlbum.albumTracks.Count > 0)
                        {
                            selectedTrack = _selectedAlbum.albumTracks[0];
                        }
                    }
                }
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Track> _trackList;

        public ObservableCollection<Track> trackList
        {
            get { return _trackList; }
            set { _trackList = value; OnPropertyChanged(); }
        }


        private Track _selectedTrack;

        public Track selectedTrack
        {
            get { return _selectedTrack; }
            set { _selectedTrack = value; OnPropertyChanged(); }
        }

        private string _newTrack;

        public string newTrack
        {
            get { return _newTrack; }
            set { _newTrack = value; OnPropertyChanged(); }
        }


        public void AddNewAlbum()
        {
            if (AlbumTracks.albums.Where(x => x.albumName == albumName && x.composerName == composerName ).Any())
            {
                MessageBox.Show("The album : " + albumName + " and composer : " + composerName + " already exists", "Duplicate Entry");
            }
            else
            {
                trackList = new ObservableCollection<Track>();
                albums.Add(new Album { albumName = albumName, composerName = composerName, albumTracks = trackList });
                AlbumTracks.albums.Add(new Album { albumName = albumName, composerName = composerName, albumTracks = trackList });
                selectedAlbum = AlbumTracks.albums.Where(x => x.albumName == albumName && x.composerName == composerName).FirstOrDefault();
                MessageBox.Show("New album successfully created", "New Album");
            }
        }
        public void DeleteAlbum()
        {
            if (selectedAlbum != null)
            {
                AlbumTracks.albums.Remove(selectedAlbum);
                albums.Remove(selectedAlbum);

            }
        }


        public void AddNewTrack()
        {
            selectedAlbum.albumTracks.Add(new Track(selectedAlbum.albumName, selectedAlbum.composerName) { Title = newTrack });
        }
        public void DeleteTrack()
        {
            if (selectedTrack != null)
            {
                AlbumTracks.albums.Where(x => x.albumName == selectedAlbum.albumName && x.composerName == selectedAlbum.composerName).FirstOrDefault().albumTracks.Remove(selectedTrack);
            }
        }

        public void OpenNewWindow()
        {
            AlbumDetails albumDetails = new AlbumDetails();
            albumDetails.DataContext = this;
            albumDetails.Show();
        }
        private bool CanDeleteTrack
        {
            get
            {
                return selectedTrack != null;
            }

        }
        private bool CanDeleteAlbum
        {
            get
            {
                return selectedAlbum != null;
            }

        }
        public bool canAddNewalbum
        {
            get { return !(string.IsNullOrWhiteSpace(albumName) || string.IsNullOrWhiteSpace(composerName)); }

        }
        private ICommand _addNewAlbum;
        public ICommand addNewAlbum
        {
            get
            {
                return _addNewAlbum ?? (_addNewAlbum = new CommandHandler(() => AddNewAlbum(), () => canAddNewalbum));
            }
        }
        private ICommand _deleteAlbum;
        public ICommand deleteAlbum
        {
            get
            {
                return _deleteAlbum ?? (_deleteAlbum = new CommandHandler(() => DeleteAlbum(), () => CanDeleteAlbum));
            }
        }




        public bool canAddnewTrack
        {
            get { return !string.IsNullOrWhiteSpace(newTrack); }

        }


        private ICommand _addNewTrack;

        public ICommand addNewTrack
        {
            get
            {
                return _addNewTrack ?? (_addNewTrack = new CommandHandler(() => AddNewTrack(), () => canAddnewTrack));
            }
        }

        private ICommand _deleteTrack;

        public ICommand deleteTrack
        {
            get
            {
                return _deleteTrack ?? (_deleteTrack = new CommandHandler(() => DeleteTrack(), () => CanDeleteTrack));
            }
        }
        private ICommand _openNewWindow;

        public ICommand openNewWindow
        {
            get
            {
                return _openNewWindow ?? (_openNewWindow = new CommandHandler(() => OpenNewWindow(), () => true));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
