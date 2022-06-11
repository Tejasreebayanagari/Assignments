﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SqlStoreproc
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        private static void SelectProc()
        {
            con = getcon();
            Console.WriteLine("Please Enter the Emp id ");
            string csvariable = Console.ReadLine();
            //cmd = new SqlCommand("select *  from Product ");
            cmd = new SqlCommand("sp_findEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@eid", csvariable));

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               
                Console.WriteLine("Emp Id is : " + dr[0]);
                Console.WriteLine("Emp name is : " + dr[1]);
                Console.WriteLine("Emp Gender is : " + dr[2]);
                Console.WriteLine("Emp Salary is : " + dr[3]);
                Console.WriteLine("Emp Email is : " + dr[4]);
                Console.WriteLine("Emp Department is : " + dr[5]);
                Console.WriteLine("Emp Phoneno is : " + dr[6]);
            }

        }
        static void Main(string[] args)
        {
            SelectProc();
            Console.ReadLine();
        }

        public static SqlConnection getcon()
        {
            con = new SqlConnection("data source = RMGW58ZLPC0942\\SQLEXPRESS; Initial catalog = ZensarDB; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }
    }
}
