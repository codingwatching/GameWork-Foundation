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
using UnityEditor;

namespace FronkonGames.GameWork.Foundation
{
  /// <summary> Message box drawer. </summary>
  [CustomPropertyDrawer(typeof(MessageBoxAttribute), true)]
  public sealed class MessageBoxDecoratorDrawer : DecoratorDrawer
  {
    public override void OnGUI(Rect position)
    {
      position.height -= EditorGUIUtility.standardVerticalSpacing;

      MessageBoxAttribute messageBox = (MessageBoxAttribute)attribute;
      
      EditorGUI.HelpBox(position, messageBox.label, (MessageType)messageBox.messageType);
    }

    public override float GetHeight()
    {
      MessageBoxAttribute messageBox = (MessageBoxAttribute)attribute;
      string iconName = messageBox.messageType switch
      {
        MessageBoxAttribute.MessageType.None =>    string.Empty,
        MessageBoxAttribute.MessageType.Info =>    "console.infoicon",
        MessageBoxAttribute.MessageType.Warning => "console.warnicon",
        MessageBoxAttribute.MessageType.Error =>   "console.erroricon",
        _ => string.Empty
      };

      return EditorStyles.helpBox.CalcHeight(EditorGUIUtility.TrTextContentWithIcon(messageBox.label, iconName),
        EditorGUIUtility.currentViewWidth - 37) + EditorGUIUtility.standardVerticalSpacing;
    }
  }
}
