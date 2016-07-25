using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using System;

namespace Assets.Scripts.Scene
{
    public class SceneGame: SceneAbstract
    {
        protected override void _OnEnter()
        {
            UIManager.Instance.ActivateUILayer(UILayerType.GAME);
        }
        protected override void _OnExit()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.GAME);
        }
        public override SceneType sceneType
        {
            get
            {
                return SceneType.GAME;
            }
        }
    }
}
