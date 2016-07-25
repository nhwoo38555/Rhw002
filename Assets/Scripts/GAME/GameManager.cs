using UnityEngine;
using System.Collections;
using Assets.Scripts.World;
using Assets.Scripts.User;

namespace Assets.Scripts.Game
{
    public sealed class GameManager
    {
        private GameManager() { }
        public void HandleOnEnterGame()
        {
            if(null!=WorldManager.Instance.rootComponet && null!= WorldManager.Instance.rootComponet.playerSpawn)
            {
                GameObject playerGo = WorldManager.Instance.rootComponet.playerSpawn.Spawn();
                UserManager.Instance.SetUserGameObject(playerGo);
                UserManager.Instance.SetPlayerCamera(WorldManager.Instance.rootComponet.playerCamera);
            }           

        }
        public void HandleOnExitGame()
        {

        }
        public void UpdatePre()
        {
            UserManager.Instance.UpdateCustomPre();
        }
        public void Update()
        {
            UserManager.Instance.UpdateCustom();
        }
        public void UpdatePost()
        {

        }
        #region SINGLETON
        private static GameManager _instance = null;
        public static GameManager Instance { get { if (null != _instance) { return _instance; } else { return (_instance = new GameManager()); } } }
        #endregion
    }
}