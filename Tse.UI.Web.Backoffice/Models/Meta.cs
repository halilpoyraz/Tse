namespace Tse.UI.Web.Backoffice.Models
{
    public partial class Meta
    {
        //Constructor
        public Meta()
        {
            Title = "Denetim A.Ş.";
            Description = "TSE Standart Denetleme Web Uygulaması";
            Keyword = "TSE, Standart denetim, denetim anket";
            Author = "Halil İbrahim Poyraz";
        }

        //Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string Author { get; set; }
    }
}

