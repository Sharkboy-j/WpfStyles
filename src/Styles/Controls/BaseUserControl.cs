using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using Styles.Themes.Extensions;

namespace Styles.Controls
{
    public partial class BaseUserControl :UserControl
    {
        public BaseUserControl()
        {
            DataContext = this;
        }
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int PhoneNumber { get; set; }
        }
        public List<User> Users { get; set; } = new List<User>
        {
            new User {Id = 1, Name = "John", PhoneNumber = 777666880},
            new User {Id = 2, Name = "Jane", PhoneNumber = 777666881},
            new User {Id = 3, Name = "Jimmy", PhoneNumber = 777666882},
            new User {Id = 4, Name = "Mary", PhoneNumber = 777666883},
            new User {Id = 5, Name = "Simon", PhoneNumber = 777666884},
            new User {Id = 6, Name = "Ann", PhoneNumber = 777666885},
            new User {Id = 1, Name = "John", PhoneNumber = 777666880},
            new User {Id = 2, Name = "Jane", PhoneNumber = 777666881},
            new User {Id = 3, Name = "Jimmy", PhoneNumber = 777666882},
            new User {Id = 4, Name = "Mary", PhoneNumber = 777666883},
            new User {Id = 5, Name = "Simon", PhoneNumber = 777666884},
            new User {Id = 6, Name = "Ann", PhoneNumber = 777666885}
        };


        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var accentBrush = TryFindResource("AccentColorBrush") as SolidColorBrush;
            accentBrush?.Color.CreateAccentColors();
        }
    }
}
