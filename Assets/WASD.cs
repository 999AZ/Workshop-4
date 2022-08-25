using UnityEngine;

public class WASD : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Vertical") > 0)  {
        transform.localPosition += new Vector3(0,0,1);
      }
      if (Input.GetButtonDown("Vertical") < 0)  {
        transform.localPosition -= new Vector3(0,0,1);
      }
      if (Input.GetButtonDown("Horizontal") > 0)  {
        transform.localPosition += new Vector3(1,0,0);
      }
      if (Input.GetButtonDown("Horizontal") < 0)  {
        transform.localPosition -= new Vector3(1,0,0);
      }
    }
}
