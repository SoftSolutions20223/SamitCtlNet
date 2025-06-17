Public Class ParametrosNomina
    Public sqlBancos As String = "INSERT INTO CAT_Bancos (Sec, Nombre, Vigente) VALUES " &
    "(1, 'Aportes en Línea', 1), " &
    "(2, 'Asopagos', 1), " &
    "(3, 'Banco Agrario de Colombia', 1), " &
    "(4, 'Banco AV Villas', 1), " &
    "(5, 'Banco BBVA', 1), " &
    "(6, 'Banco BCSC', 1), " &
    "(7, 'Banco Citibank', 1), " &
    "(8, 'Banco Coopcentral', 1), " &
    "(9, 'Banco Davivienda', 1), " &
    "(10, 'Banco de Bogotá', 1), " &
    "(11, 'Banco de la República', 1), " &
    "(12, 'Banco de Occidente', 1), " &
    "(13, 'Banco Falabella', 1), " &
    "(14, 'Banco Finandina', 1), " &
    "(15, 'Banco GNB Sudameris', 1), " &
    "(16, 'Banco Itaú Corpbanca Colombia S.A.', 1), " &
    "(17, 'Banco Mundo Mujer', 1), " &
    "(18, 'Banco Pichincha', 1), " &
    "(19, 'Banco Popular', 1), " &
    "(20, 'Banco Credifinanciera', 1), " &
    "(21, 'Banco Santander de Negocios Colombia S.A.', 1), " &
    "(22, 'Banco Serfinanza', 1), " &
    "(23, 'Bancoldex', 1), " &
    "(24, 'Bancolombia', 1), " &
    "(25, 'Bancoomeva', 1), " &
    "(26, 'BNP Paribas', 1), " &
    "(27, 'Coltefinanciera', 1), " &
    "(28, 'Compensar', 1), " &
    "(29, 'Confiar Cooperativa Financiera', 1), " &
    "(30, 'Coofinep Cooperativa Financiera', 1), " &
    "(31, 'Cooperativa Financiera Cotrafa', 1), " &
    "(32, 'Cooperativa Financiera de Antioquia', 1), " &
    "(33, 'Deceval', 1), " &
    "(34, 'Dirección del Tesoro Nacional - Regalías', 1), " &
    "(35, 'Dirección del Tesoro Nacional', 1), " &
    "(36, 'Enlace Operativo S.A.', 1), " &
    "(37, 'Financiera Juriscoop', 1), " &
    "(38, 'Banco JP Morgan Colombia', 1), " &
    "(39, 'Mibanco S.A', 1), " &
    "(40, 'Red Multibanca Colpatria', 1), " &
    "(41, 'Simple S.A', 1), " &
    "(42, 'FOGAFIN', 1)"


    Public sqlClaseLicencia As String = "INSERT INTO CAT_ClaseLicencia (Sec, idClase, NomClase, Vigente) VALUES " &
        "(1, '1', 'Licencia Clase A1', 1), " &
        "(2, '2', 'Licencia Clase A2', 1), " &
        "(3, '3', 'Licencia Clase B1', 1), " &
        "(4, '4', 'Licencia Clase B2', 1), " &
        "(5, '5', 'Licencia Clase B3', 1), " &
        "(6, '6', 'Licencia Clase C1', 1), " &
        "(7, '7', 'Licencia Clase C2', 1), " &
        "(8, '8', 'Licencia Clase C3', 1)"

    Public sqlTipoContratos As String = "INSERT INTO CAT_TipoContratos (Sec, NomTipo) VALUES " &
    "(1, 'Termino Fijo'), " &
    "(2, 'Término Indefinido'), " &
    "(3, 'Obra o Labor'), " &
    "(4, 'Aprendizaje'), " &
    "(5, 'Prácticas o Pasantías')"

    Public sqlTiposId As String = "INSERT INTO CAT_TiposId (Sec, TipoIdentificacion, NomTipo, UsaEmpleados, UsaParientes, Codigo) VALUES " &
    "(1, 'RC', 'Registro civil de nacimiento', 1, 1, '11'), " &
    "(2, 'TI', 'Tarjeta de identidad', 0, 1, '12'), " &
    "(3, 'CC', 'Cedula de ciudadanía', 1, 1, '13'), " &
    "(4, 'TE', 'Tarjeta de extranjería', 1, 1, '21'), " &
    "(5, 'CE', 'Cédula de extranjeria', 1, 1, '22'), " &
    "(6, 'NIT', 'NIT', 1, 1, '31'), " &
    "(7, 'PA', 'Pasaporte', 1, 1, '41'), " &
    "(8, 'TDE', 'Tipo de documento extranjero', 1, 1, '42'), " &
    "(9, 'PEP', 'PEP', 1, 1, '47'), " &
    "(10, 'NUIP', 'NUIP', 1, 1, '91'), " &
    "(11, 'NITE', 'NIT de otro país', 1, 1, '50')"

    Public sqlClasConceptosNomina As String = "INSERT INTO ClasConceptosNomina (Sec, Nom, Vigente) VALUES " &
    "(1, 'SEGURIDAD SOCIAL', '1'), " &
    "(2, 'PRESTACIONES SOCIALES', '1'), " &
    "(3, 'APORTES PARA FISCALES', '1'), " &
    "(4, 'NOMINA', '1')"

    Public sqlConceptosNomina As String = "INSERT INTO ConceptosNomina " &
    "(Sec, NomConcepto, Vigente, Formula, Tipo, PeriodosLiquida, Base, Redondea, Fondo, Clasificacion, EsRetencion, EsPredeterminado, CodDian, Orden) VALUES " &
    "(1, 'SUELDO', '1', NULL, 1, NULL, NULL, 1, 0, 4, 0, 1, NULL, NULL), " &
    "(2, 'AUXILIO DE TRANSPORTE', '1', NULL, 1, NULL, NULL, 1, 0, 4, 0, 1, NULL, NULL), " &
    "(3, 'SALUD EMPLEADO', '1', NULL, 2, NULL, NULL, 1, 2, 1, 0, 1, NULL, NULL), " &
    "(4, 'PENSION EMPLEADO', '1', NULL, 2, NULL, NULL, 1, 1, 1, 0, 1, NULL, NULL), " &
    "(5, 'SALUD EMPLEADOR', '1', NULL, 3, NULL, NULL, 1, 2, 1, 0, 1, NULL, NULL), " &
    "(6, 'PENSION EMPLEADOR', '1', NULL, 3, NULL, NULL, 1, 2, 2, 0, 1, NULL, NULL), " &
    "(7, 'SENA', '1', NULL, 3, NULL, NULL, 1, 4, 3, 0, 1, NULL, NULL), " &
    "(8, 'ICBF', '1', NULL, 3, NULL, NULL, 1, 4, 3, 0, 1, NULL, NULL), " &
    "(9, 'CAJA DE COMPENSACION FAMILIAR', '1', NULL, 3, NULL, NULL, 1, 4, 3, 0, 1, NULL, NULL), " &
    "(10, 'CESANTIAS', '1', NULL, 3, NULL, NULL, 1, 5, 2, 0, 1, NULL, NULL), " &
    "(11, 'INTERES DE CESANTIAS', '1', NULL, 3, NULL, NULL, 1, 5, 2, 0, 1, NULL, NULL), " &
    "(12, 'PRIMA DE SERVICIOS', '1', NULL, 3, NULL, NULL, 1, 0, 2, 0, 1, NULL, NULL), " &
    "(13, 'VACACIONES', '1', NULL, 3, NULL, NULL, 1, 0, 2, 0, 1, NULL, NULL), " &
    "(14, 'ARL', '1', NULL, 3, NULL, NULL, 1, 3, 3, 0, 1, NULL, NULL), " &
    "(15, 'DOTACION', '1', NULL, 2, NULL, NULL, 1, 0, 2, 0, 1, NULL, NULL), " &
    "(16, 'HORAS EXTRAS DIURNAS', '1', NULL, 1, NULL, NULL, 1, 0, 4, 0, 1, NULL, NULL), " &
    "(17, 'HORAS EXTRAS NOCTURNAS', '1', NULL, 1, NULL, NULL, 1, 0, 4, 0, 1, NULL, NULL), " &
    "(18, 'HORAS EXTRAS DIURNAS DOMINICAL/FESTIVO', '1', NULL, 1, NULL, NULL, 1, 0, 4, 0, 1, NULL, NULL), " &
    "(19, 'HORAS EXTRAS NOCTURNAS DOMINICAL/FESTIVO', '1', NULL, 1, NULL, NULL, 1, 0, 4, 0, 1, NULL, NULL), " &
    "(20, 'DOMINICALES Y FESTIVOS', '1', NULL, 1, NULL, NULL, 1, 0, 4, 0, 1, NULL, NULL)"

    Public sqlVariablesGenerales As String = "SET DATEFORMAT DMY; " &
    "INSERT INTO VariablesGenerales (Sec, NomVariable, Vigente, Descripcion, EsPredeterminado, CodDian) VALUES " &
    "(1, 'VALOR DE AUXILIO DE TRANSPORTE', '1', NULL, 1, NULL), " &
    "(2, 'PORCENTAJE HORAS EXTRAS DIURNAS', '1', NULL, 1, NULL), " &
    "(3, 'PORCENTAJE HORAS EXTRAS NOCTURNAS', '1', NULL, 1, NULL), " &
    "(4, 'PORCENTAJE HORAS EXTRAS DOMINICAL/FESTIVO', '1', NULL, 1, NULL), " &
    "(5, 'PORCENTAJE HORAS EXTRAS NOCTURNAS DOMINICAL/FESTIVO', '1', NULL, 1, NULL), " &
    "(6, 'VALOR SALARIO MINIMO', '1', NULL, 1, NULL), " &
    "(7, 'VALOR UVT', '1', NULL, 1, NULL), " &
    "(8, 'PORCENTAJE POR INCAPACIDAD < 91 Dias', '1', NULL, 1, NULL), " &
    "(9, 'PORCENTAJE POR INCAPACIDAD > 91 Dias', '1', NULL, 1, NULL), " &
    "(10, 'PORCENTAJE RIESGO I', '1', NULL, 1, NULL), " &
    "(11, 'PORCENTAJE RIESGO II', '1', NULL, 1, NULL), " &
    "(12, 'PORCENTAJE RIESGO III', '1', NULL, 1, NULL), " &
    "(13, 'PORCENTAJE RIESGO IV', '1', NULL, 1, NULL), " &
    "(14, 'PORCENTAJE RIESGO V', '1', NULL, 1, NULL), " &
    "(15, 'PORCENTAJE SALUD EMPLEADO', '1', NULL, 1, NULL), " &
    "(16, 'PORCENTAJE SALUD EMPLEADOR', '1', NULL, 1, NULL), " &
    "(17, 'PORCENTAJE PENSION EMPLEADO', '1', NULL, 1, NULL), " &
    "(18, 'PORCENTAJE PENSION EMPLEADOR', '1', NULL, 1, NULL), " &
    "(19, 'SALARIO INTEGRAL', '1', NULL, 1, NULL); " &
    "INSERT INTO DetallesVariablesGenerales (Sec, Variable, Valor, Fecha) VALUES " &
    "(1, 1, 106454, '01/01/2021'), " &
    "(2, 2, 25, '01/01/2021'), " &
    "(3, 3, 75, '01/01/2021'), " &
    "(4, 4, 100, '01/01/2021'), " &
    "(5, 5, 150, '01/01/2021'), " &
    "(6, 6, 908526, '01/01/2021'), " &
    "(7, 7, 36308, '01/01/2021'), " &
    "(8, 8, 66.67, '01/01/2021'), " &
    "(9, 9, 50, '01/01/2021'), " &
    "(10, 10, 0.522, '01/01/2021'), " &
    "(11, 11, 1.044, '01/01/2021'), " &
    "(12, 12, 2.436, '01/01/2021'), " &
    "(13, 13, 4.350, '01/01/2021'), " &
    "(14, 14, 6.960, '01/01/2021'), " &
    "(15, 15, 4, '01/01/2021'), " &
    "(16, 16, 8.5, '01/01/2021'), " &
    "(17, 17, 4, '01/01/2021'), " &
    "(18, 18, 12, '01/01/2021'), " &
    "(19, 19, 11810838, '01/01/2021')"

    Public sqlVariablesPersonales As String = "INSERT INTO VariablesPersonales (Sec, NomVariable, Vigente, ValorMaximo, ValorDefecto, EsPredeterminado, CodDian) VALUES " &
    "(1, 'CANTIDAD DE DIAS TRABAJADOS', '1', 30, 30, 1, NULL), " &
    "(2, 'CANTIDAD DE HORAS EXTRAS DIURNAS', '1', 48, 0, 1, 'NIE076'), " &
    "(3, 'CANTIDAD DE HORAS EXTRAS NOCTURNAS', '1', 48, 0, 1, 'NIE081'), " &
    "(4, 'CANTIDAD DE HORAS EXTRAS DIURNAS DOMINICAL/FESTIVO', '1', 48, 0, 1, 'NIE091'), " &
    "(5, 'CANTIDAD DE HORAS EXTRAS NOCTURNA DOMINICAL/FESTIVO', '1', 48, 0, 1, 'NIE101'), " &
    "(6, 'CANTIDAD DE HORAS RECARGO NOCTURNO', '1', 48, 0, 1, 'NIE086'), " &
    "(7, 'CANTIDAD DE HORAS RECARGO DIURNO DOMINICAL/FESTIVO', '1', 48, 0, 1, 'NIE096'), " &
    "(8, 'CANTIDAD DE HORAS RECARGO NOCTURNO DOMINICAL/FESTIVO', '1', 48, 0, 1, 'NIE106'), " &
    "(9, 'CANTIDAD DE DIAS DE INCAPACIDAD', '1', 30, 0, 1, NULL), " &
    "(10, 'CANTIDAD DE DOMINICALES/FESTIVOS', '1', 30, 0, 1, NULL), " &
    "(11, 'CANTIDAD DE DIAS DE VACACIONES', '1', 30, 0, 1, NULL)"

    Public sqlZenumTipoEntes As String = "INSERT INTO ZenumTipoEntes (Sec, CodTipoEnte, NomTipoEnte) VALUES " &
    "(1, 1, 'Administradoras de Fondos de Pensiones'), " &
    "(2, 2, 'Empresas Promotoras de Salud'), " &
    "(3, 3, 'Administradoras de Riesgos Profesionales'), " &
    "(4, 4, 'Cajas de Compensacion Familiar'), " &
    "(5, 5, 'Fondo de Cesantias')"

    Public sqlTiposConceptosNomina As String = "INSERT INTO TiposConceptosNomina (Sec, NomTipo, Vigente) VALUES " &
    "(1, 'Ingresos', '1'), " &
    "(2, 'Deducciones', '1'), " &
    "(3, 'Provisiones', '1')"

    Public sqlCatParentesco As String = "INSERT INTO CAT_Parentesco (Sec, NomParentesco, Estado) VALUES " &
    "(1, 'Conyuge', 1), " &
    "(2, 'Hijos', 1), " &
    "(3, 'Padres', 1)"

    Public sqlCatNivelEducativo As String = "INSERT INTO CAT_NivelEducativo (Sec, NomNivel, Vigente, EsFormal) VALUES " &
    "(1, 'Sin Estudio', 1, 0), " &
    "(2, 'Primaria', 1, 1), " &
    "(3, 'Básica Secundaria', 1, 1), " &
    "(4, 'Bachiller', 1, 1), " &
    "(5, 'Tecnico', 1, 1), " &
    "(6, 'Tecnología', 1, 1), " &
    "(7, 'Profesional', 1, 1), " &
    "(8, 'Especialización', 0, 1), " &
    "(9, 'Maestría', 0, 1), " &
    "(10, 'Doctorado', 1, 1), " &
    "(11, 'PHD', 1, 1), " &
    "(12, 'Diplomado', 1, 0), " &
    "(13, 'Foro', 1, 0), " &
    "(14, 'Auxiliar', 1, 1), " &
    "(15, 'Curso Virtual', 1, 0), " &
    "(16, 'Otro', 1, 1)"

    Public sqlCatGenero As String = "INSERT INTO CAT_Genero (idgenero, nomgenero, vigente) VALUES " &
    "('F', 'Femenino', 1), " &
    "('M', 'Masculino', 1)"

    Public sqlProfesiones As String = "INSERT INTO CAT_Profesiones (Sec, NomProfesion, Vigente, IdNivelEducativo) VALUES " &
    "(1, 'Ingeniero de Sistemas', 1, 3), " &
    "(2, 'Contador Público', 1, 3), " &
    "(3, 'Médico General', 1, 4), " &
    "(4, 'Abogado', 1, 3), " &
    "(5, 'Psicólogo', 1, 3), " &
    "(6, 'Administrador de Empresas', 1, 3), " &
    "(7, 'Arquitecto', 1, 3), " &
    "(8, 'Enfermero', 1, 3), " &
    "(9, 'Diseñador Gráfico', 1, 2), " &
    "(10, 'Profesor', 1, 3)"

    Public sqlCatEstadoCivil As String = "INSERT INTO CAT_EstadoCivil (Sec, NomEstado, Vigente) VALUES " &
    "(1, 'Casado (a)', 1), " &
    "(2, 'Union libre', 1), " &
    "(3, 'Separado (a)', 1), " &
    "(4, 'Viudo (a)', 1), " &
    "(5, 'Soltero (a)', 1)"

    Public sqlCatClaseLibreta As String = "INSERT INTO CAT_ClaseLibreta (Sec, NomClaseLib, Vigente) VALUES " &
    "(1, 'Primera Clase', 1), " &
    "(2, 'Segunda Clase', 1)"

    Public sqlGPais As String = "INSERT INTO G_Pais (Sec, NomPais, CodIso) VALUES " &
