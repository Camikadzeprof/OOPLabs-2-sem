using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _7_8
{
    class MyCommands
    {
        private static RoutedUICommand requery;

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl + R"));
            requery = new RoutedUICommand("Requery", "Requery", typeof(MyCommands), inputs);
        }

        public static RoutedUICommand Requery
        {
            get { return requery; }
        }
    }
}
