﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using JongSnam.Mobile.Constants;
using JongSnam.Mobile.CustomErrors;
using JongSnam.Mobile.Services.Interfaces;
using JongSnamService;
using Microsoft.Rest;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace JongSnam.Mobile.Services.Base
{
    public abstract class BaseServices
    {
        protected readonly IConfigurationService ConfigurationService;

        protected readonly JongSnamServices JongSnamServices;

        protected readonly IConnectivityService ConnectivityService;

        private string User
        {
            get
            {
                var user = Preferences.Get(AuthorizeConstants.UserKey, string.Empty);
                return user;
            }
        }

        private string Password
        {
            get
            {
                var password = Preferences.Get(AuthorizeConstants.PasswordKey, string.Empty);
                return password;
            }
        }

        protected Dictionary<string, List<string>> CustomHeaders
        {
            get
            {
                var customHeaders = new Dictionary<string, List<string>>();

                customHeaders.Add(AuthorizeConstants.AuthorizationKey, new List<string> { "keyHere" });
                customHeaders.Add(AuthorizeConstants.UserKey, new List<string> { User });
                customHeaders.Add(AuthorizeConstants.PasswordKey, new List<string> { Password });

                return customHeaders;
            }
        }

        public BaseServices()
        {
            ConfigurationService = DependencyService.Get<IConfigurationService>();
            ConnectivityService = DependencyService.Get<IConnectivityService>();
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            //JongSnamServices = new JongSnamServices(new Uri("http://192.168.1.13:8588/"), handler);
            //JongSnamServices = new JongSnamServices(new Uri("http://172.18.52.145:8080/"), handler);
            JongSnamServices = new JongSnamServices(new Uri("https://jongsnamservices25640404210358.azurewebsites.net/"), handler);
        }

        protected async Task<T> GetRespondDtoHandlerHttpStatus<T>(HttpOperationResponse httpOperationResponse)
        {
            var responseString = await httpOperationResponse.Response.Content.ReadAsStringAsync();
            //if (httpOperationResponse.Response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    var respondModel = JsonConvert.DeserializeObject<T>(responseString);
            //    return respondModel;
            //}
            var respondModel = JsonConvert.DeserializeObject<T>(responseString);
            return respondModel;
        }

        protected T InvokeServiceCheckInternetConnection<T>(Func<T> serviceMethod)
        {
            var isInternetConnection = ConnectivityService.IsInternetConnection();
            if (!isInternetConnection)
            {
                throw new NoInternetConnectionException($"Cannot request to {nameof(serviceMethod)}");
            }

            return serviceMethod.Invoke();
        }

    }
}
