﻿using System;
using System.Configuration;

namespace Stylelabs.Integration.Reference.DurableFunctions.Helpers
{
    public static class AppSettings
    {
        public static Uri OriginAddress
        {
            get { return new Uri(GetAppSetting("MOriginAddress")); }
        }

        public static string ClientId
        {
            get { return GetAppSetting("MClientId"); }
        }

        public static string ClientSecret
        {
            get { return GetAppSetting("MClientSecret"); }
        }

        public static string Username
        {
            get { return GetAppSetting("MUsername"); }
        }

        public static string Password
        {
            get { return GetAppSetting("MPassword"); }
        }
        
        private static string GetAppSetting(string name)
        {
            var result = ConfigurationManager.AppSettings[name];
            if (string.IsNullOrEmpty(result)) throw new InvalidOperationException($"Unable to find '{name}' appsetting.");
            return result;
        }
    }
}
