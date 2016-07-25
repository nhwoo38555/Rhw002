using UnityEngine;
using System.Collections;

namespace Assets.Scripts.World
{
    public class WCRoot : MonoBehaviour
    {
        public void InstantiateWorldGameObject()
        {
               if(null!= this._worldObject && null == this.worldGo)
            {
                this.worldGo = GameObject.Instantiate(this._worldObject) as GameObject;
            }
               if(null!= this.worldGo)
            {
                this.playerSpawn = this.worldGo.GetComponentInChildren<WCPlayerSpawn>();
                this.playerCamera = this.worldGo.GetComponentInChildren<Camera>();
            }
        }
        
        public void TerminateWorldGameObject()
        {
            if(null!= this.worldGo)
            {
                GameObject.Destroy(this.worldGo);
                this.worldGo=null;
            }
        }

        [SerializeField]
        private UnityEngine.Object _worldObject = null;

        public GameObject worldGo { get; private set; }
        public WCPlayerSpawn playerSpawn { get; private set; }
        public Camera playerCamera { get; private set; }
    }
}
