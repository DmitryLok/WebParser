﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WebParser.App
{
    public interface IRepository
    {
        float QueryFindImdbByFilmName(string filmName);
        Bitmap QueryFindSpaceObjectImageByName(string spaceObjectName);
    }
}
