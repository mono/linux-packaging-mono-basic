// AspLogTest.cs - NUnit Test Cases for Microsoft.VisualBasic.Logging.AspLog
//
// Rolf Bjarne Kvinge  (RKvinge@novell.com)
//
// 
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#if NET_2_0 && mono_not_yet
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Microsoft.VisualBasic.Logging;

namespace MonoTests.Microsoft_VisualBasic.Logging
{
	[TestFixture]
	public class AspLogTest
	{
		[Test]
		public void TestDefaults ()
		{
			AspLog log = new AspLog ();
			Assert.IsNull (log.DefaultFileLogWriter, "#01");
			Assert.AreEqual ("DefaultSource", log.TraceSource.Name, "#02");
			Assert.AreEqual (2, log.TraceSource.Listeners.Count, "#03");
			Assert.AreEqual ("Default", Helper.getObjects<System.Diagnostics.TraceListener> (log.TraceSource.Listeners) [0].Name, "#04");
			Assert.AreEqual ("", Helper.getObjects<System.Diagnostics.TraceListener> (log.TraceSource.Listeners) [1].Name, "#05");
			Assert.AreEqual ("DefaultTraceListener", Helper.getObjects<System.Diagnostics.TraceListener> (log.TraceSource.Listeners) [0].GetType ().Name, "#06");
			Assert.AreEqual ("WebPageTraceListener", Helper.getObjects<System.Diagnostics.TraceListener> (log.TraceSource.Listeners) [1].GetType ().Name, "#07");
			Assert.AreEqual (System.Diagnostics.SourceLevels.Information, log.TraceSource.Switch.Level, "#08");
		}
	}
}
#endif