﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Domain.Commands.CategoryCommand;

namespace Market.Domain.Validations.CategoryValidation
{
    public class CategoryDeleteCommandValidation : CategoryValidation<CategoryDeleteCommand>
    {
        public CategoryDeleteCommandValidation()
        {
            ValidateId();
        }
    }
}