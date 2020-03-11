using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorF1357ascii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] TiposRegistros = { "01", "02", "03", "04", "05", "06" };

            using (System.IO.StreamWriter fileWrite = new StreamWriter(this.txtDestino.Text))
            {
                using (StreamReader fielRead = new StreamReader(this.txtOrigen.Text))
                {
                    String line;
                    while ((line = fielRead.ReadLine()) != null)
                    {

                        switch (line.Substring(0, 2))
                        {
                            case "01":
                                fileWrite.WriteLine("Valor Campo:   Tamaño Campo:     Descripcion campo:");
                                fileWrite.WriteLine(line.Substring(0, 2).PadRight(15) + "  " + line.Substring(0, 2).Length.ToString().PadRight(13) + "      Tipo Registro");
                                fileWrite.WriteLine(line.Substring(2, 11).PadRight(15) + "  " + line.Substring(2, 11).Length.ToString().PadRight(13)+  "      Cuit agente retencion");
                                fileWrite.WriteLine(line.Substring(13, 6).PadRight(15) + "  " + line.Substring(13, 6).Length.ToString().PadRight(13) + "      Periodo informado");
                                fileWrite.WriteLine(line.Substring(19, 2).PadRight(15) + "  " + line.Substring(19, 2).Length.ToString().PadRight(13) + "     Secuencia");
                                fileWrite.WriteLine(line.Substring(21, 4).PadRight(15) + "  " + line.Substring(21, 4).Length.ToString().PadRight(13) + "      Codigo de impuesto");
                                fileWrite.WriteLine(line.Substring(25, 3).PadRight(15) + "  " + line.Substring(25, 3).Length.ToString().PadRight(13) + "      Codigo de concepto");
                                fileWrite.WriteLine(line.Substring(28, 4).PadRight(15) + "  " + line.Substring(28, 4).Length.ToString().PadRight(13) + "      numero de formulario");
                                fileWrite.WriteLine(line.Substring(32, 1).PadRight(15) + "  " + line.Substring(32, 1).Length.ToString().PadRight(13) + "      tipo de presentacion");
                                fileWrite.WriteLine(line.Substring(33, 5).PadRight(15) + "  " + line.Substring(33, 5).Length.ToString().PadRight(13) + "      version del sistema" + "\n");
                                fileWrite.WriteLine("");
                                break;
                            case "02":
                                fileWrite.WriteLine("Valor Campo:   Tamaño Campo:     Descripcion campo:");
                                fileWrite.WriteLine(line.Substring(0, 2).PadRight(15).PadRight(15) +"   " + line.Substring(0, 2).Length.ToString().PadRight(13) + "      Tipo Registro");
                                fileWrite.WriteLine(line.Substring(2, 11).PadRight(15) +"   " + line.Substring(2, 11).Length.ToString().PadRight(13) + "      CUIL");
                                fileWrite.WriteLine(line.Substring(13, 8).PadRight(15) +"   " + line.Substring(13, 8).Length.ToString().PadRight(13) + "      Periodo tbj desde");
                                fileWrite.WriteLine(line.Substring(21, 8).PadRight(15) +"   " + line.Substring(21, 8).Length.ToString().PadRight(13) + "      Periodo trb hasta");
                                fileWrite.WriteLine(line.Substring(29, 2).PadRight(15) +"   " + line.Substring(29, 2).Length.ToString().PadRight(13) + "      Meses");
                                fileWrite.WriteLine(line.Substring(31, 1).PadRight(15) +"   " + line.Substring(31, 1).Length.ToString().PadRight(13) + "      Beneficio");
                                fileWrite.WriteLine(line.Substring(32, 1).PadRight(15) +"   " + line.Substring(32, 1).Length.ToString().PadRight(13) + "      ¿Trabajo larga distancia?" + "\n");
                                fileWrite.WriteLine("");
                                break;
                            case "03":
                                fileWrite.WriteLine("Valor Campo:   Tamaño Campo:     Descripcion campo:");
                                fileWrite.WriteLine(line.Substring(0, 2).PadRight(15) +"   " + line.Substring(0, 2).Length.ToString().PadRight(13) + "      Tipo Registro");
                                fileWrite.WriteLine(line.Substring(2, 11).PadRight(15) +"   " + line.Substring(2, 11).Length.ToString().PadRight(13) + "      CUIL");
                                fileWrite.WriteLine(line.Substring(13, 15).PadRight(15) +"   " + line.Substring(13, 15).Length.ToString().PadRight(13) + "      Remuneracion bruta");
                                fileWrite.WriteLine(line.Substring(28, 15).PadRight(15) +"   " + line.Substring(28, 15).Length.ToString().PadRight(13) + "      Remuneracion no hab");
                                fileWrite.WriteLine(line.Substring(43, 15).PadRight(15) +"   " + line.Substring(43, 15).Length.ToString().PadRight(13) + "      SAC 1 cuota");
                                fileWrite.WriteLine(line.Substring(58, 15).PadRight(15) +"   " + line.Substring(58, 15).Length.ToString().PadRight(13) + "      SAC 2 cuota");
                                fileWrite.WriteLine(line.Substring(73, 15).PadRight(15) +"   " + line.Substring(73, 15).Length.ToString().PadRight(13) + "      Hs extras gravadas");
                                fileWrite.WriteLine(line.Substring(88, 15).PadRight(15) +"   " + line.Substring(88, 15).Length.ToString().PadRight(13) + "      Mov y viaticos rem grv");
                                fileWrite.WriteLine(line.Substring(103, 15).PadRight(15) +"   " + line.Substring(103, 15).Length.ToString().PadRight(13) + "      Pers doc - mat didactico");
                                fileWrite.WriteLine(line.Substring(118, 15).PadRight(15) +"   " + line.Substring(118, 15).Length.ToString().PadRight(13) + "      Rem no alcanzada/ exenta s/ hs extras");
                                fileWrite.WriteLine(line.Substring(133, 15).PadRight(15) +"   " + line.Substring(133, 15).Length.ToString().PadRight(13) + "      Rem exenta hs extras");
                                fileWrite.WriteLine(line.Substring(148, 15).PadRight(15) +"   " + line.Substring(148, 15).Length.ToString().PadRight(13) + "      Mov y viaticos rem exenta");
                                fileWrite.WriteLine(line.Substring(163, 15).PadRight(15) +"   " + line.Substring(163, 15).Length.ToString().PadRight(13) + "      Pers doc - mat didactico exento");
                                fileWrite.WriteLine(line.Substring(178, 15).PadRight(15) +"   " + line.Substring(178, 15).Length.ToString().PadRight(13) + "      Rem otros emp- rem bruta");
                                fileWrite.WriteLine(line.Substring(193, 15).PadRight(15) +"   " + line.Substring(193, 15).Length.ToString().PadRight(13) + "      Rem otros emp- rem bruta");
                                fileWrite.WriteLine(line.Substring(208, 15).PadRight(15) +"   " + line.Substring(208, 15).Length.ToString().PadRight(13) + "      SAC 1 CUOTA otros emp");
                                fileWrite.WriteLine(line.Substring(223, 15).PadRight(15) +"   " + line.Substring(223, 15).Length.ToString().PadRight(13) + "      SAC 2 CUOTA otros emp");
                                fileWrite.WriteLine(line.Substring(238, 15).PadRight(15) +"   " + line.Substring(238, 15).Length.ToString().PadRight(13) + "      Hs extras grv - otros emp");
                                fileWrite.WriteLine(line.Substring(253, 15).PadRight(15) +"   " + line.Substring(253, 15).Length.ToString().PadRight(13) + "      Mov y viaticos grv - otros emp");
                                fileWrite.WriteLine(line.Substring(268, 15).PadRight(15) +"   " + line.Substring(268, 15).Length.ToString().PadRight(13) + "      Docente mat. didactico grv - otros emp");
                                fileWrite.WriteLine(line.Substring(283, 15).PadRight(15) +"   " + line.Substring(283, 15).Length.ToString().PadRight(13) + "      No alcan/ex(sin hs extras)");
                                fileWrite.WriteLine(line.Substring(298, 15).PadRight(15) +"   " + line.Substring(298, 15).Length.ToString().PadRight(13) + "      Exenta hs extras - otros empl");
                                fileWrite.WriteLine(line.Substring(313, 15).PadRight(15) +"   " + line.Substring(313, 15).Length.ToString().PadRight(13) + "      Mov y viaticos exenta- Rem otros empl");
                                fileWrite.WriteLine(line.Substring(328, 15).PadRight(15) +"   " + line.Substring(328, 15).Length.ToString().PadRight(13) + "      Doc mat y diactico exento otros emp");
                                fileWrite.WriteLine(line.Substring(343, 15).PadRight(15) +"   " + line.Substring(343, 15).Length.ToString().PadRight(13) + "      Rem gravada");
                                fileWrite.WriteLine(line.Substring(358, 15).PadRight(15) +"   " + line.Substring(358, 15).Length.ToString().PadRight(13) + "      Rem no grav/ no alcanzada / exenta");
                                fileWrite.WriteLine(line.Substring(373, 17).PadRight(15) +"   " + line.Substring(373, 17).Length.ToString().PadRight(13) + "      Total remuneraciones" + "\n");
                                fileWrite.WriteLine("");
                                break;
                            case "04":
                                fileWrite.WriteLine("Valor Campo:   Tamaño Campo:     Descripcion campo:");
                                fileWrite.WriteLine(line.Substring(0, 2).PadRight(15) +"   " + line.Substring(0, 2).Length.ToString().PadRight(13) + "      Tipo Registro");
                                fileWrite.WriteLine(line.Substring(2, 11).PadRight(15) +"   " + line.Substring(2, 11).Length.ToString().PadRight(13) + "      CUIL");
                                fileWrite.WriteLine(line.Substring(13, 15).PadRight(15) +"   " + line.Substring(13, 15).Length.ToString().PadRight(13) + "      Ap. jub, retiro, pensions o subsidios");
                                fileWrite.WriteLine(line.Substring(28, 15).PadRight(15) +"   " + line.Substring(28, 15).Length.ToString().PadRight(13) + "      Ot. emp.- Ap jub retiro, pensiones o subsidios");
                                fileWrite.WriteLine(line.Substring(43, 15).PadRight(15) +"   " + line.Substring(43, 15).Length.ToString().PadRight(13) + "      Ap. obra social");
                                fileWrite.WriteLine(line.Substring(58, 15).PadRight(15) +"   " + line.Substring(58, 15).Length.ToString().PadRight(13) + "      Ap. obra social otros emp");
                                fileWrite.WriteLine(line.Substring(73, 15).PadRight(15) +"   " + line.Substring(73, 15).Length.ToString().PadRight(13) + "      Cuota sindical");
                                fileWrite.WriteLine(line.Substring(88, 15).PadRight(15) +"   " + line.Substring(88, 15).Length.ToString().PadRight(13) + "      Cuota sindical otros emp");
                                fileWrite.WriteLine(line.Substring(103, 15).PadRight(15) +"   " + line.Substring(103, 15).Length.ToString().PadRight(13) + "      Cuota medico asistencial");
                                fileWrite.WriteLine(line.Substring(118, 15).PadRight(15) +"   " + line.Substring(118, 15).Length.ToString().PadRight(13) + "      Prismas de seg para el caso de muerte");
                                fileWrite.WriteLine(line.Substring(133, 15).PadRight(15) +"   " + line.Substring(133, 15).Length.ToString().PadRight(13) + "      Seguro muerte/ mixtos sujetas al control SSN");
                                fileWrite.WriteLine(line.Substring(148, 15).PadRight(15) +"   " + line.Substring(148, 15).Length.ToString().PadRight(13) + "      Seguro de retiro priv - sujetas  SNN");
                                fileWrite.WriteLine(line.Substring(163, 15).PadRight(15) +"   " + line.Substring(163, 15).Length.ToString().PadRight(13) + "      Adq de cuotaparte FCI");
                                fileWrite.WriteLine(line.Substring(178, 15).PadRight(15) +"   " + line.Substring(178, 15).Length.ToString().PadRight(13) + "      Gastos de sepelio");
                                fileWrite.WriteLine(line.Substring(193, 15).PadRight(15) +"   " + line.Substring(193, 15).Length.ToString().PadRight(13) + "      Gtos. amort e int rodado corredores y viaj de comercio");
                                fileWrite.WriteLine(line.Substring(208, 15).PadRight(15) +"   " + line.Substring(208, 15).Length.ToString().PadRight(13) + "      Donc fiscos Nac/ prov / mun");
                                fileWrite.WriteLine(line.Substring(223, 15).PadRight(15) +"   " + line.Substring(223, 15).Length.ToString().PadRight(13) + "      Dtos oblig por ley nac / prov / munc");
                                fileWrite.WriteLine(line.Substring(238, 15).PadRight(15) +"   " + line.Substring(238, 15).Length.ToString().PadRight(13) + "      Honorarios serv asistencial sant medica y panamerica");
                                fileWrite.WriteLine(line.Substring(253, 15).PadRight(15) +"   " + line.Substring(253, 15).Length.ToString().PadRight(13) + "      Intereses cerd hipotecarios");
                                fileWrite.WriteLine(line.Substring(268, 15).PadRight(15) +"   " + line.Substring(268, 15).Length.ToString().PadRight(13) + "      AP. cap soc / fondos de riesgo soc sgr");
                                fileWrite.WriteLine(line.Substring(283, 15).PadRight(15) +"   " + line.Substring(283, 15).Length.ToString().PadRight(13) + "      Ap. cajas compl/ fondos compensadores de prev/ similares");
                                fileWrite.WriteLine(line.Substring(298, 15).PadRight(15) +"   " + line.Substring(298, 15).Length.ToString().PadRight(13) + "      Alq inmuebles destinos a su casa hab");
                                fileWrite.WriteLine(line.Substring(313, 15).PadRight(15) +"   " + line.Substring(313, 15).Length.ToString().PadRight(13) + "      empleado serv domestico");
                                fileWrite.WriteLine(line.Substring(328, 15).PadRight(15) +"   " + line.Substring(328, 15).Length.ToString().PadRight(13) + "      Gstos mov/viaticos abonados por el empleador");
                                fileWrite.WriteLine(line.Substring(343, 15).PadRight(15) +"   " + line.Substring(343, 15).Length.ToString().PadRight(13) + "      Indumentaria / equipamiento- uso exlusivo caracter obligatorio");
                                fileWrite.WriteLine(line.Substring(358, 15).PadRight(15) +"   " + line.Substring(358, 15).Length.ToString().PadRight(13) + "      Otras deduccionnes");
                                fileWrite.WriteLine(line.Substring(373, 17).PadRight(15) +"   " + line.Substring(373, 17).Length.ToString().PadRight(13) + "      Total remuneraciones Generales" + "\n");
                                fileWrite.WriteLine("");
                                break;
                            case "05":
                                fileWrite.WriteLine("Valor Campo:   Tamaño Campo:     Descripcion campo:");
                                fileWrite.WriteLine(line.Substring(2, 11).PadRight(15) + "CUIL LEGAJO       " + " Tamaño linea " + line.Length.ToString().PadRight(13) + "\n");
                                fileWrite.WriteLine(line.Substring(0, 2).PadRight(15) +"   " + line.Substring(0, 2).Length.ToString().PadRight(13) + "      Tipo Registro");
                                fileWrite.WriteLine(line.Substring(2, 11).PadRight(15) +"   " + line.Substring(2, 11).Length.ToString().PadRight(13) + "      CUIL");
                                fileWrite.WriteLine(line.Substring(13, 15).PadRight(15) +"   " + line.Substring(13, 15).Length.ToString().PadRight(13) + "      Alicuota art ");
                                fileWrite.WriteLine(line.Substring(28, 15).PadRight(15) +"   " + line.Substring(28, 15).Length.ToString().PadRight(13) + "      Deduccion especial");
                                fileWrite.WriteLine(line.Substring(43, 15).PadRight(15) +"   " + line.Substring(43, 15).Length.ToString().PadRight(13) + "        Deduccion epecifica");
                                fileWrite.WriteLine(line.Substring(58, 15).PadRight(15) +"   " + line.Substring(58, 15).Length.ToString().PadRight(13) + "      Conyugue");
                                fileWrite.WriteLine(line.Substring(73, 2).PadRight(15) +"   " + line.Substring(73, 2).Length.ToString().PadRight(13) + "      cant. hijos");
                                fileWrite.WriteLine(line.Substring(75, 15).PadRight(15) +"   " + line.Substring(75, 15).Length.ToString().PadRight(13) + "      Hijos/ hijastros");
                                fileWrite.WriteLine(line.Substring(90, 15).PadRight(15) +"   " + line.Substring(90, 15).Length.ToString().PadRight(13) + "      Total de cargas flia");
                                fileWrite.WriteLine(line.Substring(105, 15).PadRight(15) +"   " + line.Substring(105, 15).Length.ToString().PadRight(13) + "      Total deducciones art. 23");
                                fileWrite.WriteLine(line.Substring(120, 15).PadRight(15) +"   " + line.Substring(120, 15).Length.ToString().PadRight(13) + "      Rem suj a impuestos" + "\n");
                                fileWrite.WriteLine("");
                                break;
                            case "06":
                                fileWrite.WriteLine("Valor Campo:   Tamaño Campo:     Descripcion campo:");
                                fileWrite.WriteLine(line.Substring(0, 2).PadRight(15) +"   " + line.Substring(0, 2).Length.ToString().PadRight(13) + "      Tipo Registro");
                                fileWrite.WriteLine(line.Substring(2, 11).PadRight(15) +"   " + line.Substring(2, 11).Length.ToString().PadRight(13) + "      CUIL");
                                fileWrite.WriteLine(line.Substring(13, 1).PadRight(15) +"   " + line.Substring(13, 1).Length.ToString().PadRight(13) + "      Alicuota art 90 ley ganancia");
                                fileWrite.WriteLine(line.Substring(14, 1).PadRight(15) +"   " + line.Substring(14, 1).Length.ToString().PadRight(13) + "      Alicuota aplicable( sin inc hs extras)");
                                fileWrite.WriteLine(line.Substring(15, 15).PadRight(15) +"   " + line.Substring(15, 15).Length.ToString().PadRight(13) + "      Impuestos determinado");
                                fileWrite.WriteLine(line.Substring(30, 15).PadRight(15) +"   " + line.Substring(30, 15).Length.ToString().PadRight(13) + "      Impuesto retenido");
                                fileWrite.WriteLine(line.Substring(45, 15).PadRight(15) +"   " + line.Substring(45, 15).Length.ToString().PadRight(13) + "      Pagos a cuenta");
                                fileWrite.WriteLine(line.Substring(60, 15).PadRight(15) +"   " + line.Substring(60, 15).Length.ToString().PadRight(13) + "      Saldo" + "\n");
                                fileWrite.WriteLine("");
                                break;
                        }


                    }
                }




                ////aqui se renombrea el archivo temporal
                //File.Delete(@"C:\carpeta\F1357.11111111111.20180000.0001.txt");
                //File.Move(@"c:\carpeta\temp.txt", @"c:\carpeta\F1357.11111111111.20180000.0001.txt");
            }
        }
    }
}
