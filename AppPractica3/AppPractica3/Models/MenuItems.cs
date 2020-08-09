using System;
using System.Collections.Generic;
using System.Text;

namespace AppPractica3.Models
{
    class MenuItems
    {
        public enum MenuItemType
        {
            Home,
            TareasPendientes,
            InformacionPersonal

        }
        public class HomeMenuItem
        {
            public MenuItemType Id { get; set; }

            public string Title { get; set; }
        }
    }
}
