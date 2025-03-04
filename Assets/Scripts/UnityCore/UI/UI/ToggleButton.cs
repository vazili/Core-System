﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityCore
{
    namespace UI
    {
        public class ToggleButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
        {
            [SerializeField] private ToggleGroup toggleGroup;

            #region Unity Functions
            
            #endregion

            #region Public Functions

            public void OnPointerEnter(PointerEventData eventData)
            {
                toggleGroup.HighlightToggle();
            }

            public void OnPointerExit(PointerEventData eventData)
            {
                toggleGroup.ResetToggleColor();
            }

            #endregion
        }
    }
}