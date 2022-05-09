using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTest : MonoBehaviour
{
    [SerializeField] private GameObject Error;
   public void ClickOnlineError()
    {
        StartCoroutine(IEClickOnlineError());
    }
    private IEnumerator IEClickOnlineError()
    {
        Error.gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        Error.gameObject.SetActive(false);


    }
}
