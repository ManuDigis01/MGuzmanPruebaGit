using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pintura
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MGuzmanPinturasEntities context = new DL.MGuzmanPinturasEntities())
                {
                    var registros = context.PinturaGetAll().ToList(); 
                    if (registros.Count > 0)
                    {
                        result.Objects = new List<object>();
                        foreach (var registro in registros)
                        {
                            ML.Pintura pintura = new ML.Pintura();


                            pintura.Color = registro.Color;
                            pintura.FechaDeProduccion = Convert.ToString(registro.FechaDeProduccion);
                            pintura.FechaDeCaducacion = Convert.ToString(registro.FechaDeCaducacion);


                    


                            result.Objects.Add(pintura);
                        }
                        result.Correct = true;
                    }

                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessager = ex.Message;
                result.Ex = ex;

            }
            return result;
        }

        public static ML.Result Delete(int id)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MGuzmanPinturasEntities context = new DL.MGuzmanPinturasEntities())
                {
                    var resgitro = context.PinturaDelete(id);

                    if (resgitro > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessager = "No se eliminio";
                    }

                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessager = ex.Message;
                result.Ex = ex;

            }
            return result;
        }



    }
}
