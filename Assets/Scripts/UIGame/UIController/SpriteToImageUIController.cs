using UnityEngine;
using UnityEngine.UI;

namespace Al.UIGame
{
    public class SpriteToImageUIController : MonoBehaviour
    {
        #region Attributes
        private Image m_imagenReal;
        private SpriteRenderer m_imagenesPasadas;

        #endregion

        #region Unity Calls
        void Start()
        {
            TryGetComponent(out m_imagenReal);
            TryGetComponent(out m_imagenesPasadas);
        }
        void Update()
        {
            AnimacionRender();
        }

        #endregion

        #region custom privat method
        void AnimacionRender()
        {

            m_imagenReal.sprite = m_imagenesPasadas.sprite;
        }
        #endregion
    }
}
