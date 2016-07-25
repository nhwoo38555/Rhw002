using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


namespace Assets.Scripts.UI
{
    public sealed class UIManager
    {

        private UIManager() { }

        public void Initialize()
        {
            this._layerDic = new SortedDictionary<UILayerType, UILayerAbstract>();
            this._activeLayerstack = new Stack<UILayerAbstract>();
            this._lastOrderInLayer = 0;
        }
        public void Terminate()
        {
            if (null != this._activeLayerstack)
            {
                this._activeLayerstack.Clear();
                this._activeLayerstack = null;
            }
            if (null != this._layerDic)
            {
                this._layerDic.Clear();
                this._layerDic = null;
            }
        }
        public void UpdateCustom()
        {
            foreach (UILayerAbstract layer in this._activeLayerstack)
            {
                layer.UpdateOnActive();
            }
        }
        private UILayerAbstract _InstantiateUILayer(UILayerType uiLayerType_)
        {
            if(null == this.rootComponent)
            {
                this.rootComponent = GameObject.FindObjectOfType<UICRoot>();
            }
            if(null != this.rootComponent)
            {
                UILayerAbstract uiLayer = this.rootComponent.InstantiateUILayer(uiLayerType_);
                if(null != uiLayer)
                {
                    this._layerDic.Add(uiLayerType_, uiLayer);
                }
                return uiLayer;
            }
            return null;
        }
        public void DestroyUILayer(UILayerType uiLayerType_)
        {
            UILayerAbstract uiLayer = null;
            if(true == this._layerDic.TryGetValue(uiLayerType_, out uiLayer))
            {
                this._layerDic.Remove(uiLayerType_);
                if(null!= uiLayer && null != uiLayer.layerCanvas)
                {
                    GameObject.DestroyObject(uiLayer.layerCanvas.gameObject);
                }
            }
        }
        public void ActivateUILayer(UILayerType uiLayerType_)
        {
            UILayerAbstract requestLayer = null;
            if(false == this._layerDic.TryGetValue(uiLayerType_,out requestLayer))
            {
                requestLayer = _InstantiateUILayer(uiLayerType_);
            }
            if(null!= requestLayer)
            {
                if (_activeLayerstack.Count < 1) this._lastOrderInLayer = 0;
                requestLayer.Activate(++this._lastOrderInLayer);
                this._activeLayerstack.Push(requestLayer); 
                this.currentActiveLayerType = uiLayerType_;
            }
        }
        public void DeactivateUiLayer(UILayerType uiLayerType_)
        {
            if (this._activeLayerstack.Count > 0)
            {
                UILayerAbstract uiLayer = null;
                if(uiLayerType_ != UILayerType.NONE)
                {
                    if(uiLayerType_ == this._activeLayerstack.Peek().uiLayerType)
                    {
                        uiLayer = this._activeLayerstack.Pop();
                    }
                }
                else
                {
                    uiLayer = this._activeLayerstack.Pop();
                }
                if(null!= uiLayer)
                {
                    uiLayer.DeActivate();
                }
            }
        }
        public UICRoot rootComponent { get; private set; }
        public UILayerType currentActiveLayerType { get; private set; }
        private SortedDictionary<UILayerType, UILayerAbstract> _layerDic = null;
        private Stack<UILayerAbstract> _activeLayerstack = null;
        private int _lastOrderInLayer = 0;

        #region SINGLETON
        private static UIManager _instance = null;
        public static UIManager Instance { get { if(null!= _instance) { return _instance; } else { return (_instance = new UIManager()); } } }
        #endregion

    }
    
}
