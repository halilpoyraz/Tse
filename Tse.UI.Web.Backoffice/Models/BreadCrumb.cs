namespace Tse.UI.Web.Backoffice.Models
{
    public partial class BreadCrumb
    {
        //Constructor
        public BreadCrumb()
        {            
            Text1 = "Başlangıç";
            Link1 = "/baslangic/gosterge-paneli";
            Text2 = null;
            Link2 = null;
            Text3 = null;
            Link3 = null;
            HeadText = null;
            SmallText = null;
        }

        //Properties        
        public string Text1 { get; set; }
        public string Link1 { get; set; }
        public string Text2 { get; set; }
        public string Link2 { get; set; }
        public string Text3 { get; set; }
        public string Link3{ get; set; }
        public string HeadText { get; set; }
        public string SmallText { get; set; }
    }
}