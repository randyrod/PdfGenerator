using System.IO;
using System.Text;

namespace PdfGeneratorApi.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var employees = DataStorage.GetAllEmployess();

            var text = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "HtmlFiles", "ContratoIndefinido.txt"));

            string html = @"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.01//EN"" ""http://www.w3.org/TR/html4/strict.dtd"">
<HTML>
<HEAD>
<META http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
<META http-equiv=""X-UA-Compatible"" content=""IE=8"">
<TITLE>bcl_1839708809.htm</TITLE>
<META name=""generator"" content=""BCL easyConverter SDK 5.0.140"">
<STYLE type=""text/css"">

body {margin-top: 0px;margin-left: 0px;}

#page_1 {position:relative; overflow: hidden;margin: 74px 0px 108px 67px;padding: 0px;border: none;width: 727px;}





#page_2 {position:relative; overflow: hidden;margin: 74px 0px 121px 67px;padding: 0px;border: none;width: 727px;}





#page_3 {position:relative; overflow: hidden;margin: 92px 0px 820px 76px;padding: 0px;border: none;width: 718px;}





.ft0{font: bold 16px 'Times New Roman';line-height: 19px;}
.ft1{font: bold 16px 'Bookman Old Style';line-height: 19px;}
.ft2{font: 16px 'Bookman Old Style';line-height: 19px;}
.ft3{font: 16px 'Bookman Old Style';line-height: 20px;}
.ft4{font: 16px 'Bookman Old Style';line-height: 21px;}
.ft5{font: bold 16px 'Bookman Old Style';line-height: 20px;}
.ft6{font: 16px 'Times New Roman';line-height: 19px;}
.ft7{font: 16px 'Times New Roman';margin-left: 6px;line-height: 19px;}
.ft8{font: bold 16px 'Times New Roman';line-height: 20px;}
.ft9{font: 16px 'Times New Roman';line-height: 20px;}
.ft10{font: 16px 'Bookman Old Style';line-height: 18px;}

.p0{text-align: left;padding-left: 77px;margin-top: 0px;margin-bottom: 0px;}
.p1{text-align: justify;padding-left: 9px;padding-right: 70px;margin-top: 11px;margin-bottom: 0px;}
.p2{text-align: left;padding-left: 9px;margin-top: 3px;margin-bottom: 0px;}
.p3{text-align: left;padding-left: 9px;margin-top: 0px;margin-bottom: 0px;}
.p4{text-align: left;padding-left: 9px;padding-right: 75px;margin-top: 0px;margin-bottom: 0px;}
.p5{text-align: left;padding-left: 156px;margin-top: 46px;margin-bottom: 0px;}
.p6{text-align: left;padding-right: 57px;margin-top: 35px;margin-bottom: 0px;}
.p7{text-align: justify;padding-left: 26px;padding-right: 75px;margin-top: 32px;margin-bottom: 0px;text-indent: -26px;}
.p8{text-align: justify;padding-left: 26px;padding-right: 57px;margin-top: 15px;margin-bottom: 0px;text-indent: -26px;}
.p9{text-align: justify;padding-left: 26px;padding-right: 57px;margin-top: 30px;margin-bottom: 0px;text-indent: -26px;}
.p10{text-align: left;padding-left: 26px;padding-right: 57px;margin-top: 11px;margin-bottom: 0px;}
.p11{text-align: justify;padding-right: 57px;margin-top: 15px;margin-bottom: 0px;}
.p12{text-align: justify;padding-right: 57px;margin-top: 0px;margin-bottom: 0px;}
.p13{text-align: left;margin-top: 12px;margin-bottom: 0px;}
.p14{text-align: justify;padding-right: 57px;margin-top: 25px;margin-bottom: 0px;}
.p15{text-align: justify;padding-right: 57px;margin-top: 13px;margin-bottom: 0px;}
.p16{text-align: justify;padding-right: 57px;margin-top: 22px;margin-bottom: 0px;}
.p17{text-align: left;padding-left: 3px;margin-top: 0px;margin-bottom: 0px;white-space: nowrap;}
.p18{text-align: left;padding-left: 2px;margin-top: 0px;margin-bottom: 0px;white-space: nowrap;}
.p19{text-align: left;margin-top: 0px;margin-bottom: 0px;white-space: nowrap;}
.p20{text-align: left;margin-top: 0px;margin-bottom: 0px;}
.p21{text-align: justify;padding-right: 75px;margin-top: 0px;margin-bottom: 0px;}
.p22{text-align: left;margin-top: 3px;margin-bottom: 0px;}

