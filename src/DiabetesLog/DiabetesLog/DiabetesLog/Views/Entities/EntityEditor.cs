using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
    public class EntityEditor<ViewModelType, EntityType> : BasePage<ViewModelType> 
        where ViewModelType : BaseViewModel, new()
    {
    }
}
