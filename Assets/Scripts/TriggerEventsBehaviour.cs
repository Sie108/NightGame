using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
 public UnityEvent triggerEnterEvent, triggerEnterRepeatEvent, triggerEnterEndEvent, triggerExitEvent, triggerEnterMoveEvent;
 public float delayTime = 0.01f;
 private WaitForSeconds waitObj;
 public bool canRepeat;
 public int repeatTimes = 10;

 private void Start()
 {
  waitObj = new WaitForSeconds(delayTime);
 }

 private IEnumerator OnTriggerEnter(Collider other)
 {
  yield return waitObj;
  triggerEnterEvent.Invoke();

  if (canRepeat)
  {
   var i = 0;
   while (i < repeatTimes)
   {
    i++;
    triggerEnterRepeatEvent.Invoke();
   }
  }
  
  triggerEnterEndEvent.Invoke();
  }
 
 private void OnMouseDown()
  {
    triggerExitEvent.Invoke();
  }
  private void OnMouseUp()
  {
    triggerEnterMoveEvent.Invoke();
    
  }
  
 }