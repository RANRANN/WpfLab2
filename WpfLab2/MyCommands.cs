using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfLab2
{
    internal class MyCommands
    {
        public static RoutedCommand Normal { get; set; }
        public static RoutedCommand Ing { get; set; }
        public static RoutedCommand Journal { get; set; }
        public static RoutedUICommand Help { get; set; }
        public static RoutedUICommand Contacts { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.N, ModifierKeys.Control, "Alt+1"));
            Normal = new RoutedCommand("Normal", typeof(MyCommands), inputs);

            InputGestureCollection inputs1 = new InputGestureCollection();
            inputs1.Add(new KeyGesture(Key.I, ModifierKeys.Control, "Alt+2"));
            Ing = new RoutedUICommand("Инженерный", "Ing", typeof(MyCommands), inputs1);

            Journal = new RoutedUICommand("Журнал", "Journal", typeof(MyCommands));
            
            
            InputGestureCollection inputs2 = new InputGestureCollection();
            inputs2.Add(new KeyGesture(Key.H, ModifierKeys.Control, "Ctrl+H"));
            Help = new RoutedUICommand("Помощь", "Help", typeof(MyCommands), inputs2);

            Contacts = new RoutedUICommand("Контакты", "Contacts", typeof(MyCommands));


        }

    }
}
