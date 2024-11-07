using UnityEngine;

namespace Elementals
{
    public interface IElemental
    {
        ElementalsClass ElementalClass { get; set; }
        void OnActivate();
    }
}
