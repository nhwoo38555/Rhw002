using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using System;

namespace Assets.Scripts.Scene
{
    public class SceneJoin : SceneAbstract
    {
        protected override void _OnEnter()
        {
            UIManager.Instance.ActivateUILayer(UILayerType.JOIN);
        }
        protected override void _OnExit()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.JOIN);
        }
        public override SceneType sceneType
        {
            get
            {
                return SceneType.JOIN;
            }
        }
    }
}