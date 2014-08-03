﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WarApi.Requests;
using WarApi.Utilities.Attributes;

namespace UnitTests
{
    [TestClass]
    public class RequestBaseTests
    {
        protected class TestRequestWithDateParameter : RequestBase
        {
            [RequestParameter("date", true)]
            public DateTime Date { get; set; }
        }

        [TestMethod]
        public void GetEmptyParameters()
        {
            var request = new RequestBase();

            var parameters = request.Parameters;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetExceptionForRequiredParameters()
        {
            var request = new RequestBase();

            request.GetParametersLikeUri();
        }

        [TestMethod]
        public void GetParametersForUri()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";

            var uriParameters = request.GetParametersLikeUri();

            Assert.AreEqual("access_token=access%20token&application_id=application%20id", uriParameters);
        }

        [TestMethod]
        public void GetParametersCreatedWithAddParameter()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.ApplicationId = "application id";
            request.AddParameter("parameter1", "value1");

            var uriParameters = request.GetParametersLikeUri();

            Assert.AreEqual("parameter1=value1&access_token=access%20token&application_id=application%20id", uriParameters);
        }

        [TestMethod]
        public void GetParameterByKey()
        {
            var request = new RequestBase();
            request.AccessToken = "access token";
            request.AddParameter("parameter1", "value1");

            var parameter1 = request.GetParameter("parameter1");
            var accessToken = request.GetParameter("access_token");
            var applicationId = request.GetParameter("application_id");

            Assert.IsNull(applicationId);
            Assert.AreEqual("access token", accessToken);
            Assert.AreEqual("value1", parameter1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TryGetNotExistParameter()
        {
            var request = new RequestBase();

            var parameter1 = request.GetParameter("parameter1");
        }

        [TestMethod]
        public void TestRequestWithDate()
        {
            var request = new TestRequestWithDateParameter();
            request.ApplicationId = "application id";

            request.Date = new DateTime(2011, 8, 15, 8, 42, 30);

            var uriParameters = request.GetParametersLikeUri();

            Assert.AreEqual("date=1313397750&application_id=application%20id", uriParameters);
        }
    }
}
