using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Report230607
{
    public class SettingSceneUI : SceneUI
    {
        protected override void Awake()
        {
            base.Awake();

            buttons["InfoButton"].onClick.AddListener(() => { Debug.Log("Info"); });
            buttons["VolumeButton"].onClick.AddListener(() => { Debug.Log("Volume"); });
            buttons["SettingButton"].onClick.AddListener(() => { OpenPausePopUpUI(); });
        }

        public void OpenPausePopUpUI()
        {
            GameManager.UI.ShowPopUpUI<PopUpUI>("UI/SettingPopUpUI");
        }
    }
}
