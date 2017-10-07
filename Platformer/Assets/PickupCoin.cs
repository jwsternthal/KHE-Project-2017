using UnityEngine;
using System.Collections;
using System.Collections;
using UnityEngine.¡

public class PickupCoin : MonoBehaviour{

  //Use for initialization
  void Start (){

  }

  //Update is called once per frame
  void Update () {

  }

  void OnTriggerEnter2D (Collider2d other)
  {
    if (other.gameObject.CompareTag(Player))
      Destroy(gameObject);
  }
}
