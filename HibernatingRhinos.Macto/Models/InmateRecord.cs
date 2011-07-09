﻿using System.Collections.Generic;

namespace HibernatingRhinos.Macto.Models
{
    public class InmateRecord
    {
        public Inmate Inmate { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<StickyNote> StickyNotes { get; set; }

        public InmateRecord()
        {
            Notes = new List<Note>();
            StickyNotes = new List<StickyNote>();
        }
    }
}