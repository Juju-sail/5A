using MusicLibrary.Model;
using MusicLibrary.View;
using MusicLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MusicLibrary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            AlbumTracks.albums = new ObservableCollection<Album> {  new Album { albumName = "Test",  composerName = "Test" },

            };
            AlbumTracks.albums[0].albumTracks = new ObservableCollection<Track> {   new Track("Test", "Test") { Title = "newTrack" },
                                        
            };

            VM_MusicAlbum vM_MusicAlbum = new VM_MusicAlbum();
            MusicAlbumEditor musicAlbumEditor = new MusicAlbumEditor();
            musicAlbumEditor.DataContext = vM_MusicAlbum;
            musicAlbumEditor.Show();

        }
    }
}
