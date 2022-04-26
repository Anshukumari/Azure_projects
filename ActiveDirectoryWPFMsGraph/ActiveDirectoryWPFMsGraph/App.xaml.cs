using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ActiveDirectoryWPFMsGraph
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            _clientApp = PublicClientApplicationBuilder.Create(ClientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, Tenant)
                .WithDefaultRedirectUri()
                .Build();
        }
        private static string ClientId = "8d1fbc63-16e3-4e2f-8d17-c01a913eb660";
        private static string Tenant = "common";

        private static IPublicClientApplication _clientApp;

        public static IPublicClientApplication PublicClientApp
        {
            get { return _clientApp; }
        }
    }
}
