using System.Collections.Generic;
using UnityEngine;

namespace Excercise1
{
    public static class ServiceLocator
    {
        private static Dictionary<string, ICharacter> _service = new();
        private static CharacterService _characterService = new();

        public static ICharacter GetService(string id)
        {
            _service.TryGetValue(id, out var character);
            return character;
        }

        public static void SetService(string id, ICharacter services)
        {
            _characterService.TryAddCharacter(id, services);
            _service.TryAdd(id, services);
        }

        public static void RemoveService(string id)
        {
            _characterService.TryRemoveCharacter(id);
            _service.Remove(id);
        }
    }
}
