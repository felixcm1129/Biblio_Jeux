using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel; //INotifyPropertyChange
using System.Runtime.CompilerServices; //[CallerMemberName]
using System.Diagnostics;

namespace Biblio_Jeux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<Jeux> jeux { get; set; }
        private Jeux jeuxCourrant;

        private int maxIndex = 0;

        public Jeux JeuxCourrant
        {
            get => jeuxCourrant;
            set
            {
                jeuxCourrant = value;
                OnPropertyChanged();
            }
        }

        public int MaxIndex { get => maxIndex; set => maxIndex = value; }

        public MainWindow()
        {
            jeux = new List<Jeux>()
            {
                new Jeux
                {
                    titre = "The Witcher 3",
                    éditeur = "CD Projekt",
                    année = 2015,
                    description = "100 heures pour faire le tour au complet sans faire les dlc!!!!",
                    pochette = "/images/the_witcher_3.jpg",
                    console = "PC",
                    côte = 97,
                },

                new Jeux
                {
                    titre = "F1 2019",
                    éditeur = "CodeMasters",
                    année = 2019,
                    description = "Simulateur de F1",
                    pochette = "/images/ps_f1_2019.jpg",
                    console = "PC",
                    côte = 95,
                },

                new Jeux
                {
                    titre = "Red Dead Redemption 2",
                    éditeur = "Rockstar Games",
                    année = 2018,
                    description = "Jeu Western",
                    pochette = "/images/red_dead_redemption_2_cover_art_1.jpg",
                    console = "PC",
                    côte = 98,
                },

            };

            JeuxCourrant = jeux[0];
            MaxIndex = jeux.Count - 1;

            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine((int)e.NewValue);

            int newIndex = (int)e.NewValue;

            JeuxCourrant = jeux[newIndex];

        }
    }
}
