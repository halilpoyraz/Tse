namespace Tse.Dal.Backoffice.Model
{
    public class StandartIcerikDenetim
    {
        //Constructor
        public StandartIcerikDenetim()
        {
        }

        //Properties
        public int StandartIcerikDenetimID { get; set; }
        public int StandartID { get; set; }
        public int StandartIcerikID { get; set; }
        public bool Secmeli { get; set; }
        public bool Zorunlu { get; set; }
        public bool BilgiAmacli { get; set; }
        public bool KurumYeterlilikSertifikasi { get; set; }
        public bool UrunSertifikasi { get; set; }
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Standart Standart { get; set; }
        public virtual StandartIcerik StandartIcerik { get; set; }
        public virtual Durum Durum { get; set; }


        //Methods
    }
}