.td0{padding: 0px;margin: 0px;width: 443px;vertical-align: bottom;}
.td1{padding: 0px;margin: 0px;width: 136px;vertical-align: bottom;}

.tr0{height: 25px;}
.tr1{height: 22px;}

.t0{width: 579px;margin-left: 45px;margin-top: 44px;font: bold 16px 'Times New Roman';}

</STYLE>
</HEAD>

<BODY>
<DIV id=""page_1"">


<P class=""p0 ft0"">CONTRATO DE TRABAJO PARA OBRA O SERVICIO DETERMINADO</P>
<P class=""p1 ft2""><SPAN class=""ft1"">E N T R E, </SPAN>de una parte, <SPAN class=""ft1"">SR./SRA , </SPAN>dominicano/a, mayor de edad, previsto de la cédula de identidad No. <NOBR>001-1111111-1,</NOBR> domiciliado y residente en esta ciudad de Santo Domingo, Distrito Nacional, República Dominicana, actuando en calidad de presidente de la razón social <SPAN class=""ft1"">CONSORCIO AMIGOS, </SPAN>sociedad comercial constituida, organizada y existente de conformidad con las leyes de la República Dominicana, debidamente matriculada ante el Registro Nacional de Contribuyentes (RNC) bajo el número <NOBR><SPAN class=""ft1"">130-00000-0,</SPAN></NOBR><SPAN class=""ft1""> </SPAN>con domicilio y asiento social en la Ave. 40 de Junio número 45, sector Alegre, Santo Domingo, Distrito Nacional, República Dominicana, quien en lo adelante se denominara por su propio nombre o como <SPAN class=""ft1"">EL EMPLEADOR </SPAN>y, de la otra parte <SPAN class=""ft1"">Jesús Mercedes Viola, </SPAN>Dominicano/a, mayor de edad, portador de la cédula de identidad No.</P>
<P class=""p2 ft3"">___________________________________________, domiciliado y residente en la Calle</P>
<P class=""p3 ft3"">_______________________, de esta ciudad de Santo Domingo, Distrito Nacional,</P>
<P class=""p4 ft5""><SPAN class=""ft4"">República Dominicana, quien se denominara por su propio nombre o por el de </SPAN>EL TRABAJADOR<SPAN class=""ft4"">.-</SPAN></P>
<P class=""p5 ft0"">HAN CONVENIDO Y PACTADO LO SIGUIENTE</P>
<P class=""p6 ft6""><SPAN class=""ft0"">Primero: EL TRABAJADOR </SPAN>se compromete, mediante el presente contrato, a prestar servicios a <SPAN class=""ft0"">EL EMPLEADOR</SPAN>, en calidad de <SPAN class=""ft0"">Albañil de la construcción</SPAN>, bajo las siguientes condiciones:</P>
<P class=""p7 ft0""><SPAN class=""ft0"">1.1</SPAN><SPAN class=""ft7"">Reformar con materiales de obras el </SPAN>proyecto Alcantarillado La Julia, ubicada en el municipio Santo Domingo Este, provincia Santo Domingo, República Dominicana<SPAN class=""ft6"">, conforme a los términos establecidos en este contrato y a la dirección de la empresa;</SPAN></P>
<P class=""p8 ft6""><SPAN class=""ft0"">1.2</SPAN><SPAN class=""ft7"">Empañetar, colocar bloques, trabajos en mármol, alzados de muros, paredes y tapias, conforme a las especificaciones, planos o indicaciones suministradas por </SPAN><SPAN class=""ft0"">EL EMPLEADOR </SPAN>con diligencia, dedicación y esmero. Asimismo de una mano de obra en los trabajos de construcción e instalación en los términos, condiciones, valores y cantidades que se determinen en el presente contrato.</P>
<P class=""p9 ft6""><SPAN class=""ft0"">1.3</SPAN><SPAN class=""ft7"">Cumplir la jornada laboral diurna de ocho horas, iniciando a las 8 a.m., culminando ésta a las 5:00 p.m., los trabajos terminarán a las doce horas meridiano del día sábado. Teniendo como resultado un total de cuarenta y cuatro horas laborables, por semana, en virtud de lo que establece el Art. 147 del Código de Trabajo. También </SPAN><SPAN class=""ft0"">EL TRABAJADOR </SPAN>recibirá un descanso semanal ininterrumpido de treinta y seis horas, conforme al Art. 163 del Código de Trabajo.</P>
<P class=""p10 ft6"">Agregar, que <SPAN class=""ft0"">EL EMPLEADOR </SPAN>pude hacer ajustes o cambios de la horas cuando lo entienda conveniente siempre cumpliendo las reglas de los articulados mencionados.</P>
<P class=""p11 ft6""><SPAN class=""ft0"">Segundo: </SPAN>Las condiciones y obligaciones que se establecen en el apartado anterior tiene un carácter enunciativo no limitativo.</P>
<P class=""p11 ft6""><SPAN class=""ft0"">Tercero: EL TRABAJADOR</SPAN>, se compromete a cumplir con las órdenes e instrucciones que reciba de <SPAN class=""ft0"">EL EMPLEADOR </SPAN>o de sus representantes e interés de la disciplina dentro de la en construcción, y en beneficio de un mayor rendimiento de las labores que ejecuta.</P>
</DIV>
<DIV id=""page_2"">


