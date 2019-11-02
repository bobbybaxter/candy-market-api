using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using Dapper;

namespace CandyMarket.Api.Repositories
{
    public class CandyRepository : ICandyRepository
    {
        string _connectionString = "Server = localhost; Database=CandyMarketApi; Trusted_Connection=True;";

        public IEnumerable<Candy> GetAllCandy()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                db.Open();

                var allCandy = db.Query<Candy>("Select * from Candy");

                return allCandy.AsList();
            }
        }

        public bool AddCandy(AddCandyDto newCandy)
        {
            throw new NotImplementedException();
        }

        public bool EatCandy(int candyIdToDelete)
        {
            throw new NotImplementedException();
        }
    }
}