﻿using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace XtrmAddons.Net.Application.Serializable.Elements.Remote
{
    /// <summary>
    /// Class XtrmAddons Net Application Serializable Elements Server Informations.
    /// </summary>
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class Client : RemoteInfo
    {
        /// <summary>
        /// Property type of server.
        /// </summary>
        [XmlAttribute(AttributeName = "Type")]
        [JsonProperty(PropertyName = "Type")]
        public RemoteType Type { get; } = RemoteType.Client;
    }
}