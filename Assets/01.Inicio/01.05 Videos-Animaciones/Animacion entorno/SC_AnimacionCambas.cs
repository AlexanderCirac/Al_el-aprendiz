using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_AnimacionCambas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    AnimacionRender();
    }

  public Image m_imagenReal;
  public SpriteRenderer m_imagenesPasadas;
  void AnimacionRender() {

    m_imagenReal.sprite = m_imagenesPasadas.sprite;
  }
}
