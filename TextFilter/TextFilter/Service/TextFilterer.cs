using System;
using System.Collections.Generic;
using System.Text;
using TextFilter.DataAccess.Repositories;

namespace TextFilter.Service
{
    internal class TextFilterService : ITextFilterable
    {
        /// <summary>
        /// Repository object to read/write to/from.
        /// </summary>
        IRepository repository;

        /// <summary>
        /// Text filter service that performs filtering of text.
        /// </summary>
        /// <param name="repository">Repository to read/write to/from.</param>
        internal TextFilterService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Performs the filtering of the text read from the repository, updates the repository with the filtered text.
        /// </summary>
        /// <returns>Success response.</returns>
        public bool PerformFilters()
        {
            string text = repository.Read();

            // Return success/failure based on whether the text was successfully read, filtered and updated.
            return repository.Update(text);
        }
    }
}
