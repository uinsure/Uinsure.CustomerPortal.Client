/*
 * Uinsure.CustomerPortal.API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Api;
// uncomment below to import models
//using Uinsure.CustomerPortal.Client.Model;

namespace Uinsure.CustomerPortal.Client.Test.Api
{
    /// <summary>
    ///  Class for testing RenewalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RenewalsApiTests : IDisposable
    {
        private RenewalsApi instance;

        public RenewalsApiTests()
        {
            instance = new RenewalsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RenewalsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RenewalsApi
            //Assert.IsType<RenewalsApi>(instance);
        }

        /// <summary>
        /// Test ApiRenewalsEmailUpdatePost
        /// </summary>
        [Fact]
        public void ApiRenewalsEmailUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateEmailAddress? updateEmailAddress = null;
            //instance.ApiRenewalsEmailUpdatePost(updateEmailAddress);
        }

        /// <summary>
        /// Test ApiRenewalsOptInPost
        /// </summary>
        [Fact]
        public void ApiRenewalsOptInPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OptInRequest? optInRequest = null;
            //instance.ApiRenewalsOptInPost(optInRequest);
        }
    }
}