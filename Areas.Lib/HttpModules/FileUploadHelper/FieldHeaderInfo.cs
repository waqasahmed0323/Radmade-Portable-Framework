﻿namespace Areas.Lib.HttpModules.FileUploadHelper
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class FieldHeaderInfo
    {
        private byte[] _content;
        private string _contentAsString;
        private Encoding _encoding;
        private string _fieldName;

        public FieldHeaderInfo(byte[] headerContent, Encoding encoding)
        {
            this._content = headerContent;
            this._encoding = encoding;
        }

        public byte[] Content
        {
            get
            {
                return this._content;
            }
        }

        public string ContentAsString
        {
            get
            {
                if (this._contentAsString == null)
                {
                    this._contentAsString = this._encoding.GetString(this.Content);
                }
                return this._contentAsString;
            }
        }

        public string FieldName
        {
            get
            {
                if (this._fieldName == null)
                {
                    Regex regex = new Regex("\\bname=(\"?)([^;\\r\\n]*)\\1", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    this._fieldName = regex.Match(this.ContentAsString).Groups[2].Value;
                }
                return this._fieldName;
            }
        }
    }
}