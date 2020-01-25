﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BBGFrontEnd.Models
{
    public class Boardgame
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> Category { get; set; }  // Lijst van categorie id's
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int PlayTime { get; set; }        // Speeltijd in minuten
        public int MinAge { get; set; }
        public string ThumbnailURL { get; set; } // Url met verwijzing naar afbeelding van bordspel. Bron van internet of eigen cdn?
    }
}