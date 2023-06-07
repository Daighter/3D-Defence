using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Report230607
{
    public class InfoSceneUI : SceneUI
    {
        protected override void Awake()
        {
            base.Awake();

            texts["HeartText"].text = "20";
            texts["CoinText"].text = "100";
        }
    }
}
