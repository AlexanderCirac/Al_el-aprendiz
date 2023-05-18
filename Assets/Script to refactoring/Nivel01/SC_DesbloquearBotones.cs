using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_DesbloquearBotones : MonoBehaviour
{
  //esta script es para ir desbloqueando botones importantes mediante el paso de la historia con los dialogos

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public GameObject m_spriteSalto;
  public GameObject m_spriteSaltoIzq;
  public void ActivarSalto()
  {
    m_spriteSalto.SetActive(true);
    m_spriteSaltoIzq.SetActive(true);
  }

  public GameObject m_spriteAgachar;
  public GameObject m_spriteAgacharIzq;
  public void ActivarAgachar()
  {
    m_spriteAgachar.SetActive(true);
    m_spriteAgacharIzq.SetActive(true);
    
  }

  public GameObject m_spriteAtacar;
  public GameObject m_spriteAtacarIzq;
  public void ActivarDisparar()
  {
    m_spriteAtacar.SetActive(true);
    m_spriteAtacarIzq.SetActive(true);
  }
}
