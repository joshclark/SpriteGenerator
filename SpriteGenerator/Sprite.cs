﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using SpriteGenerator.Utility;

namespace SpriteGenerator
{
    class Sprite
    {
        private Dictionary<int, Image> images;
        private Dictionary<int, string> cssClassNames;
        private LayoutProperties layoutProp;

        public Sprite(LayoutProperties _layoutProp)
        {
            images = new Dictionary<int, Image>();
            cssClassNames = new Dictionary<int, string>();
            layoutProp = _layoutProp;
        }

        public void Create()
        {
            GetData(out images, out cssClassNames);

            EnsureDirectoryExists(layoutProp.outputCssFilePath);
            StreamWriter cssFile = File.CreateText(layoutProp.outputCssFilePath);
            Image resultSprite = null;

            var spriteImagePath = relativeSpriteImagePath(layoutProp.outputSpriteFilePath, layoutProp.outputCssFilePath);
            var backgroundCss = String.Format("background: url('{0}') transparent no-repeat;", spriteImagePath);

            switch (layoutProp.layout)
            {
                case "Automatic":
                    resultSprite = generateAutomaticLayout(cssFile, backgroundCss);
                    break;
                case "Horizontal":
                    resultSprite = generateHorizontalLayout(cssFile, backgroundCss);
                    break;
                case "Vertical":
                    resultSprite = generateVerticalLayout(cssFile, backgroundCss);
                    break;
                case "Rectangular":
                    resultSprite = generateRectangularLayout(cssFile, backgroundCss);
                    break;
                default:
                    break;
            }

            cssFile.Close();

            EnsureDirectoryExists(layoutProp.outputSpriteFilePath);
            FileStream outputSpriteFile = new FileStream(layoutProp.outputSpriteFilePath, FileMode.Create);
            resultSprite.Save(outputSpriteFile, ImageFormat.Png);
            outputSpriteFile.Close();
        }

        private void EnsureDirectoryExists(string file)
        {
            var dir = Path.GetDirectoryName(file);
            if ((dir != null) && (!Directory.Exists(dir)))
                Directory.CreateDirectory(dir);
        }

        /// <summary>
        /// Creates dictionary of images from the given paths and dictionary of CSS classnames from the image filenames.
        /// </summary> 
        /// <param name="inputFilePaths">Array of input file paths.</param>
        /// <param name="images">Dictionary of images to be inserted into the output sprite.</param>
        /// <param name="cssClassNames">Dictionary of CSS classnames.</param>
        private void GetData(out Dictionary<int, Image> images, out Dictionary<int, string> cssClassNames)
        {
            images = new Dictionary<int, Image>();
            cssClassNames = new Dictionary<int, string>();

            var prefix = String.IsNullOrEmpty(layoutProp.cssClassPrefix) ? String.Empty : layoutProp.cssClassPrefix + "-";

            for (int i = 0; i < layoutProp.inputFilePaths.Length; i++)
            {
                Image img = Image.FromFile(layoutProp.inputFilePaths[i]);
                images.Add(i, img);

                var filename = Path.GetFileNameWithoutExtension(layoutProp.inputFilePaths[i]);
                var outputFileName = Path.GetFileNameWithoutExtension(layoutProp.outputCssFilePath);
                var cssName = String.Format("{0}{1}-{2}", prefix, outputFileName, filename);
                cssClassNames.Add(i, cssName);
            }
        }

        private List<Module> CreateModules()
        {
            List<Module> modules = new List<Module>();
            foreach (int i in images.Keys)
                modules.Add(new Module(i, images[i], layoutProp.distanceBetweenImages));
            return modules;
        }

        //CSS line
        private string CssLine(string cssClassName, Rectangle rectangle, string backgroundCss)
        {
            string line = "." + cssClassName + " { " + backgroundCss + " width: " + rectangle.Width.ToString() + "px; height: " + rectangle.Height.ToString() + 
                "px; background-position: " + (-1 * rectangle.X).ToString() + "px " + (-1 * rectangle.Y).ToString() + "px; }";
            return line;
        }

        //Relative sprite image file path
        private string relativeSpriteImagePath(string outputSpriteFilePath, string outputCssFilePath)
        {
            string[] splittedOutputCssFilePath = outputCssFilePath.Split('\\');
            string[] splittedOutputSpriteFilePath = outputSpriteFilePath.Split('\\');

            int breakAt = 0;
            for (int i = 0; i < splittedOutputCssFilePath.Length; i++)
                if (i < splittedOutputSpriteFilePath.Length && splittedOutputCssFilePath[i] != splittedOutputSpriteFilePath[i])
                {
                    breakAt = i;
                    break;
                }

            string relativePath = "";
            for (int i = 0; i < splittedOutputCssFilePath.Length - breakAt - 1; i++)
                relativePath += "../";
            relativePath += String.Join("/", splittedOutputSpriteFilePath, breakAt, splittedOutputSpriteFilePath.Length - breakAt);

            return relativePath;
        }

