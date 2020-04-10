// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Monitor PrivateLinkScope definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AzureMonitorPrivateLinkScope : PrivateLinkScopesResource
    {
        /// <summary>
        /// Initializes a new instance of the AzureMonitorPrivateLinkScope
        /// class.
        /// </summary>
        public AzureMonitorPrivateLinkScope()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMonitorPrivateLinkScope
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Current state of this
        /// PrivateLinkScope: whether or not is has been provisioned within the
        /// resource group it is defined. Users cannot change this value but
        /// are able to read from it. Values will include Provisioning
        /// ,Succeeded, Canceled and Failed.</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections.</param>
        public AzureMonitorPrivateLinkScope(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets current state of this PrivateLinkScope: whether or not is has
        /// been provisioned within the resource group it is defined. Users
        /// cannot change this value but are able to read from it. Values will
        /// include Provisioning ,Succeeded, Canceled and Failed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets list of private endpoint connections.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (PrivateEndpointConnections != null)
            {
                foreach (var element in PrivateEndpointConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}