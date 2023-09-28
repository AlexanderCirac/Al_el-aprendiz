using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Referencia al prefab hijo que deseas asignar en el inspector
    public GameObject childPrefab;

    // Array para almacenar los hijos y nietos instanciados
    [SerializeField]
    private GameObject[] instantiatedChildren;

#if UNITY_EDITOR
    private void OnValidate()
    {
        // Ejecuta InstantiateChildren solo en el editor
        if ( !EditorApplication.isPlayingOrWillChangePlaymode )
        {
            InstantiateChildren();
        }
    }
#endif

    private void InstantiateChildren()
    {
        // Instancia los hijos y nietos
        if ( childPrefab != null )
        {
            instantiatedChildren = InstantiateChildrenRecursive(childPrefab , transform);
        }
        else
        {
            instantiatedChildren = null;
        }
    }

    private GameObject[] InstantiateChildrenRecursive(GameObject prefab , Transform parent)
    {
        int childCount = prefab.transform.childCount;
        GameObject[] instantiatedChildren = new GameObject[childCount];

        for ( int i = 0 ; i < childCount ; i++ )
        {
            Transform childTransform = prefab.transform.GetChild(i);
            GameObject instantiatedChild = Instantiate(childTransform.gameObject, childTransform.position, Quaternion.identity, parent);
            instantiatedChildren[i] = instantiatedChild;

            // Comprueba si el hijo tiene hijos y llama recursivamente a la función
            if ( childTransform.childCount > 0 )
            {
                GameObject[] instantiatedGrandchildren = InstantiateChildrenRecursive(childTransform.gameObject, instantiatedChild.transform);

                // Une los nietos al array de hijos
                instantiatedChildren = instantiatedChildren.Concat(instantiatedGrandchildren).ToArray();
            }
        }

        return instantiatedChildren;
    }
}

