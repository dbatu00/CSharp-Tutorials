using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    #region Interfaces
    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    interface IComboBox : ITextBox, IListBox { }

    public class Binder { }
    interface IDataBound
    {
        void Bind(Binder b);
    }

    public class EditBox : IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }
    #endregion
    class Program
    {
        static void Main()
        {
            
            #region interface implicit conversion
            //When a class or struct implements a particular interface,
            //instances of that class or struct can be implicitly converted
            //to that interface type. For example:
            EditBox editBox = new();
            IControl control = editBox;
            IDataBound dataBound = editBox;
            #endregion
        }
    }
}
