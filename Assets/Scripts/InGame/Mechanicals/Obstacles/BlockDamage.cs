using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Al.InGame.Obstacles
{
using AL.Tools.Interface;
    public class BlockDamage : MonoBehaviour
    {
        #region Attributes
        public float _rangeDamge;
        #endregion


        #region UnityCalls
        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out ILife ILife))
            {
                ILife.DamageLife(_rangeDamge);
            }
        }
        #endregion

        #region privat custom method

        #endregion
    }
}