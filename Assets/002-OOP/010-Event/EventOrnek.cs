using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOrnek : MonoBehaviour
{
    /*
     * Eventler tetiklenene olaylardır ve delegatelerden türerler. Ornegin Onclick ya da textChange eventi.
     
     * Event Nasıl Yazılı?
     Event yazılması için öncelikle o eventin delegate'inin yazılması gereklidir. Yani o event içine alacağı metodun ne tür bir metot oldugunu bilmesi gerekir.
     
     
     
     */

    delegate void ODelegate(); 
    event ODelegate OEvent;

    //Action//


    //event Action OrnekEvent;//system kütüphanesi eklenir ctrl . ile ampul direk açılır
    public event Action<int, int, int> OrnekAction;
    //değer döndürmeyen ve int tipinde 3 parametre alan action yani event.

    void Deneme() 
    {
        OrnekAction += EventOrnek_OrnekAction;
        OrnekAction += EventOrnek_OrnekAction1;
        OrnekAction -= EventOrnek_OrnekAction2;
        
    
    }

    private void EventOrnek_OrnekAction2(int arg1, int arg2, int arg3)
    {
        throw new NotImplementedException();
    }

    private void EventOrnek_OrnekAction1(int arg1, int arg2, int arg3)
    {
        throw new NotImplementedException();
    }

    private void EventOrnek_OrnekAction(int arg1, int arg2, int arg3)
    {
        
    }
}