<P class=""p12 ft6""><SPAN class=""ft0"">Cuarto: </SPAN>El trabajo tiene una remuneración diaria, por una suma de mil docientos pesos con 00/100 (RD$ 1,200.00), pagaderos quincenalmente.</P>
<P class=""p11 ft9""><SPAN class=""ft8"">Quinto: EL EMPLEADOR </SPAN>tendrá la prerrogativa de retener como garantía, la tercera parte del salario, en virtud de lo que establece el Art. 199 del Código de Trabajo.</P>
<P class=""p13 ft6""><SPAN class=""ft0"">Sexto: </SPAN>Queda entendido entre las partes contratantes, que a <SPAN class=""ft0"">EL TRABAJADOR</SPAN>, no le corresponden</P>
<P class=""p12 ft6"">ninguno de los siguientes conceptos, propios de un contrato de trabajo por tiempo indefinido: <SPAN class=""ft0"">(1) </SPAN>Participación en los beneficios de la empresa a que se refiere el Art. 223 del Código de trabajo; <SPAN class=""ft0"">(2) </SPAN>Escala proporcional de vacaciones a que se refiere el Art. 179, del Código de Trabajo; <SPAN class=""ft0"">(3) </SPAN>Indemnizaciones por Preaviso y auxilio de cesantía, que se refieren los Art. 76 y 80 del Código de Trabajo; y <SPAN class=""ft0"">(4) </SPAN>asistencia económica del Art. 82 del Código de Trabajo. Asimismo, queda entendido entre las partes contratantes, que a <SPAN class=""ft0"">EL TRABAJADOR</SPAN>, sólo le corresponden salario de Navidad en la forma indicada por las Leyes Laborales Vigentes y las vacaciones anuales sólo le corresponden a <SPAN class=""ft0"">EL TRABAJADOR</SPAN>, si el presente contrato se prolonga por un tiempo mayor de un año, por aplicación del Art. 178 del Código de Trabajo.</P>
<P class=""p14 ft6""><SPAN class=""ft0"">Séptimo: </SPAN>Si en el transcurso de la ejecución de los trabajos objeto del presente contrato, sobreviniere la necesidad de ajustar el monto de la remuneración convenida, según se detalla en la cuarta cláusula del presente contrato, dicho ajuste se plasmará por escrito y de mutuo acuerdo, según lo establece el Art. 20 del Código de Trabajo.</P>
<P class=""p15 ft6""><SPAN class=""ft0"">Octavo: </SPAN>Si durante el período de ejecución de los trabajos objeto del presente contrato, EL TRABAJADOR desea designar un sustituto o emplear uno o más auxiliares, estará en la obligación de comunicar por escrito al <SPAN class=""ft0"">EMPLEADOR</SPAN>, sobre dicho cambio, indicando a la vez, las condiciones en que se presentarán sus servicios el sustituto o los auxiliares contratados, a fin de que <SPAN class=""ft0"">EL EMPLEADOR </SPAN>pueda dar su aprobación; aprobación ésta que también se comunicará por escrito a <SPAN class=""ft0"">EL TRABAJADOR</SPAN>. Tanto la comunicación que haga <SPAN class=""ft0"">EL TRABAJADOR</SPAN>, como la que efectúe <SPAN class=""ft0"">EL EMPLEADOR</SPAN>, según indica en el párrafo precedente de esta misma cláusula, deberán estar firmadas, al pie de página, por la parte que la recibe, en señal de haberla recibido. Queda entendido entre las partes contratantes, que de no dársele cumplimiento a las formalidades indicadas en los párrafos precedente de esta misma cláusula, no se perfecciona la tácita aprobación a que se refiere el Art. 10 del Código de Trabajo.</P>
<P class=""p16 ft6""><SPAN class=""ft0"">Noveno: </SPAN>Queda entendido entre las partes contratantes, que la conversión del presente contrato a uno por tiempo indefinido, por aplicación del segundo párrafo del Art. 31 y del también segundo párrafo del Art. 73, ambos del Código de Trabajo, no se producirá al reanudarse los trabajos del presente contrato, que hayan estado suspendidos por una de las causas previstas en el Art. 51 del Código de Trabajo.</P>
<P class=""p15 ft6""><SPAN class=""ft0"">Décimo: </SPAN>El presente contrato terminará sin responsabilidad para las partes con la prestación del servicio o la conclusión de los trabajos efectuados por <SPAN class=""ft0"">EL TRABAJADOR</SPAN>, según se detalla en parte anterior del presente contrato, y de acuerdo a lo establecido en el Ord. 2do del Art.68 y en el Art. 72, ambos del Código de Trabajo.</P>
<P class=""p15 ft6"">Hecho en cuatro (4) originales, uno para cada parte y los otros dos para ser remitidos al Departamento de Trabajo, según lo dispuesto por el Art.22 del Código de Trabajo; a los dos (02) días del mes de marzo del año dos mil dieciocho (2018).</P>
<TABLE cellpadding=0 cellspacing=0 class=""t0"">
<TR>
	<TD class=""tr0 td0""><P class=""p17 ft0"">Pedro Juan C.</P></TD>
	<TD class=""tr0 td1""><P class=""p18 ft0"">José L. Almonte B.</P></TD>
