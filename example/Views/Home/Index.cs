using System;
using System.Collections.Generic;
using System.Linq;
using System.Mvc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace example.Views.Home
{
    internal class Index : BaseView<Label, object>
    {
        protected override void RenderCore()
        {
            MainView.Content = Model;
        }
    }
}
