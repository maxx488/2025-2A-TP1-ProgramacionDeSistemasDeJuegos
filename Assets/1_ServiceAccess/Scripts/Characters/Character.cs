using System;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Excercise1
{
    public class Character : MonoBehaviour, ICharacter
    {
        [SerializeField] protected string id;

        protected virtual void OnEnable()
        {
            //TODO: Add to CharacterService. The id should be the given serialized field.
            ServiceLocator.SetService(id, this);
        }

        protected virtual void OnDisable()
        {
            ServiceLocator.RemoveService(id);
        }
    }
}