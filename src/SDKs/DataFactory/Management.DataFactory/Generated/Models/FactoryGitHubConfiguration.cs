// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Factory's GitHub repo information.
    /// </summary>
    public partial class FactoryGitHubConfiguration : FactoryRepoConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the FactoryGitHubConfiguration class.
        /// </summary>
        public FactoryGitHubConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FactoryGitHubConfiguration class.
        /// </summary>
        /// <param name="accountName">Account name.</param>
        /// <param name="repositoryName">Rrepository name.</param>
        /// <param name="collaborationBranch">Collaboration branch.</param>
        /// <param name="rootFolder">Root folder.</param>
        /// <param name="lastCommitId">Last commit id.</param>
        /// <param name="hostName">GitHub Enterprise host name. For example:
        /// https://github.mydomain.com</param>
        public FactoryGitHubConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId = default(string), string hostName = default(string))
            : base(accountName, repositoryName, collaborationBranch, rootFolder, lastCommitId)
        {
            HostName = hostName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets gitHub Enterprise host name. For example:
        /// https://github.mydomain.com
        /// </summary>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}