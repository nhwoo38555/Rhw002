using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using System;
using Assets.Scripts.World;
using Assets.Scripts.Game;

namespace Assets.Scripts.Scene
{
    public class SceneGameStage : SceneAbstract
    {
        protected override void _OnEnter()
        {
            UIManager.Instance.ActivateUILayer(UILayerType.GAMESTAGE);
            WorldManager.Instance.InstantiateWorld();
            GameManager.Instance.HandleOnEnterGame();
        }
        protected override void _OnExit()
        {
            WorldManager.Instance.TerminateWolrd();
            UIManager.Instance.DeactivateUiLayer(UILayerType.GAMESTAGE);
            GameManager.Instance.HandleOnExitGame();
        }
        public override void UpdatePre()
        {
            GameManager.Instance.UpdatePre();
        }
        public override void UpDate()
        {
            GameManager.Instance.Update();
        }
        
        public override void UpdatePost()
        {
            GameManager.Instance.UpdatePost();
        }
        public override SceneType sceneType
        {
            get
            {
                return SceneType.GAMESTAGE;
            }
        }
    }
}