﻿using System;
using Stylelabs.M.Sdk.WebApiClient;


namespace WebClientSkeleton
{
    public static class MConnector
    {
        private static readonly Lazy<MClient> _client = new Lazy<MClient>(() =>
            new MClient(AppSettings.OriginAddress, AppSettings.ClientId, AppSettings.ClientSecret, AppSettings.Username, AppSettings.Password)
        );

        public static MClient Client { get { return _client.Value; } }
    }
}
