using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using System;

namespace Assets.Scripts.Scene
{
    public class SceneGameScene : SceneAbstract
    {
        protected override void _OnEnter()
        {
            UIManager.Instance.ActivateUILayer(UILayerType.GAMESCENE);
        }
        protected override void _OnExit()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.GAMESCENE);
        }
        public override SceneType sceneType
        {
            get
            {
                return SceneType.GAMESCENE;
            }
        }
    }
}