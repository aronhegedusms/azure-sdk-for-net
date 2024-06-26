// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Description of name availability. </summary>
    public partial class DeviceProvisioningServicesNameAvailabilityResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesNameAvailabilityResult"/>. </summary>
        internal DeviceProvisioningServicesNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> specifies if a name is available or not. </param>
        /// <param name="reason"> specifies the reason a name is unavailable. </param>
        /// <param name="message"> message containing a detailed reason name is unavailable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceProvisioningServicesNameAvailabilityResult(bool? isNameAvailable, DeviceProvisioningServicesNameUnavailableReason? reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> specifies if a name is available or not. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> specifies the reason a name is unavailable. </summary>
        public DeviceProvisioningServicesNameUnavailableReason? Reason { get; }
        /// <summary> message containing a detailed reason name is unavailable. </summary>
        public string Message { get; }
    }
}
