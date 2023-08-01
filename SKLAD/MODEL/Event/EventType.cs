using System.ComponentModel.DataAnnotations;

namespace SKLAD.MODEL.Event
{
    public enum EventType
    {
        [Display(Name = @"BARKOD BOSILGAN")]
        InProduction = 1,
        [Display(Name = @"TRANSFER KIRISH")]
        InTransfer = 2,
        [Display(Name = @"TRANSFER CHIQISH")]
        OutTransfer = 3,
        [Display(Name = @"SOTILGAN")]
        Sale = 4,
        [Display(Name = @"SOTUVDAN QAYTGAN")]
        ReturnFromSale = 5

    }
}
