﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Caughman
{
    public class ItemGUI : MonoBehaviour
    {

        public Item item;
        private Image image;
        void Start()
        {
            image = GetComponent<Image>();
        }

        
        void Update()
        {
            bool hasItem = Inventory.main.HasItem(item);


            image.enabled = hasItem;
           
        }

        public void HandleClick()
        {
            Inventory.main.itemBeingUsed = item;
        }
    }
}
