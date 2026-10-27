using UnityEngine;

public class ObjectPickup : MonoBehaviour
{
    [SerializeField] private Transform hand;
    private GameObject currentItem = null;
    private Rigidbody itemRigidbody;
    private Collider itemCollider;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Item") && currentItem == null)
        {    
            if (Input.GetKeyDown(KeyCode.E))
            { 
                Pick(other.gameObject);
            }
        }
    }

    private void Pick(GameObject item)
    {
        currentItem = item;

        itemRigidbody = item.GetComponent<Rigidbody>();
        itemCollider = item.GetComponent<Collider>();

        //Guarda la configuracion fisica original
        if (itemRigidbody != null)
        {
            itemRigidbody.isKinematic = true;
            itemRigidbody.useGravity = false;
        }

        if (itemCollider != null)
        {
            itemCollider.enabled = false;
        }
        //asociar el objeto a la mano dl player
        item.transform.SetParent(hand);
        item.transform.localPosition = Vector3.zero;
        item.transform.localRotation = Quaternion.identity;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && currentItem != null)
        {
            DropItem();
        }
    }

    public GameObject DropItem()
    {
        GameObject temp = currentItem;

        if (temp == null)
        {
            return null;
        }

        temp.transform.SetParent(null);

        //temp.transform.position = hand.position + transform.forward * 1.5f;

        if (itemCollider != null)
        {
            itemCollider.enabled = true;
        }
        if (itemRigidbody != null)
        {
            itemRigidbody.isKinematic = false;
            itemRigidbody.useGravity = true;
        }

        currentItem = null;
        itemRigidbody = null;
        itemCollider = null;

        return temp;
    }
}

