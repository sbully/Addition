using System.Windows;

namespace Addition
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassLibraryAddition.Expression exp1 = new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
                new ClassLibraryAddition.Nombre(33));
            int resultat1 = exp1.Evalue();
            string str1 = exp1.Format();

            ClassLibraryAddition.Expression exp2 = new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
                new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
                new ClassLibraryAddition.Nombre(11)));
            int resultat2 = exp2.Evalue();
            string str2 = exp2.ToString();

            ClassLibraryAddition.Expression exp3 = new ClassLibraryAddition.Soustraction(new ClassLibraryAddition.Nombre(33),
    new ClassLibraryAddition.Nombre(33));
            int resultat3 = exp3.Evalue();
            string str3 = exp3.Format();

            ClassLibraryAddition.Expression exp4 = new ClassLibraryAddition.Soustraction(new ClassLibraryAddition.Nombre(33),
    new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
                new ClassLibraryAddition.Nombre(11)));
            int resultat4 = exp4.Evalue();
            string str4 = exp4.Format();

        }
    }
}
