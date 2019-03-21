using System;
using BethanyPieShop.Models;
using System.Collections.Generic;

namespace BethanyPieShop.ViewModels
{
    public class HomeViewModels
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
