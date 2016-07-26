using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;

namespace Assets.Scripts.World
{

    public class MonsterSpawn2 : MonoBehaviour
    {
        public GameObject Spawn()
        {
            if (null != this._monsterObject2)
            {
                return GameObject.Instantiate(this._monsterObject2, base.transform.position, base.transform.rotation) as GameObject;
            }
            return null;
        }
        


        [SerializeField]
        private UnityEngine.Object _monsterObject2 = null;
    }


}