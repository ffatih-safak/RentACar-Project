﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarServices
    {
        List<Car> GetAll();
        List<Car> GetAllByCategory(string id);
        List<Car> GetByUnitModal(int minYear, int maxYear);

        List<CarDetailDto> GetCarDetail();
    }
}
