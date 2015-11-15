using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


/// <summary>
/// WS_T6WMS 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
// [System.Web.Script.Services.ScriptService]
public class WS_T6WMS : System.Web.Services.WebService {

    public WS_T6WMS () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    /// <summary>
    /// 登陆用户
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    [WebMethod]
    public UA_User QueryUA_User(UA_User user)
    {
        return new DAO.UA_User_DAO().Query(user).FirstOrDefault();
    }

    /// <summary>
    /// 根据barcode 获取存货档案
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public Inventory QueryInventoryForBarCode(string barcode)
    {
        return new DAO.Inventory_DAO().Query(param: new Inventory { cBarCode = barcode }).FirstOrDefault();
    }

    /// <summary>
    /// 创建出入库单据
    /// </summary>
    /// <param name="RdRecord"></param>
    /// <returns></returns>
    [WebMethod]
    public bool CreateRdRecord(RdRecord RdRecord)
    {
        return new DAO.RdRecord_DAO().SaveRdRecord(RdRecord);
    }

    /// <summary>
    /// 创建盘点单
    /// </summary>
    /// <param name="CheckVouch"></param>
    /// <returns></returns>
    [WebMethod]
    public bool CreateCheckVouch(CheckVouch CheckVouch)
    {
        return new DAO.CheckVouch_DAO().SaveCheckVouch(CheckVouch);
    }

    /// <summary>
    /// 获取仓库档案
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<Entity.Warehouse> QueryWarehouse()
    {
        return new DAO.Warehouse_DAO().Query(param: new Warehouse()).ToList();
    }

    /// <summary>
    /// 获取供应商列表
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<Entity.Vendor>  QueryVendor()
    {
        return new DAO.Vendor_DAO().Query(param: new Vendor()).ToList();
    }

    /// <summary>
    /// 出入库类别
    /// </summary>
    /// <param name="brdflag"></param>
    /// <returns></returns>
    [WebMethod]
    public List<Entity.Rd_Style> QueryRd_Style(int brdflag)
    {
        return new DAO.Rd_Style_DAO().Query(param: new Rd_Style { bRdFlag = brdflag , bRdEnd = true }).ToList();
    }

    /// <summary>
    /// 获取部门主数据
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<Entity.Department> QueryDepartment()
    {
        return new DAO.Department_DAO().Query(param: new Department()).ToList();
    }
}
