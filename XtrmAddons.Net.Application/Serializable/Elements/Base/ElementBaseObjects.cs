﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace XtrmAddons.Net.Application.Serializable.Elements.Base
{
    /// <summary>
    /// Class XtrmAddons Net Application Serializable Elements Element Base Objects List.
    /// </summary>
    [JsonArray()]
    public class ElementBaseObjects : ElementsBase<ElementBaseObject>
    {
        #region Constructors

        /// <summary>
        /// Class XtrmAddons Net Application Serializable Elements Element Base Objects List.
        /// </summary>
        public ElementBaseObjects() : base() { }

        /// <summary>
        /// Class XtrmAddons Net Application Serializable Elements Element Base Objects List.
        /// </summary>
        /// <param name="capacity">The initial capacity of the list.</param>
        public ElementBaseObjects(int capacity) : base(capacity) { }

        /// <summary>
        /// Class XtrmAddons Net Application Serializable Elements Element Base Objects List.
        /// </summary>
        /// <param name="collection">Collection whose items are copied to the new list.</param>
        public ElementBaseObjects(IEnumerable<ElementBaseObject> collection) : base(collection) { }

        #endregion
    }
}