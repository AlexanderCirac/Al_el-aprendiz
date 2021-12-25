using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ActivarAscensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public GameObject m_ascensor;
  public void ActivarAscensor()
  {
    m_ascensor.GetComponent<SC_Ascensor>().enabled = true;
  }
}
