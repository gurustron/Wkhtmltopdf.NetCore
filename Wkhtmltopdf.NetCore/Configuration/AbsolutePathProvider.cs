﻿namespace Wkhtmltopdf.NetCore
{
    /// <summary>
    /// Provides absolute path to wkthmltopdf/wkthmltoimage.
    /// </summary>
    public class AbsolutePathProvider : IWkhtmltopdfPathProvider
    {
        private readonly string _path;

        /// <summary>
        /// Constructs <see cref="AbsolutePathProvider"/>.
        /// </summary>
        /// <param name="path">Absolute path to wkthmltopdf/wkthmltoimage.</param>
        public AbsolutePathProvider(string path)
        {
            _path = path;
        }

        public string GetPath() => _path;
    }
}