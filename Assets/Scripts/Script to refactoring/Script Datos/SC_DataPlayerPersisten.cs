
using UnityEngine;

namespace AL.Data
{
    public class SC_DataPlayerPersisten : MonoBehaviour
    {

          #region Attributes
          [Header("Data Settings")]
          [HideInInspector] public int m_nivel;
          [HideInInspector] public float m_Numero_Brillo;
          [HideInInspector] public float m_volumenMusica;
          [HideInInspector] public bool m_Zurdo;
          [HideInInspector] public bool m_Anuncio; 
          [HideInInspector] public bool m_primeravezBolita;
          [HideInInspector] public bool m_retorno1;  
          [HideInInspector] public bool m_retorno2; 
          [HideInInspector] public bool m_retorno3;
          [SerializeField ] private SC_Scriptable m_OP;
          #endregion

          #region Singleton
          [HideInInspector]
          public static SC_DataPlayerPersisten _instanceData;
          #endregion

          #region UnityCalls
          private void Awake()
          {
                if (_instanceData != null)
                {
                    Destroy(gameObject);
                }
                else 
                { 
                    _instanceData = this;
                    DontDestroyOnLoad(gameObject);
                }
          }
          void Start()
          {
              LoadSetting();
          }
          #endregion
          private void LoadSetting()
          {
              m_nivel = m_OP.m_nivel;
              m_Numero_Brillo = m_OP.m_nivellBrillo;
              m_volumenMusica = m_OP.m_volumenMusica;
              m_Zurdo = m_OP.m_Zurdo;

          }
    }
}
