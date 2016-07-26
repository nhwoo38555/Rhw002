using UnityEngine;
using System.Collections;

namespace Assets.Scripts.World
{

    public class MonsterSpawn3 : MonoBehaviour
    {
        public GameObject Spawn()
        {
            if (null != this._monsterObject3)
            {
                return GameObject.Instantiate(this._monsterObject3, base.transform.position, base.transform.rotation) as GameObject;
            }
            return null;
        }



        [SerializeField]
        private UnityEngine.Object _monsterObject3 = null;
    }


}