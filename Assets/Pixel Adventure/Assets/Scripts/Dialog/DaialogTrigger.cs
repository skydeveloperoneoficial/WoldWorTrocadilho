using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaialogTrigger : MonoBehaviour
{
   public  Dialog dialog;
    public void dialogTrigger()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
