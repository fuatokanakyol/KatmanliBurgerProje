﻿using KatmanliBurger_DATA.Concretes;

namespace KatmanliBurger_DATA.DomainModels
{
	public class BasketLine
    {
        public ByProduct ByProduct { get; set; }
        public Menu Menu { get; set; }
        public Burger Burger { get; set; }
        public int ByProductQuantity { get; set; }
        public int MenuQuantity { get; set; }
        public int BurgerQuantity { get; set; }
		public string Description { get; set; }
	}
}
