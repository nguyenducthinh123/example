using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.Views
{
    abstract class BaseView<TView, TModel>: System.Mvc.IView
        where TView : System.Windows.UIElement, new()    {

        public object Content => MainView;

        public TView MainView {  get; set; }
        public TModel Model { get; set; }

        public void Render(object model)
        {
            MainView = new TView();
            Model = (TModel)model;

            RenderCore();

        }
        protected virtual void RenderCore() { }
    }
}
