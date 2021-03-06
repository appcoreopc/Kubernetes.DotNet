/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Model;
using Kubernetes.DotNet.Client;
using System.Reflection;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    ///  Class for testing V2alpha1CronJobSpec
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class V2alpha1CronJobSpecTests
    {
        // TODO uncomment below to declare an instance variable for V2alpha1CronJobSpec
        //private V2alpha1CronJobSpec instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of V2alpha1CronJobSpec
            //instance = new V2alpha1CronJobSpec();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V2alpha1CronJobSpec
        /// </summary>
        [Test]
        public void V2alpha1CronJobSpecInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" V2alpha1CronJobSpec
            //Assert.IsInstanceOfType<V2alpha1CronJobSpec> (instance, "variable 'instance' is a V2alpha1CronJobSpec");
        }

        /// <summary>
        /// Test the property 'ConcurrencyPolicy'
        /// </summary>
        [Test]
        public void ConcurrencyPolicyTest()
        {
            // TODO unit test for the property 'ConcurrencyPolicy'
        }
        /// <summary>
        /// Test the property 'FailedJobsHistoryLimit'
        /// </summary>
        [Test]
        public void FailedJobsHistoryLimitTest()
        {
            // TODO unit test for the property 'FailedJobsHistoryLimit'
        }
        /// <summary>
        /// Test the property 'JobTemplate'
        /// </summary>
        [Test]
        public void JobTemplateTest()
        {
            // TODO unit test for the property 'JobTemplate'
        }
        /// <summary>
        /// Test the property 'Schedule'
        /// </summary>
        [Test]
        public void ScheduleTest()
        {
            // TODO unit test for the property 'Schedule'
        }
        /// <summary>
        /// Test the property 'StartingDeadlineSeconds'
        /// </summary>
        [Test]
        public void StartingDeadlineSecondsTest()
        {
            // TODO unit test for the property 'StartingDeadlineSeconds'
        }
        /// <summary>
        /// Test the property 'SuccessfulJobsHistoryLimit'
        /// </summary>
        [Test]
        public void SuccessfulJobsHistoryLimitTest()
        {
            // TODO unit test for the property 'SuccessfulJobsHistoryLimit'
        }
        /// <summary>
        /// Test the property 'Suspend'
        /// </summary>
        [Test]
        public void SuspendTest()
        {
            // TODO unit test for the property 'Suspend'
        }

    }

}
