﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeckAnalyzer.Common;

namespace DeckAnalyzer.Data
{
    public interface IDeckFileWriter
    {
        void WriteDeck(IDeck deck, string outputLocation);
    }
}
