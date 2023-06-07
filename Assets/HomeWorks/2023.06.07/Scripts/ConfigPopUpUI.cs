using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Report230607
{
    public class ConfigPopUpUI : PopUpUI
    {
        protected override void Awake()
        {
            base.Awake();

            buttons["SaveButton"].onClick.AddListener(() => { GameManager.UI.ClosePopUpUI(); });
            buttons["CancelButton"].onClick.AddListener(() => { GameManager.UI.ClosePopUpUI(); });
        }
    }
}
