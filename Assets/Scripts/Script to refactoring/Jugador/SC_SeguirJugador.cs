using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SeguirJugador : MonoBehaviour
{
  public GameObject m_jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    this.transform.position = new Vector3(m_jugador.transform.position.x, m_jugador.transform.position.y, m_jugador.transform.position.z);
    }
}
