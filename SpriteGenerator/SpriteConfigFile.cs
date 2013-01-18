using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SpriteGenerator
{
    internal class SpriteConfigFile
    {
        private const string SpriteFilePath = "SpriteFilePath";
        private const string CssFilePath = "CssFilePath";
        private const string Layout = "Layout";
        private const string DistanceBetweenImages = "DistanceBetweenImages";
        private const string MarginWidth = "MarginWidth";
        private const string ImagesInRow = "ImagesInRow";
        private const string ImagesInColumn = "ImagesInColumn";
        private const string CssClassPrefix = "CssClassPrefix";


        private readonly string _configFile;
        private readonly string _baseDir;
        private readonly Dictionary<string, string> _settings;
        private readonly List<string> _inputFiles;

        public SpriteConfigFile(string configFile)
        {
            _configFile = Path.GetFullPath(configFile);
            _baseDir = Path.GetDirectoryName(_configFile);
            
            if (!File.Exists(_configFile))
                throw new ArgumentException("Config File does not exist: " + _configFile);

            if (_baseDir == null)
                throw new ArgumentException("Unable to determine base directory: " + _configFile);

            var lines = File.ReadAllLines(_configFile);
            _settings = lines.Where(x => x.StartsWith("#"))
                            .Select(x => x.Substring(1))
                            .ToDictionary(x => x.Split(new[] { '=' }, 2).First(), 
                                          x => x.Split(new[] { '=' }, 2).Last(), 
                                          StringComparer.OrdinalIgnoreCase);

            _inputFiles = lines.Where(x => !x.StartsWith("#")).ToList();
        }

        public LayoutProperties GenerateLayoutProperties()
        {
            var layout = new LayoutProperties
            {
                inputFilePaths = GetInputFiles(),
                outputSpriteFilePath = GetOutputImageFile(),
                outputCssFilePath = GetOutputCssFile(),
                cssClassPrefix = GetStringValueOrDefault(CssClassPrefix, "sprite"),
                layout = GetStringValueOrDefault(Layout, "Automatic"),
                distanceBetweenImages = GetIntValueOrDefault(DistanceBetweenImages, 0),
                marginWidth = GetIntValueOrDefault(MarginWidth, 0),
                imagesInRow = GetIntValueOrDefault(ImagesInRow, 0),
                imagesInColumn = GetIntValueOrDefault(ImagesInColumn, 0)
            };
            return layout;
        }


        private int GetIntValueOrDefault(string keyName, int defaultValue)
        {
            if (_settings.ContainsKey(keyName))
            {
                return Int32.Parse(_settings[keyName]);
            }

            return defaultValue;
        }

        private string GetStringValueOrDefault(string keyName, string defaultValue)
        {
            if (_settings.ContainsKey(keyName))
            {
                return _settings[keyName];
            }

            return defaultValue;
        }

        private string GetOutputCssFile()
        {
            if (_settings.ContainsKey(CssFilePath))
            {
                return Path.GetFullPath(Path.Combine(_baseDir, _settings[CssFilePath]));
            }

            return Path.ChangeExtension(_configFile, "css");
        }

        private string GetOutputImageFile()
        {
            if (_settings.ContainsKey(SpriteFilePath))
            {
                return Path.GetFullPath(Path.Combine(_baseDir, _settings[SpriteFilePath]));
            }

            return Path.ChangeExtension(_configFile, "png");
        }

        private string[] GetInputFiles()
        {
            return _inputFiles.Select(x => Path.GetFullPath(Path.Combine(_baseDir, x))).ToArray();
        }
    }
}