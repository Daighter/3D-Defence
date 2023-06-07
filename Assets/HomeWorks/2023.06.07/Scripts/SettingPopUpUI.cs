using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Report230607
{
    public class SettingPopUpUI : PopUpUI
    {
        protected override void Awake()
        {
            base.Awake();

            buttons["ContinueButton"].onClick.AddListener(() => { GameManager.UI.ClosePopUpUI(); });
            buttons["SettingsButton"].onClick.AddListener(() => { GameManager.UI.ShowPopUpUI<PopUpUI>("UI/ConfigPopUpUI"); });
        }
    }
}