"(1, 'Nive Isla', 'NU'), " &
"(13, 'Afganistan', 'AF'), " &
"(17, 'Albania', 'AL'), " &
"(23, 'Alemania', 'DE'), " &
"(26, 'Armenia', 'AM'), " &
"(27, 'Aruba', 'AW'), " &
"(29, 'Bosnia-Herzegovina', 'BA'), " &
"(31, 'Burkina Fasso', 'BF'), " &
"(37, 'Andorra', 'AD'), " &
"(40, 'Angola', 'AO'), " &
"(41, 'Anguilla', 'AI'), " &
"(43, 'Antigua Y Barbuda', 'AG'), " &
"(47, 'Antillas Holandesas', 'AN'), " &
"(53, 'Arabia Saudita', 'SA'), " &
"(59, 'Argelia', 'DZ'), " &
"(63, 'Argentina', 'AR'), " &
"(69, 'Australia', 'AU'), " &
"(72, 'Austria', 'AT'), " &
"(74, 'Azerbaijan', 'AZ'), " &
"(77, 'Bahamas', 'BS'), " &
"(80, 'Bahrein', 'BH'), " &
"(81, 'Bangladesh', 'BD'), " &
"(83, 'Barbados', 'BB'), " &
"(87, 'Belgica', 'BE'), " &
"(88, 'Belice', 'BZ'), " &
"(90, 'Bermudas', 'BM'), " &
"(91, 'Belorus', 'BY'), " &
"(93, 'Birmania (Myanmar)', 'MM'), " &
"(97, 'Bolivia', 'BO'), " &
"(101, 'Botswana', 'BW'), " &
"(105, 'Brasil', 'BR'), " &
"(108, 'Brunei Darussalam', 'BN'), " &
"(111, 'Bulgaria', 'BG'), " &
"(115, 'Burundi', 'BI'), " &
"(119, 'Butan', 'BT'), " &
"(127, 'Cabo Verde', 'CV'), " &
"(141, 'Kampuchea (Camboya)', 'KH'), " &
"(145, 'Camerun, Republica U', 'CM'), " &
"(149, 'Canada', 'CA'), " &
"(159, 'Ciudad Del Vaticano', 'VA'), " &
"(165, 'Cocos (Keeling), Isl', 'CC'), " &
"(169, 'Colombia', 'CO'), " &
"(173, 'Comoras', 'KM'), " &
"(177, 'Congo', 'CG'), " &
"(183, 'Cook, Islas', 'CK'), " &
"(187, 'Corea Del Norte,Repu', 'KP'), " &
"(190, 'Corea Del Sur, Repub', 'KR'), " &
"(193, 'Costa De Marfil', 'CI'), " &
"(196, 'Costa Rica', 'CR'), " &
"(198, 'Croacia', 'HR'), " &
"(199, 'Cuba', 'CU'), " &
"(203, 'Chad', 'TD'), " &
"(211, 'Chile', 'CL'), " &
"(215, 'China', 'CN'), " &
"(218, 'Taiwan (Formosa)', 'TW'), " &
"(221, 'Chipre', 'CY'), " &
"(229, 'Benin', 'BJ'), " &
"(232, 'Dinamarca', 'DK'), " &
"(235, 'Dominica', 'DM'), " &
"(239, 'Ecuador', 'EC'), " &
"(240, 'Egipto', 'EG'), " &
"(242, 'El Salvador', 'SV'), " &
"(243, 'Eritrea', 'ER'), " &
"(244, 'Emiratos Arabes Unid', 'AE'), " &
"(245, 'España', 'ES'), " &
"(246, 'Eslovaquia', 'SK'), " &
"(247, 'Eslovenia', 'SI'), " &
"(249, 'Estados Unidos', 'US'), " &
"(251, 'Estonia', 'EE'), " &
"(253, 'Etiopia', 'ET'), " &
"(259, 'Feroe, Islas', 'FO'), " &
"(267, 'Filipinas', 'PH'), " &
"(271, 'Finlandia', 'FI'), " &
"(275, 'Francia', 'FR'), " &
"(281, 'Gabon', 'GA'), " &
"(285, 'Gambia', 'GM'), " &
"(287, 'Georgia', 'GE'), " &
"(289, 'Ghana', 'GH'), " &
"(293, 'Gibraltar', 'GI'), " &
"(297, 'Granada', 'GD'), " &
"(301, 'Grecia', 'GR'), " &
"(305, 'Groenlandia', 'GL'), " &
"(309, 'Guadalupe', 'GP'), " &
"(313, 'Guam', 'GU'), " &
"(317, 'Guatemala', 'GT'), " &
"(325, 'Guayana Francesa', 'GF'), " &
"(329, 'Guinea', 'GN'), " &
"(331, 'Guinea Ecuatorial', 'GQ'), " &
"(334, 'Guinea - Bissau', 'GW'), " &
"(337, 'Guyana', 'GY'), " &
"(341, 'Haiti', 'HT'), " &
"(345, 'Honduras', 'HN'), " &
"(351, 'Hong Kong', 'HK'), " &
"(355, 'Hungria', 'HU'), " &
"(361, 'India', 'IN'), " &
"(365, 'Indonesia', 'ID'), " &
"(369, 'Irak', 'IQ'), " &
"(372, 'Iran, Republica Isla', 'IR'), " &
"(375, 'Irlanda (Eire)', 'IE'), " &
"(379, 'Islandia', 'IS'), " &
"(383, 'Israel', 'IL'), " &
"(386, 'Italia', 'IT'), " &
"(391, 'Jamaica', 'JM'), " &
"(399, 'Japon', 'JP'), " &
"(403, 'Jordania', 'JO'), " &
"(406, 'Kazajstan', 'KZ'), " &
"(410, 'Kenya', 'KE'), " &
"(411, 'Kiribati', 'KI'), " &
"(412, 'Kirguizistan', 'KG'), " &
"(413, 'Kuwait', 'KW'), " &
"(420, 'Laos,Republica Popul', 'LA'), " &
"(426, 'Lesotho', 'LS'), " &
"(429, 'Letonia', 'LV'), " &
"(431, 'Libano', 'LB'), " &
"(434, 'Liberia', 'LR'), " &
"(438, 'Libia(Incluye Fezzan', 'LY'), " &
"(440, 'Liechtenstein', 'LI'), " &
"(443, 'Lituania', 'LT'), " &
"(445, 'Luxemburgo', 'LU'), " &
"(447, 'Macao', 'MO'), " &
"(448, 'Macedonia', 'MK'), " &
"(450, 'Madagascar', 'MG'), " &
"(455, 'Malasia', 'MY'), " &
"(458, 'Malawi', 'MW'), " &
"(461, 'Maldivas', 'MV'), " &
"(464, 'Mali', 'ML'), " &
"(467, 'Malta', 'MT'), " &
"(469, 'Marianas Del Norte,I', 'MP'), " &
"(472, 'Marshall, Islas', 'MH'), " &
"(474, 'Marruecos', 'MA'), " &
"(477, 'Martinica', 'MQ'), " &
"(485, 'Mauricio', 'MU'), " &
"(488, 'Mauritania', 'MR'), " &
"(493, 'Mexico', 'MX'), " &
"(494, 'Micronesia,Estados F', 'FM'), " &
"(496, 'Moldavia', 'MD'), " &
"(497, 'Mongolia', 'MN'), " &
"(498, 'Monaco', 'MC'), " &
"(501, 'Monserrat, Isla', 'MS'), " &
"(505, 'Mozambique', 'MZ'), " &
"(507, 'Namibia', 'NA'), " &
"(508, 'Nauru', 'NR'), " &
"(511, 'Navidad (Christmas)', 'CX'), " &
"(517, 'Nepal', 'NP'), " &
"(521, 'Nicaragua', 'NI'), " &
"(525, 'Niger', 'NE'), " &
"(528, 'Nigeria', 'NG'), " &
"(531, 'Niue, Isla', 'UN'), " &
"(535, 'Norfolk, Isla', 'NF'), " &
"(538, 'Noruega', 'NO'), " &
"(542, 'Nueva Caledonia', 'NC'), " &
"(545, 'Papuasia Nuev Guinea', 'PG'), " &
"(548, 'Nueva Zelandia', 'NZ'), " &
"(551, 'Vanuatu', 'VU'), " &
"(556, 'Oman', 'OM'), " &
"(573, 'Paises Bajos(Holanda', 'NL'), " &
"(576, 'Pakistan', 'PK'), " &
"(578, 'Palau, Islas', 'PW'), " &
"(580, 'Panama', 'PA'), " &
"(586, 'Paraguay', 'PY'), " &
"(589, 'Peru', 'PE'), " &
"(593, 'Pitcairn, Isla', 'PN'), " &
"(599, 'Polinesia Francesa', 'PF'), " &
"(603, 'Polonia', 'PL'), " &
"(607, 'Portugal', 'PT'), " &
"(611, 'Puerto Rico', 'PR'), " &
"(618, 'Qatar', 'QA'), " &
"(628, 'Reino Unido', 'GB'), " &
"(640, 'Republica Centroafri', 'CF'), " &
"(644, 'Republica Checa', 'CZ'), " &
"(647, 'Republica Dominicana', 'DO'), " &
"(660, 'Reunion', 'RE'), " &
"(665, 'Zimbabwe', 'ZW'), " &
"(670, 'Rumania', 'RO'), " &
"(675, 'Rwanda', 'RW'), " &
"(676, 'Rusia', 'RU'), " &
"(677, 'Salomsn, Islas', 'SB'), " &
"(685, 'Sahara Occidental', 'EH'), " &
"(687, 'Samoa', 'WS'), " &
"(690, 'Samoa Norteamericana', 'AS'), " &
"(697, 'San Marino', 'SM'), " &
"(700, 'San Pedro Y Miguelon', 'PM'), " &
"(705, 'San Vicente Y Las Gr', 'VC'), " &
"(710, 'Santa Elena', 'SH'), " &
"(715, 'Santa Lucia', 'LC'), " &
"(720, 'Santo Tome Y Princip', 'ST'), " &
"(728, 'Senegal', 'SN'), " &
"(731, 'Seychelles', 'SC'), " &
"(735, 'Sierra Leona', 'SL'), " &
"(741, 'Singapur', 'SG'), " &
"(744, 'Siria,Republica Arab', 'SY'), " &
"(748, 'Somalia', 'SO'), " &
"(750, 'Sri Lanka', 'LK'), " &
"(756, 'Sudafrica,Republica', 'ZA'), " &
"(759, 'Sudan', 'SD'), " &
"(764, 'Suecia', 'SE'), " &
"(767, 'Suiza', 'CH'), " &
"(770, 'Surinam', 'SR'), " &
"(773, 'Swazilandia', 'SZ'), " &
"(774, 'Tadjikistan', 'TJ'), " &
"(776, 'Tailandia', 'TH'), " &
"(780, 'Tanzania,Republica U', 'TZ'), " &
"(783, 'Djibouti', 'DJ'), " &
"(788, 'Timor Del Este', 'TP'), " &
"(800, 'Togo', 'TG'), " &
"(805, 'Tokelau', 'TK'), " &
"(810, 'Tonga', 'TO'), " &
"(815, 'Trinidad Y Tobago', 'TT'), " &
"(820, 'Tunicia', 'TN'), " &
"(823, 'Turcas Y Caicos,Isla', 'TC'), " &
"(825, 'Turkmenistan', 'TM'), " &
"(827, 'Turquia', 'TR'), " &
"(828, 'Tuvalu', 'TV'), " &
"(830, 'Ucrania', 'UA'), " &
"(833, 'Uganda', 'UG'), " &
"(845, 'Uruguay', 'UY'), " &
"(847, 'Uzbekistan', 'UZ'), " &
"(850, 'Venezuela', 'VE'), " &
"(855, 'Vietnam', 'VN'), " &
"(863, 'Virgenes,Islas(Brita', 'VG'), " &
"(866, 'Virgenes,Islas(Norte', 'VI'), " &
"(870, 'Fiji', 'FJ'), " &
"(875, 'Wallis Y Fortuna,Isl', 'WF'), " &
"(880, 'Yemen', 'YE'), " &
"(885, 'Yugoslavia', 'YU'), " &
"(888, 'Zaire', 'ZR'), " &
"(890, 'Zambia', 'ZM'), " &
"(998, 'Comunidad Europea', 'EU'), " &
"(999, 'No Declarados', '99')"

    Public sqlGMunicipio As String = "INSERT INTO G_Municipio (Sec, Departamento, IdMunicipio, NombreMunicipio)
