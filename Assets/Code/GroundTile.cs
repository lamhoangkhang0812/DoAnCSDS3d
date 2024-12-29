using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
  public GameObject RaoChanPrefabs;
  public GameObject coinPrefabs;
  private void Start()
  {
    SpawnRaoChan();
    SpawnCoin();
  }
  private void OnTriggerExit(Collider other)
  {
    if (other.gameObject.tag == "Player")
    {
        GroundSpawn.Instance.SpawnTile();
        Destroy(gameObject, 4);
    }
  }
  void SpawnRaoChan()
  {
    int raoChanChiMuc = Random.Range(2,5);
    Transform spawnPoint = transform.GetChild(raoChanChiMuc).transform;
    Instantiate(RaoChanPrefabs,spawnPoint.position,Quaternion.identity,transform);
  }
  void SpawnCoin()
  {
    GameObject temp=Instantiate(coinPrefabs,transform);
    temp.transform.position = RandomPos(GetComponent<Collider>());
  }
  Vector3 RandomPos(Collider collider)
  {
    Vector3 point=new Vector3(
      Random.Range(collider.bounds.min.x,collider.bounds.max.x),
      Random.Range(collider.bounds.min.y,collider.bounds.max.y),
      Random.Range(collider.bounds.min.z,collider.bounds.max.z));
      if(point!=collider.ClosestPoint(point))
    {
      point=RandomPos(collider);
    }
    point.y = 1;
    return point;
  }
}
