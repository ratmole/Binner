﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Binner.Common.Models;

namespace Binner.Common.Services
{
    public interface IPartService
    {
        /// <summary>
        /// Add a new part
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        Task<Part> AddPartAsync(Part part);

        /// <summary>
        /// Update an existing part
        /// </summary>
        /// <param name="partNumber"></param>
        /// <returns></returns>
        Task<Part> UpdatePartAsync(Part part);

        /// <summary>
        /// Delete an existing part
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        Task<bool> DeletePartAsync(Part part);

        /// <summary>
        /// Find parts
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        Task<ICollection<SearchResult<Part>>> FindPartsAsync(string keywords);

        /// <summary>
        /// Get a part by part number
        /// </summary>
        /// <param name="partNumber"></param>
        /// <returns></returns>
        Task<Part> GetPartAsync(string partNumber);

        /// <summary>
        /// Get a partType object, or create it if it doesn't exist
        /// </summary>
        /// <param name="partType"></param>
        /// <returns></returns>
        Task<PartType> GetOrCreatePartTypeAsync(string partType);
    }
}