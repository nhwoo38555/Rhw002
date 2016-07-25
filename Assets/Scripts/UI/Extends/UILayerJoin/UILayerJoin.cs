using UnityEngine;
using System.Collections;
using System;

namespace Assets.Scripts.UI
{
    class UILayerJoin : UILayerAbstract
    {


        protected override void _OnActivate()
        {
            if (null == this._eventHandler)
            {
                this._eventHandler = base.layerCanvas.GetComponentInChildren<UILayerJoinHandler>();
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
        private UILayerJoinHandler _eventHandler = null;
        public override UILayerType uiLayerType
        {
            get
            {
                return UILayerType.JOIN;
            }
        }
    }
}