SELECT 1 AS Sec, '05' AS Departamento, '05001' AS IdMunicipio, 'Medellín' AS NombreMunicipio
UNION SELECT 2, '05', '05002', 'Abejorral'
UNION SELECT 3, '05', '05004', 'Abriaquí'
UNION SELECT 4, '05', '05021', 'Alejandría'
UNION SELECT 5, '05', '05030', 'Amagá'
UNION SELECT 6, '05', '05031', 'Amalfi'
UNION SELECT 7, '05', '05034', 'Andes'
UNION SELECT 8, '05', '05036', 'Angelópolis'
UNION SELECT 9, '05', '05038', 'Angostura'
UNION SELECT 10, '05', '05040', 'Anorí'
UNION SELECT 11, '05', '05042', 'Antioquia'
UNION SELECT 12, '05', '05044', 'Anza'
UNION SELECT 13, '05', '05045', 'Apartadó'
UNION SELECT 14, '05', '05051', 'Arboletes'
UNION SELECT 15, '05', '05055', 'Argelia'
UNION SELECT 16, '05', '05059', 'Armenia'
UNION SELECT 17, '05', '05079', 'Barbosa'
UNION SELECT 18, '05', '05086', 'Belmira'
UNION SELECT 19, '05', '05088', 'Bello'
UNION SELECT 20, '05', '05091', 'Betania'
UNION SELECT 21, '05', '05093', 'Betulia'
UNION SELECT 22, '05', '05101', 'Bolívar'
UNION SELECT 23, '05', '05107', 'Briceño'
UNION SELECT 24, '05', '05113', 'Buriticá'
UNION SELECT 25, '05', '05120', 'Cáceres'
UNION SELECT 26, '05', '05125', 'Caicedo'
UNION SELECT 27, '05', '05129', 'Caldas'
UNION SELECT 28, '05', '05134', 'Campamento'
UNION SELECT 29, '05', '05138', 'Cañasgordas'
UNION SELECT 30, '05', '05142', 'Caracolí'
UNION SELECT 31, '05', '05145', 'Caramanta'
UNION SELECT 32, '05', '05147', 'Carepa'
UNION SELECT 33, '05', '05148', 'Carmen de Viboral'
UNION SELECT 34, '05', '05150', 'Carolina'
UNION SELECT 35, '05', '05154', 'Caucasia'
UNION SELECT 36, '05', '05172', 'Chigorodó'
UNION SELECT 37, '05', '05190', 'Cisneros'
UNION SELECT 38, '05', '05197', 'Cocorná'
UNION SELECT 39, '05', '05206', 'Concepción'
UNION SELECT 40, '05', '05209', 'Concordia'
UNION SELECT 41, '05', '05212', 'Copacabana'
UNION SELECT 42, '05', '05234', 'Dabeiba'
UNION SELECT 43, '05', '05237', 'Don Matías'
UNION SELECT 44, '05', '05240', 'Ebéjico'
UNION SELECT 45, '05', '05250', 'El Bagre'
UNION SELECT 46, '05', '05264', 'Entrerrios'
UNION SELECT 47, '05', '05266', 'Envigado'
UNION SELECT 48, '05', '05282', 'Fredonia'
UNION SELECT 49, '05', '05284', 'Frontino'
UNION SELECT 50, '05', '05306', 'Giraldo'
UNION SELECT 51, '05', '05308', 'Girardota'
UNION SELECT 52, '05', '05310', 'Gómez Plata'
UNION SELECT 53, '05', '05313', 'Granada'
UNION SELECT 54, '05', '05315', 'Guadalupe'
UNION SELECT 55, '05', '05318', 'Guarne'
UNION SELECT 56, '05', '05321', 'Guatape'
UNION SELECT 57, '05', '05347', 'Heliconia'
UNION SELECT 58, '05', '05353', 'Hispania'
UNION SELECT 59, '05', '05360', 'Itagui'
UNION SELECT 60, '05', '05361', 'Ituango'
UNION SELECT 61, '05', '05364', 'Jardín'
UNION SELECT 62, '05', '05368', 'Jericó'
UNION SELECT 63, '05', '05376', 'La Ceja'
UNION SELECT 64, '05', '05380', 'La Estrella'
UNION SELECT 65, '05', '05390', 'La Pintada'
UNION SELECT 66, '05', '05400', 'La Unión'
UNION SELECT 67, '05', '05411', 'Liborina'
UNION SELECT 68, '05', '05425', 'Maceo'
UNION SELECT 69, '05', '05440', 'Marinilla'
UNION SELECT 70, '05', '05467', 'Montebello'
UNION SELECT 71, '05', '05475', 'Murindó'
UNION SELECT 72, '05', '05480', 'Mutatá'
UNION SELECT 73, '05', '05483', 'Nariño'
UNION SELECT 74, '05', '05490', 'Necoclí'
UNION SELECT 75, '05', '05495', 'Nechí'
UNION SELECT 76, '05', '05501', 'Olaya'
UNION SELECT 77, '05', '05541', 'Peñol'
UNION SELECT 78, '05', '05543', 'Peque'
UNION SELECT 79, '05', '05576', 'Pueblorrico'
UNION SELECT 80, '05', '05579', 'Puerto Berrio'
UNION SELECT 81, '05', '05585', 'Puerto Nare'
UNION SELECT 82, '05', '05591', 'Puerto Triunfo'
UNION SELECT 83, '05', '05604', 'Remedios'
UNION SELECT 84, '05', '05607', 'Retiro'
UNION SELECT 85, '05', '05615', 'Rionegro'
UNION SELECT 86, '05', '05628', 'Sabanalarga'
UNION SELECT 87, '05', '05631', 'Sabaneta'
UNION SELECT 88, '05', '05642', 'Salgar'
UNION SELECT 89, '05', '05647', 'San Andrés'
UNION SELECT 90, '05', '05649', 'San Carlos'
UNION SELECT 91, '05', '05652', 'San Francisco'
UNION SELECT 92, '05', '05656', 'San Jerónimo'
UNION SELECT 93, '05', '05658', 'San José de la Montaña'
UNION SELECT 94, '05', '05659', 'San Juan de Uraba'
UNION SELECT 95, '05', '05660', 'San Luis'
UNION SELECT 96, '05', '05664', 'San Pedro'
UNION SELECT 97, '05', '05665', 'San Pedro de Uraba'
UNION SELECT 98, '05', '05667', 'San Rafael'
UNION SELECT 99, '05', '05670', 'San Roque'
UNION SELECT 100, '05', '05674', 'San Vicente'
UNION SELECT 101, '05', '05679', 'Santa Bárbara'
UNION SELECT 102, '05', '05686', 'Santa Rosa de Osos'
UNION SELECT 103, '05', '05690', 'Santo Domingo'
UNION SELECT 104, '05', '05697', 'El Santuario'
UNION SELECT 105, '05', '05736', 'Segovia'
UNION SELECT 106, '05', '05756', 'Sonsón'
UNION SELECT 107, '05', '05761', 'Sopetrán'
UNION SELECT 108, '05', '05789', 'Támesis'
UNION SELECT 109, '05', '05790', 'Tarazá'
UNION SELECT 110, '05', '05792', 'Tarso'
UNION SELECT 111, '05', '05809', 'Titiribí'
UNION SELECT 112, '05', '05819', 'Toledo'
UNION SELECT 113, '05', '05837', 'Turbo'
UNION SELECT 114, '05', '05842', 'Uramita'
UNION SELECT 115, '05', '05847', 'Urrao'
UNION SELECT 116, '05', '05854', 'Valdivia'
UNION SELECT 117, '05', '05856', 'Valparaíso'
UNION SELECT 118, '05', '05858', 'Vegachí'
UNION SELECT 119, '05', '05861', 'Venecia'
UNION SELECT 120, '05', '05873', 'Vigía del Fuerte'
UNION SELECT 121, '05', '05885', 'Yalí'
UNION SELECT 122, '05', '05887', 'Yarumal'
UNION SELECT 123, '05', '05890', 'Yolombó'
UNION SELECT 124, '05', '05893', 'Yondó'
UNION SELECT 125, '05', '05895', 'Zaragoza'
UNION SELECT 126, '08', '08001', 'Barranquilla'
UNION SELECT 127, '08', '08078', 'Baranoa'
UNION SELECT 128, '08', '08137', 'Campo de la Cruz'
UNION SELECT 129, '08', '08141', 'Candelaria'
UNION SELECT 130, '08', '08296', 'Galapa'
UNION SELECT 131, '08', '08372', 'Juan de  Acosta'
UNION SELECT 132, '08', '08421', 'Luruaco'
UNION SELECT 133, '08', '08433', 'Malambo'
UNION SELECT 134, '08', '08436', 'Manatí'
UNION SELECT 135, '08', '08520', 'Palmar de Varela'
UNION SELECT 136, '08', '08549', 'Piojó'
UNION SELECT 137, '08', '08558', 'Polo Nuevo'
UNION SELECT 138, '08', '08560', 'Ponedera'
UNION SELECT 139, '08', '08573', 'Puerto Colombia'
UNION SELECT 140, '08', '08606', 'Repelón'
UNION SELECT 141, '08', '08634', 'Sabanagrande'
UNION SELECT 142, '08', '08638', 'Sabanalarga'
UNION SELECT 143, '08', '08675', 'Santa Lucía'
UNION SELECT 144, '08', '08685', 'Santo Tomás'
UNION SELECT 145, '08', '08758', 'Soledad'
UNION SELECT 146, '08', '08770', 'Suan'
UNION SELECT 147, '08', '08832', 'Tubará'
UNION SELECT 148, '08', '08849', 'Usiacurí'
UNION SELECT 149, '11', '11001', 'Bogotá'
UNION SELECT 150, '13', '13001', 'Cartagena'
UNION SELECT 151, '13', '13006', 'Achí'
UNION SELECT 152, '13', '13030', 'Altos del Rosario'
UNION SELECT 153, '13', '13042', 'Arenal'
UNION SELECT 154, '13', '13052', 'Arjona'
UNION SELECT 155, '13', '13062', 'Arroyohondo'
UNION SELECT 156, '13', '13074', 'Barranco de Loba'
UNION SELECT 157, '13', '13140', 'Calamar'
UNION SELECT 158, '13', '13160', 'Cantagallo'
UNION SELECT 159, '13', '13188', 'Cicuco'
UNION SELECT 160, '13', '13212', 'Córdoba'
UNION SELECT 161, '13', '13222', 'Clemencia'
UNION SELECT 162, '13', '13244', 'Carmen de Bolívar'
UNION SELECT 163, '13', '13248', 'El Guamo'
UNION SELECT 164, '13', '13268', 'El Peñon'
UNION SELECT 165, '13', '13300', 'Hatillo de Loba'
UNION SELECT 166, '13', '13430', 'Magangue'
UNION SELECT 167, '13', '13433', 'Mahates'
UNION SELECT 168, '13', '13440', 'Margarita'
UNION SELECT 169, '13', '13442', 'María la Baja'
UNION SELECT 170, '13', '13458', 'Montecristo'
UNION SELECT 171, '13', '13468', 'Mompos'
UNION SELECT 172, '13', '13473', 'Morales'
UNION SELECT 173, '13', '13549', 'Pinillos'
UNION SELECT 174, '13', '13580', 'Regidor'
UNION SELECT 175, '13', '13600', 'Río Viejo'
UNION SELECT 176, '13', '13620', 'San Cristóbal'
UNION SELECT 177, '13', '13647', 'San Estanislao'
UNION SELECT 178, '13', '13650', 'San Fernando'
UNION SELECT 179, '13', '13654', 'San Jacinto'
UNION SELECT 180, '13', '13655', 'San Jacinto del Cauca'
UNION SELECT 181, '13', '13657', 'San Juan Nepomuceno'
UNION SELECT 182, '13', '13667', 'San Martín Loba'
UNION SELECT 183, '13', '13670', 'San Pablo'
UNION SELECT 184, '13', '13673', 'Sta Catalina'
UNION SELECT 185, '13', '13683', 'Santa Rosa'
UNION SELECT 186, '13', '13688', 'Sta Rosa Sur'
UNION SELECT 187, '13', '13744', 'Simiti'
UNION SELECT 188, '13', '13760', 'Soplaviento'
UNION SELECT 189, '13', '13780', 'Talaigua Nuevo'
UNION SELECT 190, '13', '13810', 'Tiquisio (Puerto Rico)'
UNION SELECT 191, '13', '13836', 'Turbaco'
UNION SELECT 192, '13', '13838', 'Turbaná'
UNION SELECT 193, '13', '13873', 'Villanueva'
UNION SELECT 194, '13', '13894', 'Zambrano'
UNION SELECT 195, '15', '15001', 'Tunja'
UNION SELECT 196, '15', '15022', 'Almeida'
UNION SELECT 197, '15', '15047', 'Aquitania'
UNION SELECT 198, '15', '15051', 'Arcabuco'
UNION SELECT 199, '15', '15087', 'Belén'
UNION SELECT 200, '15', '15090', 'Berbeo'
UNION SELECT 201, '15', '15092', 'Betéitiva'
UNION SELECT 202, '15', '15097', 'Boavita'
UNION SELECT 203, '15', '15104', 'Boyacá'
UNION SELECT 204, '15', '15106', 'Briceño'
UNION SELECT 205, '15', '15109', 'Buenavista'
UNION SELECT 206, '15', '15114', 'Busbanza'
UNION SELECT 207, '15', '15131', 'Caldas'
UNION SELECT 208, '15', '15135', 'Campohermoso'
UNION SELECT 209, '15', '15162', 'Cerinza'
UNION SELECT 210, '15', '15172', 'Chinavita'
UNION SELECT 211, '15', '15176', 'Chiquinquirá'
UNION SELECT 212, '15', '15180', 'Chiscas'
UNION SELECT 213, '15', '15183', 'Chita'
UNION SELECT 214, '15', '15185', 'Chitaraque'
UNION SELECT 215, '15', '15187', 'Chivatá'
UNION SELECT 216, '15', '15189', 'Ciénega'
UNION SELECT 217, '15', '15204', 'Cómbita'
UNION SELECT 218, '15', '15212', 'Coper'
UNION SELECT 219, '15', '15215', 'Corrales'
UNION SELECT 220, '15', '15218', 'Covarachía'
UNION SELECT 221, '15', '15223', 'Cubará'
UNION SELECT 222, '15', '15224', 'Cucaita'
UNION SELECT 223, '15', '15226', 'Cuítiva'
UNION SELECT 224, '15', '15232', 'Chíquiza'
UNION SELECT 225, '15', '15236', 'Chivor'
UNION SELECT 226, '15', '15238', 'Duitama'
UNION SELECT 227, '15', '15244', 'El Cocuy'
UNION SELECT 228, '15', '15248', 'El Espino'
UNION SELECT 229, '15', '15272', 'Firavitoba'
UNION SELECT 230, '15', '15276', 'Floresta'
UNION SELECT 231, '15', '15293', 'Gachantivá'
UNION SELECT 232, '15', '15296', 'Gameza'
UNION SELECT 233, '15', '15299', 'Garagoa'
UNION SELECT 234, '15', '15317', 'Guacamayas'
UNION SELECT 235, '15', '15322', 'Guateque'
UNION SELECT 236, '15', '15325', 'Guayatá'
UNION SELECT 237, '15', '15332', 'Guican'
UNION SELECT 238, '15', '15362', 'Iza'
UNION SELECT 239, '15', '15367', 'Jenesano'
UNION SELECT 240, '15', '15368', 'Jericó'
UNION SELECT 241, '15', '15377', 'Labranzagrande'
UNION SELECT 242, '15', '15380', 'La Capilla'
UNION SELECT 243, '15', '15401', 'La Victoria'
UNION SELECT 244, '15', '15403', 'La Uvita'
UNION SELECT 245, '15', '15407', 'Villa de Leyva'
UNION SELECT 246, '15', '15425', 'Macanal'
UNION SELECT 247, '15', '15442', 'Maripí'
UNION SELECT 248, '15', '15455', 'Miraflores'
UNION SELECT 249, '15', '15464', 'Mongua'
UNION SELECT 250, '15', '15466', 'Monguí'
UNION SELECT 251, '15', '15469', 'Moniquirá'
UNION SELECT 252, '15', '15476', 'Motavita'
UNION SELECT 253, '15', '15480', 'Muzo'
UNION SELECT 254, '15', '15491', 'Nobsa'
UNION SELECT 255, '15', '15494', 'Nuevo Colón'
UNION SELECT 256, '15', '15500', 'Oicatá'
UNION SELECT 257, '15', '15507', 'Otanche'
UNION SELECT 258, '15', '15511', 'Pachavita'
UNION SELECT 259, '15', '15514', 'Páez'
UNION SELECT 260, '15', '15516', 'Paipa'
UNION SELECT 261, '15', '15518', 'Pajarito'
UNION SELECT 262, '15', '15522', 'Panqueba'
UNION SELECT 263, '15', '15531', 'Pauna'
UNION SELECT 264, '15', '15533', 'Paya'
UNION SELECT 265, '15', '15537', 'Paz de Río'
UNION SELECT 266, '15', '15542', 'Pesca'
UNION SELECT 267, '15', '15550', 'Pisba'
UNION SELECT 268, '15', '15572', 'Puerto Boyacá'
UNION SELECT 269, '15', '15580', 'Quípama'
UNION SELECT 270, '15', '15599', 'Ramiriquí'
UNION SELECT 271, '15', '15600', 'Ráquira'
UNION SELECT 272, '15', '15621', 'Rondón'
UNION SELECT 273, '15', '15632', 'Saboyá'
UNION SELECT 274, '15', '15638', 'Sáchica'
UNION SELECT 275, '15', '15646', 'Samacá'
UNION SELECT 276, '15', '15660', 'San Eduardo'
UNION SELECT 277, '15', '15664', 'San  José de Pare'
UNION SELECT 278, '15', '15667', 'San Luis de Gaceno'
UNION SELECT 279, '15', '15673', 'San Mateo'
UNION SELECT 280, '15', '15676', 'San Miguel de Sema'
UNION SELECT 281, '15', '15681', 'San Pablo de Borbur'
UNION SELECT 282, '15', '15686', 'Santana'
UNION SELECT 283, '15', '15690', 'Santa María'
UNION SELECT 284, '15', '15693', 'Santa Rosa de  Viterbo'
UNION SELECT 285, '15', '15696', 'Santa Sofía'
UNION SELECT 286, '15', '15720', 'Sativanorte'
UNION SELECT 287, '15', '15723', 'Sativasur'
UNION SELECT 288, '15', '15740', 'Siachoque'
UNION SELECT 289, '15', '15753', 'Soata'
UNION SELECT 290, '15', '15755', 'Socota'
UNION SELECT 291, '15', '15757', 'Socha'
UNION SELECT 292, '15', '15759', 'Sogamoso'
UNION SELECT 293, '15', '15761', 'Somondoco'
UNION SELECT 294, '15', '15762', 'Sora'
UNION SELECT 295, '15', '15763', 'Sotaquirá'
UNION SELECT 296, '15', '15764', 'Soracá'
UNION SELECT 297, '15', '15774', 'Susacón'
UNION SELECT 298, '15', '15776', 'Sutamarchán'
UNION SELECT 299, '15', '15778', 'Sutatenza'
UNION SELECT 300, '15', '15790', 'Tasco'
UNION SELECT 301, '15', '15798', 'Tenza'
UNION SELECT 302, '15', '15804', 'Tibaná'
UNION SELECT 303, '15', '15806', 'Tibasosa'
UNION SELECT 304, '15', '15808', 'Tinjacá'
UNION SELECT 305, '15', '15810', 'Tipacoque'
UNION SELECT 306, '15', '15814', 'Toca'
UNION SELECT 307, '15', '15816', 'Togui'
UNION SELECT 308, '15', '15820', 'Tópaga'
UNION SELECT 309, '15', '15822', 'Tota'
UNION SELECT 310, '15', '15832', 'Tununguá'
UNION SELECT 311, '15', '15835', 'Turmequé'
UNION SELECT 312, '15', '15837', 'Tuta'
UNION SELECT 313, '15', '15839', 'Tutazá'
UNION SELECT 314, '15', '15842', 'Umbita'
UNION SELECT 315, '15', '15861', 'Ventaquemada'
UNION SELECT 316, '15', '15879', 'Viracachá'
UNION SELECT 317, '15', '15897', 'Zetaquira'
UNION SELECT 318, '17', '17001', 'Manizales'
UNION SELECT 319, '17', '17013', 'Aguadas'
UNION SELECT 320, '17', '17042', 'Anserma'
UNION SELECT 321, '17', '17050', 'Aranzazu'
UNION SELECT 322, '17', '17088', 'Belalcázar'
UNION SELECT 323, '17', '17174', 'Chinchiná'
UNION SELECT 324, '17', '17272', 'Filadelfia'
UNION SELECT 325, '17', '17380', 'La Dorada'
UNION SELECT 326, '17', '17388', 'La Merced'
UNION SELECT 327, '17', '17433', 'Manzanares'
UNION SELECT 328, '17', '17442', 'Marmato'
UNION SELECT 329, '17', '17444', 'Marquetalia'
UNION SELECT 330, '17', '17446', 'Marulanda'
UNION SELECT 331, '17', '17486', 'Neira'
UNION SELECT 332, '17', '17495', 'Norcasia'
UNION SELECT 333, '17', '17513', 'Pácora'
UNION SELECT 334, '17', '17524', 'Palestina'
UNION SELECT 335, '17', '17541', 'Pensilvania'
UNION SELECT 336, '17', '17614', 'Riosucio'
UNION SELECT 337, '17', '17616', 'Risaralda'
UNION SELECT 338, '17', '17653', 'Salamina'
UNION SELECT 339, '17', '17662', 'Samaná'
UNION SELECT 340, '17', '17665', 'San José'
UNION SELECT 341, '17', '17777', 'Supía'
UNION SELECT 342, '17', '17867', 'Victoria'
UNION SELECT 343, '17', '17873', 'Villamaría'
UNION SELECT 344, '17', '17877', 'Viterbo'
UNION SELECT 345, '18', '18001', 'Florencia'
UNION SELECT 346, '18', '18029', 'Albania'
UNION SELECT 347, '18', '18094', 'Belén de los Andaquies'
UNION SELECT 348, '18', '18150', 'Cartagena del Chairá'
UNION SELECT 349, '18', '18205', 'Curillo'
UNION SELECT 350, '18', '18247', 'El Doncello'
UNION SELECT 351, '18', '18256', 'El Paujil'
UNION SELECT 352, '18', '18410', 'La Montañita'
UNION SELECT 353, '18', '18460', 'Milán'
UNION SELECT 354, '18', '18479', 'Morelia'
UNION SELECT 355, '18', '18592', 'Puerto Rico'
UNION SELECT 356, '18', '18610', 'San José del Fragua'
UNION SELECT 357, '18', '18753', 'San Vicente del Caguán'
UNION SELECT 358, '18', '18756', 'Solano'
UNION SELECT 359, '18', '18785', 'Solita'
UNION SELECT 360, '18', '18860', 'Valparaíso'
UNION SELECT 361, '19', '19001', 'Popayán'
UNION SELECT 362, '19', '19022', 'Almaguer'
UNION SELECT 363, '19', '19050', 'Argelia'
UNION SELECT 364, '19', '19075', 'Balboa'
UNION SELECT 365, '19', '19100', 'Bolívar'
UNION SELECT 366, '19', '19110', 'Buenos Aires'
UNION SELECT 367, '19', '19130', 'Cajibío'
UNION SELECT 368, '19', '19137', 'Caldono'
UNION SELECT 369, '19', '19142', 'Caloto'
UNION SELECT 370, '19', '19212', 'Corinto'
UNION SELECT 371, '19', '19256', 'El Tambo'
UNION SELECT 372, '19', '19290', 'Florencia'
UNION SELECT 373, '19', '19318', 'Guapi'
UNION SELECT 374, '19', '19355', 'Inzá'
UNION SELECT 375, '19', '19364', 'Jambaló'
UNION SELECT 376, '19', '19392', 'La Sierra'
UNION SELECT 377, '19', '19397', 'La Vega'
UNION SELECT 378, '19', '19418', 'López de Micay'
UNION SELECT 379, '19', '19450', 'Mercaderes'
UNION SELECT 380, '19', '19455', 'Miranda'
UNION SELECT 381, '19', '19473', 'Morales'
UNION SELECT 382, '19', '19513', 'Padilla'
UNION SELECT 383, '19', '19517', 'Páez'
UNION SELECT 384, '19', '19532', 'Patía'
UNION SELECT 385, '19', '19533', 'Piamonte'
UNION SELECT 386, '19', '19548', 'Piéndamo'
UNION SELECT 387, '19', '19573', 'Puerto Tejada'
UNION SELECT 388, '19', '19585', 'Puracé'
UNION SELECT 389, '19', '19622', 'Rosas'
UNION SELECT 390, '19', '19693', 'San Sebastián'
UNION SELECT 391, '19', '19698', 'Santander de Quilichao'
UNION SELECT 392, '19', '19701', 'Santa Rosa'
UNION SELECT 393, '19', '19743', 'Silvia'
UNION SELECT 394, '19', '19760', 'Sotara'
UNION SELECT 395, '19', '19780', 'Suárez'
UNION SELECT 396, '19', '19785', 'Sucre'
UNION SELECT 397, '19', '19807', 'Timbío'
UNION SELECT 398, '19', '19809', 'Timbiquí'
UNION SELECT 399, '19', '19821', 'Toribio'
UNION SELECT 400, '19', '19824', 'Totoró'
UNION SELECT 401, '19', '19845', 'Villa Rica'
UNION SELECT 402, '20', '20001', 'Valledupar'
UNION SELECT 403, '20', '20011', 'Aguachica'
UNION SELECT 404, '20', '20013', 'Agustín Codazzi'
UNION SELECT 405, '20', '20032', 'Astrea'
UNION SELECT 406, '20', '20045', 'Becerril'
UNION SELECT 407, '20', '20060', 'Bosconia'
UNION SELECT 408, '20', '20175', 'Chimichagua'
UNION SELECT 409, '20', '20178', 'Chiriguaná'
UNION SELECT 410, '20', '20228', 'Curumaní'
UNION SELECT 411, '20', '20238', 'El Copey'
UNION SELECT 412, '20', '20250', 'El Paso'
UNION SELECT 413, '20', '20295', 'Gamarra'
UNION SELECT 414, '20', '20310', 'González'
UNION SELECT 415, '20', '20383', 'La Gloria'
UNION SELECT 416, '20', '20400', 'La Jagua de Ibirico'
UNION SELECT 417, '20', '20443', 'Manaure Balcón Cesar'
UNION SELECT 418, '20', '20517', 'Pailitas'
UNION SELECT 419, '20', '20550', 'Pelaya'
UNION SELECT 420, '20', '20570', 'Pueblo Bello'
UNION SELECT 421, '20', '20614', 'Río de Oro'
UNION SELECT 422, '20', '20621', 'La Paz'
UNION SELECT 423, '20', '20710', 'San Alberto'
UNION SELECT 424, '20', '20750', 'San Diego'
UNION SELECT 425, '20', '20770', 'San Martín'
UNION SELECT 426, '20', '20787', 'Tamalameque'
UNION SELECT 427, '23', '23001', 'Montería'
UNION SELECT 428, '23', '23068', 'Ayapel'
UNION SELECT 429, '23', '23079', 'Buenavista'
UNION SELECT 430, '23', '23090', 'Canalete'
UNION SELECT 431, '23', '23162', 'Cereté'
UNION SELECT 432, '23', '23168', 'Chimá'
UNION SELECT 433, '23', '23182', 'Chinú'
UNION SELECT 434, '23', '23189', 'Ciénaga de Oro'
UNION SELECT 435, '23', '23300', 'Cotorra'
UNION SELECT 436, '23', '23350', 'La Apartada'
UNION SELECT 437, '23', '23417', 'Lorica'
UNION SELECT 438, '23', '23419', 'Los Córdobas'
UNION SELECT 439, '23', '23464', 'Momil'
UNION SELECT 440, '23', '23466', 'Montelíbano'
UNION SELECT 441, '23', '23500', 'Moñitos'
UNION SELECT 442, '23', '23555', 'Planeta Rica'
UNION SELECT 443, '23', '23570', 'Pueblo Nuevo'
UNION SELECT 444, '23', '23574', 'Puerto Escondido'
UNION SELECT 445, '23', '23580', 'Puerto Libertador'
UNION SELECT 446, '23', '23586', 'Purísima'
UNION SELECT 447, '23', '23660', 'Sahagún'
UNION SELECT 448, '23', '23670', 'San Andrés Sotavento'
UNION SELECT 449, '23', '23672', 'San Antero'
UNION SELECT 450, '23', '23675', 'San  Bernardo del Viento'
UNION SELECT 451, '23', '23678', 'San Carlos'
UNION SELECT 452, '23', '23686', 'San Pelayo'
UNION SELECT 453, '23', '23807', 'Tierralta'
UNION SELECT 454, '23', '23855', 'Valencia'
UNION SELECT 455, '25', '25001', 'Agua de Dios'
UNION SELECT 456, '25', '25019', 'Albán'
UNION SELECT 457, '25', '25035', 'Anapoima'
UNION SELECT 458, '25', '25040', 'Anolaima'
UNION SELECT 459, '25', '25053', 'Arbeláez'
UNION SELECT 460, '25', '25086', 'Beltrán'
UNION SELECT 461, '25', '25095', 'Bituima'
UNION SELECT 462, '25', '25099', 'Bojacá'
UNION SELECT 463, '25', '25120', 'Cabrera'
UNION SELECT 464, '25', '25123', 'Cachipay'
UNION SELECT 465, '25', '25126', 'Cajicá'
UNION SELECT 466, '25', '25148', 'Caparrapí'
UNION SELECT 467, '25', '25151', 'Caqueza'
UNION SELECT 468, '25', '25154', 'Carmen de Carupa'
UNION SELECT 469, '25', '25168', 'Chaguaní'
UNION SELECT 470, '25', '25175', 'Chía'
UNION SELECT 471, '25', '25178', 'Chipaque'
UNION SELECT 472, '25', '25181', 'Choachí'
UNION SELECT 473, '25', '25183', 'Chocontá'
UNION SELECT 474, '25', '25200', 'Cogua'
UNION SELECT 475, '25', '25214', 'Cota'
UNION SELECT 476, '25', '25224', 'Cucunubá'
UNION SELECT 477, '25', '25245', 'El Colegio'
UNION SELECT 478, '25', '25258', 'El Peñon'
UNION SELECT 479, '25', '25260', 'El Rosal'
UNION SELECT 480, '25', '25269', 'Facatativá'
UNION SELECT 481, '25', '25279', 'Fomeque'
UNION SELECT 482, '25', '25281', 'Fosca'
UNION SELECT 483, '25', '25286', 'Funza'
UNION SELECT 484, '25', '25288', 'Fúquene'
UNION SELECT 485, '25', '25290', 'Fusagasugá'
UNION SELECT 486, '25', '25293', 'Gachala'
UNION SELECT 487, '25', '25295', 'Gachancipá'
UNION SELECT 488, '25', '25297', 'Gachetá'
UNION SELECT 489, '25', '25299', 'Gama'
UNION SELECT 490, '25', '25307', 'Girardot'
UNION SELECT 491, '25', '25312', 'Granada'
UNION SELECT 492, '25', '25317', 'Guachetá'
UNION SELECT 493, '25', '25320', 'Guaduas'
UNION SELECT 494, '25', '25322', 'Guasca'
UNION SELECT 495, '25', '25324', 'Guataquí'
UNION SELECT 496, '25', '25326', 'Guatavita'
UNION SELECT 497, '25', '25328', 'Guayabal de Siquima'
UNION SELECT 498, '25', '25335', 'Guayabetal'
UNION SELECT 499, '25', '25339', 'Gutiérreza'
UNION SELECT 500, '25', '25368', 'Jerusalén'
UNION SELECT 501, '25', '25372', 'Junín'
UNION SELECT 502, '25', '25377', 'La Calera'
UNION SELECT 503, '25', '25386', 'La Mesa'
UNION SELECT 504, '25', '25394', 'La Palma'
UNION SELECT 505, '25', '25398', 'La Peña'
UNION SELECT 506, '25', '25402', 'La Vega'
UNION SELECT 507, '25', '25407', 'Lenguazaque'
UNION SELECT 508, '25', '25426', 'Macheta'
UNION SELECT 509, '25', '25430', 'Madrid'
UNION SELECT 510, '25', '25436', 'Manta'
UNION SELECT 511, '25', '25438', 'Medina'
UNION SELECT 512, '25', '25473', 'Mosquera'
UNION SELECT 513, '25', '25483', 'Nariño'
UNION SELECT 514, '25', '25486', 'Nemocón'
UNION SELECT 515, '25', '25488', 'Nilo'
UNION SELECT 516, '25', '25489', 'Nimaima'
UNION SELECT 517, '25', '25491', 'Nocaima'
UNION SELECT 518, '25', '25506', 'Venecia Ospina Pérez'
UNION SELECT 519, '25', '25513', 'Pacho'
UNION SELECT 520, '25', '25518', 'Paime'
UNION SELECT 521, '25', '25524', 'Pandi'
UNION SELECT 522, '25', '25530', 'Paratebueno'
UNION SELECT 523, '25', '25535', 'Pasca'
UNION SELECT 524, '25', '25572', 'Puerto Salgar'
UNION SELECT 525, '25', '25580', 'Pulí'
UNION SELECT 526, '25', '25592', 'Quebradanegra'
UNION SELECT 527, '25', '25594', 'Quetame'
UNION SELECT 528, '25', '25596', 'Quipile'
UNION SELECT 529, '25', '25599', 'Apulo'
UNION SELECT 530, '25', '25612', 'Ricaurte'
UNION SELECT 531, '25', '25645', 'San Antonio de Tequendama'
UNION SELECT 532, '25', '25649', 'San Bernardo'
UNION SELECT 533, '25', '25653', 'San Cayetano'
UNION SELECT 534, '25', '25658', 'San Francisco'
UNION SELECT 535, '25', '25662', 'San Juan de Rioseco'
UNION SELECT 536, '25', '25718', 'Sasaima'
UNION SELECT 537, '25', '25736', 'Sesquilé'
UNION SELECT 538, '25', '25740', 'Sibaté'
UNION SELECT 539, '25', '25743', 'Silvania'
UNION SELECT 540, '25', '25745', 'Simijaca'
UNION SELECT 541, '25', '25754', 'Soacha'
UNION SELECT 542, '25', '25758', 'Sopó'
UNION SELECT 543, '25', '25769', 'Subachoque'
UNION SELECT 544, '25', '25772', 'Suesca'
UNION SELECT 545, '25', '25777', 'Supatá'
UNION SELECT 546, '25', '25779', 'Susa'
UNION SELECT 547, '25', '25781', 'Sutatausa'
UNION SELECT 548, '25', '25785', 'Tabio'
UNION SELECT 549, '25', '25793', 'Tausa'
UNION SELECT 550, '25', '25797', 'Tena'
UNION SELECT 551, '25', '25799', 'Tenjo'
UNION SELECT 552, '25', '25805', 'Tibacuy'
UNION SELECT 553, '25', '25807', 'Tibiritá'
UNION SELECT 554, '25', '25815', 'Tocaima'
UNION SELECT 555, '25', '25817', 'Tocancipá'
UNION SELECT 556, '25', '25823', 'Topaipi'
UNION SELECT 557, '25', '25839', 'Ubalá'
UNION SELECT 558, '25', '25841', 'Ubaque'
UNION SELECT 559, '25', '25843', 'Villa de San Diego de Ubate'
UNION SELECT 560, '25', '25845', 'Une'
UNION SELECT 561, '25', '25851', 'Útica'
UNION SELECT 562, '25', '25862', 'Vergara'
UNION SELECT 563, '25', '25867', 'Vianí'
UNION SELECT 564, '25', '25871', 'Villagómez'
UNION SELECT 565, '25', '25873', 'Villa Pinzón'
UNION SELECT 566, '25', '25875', 'Villeta'
UNION SELECT 567, '25', '25878', 'Viotá'
UNION SELECT 568, '25', '25885', 'Yacopí'
UNION SELECT 569, '25', '25898', 'Zipacón'
UNION SELECT 570, '25', '25899', 'Zipaquirá'
UNION SELECT 571, '27', '27001', 'Quibdó'
UNION SELECT 572, '27', '27006', 'Acandí'
UNION SELECT 573, '27', '27025', 'Alto Baudó'
UNION SELECT 574, '27', '27050', 'Atrato Yuto'
UNION SELECT 575, '27', '27073', 'Bagadó'
UNION SELECT 576, '27', '27075', 'Bahía Solano'
UNION SELECT 577, '27', '27077', 'Bajo Baudó Pizarro'
UNION SELECT 578, '27', '27086', 'Belén de Bajirá'
UNION SELECT 579, '27', '27099', 'Bellavista'
UNION SELECT 580, '27', '27135', 'Cantón del San Pablo'
UNION SELECT 581, '27', '27150', 'Carmen del Darién'
UNION SELECT 582, '27', '27160', 'Cértegui'
UNION SELECT 583, '27', '27205', 'Condoto'
UNION SELECT 584, '27', '27245', 'El Carmen de Atrato'
UNION SELECT 585, '27', '27250', 'El Litoral del San Juan'
UNION SELECT 586, '27', '27361', 'Istmina'
UNION SELECT 587, '27', '27372', 'Juradó'
UNION SELECT 588, '27', '27413', 'Lloró'
UNION SELECT 589, '27', '27425', 'El Carmen de Atrato'
UNION SELECT 590, '27', '27430', 'Medio Baudó'
UNION SELECT 591, '27', '27450', 'Medio San Juan'
UNION SELECT 592, '27', '27491', 'Novita'
UNION SELECT 593, '27', '27495', 'Nuquí'
UNION SELECT 594, '27', '27580', 'Río Iro'
UNION SELECT 595, '27', '27600', 'Río Quito'
UNION SELECT 596, '27', '27615', 'Riosucio'
UNION SELECT 597, '27', '27660', 'San José del Palmar'
UNION SELECT 598, '27', '27745', 'Sipí'
UNION SELECT 599, '27', '27787', 'Tadó'
UNION SELECT 600, '27', '27800', 'Unguía'
UNION SELECT 601, '27', '27810', 'Unión Panamericana'
UNION SELECT 602, '41', '41001', 'Neiva'
UNION SELECT 603, '41', '41006', 'Acevedo'
UNION SELECT 604, '41', '41013', 'Agrado'
UNION SELECT 605, '41', '41016', 'Aipe'
UNION SELECT 606, '41', '41020', 'Algeciras'
UNION SELECT 607, '41', '41026', 'Altamira'
UNION SELECT 608, '41', '41078', 'Baraya'
UNION SELECT 609, '41', '41132', 'Campoalegre'
UNION SELECT 610, '41', '41206', 'Colombia'
UNION SELECT 611, '41', '41244', 'Elías'
UNION SELECT 612, '41', '41298', 'Garzón'
UNION SELECT 613, '41', '41306', 'Gigante'
UNION SELECT 614, '41', '41319', 'Guadalupe'
UNION SELECT 615, '41', '41349', 'Hobo'
UNION SELECT 616, '41', '41357', 'Íquira'
UNION SELECT 617, '41', '41359', 'Isnos'
UNION SELECT 618, '41', '41378', 'La Argentina'
UNION SELECT 619, '41', '41396', 'La Plata'
UNION SELECT 620, '41', '41483', 'Nátaga'
UNION SELECT 621, '41', '41503', 'Oporapa'
UNION SELECT 622, '41', '41518', 'Paicol'
UNION SELECT 623, '41', '41524', 'Palermo'
UNION SELECT 624, '41', '41530', 'Palestina'
UNION SELECT 625, '41', '41548', 'Pital'
UNION SELECT 626, '41', '41551', 'Pitalito'
UNION SELECT 627, '41', '41615', 'Rivera'
UNION SELECT 628, '41', '41660', 'Saladoblanco'
UNION SELECT 629, '41', '41668', 'San Agustín'
UNION SELECT 630, '41', '41676', 'Santa María'
UNION SELECT 631, '41', '41770', 'Suaza'
UNION SELECT 632, '41', '41791', 'Tarqui'
UNION SELECT 633, '41', '41797', 'Tesalia'
UNION SELECT 634, '41', '41799', 'Tello'
UNION SELECT 635, '41', '41801', 'Teruel'
UNION SELECT 636, '41', '41807', 'Timaná'
UNION SELECT 637, '41', '41872', 'Villavieja'
UNION SELECT 638, '41', '41885', 'Yaguará'
UNION SELECT 639, '44', '44001', 'Riohacha'
UNION SELECT 640, '44', '44035', 'Albania'
UNION SELECT 641, '44', '44078', 'Barrancas'
UNION SELECT 642, '44', '44090', 'Dibulla'
UNION SELECT 643, '44', '44098', 'Distracción'
UNION SELECT 644, '44', '44110', 'El Molino'
UNION SELECT 645, '44', '44279', 'Fonseca'
UNION SELECT 646, '44', '44378', 'Hatonuevo'
UNION SELECT 647, '44', '44420', 'La Jagua del Pilar'
UNION SELECT 648, '44', '44430', 'Maicao'
UNION SELECT 649, '44', '44560', 'Manaure'
UNION SELECT 650, '44', '44650', 'San Juan del Cesar'
UNION SELECT 651, '44', '44847', 'Uribia'
UNION SELECT 652, '44', '44855', 'Urumita'
UNION SELECT 653, '44', '44874', 'Villanueva'
UNION SELECT 654, '47', '47001', 'Santa Marta'
UNION SELECT 655, '47', '47030', 'Algarrobo'
UNION SELECT 656, '47', '47053', 'Aracataca'
UNION SELECT 657, '47', '47058', 'Ariguaní El Díficil'
UNION SELECT 658, '47', '47161', 'Cerro San Antonio'
UNION SELECT 659, '47', '47170', 'Chibolo'
UNION SELECT 660, '47', '47189', 'Ciénaga'
UNION SELECT 661, '47', '47205', 'Concordia'
UNION SELECT 662, '47', '47245', 'El Banco'
UNION SELECT 663, '47', '47258', 'El Piñon'
UNION SELECT 664, '47', '47268', 'El Retén'
UNION SELECT 665, '47', '47288', 'Fundación'
UNION SELECT 666, '47', '47318', 'Guamal'
UNION SELECT 667, '47', '47460', 'Nueva Granada'
UNION SELECT 668, '47', '47541', 'Pedraza'
UNION SELECT 669, '47', '47545', 'Pijiño del Carmen'
UNION SELECT 670, '47', '47551', 'Pivijay'
UNION SELECT 671, '47', '47555', 'Plato'
UNION SELECT 672, '47', '47570', 'Puebloviejo'
UNION SELECT 673, '47', '47605', 'Remolino'
UNION SELECT 674, '47', '47660', 'Sabanas de San Angel'
UNION SELECT 675, '47', '47675', 'Salamina'
UNION SELECT 676, '47', '47692', 'San Sebastián de Buenavista'
UNION SELECT 677, '47', '47703', 'San Zenón'
UNION SELECT 678, '47', '47707', 'Santa Ana'
UNION SELECT 679, '47', '47720', 'Santa Bárbara Pinto'
UNION SELECT 680, '47', '47745', 'Sitionuevo'
UNION SELECT 681, '47', '47798', 'Tenerife'
UNION SELECT 682, '47', '47960', 'Zapayán'
UNION SELECT 683, '47', '47980', 'Zona Bananera'
UNION SELECT 684, '50', '50001', 'Villavicencio'
UNION SELECT 685, '50', '50006', 'Acacías'
UNION SELECT 686, '50', '50110', 'Barranca de Upía'
UNION SELECT 687, '50', '50124', 'Cabuyaro'
UNION SELECT 688, '50', '50150', 'Castilla la Nueva'
UNION SELECT 689, '50', '50223', 'Cubarral'
UNION SELECT 690, '50', '50226', 'Cumaral'
UNION SELECT 691, '50', '50245', 'El Calvario'
UNION SELECT 692, '50', '50251', 'El Castillo'
UNION SELECT 693, '50', '50270', 'El Dorado'
UNION SELECT 694, '50', '50287', 'Fuente de Oro'
UNION SELECT 695, '50', '50313', 'Granada'
UNION SELECT 696, '50', '50318', 'Guamal'
UNION SELECT 697, '50', '50325', 'Mapiripán'
UNION SELECT 698, '50', '50330', 'Mesetas'
UNION SELECT 699, '50', '50350', 'La Macarena'
UNION SELECT 700, '50', '50370', 'La Uribe'
UNION SELECT 701, '50', '50400', 'Lejanías'
UNION SELECT 702, '50', '50450', 'Puerto Concordia'
UNION SELECT 703, '50', '50568', 'Puerto Gaitán'
UNION SELECT 704, '50', '50573', 'Puerto López'
UNION SELECT 705, '50', '50577', 'Puerto Lleras'
UNION SELECT 706, '50', '50590', 'Puerto Rico'
UNION SELECT 707, '50', '50606', 'Restrepo'
UNION SELECT 708, '50', '50680', 'San Carlos de Guaroa'
UNION SELECT 709, '50', '50683', 'San Juan de Arama'
UNION SELECT 710, '50', '50686', 'San Juanito'
UNION SELECT 711, '50', '50689', 'San Martín'
UNION SELECT 712, '50', '50711', 'Vistahermosa'
UNION SELECT 713, '52', '52001', 'Pasto'
UNION SELECT 714, '52', '52019', 'Albán San José'
UNION SELECT 715, '52', '52022', 'Aldana'
UNION SELECT 716, '52', '52036', 'Ancuyá'
UNION SELECT 717, '52', '52051', 'Arboleda Berruecos'
UNION SELECT 718, '52', '52079', 'Barbacoas'
UNION SELECT 719, '52', '52083', 'Belén'
UNION SELECT 720, '52', '52110', 'Buesaco'
UNION SELECT 721, '52', '52203', 'Colón Genova'
UNION SELECT 722, '52', '52207', 'Consacá'
UNION SELECT 723, '52', '52210', 'Contadero'
UNION SELECT 724, '52', '52215', 'Córdoba'
UNION SELECT 725, '52', '52224', 'Cuaspud Carlosama'
UNION SELECT 726, '52', '52227', 'Cumbal'
UNION SELECT 727, '52', '52233', 'Cumbitara'
UNION SELECT 728, '52', '52240', 'Chachaguí'
UNION SELECT 729, '52', '52250', 'El Charco'
UNION SELECT 730, '52', '52254', 'El Peñol'
UNION SELECT 731, '52', '52256', 'El Rosario'
UNION SELECT 732, '52', '52258', 'El Tablón de Gómez'
UNION SELECT 733, '52', '52260', 'El Tambo'
UNION SELECT 734, '52', '52287', 'Funes'
UNION SELECT 735, '52', '52317', 'Guachucal'
UNION SELECT 736, '52', '52320', 'Guaitarilla'
UNION SELECT 737, '52', '52323', 'Gualmatán'
UNION SELECT 738, '52', '52352', 'Iles'
UNION SELECT 739, '52', '52354', 'Imués'
UNION SELECT 740, '52', '52356', 'Ipiales'
UNION SELECT 741, '52', '52378', 'La Cruz'
UNION SELECT 742, '52', '52381', 'La Florida'
UNION SELECT 743, '52', '52385', 'La Llanada'
UNION SELECT 744, '52', '52390', 'La Tola'
UNION SELECT 745, '52', '52399', 'La Unión'
UNION SELECT 746, '52', '52405', 'Leiva'
UNION SELECT 747, '52', '52411', 'Linares'
UNION SELECT 748, '52', '52418', 'Sotomayor'
UNION SELECT 749, '52', '52427', 'Payan'
UNION SELECT 750, '52', '52435', 'Piedrancha'
UNION SELECT 751, '52', '52473', 'Mosquera'
UNION SELECT 752, '52', '52480', 'Nariño'
UNION SELECT 753, '52', '52490', 'Olaya Herrera'
UNION SELECT 754, '52', '52506', 'Ospina'
UNION SELECT 755, '52', '52520', 'Francisco Pizarro'
UNION SELECT 756, '52', '52540', 'Policarpa'
UNION SELECT 757, '52', '52560', 'Potosí'
UNION SELECT 758, '52', '52565', 'Providencia'
UNION SELECT 759, '52', '52573', 'Puerres'
UNION SELECT 760, '52', '52585', 'Pupiales'
UNION SELECT 761, '52', '52612', 'Ricaurte'
UNION SELECT 762, '52', '52621', 'Roberto Payán (San José )'
UNION SELECT 763, '52', '52678', 'Samaniego'
UNION SELECT 764, '52', '52683', 'Sandoná'
UNION SELECT 765, '52', '52685', 'San Bernardo'
UNION SELECT 766, '52', '52687', 'San Lorenzo'
UNION SELECT 767, '52', '52693', 'San Pablo'
UNION SELECT 768, '52', '52694', 'San Pedro de Cartago'
UNION SELECT 769, '52', '52696', 'Santa Bárbara (Iscuande)'
UNION SELECT 770, '52', '52699', 'Guachaves'
UNION SELECT 771, '52', '52720', 'Sapuyes'
UNION SELECT 772, '52', '52786', 'Taminango'
UNION SELECT 773, '52', '52788', 'Tangua'
UNION SELECT 774, '52', '52835', 'Tumaco'
UNION SELECT 775, '52', '52838', 'Túquerres'
UNION SELECT 776, '52', '52885', 'Yacuanquer'
UNION SELECT 777, '54', '54001', 'Cúcuta'
UNION SELECT 778, '54', '54003', 'Abrego'
UNION SELECT 779, '54', '54051', 'Arboledas'
UNION SELECT 780, '54', '54099', 'Bochalema'
UNION SELECT 781, '54', '54109', 'Bucarasica'
UNION SELECT 782, '54', '54125', 'Cácota'
UNION SELECT 783, '54', '54128', 'Cachira'
UNION SELECT 784, '54', '54172', 'Chinácota'
UNION SELECT 785, '54', '54174', 'Chitagá'
UNION SELECT 786, '54', '54206', 'Convención'
UNION SELECT 787, '54', '54223', 'Cucutilla'
UNION SELECT 788, '54', '54239', 'Durania'
UNION SELECT 789, '54', '54245', 'El Carmen'
UNION SELECT 790, '54', '54250', 'El Tarra'
UNION SELECT 791, '54', '54261', 'El Zulia'
UNION SELECT 792, '54', '54313', 'Gramalote'
UNION SELECT 793, '54', '54344', 'Hacarí'
UNION SELECT 794, '54', '54347', 'Herrán'
UNION SELECT 795, '54', '54377', 'Labateca'
UNION SELECT 796, '54', '54385', 'La Esperanza'
UNION SELECT 797, '54', '54398', 'La Playa'
UNION SELECT 798, '54', '54405', 'Los Patios'
UNION SELECT 799, '54', '54418', 'Lourdes'
UNION SELECT 800, '54', '54480', 'Mutiscua'
UNION SELECT 801, '54', '54498', 'Ocaña'
UNION SELECT 802, '54', '54518', 'Pamplona'
UNION SELECT 803, '54', '54520', 'Pamplonita'
UNION SELECT 804, '54', '54553', 'Puerto Santander'
UNION SELECT 805, '54', '54599', 'Ragonvalia'
UNION SELECT 806, '54', '54660', 'Salazar'
UNION SELECT 807, '54', '54670', 'San Calixto'
UNION SELECT 808, '54', '54673', 'San Cayetano'
UNION SELECT 809, '54', '54680', 'Santiago'
UNION SELECT 810, '54', '54720', 'Sardinata'
UNION SELECT 811, '54', '54743', 'Silos'
UNION SELECT 812, '54', '54800', 'Teorama'
UNION SELECT 813, '54', '54810', 'Tibú'
UNION SELECT 814, '54', '54820', 'Toledo'
UNION SELECT 815, '54', '54871', 'Villa Caro'
UNION SELECT 816, '54', '54874', 'Villa Rosario'
UNION SELECT 817, '63', '63001', 'Armenia'
UNION SELECT 818, '63', '63111', 'Buenavista'
UNION SELECT 819, '63', '63130', 'Calarca'
UNION SELECT 820, '63', '63190', 'Circasia'
UNION SELECT 821, '63', '63212', 'Córdoba'
UNION SELECT 822, '63', '63272', 'Filandia'
UNION SELECT 823, '63', '63302', 'Génova'
UNION SELECT 824, '63', '63401', 'La Tebaida'
UNION SELECT 825, '63', '63470', 'Montenegro'
UNION SELECT 826, '63', '63548', 'Pijao'
UNION SELECT 827, '63', '63594', 'Quimbaya'
UNION SELECT 828, '63', '63690', 'Salento'
UNION SELECT 829, '66', '66001', 'Pereira'
UNION SELECT 830, '66', '66045', 'Apía'
UNION SELECT 831, '66', '66075', 'Balboa'
UNION SELECT 832, '66', '66088', 'Belén de Umbría'
UNION SELECT 833, '66', '66170', 'Dosquebradas'
UNION SELECT 834, '66', '66318', 'Guática'
UNION SELECT 835, '66', '66383', 'La Celia'
UNION SELECT 836, '66', '66400', 'La Virginia'
UNION SELECT 837, '66', '66440', 'Marsella'
UNION SELECT 838, '66', '66456', 'Mistrató'
UNION SELECT 839, '66', '66572', 'Pueblo Rico'
UNION SELECT 840, '66', '66594', 'Quinchía'
UNION SELECT 841, '66', '66682', 'Santa Rosa de Cabal'
UNION SELECT 842, '66', '66687', 'Santuario'
UNION SELECT 843, '68', '68001', 'Bucaramanga'
UNION SELECT 844, '68', '68013', 'Aguada'
UNION SELECT 845, '68', '68020', 'Albania'
UNION SELECT 846, '68', '68051', 'Aratoca'
UNION SELECT 847, '68', '68077', 'Barbosa'
UNION SELECT 848, '68', '68079', 'Barichara'
UNION SELECT 849, '68', '68081', 'Barrancabermeja'
UNION SELECT 850, '68', '68092', 'Betulia'
UNION SELECT 851, '68', '68101', 'Bolívar'
UNION SELECT 852, '68', '68121', 'Cabrera'
UNION SELECT 853, '68', '68132', 'California'
UNION SELECT 854, '68', '68147', 'Capitanejo'
UNION SELECT 855, '68', '68152', 'Carcasí'
UNION SELECT 856, '68', '68160', 'Cepitá'
UNION SELECT 857, '68', '68162', 'Cerrito'
UNION SELECT 858, '68', '68167', 'Charalá'
UNION SELECT 859, '68', '68169', 'Charta'
UNION SELECT 860, '68', '68176', 'Chima'
UNION SELECT 861, '68', '68179', 'Chipatá'
UNION SELECT 862, '68', '68190', 'Cimitarra'
UNION SELECT 863, '68', '68207', 'Concepción'
UNION SELECT 864, '68', '68209', 'Confines'
UNION SELECT 865, '68', '68211', 'Contratación'
UNION SELECT 866, '68', '68217', 'Coromoro'
UNION SELECT 867, '68', '68229', 'Curití'
UNION SELECT 868, '68', '68235', 'El Carmen de Chucurí'
UNION SELECT 869, '68', '68245', 'El Guacamayo'
UNION SELECT 870, '68', '68250', 'El Peñón'
UNION SELECT 871, '68', '68255', 'El Playón'
UNION SELECT 872, '68', '68264', 'Encino'
UNION SELECT 873, '68', '68266', 'Enciso'
UNION SELECT 874, '68', '68271', 'Florián'
UNION SELECT 875, '68', '68276', 'Floridablanca'
UNION SELECT 876, '68', '68296', 'Galán'
UNION SELECT 877, '68', '68298', 'Gambita'
UNION SELECT 878, '68', '68307', 'Girón'
UNION SELECT 879, '68', '68318', 'Guaca'
UNION SELECT 880, '68', '68320', 'Guadalupe'
UNION SELECT 881, '68', '68322', 'Guapotá'
UNION SELECT 882, '68', '68324', 'Guavatá'
UNION SELECT 883, '68', '68327', 'Guepsa'
UNION SELECT 884, '68', '68344', 'Hato'
UNION SELECT 885, '68', '68368', 'Jesús María'
UNION SELECT 886, '68', '68370', 'Jordán'
UNION SELECT 887, '68', '68377', 'La Belleza'
UNION SELECT 888, '68', '68385', 'Landázuri'
UNION SELECT 889, '68', '68397', 'La Paz'
UNION SELECT 890, '68', '68406', 'Lebríja'
UNION SELECT 891, '68', '68418', 'Los Santos'
UNION SELECT 892, '68', '68425', 'Macaravita'
UNION SELECT 893, '68', '68432', 'Málaga'
UNION SELECT 894, '68', '68444', 'Matanza'
UNION SELECT 895, '68', '68464', 'Mogotes'
UNION SELECT 896, '68', '68468', 'Molagavita'
UNION SELECT 897, '68', '68498', 'Ocamonte'
UNION SELECT 898, '68', '68500', 'Oiba'
UNION SELECT 899, '68', '68502', 'Onzaga'
UNION SELECT 900, '68', '68522', 'Palmar'
UNION SELECT 901, '68', '68524', 'Palmas del Socorro'
UNION SELECT 902, '68', '68533', 'Páramo'
UNION SELECT 903, '68', '68547', 'Piedecuesta'
UNION SELECT 904, '68', '68549', 'Pinchote'
UNION SELECT 905, '68', '68572', 'Puente Nacional'
UNION SELECT 906, '68', '68573', 'Puerto Parra'
UNION SELECT 907, '68', '68575', 'Puerto Wilches'
UNION SELECT 908, '68', '68615', 'Rionegro'
UNION SELECT 909, '68', '68655', 'Sabana de Torres'
UNION SELECT 910, '68', '68669', 'San Andrés'
UNION SELECT 911, '68', '68673', 'San Benito'
UNION SELECT 912, '68', '68679', 'San Gil'
UNION SELECT 913, '68', '68682', 'San Joaquín'
UNION SELECT 914, '68', '68684', 'San José de Miranda'
UNION SELECT 915, '68', '68686', 'San Miguel'
UNION SELECT 916, '68', '68689', 'San Vicente de Chucuri'
UNION SELECT 917, '68', '68705', 'Santa Bárbara'
UNION SELECT 918, '68', '68720', 'Santa Helena del Opón'
UNION SELECT 919, '68', '68745', 'Simacota'
UNION SELECT 920, '68', '68755', 'Socorro'
UNION SELECT 921, '68', '68770', 'Suaita'
UNION SELECT 922, '68', '68773', 'Sucre'
UNION SELECT 923, '68', '68780', 'Suratá'
UNION SELECT 924, '68', '68820', 'Tona'
UNION SELECT 925, '68', '68855', 'Valle de San José'
UNION SELECT 926, '68', '68861', 'Vélez'
UNION SELECT 927, '68', '68867', 'Vetas'
UNION SELECT 928, '68', '68872', 'Villanueva'
UNION SELECT 929, '68', '68895', 'Zapatoca'
UNION SELECT 930, '70', '70001', 'Sincelejo'
UNION SELECT 931, '70', '70110', 'Buenavista'
UNION SELECT 932, '70', '70124', 'Caimito'
UNION SELECT 933, '70', '70204', 'Coloso Ricaurte'
UNION SELECT 934, '70', '70215', 'Corozal'
UNION SELECT 935, '70', '70221', 'Coveñas'
UNION SELECT 936, '70', '70230', 'Chalán'
UNION SELECT 937, '70', '70233', 'El Roble'
UNION SELECT 938, '70', '70235', 'Galeras Nueva Granada'
UNION SELECT 939, '70', '70265', 'Guaranda'
UNION SELECT 940, '70', '70400', 'La Unión'
UNION SELECT 941, '70', '70418', 'Los Palmitos'
UNION SELECT 942, '70', '70429', 'Majagual'
UNION SELECT 943, '70', '70473', 'Morroa'
UNION SELECT 944, '70', '70508', 'Ovejas'
UNION SELECT 945, '70', '70523', 'Palmito'
UNION SELECT 946, '70', '70670', 'Sampués'
UNION SELECT 947, '70', '70678', 'San Benito Abad'
UNION SELECT 948, '70', '70702', 'San Juan de Betulia'
UNION SELECT 949, '70', '70708', 'San Marcos'
UNION SELECT 950, '70', '70713', 'San Onofre'
UNION SELECT 951, '70', '70717', 'San Pedro'
UNION SELECT 952, '70', '70742', 'Sincé'
UNION SELECT 953, '70', '70771', 'Sucre'
UNION SELECT 954, '70', '70820', 'Santiago de Tolú'
UNION SELECT 955, '70', '70823', 'Toluviejo'
UNION SELECT 956, '73', '73001', 'Ibagué'
UNION SELECT 957, '73', '73024', 'Alpujarra'
UNION SELECT 958, '73', '73026', 'Alvarado'
UNION SELECT 959, '73', '73030', 'Ambalema'
UNION SELECT 960, '73', '73043', 'Anzoátegui'
UNION SELECT 961, '73', '73055', 'Armero Guayabal'
UNION SELECT 962, '73', '73067', 'Ataco'
UNION SELECT 963, '73', '73124', 'Cajamarca'
UNION SELECT 964, '73', '73148', 'Carmen de Apicalá'
UNION SELECT 965, '73', '73152', 'Casabianca'
UNION SELECT 966, '73', '73168', 'Chaparral'
UNION SELECT 967, '73', '73200', 'Coello'
UNION SELECT 968, '73', '73217', 'Coyaima'
UNION SELECT 969, '73', '73226', 'Cunday'
UNION SELECT 970, '73', '73236', 'Dolores'
UNION SELECT 971, '73', '73268', 'Espinal'
UNION SELECT 972, '73', '73270', 'Falan'
UNION SELECT 973, '73', '73275', 'Flandes'
UNION SELECT 974, '73', '73283', 'Fresno'
UNION SELECT 975, '73', '73319', 'Guamo'
UNION SELECT 976, '73', '73347', 'Herveo'
UNION SELECT 977, '73', '73349', 'Honda'
UNION SELECT 978, '73', '73352', 'Icononzo'
UNION SELECT 979, '73', '73408', 'Lérida'
UNION SELECT 980, '73', '73411', 'Líbano'
UNION SELECT 981, '73', '73443', 'Mariquita'
UNION SELECT 982, '73', '73449', 'Melgar'
UNION SELECT 983, '73', '73461', 'Murillo'
UNION SELECT 984, '73', '73483', 'Natagaima'
UNION SELECT 985, '73', '73504', 'Ortega'
UNION SELECT 986, '73', '73520', 'Palocabildo'
UNION SELECT 987, '73', '73547', 'Piedras'
UNION SELECT 988, '73', '73555', 'Planadas'
UNION SELECT 989, '73', '73563', 'Prado'
UNION SELECT 990, '73', '73585', 'Purificación'
UNION SELECT 991, '73', '73616', 'Rioblanco'
UNION SELECT 992, '73', '73622', 'Roncesvalles'
UNION SELECT 993, '73', '73624', 'Rovira'
UNION SELECT 994, '73', '73671', 'Saldaña'
UNION SELECT 995, '73', '73675', 'San Antonio'
UNION SELECT 996, '73', '73678', 'San Luis'
UNION SELECT 997, '73', '73686', 'Santa Isabel'
UNION SELECT 998, '73', '73770', 'Suárez'
UNION SELECT 999, '73', '73854', 'Valle de San Juan'
UNION SELECT 1000, '73', '73861', 'Venadillo'
UNION SELECT 1001, '73', '73870', 'Villahermosa'
UNION SELECT 1002, '73', '73873', 'Villarrica'
UNION SELECT 1003, '76', '76001', 'Cali'
UNION SELECT 1004, '76', '76020', 'Alcalá'
UNION SELECT 1005, '76', '76036', 'Andalucía'
UNION SELECT 1006, '76', '76041', 'Ansermanuevo'
UNION SELECT 1007, '76', '76054', 'Argelia'
UNION SELECT 1008, '76', '76100', 'Bolívar'
UNION SELECT 1009, '76', '76109', 'Buenaventura'
UNION SELECT 1010, '76', '76111', 'Guadalajara de Buga'
UNION SELECT 1011, '76', '76113', 'Bugalagrande'
UNION SELECT 1012, '76', '76122', 'Caicedonia'
UNION SELECT 1013, '76', '76126', 'Calima Darién'
UNION SELECT 1014, '76', '76130', 'Candelaria'
UNION SELECT 1015, '76', '76147', 'Cartago'
UNION SELECT 1016, '76', '76233', 'Dagua'
UNION SELECT 1017, '76', '76243', 'El Águila'
UNION SELECT 1018, '76', '76246', 'El Cairo'
UNION SELECT 1019, '76', '76248', 'El Cerrito'
UNION SELECT 1020, '76', '76250', 'El Dovio'
UNION SELECT 1021, '76', '76275', 'Florida'
UNION SELECT 1022, '76', '76306', 'Ginebra'
UNION SELECT 1023, '76', '76318', 'Guacarí'
UNION SELECT 1024, '76', '76364', 'Jamundí'
UNION SELECT 1025, '76', '76377', 'La Cumbre'
UNION SELECT 1026, '76', '76400', 'La Unión'
UNION SELECT 1027, '76', '76403', 'La Victoria'
UNION SELECT 1028, '76', '76497', 'Obando'
UNION SELECT 1029, '76', '76520', 'Palmira'
UNION SELECT 1030, '76', '76563', 'Pradera'
UNION SELECT 1031, '76', '76606', 'Restrepo'
UNION SELECT 1032, '76', '76616', 'Riofrio'
UNION SELECT 1033, '76', '76622', 'Roldanillo'
UNION SELECT 1034, '76', '76670', 'San Pedro'
UNION SELECT 1035, '76', '76736', 'Sevilla'
UNION SELECT 1036, '76', '76823', 'Toro'
UNION SELECT 1037, '76', '76828', 'Trujillo'
UNION SELECT 1038, '76', '76834', 'Tulúa'
UNION SELECT 1039, '76', '76845', 'Ulloa'
UNION SELECT 1040, '76', '76863', 'Versalles'
UNION SELECT 1041, '76', '76869', 'Vijes'
UNION SELECT 1042, '76', '76890', 'Yotoco'
UNION SELECT 1043, '76', '76892', 'Yumbo'
UNION SELECT 1044, '76', '76895', 'Zarzal'
UNION SELECT 1045, '81', '81001', 'Arauca'
UNION SELECT 1046, '81', '81065', 'Arauquita'
UNION SELECT 1047, '81', '81220', 'Cravo Norte'
UNION SELECT 1048, '81', '81300', 'Fortul'
UNION SELECT 1049, '81', '81591', 'Puerto Rondón'
UNION SELECT 1050, '81', '81736', 'Saravena'
UNION SELECT 1051, '81', '81794', 'Tame'
UNION SELECT 1052, '85', '85001', 'Yopal'
UNION SELECT 1053, '85', '85010', 'Aguazul'
UNION SELECT 1054, '85', '85015', 'Chameza'
UNION SELECT 1055, '85', '85125', 'Hato Corozal'
UNION SELECT 1056, '85', '85136', 'La Salina'
UNION SELECT 1057, '85', '85139', 'Maní'
UNION SELECT 1058, '85', '85162', 'Monterrey'
UNION SELECT 1059, '85', '85225', 'Nunchía'
UNION SELECT 1060, '85', '85230', 'Orocué'
UNION SELECT 1061, '85', '85250', 'Paz de Ariporo'
UNION SELECT 1062, '85', '85263', 'Pore'
UNION SELECT 1063, '85', '85279', 'Recetor'
UNION SELECT 1064, '85', '85300', 'Sabanalarga'
UNION SELECT 1065, '85', '85315', 'Sácama'
UNION SELECT 1066, '85', '85325', 'San Luis de Palenque'
UNION SELECT 1067, '85', '85400', 'Támara'
UNION SELECT 1068, '85', '85410', 'Tauramena'
UNION SELECT 1069, '85', '85430', 'Trinidad'
UNION SELECT 1070, '85', '85440', 'Villa Nueva'
UNION SELECT 1071, '86', '86001', 'Mocoa'
UNION SELECT 1072, '86', '86219', 'Colón'
UNION SELECT 1073, '86', '86320', 'Orito'
UNION SELECT 1074, '86', '86568', 'Puerto Asís'
UNION SELECT 1075, '86', '86569', 'Puerto Caicedo'
UNION SELECT 1076, '86', '86571', 'Puerto Guzmán'
UNION SELECT 1077, '86', '86573', 'Puerto Leguizámo'
UNION SELECT 1078, '86', '86749', 'Sibundoy'
UNION SELECT 1079, '86', '86755', 'San Francisco'
UNION SELECT 1080, '86', '86757', 'San Miguel'
UNION SELECT 1081, '86', '86760', 'Santiago'
UNION SELECT 1082, '86', '86865', 'Valle del Guamuez (La Hormiga)'
UNION SELECT 1083, '86', '86885', 'Villagarzón'
UNION SELECT 1084, '88', '88001', 'San Andrés'
UNION SELECT 1085, '88', '88564', 'Providencia'
UNION SELECT 1086, '91', '91001', 'Leticia'
UNION SELECT 1087, '91', '91263', 'El Encanto'
UNION SELECT 1088, '91', '91405', 'La Chorrera'
UNION SELECT 1089, '91', '91407', 'La Pedrera'
UNION SELECT 1090, '91', '91430', 'La Victoria'
UNION SELECT 1091, '91', '91460', 'Mirití-Paraná'
UNION SELECT 1092, '91', '91530', 'Puerto Alegría'
UNION SELECT 1093, '91', '91536', 'Puerto Arica'
UNION SELECT 1094, '91', '91540', 'Puerto Nariño'
UNION SELECT 1095, '91', '91669', 'Puerto Santander'
UNION SELECT 1096, '91', '91798', 'Tarapacá'
UNION SELECT 1097, '94', '94001', 'Inírida'
UNION SELECT 1098, '94', '94343', 'Barranco Minas'
UNION SELECT 1099, '94', '94663', 'Mapiripana'
UNION SELECT 1100, '94', '94883', 'San Felipe'
UNION SELECT 1101, '94', '94884', 'Puerto Colombia'
UNION SELECT 1102, '94', '94885', 'La Guadalupe'
UNION SELECT 1103, '94', '94886', 'Cacahual'
UNION SELECT 1104, '94', '94887', 'Pana Pana (Campo Alegre)'
UNION SELECT 1105, '94', '94888', 'Morichal Nuevo'
UNION SELECT 1106, '95', '95001', 'San José del Guaviare'
UNION SELECT 1107, '95', '95015', 'Calamar'
UNION SELECT 1108, '95', '95025', 'El Retorno'
UNION SELECT 1109, '95', '95200', 'Miraflores'
UNION SELECT 1110, '97', '97001', 'Mitú'
UNION SELECT 1111, '97', '97161', 'Caruru'
UNION SELECT 1112, '97', '97511', 'Pacoa'
UNION SELECT 1113, '97', '97666', 'Taraira'
UNION SELECT 1114, '97', '97777', 'Papunaua (Morichal)'
UNION SELECT 1115, '97', '97889', 'Yavaraté'
UNION SELECT 1116, '99', '99001', 'Puerto Carreño'
UNION SELECT 1117, '99', '99524', 'Primavera'
UNION SELECT 1118, '99', '99624', 'Santa Rosalia'
UNION SELECT 1119, '99', '99773', 'Cumaribo';"

    Public sqlG_Departamento As String = "INSERT INTO G_Departamento (Sec, Pais, NomDpto) VALUES " &
    "(1, 249, 'Estados Unidos'), " &
    "(5, 169, 'Antioquia'), " &
    "(8, 169, 'Atlántico'), " &
    "(11, 169, 'Bogotá D.C.'), " &
    "(13, 169, 'Bolívar'), " &
    "(15, 169, 'Boyacá'), " &
    "(17, 169, 'Caldas'), " &
    "(18, 169, 'Caquetá'), " &
    "(19, 169, 'Cauca'), " &
    "(20, 169, 'Cesar'), " &
    "(23, 169, 'Córdoba'), " &
    "(25, 169, 'Cundinamarca'), " &
    "(27, 169, 'Chocó'), " &
    "(41, 169, 'Huila'), " &
    "(44, 169, 'La Guajira'), " &
    "(47, 169, 'Magdalena'), " &
    "(50, 169, 'Meta'), " &
    "(52, 169, 'Nariño'), " &
    "(54, 169, 'Norte de Santander'), " &
    "(63, 169, 'Quindío'), " &
    "(66, 169, 'Risaralda'), " &
    "(68, 169, 'Santander'), " &
    "(70, 169, 'Sucre'), " &
    "(73, 169, 'Tolima'), " &
    "(76, 169, 'Valle del Cauca'), " &
    "(81, 169, 'Arauca'), " &
    "(85, 169, 'Casanare'), " &
    "(86, 169, 'Putumayo'), " &
    "(88, 169, 'San Andrés'), " &
    "(91, 169, 'Amazonas'), " &
    "(94, 169, 'Guainía'), " &
    "(95, 169, 'Guaviare'), " &
    "(97, 169, 'Vaupés'), " &
    "(99, 169, 'Vichada')"

    Public sqlCodigosDian As String = "INSERT INTO CodigosDian (Codigo, Descripcion) VALUES " &
    "('NIE069', 'Cantidad de dias laborados durante el Periodo de Pago'), " &
    "('NIE070', 'Corresponde al Sueldo Trabajado por los días laborados'), " &
    "('NIE071', 'Valor de Auxilio de Transporte que recibe el trabajador por ley, según aplique'), " &
    "('NIE072', 'Valor de Viaticos, Manutención y Alojamiento de carácter Salarial'), " &
    "('NIE073', 'Valor de Viaticos, Manutención y Alojamiento de carácter No Salarial'), " &
    "('NIE074', 'Hora de inicio de Hora Extra Diurna'), " &
    "('NIE075', 'Hora de fin de Hora Extra Diurna'), " &
    "('NIE076', 'Cantidad de Horas Extra Diurna'), " &
    "('NIE077', 'Porcentaje al cual corresponde el calculo de 1 hora Extra Diurna'), " &
    "('NIE078', 'Es el valor pagado por el tiempo que se trabaja adicional a la jornada legal o pactada contractualmente.'), " &
    "('NIE079', 'Hora de inicio de Hora Extra Nocturna'), " &
    "('NIE080', 'Hora de fin de Hora Extra Nocturna'), " &
    "('NIE081', 'Cantidad de Horas Extras Nocturnas'), " &
    "('NIE082', 'Porcentaje al cual corresponde el calculo de 1 hora Extra Nocturna'), " &
    "('NIE083', 'Es el valor pagado por el tiempo que se trabaja adicional a la jornada legal o pactada contractualmente.'), " &
    "('NIE084', 'Hora de inicio de Hora Recargo Nocturno'), " &
    "('NIE085', 'Hora de fin de Hora Recargo Nocturno'), " &
    "('NIE086', 'Cantidad de Horas Recargo Nocturno'), " &
    "('NIE087', 'Porcentaje al cual corresponde el calculo de 1 hora Recargo Nocturno'), " &
    "('NIE088', 'Es el valor pagado por el tiempo que se trabaja adicional a la jornada legal o pactada contractualmente.'), " &
    "('NIE089', 'Hora de inicio de Horas Extras Diurnas Dominical y Festivos'), " &
    "('NIE090', 'Hora de fin de Horas Extras Diurnas Dominical y Festivos'), " &
    "('NIE091', 'Cantidad de Horas Extras Diurnas Dominical y Festivos'), " &
    "('NIE092', 'Porcentaje al cual corresponde el calculo de 1 Hora Extra Diurna Dominical y Festivo'), " &
    "('NIE093', 'Es el valor pagado por el tiempo que se trabaja adicional a la jornada legal o pactada contractualmente.'), " &
    "('NIE094', 'Hora de inicio de Horas Recargo Diurno Dominical y Festivos'), " &
    "('NIE095', 'Hora de fin de Horas Recargo Diurno Dominical y Festivos'), " &
    "('NIE096', 'Cantidad de Horas Recargo Diurno Dominical y Festivos'), " &
    "('NIE097', 'Porcentaje al cual corresponde el calculo de 1 Hora Recargo Diurno Dominical y Festivos'), " &
    "('NIE098', 'Es el valor pagado por el tiempo que se trabaja adicional a la jornada legal o pactada contractualmente.'), " &
    "('NIE099', 'Hora de inicio de Horas Extras Nocturna Dominical y Festivos'), " &
    "('NIE100', 'Hora de fin de Horas Extras Nocturna Dominical y Festivos'), " &
    "('NIE101', 'Cantidad de Horas Extras Nocturna Dominical y Festivos'), " &
    "('NIE102', 'Porcentaje al cual corresponde el calculo de 1 Hora Extra Nocturna Dominical y Festivos'), " &
    "('NIE103', 'Es el valor pagado por el tiempo que se trabaja adicional a la jornada legal o pactada contractualmente.'), " &
    "('NIE104', 'Hora de inicio de Horas Recargo Nocturno Dominical y Festivos'), " &
    "('NIE105', 'Hora de fin de Horas Recargo Nocturno Dominical y Festivos'), " &
    "('NIE106', 'Cantidad de Horas Recargo Nocturno Dominical y Festivos'), " &
    "('NIE107', 'Porcentaje al cual corresponde el calculo de 1 Hora Recargo Nocturno Dominical y Festivos'), " &
    "('NIE108', 'Es el valor pagado por el tiempo que se trabaja adicional a la jornada legal o pactada contractualmente.'), " &
    "('NIE111', 'Número de días que el trabajador estuvo inactivo durante el mes por vacaciones.'), " &
    "('NIE112', 'Corresponde al valor pagado al trabajador, por el descanso remunerado que tiene derecho por haber trabajado un determinado tiempo. (Vacaciones SI disfrutadas)'), " &
    "('NIE115', 'Número de días que el trabajador estuvo activo durante el mes sin disfrutar sus vacaciones. (Vacaciones NO disfrutadas)'), " &
    "('NIE116', 'Corresponde al valor pagado al trabajador, por el descanso remunerado que no disfrutó y que tiene derecho por haber trabajado un determinado tiempo. (Vacaciones NO disfrutadas)'), " &
    "('NIE117', 'Cantidad de dias trabajados para calculo de Pago de Corte de Prima'), " &
    "('NIE118', 'Pagos por el reconocimiento del logro o cumplimiento por parte del trabajador en el desarrollo de sus labores, de condiciones definidas expresamente entre las partes.'), " &
    "('NIE119', 'Son valores pagados al trabajador de forma ocasional y por mera liberalidad o los pactados entre las partes de forma expresa como pago no salarial.'), " &
    "('NIE120', 'Pago de la Cesantia otorgada por Ley.'), " &
    "('NIE121', 'Porcentaje que corresponde al Interes de Cesantia de Ley'), " &
    "('NIE122', 'Pago de los Intereses de Cesantia otorgada por Ley.'), " &
    "('NIE123', 'Este dato se debe diligenciar solamente en el registro del mes en que el trabajador presenta o da por iniciada su Incapacidad.'), " &
    "('NIE124', 'Este dato se debe diligenciar solamente en el registro del mes en que el trabajador presenta o da por terminada su Incapacidad.'), " &
    "('NIE125', 'Número de días que el trabajador o aprendiz estuvo inactivo por incapacidad (sin importar su origen).'), " &
    "('NIE126', 'Se debe indicar el codigo al cual corresponda el tipo de incapacidad del Empleado'), " &
    "('NIE127', 'Valor de la prestación económica pagada al trabajador por consecuencia de la falta de capacidad laboral sin importar su origen.'), " &
    "('NIE128', 'Fecha donde da inicio la Licencia de Maternidad o Paternidad'), " &
    "('NIE129', 'Fecha donde termina la Licencia de Maternidad o Paternidad'), " &
    "('NIE130', 'Número de días que el trabajador o aprendiz efectivamente estuvo inactivo por licencia de maternidad o paternidad.'), " &
    "('NIE131', 'Valor pagado al trabajador del descanso remunerado que la ley confiere por el nacimiento de un hijo, y que es reconocido y pagado por la EPS a la que está afiliado el padre o la madre, o en su defecto por el empleador.'), " &
    "('NIE132', 'Este dato se debe diligenciar solamente en el registro del mes en que el  trabajador o aprendiz inicia algún permiso o licencia remunerada.'), " &
    "('NIE133', 'Este dato se debe diligenciar solamente en el registro del mes en que el trabajador o aprendiz termina el permiso o licencia remunerada.'), " &
    "('NIE134', 'Número de días que el trabajador o aprendiz efectivamente estuvo inactivo por permiso o licencia pero que le fueron reconocidos en su pago.'), " &
    "('NIE135', 'Valor pagado al trabajador corresponde a tiempo no laborado, que por ley o por acuerdo con el empleador se le concede'), " &
    "('NIE136', 'Este dato se debe diligenciar solamente en el registro del mes en que el trabajador o aprendiz inicia alguna suspensión, permiso o licencia NO remunerada.'), " &
    "('NIE137', 'Este dato se debe diligenciar solamente en el registro del mes en que el trabajador o aprendiz termina la suspensión, permiso o licencia NO remunerada.'), " &
    "('NIE138', 'Número de días que el trabajador o aprendiz efectivamente estuvo inactivo por suspensión, permiso o licencia y que NO le fueron reconocidos en su pago.'), " &
    "('NIE139', 'Son valores pagados al trabajador en forma de incentivo o recompensa por la contraprestación directa del servicio.'), " &
    "('NIE140', 'Son valores de incentivos pagados al trabajador de forma ocasional y por mera liberalidad o los pactados entre las partes de forma expresa como pago no salarial.'), " &
    "('NIE141', 'Son beneficios, ayudas o apoyos económicos, pagados al trabajador de forma habitual o pactados entre las partes como factor salarial.'), " &
    "('NIE142', 'Son beneficios, ayudas o apoyos económicos, pagados al trabajador de forma ocasional y por mera liberalidad o los pactados entre las partes de forma expresa como pago no salarial.'), " &
    "('NIE143', 'Este dato se debe diligenciar solamente en el registro del mes en que el trabajador inicia la huelga legalmente declarada.'), " &
    "('NIE144', 'Este dato se debe diligenciar solamente en el registro del mes en que el trabajador termina la huelga legalmente declarada.'), " &
    "('NIE145', 'número de días en los que el trabajador estuvo inactivo por huelga legalmente declarada.'), " &
    "('NIE146', 'Nombre del Concepto que corresponde a los demás pagos fijos o variables realizados al trabajador que remuneren en dinero o en especie como contraprestación directa del servicio, sea cualquiera la forma o denominación que se adopte.'), " &
    "('NIE147', 'Valor de los demás pagos fijos o variables realizados al trabajador que remuneren en dinero o en especie como contraprestación directa del servicio, sea cualquiera la forma o denominación que se adopte (Salarial).'), " &
    "('NIE148', 'Valor de los demás pagos que ocasionalmente y por mera liberalidad recibe el trabajador del empleador, en dinero o en especie no para su beneficio, ni para enriquecer su patrimonio, sino para desempeñar a cabalidad sus funciones (No Salarial).'), " &
    "('NIE149', 'Suma de dinero definido en el régimen de compensaciones como retribución mensual recibido por el asociado por la ejecución de su actividad material o inmaterial, la cual se fija teniendo en cuenta el tipo de labor desempeñada, el rendimiento o la productividad y la cantidad de trabajo portado. El monto de la compensación ordinaria podrá ser una suma básica igual para todos los asociados (Ordinaria).'), " &
    "('NIE150', 'Los demás pagos adicionales a la Compensación Ordinaria que recibe el asociado como retribución por su trabajo, definidos en el régimen de compensaciones (Extraordinaria).'), " &
    "('NIE151', 'Valor que el trabajador recibe como contraprestación por el trabajo realizado, por medio de bonos electrónicos, recargas, cheques, vales. es decir, todo pago realizado en un medio diferente a dinero en efectivo o consignación de cuenta bancaria (Salarial).'), " &
    "('NIE152', 'Valor que el trabajador recibe como concepto no salarial, por medio de bonos electrónicos, recargas, cheques, vales. es decir, todo pago realizado en un medio diferente a dinero en efectivo o consignación de cuenta bancaria (No Salarial).'), " &
    "('NIE153', 'Valor que el trabajador recibe como concepto no salarial, por medio de bonos electrónicos, recargas, cheques, vales. es decir, todo pago realizado en un medio diferente a dinero en efectivo o consignación de cuenta bancaria (Para Alimentación Salarial).'), " &
    "('NIE154', 'Valor que el trabajador recibe como concepto no salarial, por medio de bonos electrónicos, recargas, cheques, vales. es decir, todo pago realizado en un medio diferente a dinero en efectivo o consignación de cuenta bancaria (Para Alimentación No Salarial).'), " &
    "('NIE155', 'Valor pagado al trabajador usualmente del área comercial, y de forma regular se liquida con un porcentaje sobre el importe de una operación, también se presenta como incentivo por el logro de objetivos.'), " &
    "('NIE156', 'De conformidad con lo previsto en el artículo 230 del Código Sustantivo del Trabajo, o la norma que lo modifique, adicione o sustituya, corresponde al valor que el empleador dispone para suministrar la dotación de sus trabajadores.'), " &
    "('NIE157', 'Corresponde al valor no salarial que el patrocinador paga de forma mensual como ayuda o apoyo economía al aprendiz o practicante universitario durante su etapa lectiva y fase practica.'), " &
    "('NIE158', 'Valor que debe ser pagado al trabajador cuyo contrato indica expresamente que puede laborar mediante teletrabajo'), " &
    "('NIE159', 'Valor establecido por mutuo acuerdo por retiro del Trabajador'), " &
    "('NIE160', 'Valor de Indemnizacion establecido por ley'), " &
    "('NIE161', 'Debe corresponder al porcentaje de deducción de salud que paga el trabajador'), " &
    "('NIE163', 'El trabajador debe estar afiliado al sistema de salud. La cotización por salud que corresponde al 12.5% de la base del aporte, se hace en conjunto con la empresa. Ésta última aporta el 8.5%, y el empleado debe aportar el 4% restante. Ese 4% es el valor que se debe descontar (deducir) del total devengado a cargo del empleado.'), " &
    "('NIE164', 'Debe corresponder al porcentaje de deducción de fondo de pensión que paga el trabajador'), " &
    "('NIE166', 'El trabajador también debe estar afiliado al sistema de pensiones. La cotización por pensión está a cargo tanto de la empresa como del empleado. Del total del aporte (16%), la empresa aporta el 75% (12%) y el trabajador aporta el restante 25% (4%). Como el trabajador debe aportar un 4% por concepto de pensión, este valor se le descuenta (deduce) del valor devengado en el respectivo periodo (mes o quincena).'), " &
    "('NIE167', 'Debe corresponder al porcentaje de deducción de fondo de seguridad pensional que paga el trabajador'), " &
    "('NIE168', 'Todo trabajador que devengue un sueldo que sea igual o superior a 4 salarios mininos, debe aportar un 1% al Fondo de solidaridad pensional.'), " &
    "('NIE169', 'Se debe colocar el Porcentaje que correspondiente al Fondo de Subsistencia correspondiente'), " &
    "('NIE170', 'Valor Pagado correspondiente a Fondo de Subsistencia por parte del trabajador'), " &
    "('NIE171', 'Porcentaje establecido en la ley o por estatutos del sindicato.'), " &
    "('NIE172', 'Las cuotas que los trabajadores sindicalizados deben aportar al sindicato al que estén afiliados, y siempre que medie autorización del empleado.'), " &
    "('NIE173', 'Valor por el del incumplimiento de una regla o norma de conducta obligatoria (Publica)'), " &
    "('NIE174', 'Valor por el del incumplimiento de una regla o norma de conducta obligatoria (Privada o Ordinaria)'), " &
    "('NIE175', 'Nombre de la Libranza que corresponda a las cuotas que el empleado deba pagar a una entidad financiera, para la amortización de un crédito que le haya sido otorgado por libranza'), " &
    "('NIE176', 'Las cuotas que el empleado deba pagar a una entidad financiera, para la amortización de un crédito que le haya sido otorgado por libranza'), " &
    "('NIE177', 'Valor Pagado correspondiente a Retención en la Fuente por parte del trabajador'), " &
    "('NIE179', 'Valor Pagado correspondiente a AFC por parte del trabajador'), " &
    "('NIE180', 'Valor Pagado correspondiente a Cooperativas por parte del trabajador'), " &
    "('NIE181', 'Valor Pagado correspondiente aEmbargos Fiscales por parte del trabajador'), " &
    "('NIE182', 'Valor Pagado correspondiente a Planes Complementarios por parte del trabajador'), " &
    "('NIE183', 'Valor Pagado correspondiente a Conceptos Educativos por parte del trabajador'), " &
    "('NIE184', 'Valor Pagado correspondiente a Reintegro por parte del trabajador'), " &
    "('NIE185', 'Valor Pagado correspondiente a Deuda con la Empresa por parte del trabajador'), " &
    "('NIE193', 'Beneficios en cabeza del Trabjador que se pagan a un proveedor o tercero.'), " &
    "('NIE194', 'Anticipos de Nómina.'), " &
    "('NIE195', 'Deducciones en cabeza del Trabjador que se pagan a un proveedor o tercero.'), " &
    "('NIE196', 'Deduccion por Anticipos de Nómina.'), " &
    "('NIE197', 'Valor Pagado por Otra Deducción'), " &
    "('NIE198', 'Valor Pagado correspondiente al ahorro que hace el trabajador para complementar su pension obligatoria o cumplir metas especificas.'), " &
    "('NIE201', 'Valor que le regresa la empresa al trabajador por una deducción mal realizada en otro pago de nomina')"
End Class
