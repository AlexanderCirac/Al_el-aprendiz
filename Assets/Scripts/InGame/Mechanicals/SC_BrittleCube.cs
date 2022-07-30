using UnityEngine;

namespace AL.InGame
{
    public class SC_BrittleCube : MonoBehaviour
    {
        #region Attribute
        //esta script es para  romper las cajas cuando pase por encima
        // Start is called before the first frame update
        public int m_id_Caja;

        public GameObject m_particula;
        public Collider m_coldider;
        //parpadeo del cubo
        public GameObject m_cubo;
        private float m_tiempo;
        public float m_tiempoMax;
        private int m_cambio;
        public float m_deley;
        #endregion

        #region UnityCalls
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
          Parpadear();
        }


        private void OnTriggerEnter(Collider coll)
        {
          if (coll.CompareTag("Player"))
          {
            Funcionalidad();
          }
        }
        #endregion

        #region custom private methods

        void Funcionalidad()
        {
          romper();
        }

        void romper()
        {
          if (m_id_Caja == 1)//solo romper
          {
            m_particula.SetActive(true);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            m_coldider.enabled = false;
            Invoke("Autodestruir", 1.5f);
          }
          if (m_id_Caja == 2)//quitar vida y romperse
          {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            m_coldider.enabled = false;
            Invoke("Autodestruir", 0.5f);
          }
        }
        void Autodestruir()
        {
          Destroy(m_cubo);
        }

        void Parpadear()
        {
          if (m_id_Caja == 3)
          {
            m_tiempo += (m_tiempoMax / 2) * Time.deltaTime;

            if (m_tiempo < (m_tiempoMax + (-m_deley)) && m_cambio == 0)
            {
              m_cambio = 0;
            }
            if (m_tiempo > (m_tiempoMax + 0.1f + (-m_deley)) && m_cambio == 0)
            {
              m_cambio = 1;
            }
            if (m_tiempo > (m_tiempoMax * 2 + (-m_deley)) && m_cambio == 1)
            {
              m_tiempo = 0;
              m_cambio = 0;
            }

            if (m_cambio == 0)
            {
              m_cubo.SetActive(true);
            }
            else
            {
              m_cubo.SetActive(false);
            }

          }
        }
        #endregion

    }
}