        //Automatic layout
        private Image generateAutomaticLayout(StreamWriter cssFile, string backgroundCss)
        {
            var sortedByArea = from m in CreateModules()
                               orderby m.Width * m.Height descending
                               select m;
            List<Module> moduleList = sortedByArea.ToList<Module>();
            Placement placement = Algorithm.Greedy(moduleList);

            //Creating an empty result image.
            Image resultSprite = new Bitmap(placement.Width - layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth,
                placement.Height - layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth);
            Graphics graphics = Graphics.FromImage(resultSprite);
            
            //Drawing images into the result image in the original order and writing CSS lines.
            foreach (Module m in placement.Modules)
            {
                m.Draw(graphics, layoutProp.marginWidth);
                Rectangle rectangle = new Rectangle(m.X + layoutProp.marginWidth, m.Y + layoutProp.marginWidth,
                    m.Width - layoutProp.distanceBetweenImages, m.Height - layoutProp.distanceBetweenImages);
                cssFile.WriteLine(CssLine(cssClassNames[m.Name], rectangle, backgroundCss));
            }

            return resultSprite;
        }

        //Horizontal layout
        private Image generateHorizontalLayout(StreamWriter cssFile, string backgroundCss)
        {
            //Calculating result image dimension.
            int width = 0;
            foreach (Image image in images.Values)
                width += image.Width + layoutProp.distanceBetweenImages;
            width = width - layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth;
            int height = images[0].Height + 2 * layoutProp.marginWidth;

            //Creating an empty result image.
            Image resultSprite = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultSprite);
            
            //Initial coordinates.
            int actualXCoordinate = layoutProp.marginWidth;
            int yCoordinate = layoutProp.marginWidth;

            //Drawing images into the result image, writing CSS lines and increasing X coordinate.
            foreach(int i in images.Keys)
            {
                Rectangle rectangle = new Rectangle(actualXCoordinate, yCoordinate, images[i].Width, images[i].Height);
                graphics.DrawImage(images[i], rectangle);
                cssFile.WriteLine(CssLine(cssClassNames[i], rectangle, backgroundCss));
                actualXCoordinate += images[i].Width + layoutProp.distanceBetweenImages;
            }

            return resultSprite;
        }

        //Vertical layout
        private Image generateVerticalLayout(StreamWriter cssFile, string backgroundCss)
        {
            //Calculating result image dimension.
            int height = 0;
            foreach (Image image in images.Values)
                height += image.Height + layoutProp.distanceBetweenImages;
            height = height - layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth;
            int width = images[0].Width + 2 * layoutProp.marginWidth;

            //Creating an empty result image.
            Image resultSprite = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultSprite);
            
            //Initial coordinates.
            int actualYCoordinate = layoutProp.marginWidth;
            int xCoordinate = layoutProp.marginWidth;

            //Drawing images into the result image, writing CSS lines and increasing Y coordinate.
            foreach (int i in images.Keys)
            {
                Rectangle rectangle = new Rectangle(xCoordinate, actualYCoordinate, images[i].Width, images[i].Height);
                graphics.DrawImage(images[i], rectangle);
                cssFile.WriteLine(CssLine(cssClassNames[i], rectangle, backgroundCss));
                actualYCoordinate += images[i].Height + layoutProp.distanceBetweenImages;
            }

            return resultSprite;
        }

        private Image generateRectangularLayout(StreamWriter CSSFile, string backgroundCss)
        {
            //Calculating result image dimension.
            int imageWidth = images[0].Width;
            int imageHeight = images[0].Height;
            int width = layoutProp.imagesInRow * (imageWidth + layoutProp.distanceBetweenImages) -
                layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth;
            int height = layoutProp.imagesInColumn * (imageHeight + layoutProp.distanceBetweenImages) -
                layoutProp.distanceBetweenImages + 2 * layoutProp.marginWidth;

            //Creating an empty result image.
            Image resultSprite = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resultSprite);

            //Initial coordinates.
            int actualYCoordinate = layoutProp.marginWidth;
            int actualXCoordinate = layoutProp.marginWidth;

            //Drawing images into the result image, writing CSS lines and increasing coordinates.
            for (int i = 0; i < layoutProp.imagesInColumn; i++)
            {
                for (int j = 0; (i * layoutProp.imagesInRow) + j < images.Count && j < layoutProp.imagesInRow; j++)
                {
                    Rectangle rectangle = new Rectangle(actualXCoordinate, actualYCoordinate, imageWidth, imageHeight);
                    graphics.DrawImage(images[i * layoutProp.imagesInRow + j], rectangle);
                    CSSFile.WriteLine(CssLine(cssClassNames[i * layoutProp.imagesInRow + j], rectangle, backgroundCss));
                    actualXCoordinate += imageWidth + layoutProp.distanceBetweenImages;
                }
                actualYCoordinate += imageHeight + layoutProp.distanceBetweenImages;
                actualXCoordinate = layoutProp.marginWidth;
            }

            return resultSprite;
        }
    }
}
