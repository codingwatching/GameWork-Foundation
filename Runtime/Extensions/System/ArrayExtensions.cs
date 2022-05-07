﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Martin Bustos @FronkonGames <fronkongames@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of
// the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace FronkonGames.GameWork.Foundation
{
  /// <summary>
  /// List extensions.
  /// </summary>
  public static class ArrayExtensions
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Random<T>(this T[] self) => self[Rand.Range(0, self.Length)];
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <typeparam name="T"></typeparam>
    public static void Clear<T>(this T[] self) => Array.Clear(self, 0, self.Length);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="index"></param>
    /// <param name="count"></param>
    /// <typeparam name="T"></typeparam>
    public static void Clear<T>(this T[] self, int index, int count) => Array.Clear(self, index, count);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T[] Copy<T>(this T[] self)
    {
      T[] result = new T[self.Length];
      Array.Copy(self, result, self.Length);

      return result;
    }    

    /// <summary>
    /// Swaps a pair of elements.
    /// </summary>
    /// <param name="self"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <typeparam name="T"></typeparam>
    public static void Swap<T>(this T[] self, int i, int j) => (self[i], self[j]) = (self[j], self[i]);

    /// <summary>
    /// Reverses an array of items in place.
    /// </summary>
    /// <param name="self"></param>
    /// <typeparam name="T"></typeparam>
    public static void Reverse<T>(this T[] self) => Reverse(self, 0, self.Length);

    /// <summary>
    /// Reverses the order of the items within the specified range in place.
    /// </summary>
    /// <param name="self"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <typeparam name="T"></typeparam>
    public static void Reverse<T>(this T[] self, int from, int to)
    {
      while (--to > from)
        self.Swap(from++, to);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <typeparam name="T"></typeparam>
    public static void Shuffle<T>(this T[] self)
    {
      for (int i = self.Length - 1; i > 0; i--)
      {
        int j = Rand.Range(0, i);
        self.Swap(i, j);
      }      
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="index"></param>
    /// <param name="count"></param>
    /// <typeparam name="T"></typeparam>
    public static void Shuffle<T>(this T[] self, int index, int count)
    {
      for (int i = count - 1; i > 0; i--)
      {
        int j = Rand.Range(0, i);
        self.Swap(i + index, j + index);
      }
    }    
  }
}