using UnityEngine;
using System.Collections;
using System;

namespace Assets.Scripts.UI
{
    class UILayerGameLoading : UILayerAbstract
    {
        public override UILayerType uiLayerType
        {
            get
            {
                return UILayerType.GAME_LOADING;        
            }
        }
    }
}