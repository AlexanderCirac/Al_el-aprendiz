using UnityEngine.SceneManagement;
using UnityEngine;

namespace AL.Life
{

    public class SC_DeathController : MonoBehaviour
    {

          #region Attributes 
          public GameObject m_pregunta;
          public SC_Vida SC_V;
          private bool m_mori;
          #endregion

          #region UnityCalls

          // Start is called before the first frame update
          void Start()
          {
          m_pregunta.SetActive(false);
          }

          // Update is called once per frame
          void Update()
          {
            Morir();
          }
          #endregion

          #region Custom private methods
          void Morir()
          {
            if (SC_V.m_vida <= 0 || m_mori == true)
            {
              m_pregunta.SetActive(true);
              Time.timeScale = 0;
            }
    
          }

        public void Salir()
        {
          Application.Quit();
        }

        public void Reinciar(int m_nivel)
        {
          //Application.LoadLevel(m_nivel);
          SceneManager.LoadScene(m_nivel);
        }
          #endregion
    }
}