﻿/*
 * This source is released under the MIT-license.
 *
 * Copyright (c) 2011 Dennis Daume
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute,
 * sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 * BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;

namespace FlagLib.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="EventHandler"/> delegate.
    /// </summary>
    public static class EventHandlerExtensions
    {
        /// <summary>
        /// Raises the specified event handler.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handler">The event handler.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="eventArgs">The event args.</param>
        public static void Raise<T>(this EventHandler handler, object sender, T eventArgs) where T : EventArgs
        {
            if (handler != null)
            {
                handler(sender, eventArgs);
            }
        }
    }
}