</TR>
<TR>
	<TD class=""tr1 td0""><P class=""p19 ft0"">EL EMPLEADOR</P></TD>
	<TD class=""tr1 td1""><P class=""p19 ft0"">EL TRABAJADOR</P></TD>
</TR>
</TABLE>
</DIV>
<DIV id=""page_3"">


<P class=""p20 ft1""><SPAN class=""ft3"">Yo, </SPAN>________________________________________________, <SPAN class=""ft3"">Notario Público de los del</SPAN></P>
<P class=""p20 ft3"">Número del Distrito Nacional, Capital de la República Dominicana, Matricula No.</P>
<P class=""p20 ft3"">______________, <SPAN class=""ft1"">CERTIFICO Y DOY FE</SPAN>, que las firmas que anteceden fueron</P>
<P class=""p20 ft10"">puestas en mi presencia por los señores</P>
<P class=""p20 ft1"">____________________________________________________ (<SPAN class=""ft2"">Por sí y en representación</SPAN></P>
<P class=""p20 ft1""><SPAN class=""ft2"">de la empresa </SPAN>______________________________________________), <SPAN class=""ft2"">quienes me</SPAN></P>
<P class=""p21 ft10"">manifestaron bajo la fe del juramento ser esta la firma que acostumbran a usar en todos los actos de su vida pública y privada por lo que debe dársele a la misma entera fe y crédito. En la ciudad de Santo Domingo, Distrito Nacional, Capital de la República Dominicana, a los __________ (_______) días del mes de</P>
<P class=""p22 ft3"">____________________ del año Dos mil ___________________ (201___).</P>
</DIV>
</BODY>
</HTML>
";
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Name</th>
                                        <th>LastName</th>
                                        <th>Age</th>
                                        <th>Gender</th>
                                    </tr>");
 
            foreach (var emp in employees)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", emp.Name, emp.LastName, emp.Age, emp.Gender);
            }
 
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
 
            return html;
        }
    }
}