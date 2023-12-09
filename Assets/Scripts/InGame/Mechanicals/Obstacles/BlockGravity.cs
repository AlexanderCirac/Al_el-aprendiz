using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Al.InGame.Obstacles
{
    using AL.Tools.Enums;
    using AL.Tools.Interface;
    public class BlockGravity : MonoBehaviour, IObstactle
    {
        #region Attributes
        public eObstacle _typeObstactle;
        public eObstacle TypeObstactle { get => _typeObstactle; set => _typeObstactle = value; }
        #endregion

        #region public custom method

        public void ToActionObstacle(GameObject getGameObject)
        {
            if(TypeObstactle == eObstacle.BlockGravityEnabled) 
            {
                getGameObject.GetComponent<Rigidbody>().angularDrag = 12;
            }
            else if(TypeObstactle == eObstacle.BlockGravityDesabled)
            {
                getGameObject.GetComponent<Rigidbody>().angularDrag = 0;
            }
        }
        #endregion


    }
}