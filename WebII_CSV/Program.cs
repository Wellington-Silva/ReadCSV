using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;
using System.Data;

namespace WebII
{
    public class LerCSV
    {
        public static void Main()
        {
            string nome, categoria, ementa;
            int periodo, creditos, horaAula, horaRelogio, qtdTeorica, qtdPratica;
            decimal dificuldade;
            string path = @"C:\Users\Wellington\Documents\Git\WebII_CSV\Data\Files_CSV\disciplinas.csv";
            
            using StreamReader CSV = new (path);
            string line = CSV.ReadLine();

            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WebII;Data Source=DESKTOP-Q3N926N\\SQLEXPRESS";
            SqlConnection sqlConn = new (connectionString);
            SqlCommand cmd;
            sqlConn.Open();

            while (!CSV.EndOfStream)
            {
                try
                {
                    line = CSV.ReadLine();
                    string[] records = line.Split(';');
                    
                    nome = (records[0] != "") ? records[0] : "";
                    periodo = (records[1] == "") ? Convert.ToInt32(records[1]) : 0;
                    categoria = (records[2] != "") ? records[2] : "";
                    dificuldade = (records[3] != "") ? Convert.ToDecimal(records[3]) : 0;
                    creditos = (records[4] != "") ? int.Parse(records[4]) : 0;
                    horaAula = (records[5] != "") ? Convert.ToInt32(records[5]) : 0;
                    horaRelogio = (records[6] != "") ? Convert.ToInt32(records[6]) : 0;
                    qtdTeorica = (records[7] != "") ? Convert.ToInt32(records[7]) : 0;
                    qtdPratica = (records[8] != "") ? Convert.ToInt32(records[8]) : 0;
                    ementa = (records[9] != "") ? records[9] : "";

                    cmd = new ("INSERT INTO disciplinas (nome, periodo, categoria, dificuldade, Creditos, horaAula, horaRelogio, qtdTeorica, qtdPratica, ementa)" +
                    "VALUES('" + nome + "','" + periodo + "','" + categoria + "','" + dificuldade + "','" + creditos + "','" + horaAula + "','" + horaRelogio + "','" + qtdTeorica + "','" + qtdPratica + "','" + ementa + "')", sqlConn);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    static void DisplaySqlErrors(SqlException exception)
                    {
                        for (int i = 0; i < exception.Errors.Count; i++)
                        {
                            Console.WriteLine("Index do Erro:" + i + "\n" +
                                "Error: " + exception.Errors[i].ToString() + "\n");
                        }
                        Console.ReadLine();
                    }
                    DisplaySqlErrors(e);
                }
            }

            //=======================================================================================

            //PRÉ REQUISITO
            string preRequisito;
            int ID, necessariaPara;
            string pathTwo = @"C:\Users\Wellington\Documents\Git\WebII_CSV\Data\Files_CSV\prerequisito.csv";

            using StreamReader CSV2 = new (path);
            string lineP = CSV.ReadLine();

            while (!CSV2.EndOfStream)
            {
                try
                {
                    lineP = CSV.ReadLine();                   
                    string[] recordsP = lineP.Split(";");
                    Console.WriteLine(recordsP[0]);
                    ID = (recordsP[0] != "") ? Convert.ToInt32(recordsP[0]): 0;
                    preRequisito = (recordsP[1] != "") ? recordsP[1] : "";
                    periodo = (recordsP[2] != "") ? Convert.ToInt32(recordsP[2]) : 0;
                    creditos = (recordsP[3] != "") ? Convert.ToInt32(recordsP[3]) : 0;
                    necessariaPara = (recordsP[4] != "") ? Convert.ToInt32(recordsP[4]) : 0;
                    Console.WriteLine(recordsP);

                    cmd = new ("INSERT INTO preRequisito(ID, disciplina, periodo, creditos, nescessariaPara)" +
                    "VALUES('" + ID + "','" + preRequisito + "','" + periodo + "','" + creditos + "','" + necessariaPara + "')", sqlConn);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    static void DisplaySqlErrors(SqlException exception)
                    {
                        for (int i = 0; i < exception.Errors.Count; i++)
                        {
                            Console.WriteLine("Index do Erro: " + i + "\n" +
                                "Error: " + exception.Errors[i].ToString() + "\n");
                        }
                        Console.ReadLine();
                    }
                    DisplaySqlErrors(e);
                }
            }
            sqlConn.Close();
        }
    }
 }
