using EasyFramework.Attr;
using EasyFramework.Core.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeAutogenerationTool.Helper
{
    /// <summary>
    /// MS Sql代码自动生成
    /// </summary>
    class MSSqlAutoGenerationHelper
    {
        public static string path = "";//生成代码路径
        public static string nameSpace = "";//命名空间

        /// <summary>
        /// 生成MVC中的MC
        /// </summary>
        /// <param name="modelProperties">类字段信息</param>
        /// <param name="modelAttribute">表信息</param>
        /// <returns>返回true表示生成成功, 否则失败</returns>
        public static bool GenerateMC(List<ModelProperty> modelProperties, ModelAttribute modelAttribute)
        {
            return GenerateModel(modelProperties, modelAttribute) && GenerateController(modelAttribute);
        }

        /// <summary>
        /// 生成Model
        /// </summary>
        /// <param name="modelProperties">类字段信息</param>
        /// <param name="modelAttribute">表信息</param>
        /// <returns>返回true表示生成成功, 否则失败</returns>
        public static bool GenerateModel(List<ModelProperty> modelProperties, ModelAttribute modelAttribute)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;\n");
            //sb.Append("using EasyFramework.Attr;\n");
            //sb.Append("using EasyFramework.Models;\n");
            //sb.Append(string.Format("namespace {0}.Models\n", nameSpace));
            sb.Append(string.Format("namespace {0}\n", nameSpace));
            sb.Append("{\n");
            //sb.Append(string.Format("    [Model(\"{0}\", \"{1}\")]\n", modelAttribute.TableName, modelAttribute.PrimaryKey));
            //sb.Append(string.Format("    public class {0} : BaseModel\n", modelAttribute.TableName));
            sb.Append(string.Format("    public class {0}\n", modelAttribute.TableName));
            sb.Append("    {\n");
            foreach (ModelProperty modelProperty in modelProperties)
            {
                //字段类型
                string type = "";
                //字段长度信息
                string lengthInfo = "";
                //字段默认值
                string _default = string.IsNullOrEmpty(modelProperty.Default) ? "" : string.Format(", Default = \"{0}\"", modelProperty.Default);
                //说明
                string explain = string.IsNullOrEmpty(modelProperty.Explain) ? "" : string.Format(", Explain = \"{0}\"", modelProperty.Explain);
                //能否为空
                string IsNull = string.Format(", IsNull = {0}", modelProperty.IsNull.ToString().ToLower());
                switch (MSDBType.GetTypeBySqlTypeName(modelProperty.ColType).Name)
                {
                    case "String":
                        type = "string";
                        lengthInfo = string.Format(", MinLength = {0}, MaxLength = {1}", modelProperty.MinLength, modelProperty.MaxLength);
                        break;
                    case "Int32":
                        type = "int";
                        break;
                    case "Boolean":
                        type = "bool";
                        break;
                    case "DateTime":
                        type = "DateTime";
                        break;
                    case "Double":
                        type = "double";
                        break;
                }
                sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n", modelProperty.Explain));
                //sb.Append(string.Format("        [ModelProperty(\"{0}\", \"{1}\"{2}{3}{4}{5})]\n", modelProperty.ColName, modelProperty.ColType, lengthInfo, _default, explain, IsNull));
                sb.Append(string.Format("        public {0} {1} {2}\n\n", type, modelProperty.ColName, "{ get; set; }"));
            }
            sb.Append("    }\n");
            sb.Append("}");
            try
            {
                FileStream fs = new FileStream(string.Format("{0}/CodeAutoGeneration/Models/{1}.cs", path, modelAttribute.TableName), FileMode.Create);
                byte[] bytes = Encoding.UTF8.GetBytes(sb.ToString());
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                GenerateLog4Net();
            }
            catch (Exception e)
            {
                string sss = e.Message;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 生成MVC中的C
        /// </summary>
        /// <param name="modelAttribute">表信息</param>
        /// <returns>true表示生成成功 否则 失败</returns>
        public static bool GenerateController(ModelAttribute modelAttribute)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;\n");
            sb.Append("using System.Web;\n");
            sb.Append("using System.Web.Mvc;\n");
            sb.Append("using System.Collections.Generic;\n");
            sb.Append("using EasyFramework.Core;\n");
            sb.Append(string.Format("namespace {0}.Controllers\n", nameSpace));
            sb.Append("{\n");
            sb.Append(string.Format("    public class {0}Controller : BaseController\n", modelAttribute.TableName));
            sb.Append("    {\n");
            sb.Append("        public ActionResult Index()\n");
            sb.Append("        {\n");
            sb.Append("            return View();\n");
            sb.Append("        }\n");
            sb.Append("    }\n");
            sb.Append("}\n");
            try
            {
                FileStream fs = new FileStream(string.Format("{0}/Controllers/{1}Controller.cs", path, modelAttribute.TableName), FileMode.Create);
                byte[] bytes = Encoding.UTF8.GetBytes(sb.ToString());
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                GenerateLog4Net();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 生成三层中的DAL
        /// </summary>
        /// <param name="modelProperties">类字段信息</param>
        /// <param name="modelAttribute">表信息</param>
        /// <returns>返回true表示生成成功, 否则失败</returns>
        public static bool GenerateDAL(List<ModelProperty> modelProperties, ModelAttribute modelAttribute)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;\n");
            sb.Append("using Pb.WCS.CCS.Data;\n");
            sb.Append("using System.Data;\n");
            sb.Append("using System.Collections;\n");
            sb.Append("using System.Collections.Generic;\n");
            sb.Append("using Pb.WCS.CCS.Data.CommonFolder;\n");
            sb.Append(string.Format("namespace {0}\n", nameSpace));
            sb.Append("{\n");
            sb.Append(string.Format("    public class {0}Adapter\n", modelAttribute.TableName));
            sb.Append("    {\n");

            string primaryKey = modelAttribute.PrimaryKey;//主键
            string adapter = modelAttribute.TableName + "Adapter";
            string tableName = modelAttribute.TableName;
            sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n", tableName));
            sb.Append(string.Format("        private string tableName = \"{0}\";\n\n", tableName));

            //实体名称
            string strEntity = "AdapterEntityList";
            sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n", "Adapter中的EntityList"));
            sb.Append(string.Format("        public static List<{0}> {1} {2}\n\n", tableName, strEntity, "{ get; set; }"));

            //方法
            #region 新增
            string funcName = "新增";
            string paramName = "<param name=\"objEntity\"></param>";
            string param = "objEntity";
            sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n        /// {1}\n", funcName, paramName));
            sb.Append(string.Format("        public int Add({0} {1})\n", tableName, param));
            sb.Append("        {\n");

            sb.Append(string.Format("           int result = -1;\n"));
            sb.Append(string.Format("           try\n"));
            sb.Append("           {\n");
            sb.Append(string.Format("               string sql = @\"INSERT INTO[{0}]\" +\n", tableName));
            sb.Append(string.Format("               \"( "));

            string colList = string.Empty;
            string paramList = string.Empty;
            StringBuilder paramHash = new StringBuilder();
            paramHash.Append(string.Format("               Hashtable pH = new Hashtable();\n"));
            foreach (ModelProperty modelProperty in modelProperties)
            {
                string colName = modelProperty.ColName;
                if (colName == "ID")
                {
                    continue;
                }
                else
                {
                    colList += colName + ",";
                    paramList += "@" + colName + ",";
                    paramHash.Append(string.Format("               pH.Add(\"@{0}\", objEntity.{0});\n", colName));
                }
            }
            sb.Append(string.Format("{0})\" + \n", colList.TrimEnd(',')));
            sb.Append(string.Format("               \" VALUES\" + \n"));
            sb.Append(string.Format("               \"( "));
            sb.Append(string.Format("{0})\"; \n\n", paramList.TrimEnd(',')));
            sb.Append(paramHash + "\n");
            sb.Append(string.Format("               Global.mainSQLServer.ExecuteNonQuery(sql, pH);\n"));
            sb.Append(string.Format("               result = 1; \n"));
            sb.Append("           }\n");

            sb.Append(string.Format("           catch (Exception ex)\n"));
            sb.Append("           {\n");
            sb.Append("           }\n");

            sb.Append(string.Format("           return result;\n"));

            sb.Append("       }\n");
            #endregion

            #region 修改
            funcName = "修改";
            paramName = "<param name=\"objEntity\"></param>";
            param = "objEntity";
            sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n        /// {1}\n", funcName, paramName));
            sb.Append(string.Format("        public int Update({0} {1})\n", tableName, param));
            sb.Append("        {\n");

            sb.Append(string.Format("           int result = -1;\n"));
            sb.Append(string.Format("           try\n"));
            sb.Append("           {\n");
            sb.Append(string.Format("               string sql = @\"UPDATE [{0}] SET \" +\n", tableName));

            string updateList = string.Empty;
            StringBuilder paramHash2 = new StringBuilder();
            paramHash2.Append(string.Format("               Hashtable pH = new Hashtable();\n"));
            foreach (ModelProperty modelProperty in modelProperties)
            {
                string colName = modelProperty.ColName;
                if (colName == "ID")
                {
                    continue;
                }
                else
                {
                    updateList += string.Format("{0} = @{0}",colName) + ",";
                    paramHash2.Append(string.Format("               pH.Add(\"@{0}\", objEntity.{0});\n", colName));
                }
            }
            sb.Append(string.Format("               \"{0}\" + \n", updateList.TrimEnd(',')));
            sb.Append(string.Format("               \" WHERE \" +\n"));
            sb.Append(string.Format("               \" {0} = '\" + objEntity.{0} + \"'\";\n\n", primaryKey));
            sb.Append(paramHash2 + "\n");
            sb.Append(string.Format("               Global.mainSQLServer.ExecuteNonQuery(sql, pH);\n"));
            sb.Append(string.Format("               result = 1; \n"));
            sb.Append("           }\n");

            sb.Append(string.Format("           catch (Exception ex)\n"));
            sb.Append("           {\n");
            sb.Append("           }\n");

            sb.Append(string.Format("           return result;\n"));

            sb.Append("       }\n");
            #endregion

            #region 删除
            funcName = "删除";
            paramName = "<param name=\"objEntity\"></param>";
            param = "objEntity";
            sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n        /// {1}\n", funcName, paramName));
            sb.Append(string.Format("        public int Delete({0} {1})\n", tableName, param));
            sb.Append("        {\n");

            sb.Append(string.Format("           int result = -1;\n"));
            sb.Append(string.Format("           try\n"));
            sb.Append("           {\n");
            sb.Append(string.Format("               string sql = @\"DELETE FROM [{0}] \" +\n", tableName));
            
            sb.Append(string.Format("               \" WHERE \" +\n"));
            sb.Append(string.Format("               \" {0} = '\" + objEntity.{0} + \"'\";\n\n",primaryKey));
            sb.Append(paramHash2 + "\n");
            sb.Append(string.Format("               Global.mainSQLServer.ExecuteNonQuery(sql, pH);\n"));
            sb.Append(string.Format("               result = 1; \n"));
            sb.Append("           }\n");

            sb.Append(string.Format("           catch (Exception ex)\n"));
            sb.Append("           {\n");
            sb.Append("           }\n");

            sb.Append(string.Format("           return result;\n"));

            sb.Append("       }\n");
            #endregion

            #region 查询
            funcName = "获取所有的Entity";
            sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n", funcName));
            sb.Append(string.Format("         public List<{0}> GetAllEntityList()\n", tableName));
            sb.Append("        {\n");

            sb.Append(string.Format("           try\n"));
            sb.Append("           {\n");
            sb.Append(string.Format("               string sql = @\"SELECT * FROM [{0}] \";\n", tableName));

            sb.Append(string.Format("               DataSet ds = Global.mainSQLServer.ExecuteDataSet(sql);\n"));
            sb.Append(string.Format("               return getListFromDataSet(ds); \n"));
            sb.Append("           }\n");

            sb.Append(string.Format("           catch (Exception ex)\n"));
            sb.Append("           {\n");
            sb.Append(string.Format("               return null; \n"));
            sb.Append("           }\n");

            sb.Append("       }\n");
            #endregion

            #region 数据类型转换
            funcName = string.Format("根据:{0}数据集获取数据列表",tableName);
            sb.Append(string.Format("        /// <summary>\n        /// {0}\n        /// </summary>\n", funcName));
            sb.Append(string.Format("         private List<{0}> getListFromDataSet(DataSet ds)\n", tableName));
            sb.Append("        {\n");

            sb.Append(string.Format("           try\n"));
            sb.Append("           {\n");
            sb.Append(string.Format("               List<{0}> result = new List<{0}>();\n", tableName));
            sb.Append(string.Format("               if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)\n", tableName));
            sb.Append("               {\n");
            sb.Append("                   return result;\n");
            sb.Append("               }\n");

            sb.Append(string.Format("               for (int i = 0; i < ds.Tables[0].Rows.Count; i++)\n", tableName));
            sb.Append("               {\n");
            sb.Append("                   DataRow row = ds.Tables[0].Rows[i];\n");
            sb.Append(string.Format("                   {0} newObj = new {0}\n",tableName));
            sb.Append("                   {\n");
            foreach(ModelProperty modelProperty in modelProperties)
            {
                string dataType = modelProperty.ColType;
                string colName = modelProperty.ColName;
                if(dataType.ToUpper() == "varchar".ToUpper())
                {
                    sb.Append(string.Format("                       {0} = row[\"{0}\"].ConvertString(),\n", colName));
                }
                else if (dataType.ToUpper() == "smallint".ToUpper())
                {
                    sb.Append(string.Format("                       {0} = row[\"{0}\"].ConvertInt32(),\n", colName));
                }
                else if(dataType.ToUpper() == "int".ToUpper())
                {
                    sb.Append(string.Format("                       {0} = row[\"{0}\"].ConvertInt32(),\n", colName));
                }
                else if(dataType.ToUpper() == "bigint".ToUpper())
                {
                    sb.Append(string.Format("                       {0} = row[\"{0}\"].ConvertInt32(),\n", colName));
                }
                else if(dataType.ToUpper() == "datetime".ToUpper())
                {
                    sb.Append(string.Format("                       {0} = Convert.ToDateTime(row[\"{0}\"]),\n", colName));
                }
                else
                {
                    sb.Append(string.Format("                       {0} = row[\"{0}\"].ConvertString(),\n", colName));
                }
            }
            sb.Append("                   };\n");
            sb.Append("                   result.Add(newObj);\n");
            sb.Append("               }\n");
            
            sb.Append(string.Format("               return result; \n"));
            sb.Append("           }\n");

            sb.Append(string.Format("           catch (Exception ex)\n"));
            sb.Append("           {\n");
            sb.Append(string.Format("               return null; \n"));
            sb.Append("           }\n");

            sb.Append("       }\n");
            #endregion

            sb.Append("    }\n");
            sb.Append("}");
            try
            {
                FileStream fs = new FileStream(string.Format("{0}/CodeAutoGeneration/Adapter/{1}.cs", path, adapter), FileMode.Create);
                byte[] bytes = Encoding.UTF8.GetBytes(sb.ToString());
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                GenerateLog4Net();
            }
            catch (Exception e)
            {
                string sss = e.Message;
                return false;
            }
            return true;
        }

        #region 公用配置创建

        /// <summary>
        /// 生成log4net配置文件
        /// </summary>
        private static void GenerateLog4Net()
        {
            if (!Directory.Exists(path + @"\bin"))
            {
                Directory.CreateDirectory(path + @"\bin");
            }
            if (!File.Exists(path + @"\bin\Log4Net.config"))
            {
                bool c = File.Exists("Log4Net.config");
                File.Copy("Log4Net.config", path + "/bin/Log4Net.config");
            }
        }

        #endregion
    }
}
