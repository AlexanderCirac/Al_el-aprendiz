using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace Al.InGame.Controller
{
    public class DistanceController : MonoBehaviour
    {
        #region Attributes

        #endregion

        #region Unity Calls
        private void Start()
        {
            transform.GetChild(0).gameObject.SetActive(false);

        }
        private void OnBecameVisible()
        {
            transform.GetChild(0).gameObject.SetActive(true);

        }
        private void OnBecameInvisible()
        {
            transform.GetChild(0).gameObject.SetActive(false);

        }
        #endregion


        #region privat method Calls

        #endregion
    }
}

