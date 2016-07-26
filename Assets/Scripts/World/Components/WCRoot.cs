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
                this.monsterSpawn = this.worldGo.GetComponentInChildren<MonsterSpawn>();
                this.monsterSpawn2 = this.worldGo.GetComponentInChildren<MonsterSpawn2>();
                this.monsterSpawn3 = this.worldGo.GetComponentInChildren<MonsterSpawn3>();
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
        public MonsterSpawn monsterSpawn { get; private set; }
        public MonsterSpawn2 monsterSpawn2 { get; private set; }
        public MonsterSpawn3 monsterSpawn3 { get; private set; }
    }
}
