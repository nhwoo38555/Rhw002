using UnityEngine;
using System.Collections;
using System;

namespace Assets.Scripts.UI
{
    class UILayerLobby : UILayerAbstract
    {
        protected override void _OnActivate()
        {
            if(null == this._eventHandler)
            {
                this._eventHandler = base.layerCanvas.GetComponentInChildren<UILayerLobbyHandler>();
            }
            if(null != this._eventHandler)
            {
                this._eventHandler.HandleOnActivateLayer();
            }
        }
        protected override void _OnDeActivate()
        {
            if(null != this._eventHandler)
            {
                this._eventHandler.HandleOnDeActivateLayer();
            }

        }
        private UILayerLobbyHandler _eventHandler = null;
        public override UILayerType uiLayerType
        {
            get
            {
                return UILayerType.LOBBY;
            }
        }

    }
}
