using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;



namespace PrismDemo.RegionDemo.ViewModel
{
    public class RegionDemo1ViewModel : BindableBase
    {
        public DelegateCommand ButtonAClickCommand
        {
            get; private set;
        }



        public DelegateCommand ButtonBClickCommand
        {
            get; private set;
        }



        public RegionDemo1ViewModel ()
        {
            ButtonAClickCommand = new DelegateCommand( () =>
            {

            } );

            ButtonBClickCommand = new DelegateCommand( () =>
            {

            } );
        }



    }
}