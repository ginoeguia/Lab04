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


namespace Lab04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public class Person
    {
        public string PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


        public string FullName { get; set; }
        public string Age { get; set; }
    }
}
