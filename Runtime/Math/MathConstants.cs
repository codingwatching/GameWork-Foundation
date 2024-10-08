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
using UnityEngine;

namespace FronkonGames.GameWork.Foundation
{
  /// <summary> Math constants. </summary>
  public static class MathConstants
  {
    /// <summary> The ratio of a circle's circumference to its diameter </summary>
    public static readonly float Pi                 = 3.14159265358979f;

    /// <summary> Pi / 2 </summary>
    public static readonly float PiHalf             = Pi * 0.5f;

    /// <summary> Pi * 2 </summary>
    public static readonly float Pi2                = Pi * 2.0f;

    /// <summary> Euler's number </summary>
    public static readonly float E                  = 2.71828182846f;

    /// <summary> The ratio between circumference and radius (2 * Pi) </summary>
    public static readonly float Tau                = 6.28318530717959f;

    /// <summary> The ratio of their sum to the larger of the two quantities </summary>
    public static readonly float GoldenRatio        = 1.61803398875f;

    /// <summary> Multiplying to convert from degrees to radians </summary>
    public static readonly float Deg2Rad            = Tau / 360.0f;

    /// <summary> Multiplying to convert from radians to degrees </summary>
    public static readonly float Rad2Deg  = 360.0f / Tau;

    /// <summary>1.0 / 3.0</summary>
    public static readonly float OneThird           = 0.333333333333333f;

    /// <summary>2.0 / 3.0</summary>
    public static readonly float TwoThirds          = 0.666666666666667f;

    /// <summary>1.0 / 6.0</summary>
    public static readonly float OneSixth           = 0.166666666666667f;

    /// <summary>Using float.epsilon can cause precision problems in Unity.</summary>
    public const float Epsilon                      = 1.4E-32f;

    /// <summary> Positive infinity </summary>
    public static readonly float Infinity           = Mathf.Infinity;

    /// <summary> Negative infinity </summary>
    public static readonly float NegativeInfinity   = Mathf.NegativeInfinity;

    /// <summary> Invalid Vector2 </summary>
    public static readonly Vector2 NaNVector2       = new(float.NaN, float.NaN);

    /// <summary> Vector2 infinity </summary>
    public static readonly Vector2 InfinityVector2  = new(Infinity, Infinity);

    /// <summary> Invalid Vector3 </summary>
    public static readonly Vector3 NaNVector3       = new(float.NaN, float.NaN, float.NaN);

    /// <summary> Vector3 infinity </summary>
    public static readonly Vector3 InfinityVector3  = new(Infinity, Infinity, Infinity);

    /// <summary> Invalid Vector4 </summary>
    public static readonly Vector4 NaNVector4       = new(float.NaN, float.NaN, float.NaN, float.NaN);

    /// <summary> Vector4 infinity </summary>
    public static readonly Vector4 InfinityVector4  = new(Infinity, Infinity, Infinity, Infinity);

    /// <summary> Empty ray </summary>
    public static readonly Ray EmptyRay             = new();
  }
}
