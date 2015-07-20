﻿/*
Code creator: flagbug (https://github.com/flagbug)
Website: https://github.com/flagbug/YoutubeExtractor
License:

The MIT License (MIT)
Copyright (c) flagbug

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
    */

using System;

namespace Hurricane.Services.YouTube.Extractor
{
    /// <summary>
    /// <para>
    /// The exception that is thrown when the YouTube page could not be parsed.
    /// This happens, when YouTube changes the structure of their page.
    /// </para>
    /// Please report when this exception happens at www.github.com/flagbug/YoutubeExtractor/issues
    /// </summary>
    class YoutubeParseException : Exception
    {
        public YoutubeParseException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
