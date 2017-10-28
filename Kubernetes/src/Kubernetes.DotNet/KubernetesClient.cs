﻿using System;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;

namespace Kubernetes.DotNet
{
    /// <summary>
    /// The implemetation of <see cref="IKubernetesClient"/> to interact with provided K8s Remote APIs.
    /// </summary>
    public class KubernetesClient : IKubernetesClient
    {
        /// <summary>
        /// The <see cref="KubernetesClientConfiguration"/>.
        /// </summary>
        public KubernetesClientConfiguration Configuration { get; }

        /// <summary>
        /// The admissions control API endpoint.
        /// </summary>
        public IAdmissionregistrationApi AdmissionregistrationApi { get; }

        /// <summary>
        /// The registration API endpoint.
        /// </summary>
        public IApiregistration_v1beta1Api ApiRegistrationApi { get; }

        /// <summary>
        /// The Apps API endpoint.
        /// </summary>
        public IApps_v1beta1Api AppsApi { get; }

        /// <summary>
        /// The authentication API endpoint.
        /// </summary>
        public IAuthentication_v1Api AuthenticationApi { get; }

        /// <summary>
        /// The authorization API endpoint.
        /// </summary>
        public IAuthorization_v1Api AuthorizationApi { get; }

        /// <summary>
        /// The autoscaling API endpoint.
        /// </summary>
        public IAutoscaling_v1Api AutoscalingApi { get; }

        /// <summary>
        /// The batch API endpoint.
        /// </summary>
        public IBatch_v1Api BatchApi { get; }

        /// <summary>
        /// The certificates API endpoint.
        /// </summary>
        public ICertificates_v1beta1Api CertificatesApi { get; }

        /// <summary>
        /// The core API endpoint.
        /// </summary>
        public ICore_v1Api CoreApi { get; }

        /// <summary>
        /// The extensions API endpoint.
        /// </summary>
        public IExtensions_v1beta1Api ExtensionsApi { get; }

        /// <summary>
        /// The logs API endpoint.
        /// </summary>
        public ILogsApi LogsApi { get; }

        /// <summary>
        /// The networking API endpoint.
        /// </summary>
        public INetworking_v1Api NetworkingApi { get; }

        /// <summary>
        /// The policy API endpoint.
        /// </summary>
        public IPolicy_v1beta1Api PolicyApi { get; }

        /// <summary>
        /// The role based control authorization API endpoint.
        /// </summary>
        public IRbacAuthorization_v1beta1Api RbacAuthorizationApi { get; }

        /// <summary>
        /// The settings API endpoint.
        /// </summary>
        public ISettingsApi SettingsApi { get; }

        /// <summary>
        /// The storage API endpoint.
        /// </summary>
        public IStorage_v1Api StorageApi { get; }

        /// <summary>
        /// The version API endpoint.
        /// </summary>
        public IVersionApi VersionApi { get; }
        
        /// <summary>
        /// The internal <see cref="KubernetesClient"/> ctr.
        /// </summary>
        /// <param name="configuration">The <see cref="KubernetesClientConfiguration"/>.</param>
        internal KubernetesClient(KubernetesClientConfiguration configuration)
        {
            if (null == configuration)
                throw new ApplicationException($"Missing required argument {nameof(configuration)}");
            this.Configuration = configuration;

            // Set up the http client
            ApiClient httpClient = new ApiClient(configuration.MasterUrl);

            // Initialize endpoints
            this.ApiRegistrationApi = new Apiregistration_v1beta1Api(configuration.MasterUrl);
            this.AppsApi = new Apps_v1beta1Api(configuration.MasterUrl);
            this.AuthenticationApi = new Authentication_v1Api(configuration.MasterUrl);
            this.AuthorizationApi = new Authorization_v1Api(configuration.MasterUrl);
            this.AutoscalingApi = new Autoscaling_v1Api(configuration.MasterUrl);
            this.BatchApi = new Batch_v1Api(configuration.MasterUrl);
            this.CertificatesApi = new Certificates_v1beta1Api(configuration.MasterUrl);
            this.CoreApi = new Core_v1Api(configuration.MasterUrl);
            this.ExtensionsApi = new Extensions_v1beta1Api(configuration.MasterUrl);
            this.LogsApi = new LogsApi(configuration.MasterUrl);
            this.NetworkingApi = new Networking_v1Api(configuration.MasterUrl);
            this.PolicyApi = new Policy_v1beta1Api(configuration.MasterUrl);
            this.RbacAuthorizationApi = new RbacAuthorization_v1beta1Api(configuration.MasterUrl);
            this.StorageApi = new Storage_v1Api(configuration.MasterUrl);
            this.VersionApi = new VersionApi(configuration.MasterUrl);
        }
    }
}