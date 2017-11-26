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
    ///  Class for testing V1PersistentVolumeSpec
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class V1PersistentVolumeSpecTests
    {
        // TODO uncomment below to declare an instance variable for V1PersistentVolumeSpec
        //private V1PersistentVolumeSpec instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of V1PersistentVolumeSpec
            //instance = new V1PersistentVolumeSpec();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V1PersistentVolumeSpec
        /// </summary>
        [Test]
        public void V1PersistentVolumeSpecInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" V1PersistentVolumeSpec
            //Assert.IsInstanceOfType<V1PersistentVolumeSpec> (instance, "variable 'instance' is a V1PersistentVolumeSpec");
        }

        /// <summary>
        /// Test the property 'AccessModes'
        /// </summary>
        [Test]
        public void AccessModesTest()
        {
            // TODO unit test for the property 'AccessModes'
        }
        /// <summary>
        /// Test the property 'AwsElasticBlockStore'
        /// </summary>
        [Test]
        public void AwsElasticBlockStoreTest()
        {
            // TODO unit test for the property 'AwsElasticBlockStore'
        }
        /// <summary>
        /// Test the property 'AzureDisk'
        /// </summary>
        [Test]
        public void AzureDiskTest()
        {
            // TODO unit test for the property 'AzureDisk'
        }
        /// <summary>
        /// Test the property 'AzureFile'
        /// </summary>
        [Test]
        public void AzureFileTest()
        {
            // TODO unit test for the property 'AzureFile'
        }
        /// <summary>
        /// Test the property 'Capacity'
        /// </summary>
        [Test]
        public void CapacityTest()
        {
            // TODO unit test for the property 'Capacity'
        }
        /// <summary>
        /// Test the property 'Cephfs'
        /// </summary>
        [Test]
        public void CephfsTest()
        {
            // TODO unit test for the property 'Cephfs'
        }
        /// <summary>
        /// Test the property 'Cinder'
        /// </summary>
        [Test]
        public void CinderTest()
        {
            // TODO unit test for the property 'Cinder'
        }
        /// <summary>
        /// Test the property 'ClaimRef'
        /// </summary>
        [Test]
        public void ClaimRefTest()
        {
            // TODO unit test for the property 'ClaimRef'
        }
        /// <summary>
        /// Test the property 'Fc'
        /// </summary>
        [Test]
        public void FcTest()
        {
            // TODO unit test for the property 'Fc'
        }
        /// <summary>
        /// Test the property 'FlexVolume'
        /// </summary>
        [Test]
        public void FlexVolumeTest()
        {
            // TODO unit test for the property 'FlexVolume'
        }
        /// <summary>
        /// Test the property 'Flocker'
        /// </summary>
        [Test]
        public void FlockerTest()
        {
            // TODO unit test for the property 'Flocker'
        }
        /// <summary>
        /// Test the property 'GcePersistentDisk'
        /// </summary>
        [Test]
        public void GcePersistentDiskTest()
        {
            // TODO unit test for the property 'GcePersistentDisk'
        }
        /// <summary>
        /// Test the property 'Glusterfs'
        /// </summary>
        [Test]
        public void GlusterfsTest()
        {
            // TODO unit test for the property 'Glusterfs'
        }
        /// <summary>
        /// Test the property 'HostPath'
        /// </summary>
        [Test]
        public void HostPathTest()
        {
            // TODO unit test for the property 'HostPath'
        }
        /// <summary>
        /// Test the property 'Iscsi'
        /// </summary>
        [Test]
        public void IscsiTest()
        {
            // TODO unit test for the property 'Iscsi'
        }
        /// <summary>
        /// Test the property 'Local'
        /// </summary>
        [Test]
        public void LocalTest()
        {
            // TODO unit test for the property 'Local'
        }
        /// <summary>
        /// Test the property 'Nfs'
        /// </summary>
        [Test]
        public void NfsTest()
        {
            // TODO unit test for the property 'Nfs'
        }
        /// <summary>
        /// Test the property 'PersistentVolumeReclaimPolicy'
        /// </summary>
        [Test]
        public void PersistentVolumeReclaimPolicyTest()
        {
            // TODO unit test for the property 'PersistentVolumeReclaimPolicy'
        }
        /// <summary>
        /// Test the property 'PhotonPersistentDisk'
        /// </summary>
        [Test]
        public void PhotonPersistentDiskTest()
        {
            // TODO unit test for the property 'PhotonPersistentDisk'
        }
        /// <summary>
        /// Test the property 'PortworxVolume'
        /// </summary>
        [Test]
        public void PortworxVolumeTest()
        {
            // TODO unit test for the property 'PortworxVolume'
        }
        /// <summary>
        /// Test the property 'Quobyte'
        /// </summary>
        [Test]
        public void QuobyteTest()
        {
            // TODO unit test for the property 'Quobyte'
        }
        /// <summary>
        /// Test the property 'Rbd'
        /// </summary>
        [Test]
        public void RbdTest()
        {
            // TODO unit test for the property 'Rbd'
        }
        /// <summary>
        /// Test the property 'ScaleIO'
        /// </summary>
        [Test]
        public void ScaleIOTest()
        {
            // TODO unit test for the property 'ScaleIO'
        }
        /// <summary>
        /// Test the property 'StorageClassName'
        /// </summary>
        [Test]
        public void StorageClassNameTest()
        {
            // TODO unit test for the property 'StorageClassName'
        }
        /// <summary>
        /// Test the property 'Storageos'
        /// </summary>
        [Test]
        public void StorageosTest()
        {
            // TODO unit test for the property 'Storageos'
        }
        /// <summary>
        /// Test the property 'VsphereVolume'
        /// </summary>
        [Test]
        public void VsphereVolumeTest()
        {
            // TODO unit test for the property 'VsphereVolume'
        }

    }

}