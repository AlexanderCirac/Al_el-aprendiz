using AL.Tools.Template;
using UnityEngine;
using Zenject;

public class AnimationCharacterInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CharacterTamplate>().FromComponentInHierarchy().AsCached();
    }
}