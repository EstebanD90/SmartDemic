using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.PatenteFamilia.Entity;
using Framework.PatenteFamilia.Data;
using System.Transactions;

namespace Framework.PatenteFamilia.Business
{
    public static class FamiliaBLL
    {
        //public static void Insert(Familia f)
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        try
        //        {
        //            if (!Exists(f))
        //            {
        //                FamiliaDAL.Insert(f);
        //                foreach (FamiliaComponent component in f.accesos)
        //                {
        //                    if (component.GetType().Name == "Familia")
        //                    {
        //                        FamiliaFamiliaDAL.Insert(f.id, component.id);
        //                    }
        //                    else
        //                    {
        //                        FamiliaPatenteDAL.Insert(f.id, component.id);
        //                    }
        //                }
        //            }
        //            scope.Complete();
        //        }
        //        catch (Exception ex)
        //        {
        //            scope.Dispose();
        //            throw ex;
        //        }
        //    }

        //}

        //public static bool Exists(Familia f)
        //{
        //    return FamiliaDAL.Exists(f);
        //}

        //public static void Delete(Familia f)
        //{
        //    FamiliaDAL.Delete(f);
        //}

        //public static List<Familia> GetAll()
        //{
        //    var familias = new List<Familia>();
        //    foreach (Familia f in FamiliaDAL.GetAll())
        //    {
        //        familias.Add(GetByName(f.nombre));
        //    }
        //    return familias;
        //}

        ////Devuelve la familia con todos sus accesos
        //public static Familia GetByName(string name)
        //{
        //    var familia = FamiliaDAL.GetByName(name);
        //    var patentes = FamiliaPatenteDAL.FindAllByFamilia(familia.id);
        //    foreach (Patente p in patentes) familia.Agregar(p);
        //    var familias = FamiliaFamiliaDAL.FindAllByFamilia(familia.id);
        //    foreach (Familia f in familias)
        //    {
        //        familia.Agregar(GetByName(f.nombre));
        //    }
        //    return familia;
        //}

        //public static void Update(Familia f)
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        try
        //        {
        //            FamiliaDAL.Update(f);
        //            FamiliaFamiliaDAL.DeleteByFamilia(f.id);
        //            FamiliaPatenteDAL.DeleteByFamilia(f.id);
        //            foreach (FamiliaComponent component in f.accesos)
        //            {
        //                if (component.GetType().Name == "Familia")
        //                {
        //                    FamiliaFamiliaDAL.Insert(f.id, component.id);
        //                }
        //                else
        //                {
        //                    FamiliaPatenteDAL.Insert(f.id, component.id);
        //                }
        //            }
        //            scope.Complete();
        //        }
        //        catch (Exception ex)
        //        {
        //            scope.Dispose();
        //            throw ex;
        //        }
        //    }


        //}
    }
}
