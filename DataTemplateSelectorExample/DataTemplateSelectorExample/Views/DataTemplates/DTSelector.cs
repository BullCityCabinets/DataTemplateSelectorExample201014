using DataTemplateSelectorExample.Models;
using DataTemplateSelectorExample.ViewModels;
using Xamarin.Forms;

namespace DataTemplateSelectorExample.Views.DataTemplates
{
    public class DTSelector : DataTemplateSelector
    {
        public DataTemplate DT1ref { get; set; }
        public DataTemplate DT2ref { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (App.CurrentUser.MyPref)
            {
                case SomeEnum.ILikeDT1:
                    return DT1ref;

                case SomeEnum.ILikeDT2:
                    return DT2ref;

                default:
                    return DT1ref;
            }
        }
    }
}