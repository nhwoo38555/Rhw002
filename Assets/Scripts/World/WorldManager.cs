using UnityEngine;
using System.Collections;

namespace Assets.Scripts.World
{
    public sealed class WorldManager
    {
        private WorldManager() { }
        public void InstantiateWorld()
        {
            if (null == this.rootComponet)
            {
                this.rootComponet = GameObject.FindObjectOfType<WCRoot>();
            }
            if (null != this.rootComponet)
            {
                this.rootComponet.InstantiateWorldGameObject();
            }
            }
        public void TerminateWolrd()
        {
            if(null!= this.rootComponet)
            {
                this.rootComponet.TerminateWorldGameObject();
                this.rootComponet = null;
            }
        }
        public WCRoot rootComponet { get; private set; }
        #region SINGLETON
        private static WorldManager _instance = null;
        public static WorldManager Instance { get { if (null != _instance) { return _instance; } else { return (_instance = new WorldManager()); } } }
        #endregion
    }
}

