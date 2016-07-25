using UnityEngine;
using System.Collections;
using System;

namespace Assets.Scripts.UI
{
    class UILayerGameScene : UILayerAbstract
    {

        protected override void _OnActivate()
        {
            if (null == this._eventHandler)
            {
                this._eventHandler = base.layerCanvas.GetComponentInChildren<UILayerGameSceneHandler>();
            }
            if (null != this._eventHandler)
            {
                this._eventHandler.HandleOnActivateLayer();
            }
        }
        protected override void _OnDeActivate()
        {
            if (null != this._eventHandler)
            {
                this._eventHandler.HandleOnDeActivateLayer();
            }

        }

        private UILayerGameSceneHandler _eventHandler = null;

        public override UILayerType uiLayerType
        {
            get
            {
                return UILayerType.GAMESCENE;
            }
        }
    }
}