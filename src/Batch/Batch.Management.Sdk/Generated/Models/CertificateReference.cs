// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Warning: This object is deprecated and will be removed after February,
    /// 2024. Please use the [Azure KeyVault
    /// Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide)
    /// instead.
    /// </summary>
    /// <remarks>
    /// Warning: This object is deprecated and will be removed after February,
    /// 2024. Please use the [Azure KeyVault
    /// Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide)
    /// instead.
    /// </remarks>
    public partial class CertificateReference
    {
        /// <summary>
        /// Initializes a new instance of the CertificateReference class.
        /// </summary>
        public CertificateReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateReference class.
        /// </summary>

        /// <param name="id">The fully qualified ID of the certificate to install on the pool. This must
        /// be inside the same batch account as the pool.
        /// </param>

        /// <param name="storeLocation">The default value is currentUser. This property is applicable only for
        /// pools configured with Windows nodes (that is, created with
        /// cloudServiceConfiguration, or with virtualMachineConfiguration using a
        /// Windows image reference). For Linux compute nodes, the certificates are
        /// stored in a directory inside the task working directory and an environment
        /// variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for
        /// this location. For certificates with visibility of &#39;remoteUser&#39;, a &#39;certs&#39;
        /// directory is created in the user&#39;s home directory (e.g.,
        /// /home/{user-name}/certs) and certificates are placed in that directory.
        /// Possible values include: &#39;CurrentUser&#39;, &#39;LocalMachine&#39;</param>

        /// <param name="storeName">This property is applicable only for pools configured with Windows nodes
        /// (that is, created with cloudServiceConfiguration, or with
        /// virtualMachineConfiguration using a Windows image reference). Common store
        /// names include: My, Root, CA, Trust, Disallowed, TrustedPeople,
        /// TrustedPublisher, AuthRoot, AddressBook, but any custom store name can also
        /// be used. The default value is My.
        /// </param>

        /// <param name="visibility">Which user accounts on the compute node should have access to the private
        /// data of the certificate.
        /// </param>
        public CertificateReference(string id, CertificateStoreLocation? storeLocation = default(CertificateStoreLocation?), string storeName = default(string), System.Collections.Generic.IList<CertificateVisibility> visibility = default(System.Collections.Generic.IList<CertificateVisibility>))

        {
            this.Id = id;
            this.StoreLocation = storeLocation;
            this.StoreName = storeName;
            this.Visibility = visibility;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the fully qualified ID of the certificate to install on the
        /// pool. This must be inside the same batch account as the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }

        /// <summary>
        /// Gets or sets the default value is currentUser. This property is applicable
        /// only for pools configured with Windows nodes (that is, created with
        /// cloudServiceConfiguration, or with virtualMachineConfiguration using a
        /// Windows image reference). For Linux compute nodes, the certificates are
        /// stored in a directory inside the task working directory and an environment
        /// variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for
        /// this location. For certificates with visibility of &#39;remoteUser&#39;, a &#39;certs&#39;
        /// directory is created in the user&#39;s home directory (e.g.,
        /// /home/{user-name}/certs) and certificates are placed in that directory. Possible values include: &#39;CurrentUser&#39;, &#39;LocalMachine&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storeLocation")]
        public CertificateStoreLocation? StoreLocation {get; set; }

        /// <summary>
        /// Gets or sets this property is applicable only for pools configured with
        /// Windows nodes (that is, created with cloudServiceConfiguration, or with
        /// virtualMachineConfiguration using a Windows image reference). Common store
        /// names include: My, Root, CA, Trust, Disallowed, TrustedPeople,
        /// TrustedPublisher, AuthRoot, AddressBook, but any custom store name can also
        /// be used. The default value is My.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storeName")]
        public string StoreName {get; set; }

        /// <summary>
        /// Gets or sets which user accounts on the compute node should have access to
        /// the private data of the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "visibility")]
        public System.Collections.Generic.IList<CertificateVisibility> Visibility {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }




        }
    }
}