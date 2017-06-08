﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNetNuke.Services.Search.Entities;

namespace DotNetNuke.Services.Search.Controllers
{
    /// <summary>
    /// Module can optionally specify custom behavior to provide Permission and Url Services. 
    /// </summary>
    /// <remarks>This is needed only when Module wants additional capabilities on top of what Core already performs.</remarks>
    public interface IModuleSearchResultController
    {
        /// <summary>
        /// Does the user in the Context have View Permission on the Document
        /// </summary>
        /// <param name="searchResult">Search Result</param>
        /// <returns>True or False</returns>
        bool HasViewPermission(SearchResult searchResult);

        /// <summary>
        /// Return a Url that can be shown in search results.
        /// </summary>
        /// <param name="searchResult">Search Result</param>
        /// <returns>Url</returns>
        /// <remarks>The Query Strings in the Document (if present) should be appended while returning the Url</remarks>
        string GetDocUrl(SearchResult searchResult);
    }
}
