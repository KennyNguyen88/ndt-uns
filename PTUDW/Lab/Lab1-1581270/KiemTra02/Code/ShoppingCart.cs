﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiemTra02.Code
{
    public class ShoppingCart
    {
        #region Properties

        public List<CartItem> Items { get; private set; }

        #endregion

        #region Shopping Cart Constructor
       
        public ShoppingCart()
        {
            if (HttpContext.Current.Session["ASPNETShoppingCart"] == null)
            {
                Items = new List<CartItem>();
                HttpContext.Current.Session["ASPNETShoppingCart"] = Items;
            }
            else
            {
                Items = (List<CartItem>)HttpContext.Current.Session["ASPNETShoppingCart"];
            }
        }
       
        #endregion

        #region Item Modification Methods
        /** 
     * AddItem() - Adds an item to the shopping  
     */
        public void AddItem(int productId)
        {
            // Create a new item to add to the cart  
            CartItem newItem = new CartItem(productId);

            // If this item already exists in our list of items, increase the quantity  
            // Otherwise, add the new item to the list  
            if (Items.Contains(newItem))
            {
                foreach (CartItem item in Items)
                {
                    if (item.Equals(newItem))
                    {
                        item.Quantity++;
                        return;
                    }
                }
            }
            else
            {
                newItem.Quantity = 1;
                Items.Add(newItem);
            }
        }

        /** 
         * SetItemQuantity() - Changes the quantity of an item in the cart 
         */
        public void SetItemQuantity(int productId, int quantity)
        {
            // If we are setting the quantity to 0, remove the item entirely  
            if (quantity == 0)
            {
                RemoveItem(productId);
                return;
            }

            // Find the item and update the quantity  
            CartItem updatedItem = new CartItem(productId);

            foreach (CartItem item in Items)
            {
                if (item.Equals(updatedItem))
                {
                    item.Quantity = quantity;
                    return;
                }
            }
        }

        /** 
         * RemoveItem() - Removes an item from the shopping cart 
         */
        public void RemoveItem(int productId)
        {
            CartItem removedItem = new CartItem(productId);
            Items.Remove(removedItem);
        }
        #endregion

        #region Reporting Properties
        

        public decimal TotalCost
        {
            get
            {
                decimal subTotal = 0;
                foreach (CartItem item in Items)
                    subTotal += item.TotalPrice;

                return subTotal;
            }
        }

        public int TotalItemCount
        {
            get
            {
                int total = 0;
                foreach (CartItem item in Items)
                    total += item.Quantity;

                return total;
            }
        }
        #endregion
    }
}