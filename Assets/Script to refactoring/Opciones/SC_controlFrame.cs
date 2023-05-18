using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_controlFrame : MonoBehaviour
{
  //esta script es para controlar el los fps del aparato y dejarlo a una velocidad

  public int target;
    // Start is called before the first frame update
    void Start()
    {
    QualitySettings.vSyncCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if (target != Application.targetFrameRate)
      {
        Application.targetFrameRate = target;
      }
    }
}
