using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Elementals
{
    public class GameManager : MonoBehaviour
    {
        public List<Button> Buttons;
        public List<BaseElement> AllElementals;

        public BaseElement CurrentElement { get; set; }

        public TMP_Text SelectedElementName;

        /// <summary>
        /// Start is called on the frame when a script is enabled just before
        /// any of the Update methods is called the first time.
        /// </summary>
        private void Start()
        {
            for (int i = 0; i < Buttons.Count; i++)
            {
                int index = i;
                Buttons[index].onClick.AddListener(() => OnClickElement(AllElementals[index]));
            }
        }

        private void OnClickElement(BaseElement selectedElement)
        {
            if (selectedElement == CurrentElement) return;

            CurrentElement = selectedElement;

            CurrentElement.OnActivate();

            OnCurrentElementChanged();
        }

        private void OnCurrentElementChanged()
        {
            if (CurrentElement.ElementalClass == ElementalsClass.None)
            {
                return;
            }

            SelectedElementName.text = CurrentElement.ElementalClass.ToString();
        }
    }
}
