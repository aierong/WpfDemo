using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

/*          
            SolidColorBrush br1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
           


Color的3种创建方式：
Color cl0 = Colors.Brown;
Color cl = ( Color ) ColorConverter.ConvertFromString( "#A52A2A" );
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
            Color cl = ( Color ) ColorConverter.ConvertFromString( "#A52A2A" );
            SolidColorBrush br2 = new System.Windows.Media.SolidColorBrush( cl );
            Color cl2 = System.Windows.Media.Color.FromArgb( 255 , 165 , 42 , 42 );
            SolidColorBrush br3 = new System.Windows.Media.SolidColorBrush( cl2 );

            if ( br1 != null )
            {
            }

            //SolidColorBrush 转换Color 2种方式
            SolidColorBrush _SolidColorBrush = new System.Windows.Media.SolidColorBrush( Colors.Brown );
            Color Color1 = _SolidColorBrush.Color;
            Color Color2 = ( Color ) ColorConverter.ConvertFromString( _SolidColorBrush.ToString () );


            Brush b1 = new System.Windows.Media.SolidColorBrush( Colors.Brown );
        }

    }
}
