using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendCSharpWPF.Classes
{
    public class ComboBoxItemValue<T>
    {

        public string Text { get; set; }
        public T Value { get; set; }

        public ComboBoxItemValue()
        {

        }
        public ComboBoxItemValue(string text,T value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
