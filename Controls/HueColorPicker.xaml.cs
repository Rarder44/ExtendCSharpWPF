using ExtendCSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using ExtendCSharpWPF;
using ExtendCSharp.ExtendedClass;

namespace ExtendCSharpWPF.Controls
{
    /// <summary>
    /// Logica di interazione per HueColorPicker.xaml
    /// </summary>
    public partial class HueColorPicker : UserControl
    {
      


        public double Radius
        {
            get
            {
                if (this.ActualHeight < this.ActualWidth)
                    return this.ActualHeight / 2;
                else
                    return this.ActualWidth / 2;
            }
        }
        private Point Center
        {
            get
            {
                return new Point(canvas.ActualWidth / 2, canvas.ActualHeight / 2);
            }
        }

        private Ellipse SelectionCircle;
        private  Color _currentSelectedColor = Colors.White;
        public Color SelectedColor
        {
            get
            {
                return _currentSelectedColor;
            }
        }

        private DirectBitmap imgHud;

        public event EventHandler<Color> ColorChanged;
        
        public HueColorPicker()
        {
            InitializeComponent();
            ResourcesService rs=new ResourcesService(System.Reflection.Assembly.GetExecutingAssembly());
            BitmapImage img = rs.GetObject<BitmapImage>( "ExtendCSharpWPF.Resource.HueRing.png");
            canvas.Background = new ImageBrush(img);
          

            SelectionCircle = new Ellipse();
            SelectionCircle.Stroke = System.Windows.Media.Brushes.Black;
            SelectionCircle.Fill = System.Windows.Media.Brushes.Transparent;
            SelectionCircle.HorizontalAlignment = HorizontalAlignment.Center;
            SelectionCircle.VerticalAlignment = VerticalAlignment.Center;  
            canvas.Children.Add(SelectionCircle);
        }


       

        void CheckColorSelected(Point MousePosition)
        {
            double distance = MousePosition.Distance(Center);

            if (distance < Radius - 1)      //CORR: -1 per evitare colori neri involontari       
            {
                Point p = MousePosition;
                MoveSelectionCircle(p);
                _currentSelectedColor = GetPixelColor(p);
                ColorChanged?.Invoke(this, _currentSelectedColor);
            }

        }

        void MoveSelectionCircle(Point destination)
        {
            double left = destination.X - (SelectionCircle.Width / 2);
            double top = destination.Y - (SelectionCircle.Height / 2);
            SelectionCircle.Margin = new Thickness(left, top, 0, 0);
        }


        public Color GetPixelColor(Point p)
        {
            //ATTENZIONE!: le lettere a/r/g/b non seguono i GET! ( l'immagine che viene caricato ha una diversa disposizione dei byte dei colori in memoria ) 
            byte b = (byte)imgHud.getA((int)p.X, (int)p.Y);
            byte g = (byte)imgHud.getR((int)p.X, (int)p.Y);
            byte r = (byte)imgHud.getG((int)p.X, (int)p.Y);
            byte a = (byte)imgHud.getB((int)p.X, (int)p.Y);

            return Color.FromArgb(a, r, g, b);
        }








        protected override void OnRender(DrawingContext drawingContext)
        {
            var b = canvas.ToBitmap();
            imgHud = new DirectBitmap(b.GetBytes(),(int)b.Width, (int)b.Height);

            double rad = Radius;
            SelectionCircle.Width = rad/10;
            SelectionCircle.Height = rad/10;
            MoveSelectionCircle(Center);

            base.OnRender(drawingContext);
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CheckColorSelected(e.GetPosition(this));
         
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed)
                return;

            CheckColorSelected(e.GetPosition(this));
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
        

    

        /*
         immagine generata con codice JS -> https://jsfiddle.net/1re602s3/
            <canvas id="picker" width="1000" height="1000"></canvas>


            <script>
             var canvas = document.getElementById("picker");
            var context = canvas.getContext("2d");
            var x = canvas.width / 2;
            var y = canvas.height / 2;
            var radius = 500;
            var counterClockwise = false;

            for(var angle=0; angle<=360; angle+=0.1){
                var startAngle = (angle-2)*Math.PI/180;
                var endAngle = angle * Math.PI/180;
                context.beginPath();
                context.moveTo(x, y);
                context.arc(x, y, radius, startAngle, endAngle, counterClockwise);
                context.closePath();
               var gradient = context.createRadialGradient(x, y, 0, x, y, radius);
	            gradient.addColorStop(0,'hsl('+angle+', 10%, 100%)');
	            gradient.addColorStop(1,'hsl('+angle+', 100%, 50%)');
                context.fillStyle = gradient;
                context.fill();
            }
            var img    = canvas.toDataURL("image/png");
            document.write('<img src="'+img+'"/>');
            </script>
         */

    }
}
