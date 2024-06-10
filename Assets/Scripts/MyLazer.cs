using System;
using Unity.VisualScripting;
using UnityEngine;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class MyLazer : SteamVR_LaserPointer
{
  public override void OnPointerIn(PointerEventArgs e)
  {
    base.OnPointerIn(e);
  }

  public override void OnPointerClick(PointerEventArgs e)
  {
    base.OnPointerClick(e);
    if (e.target.CompareTag("UIELement"))
    {
      UIElement el = e.target.GetComponent<UIElement>();
      el.onHandClick.Invoke(GetComponent<Hand>());
    }
  }

  public override void OnPointerOut(PointerEventArgs e)
  {
    base.OnPointerOut(e);

  }
}