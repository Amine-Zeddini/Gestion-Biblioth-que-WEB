﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Booker.Models;

namespace Booker.ViewModels
{
    public class LivreEtudiantViewModel
    {
        public Livre Livre { get; set; }
        public bool RentedBySession { get; set; }
    }
}