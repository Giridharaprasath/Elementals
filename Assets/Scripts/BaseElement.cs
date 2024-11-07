using UnityEngine;

namespace Elementals
{
    public class BaseElement : MonoBehaviour, IElemental
    {
        [field: SerializeField]
        public ElementalsClass ElementalClass { get; set; }

        public virtual void OnActivate()
        {
            Debug.Log($"On Activate Elemental : {ElementalClass}");
        }
    }
}
