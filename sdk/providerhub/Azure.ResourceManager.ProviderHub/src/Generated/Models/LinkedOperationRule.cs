// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The LinkedOperationRule. </summary>
    public partial class LinkedOperationRule
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

        /// <summary> Initializes a new instance of <see cref="LinkedOperationRule"/>. </summary>
        /// <param name="linkedOperation"></param>
        /// <param name="linkedAction"></param>
        internal LinkedOperationRule(LinkedOperation linkedOperation, LinkedAction linkedAction)
        {
            LinkedOperation = linkedOperation;
            LinkedAction = linkedAction;
        }

        /// <summary> Initializes a new instance of <see cref="LinkedOperationRule"/>. </summary>
        /// <param name="linkedOperation"></param>
        /// <param name="linkedAction"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkedOperationRule(LinkedOperation linkedOperation, LinkedAction linkedAction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LinkedOperation = linkedOperation;
            LinkedAction = linkedAction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LinkedOperationRule"/> for deserialization. </summary>
        internal LinkedOperationRule()
        {
        }

        /// <summary> Gets the linked operation. </summary>
        public LinkedOperation LinkedOperation { get; }
        /// <summary> Gets the linked action. </summary>
        public LinkedAction LinkedAction { get; }
    }
}
