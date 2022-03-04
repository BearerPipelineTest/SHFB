﻿//===============================================================================================================
// System  : Sandcastle Tools - Sandcastle Tools Core Class Library
// File    : MediaLinkInlineElement.cs
// Author  : Eric Woodruff  (Eric@EWoodruff.us)
// Updated : 01/24/2022
// Note    : Copyright 2022, Eric Woodruff, All rights reserved
//
// This file contains the class used to handle mediaLinkInline elements
//
// This code is published under the Microsoft Public License (Ms-PL).  A copy of the license should be
// distributed with the code and can be found at the project website: https://GitHub.com/EWSoftware/SHFB.  This
// notice, the author's name, and all copyright notices must remain intact in all applications, documentation,
// and source files.
//
//    Date     Who  Comments
// ==============================================================================================================
// 01/24/2022  EFW  Created the code
//===============================================================================================================

using System;
using System.Xml.Linq;

namespace Sandcastle.Core.PresentationStyle.Transformation.Elements.Html
{
    /// <summary>
    /// This handles <c>mediaLinkInline</c> elements
    /// </summary>
    public class MediaLinkInlineElement : Element
    {
        /// <inheritdoc />
        public MediaLinkInlineElement() : base("mediaLinkInline")
        {
        }

        /// <inheritdoc />
        public override void Render(TopicTransformationCore transformation, XElement element)
        {
            if(transformation == null)
                throw new ArgumentNullException(nameof(transformation));

            if(element == null)
                throw new ArgumentNullException(nameof(element));

            string linkTarget = element.Element(Ddue + "image")?.Attribute(Xlink + "href")?.Value;

            if(!String.IsNullOrWhiteSpace(linkTarget))
            {
                var link = new XElement("span",
                        transformation.StyleAttributeFor(CommonStyle.Media),
                    new XElement("artLink",
                        new XAttribute("target", linkTarget)));

                transformation.CurrentElement.Add(link);
            }
        }
    }
}
