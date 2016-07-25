using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using System;

namespace Assets.Scripts.Scene
{
    public class SceneLobby :SceneAbstract
    {
        protected override void _OnEnter()
        {
            UIManager.Instance.ActivateUILayer(UILayerType.LOBBY);
        }
        protected override void _OnExit()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.LOBBY);
        }
        public override SceneType sceneType
        {
            get
            {
                return SceneType.LOBBY;
            }
        }
    }
}
