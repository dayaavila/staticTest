//using System;
//using System.Collections.Generic;
//using System.Text;



//using System.Data;


//namespace MetodoStatico4
//{
//    public static class TablasHelper
//    {
//        public static DataTable CreaTablaUsuario()
//        {
//            DataTable dt = new DataTable();
//            DataColumn column;
//            column = new DataColumn();
//            column.DataType = Type.GetType("System.Int32");
//            column.ColumnName = "UsuarioId";
//            dt.Columns.Add(column);
//            column = new DataColumn();
//            column.DataType = Type.GetType("System.String");
//            column.ColumnName = "Correo";
//            dt.Columns.Add(column);
//            column = new DataColumn();
//            column.DataType = Type.GetType("System.String");
//            column.ColumnName = "Nombre";
//            dt.Columns.Add(column);
//            column = new DataColumn();
//            column.DataType = Type.GetType("System.String");
//            column.ColumnName = "Paterno";
//            dt.Columns.Add(column);
//            column = new DataColumn();
//            column.DataType = Type.GetType("System.String");
//            column.ColumnName = "Materno";
//            dt.Columns.Add(column);
//            return dt;
//        }

//        public static DataTable LlenaTablaUsuario(DataTable dt, List usuarios)
//        {
//            foreach (Usuario usuario in usuarios)
//            {
//                DataRow row = dt.NewRow();
//                row["UsuarioId"] = usuario.UsuarioId;
//                row["Correo"] = usuario.Correo;
//                row["Nombre"] = usuario.Nombre;
//                row["Paterno"] = usuario.Paterno;
//                row["Materno"] = usuario.Materno;
//                dt.Rows.Add(row);
//            }
//            return dt;
//        }
//    }

//}
