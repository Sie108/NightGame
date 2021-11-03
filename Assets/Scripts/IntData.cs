using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "SingleVariables/IntData")]
public class IntData : NameID
{
 public int value;
 private int currentValue;
 public UnityEvent decrementEvent, valueChangeEvent, atZeroEvent, compareTrueEvent;

 public void SetValue(int amount)
 {
  value = amount;
  valueChangeEvent.Invoke();
 }

 public void UpdateFromCurrentValue()
 {
     value = currentValue;
     valueChangeEvent.Invoke();
 }

 public void UpdateCurrentValue()
 {
     currentValue = value;
     valueChangeEvent.Invoke();
 }

 public void UpdateValue(int amount)
 {
     value += amount;
     valueChangeEvent.Invoke();
 }
 public void IncrementValue()
 {
     value++;
     valueChangeEvent.Invoke();
 }
 public void DecrementToZero()
    {
     if (value > 0) 
     {
             value--;
             decrementEvent.Invoke();
     } 
     if (value == 0)
     {
         atZeroEvent.Invoke();
     }
    }

 public void UpdateValue(Object data)
    {
     var newData = data as IntData;
     if (newData != null) return;
     valueChangeEvent.Invoke();
    }

 public void SetValue(Object data)
    {
     var newData = data as IntData;
     if (newData == null) return;
     value = newData.value;
     valueChangeEvent.Invoke();
    }

 public void CompareValue(IntData data)
    {
       if (value == data.value)
       {
           compareTrueEvent.Invoke();
       }
    }

 public void CompareValue(int data)
    {
         if (value == data)
         {
         compareTrueEvent.Invoke();
         }
    }
}
