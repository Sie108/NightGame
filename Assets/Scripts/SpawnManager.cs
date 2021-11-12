using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class SpawnManager : MonoBehaviour
{
    public UnityEvent onEnableEvent;
    public bool canRun = true;
    public float holdTime = 2f;
    private WaitForSeconds wfs;
    public GameObject prefab;

    private IEnumerator Start()
    {
        wfs = new WaitForSeconds(holdTime);

        while (canRun)
        {
            yield return wfs;
            Instantiate(prefab);
        }
    }
}
