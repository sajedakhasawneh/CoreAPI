﻿using System;
using System.Collections.Generic;

namespace AngularApp.Server.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
