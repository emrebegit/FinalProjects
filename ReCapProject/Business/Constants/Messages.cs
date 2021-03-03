using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "New car added";
        public static string CarDeleted = "Car is deleted";
        public static string CarUpdated = "Car is updated";
        public static string ColorAdded = "New color added";
        public static string ColorDeleted = "Color is deleted";
        public static string ColorUpdated = "Color is updated";
        public static string BrandAdded = "New Brand added";
        public static string BrandDeleted = "Brand is deleted";
        public static string BrandUpdated = "Brand is updated";
        public static string CarNameInvalit = "Car name is invalid";
        public static string CarDailyPrice = "Car daiy price is not good";
        public static string CarsListed = "Cars are listed";
        public static string ColorNameInvalit = "Color name is invalid";
        public static string ColorListed = "Color are listed";
        public static string BrandInvalit = "Brand name is invalid";
        public static string BrandListed = "Brand are listed";
        public static string MaintenanceTime = "System is not working for now";
        public static string LimitOfImages="Images count is so big";
        public static string ImagesAdded="Images is added";
        public static string ImagesDeleted="Images is deleted";
        public static string BadDeleteOperations="Images is not delete";
        public static string AuthorizationDenied="yetki yok";
        public static string AccessTokenCreated="token oluşturuldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="hatalı parola";
        public static string SuccessfulLogin="giriş başarılı";
        public static string UserRegistered="kullanıcı oluşturuldu";
        public static string UserAlreadyExists="kullanıcı mevcut";
    }
}
