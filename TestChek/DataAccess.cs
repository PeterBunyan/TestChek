using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestChek.Models;
using Dapper;
using System.Data;

namespace TestChek
{
    public class DataAccess
    {
        public List<ResultRecord> GetResultRecord(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnString("DefaultConnection")))
            {
                var dbRecord =  connection.Query<ResultRecord>($"Select * from PatientRecordTable where LastName = '{ lastName }'").ToList();
                return dbRecord;
            }
        }
        //need additional method to query AspNetUsers table for patients. It should return patients first and last name and assign them to variabiables
        //that we can then match to the results table and combine with our test results when we store them all together.

        public string GetId(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnString("DefaultConnection")))
            {
                var userId = connection.Query($"Select Id from AspNetUsers where LastName = '{ lastName }'").ToString();
                return userId;
            }
        }
    }
}