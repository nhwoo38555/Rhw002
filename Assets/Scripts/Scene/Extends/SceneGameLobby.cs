using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using System;

namespace Assets.Scripts.Scene
{
    public class SceneGameLobby : SceneAbstract
    {
        protected override void _OnEnter()
        {
            UIManager.Instance.ActivateUILayer(UILayerType.GAMELOBBY);
        }
        protected override void _OnExit()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.GAMELOBBY);
        }
        public override SceneType sceneType
        {
            get
            {
                return SceneType.GAMELOBBY;
            }
        }
    }
}
