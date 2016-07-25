using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Scene
{
    public sealed class SceneManager
    {
        private SceneManager() { }
        public void Initialize()
        {
            this._curSceneType = SceneType.NONE;
            this._sceneArray = new SceneAbstract[(int)SceneType.MAX];
            this._sceneArray[(int)SceneType.LOBBY] = new SceneLobby();
            this._sceneArray[(int)SceneType.JOIN] = new SceneJoin();
            this._sceneArray[(int)SceneType.GAME] = new SceneGame();
            this._sceneArray[(int)SceneType.GAMELOBBY] = new SceneGameLobby();
            this._sceneArray[(int)SceneType.GAMESCENE] = new SceneGameScene();
            this._sceneArray[(int)SceneType.GAMESTAGE] = new SceneGameStage(); 
            
        }
        public void Terminate()
        {
            this._curSceneType = SceneType.NONE;
            this._sceneArray[(int)SceneType.LOBBY] = null;
            this._sceneArray[(int)SceneType.JOIN] = null;
            this._sceneArray[(int)SceneType.GAME] = null;
            this._sceneArray[(int)SceneType.GAMELOBBY] = null;
            this._sceneArray[(int)SceneType.GAMESCENE] = null;
            this._sceneArray[(int)SceneType.GAMESTAGE] = null;
            this._sceneArray = null;
        }

        public void UpDateCustomPre()
        {
            this._sceneArray[(int)_curSceneType].UpdatePre();
        }
        public void UpDateCustom()
        {
            this._sceneArray[(int)_curSceneType].UpDate();
        }
        public void FixedUpDateCustom()
        {
            this._sceneArray[(int)_curSceneType].FixedUpdate();
        }
        public void UpDateCustomPost()
        {
            this._sceneArray[(int)_curSceneType].UpdatePost();
        }

        public void ChangeSceneRequest(SceneType sceneType_)
        {
            if(this._curSceneType != SceneType.NONE)
            {
                this._sceneArray[(int)_curSceneType].Exit();
            }
            this._sceneArray[(int)sceneType_].Enter();
            _curSceneType = sceneType_;
        }
        public SceneAbstract GetCurScene()
        {
            if(SceneType.NONE != _curSceneType)
            {
                return _sceneArray[(int)_curSceneType];
            }
            return null;
        }
        private SceneType _curSceneType;
        private SceneAbstract[] _sceneArray;

        public SceneType curSceneType { get { return _curSceneType; } }
        #region SINGLETON
        private static SceneManager _instance = null;
        public static SceneManager Instance
        {
            get { if (null != _instance) { return _instance; } else { return (_instance = new SceneManager()); } }
            #endregion

        }
    }
}
