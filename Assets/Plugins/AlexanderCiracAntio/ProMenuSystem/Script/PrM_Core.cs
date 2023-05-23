using UnityEngine;

namespace AlexanderCA.ProMenu
{
    using AlexanderCA.ProMenu.Explication;
    public class PrM_Core : MonoBehaviour
    {
        #region Custom public Methods
        [System.Diagnostics.Conditional("UNITY_EDITOR")]
        public void Reset() 
        {
            #if UNITY_EDITOR
            if (UnityEditor.EditorUtility.DisplayDialog("Español: Agradecimientos \n English:Gratitude", "Español: Buenos dias,muchas gracias por adquirir el paquete, le deseo que sea de mucha utilidad,le añadire de forma automatica dentro de su escena un objeto vacio con el nombre ProMenuMannager, en el cual se le colocara de forma automatica todas las scripts que necesita.  \n English: Good morning, thank you very much for purchasing the package, I hope it will be very useful, I will automatically add an empty object with the name ProMenuMannager to your scene, in which all the scripts you need will be automatically placed .", "ok"))
            {
              GameObject m_12 = new GameObject();
              m_12.name = "ProMenuSystem";
              m_12.AddComponent<PrM_Explication>();
            }
            #endif
        }
        #endregion
    }
}

