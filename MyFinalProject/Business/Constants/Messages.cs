using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is added";
        public static string ProductNameInvalid = "Product name is bad";
        public static string MaintenanceTime = "Time is not good";
        public static string ProductsListed = "Products are listed";
        public static string ProductCountOfCategoryError = "This category is full";
        internal static string ProductNameAlreadyExists="This name is using";
        public static string CategoryLimitExceded = "Category limited is full";
        internal static string AuthorizationDenied="No yetki";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
