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

namespace ExtendCSharpWPF.Controls
{
    /// <summary>
    /// Logica di interazione per NumericUpDown.xaml
    /// </summary>
    public partial class NumericUpDown : UserControl
    {
        public int? Max { get; set; } = null;
        public int? Min { get; set; } = null;
        public int Default { get; set; } = 0;



        public NumericUpDown()
        {
            InitializeComponent();
            
        }
        private void userControl_Loaded(object sender, RoutedEventArgs e)
        {
            if(_numValue==null)
                _numValue = Default;
            txtNum.Text = _numValue.ToString();
        }
        private int? _numValue = null;
        private bool DisableTextChanged = false;

        public int NumValue
        {
            get { return _numValue!=null?_numValue.Value:0; }
            set
            {
                _numValue = value;
                DisableTextChanged = true;
                txtNum.Text = value.ToString();
                DisableTextChanged = false;
            }
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            if( CheckNumber(NumValue+1))
                NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            if (CheckNumber(NumValue -1))
                NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DisableTextChanged)
                return;
            
            if (txtNum == null)
            {
                return;
            }

            int t;
            if (int.TryParse(txtNum.Text, out t))
            {
                if (CheckNumber(t))
                    NumValue = t;
                else
                    NumValue = NumValue;
            }
            else
                NumValue = Default;
        }


        private bool CheckNumber(int n)
        {
            if (Max != null && n > Max)
                return false;

            if (Min != null && n < Min)
                return false;

            return true;
               
        }

        
    }
}
