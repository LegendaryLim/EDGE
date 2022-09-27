using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
public class UserBox : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI UserName = null;
    [SerializeField] private TextMeshProUGUI UserInfo = null;

    [PunRPC]
    public void InitUserUI(string name, string rating, string games, int ID, Vector3 position)
    {
        UserName.text = name;
        this.transform.position = position;
        Transform tr = null;
        tr.position = position;
        tr.rotation = Quaternion.identity;
        this.transform.SetParent(tr);
        if (ID == 1)
        {
            UserInfo.alignment = TextAlignmentOptions.MidlineLeft;
        }
        else
        {
            UserInfo.alignment = TextAlignmentOptions.MidlineRight;
        }
        UserInfo.text = "Rating : " + rating + "%\n" + "Games : " + games;
    }
}
