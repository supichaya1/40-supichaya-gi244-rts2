using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
<<<<<<< HEAD
using UnityEngine.UI;

=======
using UnityEngine.UI;   
    
>>>>>>> 3dcc0656f223033f819d453d2cde4a81cae89834
public class InfoManager : MonoBehaviour
{
    [SerializeField] private Image unitPic, hpIcon, rsrcIcon, moveIcon, atkIcon, amrIcon, vslRngIcon, wpRngIcon;
    [SerializeField] private TextMeshProUGUI nameTxt, hpTxt, rsrcTxt, moveTxt, atkTxt, amrTxt, vslRngTxt, wpRngTxt;
<<<<<<< HEAD
    
    public static InfoManager instance;

    void Awake()
    {
        instance = this;
    }
=======

    public static InfoManager instance;
    private void Awake()
    {
        instance = this;
    }

>>>>>>> 3dcc0656f223033f819d453d2cde4a81cae89834
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
     }
    
    private void SetPic(Sprite pic)
    {
        unitPic.color = Color.white;
        unitPic.sprite = pic;
    }
<<<<<<< HEAD
    private void SetPic(Sprite pic)
    {
        unitPic.color = Color.white;
        unitPic.sprite = pic;
    }
=======
    
>>>>>>> 3dcc0656f223033f819d453d2cde4a81cae89834
    public void ShowAllInfo(Unit unit)
    {
        SetPic(unit.UnitPic);
        nameTxt.text = unit.UnitName;

        hpIcon.color = Color.white;
        hpTxt.text = $"{unit.CurHP}/{unit.MaxHP}";

        moveIcon.color = Color.white;
        moveTxt.text = unit.MoveSpeed.ToString();

        atkIcon.color = Color.white;
        atkTxt.text = $"{unit.MinWpnDamage}-{unit.MaxWpnDamage}";

        amrIcon.color = Color.white;
        amrTxt.text = $"{unit.Armour}";

        vslRngIcon.color = Color.white;
        vslRngTxt.text = $"{unit.VisualRange}";

        wpRngIcon.color = Color.white;
        wpRngTxt.text = $"{unit.WeaponRange}";
    }
<<<<<<< HEAD
=======
    
>>>>>>> 3dcc0656f223033f819d453d2cde4a81cae89834
    public void ClearAllInfo()
    {
        //Clear Pic
        unitPic.color = Color.clear;
        nameTxt.text = "";

        hpIcon.color = Color.clear;
        hpTxt.text = "";

        moveIcon.color = Color.clear;
        moveTxt.text = "";

        atkIcon.color = Color.clear;
        atkTxt.text = "";

        amrIcon.color = Color.clear;
        amrTxt.text = "";

        vslRngIcon.color = Color.clear;
        vslRngTxt.text = "";

        wpRngIcon.color = Color.clear;
        wpRngTxt.text = "";
    }
    
    public void ShowAllInfo(Building building)
    {
        SetPic(building.StructurePic);
        nameTxt.text = building.StructureName;

        hpIcon.color = Color.white;
        hpTxt.text = $"{building.CurHP}/{building.MaxHP}";
    }
<<<<<<< HEAD
    
    
=======


>>>>>>> 3dcc0656f223033f819d453d2cde4a81cae89834
}
