using UnityEngine;
using AL.Player;

namespace AL.Player
{

    public class SC_GravetyPlayerController : MonoBehaviour
    {
        #region Attributes
        //Update is called once per frame
        //public float m_gravedad;
        //public bool m_gravedad1;
        //public SC_JugadorMovimiento SC_J;
        //public float m_velocidadMovimiento;

        //  public GameObject m_jugador;

        private float m_velocidadestandar;
        private bool m_gravedad;
        //private bool m_desgravedad;
        public SC_PlayerController SC_J;
        //public SC_jugadorEfectoDaño SC_JED;
        private float m_velocidadNormal;
        public float m_massa;
        public float m_fuerza;
        private float m_fuerzanormal;
        #endregion   
    
        #region UnityCalls
        // Start is called before the first frame update
        void Start()
        {
        m_fuerzanormal = this.GetComponent<ConstantForce>().force.y;
        if (SC_J != null)
        {

        m_velocidadestandar = SC_J.m_velocidadMovimiento;
        }
        }

        private void Update()
        {
          gravedad();
        }
        private void OnTriggerEnter(Collider coll)
        {

          if (coll.CompareTag("Caida"))
          {
            m_gravedad = true;
          }
          if (coll.CompareTag("caida1"))
          {

            m_gravedad = false;
          }
        }
    #endregion

    #region custom private methods
    void gravedad()
    {
      if (m_gravedad)
      {

        this.GetComponent<Rigidbody>().mass = m_massa;
        this.GetComponent<ConstantForce>().force = new Vector3(0, m_fuerza, 0);

      }
      else
      {
        this.GetComponent<Rigidbody>().mass = 1;
        this.GetComponent<ConstantForce>().force = new Vector3(0, m_fuerzanormal, 0);

      }
    }
    #endregion
  }
}
