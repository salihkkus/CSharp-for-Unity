using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " Trigger alanına girdi!");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + " Trigger alanında kalmaya devam ediyor...");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " Trigger alanından çıktı!");
    }
}

/*
    Türkçe Açıklamalar:
    - OnTriggerEnter(): Başka bir nesne trigger alanına GİRİNCE çalışır.
    - OnTriggerStay(): Başka bir nesne trigger alanında KALDIĞI SÜRECE çalışır.
    - OnTriggerExit(): Başka bir nesne trigger alanından ÇIKINCA çalışır.

    English Explanations:
    - OnTriggerEnter(): Called when another object ENTERS the trigger area.
    - OnTriggerStay(): Called while another object STAYS inside the trigger area.
    - OnTriggerExit(): Called when another object EXITS the trigger area.
*/
