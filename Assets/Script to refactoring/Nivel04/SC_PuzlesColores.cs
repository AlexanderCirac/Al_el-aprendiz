using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PuzlesColores : MonoBehaviour
{
  //esta script es para crear una secuencia en la que el jugador a de poner el orden
  public string[] m_Secuencia; // esto es para poder crear una lista ordenada
  public List<GameObject> m_objetos; // aqui es donde se guardara los objetos que sea selecionados por el jugador
  public int m_siguienteSecuencia; // aqui añadiremos una numero que ira incrementando para ver 
  public GameObject m_todo; // esto es para desactivar el acertijo
  

  

  // Start is called before the first frame update
  void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
   
     ComprovarSecuencia();


    }

  void ComprovarSecuencia()
  {
   
  
      if ( m_Secuencia.Length == m_objetos.ToArray().Length)
      {
        Debug.Log("Miramos secuencia"); // aqui es para cotejar la lista de las respuesta con el objeto añadido
        if (m_Secuencia[m_siguienteSecuencia] == m_objetos[m_siguienteSecuencia].tag.ToString())
        {
          Debug.Log("Comprovacion secuencia"); // si el objeto añadido coincide con la lista correcta se permite añadir el siguiente objeto
          if (m_siguienteSecuencia <= m_Secuencia.Length - 2)
          {
            m_siguienteSecuencia++;
          }
          else // una vez que se tenga todos los objetos se finaliza la pureba desactivando el puzzle y la barrera para terminar el nivel
          {
            Debug.Log("Todo correcto");
            m_todo.SetActive(false);
          }
        }
        else // en el caso que el objeto añadido que no coincida
        {
          Debug.Log("Secuencia erronia");
        m_siguienteSecuencia = 0;
        m_objetos.Clear();
        }
      }
    }
  
 
}


