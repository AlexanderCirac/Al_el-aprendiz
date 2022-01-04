using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MantenerPulsado : MonoBehaviour
{

  //esta script es para completar SC_Carta y que funcione bien

  public SC_Carta SC_C;
  public SC_UIMantener SC_UI;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MantenerPulsado();
    }

    public void MantenerPulsado()
    {
      SC_C.m_dotwo = SC_UI.IsHolding;
    }
}
