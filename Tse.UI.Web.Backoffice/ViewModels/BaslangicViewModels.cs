namespace Tse.UI.Web.Backoffice.ViewModels
{
    using Models;

    public partial class GostergePaneliViewModel : BaseViewModel
    {
        //Constructor
        public GostergePaneliViewModel()
        {
            Meta = new Meta()
            {
                Title = "Gösterge Paneli",
                Description = "Bu ekrandan sistemde gerçekleşen son olaylara gözatabilirsiniz"
            };
            
            BreadCrumb = new BreadCrumb()
            {
                Text1 = "Başlangıç",
                Link1 = "/baslangic/gosterge-paneli",
                Text2 = "Gösterge Paneli"
            };                        
        }                       
    }

    public partial class GuncellemelerViewModel : BaseViewModel
    {
        //Constructor
        public GuncellemelerViewModel()
        {
            Meta = new Meta()
            {
                Title = "Güncellemeler",
                Description = "Bu ekrandan uygulamanın güncelleme paketlerini yükleyip, kurabilirsiniz."
            };

            BreadCrumb = new BreadCrumb()
            {
                Text1 = "Başlangıç",
                Link1 = "/baslangic/gosterge-paneli",
                Text2 = "Güncellemeler"
            };           
        }   
    }
}