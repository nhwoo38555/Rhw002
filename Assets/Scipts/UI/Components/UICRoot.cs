using UnityEngine;
using System.Collections;

namespace Assets.Scripts.UI
{
    public class UICRoot: MonoBehaviour
    {
        void Awake()
        {
            this._uiRootRectTransform = base.transform as RectTransform;
        }

        public  UILayerAbstract InstantiateUILayer(UILayerType uiLayerType_)
        {
            GameObject uiLayerObject = null;

            switch (uiLayerType_)
            {
                case UILayerType.GAME: { uiLayerObject = GameObject.Instantiate(_gameLayer) as GameObject; } break;
                case UILayerType.GAME_LOADING: { uiLayerObject = GameObject.Instantiate(_gameLoadingLayer) as GameObject; }break;
                case UILayerType.LOBBY: { uiLayerObject = GameObject.Instantiate(_LobbyLayer) as GameObject; }break;
                case UILayerType.JOIN: { uiLayerObject = GameObject.Instantiate(_JoinLayer) as GameObject; }break;
            }

            if (null != uiLayerObject)
            {
                uiLayerObject.transform.localScale = base.transform.localScale;
                uiLayerObject.transform.position = base.transform.position;
                uiLayerObject.transform.SetParent(base.transform);

                RectTransform UILayerRectTransform = uiLayerObject.transform as RectTransform;

                if (null != UILayerRectTransform && null != _uiRootRectTransform)
                {
                    UILayerRectTransform.sizeDelta = Vector2.zero;
                }
                UILayerAbstract uiLayer = null;
                switch (uiLayerType_)
                {
                    case UILayerType.GAME: { uiLayer = new UILayerGame(); } break;
                    case UILayerType.GAME_LOADING: { uiLayer = new UILayerGameLoading(); } break;
                    case UILayerType.LOBBY: { uiLayer = new UILayerLobby(); } break;
                    case UILayerType.JOIN: { uiLayer = new  UILayerJoin(); } break;
                }
                if (null != uiLayer)
                {
                    uiLayer.Initialize(uiLayerObject);
                    return uiLayer;
                }
                return null;
            }
            else
            {
                Debug.LogError("Error");
            }
            return null;
        }

        [SerializeField]
        private UnityEngine.Object _LobbyLayer = null;
        [SerializeField]
        private UnityEngine.Object _gameLayer = null;
        [SerializeField]
        private UnityEngine.Object _gameLoadingLayer = null;
        [SerializeField]
        private UnityEngine.Object _JoinLayer = null;
        private RectTransform _uiRootRectTransform = null;

    }
        
    }
