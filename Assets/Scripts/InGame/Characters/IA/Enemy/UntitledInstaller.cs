using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "UntitledInstaller", menuName = "Installers/UntitledInstaller")]
public class UntitledInstaller : ScriptableObjectInstaller<UntitledInstaller>
{
    public GameObject player;
    public GameObject[] weaponPrefabs;
    public override void InstallBindings()
    {
    }
}