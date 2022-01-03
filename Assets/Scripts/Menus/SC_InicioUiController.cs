using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AL.UI
{
    public class SC_InicioUiController : MonoBehaviour
    {
          #region Attributes
          [Header("Buttons")]
          [SerializeField] private Button _loadLevel;
          [Header("Panels")]
          [SerializeField] private GameObject _panelAnimation;
          #endregion
    
          #region UnityCalls
          // Start is called before the first frame update
          void Start()
          {
              _loadLevel.onClick.AddListener(ActiveAnimation);
          }

          // Update is called once per frame
          void Update()
          {
        
          }
          #endregion 
    
          #region Methods
          private void ActiveAnimation()
          {
              _panelAnimation.SetActive(true);
              Invoke(nameof(LoadLevel),1.2f);
          }
          private void LoadLevel()
          {
              SceneManager.LoadScene(1);
          }
          #endregion

    }
}
