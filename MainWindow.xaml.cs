using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfDesign
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            members.Add(new Member { Number="1", Character="J", BgColor=(Brush)converter.ConvertFromString("#1098ad"), Name="John Doe", Position="Coach", Email="john.doe@gmail.com", Phone="854-738-7484"});
            members.Add(new Member { Number="2", Character="R", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Reza Alavi", Position="Administrator", Email="reza11@hotmail.com", Phone="027-894-8435"});
            members.Add(new Member { Number="3", Character="D", BgColor=(Brush)converter.ConvertFromString("#ff8f00"), Name="Dennis Castillio", Position= "Coach", Email="dent.cast@gmail.com", Phone="730-256-4824"});
            members.Add(new Member { Number="4", Character="G", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Gabriel Cox", Position= "Coach", Email="coxcox@gmail.com", Phone="456-987-7098"});
            members.Add(new Member { Number="5", Character="L", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Lena Jones", Position= "Manager", Email="len.off@hotmail.com", Phone="243-236-5564"});
            members.Add(new Member { Number="6", Character="B", BgColor=(Brush)converter.ConvertFromString("#6741d9"), Name="Benjamin Caliword", Position= "Administrator", Email="beni12@hotmail.com", Phone="677-543-7560"});
            members.Add(new Member { Number="7", Character="S", BgColor=(Brush)converter.ConvertFromString("#ff6d00"), Name="Sophia Muris", Position= "Coach", Email="sophi.muri@gmail.com", Phone="450-123-3434"});
            members.Add(new Member { Number="8", Character="A", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Ali Pormand", Position= "Manager", Email="alipor@yahoo.com", Phone="676-621-2346"});
            members.Add(new Member { Number="9", Character="F", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Frank Underwood", Position="Manager", Email="frank@yahoo.com", Phone="334-787-6666"});
            members.Add(new Member { Number="10", Character="S", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Saeed Dasman", Position= "Coach", Email="saeed.dasi@hotmail.com", Phone="347-422-3435"});
            
            members.Add(new Member { Number="1", Character="J", BgColor=(Brush)converter.ConvertFromString("#1098ad"), Name="John Doe", Position="Coach", Email="john.doe@gmail.com", Phone="854-738-7484"});
            members.Add(new Member { Number="2", Character="R", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Reza Alavi", Position="Administrator", Email="reza11@hotmail.com", Phone="027-894-8435"});
            members.Add(new Member { Number="3", Character="D", BgColor=(Brush)converter.ConvertFromString("#ff8f00"), Name="Dennis Castillio", Position= "Coach", Email="dent.cast@gmail.com", Phone="730-256-4824"});
            members.Add(new Member { Number="4", Character="G", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Gabriel Cox", Position= "Coach", Email="coxcox@gmail.com", Phone="456-987-7098"});
            members.Add(new Member { Number="5", Character="L", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Lena Jones", Position= "Manager", Email="len.off@hotmail.com", Phone="243-236-5564"});
            members.Add(new Member { Number="6", Character="B", BgColor=(Brush)converter.ConvertFromString("#6741d9"), Name="Benjamin Caliword", Position= "Administrator", Email="beni12@hotmail.com", Phone="677-543-7560"});
            members.Add(new Member { Number="7", Character="S", BgColor=(Brush)converter.ConvertFromString("#ff6d00"), Name="Sophia Muris", Position= "Coach", Email="sophi.muri@gmail.com", Phone="450-123-3434"});
            members.Add(new Member { Number="8", Character="A", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Ali Pormand", Position= "Manager", Email="alipor@yahoo.com", Phone="676-621-2346"});
            members.Add(new Member { Number="9", Character="F", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Frank Underwood", Position="Manager", Email="frank@yahoo.com", Phone="334-787-6666"});
            members.Add(new Member { Number="10", Character="S", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Saeed Dasman", Position= "Coach", Email="saeed.dasi@hotmail.com", Phone="347-422-3435"});
            
            members.Add(new Member { Number="1", Character="J", BgColor=(Brush)converter.ConvertFromString("#1098ad"), Name="John Doe", Position="Coach", Email="john.doe@gmail.com", Phone="854-738-7484"});
            members.Add(new Member { Number="2", Character="R", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Reza Alavi", Position="Administrator", Email="reza11@hotmail.com", Phone="027-894-8435"});
            members.Add(new Member { Number="3", Character="D", BgColor=(Brush)converter.ConvertFromString("#ff8f00"), Name="Dennis Castillio", Position= "Coach", Email="dent.cast@gmail.com", Phone="730-256-4824"});
            members.Add(new Member { Number="4", Character="G", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Gabriel Cox", Position= "Coach", Email="coxcox@gmail.com", Phone="456-987-7098"});
            members.Add(new Member { Number="5", Character="L", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Lena Jones", Position= "Manager", Email="len.off@hotmail.com", Phone="243-236-5564"});
            members.Add(new Member { Number="6", Character="B", BgColor=(Brush)converter.ConvertFromString("#6741d9"), Name="Benjamin Caliword", Position= "Administrator", Email="beni12@hotmail.com", Phone="677-543-7560"});
            members.Add(new Member { Number="7", Character="S", BgColor=(Brush)converter.ConvertFromString("#ff6d00"), Name="Sophia Muris", Position= "Coach", Email="sophi.muri@gmail.com", Phone="450-123-3434"});
            members.Add(new Member { Number="8", Character="A", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Ali Pormand", Position= "Manager", Email="alipor@yahoo.com", Phone="676-621-2346"});
            members.Add(new Member { Number="9", Character="F", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Frank Underwood", Position="Manager", Email="frank@yahoo.com", Phone="334-787-6666"});
            members.Add(new Member { Number="10", Character="S", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Saeed Dasman", Position= "Coach", Email="saeed.dasi@hotmail.com", Phone="347-422-3435"});
            
            members.Add(new Member { Number="1", Character="J", BgColor=(Brush)converter.ConvertFromString("#1098ad"), Name="John Doe", Position="Coach", Email="john.doe@gmail.com", Phone="854-738-7484"});
            members.Add(new Member { Number="2", Character="R", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Reza Alavi", Position="Administrator", Email="reza11@hotmail.com", Phone="027-894-8435"});
            members.Add(new Member { Number="3", Character="D", BgColor=(Brush)converter.ConvertFromString("#ff8f00"), Name="Dennis Castillio", Position= "Coach", Email="dent.cast@gmail.com", Phone="730-256-4824"});
            members.Add(new Member { Number="4", Character="G", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Gabriel Cox", Position= "Coach", Email="coxcox@gmail.com", Phone="456-987-7098"});
            members.Add(new Member { Number="5", Character="L", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Lena Jones", Position= "Manager", Email="len.off@hotmail.com", Phone="243-236-5564"});
            members.Add(new Member { Number="6", Character="B", BgColor=(Brush)converter.ConvertFromString("#6741d9"), Name="Benjamin Caliword", Position= "Administrator", Email="beni12@hotmail.com", Phone="677-543-7560"});
            members.Add(new Member { Number="7", Character="S", BgColor=(Brush)converter.ConvertFromString("#ff6d00"), Name="Sophia Muris", Position= "Coach", Email="sophi.muri@gmail.com", Phone="450-123-3434"});
            members.Add(new Member { Number="8", Character="A", BgColor=(Brush)converter.ConvertFromString("#ff5252"), Name="Ali Pormand", Position= "Manager", Email="alipor@yahoo.com", Phone="676-621-2346"});
            members.Add(new Member { Number="9", Character="F", BgColor=(Brush)converter.ConvertFromString("#1e88e5"), Name="Frank Underwood", Position="Manager", Email="frank@yahoo.com", Phone="334-787-6666"});
            members.Add(new Member { Number="10", Character="S", BgColor=(Brush)converter.ConvertFromString("#0ca678"), Name="Saeed Dasman", Position= "Coach", Email="saeed.dasi@hotmail.com", Phone="347-422-3435"});
            
            membersDataGrid.ItemsSource = members;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }

}
