﻿using Newtonsoft.Json;
using System;

namespace XtrmAddons.Net.Application.Serializable.Elements.Data
{
    /// <summary>
    /// Class XtrmAddons Net Application Serializable Elements Data Options.
    /// </summary>
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class DataOptions
    {
        #region Properties

        /// <summary>
        /// Property to access to the list of databases informations.
        /// </summary>
        [JsonProperty(PropertyName = "Databases")]
        public Databases Databases { get; set; }

        #endregion



        #region Constructors

        /// <summary>
        /// Class XtrmAddons Net Application Serializable Elements Data Options Constructor.
        /// </summary>
        public DataOptions()
        {
            Databases = new Databases();
        }

        #endregion
    }
}