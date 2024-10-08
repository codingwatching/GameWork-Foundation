////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
using UnityEngine.Events;

namespace FronkonGames.GameWork.Foundation.Prototype
{
  /// <summary> Trigger tester. </summary>
  /// <remarks> This component is intended for use in prototypes only. </remarks>
  public class TriggerTest : CachedMonoBehaviour
  {
    [SerializeField, Tag]
    private string tagFilter;

    [SerializeField]
    private string nameFilter;

    [SerializeField]
    private LayerMask layerFilter = -1;

    [Space, SerializeField]
    private UnityEvent<GameObject, Collider> onTriggerEnter;

    [Space, SerializeField]
    private UnityEvent<GameObject, Collider> onTriggerStay;

    [SerializeField]
    private UnityEvent<GameObject, Collider> onTriggerExit;

    [Space, SerializeField]
    private bool debugView;

    private Collider trigger;

    private bool PassFilter(GameObject gameObject)
    {
      if (string.IsNullOrEmpty(tagFilter) == false && string.Compare(tagFilter, gameObject.tag) == 0)
        return true;

      if (string.IsNullOrEmpty(nameFilter) == false && string.Compare(nameFilter, gameObject.name) == 0)
        return true;

      return gameObject.layer.IsInLayerMask(layerFilter);
    }

    private void OnTriggerEnter(Collider other)
    {
      if (PassFilter(other.gameObject) == true)
        onTriggerEnter?.Invoke(gameObject, other);
    }

    private void OnTriggerStay(Collider other)
    {
      if (PassFilter(other.gameObject) == true)
        onTriggerStay?.Invoke(gameObject, other);
    }

    private void OnTriggerExit(Collider other)
    {
      if (PassFilter(other.gameObject) == true)
      {
        onTriggerExit?.Invoke(gameObject, other);
      }
    }

    private void OnEnable()
    {
      trigger = this.gameObject.GetComponent<Collider>();
    }

    private void Update()
    {
      if (debugView == true)
        trigger.Draw();
    }
  }
}
