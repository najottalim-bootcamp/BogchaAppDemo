﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Domain.Entities;

public class MealPlan
{
    public string DateName { get; set; }
    public string MealNo { get; set; }
    public string AM_Snack { get; set; }
    public string Lunch { get; set; }
    public string Fruit { get; set; }
    public string PM_Snack { get; set; }
}
