using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages 
    {
        //--- Car Messages---
        public static string CarAdded = "Araç eklendi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarListed = "Araçlar listelendi";       
        public static string CarDetailed = "Araç detayları";

        //--- Color Messages---
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renk listelendi";
        public static string ColorUpdated = "Renk güncellendi";

        //--- Brand Massages---
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Marka listelendi";
        public static string BrandUpdated = "Marka güncellendi";

        //--- User Messages---
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcı listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        //--- Error Messages---
        public static string InvalidException = "Hata Oluştu";

        //--- System Messages---
        public static string MaintananceTime = "Sistem bakımda";

        //--- Customer Messages---
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteri listelendi";

        //--- Rental Messages---
        public static string RentalAdded = "Kiralanan araç eklendi";
        public static string RentalDeleted = "Kiralanan araç silindi";
        public static string RentalListed = "Kiralanan araçlar listelendi";
        public static string RentalUpdated = "Kiralanan araçlar güncellendi";
        public static string RentalError = "Araç kiralanamıyor";
    }
}
