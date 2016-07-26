using UnityEngine;
using System.Collections;

namespace Assets.Scripts.World {

    public class MonsterSpawn : MonoBehaviour
    {
        public GameObject Spawn()
        {
            if(null!= this._monsterObject)
            {
                return GameObject.Instantiate(this._monsterObject, base.transform.position, base.transform.rotation) as GameObject;
            }
            return null;
        }

        public void Destroy()
        {
            if (null != this._monsterObject)
            {
                GameObject.Destroy(_monsterObject);
                _monsterObject = null;
            }
            
        }

       [SerializeField]
        private UnityEngine.Object _monsterObject = null;
    }


}

