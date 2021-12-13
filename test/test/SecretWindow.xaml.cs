using System.Windows;
using System.Security.Permissions;

namespace test
{
    /// <summary>
    /// Interaction logic for SecretWindow.xaml
    /// </summary>
    //[PrincipalPermission(SecurityAction.Demand)]
    public partial class SecretWindow : Window, IView
    {
        public SecretWindow()
        {
            InitializeComponent();
        }

        #region IView Members

        public IViewModel ViewModel
        {
            get
            {
                return DataContext as IViewModel;
            }
            set
            {
                DataContext = value;
            }
        }

        #endregion
    }
}