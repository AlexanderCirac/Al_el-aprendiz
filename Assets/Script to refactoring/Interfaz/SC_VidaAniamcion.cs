using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_VidaAniamcion : MonoBehaviour
{
  //esto es para activar la animacion de la vida pero con dos variables una para forma normal y otra para la forma especial del nivel 1


    // Start is called before the first frame update
    void Start()
    {
        
    }

  public bool m_normal;
    // Update is called once per frame
    void Update()
    {
      if (m_normal)
      {
      ActivarAnimacionVida();
      }
        else
        {
          if (m_doOnce)
          {
            this.GetComponent<Animator>().enabled = true;
          }
        }
    }

  /////////////////////////////////////////////////////forma especial///////////////////////////////////////////

  //variables para la forma especial en la que cuando la barra este en su lugar activara la animacion
  public Slider m_barra;
  [HideInInspector]
  public bool m_doOnce;
  public void MoverSobre()
  {
      m_doOnce = true;
  }
  void ActivarAnimacionVida()
  {
      this.GetComponent<Animator>().enabled = true;
  }
}
