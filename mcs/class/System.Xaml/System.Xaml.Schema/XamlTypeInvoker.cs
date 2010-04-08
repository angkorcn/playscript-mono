//
// Copyright (C) 2010 Novell Inc. http://novell.com
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Markup;

namespace System.Xaml.Schema
{
	public class XamlTypeInvoker
	{
		public static XamlTypeInvoker UnknownInvoker {
			get { throw new NotImplementedException (); }
		}

		protected XamlTypeInvoker ()
		{
			throw new NotImplementedException ();
		}
		
		public XamlTypeInvoker (XamlType type)
		{
			throw new NotImplementedException ();
		}
		
		public EventHandler<XamlSetMarkupExtensionEventArgs> SetMarkupExtensionHandler {
			get { throw new NotImplementedException (); }
		}
		public EventHandler<XamlSetTypeConverterEventArgs> SetTypeConverterHandler {
			get { throw new NotImplementedException (); }
		}
		public virtual void AddToCollection (object instance, object item)
		{
			throw new NotImplementedException ();
		}
		public virtual void AddToDictionary (object instance, object key, object item)
		{
			throw new NotImplementedException ();
		}
		public virtual object CreateInstance (object [] arguments)
		{
			throw new NotImplementedException ();
		}
		public virtual MethodInfo GetAddMethod (XamlType contentType)
		{
			throw new NotImplementedException ();
		}
		public virtual MethodInfo GetEnumeratorMethod ()
		{
			throw new NotImplementedException ();
		}
		public virtual IEnumerator GetItems (object instance)
		{
			throw new NotImplementedException ();
		}
	}
}