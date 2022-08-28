using LibreriaApollo.BD;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibreriaApollo.Helpers
{
    class helpers
    {
        public string insertarFechaConFormato(string fecha)
        {
            if (!this.esFechaValida(fecha)) return "";
            string[] separaciones = fecha.Split('/');
            if (separaciones[0].Length == 1)
            {
                separaciones[0] = "0" + separaciones[0];
            }
            if (separaciones[1].Length == 1)
            {
                separaciones[1] = "0" + separaciones[1];
            }
            return separaciones[2] + "/" + separaciones[1] + "/" + separaciones[0];
        }

        public string traerFechaConFormato(string fecha)
        {
            if (!this.esFechaValida(fecha)) return "";
            string[] separaciones = fecha.Split('/');
            if (separaciones[0].Length == 1)
            {
                separaciones[0] = "0" + separaciones[0];
            }
            if (separaciones[0].Length == 1)
            {
                separaciones[1] = "0" + separaciones[1];
            }
            return separaciones[0] + "/" + separaciones[1] + "/" + separaciones[2];
        }

        public bool esFechaValida(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            } catch
            {
                return false;
            }
        }

        public void cargarReporte(string sql, string nombre, ReportViewer reporte) {
            Conexion conexion = new Conexion();

            DataTable consulta = conexion.consultar(sql);
            ReportDataSource data = new ReportDataSource();

            data.Name = nombre;
            data.Value = consulta;
            reporte.LocalReport.DataSources.Clear();
            reporte.LocalReport.DataSources.Add(data);
            reporte.RefreshReport();
        }

        public bool esMesValido(int mes)
        {
            return mes >= 1 && mes <= 12;
        }

        public bool esAnioValido(int anio)
        {
            return anio >= 1950 && anio <= DateTime.Now.Year;
        }
    }
}
