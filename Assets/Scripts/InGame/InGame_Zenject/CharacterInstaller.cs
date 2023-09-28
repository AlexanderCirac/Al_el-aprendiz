using AL.Tools.Interface;
using UnityEngine;
using Zenject;

public class CharacterInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IInputs>().FromComponentInChildren().AsTransient();
    }
}