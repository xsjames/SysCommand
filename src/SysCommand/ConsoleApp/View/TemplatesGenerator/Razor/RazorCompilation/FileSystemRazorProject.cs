﻿using Microsoft.AspNetCore.Razor.Language;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SysCommand.ConsoleApp.View.TemplatesGenerator.Razor
{
    internal class FileSystemRazorProject : RazorProject
    {
        public FileSystemRazorProject(string root)
        {
            if (string.IsNullOrEmpty(root))
            {
                throw new ArgumentException("Value cannot be null or an empty string.", nameof(root));
            }

            Root = root.Replace('\\', '/').TrimEnd('/');
        }

        public string Root { get; }

        public override IEnumerable<RazorProjectItem> EnumerateItems(string basePath)
        {
            var absoluteBasePath = NormalizeAndEnsureValidPath(basePath);

            var directory = new DirectoryInfo(absoluteBasePath);
            if (!directory.Exists)
            {
                return Enumerable.Empty<RazorProjectItem>();
            }

            return directory
                .EnumerateFiles("*.cshtml", SearchOption.AllDirectories)
                .Select(file =>
                {
                    var relativePath = file.FullName.Substring(absoluteBasePath.Length).Replace(Path.DirectorySeparatorChar, '/');
                    return new FileSystemRazorProjectItem(basePath, relativePath, file);
                });
        }

        public override RazorProjectItem GetItem(string path)
        {
            var absolutePath = NormalizeAndEnsureValidPath(path);

            return new FileSystemRazorProjectItem("/", path, new FileInfo(absolutePath));
        }

        protected override string NormalizeAndEnsureValidPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Value cannot be null or an empty string.", nameof(path));
            }

            var absolutePath = path;
            if (!absolutePath.StartsWith(Root, StringComparison.OrdinalIgnoreCase))
            {
                if (path[0] == '/' || path[0] == '\\')
                {
                    path = path.Substring(1);
                }

                absolutePath = Path.Combine(Root, path);
            }

            absolutePath = absolutePath.Replace('\\', '/');

            return absolutePath;
        }
    }
}
