using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

/*       
SolidColorBrush的创建方式
SolidColorBrush br1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );

Brush的创建方式
//Brush是SolidColorBrush的基类
Brush b1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );

Brush转hex
Brush b2 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
//Brush转hex
var hex1 = b2.ToString();

SolidColorBrush转hex
SolidColorBrush sb1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
//SolidColorBrush转hex
var hex2 = sb1.ToString();

SolidColorBrush转Color
SolidColorBrush sb2 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
//SolidColorBrush转Color
var co1 = sb2.Color;
           
Color的创建方式：
Color cl0 = Colors.Brown;

//hex转Color
Color cl = ( Color ) ColorConverter.ConvertFromString( "#A52A2A" );
//rgb转Color
Color cl2 = System.Windows.Media.Color.FromArgb( 255 , 165 , 42 , 42 );





*/

namespace WpfApp.Views.colorbrushstring
{
    public class colorWindow1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public colorWindow1ViewModel ()
        {
            Color cl0 = Colors.Brown;
            SolidColorBrush br1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
            //hex转Color
            Color cl = ( Color ) ColorConverter.ConvertFromString( "#A52A2A" );
            SolidColorBrush br2 = new System.Windows.Media.SolidColorBrush( cl );
            //rgb转Color
            Color cl2 = System.Windows.Media.Color.FromArgb( 255 , 165 , 42 , 42 );
            SolidColorBrush br3 = new System.Windows.Media.SolidColorBrush( cl2 );

            if ( br1 != null )
            {
            }

            //SolidColorBrush 转换Color 2种方式
            SolidColorBrush _SolidColorBrush = new System.Windows.Media.SolidColorBrush( Colors.Brown );
            Color Color1 = _SolidColorBrush.Color;
            Color Color2 = ( Color ) ColorConverter.ConvertFromString( _SolidColorBrush.ToString() );

            Brush b1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );

            Brush b2 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
            //Brush转hex
            var hex1 = b2.ToString();

            SolidColorBrush sb1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
            //SolidColorBrush转hex
            var hex2 = sb1.ToString();

            SolidColorBrush sb2 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
            //SolidColorBrush转Color
            var co1 = sb2.Color;
           
        }

    }
}
