using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_BloqCuanMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

 
  public GameObject m_bloqueMenu;
  public void activarCoso()
  {
    m_bloqueMenu.SetActive (true);
  }

  public void desactivarCoso()
  {
    m_bloqueMenu.SetActive(false);
  }

}
