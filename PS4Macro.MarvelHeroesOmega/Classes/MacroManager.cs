﻿// PS4Macro.MarvelHeroesOmega (File: Classes/MacroManager.cs)
//
// Copyright (c) 2017 Komefai
//
// Visit http://komefai.com for more information
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS4Macro.MarvelHeroesOmega
{
    public class MacroManager
    {
        #region Singleton
        private static MacroManager instance;
        public static MacroManager Instance => instance ?? (instance = new MacroManager());
        #endregion

        public const string KEY_STARTUP = "Startup";
        public const string KEY_PREPARE_COMBAT = "PrepareCombat";

        public Dictionary<string, string> PathDictionary { get; set; }

        private MacroManager()
        {
            PathDictionary = new Dictionary<string, string>()
            {
                { KEY_STARTUP, null },
                { KEY_PREPARE_COMBAT, null }
            };
        }

        public bool Exist(string key)
        {
            return PathDictionary.ContainsKey(key) && PathDictionary[key] != null;
        }
    }
}
