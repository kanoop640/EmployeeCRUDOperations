using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;


namespace Repository.Context
{
    public class UserDBContext :DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options):base(options)
        {
        }
        public DbSet<ParkingModel> Parkings
        {
            get;set;
        }
    }
}
