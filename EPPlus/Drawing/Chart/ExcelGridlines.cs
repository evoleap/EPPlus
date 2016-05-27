﻿/*******************************************************************************
 * You may amend and distribute as you like, but don't remove this header!
 *
 * EPPlus provides server-side generation of Excel 2007/2010 spreadsheets.
 * See http://www.codeplex.com/EPPlus for details.
 *
 * Copyright (C) 2011  Jan Källman
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.

 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
 * See the GNU Lesser General Public License for more details.
 *
 * The GNU Lesser General Public License can be viewed at http://www.opensource.org/licenses/lgpl-license.php
 * If you unfamiliar with this license or have questions about it, here is an http://www.gnu.org/licenses/gpl-faq.html
 *
 * All code and executables are provided "as is" with no warranty either express or implied. 
 * The author accepts no liability for any damage or loss of business that this product may cause.
 *
 * Code change notes:
 * 
 * Author							Change						Date
 *******************************************************************************
 * Kenny Nygaard		Added		 2016-05-27
 *******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace OfficeOpenXml.Drawing.Chart
{
    public sealed class ExcelGridlines : XmlHelper
    {
        string _linePath;

        internal ExcelGridlines(XmlNamespaceManager nameSpaceManager, XmlNode topNode, string linePath) :
            base(nameSpaceManager, topNode)
        {
            SchemaNodeOrder = new string[] { "spPr" };
            _linePath = linePath;
            _lineBorderPath = string.Format(_lineBorderPath, _linePath);
        }

        ExcelDrawingBorder _line = null;
        string _lineBorderPath = "{0}/c:spPr/a:ln";
        /// <summary>
        /// Line style options.
        /// </summary>
        public ExcelDrawingBorder Line
        {
            get
            {
                if (_line == null)
                    _line = new ExcelDrawingBorder(NameSpaceManager, TopNode, _lineBorderPath);
                return _line;
            }
        }

    }
}
