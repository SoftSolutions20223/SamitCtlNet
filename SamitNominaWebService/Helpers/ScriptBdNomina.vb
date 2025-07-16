Imports System.Data.SqlClient

Public Class ScriptBdNomina

    Function EjecutarScriptBd(conex As SqlConnection) As Boolean
        Try
            Dim rawScript As String = ScriptBd.Trim() _
  .Replace(vbCrLf, vbLf) _
  .Replace(vbCr, vbLf)      ' todas las variaciones pasan a "\n"

            ' Ahora sí partimos sobre "\nGO\n"
            Dim bloques As String() = rawScript.Split(
  New String() {vbLf & "GO" & vbLf},
  StringSplitOptions.RemoveEmptyEntries)

            ' 3. Ejecutar
            For Each bloque As String In bloques
                Using cmd As New SqlCommand(bloque, conex)
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                End Using
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function CreaBd(conex As SqlConnection, NombreBd As String) As Boolean
        Try
            Dim sql = "Create Database " + NombreBd

            Using cmd As New SqlCommand(sql, conex)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public ScriptBd As String =
    <root>
        <![CDATA[
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Asig_ValoresExentos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Asig_ValoresExentos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NULL,
	[Valor] [money] NULL,
	[ValorExento] [int] NULL,
	[Certificado] [image] NULL,
	[Vigente] [bit] NULL,
 CONSTRAINT [PKA_Asig_ValoresExentos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[BasesConceptos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BasesConceptos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BasesConceptos](
	[Sec] [int] NOT NULL,
	[NomBase] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
	[Formula] [nvarchar](1000) NULL,
 CONSTRAINT [PKA_BasesConceptos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Cargo_Asignaciones]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cargo_Asignaciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cargo_Asignaciones](
	[Sec] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cargo] [int] NOT NULL,
	[Asignacion] [money] NULL,
 CONSTRAINT [PKA_Cargo_Asignaciones] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Cargo_Funciones]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cargo_Funciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cargo_Funciones](
	[Sec] [int] NOT NULL,
	[Cargo] [int] NOT NULL,
	[CodFuncion] [int] NOT NULL,
 CONSTRAINT [PKA_Cargo_Funciones] PRIMARY KEY CLUSTERED 
(
	[Cargo] ASC,
	[CodFuncion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cargos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cargos](
	[Sec] [int] IDENTITY(1,1) NOT NULL,
	[CodCargo] [varchar](20) NOT NULL,
	[Denominacion] [varchar](100) NOT NULL,
	[Descripcion] [varchar](1000) NOT NULL,
 CONSTRAINT [PKA_Cargos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_Bancos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_Bancos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_Bancos](
	[Sec] [int] NOT NULL,
	[Nombre] [varchar](250) NULL,
	[Vigente] [bit] NOT NULL,
 CONSTRAINT [PKA_CAT_Bancos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_ClaseLibreta]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_ClaseLibreta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_ClaseLibreta](
	[Sec] [int] NOT NULL,
	[NomClaseLib] [varchar](50) NOT NULL,
	[Vigente] [bit] NOT NULL,
 CONSTRAINT [PKA_CAT_ClaseLibreta] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_ClaseLicencia]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_ClaseLicencia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_ClaseLicencia](
	[Sec] [int] NULL,
	[idClase] [varchar](10) NOT NULL,
	[NomClase] [varchar](350) NULL,
	[Vigente] [bit] NULL,
 CONSTRAINT [PKA_CAT_ClaseLicencia] PRIMARY KEY CLUSTERED 
(
	[idClase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_EstadoCivil]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_EstadoCivil]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_EstadoCivil](
	[Sec] [int] NOT NULL,
	[NomEstado] [varchar](50) NOT NULL,
	[Vigente] [bit] NOT NULL,
 CONSTRAINT [PKA_CAT_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_Genero]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_Genero]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_Genero](
	[idgenero] [varchar](3) NOT NULL,
	[nomgenero] [varchar](50) NULL,
	[vigente] [bit] NULL,
 CONSTRAINT [PK_cat_genero] PRIMARY KEY CLUSTERED 
(
	[idgenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_NivelEducativo]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_NivelEducativo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_NivelEducativo](
	[Sec] [int] NOT NULL,
	[NomNivel] [varchar](50) NOT NULL,
	[Vigente] [bit] NOT NULL,
	[EsFormal] [bit] NOT NULL,
 CONSTRAINT [PKA_CAT_NivelEducativo] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_Parentesco]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_Parentesco]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_Parentesco](
	[Sec] [int] NOT NULL,
	[NomParentesco] [varchar](50) NOT NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PKA_CAT_Parentesco] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_Profesiones]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_Profesiones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_Profesiones](
	[Sec] [int] NOT NULL,
	[NomProfesion] [varchar](max) NOT NULL,
	[Vigente] [bit] NOT NULL,
	[IdNivelEducativo] [int] NULL,
 CONSTRAINT [PKA_CAT_Profesiones] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_TipoContratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_TipoContratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_TipoContratos](
	[Sec] [int] NOT NULL,
	[NomTipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CAT_TipoContratos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CAT_TiposId]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CAT_TiposId]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CAT_TiposId](
	[Sec] [int] NULL,
	[TipoIdentificacion] [varchar](4) NOT NULL,
	[NomTipo] [varchar](50) NOT NULL,
	[UsaEmpleados] [bit] NOT NULL,
	[UsaParientes] [bit] NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
 CONSTRAINT [PKA_CAT_TiposId] PRIMARY KEY CLUSTERED 
(
	[TipoIdentificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ClasConceptosNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClasConceptosNomina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ClasConceptosNomina](
	[Sec] [int] NOT NULL,
	[Nom] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
 CONSTRAINT [PKA_ClasConceptosNomina] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ClasConceptosPersonales]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClasConceptosPersonales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ClasConceptosPersonales](
	[Sec] [int] NOT NULL,
	[Nom] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
	[NivelP] [int] NULL,
 CONSTRAINT [PKA_ClasConceptosPersonales] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CodigosDian]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CodigosDian]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CodigosDian](
	[Sec] [int] NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Descripcion] [varchar](2000) NULL,
 CONSTRAINT [PKA_CodigosDian] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Conceptos_PerfilCta]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Conceptos_PerfilCta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Conceptos_PerfilCta](
	[Sec] [int] NOT NULL,
	[Concepto] [int] NULL,
	[CuentaContable] [varchar](20) NULL,
	[ConceptoR] [int] NULL,
	[ContraPartida] [varchar](20) NULL,
	[PerfilCta] [int] NULL,
	[Naturaleza] [varchar](1) NULL,
 CONSTRAINT [PKA_Conceptos_PerfilCta] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ConceptosNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosNomina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ConceptosNomina](
	[Sec] [int] NOT NULL,
	[NomConcepto] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
	[Formula] [varchar](200) NULL,
	[Tipo] [int] NULL,
	[PeriodosLiquida] [varchar](20) NULL,
	[Base] [varchar](200) NULL,
	[Redondea] [int] NULL,
	[Fondo] [int] NULL,
	[Clasificacion] [int] NULL,
	[EsRetencion] [bit] NULL,
	[EsPredeterminado] [bit] NULL,
	[CodDian] [varchar](20) NULL,
	[Orden] [int] NULL,
 CONSTRAINT [PKA_ConceptosNomina] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ConceptosP_Contratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosP_Contratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ConceptosP_Contratos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NULL,
	[Concepto] [int] NULL,
	[TotalDescontar] [money] NULL,
	[DescontarPeriodo] [money] NULL,
	[TotalDescontado] [money] NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
	[Vigente] [varchar](1) NULL,
	[NumCuotas] [int] NULL,
	[CuotaInicial] [int] NULL,
	[CuotaFinal] [int] NULL,
	[CuotaActual] [int] NULL,
	[AplicaLiquidaPeriodos] [bit] NULL,
	[AplicaLiquidaSemestres] [bit] NULL,
	[AplicaLiquidaExtraordinarias] [bit] NULL,
	[AplicaLiquidaContratos] [bit] NULL,
	[CtaContable] [varchar](20) NULL,
	[DocContable] [varchar](20) NULL,
 CONSTRAINT [PKA_ConceptosP_Contratos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ConceptosPersonales]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosPersonales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ConceptosPersonales](
	[Sec] [int] NOT NULL,
	[NomConcepto] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
	[Clasificacion] [int] NULL,
	[PeriodosLiquida] [varchar](20) NULL,
	[ValMaxDescuento] [varchar](2000) NULL,
	[EsPredeterminado] [bit] NULL,
	[CodDian] [varchar](20) NULL,
 CONSTRAINT [PKA_ConceptosPersonales] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ConceptosPlantillas]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosPlantillas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ConceptosPlantillas](
	[Sec] [int] NOT NULL,
	[Plantilla] [int] NOT NULL,
	[Concepto] [int] NOT NULL,
 CONSTRAINT [PKA_ConceptosPlantillas] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC,
	[Plantilla] ASC,
	[Concepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ConceptosProvisionesPlantillas]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosProvisionesPlantillas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ConceptosProvisionesPlantillas](
	[Sec] [int] NOT NULL,
	[Plantilla] [int] NOT NULL,
	[Concepto] [int] NOT NULL,
 CONSTRAINT [PKA_ConceptosProvisionesPlantillas] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC,
	[Plantilla] ASC,
	[Concepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ConfigConceptos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConfigConceptos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ConfigConceptos](
	[Sec] [int] NOT NULL,
	[Nomina] [int] NULL,
	[Concepto] [int] NULL,
	[Formula] [varchar](2000) NULL,
	[PeriodosLiquida] [varchar](20) NULL,
	[CuentaContable] [varchar](20) NULL,
	[ConceptoR] [int] NULL,
	[ContraPartida] [varchar](20) NULL,
 CONSTRAINT [PKA_ConfigConceptos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ConfigProvisiones]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConfigProvisiones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ConfigProvisiones](
	[Sec] [int] NOT NULL,
	[Concepto] [int] NULL,
	[Formula] [varchar](2000) NULL,
	[SemestresLiquida] [varchar](20) NULL,
	[CuentaContable] [varchar](20) NULL,
	[Nomina] [int] NULL,
 CONSTRAINT [PKA_ConfigProvisiones] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Contrato_Cargos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contrato_Cargos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Contrato_Cargos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NOT NULL,
	[Cargo] [int] NOT NULL,
	[FechaInicio] [smalldatetime] NOT NULL,
	[FechaFin] [smalldatetime] NULL,
	[UsrRegistra] [varchar](20) NULL,
	[FechaRegistro] [smalldatetime] NULL,
	[TerminalRegistra] [varchar](50) NULL,
 CONSTRAINT [PKA_Contrato_Cargos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Contratos](
	[Sec] [int] NULL,
	[Oficina] [int] NULL,
	[CodContrato] [int] NOT NULL,
	[Empleado] [int] NULL,
	[TipoContrato] [int] NULL,
	[HorasMes] [int] NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[Dependencia] [int] NULL,
	[Aprendiz] [bit] NULL,
	[Terminado] [bit] NULL,
	[Plantilla] [int] NULL,
	[Nomina] [int] NULL,
	[CargoActual] [int] NULL,
	[Asignacion] [money] NULL,
	[IdContrato] [varchar](50) NULL,
	[ValorExento] [money] NULL,
	[AsignacionCargo] [varchar](1) NULL,
	[FechaLiquidacion] [date] NULL,
	[UsaAsginaCargo] [bit] NULL,
	[TipoTrabajador] [varchar](10) NULL,
	[SubTipoTrabajador] [varchar](10) NULL,
	[SalarioIntegral] [varchar](10) NULL,
	[PerfilCuentas] [int] NULL,
 CONSTRAINT [PKA_Contratos] PRIMARY KEY CLUSTERED 
(
	[CodContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Contratos_CentroCostos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contratos_CentroCostos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Contratos_CentroCostos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NULL,
	[CentroCosto] [int] NULL,
	[Porcentaje] [decimal](18, 1) NULL,
 CONSTRAINT [PKA_Contratos_CentroCostos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ContratosLiquidados]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContratosLiquidados]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContratosLiquidados](
	[Sec] [int] NOT NULL,
	[OfiNomina] [int] NOT NULL,
	[OfiRegistra] [int] NOT NULL,
	[UsuCrea] [varchar](20) NOT NULL,
	[UsuMod] [varchar](20) NULL,
	[FechaCrea] [datetime] NOT NULL,
	[FechaMod] [datetime] NULL,
	[TerminalCrea] [varchar](50) NOT NULL,
	[TerminalMod] [varchar](50) NULL,
	[FechaSys] [datetime] NOT NULL,
	[Estado] [varchar](10) NULL,
	[ParametrosB] [varchar](100) NULL,
	[Conceptos] [varchar](2000) NULL,
	[EsBorrador] [bit] NULL,
	[TipoContrato] [int] NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
 CONSTRAINT [PKA_ContratosLiquidados] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ContratosLiquidados_Conceptos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContratosLiquidados_Conceptos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContratosLiquidados_Conceptos](
	[Sec] [int] NOT NULL,
	[LiquidaContrato] [int] NULL,
	[Valor] [money] NULL,
	[Base] [money] NULL,
	[NomConcepto] [varchar](200) NULL,
	[SecConcepto] [int] NULL,
	[NomBase] [varchar](200) NULL,
	[SecConceptoP] [int] NULL,
	[SecConceptoP2] [int] NULL,
 CONSTRAINT [PKA_ContratosLiquidados_Conceptos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ContratosLiquidados_Contratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContratosLiquidados_Contratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContratosLiquidados_Contratos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NOT NULL,
	[NominaLiquida] [int] NOT NULL,
	[Total] [money] NOT NULL,
	[CargoActual] [int] NULL,
	[TotalIngresos] [money] NULL,
	[TotalDeducciones] [money] NULL,
	[TotalDescuentosNomina] [money] NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
	[EstadoCont] [varchar](50) NULL,
 CONSTRAINT [PKA_ContratosLiquidados_Contratos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ContratosLiquidados_Variables]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContratosLiquidados_Variables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContratosLiquidados_Variables](
	[Sec] [int] NOT NULL,
	[SecLiquidaContrato] [int] NULL,
	[Variable] [int] NULL,
	[Cantidad] [money] NULL,
 CONSTRAINT [PKA_ContratosLiquidados_Variables] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CT_CentroCostos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CT_CentroCostos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CT_CentroCostos](
	[Sec] [int] NOT NULL,
	[Nom_CentroCosto] [varchar](30) NOT NULL,
	[Responsable] [bigint] NOT NULL,
	[Estado] [varchar](1) NOT NULL,
	[LimitaUso] [bit] NULL,
	[FechaIniLimite] [datetime] NULL,
	[FechaFinLimite] [datetime] NULL,
 CONSTRAINT [PKA_CT_CentroCostos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CT_PlandeCuentas]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CT_PlandeCuentas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CT_PlandeCuentas](
	[CodCuenta] [varchar](10) NOT NULL,
	[NomCuenta] [varchar](100) NOT NULL,
	[NatCuenta] [bit] NOT NULL,
	[TerCuenta] [varchar](1) NOT NULL,
	[TipoRetefuente] [tinyint] NULL,
	[Detalla] [varchar](1) NOT NULL,
	[ManejaCC] [bit] NOT NULL,
	[SeAjusta] [varchar](1) NULL,
	[AjLlevaCuenta] [varchar](10) NULL,
	[AjContraCuenta] [varchar](10) NULL,
	[LlevaAOrden] [bit] NULL,
	[AjLlevaOrden] [varchar](10) NULL,
	[AjContraOrden] [varchar](10) NULL,
	[Estado] [varchar](1) NOT NULL,
	[EsdeAjustes] [bit] NULL,
	[EsdeMovimiento] [bit] NOT NULL,
	[PermiteSaldoCNat] [bit] NOT NULL,
	[PermiteMovtoCNat] [bit] NOT NULL,
	[Nivel] [tinyint] NOT NULL,
	[Corriente] [bit] NOT NULL,
	[Disponible] [bit] NOT NULL,
	[FechaMod] [datetime] NULL,
	[UsrMod] [varchar](10) NULL,
	[FechaGen] [datetime] NULL,
	[UsrGen] [varchar](10) NULL,
	[SecCuenta] [int] NULL,
	[EsdeAportes] [bit] NULL,
	[EsdeBancos] [bit] NULL,
	[EsdeAnticipos] [bit] NULL,
	[TerCierre] [bigint] NULL,
	[CierraTer] [bit] NULL,
	[CtrVehi] [bit] NULL,
	[ManejoNIIF] [tinyint] NOT NULL,
	[CodCtaNIIF] [varchar](10) NULL,
	[UtilizaCP] [bit] NULL,
	[TipoCP] [smallint] NULL,
	[CodFEDB] [smallint] NULL,
	[CodFECR] [smallint] NULL,
 CONSTRAINT [PK_CodCuenta] PRIMARY KEY CLUSTERED 
(
	[CodCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Dependencias]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dependencias]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Dependencias](
	[Sec] [int] NOT NULL,
	[NomDependencia] [varchar](100) NULL,
	[Vigente] [varchar](1) NULL,
 CONSTRAINT [PKA_Dependencias] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[DescripVarPer]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DescripVarPer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DescripVarPer](
	[Sec] [int] NOT NULL,
	[FechaHoraInicio] [datetime] NULL,
	[FechaHoraFin] [datetime] NULL,
	[Cantidad] [int] NULL,
	[CodVarP] [int] NOT NULL,
	[TipoDesc] [varchar](10) NULL,
	[NomTipo] [varchar](200) NULL,
 CONSTRAINT [PKA_DescripVarPer] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[DetallesVariablesGenerales]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DetallesVariablesGenerales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DetallesVariablesGenerales](
	[Sec] [int] NOT NULL,
	[Variable] [int] NULL,
	[Valor] [money] NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PKA_DetallesVariablesGenerales] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleados]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Empleados](
	[Sec] [int] NOT NULL,
	[TipoIdentificacion] [varchar](4) NOT NULL,
	[Identificacion] [bigint] NOT NULL,
	[Dv] [varchar](1) NULL,
	[PApellido] [varchar](50) NOT NULL,
	[SApellido] [varchar](50) NULL,
	[PNombre] [varchar](50) NULL,
	[SNombre] [varchar](50) NULL,
	[Genero] [varchar](1) NULL,
	[FechaNacimiento] [datetime] NULL,
	[MunicipioNacimiento] [varchar](6) NULL,
	[FechaExpDoc] [datetime] NULL,
	[LugarExpDoc] [varchar](6) NULL,
	[Direccion] [varchar](150) NULL,
	[Barrio] [varchar](50) NULL,
	[Municipio] [varchar](6) NULL,
	[Email1] [varchar](50) NULL,
	[Email2] [varchar](50) NULL,
	[Profesion] [int] NULL,
	[PersonasaCargo] [int] NULL,
	[EstadoCivil] [tinyint] NULL,
	[Tel1] [varchar](25) NULL,
	[Tel2] [varchar](25) NULL,
	[NumCelular] [varchar](25) NULL,
	[WebPage] [varchar](100) NULL,
	[LicConduccion] [varchar](50) NULL,
	[LicCategoria] [varchar](10) NULL,
	[ClaseLib] [int] NULL,
	[NumLib] [varchar](20) NULL,
	[DistritoLib] [varchar](20) NULL,
	[Comentario] [varchar](250) NULL,
	[ActividadEco] [varchar](6) NULL,
	[FechaIngreso] [datetime] NULL,
	[FechaGen] [datetime] NULL,
	[UsrGen] [varchar](20) NULL,
	[FechaMod] [datetime] NULL,
	[UsrMod] [varchar](20) NULL,
	[Pensionado] [bit] NULL,
	[codBanco] [int] NULL,
	[NumCuenta] [varchar](80) NULL,
	[TipoCuenta] [int] NULL,
	[Foto] [nvarchar](max) NULL,
 CONSTRAINT [PKA_Empleados] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Empleados_Educacion]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleados_Educacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Empleados_Educacion](
	[Sec] [int] NOT NULL,
	[Empleado] [int] NOT NULL,
	[NivelEstudio] [int] NOT NULL,
	[FechaGrado] [datetime] NOT NULL,
	[Duracion] [int] NOT NULL,
	[TipoTiempo] [int] NULL,
	[IdTituloObtenido] [int] NULL,
	[NombreInstitucion] [varchar](100) NULL,
	[MatriculaProfesional] [varchar](15) NULL,
	[LugarTitulo] [varchar](6) NULL,
 CONSTRAINT [PKA_Empleados_Educacion] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Empleados_HistoriaLaboral]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleados_HistoriaLaboral]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Empleados_HistoriaLaboral](
	[Sec] [int] NOT NULL,
	[Empleado] [int] NOT NULL,
	[Empresa] [varchar](100) NULL,
	[Cargo] [varchar](200) NULL,
	[FechaIngreso] [datetime] NULL,
	[FechaRetiro] [datetime] NULL,
	[TelEmpresa] [varchar](20) NULL,
	[Direccion] [varchar](50) NULL,
	[JefeInmediato] [varchar](50) NULL,
	[ImgDocumento] [image] NULL,
 CONSTRAINT [PKA_Empleados_HistoriaLaboral] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Empleados_RegFot]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleados_RegFot]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Empleados_RegFot](
	[Sec] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Item] [int] NOT NULL,
	[Tipo] [int] NOT NULL,
	[SecTipo] [int] NOT NULL,
	[Foto] [nvarchar](max) NULL,
	[Predeterminada] [bit] NULL,
	[Descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_Empleados_RegFot] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[EntesSSAP]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EntesSSAP]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EntesSSAP](
	[Sec] [int] NOT NULL,
	[TipoEnte] [int] NOT NULL,
	[Nit] [bigint] NULL,
	[NombreEntidad] [varchar](100) NULL,
	[Estado] [varchar](1) NOT NULL,
	[CuentaPasivo] [varchar](10) NOT NULL,
 CONSTRAINT [PKA_EntesSSAP] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC,
	[TipoEnte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[EntesTercero]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EntesTercero]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EntesTercero](
	[Sec] [int] NOT NULL,
	[Empleado] [int] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[FechaRetiro] [datetime] NULL,
	[Retirado] [bit] NOT NULL,
	[CausadeRetiro] [varchar](250) NULL,
	[SecEntesSSAP] [int] NULL,
 CONSTRAINT [PKA_EntesTercero] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Errores]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Errores]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Errores](
	[Errores] [nvarchar](max) NULL,
	[Procedimiento] [varchar](200) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Familiares]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Familiares]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Familiares](
	[Sec] [int] NOT NULL,
	[TipoIdentificacion] [varchar](4) NOT NULL,
	[Identificacion] [int] NOT NULL,
	[Nombre] [varchar](200) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Ocupacion] [varchar](50) NULL,
	[EmpresaWk] [varchar](50) NULL,
	[CargoActual] [varchar](50) NULL,
	[Telefonos] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Ciudad] [varchar](50) NOT NULL,
 CONSTRAINT [PKA_Familiares] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Funciones]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Funciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Funciones](
	[Sec] [int] NOT NULL,
	[DetalleFuncion] [varchar](1000) NULL,
 CONSTRAINT [PKA_Funciones] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[G_Departamento]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[G_Departamento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[G_Departamento](
	[Sec] [int] NOT NULL,
	[Pais] [int] NOT NULL,
	[NomDpto] [varchar](100) NOT NULL,
 CONSTRAINT [PKA_G_Departamento] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[G_Municipio]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[G_Municipio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[G_Municipio](
	[Sec] [int] NULL,
	[Departamento] [varchar](3) NOT NULL,
	[IdMunicipio] [varchar](6) NOT NULL,
	[NombreMunicipio] [varchar](50) NULL,
 CONSTRAINT [PKA_G_Municipio] PRIMARY KEY CLUSTERED 
(
	[IdMunicipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[G_Pais]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[G_Pais]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[G_Pais](
	[Sec] [int] NOT NULL,
	[NomPais] [varchar](100) NOT NULL,
	[CodIso] [varchar](3) NOT NULL,
 CONSTRAINT [PKA_G_Pais] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquida]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquida](
	[Sec] [int] NOT NULL,
	[Periodo] [int] NOT NULL,
	[EsBorrador] [bit] NOT NULL,
	[OfiNomina] [int] NOT NULL,
	[OfiRegistra] [int] NOT NULL,
	[UsuCrea] [varchar](20) NOT NULL,
	[UsuMod] [varchar](20) NULL,
	[FechaCrea] [datetime] NOT NULL,
	[FechaMod] [datetime] NULL,
	[TerminalCrea] [varchar](50) NOT NULL,
	[TerminalMod] [varchar](50) NULL,
	[FechaSys] [datetime] NOT NULL,
 CONSTRAINT [PKA_NominaLiquida] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaConceptos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaConceptos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaConceptos](
	[Sec] [int] NOT NULL,
	[LiquidaContrato] [int] NOT NULL,
	[Valor] [money] NOT NULL,
	[Base] [money] NOT NULL,
	[NomConcepto] [varchar](200) NOT NULL,
	[SecConcepto] [int] NULL,
	[NomBase] [varchar](200) NULL,
	[SecConceptoP] [int] NULL,
	[SecConceptoP2] [int] NULL,
	[Cuota] [int] NULL,
 CONSTRAINT [PKA_NominaLiquidaConceptos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaContratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaContratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaContratos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NOT NULL,
	[NominaLiquida] [int] NOT NULL,
	[Total] [money] NOT NULL,
	[HorasMes] [int] NULL,
	[CargoActual] [int] NULL,
	[Asignacion] [money] NULL,
	[TotalProvisiones] [money] NULL,
	[TotalFondos] [money] NULL,
	[TotalIngresos] [money] NULL,
	[TotalDeducciones] [money] NULL,
	[Comentario] [varchar](2000) NULL,
	[TotalDescuentosNomina] [money] NULL,
 CONSTRAINT [PKA_NominaLiquidaContratos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidada]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidada]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidada](
	[Sec] [int] NOT NULL,
	[Periodo] [int] NOT NULL,
	[OfiNomina] [int] NOT NULL,
	[OfiRegistra] [int] NOT NULL,
	[UsuCrea] [varchar](20) NOT NULL,
	[FechaCrea] [datetime] NOT NULL,
	[TerminalCrea] [varchar](50) NOT NULL,
	[FechaSys] [datetime] NOT NULL,
	[Estado] [varchar](10) NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
 CONSTRAINT [PKA_NominaLiquidada] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidadaConceptos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidadaConceptos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidadaConceptos](
	[Sec] [int] NOT NULL,
	[LiquidadaContrato] [int] NOT NULL,
	[Valor] [money] NOT NULL,
	[Base] [money] NOT NULL,
	[NomConcepto] [varchar](200) NOT NULL,
	[SecConcepto] [int] NULL,
	[NomBase] [varchar](200) NULL,
	[SecConceptoP] [int] NULL,
	[SecConceptoP2] [int] NULL,
	[Cuota] [int] NULL,
 CONSTRAINT [PKA_NominaLiquidadaConceptos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidadaContratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidadaContratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidadaContratos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NOT NULL,
	[NominaLiquidada] [int] NOT NULL,
	[Total] [money] NOT NULL,
	[HorasMes] [int] NULL,
	[CargoActual] [int] NULL,
	[Asignacion] [money] NULL,
	[TotalProvisiones] [money] NULL,
	[TotalFondos] [money] NULL,
	[TotalIngresos] [money] NULL,
	[TotalDeducciones] [money] NULL,
	[Comentario] [varchar](2000) NULL,
	[TotalDescuentosNomina] [money] NULL,
	[Cufe] [varchar](200) NULL,
	[Estado] [varchar](500) NULL,
	[DoceId] [varchar](200) NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
	[EstadoCont] [varchar](50) NULL,
 CONSTRAINT [PKA_NominaLiquidadaContratos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidadaVariables]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidadaVariables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidadaVariables](
	[Sec] [int] NOT NULL,
	[SecLiquidadaContrato] [int] NOT NULL,
	[Variable] [int] NOT NULL,
	[Cantidad] [money] NOT NULL,
 CONSTRAINT [PKA_NominaLiquidadaVariables] PRIMARY KEY CLUSTERED 
(
	[SecLiquidadaContrato] ASC,
	[Variable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaDescripVarPer]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaDescripVarPer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaDescripVarPer](
	[Sec] [int] NOT NULL,
	[FechaHoraInicio] [datetime] NULL,
	[FechaHoraFin] [datetime] NULL,
	[Cantidad] [int] NULL,
	[CodVarP] [int] NOT NULL,
	[TipoDesc] [varchar](10) NULL,
 CONSTRAINT [PKA_NominaLiquidaDescripVarPer] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaExtraordinaria]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaExtraordinaria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaExtraordinaria](
	[Sec] [int] NOT NULL,
	[OfiNomina] [int] NOT NULL,
	[OfiRegistra] [int] NOT NULL,
	[UsuCrea] [varchar](20) NOT NULL,
	[UsuMod] [varchar](20) NULL,
	[FechaCrea] [datetime] NOT NULL,
	[FechaMod] [datetime] NULL,
	[TerminalCrea] [varchar](50) NOT NULL,
	[TerminalMod] [varchar](50) NULL,
	[FechaSys] [datetime] NOT NULL,
	[Estado] [varchar](10) NULL,
	[ParametrosB] [varchar](100) NULL,
	[Conceptos] [varchar](2000) NULL,
	[EsBorrador] [bit] NULL,
	[Nomina] [int] NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
 CONSTRAINT [PKA_NominaLiquidaExtraordinaria] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaExtraordinariaConceptos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaExtraordinariaConceptos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaExtraordinariaConceptos](
	[Sec] [int] NOT NULL,
	[LiquidaContrato] [int] NOT NULL,
	[Valor] [money] NOT NULL,
	[Base] [money] NOT NULL,
	[NomConcepto] [varchar](200) NOT NULL,
	[SecConcepto] [int] NULL,
	[NomBase] [varchar](200) NULL,
	[SecConceptoP] [int] NULL,
	[SecConceptoP2] [int] NULL,
	[Cuota] [int] NULL,
 CONSTRAINT [PKA_NominaLiquidaExtraordinariaConceptos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaExtraordinariaContratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaExtraordinariaContratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaExtraordinariaContratos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NOT NULL,
	[NominaLiquidaExtraordinaria] [int] NOT NULL,
	[Total] [money] NOT NULL,
	[CargoActual] [int] NULL,
	[TotalIngresos] [money] NULL,
	[TotalDeducciones] [money] NULL,
	[TotalDescuentosNomina] [money] NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
	[EstadoCont] [varchar](50) NULL,
 CONSTRAINT [PKA_NominaLiquidaExtraordinariaContratos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaExtraordinariaVariables]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaExtraordinariaVariables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaExtraordinariaVariables](
	[Sec] [int] NOT NULL,
	[SecLiquidaContrato] [int] NOT NULL,
	[Variable] [int] NOT NULL,
	[Cantidad] [money] NOT NULL,
 CONSTRAINT [PKA_NominaLiquidaExtraordinariaVariables] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaSemestres]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaSemestres]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaSemestres](
	[Sec] [int] NOT NULL,
	[Semestre] [int] NOT NULL,
	[OfiNomina] [int] NOT NULL,
	[OfiRegistra] [int] NOT NULL,
	[UsuCrea] [varchar](20) NOT NULL,
	[UsuMod] [varchar](20) NULL,
	[FechaCrea] [datetime] NOT NULL,
	[FechaMod] [datetime] NULL,
	[TerminalCrea] [varchar](50) NOT NULL,
	[TerminalMod] [varchar](50) NULL,
	[FechaSys] [datetime] NOT NULL,
	[Estado] [varchar](10) NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
 CONSTRAINT [PKA_NominaLiquidaSemestres] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaSemestresConceptos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaSemestresConceptos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaSemestresConceptos](
	[Sec] [int] NOT NULL,
	[LiquidaContrato] [int] NOT NULL,
	[Valor] [money] NOT NULL,
	[Base] [money] NOT NULL,
	[NomConcepto] [varchar](200) NOT NULL,
	[SecConcepto] [int] NULL,
	[NomBase] [varchar](200) NULL,
	[SecConceptoP] [int] NULL,
	[SecConceptoP2] [int] NULL,
	[Cuota] [int] NULL,
 CONSTRAINT [PKA_NominaLiquidaSemestresConceptos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaSemestresContratos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaSemestresContratos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaSemestresContratos](
	[Sec] [int] NOT NULL,
	[Contrato] [int] NOT NULL,
	[NominaLiquidaSemestres] [int] NOT NULL,
	[Total] [money] NOT NULL,
	[CargoActual] [int] NULL,
	[TotalIngresos] [money] NULL,
	[TotalDeducciones] [money] NULL,
	[TotalDescuentosNomina] [money] NULL,
	[Contabilizada] [bit] NULL,
	[FormaDePago] [varchar](20) NULL,
	[DocContable] [varchar](50) NULL,
	[EstadoCont] [varchar](50) NULL,
 CONSTRAINT [PKA_NominaLiquidaSemestresContratos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaSemestresVariables]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaSemestresVariables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaSemestresVariables](
	[Sec] [int] NOT NULL,
	[SecLiquidaContrato] [int] NOT NULL,
	[Variable] [int] NOT NULL,
	[Cantidad] [money] NOT NULL,
 CONSTRAINT [PKA_NominaLiquidaSemestresVariables] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[NominaLiquidaVariables]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NominaLiquidaVariables]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NominaLiquidaVariables](
	[Sec] [int] NOT NULL,
	[SecLiquidaContrato] [int] NOT NULL,
	[Variable] [int] NOT NULL,
	[Cantidad] [money] NOT NULL,
 CONSTRAINT [PKA_NominaLiquidaVariables] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC,
	[SecLiquidaContrato] ASC,
	[Variable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Nominas]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nominas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Nominas](
	[Sec] [int] NOT NULL,
	[NomNomina] [varchar](50) NULL,
	[FormaLiquida] [int] NULL,
	[Fecha] [date] NULL,
	[Oficina] [int] NULL,
 CONSTRAINT [PKA_Nominas] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PerfilesCta]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PerfilesCta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PerfilesCta](
	[Sec] [int] NOT NULL,
	[NomPerfilCta] [varchar](50) NULL,
	[Vigente] [varchar](1) NULL,
	[FormaPago] [varchar](10) NULL,
	[MovsTercerosIngresos] [bit] NULL,
	[MovsTercerosProvisiones] [bit] NULL,
	[MovsTercerosDeducciones] [bit] NULL,
	[MovsEntidadesIngresos] [bit] NULL,
	[MovsEntidadesProvisiones] [bit] NULL,
	[MovsEntidadesDeducciones] [bit] NULL,
	[MovsEntSeguridadSIngresos] [bit] NULL,
	[MovsEntSeguridadSProvisiones] [bit] NULL,
	[MovsEntSeguridadSDeducciones] [bit] NULL,
	[MovsEntPrestSIngresos] [bit] NULL,
	[MovsEntPrestSProvisiones] [bit] NULL,
	[MovsEntPrestSDeducciones] [bit] NULL,
	[MovsEntAportesParaIngresos] [bit] NULL,
	[MovsEntAportesParaProvisiones] [bit] NULL,
	[MovsEntAportesParaDeducciones] [bit] NULL,
	[MovsEntNominaIngresos] [bit] NULL,
	[MovsEntNominaProvisiones] [bit] NULL,
	[MovsEntNominaDeducciones] [bit] NULL,
 CONSTRAINT [PKA_PerfilesCta] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PeriodosLiquidacion]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PeriodosLiquidacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PeriodosLiquidacion](
	[Sec] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
	[Estado] [varchar](1) NULL,
	[Nomina] [int] NULL,
	[Año] [int] NULL,
	[PeriodoMes] [int] NULL,
	[NumPeriodoNom] [int] NULL,
	[CodPeriodo] [int] NULL,
	[NumMes] [int] NULL,
	[Semestre] [int] NULL,
 CONSTRAINT [PKA_PeriodosLiquidacion] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PlantadeCargos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlantadeCargos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PlantadeCargos](
	[Sec] [int] NOT NULL,
	[Oficina] [int] NOT NULL,
	[Cargo] [int] NOT NULL,
	[NumCargos] [int] NOT NULL,
 CONSTRAINT [PKA_PlantadeCargos] PRIMARY KEY CLUSTERED 
(
	[Oficina] ASC,
	[Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Plantillas]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Plantillas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Plantillas](
	[Sec] [int] NOT NULL,
	[NomPlantilla] [varchar](50) NULL,
	[Vigente] [varchar](1) NULL,
	[ValorMaxDescontar] [varchar](2000) NULL,
 CONSTRAINT [PKA_Plantillas] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[RelFami]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelFami]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RelFami](
	[Sec] [int] NOT NULL,
	[empleado] [int] NOT NULL,
	[familiar] [int] NOT NULL,
	[parentesco] [tinyint] NULL,
 CONSTRAINT [PKA_RelFami] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC,
	[empleado] ASC,
	[familiar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[SemestresLiquidacion]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SemestresLiquidacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SemestresLiquidacion](
	[Sec] [int] NOT NULL,
	[Semestre] [int] NULL,
	[Año] [int] NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
	[Estado] [varchar](1) NULL,
	[Nomina] [int] NULL,
 CONSTRAINT [PKA_SemestresLiquidacion] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[TiposConceptosNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosNomina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TiposConceptosNomina](
	[Sec] [int] NOT NULL,
	[NomTipo] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
 CONSTRAINT [PKA_TiposConceptosNomina] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[TiposContratos_ConceptosNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposContratos_ConceptosNomina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TiposContratos_ConceptosNomina](
	[Sec] [int] NOT NULL,
	[Concepto] [int] NULL,
	[TipoContrato] [int] NULL,
	[Formula] [varchar](2000) NULL,
	[BaseCalculo] [varchar](200) NULL,
	[SeLiquida] [bit] NULL,
	[CuentaContable] [varchar](20) NULL,
 CONSTRAINT [PKA_TiposContratos_ConceptosNomina] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ValoresExentos]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValoresExentos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ValoresExentos](
	[Sec] [int] NOT NULL,
	[Nom] [varchar](200) NULL,
	[Vigente] [bit] NULL,
	[TipoValor] [char](1) NULL,
 CONSTRAINT [PKA_ValoresExentos] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[VariablesGenerales]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VariablesGenerales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VariablesGenerales](
	[Sec] [int] NOT NULL,
	[NomVariable] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
	[Descripcion] [varchar](200) NULL,
	[EsPredeterminado] [bit] NULL,
	[CodDian] [varchar](20) NULL,
 CONSTRAINT [PKA_VariablesGenerales] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[VariablesPersonales]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VariablesPersonales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VariablesPersonales](
	[Sec] [int] NOT NULL,
	[NomVariable] [varchar](200) NULL,
	[Vigente] [varchar](1) NULL,
	[ValorMaximo] [money] NULL,
	[ValorDefecto] [money] NULL,
	[EsPredeterminado] [bit] NULL,
	[CodDian] [varchar](20) NULL,
 CONSTRAINT [PKA_VariablesPersonales] PRIMARY KEY CLUSTERED 
(
	[Sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ZenumTipoEntes]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ZenumTipoEntes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ZenumTipoEntes](
	[Sec] [int] NULL,
	[CodTipoEnte] [int] NOT NULL,
	[NomTipoEnte] [varchar](50) NOT NULL,
 CONSTRAINT [PKA_ZenumTipoEntes] PRIMARY KEY CLUSTERED 
(
	[CodTipoEnte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[DynamicUpsertJson]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DynamicUpsertJson]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DynamicUpsertJson] AS' 
END
GO
ALTER   PROCEDURE [dbo].[DynamicUpsertJson]
    @json NVARCHAR(MAX),
    @tabla NVARCHAR(128),
    @modoEstricto BIT = 0,
    @procesarPorLotes BIT = 1,
    @tamanoLote INT = 100,
    @timeoutSeconds INT = 300,
    @maxReintentos INT = 3,
    @registrarLog BIT = 0
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DEADLOCK_PRIORITY LOW;
    
    -- Variables de control
    DECLARE @RequestID UNIQUEIDENTIFIER = NEWID();
    DECLARE @StartTime DATETIME2 = SYSUTCDATETIME();
    DECLARE @ProcessedCount INT = 0;
    DECLARE @TableName NVARCHAR(128);
    DECLARE @SQL NVARCHAR(MAX);
    DECLARE @ParmDefinition NVARCHAR(MAX);
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
    DECLARE @ErrorNumber INT;
    DECLARE @intentos INT = 0;
    DECLARE @ExternalTran BIT = (CASE WHEN @@TRANCOUNT > 0 THEN 1 ELSE 0 END);
    DECLARE @filasjson AS VARCHAR(MAX);
    DECLARE @filasnew AS VARCHAR(MAX);
    DECLARE @filasErrors AS VARCHAR(MAX);
    DECLARE @filasExisting AS VARCHAR(MAX);
    DECLARE @columnas AS VARCHAR(MAX);
    SET DATEFORMAT DMY;

    -- Configurar timeout para bloqueos con protección contra desbordamiento
    DECLARE @LockTimeoutMs INT;
    IF @timeoutSeconds <= 214 -- Máximo seguro para evitar desbordamiento
        SET @LockTimeoutMs = @timeoutSeconds * 1000;
    ELSE
        SET @LockTimeoutMs = 214748364; -- Valor máximo permitido

    SET @SQL = N'SET LOCK_TIMEOUT ' + CAST(@LockTimeoutMs AS VARCHAR(20));
    EXEC sp_executesql @SQL;
    
    -- Validación y ajuste de parámetros
    SET @tamanoLote = CASE 
        WHEN @tamanoLote < 10 THEN 10
        WHEN @tamanoLote > 5000 THEN 5000
        ELSE @tamanoLote
    END;
    
    SET @timeoutSeconds = CASE WHEN @timeoutSeconds <= 0 THEN 300 ELSE @timeoutSeconds END;
    SET @maxReintentos = CASE WHEN @maxReintentos <= 0 THEN 3 ELSE @maxReintentos END;
    
    -- Tabla para errores
    CREATE TABLE #Errors (
        ErrorId INT IDENTITY(1,1),
        RowId INT, 
        ErrorCode INT, 
        Field NVARCHAR(128), 
        ErrorMessage NVARCHAR(MAX),
        JsonData NVARCHAR(MAX)
    );
    
    -- Índice para mejorar rendimiento en validaciones
    CREATE NONCLUSTERED INDEX IX_Errors_RowId ON #Errors(RowId);
    
    -- Tabla para resultados
    CREATE TABLE #Results (
        ResultId INT IDENTITY(1,1),
        RowId INT, 
        Operation NVARCHAR(10), 
        Success BIT, 
        Sec INT,
        RequestTimeUTC DATETIME2,
        Data NVARCHAR(MAX)
    );
    
    -- Validar JSON y tabla usando funciones y parámetros para evitar inyección SQL
    IF @json IS NULL OR LEN(@json) = 0 
    BEGIN
        INSERT INTO #Errors(RowId, ErrorCode, Field, ErrorMessage)
        VALUES(NULL, 1000, NULL, 'JSON vacío o NULL');
        GOTO ReturnResults;
    END
    
    IF ISJSON(@json) = 0
    BEGIN
        INSERT INTO #Errors(RowId, ErrorCode, Field, ErrorMessage)
        VALUES(NULL, 1001, NULL, 'Formato JSON inválido');
        GOTO ReturnResults;
    END
    
    -- Validación de seguridad para el nombre de tabla
    IF @tabla IS NULL OR LEN(@tabla) = 0 
       OR PATINDEX('%[^a-zA-Z0-9_]%', @tabla COLLATE DATABASE_DEFAULT) > 0 
       OR EXISTS (
          SELECT 1 FROM sys.objects 
          WHERE name = @tabla COLLATE DATABASE_DEFAULT AND type IN ('S', 'IT', 'SQ', 'U')
            AND SCHEMA_NAME(schema_id) NOT IN ('dbo', 'app')
       )
    BEGIN
        INSERT INTO #Errors(RowId, ErrorCode, Field, ErrorMessage)
        VALUES(NULL, 1002, NULL, 'Nombre de tabla inválido o no permitido');
        GOTO ReturnResults;
    END
    
    -- Usar sp_executesql para proteger contra inyección SQL
    SET @TableName = QUOTENAME(@tabla);
    
    -- Verificar existencia de tabla
    SET @SQL = N'SELECT @ExistsOut = CASE WHEN OBJECT_ID(@TableParam) IS NULL THEN 0 ELSE 1 END';
    DECLARE @TableExists BIT;
    EXEC sp_executesql @SQL, 
         N'@TableParam NVARCHAR(128), @ExistsOut BIT OUTPUT', 
         @tabla, @TableExists OUTPUT;
         
    IF @TableExists = 0
    BEGIN
        INSERT INTO #Errors(RowId, ErrorCode, Field, ErrorMessage)
        VALUES(NULL, 1003, NULL, 'La tabla especificada no existe');
        GOTO ReturnResults;
    END
    
    -- Verificar estructura de tabla requerida
    BEGIN TRY
        DECLARE @RequeridosCheck TABLE (ColumnCount INT, RequiredCount INT);
        
        SET @SQL = N'
        SELECT COUNT(*) AS ColumnCount,
               SUM(CASE WHEN c.name IN (''Sec'') THEN 1 ELSE 0 END) AS RequiredCount
        FROM sys.columns c
        WHERE c.object_id = OBJECT_ID(@tabla)';
        
        SET @ParmDefinition = N'@tabla NVARCHAR(128)';
        
        INSERT INTO @RequeridosCheck
        EXEC sp_executesql @SQL, @ParmDefinition, @tabla;
        
        IF NOT EXISTS (SELECT 1 FROM @RequeridosCheck WHERE RequiredCount = 1)
        BEGIN
            INSERT INTO #Errors(RowId, ErrorCode, Field, ErrorMessage)
            VALUES(NULL, 1004, NULL, 'La tabla debe tener la columna Sec');
            GOTO ReturnResults;
        END
    END TRY
    BEGIN CATCH
        INSERT INTO #Errors(RowId, ErrorCode, Field, ErrorMessage)
        VALUES(NULL, 1005, NULL, 'Error al verificar estructura: ' + ERROR_MESSAGE());
        GOTO ReturnResults;
    END CATCH
    
    -- 1. Crear la tabla #Columns con todos los campos necesarios
    CREATE TABLE #Columns (
        ColumnId INT IDENTITY(1,1),
        ColumnName SYSNAME,
        DataType SYSNAME,
        IsNullable BIT,
        MaxLength INT,
        Precision INT,
        Scale INT,
        DefaultValue NVARCHAR(MAX),
        TypeCategory VARCHAR(20),
        IsIdentity BIT,
        IsComputed BIT, 
        IsPrimaryKey BIT, 
        ColumnNameUpper SYSNAME NULL
    );

    -- 2. Ejecutar el INSERT inicial
    SET @SQL = N'
    INSERT INTO #Columns (ColumnName, DataType, IsNullable, MaxLength, Precision, Scale, DefaultValue, IsIdentity, IsComputed, IsPrimaryKey)
    SELECT 
        c.name,
        t.name,
        c.is_nullable,
        c.max_length,
        c.precision,
        c.scale,
        ISNULL(dc.definition, N''''),
        c.is_identity,
        c.is_computed,
        CASE WHEN i.is_primary_key = 1 THEN 1 ELSE 0 END
    FROM sys.columns c
    JOIN sys.types t ON c.user_type_id = t.user_type_id
    LEFT JOIN sys.default_constraints dc ON c.default_object_id = dc.object_id
    LEFT JOIN sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
    LEFT JOIN sys.indexes i ON i.object_id = ic.object_id AND i.index_id = ic.index_id
    WHERE c.object_id = OBJECT_ID(@tabla)';

    EXEC sp_executesql @SQL, N'@tabla NVARCHAR(128)', @tabla;

    WITH cteDuplicados AS (
        SELECT 
            ColumnId,
            ColumnName,
            ROW_NUMBER() OVER (PARTITION BY ColumnName ORDER BY ColumnId) AS rn
        FROM #Columns
    )
    DELETE FROM cteDuplicados
    WHERE rn > 1;
    
    SET @columnas = (SELECT * FROM #Columns FOR JSON PATH);

    -- 3. Actualizar ColumnNameUpper inmediatamente después
    UPDATE #Columns
    SET ColumnNameUpper = UPPER(ColumnName);
        
    -- Categorizar tipos para optimizar validación
    UPDATE #Columns
    SET TypeCategory = 
        CASE 
            WHEN DataType = 'bit' THEN 'BOOLEAN'
            WHEN DataType IN ('tinyint', 'smallint', 'int', 'bigint') THEN 'INTEGER'
            WHEN DataType IN ('decimal', 'numeric', 'money', 'smallmoney', 'float', 'real') THEN 'DECIMAL'
            WHEN DataType = 'date' THEN 'DATE'
            WHEN DataType IN ('datetime', 'datetime2', 'smalldatetime', 'datetimeoffset') THEN 'DATETIME'
            WHEN DataType IN ('char', 'varchar', 'nchar', 'nvarchar', 'text', 'ntext') THEN 'STRING'
            WHEN DataType IN ('uniqueidentifier') THEN 'GUID'
            ELSE 'OTHER'
        END;
        
    CREATE NONCLUSTERED INDEX IX_Columns_Name ON #Columns(ColumnName);
    CREATE NONCLUSTERED INDEX IX_Columns_NameUpper ON #Columns(ColumnNameUpper);

    SET @columnas = (SELECT * FROM #Columns FOR JSON PATH);
        
    -- Procesar datos JSON en tabla temporal
    CREATE TABLE #JsonTable (
        RowId INT IDENTITY(1,1), 
        JsonData NVARCHAR(MAX),
        Sec INT NULL,
        IsValid BIT DEFAULT 1
    );
        
    CREATE NONCLUSTERED INDEX IX_JsonTable_RowId ON #JsonTable(RowId);
    CREATE NONCLUSTERED INDEX IX_JsonTable_Keys ON #JsonTable(Sec) WHERE IsValid = 1;
        
    -- Verificar si es un array o un objeto único
    DECLARE @IsArray BIT = 1;
    IF LEFT(LTRIM(@json), 1) = '{' SET @IsArray = 0;
        
    -- Insertar JSON en tabla temporal manteniendo sensibilidad a mayúsculas/minúsculas
    IF @IsArray = 1
    BEGIN
        INSERT INTO #JsonTable (JsonData, Sec)
        SELECT 
            value,
            TRY_CAST(JSON_VALUE(value, '$.Sec') AS INT)
        FROM OPENJSON(@json);
    END
    ELSE
    BEGIN
        INSERT INTO #JsonTable (JsonData, Sec)
        VALUES(
            @json,
            TRY_CAST(JSON_VALUE(@json, '$.Sec') AS INT)
        );
    END
        
    -- Validar campos clave
    UPDATE #JsonTable 
    SET IsValid = 0
    WHERE Sec IS NULL;
        
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        RowId, 
        1006, 
        'Sec',
        'Campo Sec es obligatorio y debe ser numérico', 
        JsonData
    FROM #JsonTable
    WHERE IsValid = 0;
        
    -- Verificar si hay valores duplicados en el JSON de entrada (mismo Sec, excepto cuando es 0)
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        j1.RowId,
        1007,
        'Sec',
        'Registro duplicado en el JSON de entrada: Sec=' + CAST(j1.Sec AS VARCHAR),
        j1.JsonData
    FROM #JsonTable j1
    INNER JOIN (
        SELECT Sec, MIN(RowId) AS FirstRowId, COUNT(*) AS DuplicateCount
        FROM #JsonTable
        WHERE IsValid = 1
        AND Sec <> 0 -- No considerar duplicados los Sec = 0 (inserciones nuevas)
        GROUP BY Sec
        HAVING COUNT(*) > 1
    ) j2 ON j1.Sec = j2.Sec AND j1.RowId > j2.FirstRowId;
        
    -- Clasificar registros
    CREATE TABLE #Existing (RowId INT, Sec INT);
    CREATE NONCLUSTERED INDEX IX_Existing_RowId ON #Existing(RowId);
    CREATE NONCLUSTERED INDEX IX_Existing_Keys ON #Existing(Sec);
        
    CREATE TABLE #New (RowId INT PRIMARY KEY);
        
    -- Usar READ COMMITTED para compatibilidad con entornos de alta disponibilidad
    SET @SQL = N'
    INSERT INTO #Existing (RowId, Sec)
    SELECT jt.RowId, jt.Sec
    FROM #JsonTable jt
    INNER JOIN ' + @TableName + ' t WITH (READCOMMITTED)
    ON t.Sec = jt.Sec
    WHERE jt.IsValid = 1
    AND jt.Sec <> 0
    AND jt.RowId NOT IN (SELECT RowId FROM #Errors)';
        
    BEGIN TRY
        EXEC sp_executesql @SQL;
    END TRY
    BEGIN CATCH
        INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
        VALUES (NULL, 1008, NULL, 'Error verificando registros existentes: ' + ERROR_MESSAGE(), NULL);
        GOTO ReturnResults;
    END CATCH
        
    -- Identificar registros nuevos
    SET @filasjson = (SELECT * FROM #JsonTable FOR JSON PATH);
    INSERT INTO #New (RowId)
    SELECT RowId FROM #JsonTable
    WHERE IsValid = 1
      AND RowId NOT IN (SELECT RowId FROM #Errors)
      AND RowId NOT IN (SELECT RowId FROM #Existing);

    SET @filasnew = (SELECT * FROM #New FOR JSON PATH);
    SET @filasErrors = (SELECT * FROM #Errors FOR JSON PATH);
    SET @filasExisting = (SELECT * FROM #Existing FOR JSON PATH);
        
    -- Validar campos requeridos para registros nuevos
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        jt.RowId, 1009, c.ColumnName,
        'Campo requerido ausente: ' + c.ColumnName, jt.JsonData
    FROM #JsonTable jt
    CROSS JOIN (
        SELECT ColumnName, ColumnNameUpper
        FROM #Columns 
        WHERE IsNullable = 0 
          AND DefaultValue = ''
          AND ColumnName NOT IN ('Sec')
          AND IsIdentity = 0
          AND IsComputed = 0
    ) c
    WHERE jt.RowId IN (SELECT RowId FROM #New)
      AND jt.IsValid = 1
      AND NOT EXISTS (
          SELECT 1 
          FROM OPENJSON(jt.JsonData)
          WHERE UPPER([key]) COLLATE DATABASE_DEFAULT = c.ColumnNameUpper COLLATE DATABASE_DEFAULT
            AND [value] IS NOT NULL
            AND [value] <> 'null'
            AND [value] <> ''
      );
        
    -- Validaciones de tipo y rango - corregidas para case-insensitive
    -- Numéricos
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        jt.RowId, 1010, j.[key],
        'Valor numérico inválido: ' + ISNULL(j.[value], 'NULL'), jt.JsonData
    FROM #JsonTable jt
    CROSS APPLY OPENJSON(jt.JsonData) j
    JOIN #Columns c ON UPPER(j.[key]) COLLATE DATABASE_DEFAULT = c.ColumnNameUpper COLLATE DATABASE_DEFAULT
    WHERE jt.IsValid = 1
      AND jt.RowId NOT IN (SELECT RowId FROM #Errors)
      AND c.TypeCategory IN ('INTEGER', 'DECIMAL')
      AND j.[value] IS NOT NULL
      AND j.[value] NOT IN ('null', '')
      AND TRY_CAST(j.[value] AS FLOAT) IS NULL;
        
    -- Validación de rango para tipos específicos
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        jt.RowId, 1011, j.[key],
        'Valor fuera de rango permitido para ' + c.DataType + ': ' + j.[value], jt.JsonData
    FROM #JsonTable jt
    CROSS APPLY OPENJSON(jt.JsonData) j
    JOIN #Columns c ON UPPER(j.[key]) COLLATE DATABASE_DEFAULT = c.ColumnNameUpper COLLATE DATABASE_DEFAULT
    WHERE jt.IsValid = 1
      AND jt.RowId NOT IN (SELECT RowId FROM #Errors)
      AND c.TypeCategory = 'INTEGER'
      AND j.[value] IS NOT NULL
      AND j.[value] NOT IN ('null', '')
      AND TRY_CAST(j.[value] AS FLOAT) IS NOT NULL
      AND (
          (c.DataType = 'tinyint' AND (TRY_CAST(j.[value] AS FLOAT) < 0 OR TRY_CAST(j.[value] AS FLOAT) > 255)) OR
          (c.DataType = 'smallint' AND (TRY_CAST(j.[value] AS FLOAT) < -32768 OR TRY_CAST(j.[value] AS FLOAT) > 32767)) OR
          (c.DataType = 'int' AND (TRY_CAST(j.[value] AS FLOAT) < -2147483648 OR TRY_CAST(j.[value] AS FLOAT) > 2147483647))
      );
        
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        jt.RowId, 1012, j.[key],
        'Valor decimal fuera de rango: ' + j.[value], jt.JsonData
    FROM #JsonTable jt
    CROSS APPLY OPENJSON(jt.JsonData) j
    JOIN #Columns c ON UPPER(j.[key]) COLLATE DATABASE_DEFAULT = c.ColumnNameUpper COLLATE DATABASE_DEFAULT
    WHERE jt.IsValid = 1
      AND jt.RowId NOT IN (SELECT RowId FROM #Errors)
      AND c.TypeCategory = 'DECIMAL'
      AND j.[value] IS NOT NULL
      AND j.[value] NOT IN ('null', '')
      AND TRY_CAST(j.[value] AS FLOAT) IS NOT NULL
      AND c.Precision > 0
      AND (
          (c.Precision - c.Scale <= 9 AND ABS(CAST(j.[value] AS FLOAT)) > POWER(CONVERT(FLOAT, 10), c.Precision - c.Scale))
          OR
          (c.Precision - c.Scale > 9 AND ABS(CAST(j.[value] AS FLOAT)) > 1000000000)
      );
        
    -- Fechas
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        jt.RowId, 1013, j.[key],
        'Formato de fecha inválido: ' + ISNULL(j.[value], 'NULL'), jt.JsonData
    FROM #JsonTable jt
    CROSS APPLY OPENJSON(jt.JsonData) j
    JOIN #Columns c ON UPPER(j.[key]) COLLATE DATABASE_DEFAULT = c.ColumnNameUpper COLLATE DATABASE_DEFAULT
    WHERE jt.IsValid = 1
      AND jt.RowId NOT IN (SELECT RowId FROM #Errors)
      AND c.TypeCategory = 'DATETIME'
      AND j.[value] IS NOT NULL
      AND j.[value] NOT IN ('null', '')
      AND TRY_CONVERT(DATETIME2, j.[value]) IS NULL;
        
    -- Valores booleanos
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        jt.RowId, 1014, j.[key],
        'Valor booleano inválido: ' + ISNULL(j.[value], 'NULL'), jt.JsonData
    FROM #JsonTable jt
    CROSS APPLY OPENJSON(jt.JsonData) j
    JOIN #Columns c ON UPPER(j.[key]) COLLATE DATABASE_DEFAULT = c.ColumnNameUpper COLLATE DATABASE_DEFAULT
    WHERE jt.IsValid = 1
      AND jt.RowId NOT IN (SELECT RowId FROM #Errors)
      AND c.TypeCategory = 'BOOLEAN'
      AND j.[value] IS NOT NULL
      AND j.[value] NOT IN ('null', '')
      AND LOWER(j.[value]) NOT IN ('0', '1', 'true', 'false');
        
    -- Longitud de texto - Corrección para nchar/nvarchar
    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
    SELECT 
        jt.RowId, 1015, j.[key],
        'Texto excede longitud (' + CAST(CASE WHEN c.DataType IN ('nchar', 'nvarchar') THEN c.MaxLength / 2 ELSE c.MaxLength END AS VARCHAR) + '): ' + 
        LEFT(j.[value], 30) + CASE WHEN LEN(j.[value]) > 30 THEN '...' ELSE '' END, 
        jt.JsonData
    FROM #JsonTable jt
    CROSS APPLY OPENJSON(jt.JsonData) j
    JOIN #Columns c ON UPPER(j.[key]) COLLATE DATABASE_DEFAULT = c.ColumnNameUpper COLLATE DATABASE_DEFAULT
    WHERE jt.IsValid = 1
      AND jt.RowId NOT IN (SELECT RowId FROM #Errors)
      AND c.TypeCategory = 'STRING'
      AND c.MaxLength > 0 AND c.MaxLength != -1
      AND j.[value] IS NOT NULL
      AND j.[value] NOT IN ('null', '')
      AND (
          (c.DataType IN ('nchar', 'nvarchar') AND LEN(j.[value]) > c.MaxLength / 2) OR
          (c.DataType IN ('char', 'varchar') AND LEN(j.[value]) > c.MaxLength)
      );
        
    -- Si hay errores en modo estricto, detener
    IF @modoEstricto = 1 AND EXISTS (SELECT 1 FROM #Errors)
    BEGIN
	insert into Errores (Errores,Procedimiento) values ((select * from #Errors for json path),'InsertDinamico')
        GOTO ReturnResults;
    END
        
    SET @filasnew = (SELECT * FROM #New FOR JSON PATH);
    SET @filasErrors = (SELECT * FROM #Errors FOR JSON PATH);
    SET @filasExisting = (SELECT * FROM #Existing FOR JSON PATH);

    -- PROCESAR ACTUALIZACIONES
    IF EXISTS (SELECT 1 FROM #Existing WHERE RowId NOT IN (SELECT RowId FROM #Errors UNION SELECT RowId FROM #Results))
    BEGIN        
        WHILE EXISTS (
            SELECT 1 FROM #Existing e
            WHERE e.RowId NOT IN (SELECT RowId FROM #Errors UNION SELECT RowId FROM #Results)
        )
        BEGIN                                
            SET @intentos = 0;
            
            WHILE @intentos < @maxReintentos
            BEGIN
                BEGIN TRY
                    
                    CREATE TABLE #UpdatedRows (
                        Sec INT, 
                        RowId INT
                    );
                    
                    -- Construir update más seguros - procesando columnas en bloques para evitar desbordamiento
                    DECLARE @UpdateColumns NVARCHAR(MAX) = N'';
                    DECLARE @ColumnsSql NVARCHAR(MAX);
                    DECLARE @CurrentColumnCount INT = 0;
                    DECLARE @MaxColumnsPerBatch INT = 50; -- Ajustar según la complejidad de columnas
                    
                    -- Procesar columnas en lotes para prevenir desbordamiento de SQL
                    DECLARE @ColumnToProcess TABLE (
                        Id INT IDENTITY(1,1),
                        ColumnName SYSNAME,
                        DataType SYSNAME,
                        TypeCategory VARCHAR(20),
                        Precision INT,
                        Scale INT,
                        IsNullable BIT,
                        DefaultValue NVARCHAR(MAX)
                    );

                    -- Tabla para rastrear columnas ya procesadas
                    DECLARE @ProcessedColumns TABLE (
                        ColumnName SYSNAME PRIMARY KEY
                    );

                    -- Variables necesarias para el procesamiento
                    DECLARE @TotalColumns INT;
                    DECLARE @CurrentIndex INT;

                    -- Reutilizar la tabla @ColumnToProcess ya existente
                    DELETE FROM @ColumnToProcess;
                    INSERT INTO @ColumnToProcess (ColumnName, DataType, TypeCategory, Precision, Scale, IsNullable, DefaultValue)
                    SELECT ColumnName, DataType, TypeCategory, Precision, Scale, IsNullable, DefaultValue
                    FROM #Columns
                    WHERE ColumnName NOT IN ('Sec', 'FechaActualizacion')
                      AND IsIdentity = 0
                      AND IsComputed = 0
                    ORDER BY ColumnId;

                    -- Inicializar variables
                    SET @TotalColumns = (SELECT COUNT(*) FROM @ColumnToProcess);
                    SET @CurrentIndex = 1;
                    SET @UpdateColumns = N'';

                    WHILE @CurrentIndex <= @TotalColumns
                    BEGIN
                        SET @ColumnsSql = N'';
                        
                        -- Procesar columnas no duplicadas
                        SELECT @ColumnsSql = @ColumnsSql + 
                            CASE 
                                WHEN EXISTS (SELECT 1 FROM @ProcessedColumns WHERE ColumnName = cp.ColumnName) 
                                THEN N'' -- Omitir columna ya procesada
                                ELSE 
                                    N', ' + QUOTENAME(cp.ColumnName) + N' = CASE 
                                        WHEN JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + N''') IS NULL THEN t.' + QUOTENAME(cp.ColumnName) + N'
                                        ELSE ' + 
                                            CASE 
                                                WHEN cp.TypeCategory = 'BOOLEAN' THEN 
                                                    'CASE WHEN LOWER(LTRIM(RTRIM(JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + N''')))) IN (''1'', ''true'') THEN 1 ' +
                                                    'WHEN LOWER(LTRIM(RTRIM(JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + N''')))) IN (''0'', ''false'') THEN 0 ' +
                                                    'ELSE t.' + QUOTENAME(cp.ColumnName) + ' END'
                                                WHEN cp.TypeCategory = 'INTEGER' THEN 
                                                    'TRY_CAST(JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + ''') AS ' + cp.DataType + ')'
                                                WHEN cp.TypeCategory = 'DECIMAL' THEN 
                                                    'CAST(JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + ''') AS ' + 
                                                    cp.DataType + ')'
                                                WHEN cp.TypeCategory = 'DATE' THEN 
                                                    'TRY_CONVERT(DATE, JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + '''), 126)'
                                                WHEN cp.TypeCategory = 'DATETIME' THEN 
                                                    'TRY_CONVERT(DATETIME, JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + '''), 126)'
                                                WHEN cp.TypeCategory = 'STRING' THEN 
                                                    'JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + ''')'
                                                WHEN cp.TypeCategory = 'GUID' THEN 
                                                    'TRY_CONVERT(UNIQUEIDENTIFIER, JSON_VALUE(jt.JsonData, ''$.' + QUOTENAME(cp.ColumnName, '"') + '''))'
                                                ELSE 
                                                    't.' + QUOTENAME(cp.ColumnName)
                                            END + N'
                                    END'
                            END
                        FROM @ColumnToProcess cp
                        WHERE Id BETWEEN @CurrentIndex AND @CurrentIndex + @MaxColumnsPerBatch - 1;
                        
                        -- Registrar columnas procesadas
                        INSERT INTO @ProcessedColumns (ColumnName)
                        SELECT ColumnName FROM @ColumnToProcess cp
                        WHERE Id BETWEEN @CurrentIndex AND @CurrentIndex + @MaxColumnsPerBatch - 1
                          AND NOT EXISTS (SELECT 1 FROM @ProcessedColumns WHERE ColumnName = cp.ColumnName);
                        
                        -- Acumular SQL
                        SET @UpdateColumns = @UpdateColumns + @ColumnsSql;
                        SET @CurrentIndex = @CurrentIndex + @MaxColumnsPerBatch;
                    END

                    IF LEN(@UpdateColumns) > 0
                    BEGIN
                        -- Si comienza con coma, quitarla
                        IF LEFT(@UpdateColumns, 1) = ',' 
                            SET @UpdateColumns = SUBSTRING(@UpdateColumns, 2, LEN(@UpdateColumns) - 1);
                            
                        -- Si termina con coma, quitarla
                        IF RIGHT(@UpdateColumns, 1) = ','
                            SET @UpdateColumns = SUBSTRING(@UpdateColumns, 1, LEN(@UpdateColumns) - 1);
                            
                        -- Si está vacío después de las correcciones, no hay nada que actualizar
                        IF LEN(@UpdateColumns) = 0
                            SET @SQL = N'UPDATE t SET Sec = Sec;'; -- Actualización dummy
                        ELSE
                            SET @SQL = N'UPDATE t SET ' + @UpdateColumns + N';';
                    END
                    ELSE
                        SET @SQL = N'UPDATE t SET Sec = Sec;'; -- Actualización dummy

                    -- Construir y ejecutar UPDATE
                    SET @SQL = N'
                    UPDATE t SET ' + @UpdateColumns + N'
                    OUTPUT inserted.Sec, be.RowId INTO #UpdatedRows
                    FROM ' + @TableName + N' t
                    INNER JOIN #Existing be ON t.Sec = be.Sec
                    INNER JOIN #JsonTable jt ON be.RowId = jt.RowId
                    WHERE jt.RowId NOT IN (SELECT RowId FROM #Errors UNION SELECT RowId FROM #Results)';
                    
                    EXEC sp_executesql @SQL;
                    
                    INSERT INTO #Results (RowId, Operation, Success, Sec, RequestTimeUTC, Data)
                    SELECT ur.RowId, 'UPDATE', 1, ur.Sec, SYSUTCDATETIME(), NULL
                    FROM #UpdatedRows ur;
                    
                    
                    SET @ProcessedCount = @ProcessedCount + (SELECT COUNT(*) FROM #UpdatedRows);
                    
                    IF OBJECT_ID('tempdb..#UpdatedRows') IS NOT NULL 
                        DROP TABLE #UpdatedRows;
                        
                    BREAK; -- Éxito, salir del ciclo de reintentos
                END TRY
                BEGIN CATCH
                    SET @ErrorNumber = ERROR_NUMBER();
                    SET @ErrorMsg = ERROR_MESSAGE();
                    SET @ErrorSeverity = ERROR_SEVERITY();
                    SET @ErrorState = ERROR_STATE();
                    
                    IF OBJECT_ID('tempdb..#UpdatedRows') IS NOT NULL 
                        DROP TABLE #UpdatedRows;
                    
                    -- Reintentar en caso de errores transitorios
                    IF (@ErrorNumber IN (1205, 1222, -2, 701, 41302, 41305, 41325, 41839)) AND @intentos < @maxReintentos
                    BEGIN
                        SET @intentos = @intentos + 1;
                        WAITFOR DELAY '00:00:00.1'; -- 100ms de espera antes de reintentar
                        CONTINUE;
                    END
                    
                    -- Para otros errores, registrar y continuar
                    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
                    SELECT 
                        be.RowId, 
                        1016, 
                        NULL,
                        'Error al actualizar registros: ' + @ErrorMsg, 
                        jt.JsonData
                    FROM #Existing be
                    JOIN #JsonTable jt ON be.RowId = jt.RowId;
                    
                    IF @modoEstricto = 1 GOTO ReturnResults;
                    BREAK; -- Error no recuperable, salir del ciclo
                END CATCH
            END
            
        END       
        
        WHILE EXISTS (
            SELECT 1 FROM #Results r
            WHERE r.Operation = 'UPDATE' AND r.Data IS NULL
        )
        BEGIN
            BEGIN TRY
                CREATE TABLE #UpdateJsonData (
                    ResultId INT,
                    JsonData NVARCHAR(MAX)
                );
                
                SET @SQL = N'
                INSERT INTO #UpdateJsonData (ResultId, JsonData)
                SELECT r.ResultId,
                       (SELECT * FROM ' + @TableName + ' t 
                        WHERE t.Sec = r.Sec 
                        FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) AS JsonData
                FROM #Results r
                WHERE r.Operation = ''UPDATE'' AND r.Data IS NULL';
                
                EXEC sp_executesql @SQL;
                
                UPDATE r
                SET Data = ud.JsonData
                FROM #Results r
                JOIN #UpdateJsonData ud ON r.ResultId = ud.ResultId;
                
                DROP TABLE #UpdateJsonData;
            END TRY
            BEGIN CATCH
                IF OBJECT_ID('tempdb..#UpdateJsonData') IS NOT NULL 
                    DROP TABLE #UpdateJsonData;
                    
                INSERT INTO #Errors VALUES (NULL, 1017, NULL, 'Error al recuperar datos JSON actualizados: ' + ERROR_MESSAGE(), NULL);
                
                -- No detenemos el procesamiento por este tipo de error
            END CATCH            
        END
    END
    
    -- PROCESAR INSERCIONES
    IF EXISTS (SELECT 1 FROM #New WHERE RowId NOT IN (SELECT RowId FROM #Errors))
    BEGIN
        -- Variable para rastrear el próximo valor Sec disponible
        DECLARE @NextSecValue INT = NULL;
        
        -- Manejar cada registro individualmente
        DECLARE @NewRowId INT;
        DECLARE @JsonData NVARCHAR(MAX);
        DECLARE @SecValue INT;
        
        DECLARE new_rows_cursor CURSOR FOR
            SELECT n.RowId, jt.JsonData, jt.Sec 
            FROM #New n
            JOIN #JsonTable jt ON n.RowId = jt.RowId
            WHERE jt.RowId NOT IN (SELECT RowId FROM #Errors);
        
        OPEN new_rows_cursor;
        FETCH NEXT FROM new_rows_cursor INTO @NewRowId, @JsonData, @SecValue;
        
        WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @intentos = 0;
            WHILE @intentos < @maxReintentos
            BEGIN
                BEGIN TRY
                    
                    CREATE TABLE #InsertedRows (
                        Sec INT, 
                        RowId INT
                    );
                    
                    DECLARE @DynamicSQL NVARCHAR(MAX);
                    SET @DynamicSQL = N'
                    INSERT INTO ' + @TableName + ' (';
                    
                    -- Agregar columnas
                    SELECT @DynamicSQL = @DynamicSQL + 
                        CASE WHEN ColumnId = 1 THEN '' ELSE ', ' END + 
                        QUOTENAME(ColumnName)
                    FROM #Columns
                    WHERE IsIdentity = 0
                      AND IsComputed = 0
                    ORDER BY ColumnId;
                    
                    SET @DynamicSQL = @DynamicSQL + ') 
                    OUTPUT inserted.Sec, ' + CAST(@NewRowId AS VARCHAR(10)) + '
                    INTO #InsertedRows(Sec, RowId)
                    SELECT ';
                    
                    -- Declarar variable para el nuevo ID si es necesario
                    DECLARE @NewSecId INT = NULL;
                    
                    -- Si Sec es 0, obtener el próximo valor disponible
                    IF @SecValue = 0
                    BEGIN
                        -- Obtener el próximo valor base solo una vez por lote
                        IF @NextSecValue IS NULL
                        BEGIN
                            SET @SQL = N'SELECT @NextSecOut = ISNULL(MAX(Sec), 0) + 1 FROM ' + @TableName;
                            EXEC sp_executesql @SQL, N'@NextSecOut INT OUTPUT', @NextSecValue OUTPUT;
                        END
                        
                        -- Usar el valor y luego incrementarlo para el siguiente registro
                        SET @NewSecId = @NextSecValue;
                        SET @NextSecValue = @NextSecValue + 1;
                    END

                    -- Agregar valores para cada columna
                    SELECT @DynamicSQL = @DynamicSQL + 
                        CASE WHEN ColumnId = 1 THEN '' ELSE ', ' END + 
                        CASE 
                            WHEN ColumnName = 'Sec' THEN 
                                CASE WHEN @SecValue = 0 THEN 
                                    CAST(@NewSecId AS VARCHAR(20)) -- Usar el valor calculado
                                ELSE 
                                    CAST(@SecValue AS VARCHAR(20)) -- Usar el valor proporcionado
                                END
                            ELSE 
                                CASE 
                                    WHEN DataType = 'money' THEN 
                                        'CAST(JSON_VALUE(''' + REPLACE(@JsonData, '''', '''''') + ''', ''$.' + ColumnName + ''') AS money)'
                                    WHEN TypeCategory = 'STRING' THEN 
                                        'JSON_VALUE(''' + REPLACE(@JsonData, '''', '''''') + ''', ''$.' + ColumnName + ''')'
                                    WHEN TypeCategory = 'BOOLEAN' THEN
                                        'CAST(JSON_VALUE(''' + REPLACE(@JsonData, '''', '''''') + ''', ''$.' + ColumnName + ''') AS BIT)'
                                    WHEN TypeCategory = 'INTEGER' THEN
                                        'CAST(JSON_VALUE(''' + REPLACE(@JsonData, '''', '''''') + ''', ''$.' + ColumnName + ''') AS ' + DataType + ')'
                                    WHEN TypeCategory = 'DECIMAL' AND DataType <> 'money' THEN
                                        'CAST(JSON_VALUE(''' + REPLACE(@JsonData, '''', '''''') + ''', ''$.' + ColumnName + ''') AS ' + 
                                        DataType + '(' + CAST(Precision AS VARCHAR) + ',' + CAST(Scale AS VARCHAR) + '))'
                                    WHEN TypeCategory = 'DATETIME' THEN
                                        'CAST(JSON_VALUE(''' + REPLACE(@JsonData, '''', '''''') + ''', ''$.' + ColumnName + ''') AS ' + DataType + ')'
                                    ELSE
                                        'JSON_VALUE(''' + REPLACE(@JsonData, '''', '''''') + ''', ''$.' + ColumnName + ''')'
                                END
                        END
                    FROM #Columns
                    WHERE IsIdentity = 0
                      AND IsComputed = 0
                    ORDER BY ColumnId;
                    
                    EXEC sp_executesql @DynamicSQL;
                    
                    INSERT INTO #Results (RowId, Operation, Success, Sec, RequestTimeUTC, Data)
                    SELECT RowId, 'INSERT', 1, Sec, SYSUTCDATETIME(), NULL
                    FROM #InsertedRows;
                    
                    SET @ProcessedCount = @ProcessedCount + 1;
                    
                    DROP TABLE #InsertedRows;
                    
                    
                    BREAK; -- Éxito
                END TRY
                BEGIN CATCH
                    SET @ErrorNumber = ERROR_NUMBER();
                    SET @ErrorMsg = ERROR_MESSAGE();
                    
                    IF OBJECT_ID('tempdb..#InsertedRows') IS NOT NULL 
                        DROP TABLE #InsertedRows;
                    
                    
                    IF (@ErrorNumber IN (1205, 1222, -2, 701, 41302, 41305, 41325, 41839)) AND @intentos < @maxReintentos
                    BEGIN
                        SET @intentos = @intentos + 1;
                        WAITFOR DELAY '00:00:00.2';
                        CONTINUE;
                    END
                    
                    INSERT INTO #Errors (RowId, ErrorCode, Field, ErrorMessage, JsonData)
                    VALUES (@NewRowId, 1018, NULL, 'Error al insertar registro: ' + @ErrorMsg, @JsonData);
                    
                    IF @modoEstricto = 1 
                    BEGIN
                        CLOSE new_rows_cursor;
                        DEALLOCATE new_rows_cursor;
                        GOTO ReturnResults;
                    END
                    
                    BREAK;
                END CATCH
            END
            
            FETCH NEXT FROM new_rows_cursor INTO @NewRowId, @JsonData, @SecValue;
        END
        
        CLOSE new_rows_cursor;
        DEALLOCATE new_rows_cursor;
        
        -- Recuperar datos insertados
        DECLARE @ResultsToUpdate TABLE (
            ResultId INT,
            Sec INT
        );
        
        INSERT INTO @ResultsToUpdate (ResultId, Sec)
        SELECT ResultId, Sec
        FROM #Results
        WHERE Operation = 'INSERT' AND Data IS NULL;
        
        DECLARE @ResultId INT, @ResultSec INT;
        DECLARE @JsonResult NVARCHAR(MAX);
        
        DECLARE results_cursor CURSOR FOR 
            SELECT ResultId, Sec FROM @ResultsToUpdate;
        
        OPEN results_cursor;
        FETCH NEXT FROM results_cursor INTO @ResultId, @ResultSec;
        
        WHILE @@FETCH_STATUS = 0
        BEGIN
            BEGIN TRY
                SET @SQL = N'SELECT @JsonOut = (SELECT * FROM ' + @TableName + 
                           N' WHERE Sec = @Sec FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)';
                
                EXEC sp_executesql @SQL, 
                     N'@Sec INT, @JsonOut NVARCHAR(MAX) OUTPUT', 
                     @ResultSec, @JsonResult OUTPUT;
                
                UPDATE #Results
                SET Data = @JsonResult
                WHERE ResultId = @ResultId;
            END TRY
            BEGIN CATCH
                -- Ignorar errores al recuperar datos JSON
            END CATCH
            
            FETCH NEXT FROM results_cursor INTO @ResultId, @ResultSec;
        END
        
        CLOSE results_cursor;
        DEALLOCATE results_cursor;
    END

    -- Registrar auditoría si se requiere
    IF @registrarLog = 1
    BEGIN
        DECLARE @LogMessage NVARCHAR(4000) = 'DynamicUpsertJson: Tabla=' + @tabla + 
                                           ', Registros=' + CAST((SELECT COUNT(*) FROM #JsonTable) AS VARCHAR) +
                                           ', Procesados=' + CAST(@ProcessedCount AS VARCHAR) +
                                           ', Errores=' + CAST((SELECT COUNT(*) FROM #Errors) AS VARCHAR) +
                                           ', Tiempo=' + CAST(DATEDIFF(MILLISECOND, @StartTime, SYSUTCDATETIME()) AS VARCHAR) + 'ms';
    END

ReturnResults:
    -- Limitar tamaño de respuesta JSON para evitar problemas de memoria
    DECLARE @MaxJsonRows INT = 1000; -- Ajustar según necesidades

    -- Devolver resultados en formato JSON estructurado
    SELECT (
        SELECT 
            @RequestID AS RequestId,
            DATEDIFF(MILLISECOND, @StartTime, SYSUTCDATETIME()) AS ExecutionTimeMs,
            (SELECT COUNT(*) FROM #JsonTable) AS TotalRecords,
            @ProcessedCount AS ProcessedCount,
            (SELECT COUNT(*) FROM #Errors) AS ErrorCount,
            (SELECT COUNT(*) FROM #Results WHERE Operation = 'INSERT') AS InsertCount,
            (SELECT COUNT(*) FROM #Results WHERE Operation = 'UPDATE') AS UpdateCount,
            (
                SELECT TOP (@MaxJsonRows)
                    r.RowId,
                    r.Operation,
                    r.Sec,
                    r.RequestTimeUTC,
                    JSON_QUERY(r.Data) AS Record
                FROM #Results r
                ORDER BY r.RowId
                FOR JSON PATH
            ) AS Results,
            (
                SELECT TOP (@MaxJsonRows)
                    e.RowId,
                    e.ErrorCode,
                    e.Field,
                    e.ErrorMessage,
                    CASE 
                        WHEN LEN(e.JsonData) > 4000 THEN JSON_QUERY(LEFT(e.JsonData, 4000) + '...') 
                        ELSE JSON_QUERY(e.JsonData)
                    END AS OriginalData
                FROM #Errors e
                ORDER BY e.ErrorId
                FOR JSON PATH
            ) AS Errors,
            CASE WHEN (SELECT COUNT(*) FROM #Results) > @MaxJsonRows OR 
                      (SELECT COUNT(*) FROM #Errors) > @MaxJsonRows 
                 THEN 1 ELSE 0 
            END AS ResultsTruncated
        FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
    ) AS Response;

    -- Limpiar tablas temporales
    IF OBJECT_ID('tempdb..#Columns') IS NOT NULL DROP TABLE #Columns;
    IF OBJECT_ID('tempdb..#JsonTable') IS NOT NULL DROP TABLE #JsonTable;
    IF OBJECT_ID('tempdb..#Existing') IS NOT NULL DROP TABLE #Existing;
    IF OBJECT_ID('tempdb..#New') IS NOT NULL DROP TABLE #New;
    IF OBJECT_ID('tempdb..#Results') IS NOT NULL DROP TABLE #Results;
    IF OBJECT_ID('tempdb..#Errors') IS NOT NULL DROP TABLE #Errors;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AnularLiquidacion]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_AnularLiquidacion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_AnularLiquidacion] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_AnularLiquidacion]
    @Datos NVARCHAR(MAX) -- JSON con SecLiquidacion y TipoLiquidacion
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    -- Variables principales
    DECLARE @SecLiquidacion INT;
    DECLARE @TipoLiquidacion CHAR(1); -- P=Periodos, S=Semestres, E=Extraordinaria, C=Contratos
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @Estado VARCHAR(20);
    DECLARE @SecPeriodoSemestre INT;
    
    -- Variables para manejo de descuentos
    DECLARE @CuotaMaxima INT;
    DECLARE @CuotaActual INT;
    DECLARE @SecConceptoP2 INT;
    DECLARE @NomConcepto VARCHAR(100);
    DECLARE @IdContrato VARCHAR(50);
    DECLARE @ValorDescuento MONEY;
    DECLARE @TotalDescontado MONEY;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @SecLiquidacion = JSON_VALUE(@Datos, '$.SecLiquidacion'),
            @TipoLiquidacion = UPPER(JSON_VALUE(@Datos, '$.TipoLiquidacion'));
        
        -- 3. VALIDAR TIPO DE LIQUIDACIÓN
        IF @TipoLiquidacion NOT IN ('P', 'S', 'E', 'C')
        BEGIN
            SET @ErrorMsg = 'Tipo de liquidación inválido. Debe ser P, S, E o C';
            THROW 50001, @ErrorMsg, 1;
        END
        
        -- 4. OBTENER Y VALIDAR ESTADO ACTUAL
        IF @TipoLiquidacion = 'P'
        BEGIN
            SELECT @Estado = Estado 
            FROM NominaLiquidada 
            WHERE Sec = @SecLiquidacion;
            
            IF @Estado IS NULL
            BEGIN
                SET @ErrorMsg = 'No se encontró la liquidación de periodos especificada';
                THROW 50002, @ErrorMsg, 1;
            END
        END
        ELSE IF @TipoLiquidacion = 'S'
        BEGIN
            SELECT @Estado = Estado 
            FROM NominaLiquidaSemestres 
            WHERE Sec = @SecLiquidacion;
            
            IF @Estado IS NULL
            BEGIN
                SET @ErrorMsg = 'No se encontró la liquidación de semestres especificada';
                THROW 50002, @ErrorMsg, 1;
            END
        END
        ELSE IF @TipoLiquidacion = 'E'
        BEGIN
            SELECT @Estado = Estado 
            FROM NominaLiquidaExtraordinaria 
            WHERE Sec = @SecLiquidacion;
            
            IF @Estado IS NULL
            BEGIN
                SET @ErrorMsg = 'No se encontró la liquidación extraordinaria especificada';
                THROW 50002, @ErrorMsg, 1;
            END
        END
        ELSE IF @TipoLiquidacion = 'C'
        BEGIN
            SELECT @Estado = Estado 
            FROM ContratosLiquidados 
            WHERE Sec = @SecLiquidacion;
            
            IF @Estado IS NULL
            BEGIN
                SET @ErrorMsg = 'No se encontró la liquidación de contratos especificada';
                THROW 50002, @ErrorMsg, 1;
            END
        END
        
        -- 5. VALIDAR QUE NO ESTÉ YA ANULADA
        IF @Estado = 'A'
        BEGIN
            SET @ErrorMsg = 'Esta Liquidación ya se encuentra anulada';
            THROW 50003, @ErrorMsg, 1;
        END
        
        -- 6. PROCESAR DESCUENTOS (Solo para P, S, E)
        IF @TipoLiquidacion IN ('P', 'S', 'E')
        BEGIN
            -- Crear tabla temporal para descuentos
            CREATE TABLE #Descuentos (
                SecConceptoP2 INT,
                Valor MONEY,
                Cuota INT,
                NomConcepto VARCHAR(100),
                IdContrato VARCHAR(50)
            );
            
            -- Obtener descuentos según tipo
            IF @TipoLiquidacion = 'P'
            BEGIN
                INSERT INTO #Descuentos
                SELECT NLCC.SecConceptoP2, NLCC.Valor, NLCC.Cuota, CP.NomConcepto, C.IdContrato
                FROM NominaLiquidadaConceptos NLCC 
                INNER JOIN ConceptosPersonales CP ON NLCC.SecConceptoP = CP.Sec 
                INNER JOIN NominaLiquidadaContratos NLC ON NLCC.LiquidadaContrato = NLC.Sec 
                INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato 
                WHERE NLC.NominaLiquidada = @SecLiquidacion 
                AND NLCC.SecConceptoP2 <> '';
            END
            ELSE IF @TipoLiquidacion = 'S'
            BEGIN
                INSERT INTO #Descuentos
                SELECT NLCC.SecConceptoP2, NLCC.Valor, NLCC.Cuota, CP.NomConcepto, C.IdContrato
                FROM NominaLiquidaSemestresConceptos NLCC 
                INNER JOIN ConceptosPersonales CP ON NLCC.SecConceptoP = CP.Sec 
                INNER JOIN NominaLiquidaSemestresContratos NLC ON NLCC.LiquidaContrato = NLC.Sec 
                INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato 
                WHERE NLC.NominaLiquidaSemestres = @SecLiquidacion 
                AND NLCC.SecConceptoP2 <> '';
            END
            ELSE IF @TipoLiquidacion = 'E'
            BEGIN
                INSERT INTO #Descuentos
                SELECT NLCC.SecConceptoP2, NLCC.Valor, NLCC.Cuota, CP.NomConcepto, C.IdContrato
                FROM NominaLiquidaExtraordinariaConceptos NLCC 
                INNER JOIN ConceptosPersonales CP ON NLCC.SecConceptoP = CP.Sec 
                INNER JOIN NominaLiquidaExtraordinariaContratos NLC ON NLCC.LiquidaContrato = NLC.Sec 
                INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato 
                WHERE NLC.NominaLiquidaExtraordinaria = @SecLiquidacion 
                AND NLCC.SecConceptoP2 <> '';
            END
            
            -- Validar cuotas posteriores para cada descuento
            DECLARE cur_descuentos CURSOR FOR
            SELECT SecConceptoP2, Valor, Cuota, NomConcepto, IdContrato
            FROM #Descuentos;
            
            OPEN cur_descuentos;
            FETCH NEXT FROM cur_descuentos INTO @SecConceptoP2, @ValorDescuento, @CuotaActual, @NomConcepto, @IdContrato;
            
            WHILE @@FETCH_STATUS = 0
            BEGIN
                -- Obtener cuota máxima en todas las liquidaciones
                SELECT @CuotaMaxima = ISNULL(MAX(Tb.Num), 0)
                FROM (
                    SELECT NLC.Cuota AS Num 
                    FROM NominaLiquidadaConceptos NLC 
                    INNER JOIN NominaLiquidadaContratos NLDC ON NLC.LiquidadaContrato = NLDC.Sec 
                    INNER JOIN NominaLiquidada NL ON NLDC.NominaLiquidada = NL.Sec 
                    WHERE NL.Estado <> 'A' AND NLC.SecConceptoP2 = @SecConceptoP2
                    UNION
                    SELECT NLC.Cuota AS Num 
                    FROM NominaLiquidaExtraordinariaConceptos NLC 
                    INNER JOIN NominaLiquidaExtraordinariaContratos NLDC ON NLC.LiquidaContrato = NLDC.Sec 
                    INNER JOIN NominaLiquidaExtraordinaria NL ON NLDC.NominaLiquidaExtraordinaria = NL.Sec 
                    WHERE NL.Estado <> 'A' AND NLC.SecConceptoP2 = @SecConceptoP2
                    UNION
                    SELECT NLC.Cuota AS Num 
                    FROM NominaLiquidaSemestresConceptos NLC 
                    INNER JOIN NominaLiquidaSemestresContratos NLDC ON NLC.LiquidaContrato = NLDC.Sec 
                    INNER JOIN NominaLiquidaSemestres NL ON NLDC.NominaLiquidaSemestres = NL.Sec 
                    WHERE NL.Estado <> 'A' AND NLC.SecConceptoP2 = @SecConceptoP2
                ) AS Tb;
                
                -- Validar que no existan cuotas posteriores
                IF @CuotaMaxima <> @CuotaActual
                BEGIN
                    SET @ErrorMsg = 'El Concepto Personal ' + @NomConcepto + ' aplicado al Contrato ' + @IdContrato + 
                                   ' se ha efectuado en liquidaciones posteriores, no es posible continuar!';
                    THROW 50004, @ErrorMsg, 1;
                END
                
                -- Restar descuento
                UPDATE ConceptosP_Contratos
                SET TotalDescontado = TotalDescontado - @ValorDescuento,
                    CuotaActual = CuotaActual - 1
                WHERE Sec = @SecConceptoP2;
                
                FETCH NEXT FROM cur_descuentos INTO @SecConceptoP2, @ValorDescuento, @CuotaActual, @NomConcepto, @IdContrato;
            END
            
            CLOSE cur_descuentos;
            DEALLOCATE cur_descuentos;
            
            DROP TABLE #Descuentos;
        END
        
        -- 7. ANULAR SEGÚN TIPO
        IF @TipoLiquidacion = 'P'
        BEGIN
            -- Obtener periodo
            SELECT @SecPeriodoSemestre = Periodo 
            FROM NominaLiquidada 
            WHERE Sec = @SecLiquidacion;
            
            -- Actualizar estados
            UPDATE NominaLiquidada 
            SET Estado = 'A' 
            WHERE Sec = @SecLiquidacion;
            
            UPDATE PeriodosLiquidacion 
            SET Estado = 'P' 
            WHERE Sec = @SecPeriodoSemestre;
        END
        ELSE IF @TipoLiquidacion = 'S'
        BEGIN
            -- Obtener semestre
            SELECT @SecPeriodoSemestre = Semestre 
            FROM NominaLiquidaSemestres 
            WHERE Sec = @SecLiquidacion;
            
            -- Actualizar estados
            UPDATE NominaLiquidaSemestres 
            SET Estado = 'A' 
            WHERE Sec = @SecLiquidacion;
            
            UPDATE SemestresLiquidacion 
            SET Estado = 'P' 
            WHERE Sec = @SecPeriodoSemestre;
        END
        ELSE IF @TipoLiquidacion = 'E'
        BEGIN
            -- Solo actualizar estado
            UPDATE NominaLiquidaExtraordinaria 
            SET Estado = 'A' 
            WHERE Sec = @SecLiquidacion;
        END
        ELSE IF @TipoLiquidacion = 'C'
        BEGIN
            -- Actualizar estado de liquidación
            UPDATE ContratosLiquidados 
            SET Estado = 'A' 
            WHERE Sec = @SecLiquidacion;
            
            -- Reactivar contratos
            UPDATE C
            SET C.Terminado = 0
            FROM Contratos C
            INNER JOIN ContratosLiquidados_Contratos CLC ON C.CodContrato = CLC.Contrato
            WHERE CLC.NominaLiquida = @SecLiquidacion;
        END
        
        COMMIT TRANSACTION;
        
        -- 8. RETORNAR RESPUESTA EXITOSA
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                'ANULADA' as Operacion,
                'Liquidación anulada exitosamente!' as Mensaje,
                GETDATE() as FechaHoraServidor,
                @SecLiquidacion as SecLiquidacion,
                @TipoLiquidacion as TipoLiquidacion,
                CASE @TipoLiquidacion
                    WHEN 'P' THEN 'Liquidación de Periodos'
                    WHEN 'S' THEN 'Liquidación de Semestres'
                    WHEN 'E' THEN 'Liquidación Extraordinaria'
                    WHEN 'C' THEN 'Liquidación de Contratos'
                END as TipoDescripcion
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CopiarContrato]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_CopiarContrato]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_CopiarContrato] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_CopiarContrato]
    @SecEmpleadoDestino INT,      -- Sec del empleado que recibirá el contrato copiado
    @SecContratoOrigen INT,       -- Sec del contrato a copiar
    @Usuario VARCHAR(20),         -- Usuario que realiza la operación
    @Terminal VARCHAR(50)         -- Terminal desde donde se ejecuta
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    DECLARE @SecNuevoContrato INT;
    DECLARE @NuevoCodContrato INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @NombreEmpleadoDestino NVARCHAR(200);
    DECLARE @IdentificacionEmpleado BIGINT;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDACIONES BÁSICAS
        
        -- Validar que existe el empleado destino
        IF NOT EXISTS (SELECT 1 FROM Empleados WHERE Sec = @SecEmpleadoDestino)
        BEGIN
            SET @ErrorMsg = 'No existe el empleado con Sec = ' + CAST(@SecEmpleadoDestino AS VARCHAR);
            THROW 50001, @ErrorMsg, 1;
        END
        
        -- Validar que existe el contrato origen
        IF NOT EXISTS (SELECT 1 FROM Contratos WHERE Sec = @SecContratoOrigen)
        BEGIN
            SET @ErrorMsg = 'No existe el contrato con Sec = ' + CAST(@SecContratoOrigen AS VARCHAR);
            THROW 50002, @ErrorMsg, 1;
        END
        
        -- Validar que el contrato origen no esté terminado
        IF EXISTS (SELECT 1 FROM Contratos WHERE Sec = @SecContratoOrigen AND Terminado = 1)
        BEGIN
            SET @ErrorMsg = 'El contrato origen está terminado y no puede ser copiado';
            THROW 50003, @ErrorMsg, 1;
        END
        
        -- Obtener datos del empleado destino
        SELECT 
            @NombreEmpleadoDestino = RTRIM(LTRIM(PApellido)) + ' ' + 
                                    ISNULL(RTRIM(LTRIM(SApellido)), '') + ' ' + 
                                    RTRIM(LTRIM(PNombre)) + ' ' + 
                                    ISNULL(RTRIM(LTRIM(SNombre)), ''),
            @IdentificacionEmpleado = Identificacion
        FROM Empleados 
        WHERE Sec = @SecEmpleadoDestino;
        
        -- 2. CALCULAR NUEVOS IDs
        
        -- Calcular nuevo Sec para el contrato
        SELECT @SecNuevoContrato = ISNULL(MAX(Sec), 0) + 1 FROM Contratos;
        
        -- Calcular nuevo CodContrato
        SELECT @NuevoCodContrato = ISNULL(MAX(CodContrato), 0) + 1 FROM Contratos;
        
        -- 3. COPIAR EL CONTRATO
        
        INSERT INTO Contratos (
            Sec, Oficina, CodContrato, Empleado, TipoContrato, HorasMes,
            FechaInicio, FechaFin, Dependencia, Aprendiz, Terminado,
            Plantilla, Nomina, CargoActual, Asignacion, IdContrato,
            ValorExento, AsignacionCargo, FechaLiquidacion, UsaAsginaCargo,
            TipoTrabajador, SubTipoTrabajador, SalarioIntegral, PerfilCuentas
        )
        SELECT 
            @SecNuevoContrato,              -- Nuevo Sec
            Oficina, 
            @NuevoCodContrato,              -- Nuevo CodContrato
            @SecEmpleadoDestino,            -- Nuevo empleado
            TipoContrato, 
            HorasMes,
            GETDATE(),                      -- FechaInicio = Hoy
            FechaFin, 
            Dependencia, 
            Aprendiz, 
            0,                              -- Terminado = No
            Plantilla, 
            Nomina, 
            CargoActual, 
            Asignacion, 
            'COPIA-' + CAST(@NuevoCodContrato AS VARCHAR), -- Nuevo IdContrato
            ValorExento, 
            AsignacionCargo, 
            NULL,                           -- FechaLiquidacion = NULL
            UsaAsginaCargo,
            TipoTrabajador, 
            SubTipoTrabajador, 
            SalarioIntegral, 
            PerfilCuentas
        FROM Contratos 
        WHERE Sec = @SecContratoOrigen;
        
        -- 4. COPIAR CENTROS DE COSTOS
        
        INSERT INTO Contratos_CentroCostos (Sec, Contrato, CentroCosto, Porcentaje)
        SELECT 
            ROW_NUMBER() OVER (ORDER BY CentroCosto) + 
            ISNULL((SELECT MAX(Sec) FROM Contratos_CentroCostos), 0),
            @SecNuevoContrato,              -- Nuevo contrato
            CentroCosto,
            Porcentaje
        FROM Contratos_CentroCostos
        WHERE Contrato = @SecContratoOrigen;
        
        -- 5. COPIAR CARGOS
        
        INSERT INTO Contrato_Cargos (
            Sec, Contrato, Cargo, FechaInicio, FechaFin, 
            UsrRegistra, FechaRegistro, TerminalRegistra
        )
        SELECT 
            ROW_NUMBER() OVER (ORDER BY FechaInicio) + 
            ISNULL((SELECT MAX(Sec) FROM Contrato_Cargos), 0),
            @SecNuevoContrato,              -- Nuevo contrato
            Cargo,
            CASE 
                WHEN FechaFin IS NULL THEN GETDATE()  -- Si el cargo está activo, inicia hoy
                ELSE FechaInicio 
            END,
            FechaFin,
            @Usuario,
            GETDATE(),
            @Terminal
        FROM Contrato_Cargos
        WHERE Contrato = @SecContratoOrigen;
        
        -- 6. ACTUALIZAR EL CARGO ACTUAL EN EL NUEVO CONTRATO
        -- (Tomar el cargo más reciente sin fecha fin)
        
        UPDATE Contratos 
        SET CargoActual = (
            SELECT TOP 1 Sec 
            FROM Contrato_Cargos 
            WHERE Contrato = @SecNuevoContrato 
                AND FechaFin IS NULL
            ORDER BY FechaInicio DESC
        )
        WHERE Sec = @SecNuevoContrato;
        
        COMMIT TRANSACTION;
        
        -- 7. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                'COPIED' as Operacion,
                'Contrato copiado exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                @SecContratoOrigen as ContratoOrigen,
                JSON_QUERY((
                    SELECT 
                        c.Sec,
                        c.CodContrato,
                        c.IdContrato,
                        c.Empleado as SecEmpleado,
                        @IdentificacionEmpleado as IdentificacionEmpleado,
                        @NombreEmpleadoDestino as NombreEmpleado,
                        c.FechaInicio,
                        c.FechaFin,
                        c.Asignacion,
                        c.CargoActual,
                        tc.NomTipo as TipoContrato,
                        n.NomNomina as Nomina,
                        p.NomPlantilla as Plantilla,
                        JSON_QUERY((
                            SELECT 
                                cc.Sec,
                                cc.CentroCosto,
                                ccc.Nom_CentroCosto as NombreCentroCosto,
                                cc.Porcentaje
                            FROM Contratos_CentroCostos cc
                            INNER JOIN CT_CentroCostos ccc ON cc.CentroCosto = ccc.Sec
                            WHERE cc.Contrato = c.Sec
                            FOR JSON PATH
                        )) as CentrosCosto,
                        JSON_QUERY((
                            SELECT 
                                ccg.Sec,
                                ccg.Cargo,
                                cg.Denominacion as NombreCargo,
                                ccg.FechaInicio,
                                ccg.FechaFin
                            FROM Contrato_Cargos ccg
                            INNER JOIN cargos cg ON ccg.Cargo = cg.Sec
                            WHERE ccg.Contrato = c.Sec
                            ORDER BY ccg.FechaInicio
                            FOR JSON PATH
                        )) as Cargos,
                        (
                            SELECT COUNT(*) 
                            FROM Contratos_CentroCostos 
                            WHERE Contrato = c.Sec
                        ) as TotalCentrosCosto,
                        (
                            SELECT COUNT(*) 
                            FROM Contrato_Cargos 
                            WHERE Contrato = c.Sec
                        ) as TotalCargos
                    FROM Contratos c
                    LEFT JOIN CAT_TipoContratos tc ON c.TipoContrato = tc.Sec
                    LEFT JOIN Nominas n ON c.Nomina = n.Sec
                    LEFT JOIN Plantillas p ON c.Plantilla = p.Sec
                    WHERE c.Sec = @SecNuevoContrato
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as ContratoNuevo
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                @SecEmpleadoDestino as SecEmpleadoDestino,
                @SecContratoOrigen as SecContratoOrigen
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CopiarNominaDesdeNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_CopiarNominaDesdeNomina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_CopiarNominaDesdeNomina] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_CopiarNominaDesdeNomina]
    @Datos NVARCHAR(MAX) -- JSON con la información de la nueva nómina y la nómina plantilla
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    DECLARE @SecNomina INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @ConceptosInsertados INT = 0;
    DECLARE @ProvisionesInsertadas INT = 0;
    
    -- Variables para extraer del JSON
    DECLARE @NomNomina VARCHAR(50);
    DECLARE @NominaPlantilla INT; -- ID de la nómina a copiar
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    
    -- Variables para copiar de la plantilla
    DECLARE @FormaLiquida SMALLINT;
    DECLARE @Fecha DATE;
    DECLARE @Oficina SMALLINT;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @NomNomina = JSON_VALUE(@Datos, '$.NomNomina'),
            @NominaPlantilla = JSON_VALUE(@Datos, '$.NominaPlantilla'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. CALCULAR EL PRÓXIMO SEC DISPONIBLE
        SELECT @SecNomina = ISNULL(MAX(Sec), 0) + 1 
        FROM Nominas;
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @NomNomina IS NULL OR @NomNomina = ''
        BEGIN
            SET @ErrorMsg = 'El nombre de la nómina es requerido';
            THROW 50001, @ErrorMsg, 1;
        END
        
        IF @NominaPlantilla IS NULL OR @NominaPlantilla = 0
        BEGIN
            SET @ErrorMsg = 'La nómina plantilla es requerida';
            THROW 50002, @ErrorMsg, 1;
        END
        
        -- Verificar que existe la nómina plantilla
        IF NOT EXISTS (SELECT 1 FROM Nominas WHERE Sec = @NominaPlantilla)
        BEGIN
            SET @ErrorMsg = 'La nómina plantilla con Sec = ' + CAST(@NominaPlantilla AS VARCHAR) + ' no existe';
            THROW 50003, @ErrorMsg, 1;
        END
        
        -- 5. OBTENER DATOS DE LA NÓMINA PLANTILLA
        SELECT 
            @FormaLiquida = FormaLiquida,
            @Fecha = Fecha,
            @Oficina = Oficina
        FROM Nominas 
        WHERE Sec = @NominaPlantilla;
        
        -- 6. INSERTAR LA NUEVA NÓMINA COPIANDO DE LA PLANTILLA
        INSERT INTO Nominas (Sec, NomNomina, FormaLiquida, Fecha, Oficina)
        VALUES (@SecNomina, @NomNomina, @FormaLiquida, @Fecha, @Oficina);
        
        -- 7. COPIAR CONFIGURACIÓN DE CONCEPTOS
        INSERT INTO ConfigConceptos (Sec, Nomina, Concepto, Formula, PeriodosLiquida, CuentaContable, ConceptoR, ContraPartida)
        SELECT 
            CC2.maxfila + CC2.fila as Sec, 
            @SecNomina as Nomina, 
            CC.Concepto, 
            CC.Formula, 
            CC.PeriodosLiquida,
            CC.CuentaContable,
            CC.ConceptoR,
            CC.ContraPartida
        FROM ConfigConceptos CC 
        INNER JOIN (
            SELECT 
                Sec, 
                Nomina, 
                Concepto, 
                (SELECT ISNULL(MAX(Sec), 0) FROM ConfigConceptos) as maxfila, 
                ROW_NUMBER() OVER(ORDER BY Sec) AS fila 
            FROM ConfigConceptos
            WHERE Nomina = @NominaPlantilla
        ) as CC2 ON CC.Sec = CC2.Sec
        WHERE CC.Nomina = @NominaPlantilla;
        
        SET @ConceptosInsertados = @@ROWCOUNT;
        
        -- 8. COPIAR CONFIGURACIÓN DE PROVISIONES
        INSERT INTO ConfigProvisiones (Sec, Nomina, Concepto, Formula, SemestresLiquida, CuentaContable)
        SELECT 
            CC2.maxfila + CC2.fila as Sec, 
            @SecNomina as Nomina, 
            CC.Concepto, 
            CC.Formula, 
            CC.SemestresLiquida, 
            CC.CuentaContable
        FROM ConfigProvisiones CC 
        INNER JOIN (
            SELECT 
                Sec, 
                Nomina, 
                Concepto, 
                (SELECT ISNULL(MAX(Sec), 0) FROM ConfigProvisiones) as maxfila, 
                ROW_NUMBER() OVER(ORDER BY Sec) AS fila 
            FROM ConfigProvisiones
            WHERE Nomina = @NominaPlantilla
        ) as CC2 ON CC.Sec = CC2.Sec
        WHERE CC.Nomina = @NominaPlantilla;
        
        SET @ProvisionesInsertadas = @@ROWCOUNT;
        
        COMMIT TRANSACTION;
        
        -- 9. RETORNAR RESPUESTA EN JSON (MISMO FORMATO QUE SP_UpsertNomina)
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                'COPIED' as Operacion,
                'Nómina copiada exitosamente desde plantilla' as Mensaje,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY((
                    SELECT 
                        n.Sec,
                        n.NomNomina,
                        n.FormaLiquida,
                        n.Fecha,
                        n.Oficina,
                        (
                            SELECT COUNT(*) 
                            FROM ConfigConceptos 
                            WHERE Nomina = n.Sec
                        ) as TotalConceptosConfigurados,
                        @ConceptosInsertados as ConceptosNuevos,
                        (
                            SELECT COUNT(*) 
                            FROM ConfigProvisiones 
                            WHERE Nomina = n.Sec
                        ) as TotalProvisionesConfiguradas,
                        @ProvisionesInsertadas as ProvisionesNuevas,
                        (
                            SELECT TOP 10
                                cc.Sec,
                                cc.Concepto,
                                cn.NomConcepto,
                                cc.Formula,
                                cc.PeriodosLiquida,
                                cc.CuentaContable,
                                cc.ContraPartida
                            FROM ConfigConceptos cc
                            INNER JOIN ConceptosNomina cn ON cc.Concepto = cn.Sec
                            WHERE cc.Nomina = n.Sec
                            ORDER BY cc.Sec DESC
                            FOR JSON PATH
                        ) as ConceptosConfigurados,
                        (
                            SELECT TOP 10
                                cp.Sec,
                                cp.Concepto,
                                cn.NomConcepto,
                                cp.Formula,
                                cp.SemestresLiquida,
                                cp.CuentaContable
                            FROM ConfigProvisiones cp
                            INNER JOIN ConceptosNomina cn ON cp.Concepto = cn.Sec
                            WHERE cp.Nomina = n.Sec
                            ORDER BY cp.Sec DESC
                            FOR JSON PATH
                        ) as ProvisionesConfiguradas
                    FROM Nominas n
                    WHERE n.Sec = @SecNomina
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as Nomina
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON (MISMO FORMATO QUE SP_UpsertNomina)
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminaNominas]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_EliminaNominas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_EliminaNominas] AS' 
END
GO
ALTER PROCEDURE [dbo].[sp_EliminaNominas]
    @Datos NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Variables para el proceso
    DECLARE @Sec_nomina INT
    DECLARE @NumRegistros INT
    DECLARE @Resultado INT = 0
    DECLARE @Mensaje NVARCHAR(500) = ''
    
    -- Extraer el Sec_nomina del JSON
    SET @Sec_nomina = JSON_VALUE(@Datos, '$.Datos')
    
    -- Validación 1: Verificar si la nómina está asociada a contratos
    SELECT @NumRegistros = COUNT(*) 
    FROM Contratos 
    WHERE Nomina = @Sec_nomina
    
    IF @NumRegistros > 0
    BEGIN
        SET @Mensaje = 'La Nomina que desea eliminar se encuentra asociada a un contrato y no es posible continuar!'
		SELECT (
        SELECT @Resultado AS Resultado, @Mensaje AS Mensaje FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
		        )  AS JsonResponse;
        RETURN
    END
    
    -- Validación 2: Verificar si está en proceso de liquidación de periodos
    SELECT @NumRegistros = COUNT(NL.Sec) 
    FROM NominaLiquida NL 
    INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec 
    WHERE PL.Nomina = @Sec_nomina
    
    IF @NumRegistros > 0
    BEGIN
        SET @Mensaje = 'La Nomina que desea eliminar se encuentra en proceso de liquidación de periodos y no es posible continuar!'
		SELECT (
        SELECT @Resultado AS Resultado, @Mensaje AS Mensaje FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
		        )  AS JsonResponse;
        RETURN
    END
    
    -- Validación 3: Verificar si tiene periodos liquidados
    SELECT @NumRegistros = COUNT(NL.Sec) 
    FROM NominaLiquidada NL 
    INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec 
    WHERE PL.Nomina = @Sec_nomina
    
    IF @NumRegistros > 0
    BEGIN
        SET @Mensaje = 'La Nomina que desea eliminar ya tiene periodos liquidados y no es posible continuar!'
		SELECT (
        SELECT @Resultado AS Resultado, @Mensaje AS Mensaje FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
		        )  AS JsonResponse;
        RETURN
    END
    
    -- Validación 4: Verificar si tiene semestres liquidados o en proceso
    SELECT @NumRegistros = COUNT(NL.Sec) 
    FROM NominaLiquidaSemestres NL 
    INNER JOIN SemestresLiquidacion SL ON NL.Semestre = SL.Sec 
    WHERE SL.Nomina = @Sec_nomina
    
    IF @NumRegistros > 0
    BEGIN
        SET @Mensaje = 'La Nomina que desea eliminar ya tiene semestres liquidados o en proceso de liquidación y no es posible continuar!'
		SELECT (
			SELECT @Resultado AS Resultado, @Mensaje AS Mensaje FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        )  AS JsonResponse;
        
        RETURN
    END
    
    -- Si todas las validaciones pasan, proceder con la eliminación
    BEGIN TRY
        BEGIN TRANSACTION
            
            DELETE FROM ConfigConceptos WHERE Nomina = @Sec_nomina
            DELETE FROM ConfigProvisiones WHERE Nomina = @Sec_nomina
            DELETE FROM PeriodosLiquidacion WHERE Nomina = @Sec_nomina
            DELETE FROM SemestresLiquidacion WHERE Nomina = @Sec_nomina
            DELETE FROM Nominas WHERE Sec = @Sec_nomina
            
            -- Si llegamos aquí, todo salió bien
            SET @Resultado = 1
            SET @Mensaje = 'Nómina eliminada exitosamente'
            
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        SET @Resultado = 0
        SET @Mensaje = 'Error al eliminar la nomina!'
    END CATCH
    
    -- Retornar el resultado
	SELECT (
    SELECT @Resultado AS Resultado, @Mensaje AS Mensaje FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        )  AS JsonResponse;    
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarBorradorNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_EliminarBorradorNomina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_EliminarBorradorNomina] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_EliminarBorradorNomina]
    @Datos NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @SecNominaLiquida INT;
    DECLARE @Usuario NVARCHAR(20);
    DECLARE @Terminal NVARCHAR(50);
    DECLARE @ErrorMsg NVARCHAR(500);
    
    BEGIN TRY
        -- Validar JSON
        IF ISJSON(@Datos) = 0
        BEGIN
            RAISERROR('Formato JSON inválido', 16, 1);
            RETURN;
        END
        
        -- Extraer parámetros del JSON
        SELECT 
            @SecNominaLiquida = JSON_VALUE(@Datos, '$.SecNominaLiquida'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
            
        -- Validar parámetros
        IF @SecNominaLiquida IS NULL
        BEGIN
            RAISERROR('SecNominaLiquida es requerido', 16, 1);
            RETURN;
        END
        
        -- Verificar que existe y es un borrador
        IF NOT EXISTS (SELECT 1 FROM NominaLiquida WHERE Sec = @SecNominaLiquida AND EsBorrador = 1)
        BEGIN
            RAISERROR('No se encontró el borrador especificado', 16, 1);
            RETURN;
        END
        
        BEGIN TRANSACTION;
        
        -- 1. Eliminar DescripVarPer relacionados
        DELETE DVP
        FROM DescripVarPer DVP
        INNER JOIN NominaLiquidaVariables NLV ON DVP.CodVarP = NLV.Sec
        INNER JOIN NominaLiquidaContratos NLC ON NLV.SecLiquidaContrato = NLC.Sec
        WHERE NLC.NominaLiquida = @SecNominaLiquida;
        
        -- 2. Eliminar NominaLiquidaVariables
        DELETE NLV
        FROM NominaLiquidaVariables NLV
        INNER JOIN NominaLiquidaContratos NLC ON NLV.SecLiquidaContrato = NLC.Sec
        WHERE NLC.NominaLiquida = @SecNominaLiquida;
        
        -- 3. Eliminar NominaLiquidaConceptos
        DELETE NLCC
        FROM NominaLiquidaConceptos NLCC
        INNER JOIN NominaLiquidaContratos NLC ON NLCC.LiquidaContrato = NLC.Sec
        WHERE NLC.NominaLiquida = @SecNominaLiquida;
        
        -- 4. Eliminar NominaLiquidaContratos
        DELETE FROM NominaLiquidaContratos
        WHERE NominaLiquida = @SecNominaLiquida;
        
        -- 5. Eliminar NominaLiquida
        DELETE FROM NominaLiquida
        WHERE Sec = @SecNominaLiquida;
        
        COMMIT TRANSACTION;
        
        -- Retornar respuesta exitosa en JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                'DELETED' as Operacion,
                'Borrador eliminado correctamente' as Mensaje,
                @SecNominaLiquida as SecNominaLiquida,
                GETDATE() as FechaHoraServidor
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                ERROR_MESSAGE() as Mensaje,
                ERROR_NUMBER() as CodigoError,
                GETDATE() as FechaHoraServidor
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarBorradorNomina_NoResponse]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_EliminarBorradorNomina_NoResponse]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_EliminarBorradorNomina_NoResponse] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_EliminarBorradorNomina_NoResponse]
    @Datos NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @SecNominaLiquida INT;
    DECLARE @Usuario NVARCHAR(20);
    DECLARE @Terminal NVARCHAR(50);
    DECLARE @ErrorMsg NVARCHAR(500);
    
    BEGIN TRY
        -- Validar JSON
        IF ISJSON(@Datos) = 0
        BEGIN
            RAISERROR('Formato JSON inválido', 16, 1);
            RETURN;
        END
        
        -- Extraer parámetros del JSON
        SELECT 
            @SecNominaLiquida = JSON_VALUE(@Datos, '$.SecNominaLiquida'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
            
        -- Validar parámetros
        IF @SecNominaLiquida IS NULL
        BEGIN
            RAISERROR('SecNominaLiquida es requerido', 16, 1);
            RETURN;
        END
        
        -- Verificar que existe y es un borrador
        IF NOT EXISTS (SELECT 1 FROM NominaLiquida WHERE Sec = @SecNominaLiquida AND EsBorrador = 1)
        BEGIN
            RAISERROR('No se encontró el borrador especificado', 16, 1);
            RETURN;
        END
        
        BEGIN TRANSACTION;
        
        -- 1. Eliminar DescripVarPer relacionados
        DELETE DVP
        FROM DescripVarPer DVP
        INNER JOIN NominaLiquidaVariables NLV ON DVP.CodVarP = NLV.Sec
        INNER JOIN NominaLiquidaContratos NLC ON NLV.SecLiquidaContrato = NLC.Sec
        WHERE NLC.NominaLiquida = @SecNominaLiquida;
        
        -- 2. Eliminar NominaLiquidaVariables
        DELETE NLV
        FROM NominaLiquidaVariables NLV
        INNER JOIN NominaLiquidaContratos NLC ON NLV.SecLiquidaContrato = NLC.Sec
        WHERE NLC.NominaLiquida = @SecNominaLiquida;
        
        -- 3. Eliminar NominaLiquidaConceptos
        DELETE NLCC
        FROM NominaLiquidaConceptos NLCC
        INNER JOIN NominaLiquidaContratos NLC ON NLCC.LiquidaContrato = NLC.Sec
        WHERE NLC.NominaLiquida = @SecNominaLiquida;
        
        -- 4. Eliminar NominaLiquidaContratos
        DELETE FROM NominaLiquidaContratos
        WHERE NominaLiquida = @SecNominaLiquida;
        
        -- 5. Eliminar NominaLiquida
        DELETE FROM NominaLiquida
        WHERE Sec = @SecNominaLiquida;
        
        COMMIT TRANSACTION;
        

        
    END TRY
    BEGIN CATCH
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GuardarBorradorNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_GuardarBorradorNomina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_GuardarBorradorNomina] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_GuardarBorradorNomina]
    @Datos NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Variables para respuesta
    DECLARE @Estado VARCHAR(50) = 'SUCCESS'
    DECLARE @Mensaje NVARCHAR(500) = ''
    DECLARE @CodigoError INT = NULL
    DECLARE @SecNominaLiquida INT
    DECLARE @ContratosGuardados INT = 0
    DECLARE @ConceptosGuardados INT = 0
    DECLARE @VariablesGuardadas INT = 0
    
    BEGIN TRY
        BEGIN TRANSACTION
        
        -- Parsear JSON principal
        DECLARE @SecPeriodo INT = JSON_VALUE(@Datos, '$.SecPeriodo')
        DECLARE @Usuario VARCHAR(50) = JSON_VALUE(@Datos, '$.Usuario')
        DECLARE @Terminal VARCHAR(50) = JSON_VALUE(@Datos, '$.Terminal')
        
        SET @SecNominaLiquida = JSON_VALUE(@Datos, '$.SecNominaLiquida')
        
        -- Verificar si existe NominaLiquida
        IF EXISTS (SELECT 1 FROM NominaLiquida WHERE Sec = @SecNominaLiquida)
        BEGIN
            -- Actualizar NominaLiquida existente
            UPDATE NominaLiquida 
            SET FechaMod = GETDATE(),
                UsuMod = @Usuario,
                TerminalMod = @Terminal
            WHERE Sec = @SecNominaLiquida
        END
        ELSE
        BEGIN
            -- Obtener siguiente Sec para NominaLiquida
            DECLARE @NuevoSecNomina INT
            SELECT @NuevoSecNomina = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquida
            
            -- Insertar nueva NominaLiquida
            INSERT INTO NominaLiquida (Sec, Periodo, EsBorrador, FechaCrea, UsuCrea, TerminalCrea)
            VALUES (@NuevoSecNomina, @SecPeriodo, 1, GETDATE(), @Usuario, @Terminal)
            
            SET @SecNominaLiquida = @NuevoSecNomina
        END
        
        -- Procesar contratos
        DECLARE @Contratos NVARCHAR(MAX) = JSON_QUERY(@Datos, '$.Contratos')
        
        -- Cursor para contratos
        DECLARE @ContratoJSON NVARCHAR(MAX)
        DECLARE contrato_cursor CURSOR FOR
        SELECT value FROM OPENJSON(@Contratos)
        
        OPEN contrato_cursor
        FETCH NEXT FROM contrato_cursor INTO @ContratoJSON
        
        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Variables del contrato
            DECLARE @SecContratoLiquida INT = JSON_VALUE(@ContratoJSON, '$.SecContratoLiquida')
            DECLARE @CodContrato VARCHAR(20) = JSON_VALUE(@ContratoJSON, '$.CodContrato')
            DECLARE @Total DECIMAL(18,2) = JSON_VALUE(@ContratoJSON, '$.Total')
            DECLARE @HorasMes DECIMAL(18,2) = JSON_VALUE(@ContratoJSON, '$.HorasMes')
            DECLARE @CargoActual INT = JSON_VALUE(@ContratoJSON, '$.CargoActual')
            DECLARE @Asignacion DECIMAL(18,2) = JSON_VALUE(@ContratoJSON, '$.Asignacion')
            DECLARE @TotalIngresos DECIMAL(18,2) = JSON_VALUE(@ContratoJSON, '$.TotalIngresos')
            DECLARE @TotalDeducciones DECIMAL(18,2) = JSON_VALUE(@ContratoJSON, '$.TotalDeducciones')
            DECLARE @TotalProvisiones DECIMAL(18,2) = JSON_VALUE(@ContratoJSON, '$.TotalProvisiones')
            DECLARE @TotalDescuentosNomina DECIMAL(18,2) = JSON_VALUE(@ContratoJSON, '$.TotalDescuentosNomina')
            
            -- Verificar si existe el contrato
            IF EXISTS (SELECT 1 FROM NominaLiquidaContratos WHERE Sec = @SecContratoLiquida)
            BEGIN
                -- Actualizar contrato existente
                UPDATE NominaLiquidaContratos
                SET Total = @Total,
                    HorasMes = @HorasMes,
                    CargoActual = @CargoActual,
                    Asignacion = @Asignacion,
                    TotalIngresos = @TotalIngresos,
                    TotalDeducciones = @TotalDeducciones,
                    TotalProvisiones = @TotalProvisiones,
                    TotalDescuentosNomina = @TotalDescuentosNomina
                WHERE Sec = @SecContratoLiquida
            END
            ELSE
            BEGIN
                -- Obtener siguiente Sec para NominaLiquidaContratos
                DECLARE @NuevoSecContrato INT
                SELECT @NuevoSecContrato = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidaContratos
                
                -- Insertar nuevo contrato
                INSERT INTO NominaLiquidaContratos (
                    Sec, NominaLiquida, Contrato, Total, HorasMes, CargoActual, 
                    Asignacion, TotalIngresos, TotalDeducciones, TotalProvisiones, 
                    TotalDescuentosNomina
                )
                VALUES (
                    @NuevoSecContrato, @SecNominaLiquida, @CodContrato, @Total, @HorasMes, @CargoActual,
                    @Asignacion, @TotalIngresos, @TotalDeducciones, @TotalProvisiones,
                    @TotalDescuentosNomina
                )
                
                SET @SecContratoLiquida = @NuevoSecContrato
            END
            
            SET @ContratosGuardados = @ContratosGuardados + 1
            
            -- Procesar conceptos del contrato
            DECLARE @Conceptos NVARCHAR(MAX) = JSON_QUERY(@ContratoJSON, '$.Conceptos')
            
            DECLARE @ConceptoJSON NVARCHAR(MAX)
            DECLARE concepto_cursor CURSOR FOR
            SELECT value FROM OPENJSON(@Conceptos)
            
            OPEN concepto_cursor
            FETCH NEXT FROM concepto_cursor INTO @ConceptoJSON
            
            WHILE @@FETCH_STATUS = 0
            BEGIN
                -- Variables del concepto
                DECLARE @SecConcepto INT = JSON_VALUE(@ConceptoJSON, '$.SecConcepto')
                DECLARE @SecConceptoP INT = JSON_VALUE(@ConceptoJSON, '$.SecConceptoP')
                DECLARE @SecConceptoP2 INT = JSON_VALUE(@ConceptoJSON, '$.SecConceptoP2')
                DECLARE @NomConcepto VARCHAR(100) = JSON_VALUE(@ConceptoJSON, '$.NomConcepto')
                DECLARE @Valor DECIMAL(18,2) = JSON_VALUE(@ConceptoJSON, '$.Valor')
                DECLARE @Base DECIMAL(18,2) = JSON_VALUE(@ConceptoJSON, '$.Base')
                DECLARE @NomBase VARCHAR(100) = JSON_VALUE(@ConceptoJSON, '$.NomBase')
                DECLARE @EsDescuento BIT = JSON_VALUE(@ConceptoJSON, '$.EsDescuento')
                DECLARE @Cuota INT = 0
                
                -- Si SecConceptoP2 es mayor que cero, consultar la cuota
                IF @SecConceptoP2 > 0
                BEGIN
                    SELECT @Cuota = ISNULL(CuotaActual, 0) 
                    FROM ConceptosP_Contratos 
                    WHERE Sec = @SecConceptoP2
                END
                
                IF @EsDescuento = 0  -- Concepto normal
                BEGIN
                    -- Verificar si existe
                    IF EXISTS (SELECT 1 FROM NominaLiquidaConceptos 
                              WHERE LiquidaContrato = @SecContratoLiquida 
                              AND SecConcepto = @SecConcepto)
                    BEGIN
                        -- Actualizar
                        UPDATE NominaLiquidaConceptos
                        SET Valor = @Valor,
                            Base = @Base,
                            NomConcepto = @NomConcepto,
                            NomBase = @NomBase
                        WHERE LiquidaContrato = @SecContratoLiquida 
                        AND SecConcepto = @SecConcepto
                    END
                    ELSE
                    BEGIN
                        -- Obtener siguiente Sec
                        DECLARE @NuevoSecConcepto INT
                        SELECT @NuevoSecConcepto = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidaConceptos
                        
                        -- Insertar
                        INSERT INTO NominaLiquidaConceptos (
                            Sec, LiquidaContrato, SecConcepto, Valor, Base, 
                            NomConcepto, NomBase
                        )
                        VALUES (
                            @NuevoSecConcepto, @SecContratoLiquida, @SecConcepto, @Valor, @Base,
                            @NomConcepto, @NomBase
                        )
                    END
                END
                ELSE  -- Concepto personal/descuento
                BEGIN
                    -- Verificar si existe
                    IF EXISTS (SELECT 1 FROM NominaLiquidaConceptos 
                              WHERE LiquidaContrato = @SecContratoLiquida 
                              AND SecConceptoP = @SecConceptoP)
                    BEGIN
                        -- Actualizar
                        UPDATE NominaLiquidaConceptos
                        SET Valor = @Valor,
                            Base = @Base,
                            NomConcepto = @NomConcepto,
                            NomBase = @NomBase,
                            SecConceptoP2 = @SecConceptoP2,
                            Cuota = @Cuota
                        WHERE LiquidaContrato = @SecContratoLiquida 
                        AND SecConceptoP = @SecConceptoP
                    END
                    ELSE
                    BEGIN
                        -- Obtener siguiente Sec
                        DECLARE @NuevoSecConceptoP INT
                        SELECT @NuevoSecConceptoP = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidaConceptos
                        
                        -- Insertar
                        INSERT INTO NominaLiquidaConceptos (
                            Sec, LiquidaContrato, SecConceptoP, SecConceptoP2, 
                            Valor, Base, NomConcepto, NomBase, Cuota
                        )
                        VALUES (
                            @NuevoSecConceptoP, @SecContratoLiquida, @SecConceptoP, @SecConceptoP2,
                            @Valor, @Base, @NomConcepto, @NomBase, @Cuota
                        )
                    END
                END
                
                SET @ConceptosGuardados = @ConceptosGuardados + 1
                
                FETCH NEXT FROM concepto_cursor INTO @ConceptoJSON
            END
            
            CLOSE concepto_cursor
            DEALLOCATE concepto_cursor
            
            -- Procesar variables del contrato
            DECLARE @Variables NVARCHAR(MAX) = JSON_QUERY(@ContratoJSON, '$.Variables')
            
            DECLARE @VariableJSON NVARCHAR(MAX)
            DECLARE variable_cursor CURSOR FOR
            SELECT value FROM OPENJSON(@Variables)
            
            OPEN variable_cursor
            FETCH NEXT FROM variable_cursor INTO @VariableJSON
            
            WHILE @@FETCH_STATUS = 0
            BEGIN
                -- Variables de la variable
                DECLARE @Variable INT = JSON_VALUE(@VariableJSON, '$.Variable')
                DECLARE @Cantidad DECIMAL(18,2) = JSON_VALUE(@VariableJSON, '$.Cantidad')
                
                -- Verificar si existe
                IF EXISTS (SELECT 1 FROM NominaLiquidaVariables 
                          WHERE SecLiquidaContrato = @SecContratoLiquida 
                          AND Variable = @Variable)
                BEGIN
                    -- Actualizar
                    UPDATE NominaLiquidaVariables
                    SET Cantidad = @Cantidad
                    WHERE SecLiquidaContrato = @SecContratoLiquida 
                    AND Variable = @Variable
                END
                ELSE
                BEGIN
                    -- Obtener siguiente Sec
                    DECLARE @NuevoSecVariable INT
                    SELECT @NuevoSecVariable = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidaVariables
                    
                    -- Insertar
                    INSERT INTO NominaLiquidaVariables (
                        Sec, SecLiquidaContrato, Variable, Cantidad
                    )
                    VALUES (
                        @NuevoSecVariable, @SecContratoLiquida, @Variable, @Cantidad
                    )
                END
                
                SET @VariablesGuardadas = @VariablesGuardadas + 1
                
                FETCH NEXT FROM variable_cursor INTO @VariableJSON
            END
            
            CLOSE variable_cursor
            DEALLOCATE variable_cursor
            
            FETCH NEXT FROM contrato_cursor INTO @ContratoJSON
        END
        
        CLOSE contrato_cursor
        DEALLOCATE contrato_cursor
        
        COMMIT TRANSACTION
        
        SET @Mensaje = 'Borrador guardado exitosamente'
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
            
        SET @Estado = 'ERROR'
        SET @Mensaje = ERROR_MESSAGE()
        SET @CodigoError = ERROR_NUMBER()
    END CATCH
    
    -- Devolver respuesta
    SELECT 
        @Estado AS Estado,
        'GuardarBorradorNomina' AS Operacion,
        @Mensaje AS Mensaje,
        @SecNominaLiquida AS SecNominaLiquida,
        @ContratosGuardados AS ContratosGuardados,
        @ConceptosGuardados AS ConceptosGuardados,
        @VariablesGuardadas AS VariablesGuardadas,
        @CodigoError AS CodigoError,
        GETDATE() AS FechaHoraServidor
    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LiquidarNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_LiquidarNomina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_LiquidarNomina] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_LiquidarNomina]
    @Datos NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    SET DATEFORMAT DMY;
    
    -- Variables para respuesta (misma nomenclatura que GuardarBorrador)
    DECLARE @Estado VARCHAR(50) = 'SUCCESS'
    DECLARE @Mensaje NVARCHAR(500) = ''
    DECLARE @CodigoError INT = NULL
    DECLARE @ContratosLiquidados INT = 0
    DECLARE @ConceptosLiquidados INT = 0
    DECLARE @VariablesLiquidadas INT = 0
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Parsear JSON
        DECLARE @SecNominaLiquida INT = JSON_VALUE(@Datos, '$.SecNominaLiquida');
        
        -- Variables locales
        DECLARE @SecNominaLiquidada INT;
        DECLARE @SecPeriodo INT;
        
        -- Obtener el periodo de la nómina a liquidar
        SELECT @SecPeriodo = Periodo
        FROM NominaLiquida
        WHERE Sec = @SecNominaLiquida;
        
        -- Validar que existe el borrador
        IF @SecPeriodo IS NULL
        BEGIN
            RAISERROR('No se encontró el borrador de nómina especificado', 16, 1);
            RETURN;
        END
        
        -- Validar que no esté ya liquidado
        IF EXISTS (SELECT 1 FROM NominaLiquidada WHERE Periodo = @SecPeriodo AND Estado <> 'A')
        BEGIN
            RAISERROR('Este periodo ya ha sido liquidado', 16, 1);
            RETURN;
        END
        
        -- Crear nueva nómina liquidada
        SELECT @SecNominaLiquidada = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidada;
        
        INSERT INTO NominaLiquidada (
            Sec, Periodo, OfiNomina, OfiRegistra, Estado, Contabilizada,
            UsuCrea, FechaCrea, TerminalCrea, FechaSys
        )
        SELECT 
            @SecNominaLiquidada, Periodo, OfiNomina, OfiRegistra, 'L', 0,
            USER_NAME(), GETDATE(), HOST_NAME(), GETDATE()
        FROM NominaLiquida
        WHERE Sec = @SecNominaLiquida;
        
        -- Tabla temporal para mapear contratos
        CREATE TABLE #MapeoContratos (
            SecOriginal INT,
            SecNuevo INT,
            Contrato INT
        );
        
        -- Migrar contratos
        INSERT INTO NominaLiquidadaContratos (
            Sec, NominaLiquidada, Contrato, Total, TotalProvisiones,
            TotalFondos, TotalIngresos, TotalDeducciones, TotalDescuentosNomina,
            HorasMes, CargoActual, Comentario, Asignacion
        )
        OUTPUT inserted.Contrato, inserted.Sec INTO #MapeoContratos(Contrato, SecNuevo)
        SELECT 
            ROW_NUMBER() OVER (ORDER BY Sec) + (SELECT ISNULL(MAX(Sec), 0) FROM NominaLiquidadaContratos),
            @SecNominaLiquidada, Contrato, Total, TotalProvisiones,
            TotalFondos, TotalIngresos, TotalDeducciones, TotalDescuentosNomina,
            HorasMes, CargoActual, Comentario, Asignacion
        FROM NominaLiquidaContratos
        WHERE NominaLiquida = @SecNominaLiquida;
        
        -- Contar contratos liquidados
        SET @ContratosLiquidados = @@ROWCOUNT;
        
        -- Actualizar SecOriginal en tabla de mapeo
        UPDATE m
        SET m.SecOriginal = nlc.Sec
        FROM #MapeoContratos m
        INNER JOIN NominaLiquidaContratos nlc ON m.Contrato = nlc.Contrato
        WHERE nlc.NominaLiquida = @SecNominaLiquida;
        
        -- Migrar variables
        INSERT INTO NominaLiquidadaVariables (
            Sec, SecLiquidadaContrato, Variable, Cantidad
        )
        SELECT 
            ROW_NUMBER() OVER (ORDER BY v.Sec) + (SELECT ISNULL(MAX(Sec), 0) FROM NominaLiquidadaVariables),
            m.SecNuevo, v.Variable, v.Cantidad
        FROM NominaLiquidaVariables v
        INNER JOIN #MapeoContratos m ON v.SecLiquidaContrato = m.SecOriginal;
        
        -- Contar variables liquidadas
        SET @VariablesLiquidadas = @@ROWCOUNT;
        
        -- Tabla temporal para mapear variables (necesario para DescripVarPer)
        CREATE TABLE #MapeoVariables (
            SecOriginal INT,
            SecNuevo INT
        );
        
        INSERT INTO #MapeoVariables (SecOriginal, SecNuevo)
        SELECT 
            v.Sec,
            nlv.Sec
        FROM NominaLiquidaVariables v
        INNER JOIN #MapeoContratos m ON v.SecLiquidaContrato = m.SecOriginal
        INNER JOIN NominaLiquidadaVariables nlv ON nlv.SecLiquidadaContrato = m.SecNuevo 
            AND nlv.Variable = v.Variable;
        
        -- Migrar descripciones de variables
        INSERT INTO NominaLiquidaDescripVarPer (
            Sec, FechaHoraInicio, FechaHoraFin, Cantidad, CodVarP, TipoDesc
        )
        SELECT 
            ROW_NUMBER() OVER (ORDER BY d.Sec) + (SELECT ISNULL(MAX(Sec), 0) FROM NominaLiquidaDescripVarPer),
            d.FechaHoraInicio, d.FechaHoraFin, d.Cantidad, mv.SecNuevo, d.TipoDesc
        FROM DescripVarPer d
        INNER JOIN #MapeoVariables mv ON d.CodVarP = mv.SecOriginal;
        
        -- Migrar conceptos y actualizar descuentos por nómina
        DECLARE @SecConcepto INT, @SecConceptoP INT, @SecConceptoP2 INT;
        DECLARE @Valor DECIMAL(18,2), @Cuota INT;
        DECLARE @TotalDescontado DECIMAL(18,2), @TotalDescontar DECIMAL(18,2);
        DECLARE @Vigente BIT;
        DECLARE @NomConcepto NVARCHAR(100), @Base DECIMAL(18,2), @NomBase NVARCHAR(100);
        DECLARE @SecLiquidadaContrato INT;
        
        -- Cursor para procesar conceptos
        DECLARE cur_conceptos CURSOR FOR
        SELECT 
            c.SecConcepto, c.SecConceptoP, c.SecConceptoP2, 
            c.Valor, c.NomConcepto, c.Base, c.NomBase, c.Cuota,
            m.SecNuevo
        FROM NominaLiquidaConceptos c
        INNER JOIN #MapeoContratos m ON c.LiquidaContrato = m.SecOriginal;
        
        OPEN cur_conceptos;
        
        FETCH NEXT FROM cur_conceptos INTO 
            @SecConcepto, @SecConceptoP, @SecConceptoP2, 
            @Valor, @NomConcepto, @Base, @NomBase, @Cuota, @SecLiquidadaContrato;
        
        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Insertar concepto liquidado
            INSERT INTO NominaLiquidadaConceptos (
                Sec, LiquidadaContrato, SecConcepto, SecConceptoP, SecConceptoP2,
                Valor, NomConcepto, Base, NomBase, Cuota
            )
            VALUES (
                (SELECT ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidadaConceptos),
                @SecLiquidadaContrato, @SecConcepto, @SecConceptoP, @SecConceptoP2,
                @Valor, @NomConcepto, @Base, @NomBase, @Cuota
            );
            
            -- Incrementar contador de conceptos
            SET @ConceptosLiquidados = @ConceptosLiquidados + 1;
            
            -- Si es descuento por nómina, actualizar ConceptosP_Contratos
            IF @SecConceptoP IS NOT NULL AND @SecConceptoP > 0 
               AND @SecConceptoP2 IS NOT NULL AND @SecConceptoP2 > 0
            BEGIN
                -- Obtener valores actuales
                SELECT 
                    @TotalDescontado = ISNULL(TotalDescontado, 0),
                    @TotalDescontar = ISNULL(TotalDescontar, 0)
                FROM ConceptosP_Contratos
                WHERE Sec = @SecConceptoP2;
                
                -- Calcular nuevo total descontado
                SET @TotalDescontado = @TotalDescontado + @Valor;
                
                -- Determinar si sigue vigente
                IF @TotalDescontado >= @TotalDescontar
                    SET @Vigente = 0;
                ELSE
                    SET @Vigente = 1;
                
                -- Actualizar ConceptosP_Contratos
                UPDATE ConceptosP_Contratos
                SET TotalDescontado = @TotalDescontado,
                    Vigente = @Vigente,
                    CuotaActual = ISNULL(@Cuota, 0) + 1
                WHERE Sec = @SecConceptoP2;
            END
            
            FETCH NEXT FROM cur_conceptos INTO 
                @SecConcepto, @SecConceptoP, @SecConceptoP2, 
                @Valor, @NomConcepto, @Base, @NomBase, @Cuota, @SecLiquidadaContrato;
        END
        
        CLOSE cur_conceptos;
        DEALLOCATE cur_conceptos;
        
        -- Actualizar estado del periodo a Liquidado
        UPDATE PeriodosLiquidacion
        SET Estado = 'L'
        WHERE Sec = @SecPeriodo;
        
        -- Limpiar tablas temporales
        DROP TABLE #MapeoContratos;
        DROP TABLE #MapeoVariables;
        
        -- Llamar al procedimiento de eliminar borrador
        DECLARE @DatosEliminar NVARCHAR(MAX) = N'{"SecNominaLiquida": ' + CAST(@SecNominaLiquida AS NVARCHAR(10)) + '}';
        EXEC SP_EliminarBorradorNomina_NoResponse @DatosEliminar;
        
        COMMIT TRANSACTION;
        
        SET @Mensaje = 'Nómina liquidada exitosamente';
               
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        SET @Estado = 'ERROR';
        SET @Mensaje = ERROR_MESSAGE();
        SET @CodigoError = ERROR_NUMBER();
    END CATCH
    
    -- Devolver respuesta con misma nomenclatura que GuardarBorrador
    SELECT 
        @Estado AS Estado,
        'LiquidarNomina' AS Operacion,
        @Mensaje AS Mensaje,
        @SecNominaLiquidada AS SecNominaLiquidada,
        @ContratosLiquidados AS ContratosLiquidados,
        @ConceptosLiquidados AS ConceptosLiquidados,
        @VariablesLiquidadas AS VariablesLiquidadas,
        @CodigoError AS CodigoError,
        GETDATE() AS FechaHoraServidor
    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ModNomFormulas]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModNomFormulas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_ModNomFormulas] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_ModNomFormulas]
    @NomVariable NVARCHAR(200),
    @NuevoNomVariable NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Actualizar fórmulas en ConfigConceptos
    UPDATE ConfigConceptos 
    SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)), '[' + @NomVariable + ']', '[' + @NuevoNomVariable + ']')
    WHERE Formula LIKE '%[' + @NomVariable + ']%';
    
    -- Actualizar ValMaxDescuento en ConceptosPersonales
    UPDATE ConceptosPersonales 
    SET ValMaxDescuento = REPLACE(SUBSTRING(ValMaxDescuento, 1, DATALENGTH(ValMaxDescuento)), '[' + @NomVariable + ']', '[' + @NuevoNomVariable + ']')
    WHERE ValMaxDescuento LIKE '%[' + @NomVariable + ']%';
    
    -- Actualizar fórmulas en BasesConceptos
    UPDATE BasesConceptos 
    SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)), '[' + @NomVariable + ']', '[' + @NuevoNomVariable + ']')
    WHERE Formula LIKE '%[' + @NomVariable + ']%';
    
    -- Actualizar ValorMaxDescontar en Plantillas
    UPDATE Plantillas 
    SET ValorMaxDescontar = REPLACE(SUBSTRING(ValorMaxDescontar, 1, DATALENGTH(ValorMaxDescontar)), '[' + @NomVariable + ']', '[' + @NuevoNomVariable + ']')
    WHERE ValorMaxDescontar LIKE '%[' + @NomVariable + ']%';
    
    -- Actualizar fórmulas en TiposContratos_ConceptosNomina
    UPDATE TiposContratos_ConceptosNomina 
    SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)), '[' + @NomVariable + ']', '[' + @NuevoNomVariable + ']')
    WHERE Formula LIKE '%[' + @NomVariable + ']%';
    
    -- Actualizar fórmulas en ConfigProvisiones
    UPDATE ConfigProvisiones 
    SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)), '[' + @NomVariable + ']', '[' + @NuevoNomVariable + ']')
    WHERE Formula LIKE '%[' + @NomVariable + ']%';
    
    -- Actualizar BaseCalculo en TiposContratos_ConceptosNomina
    UPDATE TiposContratos_ConceptosNomina 
    SET BaseCalculo = @NuevoNomVariable
    WHERE BaseCalculo = @NomVariable;
    
    -- Actualizar Base en ConceptosNomina
    UPDATE ConceptosNomina 
    SET Base = @NuevoNomVariable
    WHERE Base = @NomVariable;
    
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertCargo]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertCargo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertCargo] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_UpsertCargo]
    @Datos NVARCHAR(MAX) -- JSON con toda la información del cargo
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    DECLARE @SecCargo INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    DECLARE @MaxAsignacionFecha DATE;
    DECLARE @MaxAsignacionValor MONEY;
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @CodCargo VARCHAR(20);
    DECLARE @Denominacion VARCHAR(100);
    DECLARE @Descripcion VARCHAR(1000);
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @CodCargo = JSON_VALUE(@Datos, '$.CodCargo'),
            @Denominacion = JSON_VALUE(@Datos, '$.Denominacion'),
            @Descripcion = JSON_VALUE(@Datos, '$.Descripcion'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN
        IF @Sec > 0
        BEGIN
            SET @IsUpdate = 1;
            SET @SecCargo = @Sec;
        END
        ELSE
        BEGIN
            SET @IsUpdate = 0;
        END
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @CodCargo IS NULL OR @CodCargo = ''
        BEGIN
            SET @ErrorMsg = 'El código del cargo es requerido';
            THROW 50001, @ErrorMsg, 1;
        END
        
        IF @Denominacion IS NULL OR @Denominacion = ''
        BEGIN
            SET @ErrorMsg = 'La denominación del cargo es requerida';
            THROW 50002, @ErrorMsg, 1;
        END
        
        IF @Descripcion IS NULL OR @Descripcion = ''
        BEGIN
            SET @ErrorMsg = 'La descripción del cargo es requerida';
            THROW 50003, @ErrorMsg, 1;
        END
        
        -- 5. VALIDACIONES ESPECÍFICAS SEGÚN OPERACIÓN
        
        IF @IsUpdate = 1
        BEGIN
            -- Para actualización: verificar que el cargo existe
            IF NOT EXISTS (SELECT 1 FROM cargos WHERE Sec = @Sec)
            BEGIN
                SET @ErrorMsg = 'El cargo con Sec = ' + CAST(@Sec AS VARCHAR) + ' no existe';
                THROW 50004, @ErrorMsg, 1;
            END
        END
        ELSE
        BEGIN
            -- Para inserción: verificar que no existe el CodCargo
            IF EXISTS (SELECT 1 FROM cargos WHERE CodCargo = @CodCargo)
            BEGIN
                SET @ErrorMsg = 'Ya existe un cargo con el código: ' + @CodCargo;
                THROW 50005, @ErrorMsg, 1;
            END
        END
        
        -- Validar que todas las funciones existen
        IF EXISTS (
            SELECT 1 
            FROM OPENJSON(@Datos, '$.Funciones') 
            WHERE JSON_VALUE(value, '$.CodFuncion') NOT IN (
                SELECT CAST(Sec AS VARCHAR) FROM Funciones
            )
        )
        BEGIN
            SET @ErrorMsg = 'Una o más funciones no existen';
            THROW 50006, @ErrorMsg, 1;
        END
        
        -- 6. UPSERT DEL CARGO
        
        IF @IsUpdate = 1
        BEGIN
            -- ACTUALIZACIÓN
            UPDATE cargos SET
                CodCargo = @CodCargo,
                Denominacion = @Denominacion,
                Descripcion = @Descripcion
            WHERE Sec = @Sec;
        END
        ELSE
        BEGIN
            -- INSERCIÓN
            INSERT INTO cargos (CodCargo, Denominacion, Descripcion)
            VALUES (@CodCargo, @Denominacion, @Descripcion);
            
            SET @SecCargo = SCOPE_IDENTITY();
        END
        
        -- 7. MANEJAR FUNCIONES DEL CARGO
        
        -- Eliminar funciones existentes
        DELETE FROM Cargo_Funciones WHERE Cargo = @SecCargo;
        
        -- Insertar nuevas funciones si hay
        IF EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.Funciones'))
        BEGIN
            INSERT INTO Cargo_Funciones (Sec, Cargo, CodFuncion)
            SELECT 
                ROW_NUMBER() OVER (ORDER BY JSON_VALUE(value, '$.CodFuncion')) + 
                ISNULL((SELECT MAX(Sec) FROM Cargo_Funciones), 0),
                @SecCargo,
                CAST(JSON_VALUE(value, '$.CodFuncion') AS INT)
            FROM OPENJSON(@Datos, '$.Funciones');
        END
        
        -- 8. MANEJAR ASIGNACIONES DEL CARGO
        
        -- Eliminar asignaciones existentes
        DELETE FROM Cargo_Asignaciones WHERE Cargo = @SecCargo;
        
        -- Insertar nuevas asignaciones si hay
        IF EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.Asignaciones'))
        BEGIN
            INSERT INTO Cargo_Asignaciones (Sec, Fecha, Cargo, Asignacion)
            SELECT 
                ROW_NUMBER() OVER (ORDER BY CAST(JSON_VALUE(value, '$.Fecha') AS DATE)) + 
                ISNULL((SELECT MAX(Sec) FROM Cargo_Asignaciones), 0),
                CAST(JSON_VALUE(value, '$.Fecha') AS DATE),
                @SecCargo,
                CAST(JSON_VALUE(value, '$.Asignacion') AS MONEY)
            FROM OPENJSON(@Datos, '$.Asignaciones');
            
            -- Obtener la asignación más reciente
            SELECT TOP 1 
                @MaxAsignacionFecha = Fecha,
                @MaxAsignacionValor = Asignacion
            FROM Cargo_Asignaciones
            WHERE Cargo = @SecCargo
            ORDER BY Fecha DESC;
            
            -- Actualizar contratos que usan asignación del cargo
            UPDATE C 
            SET C.Asignacion = @MaxAsignacionValor
            FROM Contratos C 
            INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.Sec
            WHERE C.UsaAsginaCargo = 1 
            AND CC.Cargo = @SecCargo;
        END
        ELSE
        BEGIN
            -- Si no hay asignaciones, poner en 0 los contratos que usan asignación del cargo
            UPDATE C 
            SET C.Asignacion = 0
            FROM Contratos C 
            INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.Sec
            WHERE C.UsaAsginaCargo = 1 
            AND CC.Cargo = @SecCargo;
        END
        
        COMMIT TRANSACTION;
        
        -- 9. RETORNAR RESPUESTA EN JSON
SELECT (
    SELECT 
        'SUCCESS' as Estado,
        CASE WHEN @IsUpdate = 1 THEN 'UPDATED' ELSE 'INSERTED' END as Operacion,
        'Cargo guardado exitosamente' as Mensaje,
        GETDATE() as FechaHoraServidor,
        JSON_QUERY((  -- Agregar JSON_QUERY aquí
            SELECT 
                c.Sec,
                c.CodCargo,
                c.Denominacion,
                c.Descripcion,
                (
                    SELECT 
                        cf.Sec,
                        cf.CodFuncion,
                        f.DetalleFuncion
                    FROM Cargo_Funciones cf
                    INNER JOIN Funciones f ON cf.CodFuncion = f.Sec
                    WHERE cf.Cargo = c.Sec
                    FOR JSON PATH
                ) as Funciones,
                (
                    SELECT 
                        ca.Sec,
                        ca.Fecha,
                        ca.Asignacion
                    FROM Cargo_Asignaciones ca
                    WHERE ca.Cargo = c.Sec
                    ORDER BY ca.Fecha
                    FOR JSON PATH
                ) as Asignaciones,
                ISNULL(@MaxAsignacionValor, 0) as AsignacionActual,
                (
                    SELECT COUNT(*) 
                    FROM Contratos ct
                    INNER JOIN Contrato_Cargos cc ON ct.CargoActual = cc.Sec
                    WHERE cc.Cargo = c.Sec
                ) as ContratosAfectados
            FROM cargos c
            WHERE c.Sec = @SecCargo
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        )) as Cargo  -- Cerrar JSON_QUERY
    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
       -- Retornar error en JSON
SELECT (
    SELECT 
        'ERROR' as Estado,
        'ERROR' as Operacion,
        @ErrorMessage as Mensaje,
        @ErrorNumber as CodigoError,
        GETDATE() as FechaHoraServidor,
        JSON_QUERY(@Datos) as DatosEnviados  -- Agregar JSON_QUERY aquí también
    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertConceptosNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertConceptosNomina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertConceptosNomina] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_UpsertConceptosNomina]
    @Datos NVARCHAR(MAX) -- JSON con toda la información del concepto
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    
    DECLARE @SecConcepto INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    DECLARE @NomConceptoAnterior NVARCHAR(200);
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @NomConcepto NVARCHAR(200);
    DECLARE @Vigente CHAR(1);
    DECLARE @Formula NVARCHAR(200);
    DECLARE @Tipo INT;
    DECLARE @PeriodosLiquida NVARCHAR(20);
    DECLARE @Base NVARCHAR(200);
    DECLARE @Redondea INT;
    DECLARE @Fondo INT;
    DECLARE @Clasificacion INT;
    DECLARE @EsRetencion BIT;
    DECLARE @EsPredeterminado BIT;
    DECLARE @CodDian NVARCHAR(20);
    DECLARE @Orden INT;
    DECLARE @Usuario NVARCHAR(20);
    DECLARE @Terminal NVARCHAR(50);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @NomConcepto = JSON_VALUE(@Datos, '$.NomConcepto'),
            @Vigente = JSON_VALUE(@Datos, '$.Vigente'),
            @Formula = JSON_VALUE(@Datos, '$.Formula'),
            @Tipo = JSON_VALUE(@Datos, '$.Tipo'),
            @PeriodosLiquida = JSON_VALUE(@Datos, '$.PeriodosLiquida'),
            @Base = JSON_VALUE(@Datos, '$.Base'),
            @Redondea = JSON_VALUE(@Datos, '$.Redondea'),
            @Fondo = JSON_VALUE(@Datos, '$.Fondo'),
            @Clasificacion = JSON_VALUE(@Datos, '$.Clasificacion'),
            @EsRetencion = CASE WHEN JSON_VALUE(@Datos, '$.EsRetencion') = 'true' THEN 1 ELSE 0 END,
            @EsPredeterminado = CASE WHEN JSON_VALUE(@Datos, '$.EsPredeterminado') = 'true' THEN 1 ELSE 0 END,
            @CodDian = JSON_VALUE(@Datos, '$.CodDian'),
            @Orden = JSON_VALUE(@Datos, '$.Orden'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN
        IF @Sec > 0
        BEGIN
            SET @IsUpdate = 1;
            SET @SecConcepto = @Sec;
            
            -- Guardar el nombre anterior para actualizar fórmulas si cambia
            SELECT @NomConceptoAnterior = NomConcepto 
            FROM ConceptosNomina 
            WHERE Sec = @Sec;
        END
        ELSE
        BEGIN
            SET @IsUpdate = 0;
            -- Obtener el siguiente Sec disponible
            SELECT @SecConcepto = ISNULL(MAX(Sec), 0) + 1 FROM ConceptosNomina;
        END
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @NomConcepto IS NULL OR @NomConcepto = ''
        BEGIN
            SET @ErrorMsg = 'El nombre del concepto es requerido';
            THROW 50001, @ErrorMsg, 1;
        END
        
        IF @Vigente IS NULL OR @Vigente = ''
        BEGIN
            SET @ErrorMsg = 'El estado de vigencia es requerido';
            THROW 50002, @ErrorMsg, 1;
        END
        
        -- 5. VALIDACIONES ESPECÍFICAS SEGÚN OPERACIÓN
        
        IF @IsUpdate = 1
        BEGIN
            -- Para actualización: verificar que el concepto existe
            IF NOT EXISTS (SELECT 1 FROM ConceptosNomina WHERE Sec = @Sec)
            BEGIN
                SET @ErrorMsg = 'El concepto con Sec = ' + CAST(@Sec AS VARCHAR) + ' no existe';
                THROW 50003, @ErrorMsg, 1;
            END
        END
        ELSE
        BEGIN
            -- Para inserción: verificar que no existe el nombre
            IF EXISTS (SELECT 1 FROM ConceptosNomina WHERE NomConcepto = @NomConcepto)
            BEGIN
                SET @ErrorMsg = 'Ya existe un concepto con el nombre: ' + @NomConcepto;
                THROW 50004, @ErrorMsg, 1;
            END
        END
        
        -- Validar tipo si se proporciona
        IF @Tipo IS NOT NULL AND NOT EXISTS (SELECT 1 FROM TiposConceptosNomina WHERE Sec = @Tipo)
        BEGIN
            SET @ErrorMsg = 'El tipo de concepto especificado no existe';
            THROW 50005, @ErrorMsg, 1;
        END
        
        -- Validar clasificación si se proporciona
        IF @Clasificacion IS NOT NULL AND NOT EXISTS (SELECT 1 FROM ClasConceptosNomina WHERE Sec = @Clasificacion)
        BEGIN
            SET @ErrorMsg = 'La clasificación especificada no existe';
            THROW 50006, @ErrorMsg, 1;
        END
        
        -- 6. UPSERT DEL CONCEPTO
        
        IF @IsUpdate = 1
        BEGIN
            -- ACTUALIZACIÓN
            UPDATE ConceptosNomina SET
                NomConcepto = @NomConcepto,
                Vigente = @Vigente,
                Formula = @Formula,
                Tipo = @Tipo,
                PeriodosLiquida = @PeriodosLiquida,
                Base = @Base,
                Redondea = @Redondea,
                Fondo = @Fondo,
                Clasificacion = @Clasificacion,
                EsRetencion = @EsRetencion,
                EsPredeterminado = @EsPredeterminado,
                CodDian = @CodDian,
                Orden = @Orden
            WHERE Sec = @Sec;
            
            -- Si cambió el nombre, actualizar las fórmulas
            IF @NomConceptoAnterior <> @NomConcepto
            BEGIN
                EXEC SP_ModNomFormulas @NomConceptoAnterior, @NomConcepto;
            END
        END
        ELSE
        BEGIN
            -- INSERCIÓN
            INSERT INTO ConceptosNomina (
                Sec, NomConcepto, Vigente, Formula, Tipo, PeriodosLiquida, 
                Base, Redondea, Fondo, Clasificacion, EsRetencion, 
                EsPredeterminado, CodDian, Orden
            )
            VALUES (
                @SecConcepto, @NomConcepto, @Vigente, @Formula, @Tipo, @PeriodosLiquida,
                @Base, @Redondea, @Fondo, @Clasificacion, @EsRetencion,
                @EsPredeterminado, @CodDian, @Orden
            );
        END
        
        -- 7. CREAR REGISTROS EN TABLAS RELACIONADAS (solo para nuevos conceptos)
        
        IF @IsUpdate = 0
        BEGIN
            DECLARE @SecConfig INT;
            DECLARE @SecProvision INT;
            DECLARE @SecTipoContrato INT;
            
            -- Obtener el máximo Sec actual de ConfigConceptos
            SELECT @SecConfig = ISNULL(MAX(Sec), 0) FROM ConfigConceptos;
            
            -- Insertar en ConfigConceptos para todas las nóminas activas
            INSERT INTO ConfigConceptos (Sec, Nomina, Concepto, Formula, PeriodosLiquida, CuentaContable, ConceptoR, ContraPartida)
            SELECT 
                @SecConfig + ROW_NUMBER() OVER (ORDER BY n.Sec),
                n.Sec,
                @SecConcepto,
                @Formula,
                @PeriodosLiquida,
                NULL, -- CuentaContable se configura después
                NULL, -- ConceptoR
                NULL  -- ContraPartida
            FROM Nominas n
            WHERE NOT EXISTS (
                SELECT 1 FROM ConfigConceptos cc 
                WHERE cc.Concepto = @SecConcepto AND cc.Nomina = n.Sec
            );
            
            -- Si es un concepto de tipo provisión, insertar también en ConfigProvisiones
            IF EXISTS (SELECT 1 FROM TiposConceptosNomina WHERE Sec = @Tipo AND NomTipo LIKE '%provision%')
            BEGIN
                -- Obtener el máximo Sec actual de ConfigProvisiones
                SELECT @SecProvision = ISNULL(MAX(Sec), 0) FROM ConfigProvisiones;
                
                INSERT INTO ConfigProvisiones (Sec, Concepto, Formula, SemestresLiquida, CuentaContable, Nomina)
                SELECT 
                    @SecProvision + ROW_NUMBER() OVER (ORDER BY n.Sec),
                    @SecConcepto,
                    @Formula,
                    '1,2', -- Por defecto liquida ambos semestres
                    NULL,  -- CuentaContable se configura después
                    n.Sec
                FROM Nominas n
                WHERE NOT EXISTS (
                    SELECT 1 FROM ConfigProvisiones cp 
                    WHERE cp.Concepto = @SecConcepto AND cp.Nomina = n.Sec
                );
            END
            
            -- Obtener el máximo Sec actual de TiposContratos_ConceptosNomina
            SELECT @SecTipoContrato = ISNULL(MAX(Sec), 0) FROM TiposContratos_ConceptosNomina;
            
            -- Insertar en TiposContratos_ConceptosNomina para todos los tipos de contrato
            INSERT INTO TiposContratos_ConceptosNomina (Sec, Concepto, TipoContrato, Formula, BaseCalculo, SeLiquida, CuentaContable)
            SELECT 
                @SecTipoContrato + ROW_NUMBER() OVER (ORDER BY tc.Sec),
                @SecConcepto,
                tc.Sec,
                @Formula,
                @Base,
                0, -- Por defecto no se liquida, se debe configurar después
                NULL -- CuentaContable se configura después
            FROM CAT_TipoContratos tc
            WHERE NOT EXISTS (
                SELECT 1 FROM TiposContratos_ConceptosNomina tccn 
                WHERE tccn.Concepto = @SecConcepto AND tccn.TipoContrato = tc.Sec
            );
        END
        
        COMMIT TRANSACTION;
        
        -- 8. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                CASE WHEN @IsUpdate = 1 THEN 'UPDATED' ELSE 'INSERTED' END as Operacion,
                'Concepto de nómina guardado exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY((
                    SELECT 
                        cn.Sec,
                        cn.NomConcepto,
                        cn.Vigente,
                        cn.Formula,
                        cn.Tipo,
                        tcn.NomTipo as NombreTipo,
                        cn.PeriodosLiquida,
                        cn.Base,
                        cn.Redondea,
                        cn.Fondo,
                        cn.Clasificacion,
                        ccn.Nom as NombreClasificacion,
                        cn.EsRetencion,
                        cn.EsPredeterminado,
                        cn.CodDian,
                        cn.Orden,
                        (
                            SELECT COUNT(*) 
                            FROM ConfigConceptos 
                            WHERE Concepto = cn.Sec
                        ) as TotalNominasConfiguradas,
                        (
                            SELECT COUNT(*) 
                            FROM ConfigProvisiones 
                            WHERE Concepto = cn.Sec
                        ) as TotalProvisionesConfiguradas,
                        (
                            SELECT COUNT(*) 
                            FROM TiposContratos_ConceptosNomina 
                            WHERE Concepto = cn.Sec
                        ) as TotalTiposContratoConfigurados
                    FROM ConceptosNomina cn
                    LEFT JOIN TiposConceptosNomina tcn ON cn.Tipo = tcn.Sec
                    LEFT JOIN ClasConceptosNomina ccn ON cn.Clasificacion = ccn.Sec
                    WHERE cn.Sec = @SecConcepto
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as ConceptoNomina
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertContrato]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertContrato]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertContrato] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_UpsertContrato]
    @Datos NVARCHAR(MAX) -- JSON con toda la información del contrato
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
	   SET DATEFORMAT DMY;  -- Agregar esta línea
    
    DECLARE @SecEmpleado INT;
    DECLARE @SecContratoResult INT;
    DECLARE @CargoActual INT = NULL;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @Oficina SMALLINT;
    DECLARE @CodContrato INT;
    DECLARE @IdentificacionEmpleado BIGINT;
    DECLARE @TipoContrato SMALLINT;
    DECLARE @HorasMes SMALLINT;
    DECLARE @FechaInicio DATETIME;
    DECLARE @FechaFin DATETIME;
    DECLARE @Dependencia SMALLINT;
    DECLARE @Plantilla INT;
    DECLARE @PerfilCuentas INT;
    DECLARE @Nomina INT;
    DECLARE @Asignacion MONEY;
    DECLARE @IdContrato VARCHAR(50);
    DECLARE @AsignacionCargo VARCHAR(1);
    DECLARE @UsaAsginaCargo BIT;
    DECLARE @TipoTrabajador VARCHAR(10);
    DECLARE @SubTipoTrabajador VARCHAR(10);
    DECLARE @SalarioIntegral VARCHAR(10);
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    DECLARE @TotalPorcentaje DECIMAL(18,1) = 0;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @Oficina = JSON_VALUE(@Datos, '$.Oficina'),
            @CodContrato = JSON_VALUE(@Datos, '$.CodContrato'),
            @IdentificacionEmpleado = JSON_VALUE(@Datos, '$.IdentificacionEmpleado'),
            @TipoContrato = JSON_VALUE(@Datos, '$.TipoContrato'),
            @HorasMes = ISNULL(JSON_VALUE(@Datos, '$.HorasMes'), 0),
            @FechaInicio = JSON_VALUE(@Datos, '$.FechaInicio'),
            @FechaFin = JSON_VALUE(@Datos, '$.FechaFin'),
            @Dependencia = JSON_VALUE(@Datos, '$.Dependencia'),
            @Plantilla = JSON_VALUE(@Datos, '$.Plantilla'),
            @PerfilCuentas = JSON_VALUE(@Datos, '$.PerfilCuentas'),
            @Nomina = JSON_VALUE(@Datos, '$.Nomina'),
            @Asignacion = JSON_VALUE(@Datos, '$.Asignacion'),
            @IdContrato = JSON_VALUE(@Datos, '$.IdContrato'),
            @AsignacionCargo = JSON_VALUE(@Datos, '$.AsignacionCargo'),
            @UsaAsginaCargo = JSON_VALUE(@Datos, '$.UsaAsginaCargo'),
            @TipoTrabajador = JSON_VALUE(@Datos, '$.TipoTrabajador'),
            @SubTipoTrabajador = JSON_VALUE(@Datos, '$.SubTipoTrabajador'),
            @SalarioIntegral = JSON_VALUE(@Datos, '$.SalarioIntegral'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN
        IF @Sec > 0
        BEGIN
            SET @IsUpdate = 1;
            SET @SecContratoResult = @Sec;
        END
        ELSE
        BEGIN
            SET @IsUpdate = 0;
            -- Para inserción: calcular el próximo Sec disponible
            SELECT @SecContratoResult = ISNULL(MAX(Sec), 0) + 1 
            FROM Contratos;
        END
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @FechaInicio IS NULL
        BEGIN
            SET @ErrorMsg = 'La fecha de inicio de contrato no puede estar vacía.';
            THROW 50001, @ErrorMsg, 1;
        END
        
        IF @IdentificacionEmpleado IS NULL
        BEGIN
            SET @ErrorMsg = 'La identificación del empleado es requerida.';
            THROW 50002, @ErrorMsg, 1;
        END
        
        IF @Usuario IS NULL OR @Usuario = ''
        BEGIN
            SET @ErrorMsg = 'El usuario es requerido.';
            THROW 50003, @ErrorMsg, 1;
        END
        
        -- Validar que existe el empleado por identificación
        SELECT @SecEmpleado = Sec 
        FROM Empleados 
        WHERE Identificacion = @IdentificacionEmpleado;
        
        IF @SecEmpleado IS NULL
        BEGIN
            SET @ErrorMsg = 'No existe un empleado con la identificación: ' + CAST(@IdentificacionEmpleado AS VARCHAR);
            THROW 50004, @ErrorMsg, 1;
        END
        
        -- Validar centros de costo
        IF NOT EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.CentrosCosto'))
        BEGIN
            SET @ErrorMsg = 'Debe ingresar al menos un centro de costos';
            THROW 50005, @ErrorMsg, 1;
        END
        
        -- Validar porcentajes de centros de costo
        SELECT @TotalPorcentaje = SUM(CAST(JSON_VALUE(value, '$.Porcentaje') AS DECIMAL(18,1)))
        FROM OPENJSON(@Datos, '$.CentrosCosto');
        
        IF @TotalPorcentaje <> 0 AND @TotalPorcentaje <> 100
        BEGIN
            SET @ErrorMsg = 'La suma de porcentajes debe ser 0 o 100%. Actual: ' + CAST(@TotalPorcentaje AS VARCHAR);
            THROW 50006, @ErrorMsg, 1;
        END
        
        -- Validar que todos los centros de costo existen
        IF EXISTS (
            SELECT 1 
            FROM OPENJSON(@Datos, '$.CentrosCosto') 
            WHERE JSON_VALUE(value, '$.CentroCosto') NOT IN (
                SELECT CAST(Sec AS VARCHAR) FROM CT_CentroCostos WHERE Estado = '1'
            )
        )
        BEGIN
            SET @ErrorMsg = 'Uno o más centros de costo no existen o no están vigentes';
            THROW 50007, @ErrorMsg, 1;
        END
        
        -- Si hay cargos, validar que existen
        IF EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.Cargos'))
        BEGIN
            IF EXISTS (
                SELECT 1 
                FROM OPENJSON(@Datos, '$.Cargos') 
                WHERE JSON_VALUE(value, '$.Cargo') NOT IN (
                    SELECT CAST(Sec AS VARCHAR) FROM cargos
                )
            )
            BEGIN
                SET @ErrorMsg = 'Uno o más cargos no existen';
                THROW 50008, @ErrorMsg, 1;
            END
        END
-- 5. VALIDACIONES ESPECÍFICAS SEGÚN OPERACIÓN

IF @IsUpdate = 1
BEGIN
    -- Para actualización: verificar que el contrato existe
    IF NOT EXISTS (SELECT 1 FROM Contratos WHERE Sec = @Sec)
    BEGIN
        SET @ErrorMsg = 'El contrato con Sec = ' + CAST(@Sec AS VARCHAR) + ' no existe';
        THROW 50009, @ErrorMsg, 1;
    END
    
    -- Validar que no existe otro contrato con el mismo CodContrato
    IF EXISTS (SELECT 1 FROM Contratos WHERE IdContrato = @IdContrato AND Sec <> @Sec)
    BEGIN
        SET @ErrorMsg = 'Ya existe otro contrato con el código: ' + CAST(@IdContrato AS VARCHAR);
        THROW 50011, @ErrorMsg, 1;
    END
    
    -- Validar que no existe otro contrato con el mismo IdContrato
    IF @IdContrato IS NOT NULL AND @IdContrato <> '' AND 
       EXISTS (SELECT 1 FROM Contratos WHERE IdContrato = @IdContrato AND Sec <> @Sec)
    BEGIN
        SET @ErrorMsg = 'Ya existe otro contrato con el IdContrato: ' + @IdContrato;
        THROW 50012, @ErrorMsg, 1;
    END
END
ELSE
BEGIN
    -- Para inserción: verificar que no existe el CodContrato
    IF EXISTS (SELECT 1 FROM Contratos WHERE IdContrato = @IdContrato)
    BEGIN
        SET @ErrorMsg = 'Ya existe un contrato con el código: ' + CAST(@IdContrato AS VARCHAR);
        THROW 50010, @ErrorMsg, 1;
    END
    
    -- Para inserción: verificar que no existe el IdContrato
    IF @IdContrato IS NOT NULL AND @IdContrato <> '' AND 
       EXISTS (SELECT 1 FROM Contratos WHERE IdContrato = @IdContrato)
    BEGIN
        SET @ErrorMsg = 'Ya existe un contrato con el IdContrato: ' + @IdContrato;
        THROW 50013, @ErrorMsg, 1;
    END
END
        
        -- Obtener el cargo actual (el más reciente si hay cargos)
        SELECT TOP 1 @CargoActual = CAST(JSON_VALUE(value, '$.Cargo') AS INT)
        FROM OPENJSON(@Datos, '$.Cargos')
        ORDER BY JSON_VALUE(value, '$.FechaInicio') DESC;
        
        -- 6. UPSERT DEL CONTRATO
        
        IF @IsUpdate = 1
        BEGIN
            -- ACTUALIZACIÓN
            UPDATE Contratos SET
                Oficina = @Oficina,
                CodContrato = @Sec,
                Empleado = @SecEmpleado,
                TipoContrato = @TipoContrato,
                HorasMes = @HorasMes,
                FechaInicio = @FechaInicio,
                FechaFin = @FechaFin,
                Dependencia = @Dependencia,
                Plantilla = @Plantilla,
                PerfilCuentas = @PerfilCuentas,
                Nomina = @Nomina,
                Asignacion = @Asignacion,
                IdContrato = @IdContrato,
                AsignacionCargo = @AsignacionCargo,
                UsaAsginaCargo = @UsaAsginaCargo,
                TipoTrabajador = @TipoTrabajador,
                SubTipoTrabajador = @SubTipoTrabajador,
                SalarioIntegral = @SalarioIntegral,
                CargoActual = @CargoActual
            WHERE Sec = @Sec;
        END
        ELSE
        BEGIN
            -- INSERCIÓN con Sec calculado
            INSERT INTO Contratos (
                Sec, Oficina, CodContrato, Empleado, TipoContrato, HorasMes,
                FechaInicio, FechaFin, Dependencia, Plantilla, PerfilCuentas,
                Nomina, Asignacion, IdContrato, AsignacionCargo, UsaAsginaCargo,
                TipoTrabajador, SubTipoTrabajador, SalarioIntegral, CargoActual,
                Terminado, Aprendiz
            )
            VALUES (
                @SecContratoResult, @Oficina, @SecContratoResult, @SecEmpleado, @TipoContrato, @HorasMes,
                @FechaInicio, @FechaFin, @Dependencia, @Plantilla, @PerfilCuentas,
                @Nomina, @Asignacion, @IdContrato, @AsignacionCargo, @UsaAsginaCargo,
                @TipoTrabajador, @SubTipoTrabajador, @SalarioIntegral, @CargoActual,
                0, 0
            );
        END
        
        -- 7. MANEJAR CENTROS DE COSTO
        
        -- Eliminar centros de costo existentes
        DELETE FROM Contratos_CentroCostos WHERE Contrato = @SecContratoResult;
        
        -- Insertar nuevos centros de costo con Sec calculado
        INSERT INTO Contratos_CentroCostos (Sec, Contrato, CentroCosto, Porcentaje)
        SELECT 
            ROW_NUMBER() OVER (ORDER BY JSON_VALUE(value, '$.CentroCosto')) + 
            ISNULL((SELECT MAX(Sec) FROM Contratos_CentroCostos), 0),
            @SecContratoResult,
            CAST(JSON_VALUE(value, '$.CentroCosto') AS SMALLINT),
            CAST(JSON_VALUE(value, '$.Porcentaje') AS DECIMAL(18,1))
        FROM OPENJSON(@Datos, '$.CentrosCosto');
        
        -- 8. MANEJAR CARGOS DEL CONTRATO
        
        -- Eliminar cargos existentes
        DELETE FROM Contrato_Cargos WHERE Contrato = @SecContratoResult;
        
        -- Insertar nuevos cargos si hay
        IF EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.Cargos'))
        BEGIN
            INSERT INTO Contrato_Cargos (
                Sec, Contrato, Cargo, FechaInicio, FechaFin, 
                UsrRegistra, FechaRegistro, TerminalRegistra
            )
            SELECT 
                ROW_NUMBER() OVER (ORDER BY JSON_VALUE(value, '$.FechaInicio')) + 
                ISNULL((SELECT MAX(Sec) FROM Contrato_Cargos), 0),
                @SecContratoResult,
                CAST(JSON_VALUE(value, '$.Cargo') AS INT),
                CAST(JSON_VALUE(value, '$.FechaInicio') AS DATETIME),
                CASE 
                    WHEN JSON_VALUE(value, '$.FechaFin') IS NULL OR JSON_VALUE(value, '$.FechaFin') = '' 
                    THEN NULL 
                    ELSE CAST(JSON_VALUE(value, '$.FechaFin') AS DATETIME) 
                END,
                @Usuario,
                GETDATE(),
                @Terminal
            FROM OPENJSON(@Datos, '$.Cargos');
        END
        
        COMMIT TRANSACTION;
        
-- 9. RETORNAR RESPUESTA EN JSON
SELECT (
    SELECT 
        'SUCCESS' as Estado,
        CASE WHEN @IsUpdate = 1 THEN 'UPDATED' ELSE 'INSERTED' END as Operacion,
        'Contrato guardado exitosamente' as Mensaje,
        GETDATE() as FechaHoraServidor,
        JSON_QUERY((  -- Agregar JSON_QUERY aquí
            SELECT 
                c.Sec,
                c.CodContrato,
                c.Empleado,
                e.Identificacion as IdentificacionEmpleado,
                e.PApellido + ' ' + ISNULL(e.SApellido, '') + ' ' + e.PNombre + ' ' + ISNULL(e.SNombre, '') as NombreEmpleado,
                c.FechaInicio,
                c.FechaFin,
                c.Asignacion,
                c.CargoActual,
                JSON_QUERY((  -- También aquí para CentrosCosto
                    SELECT 
                        cc.Sec,
                        cc.CentroCosto,
                        ccc.Nom_CentroCosto as NombreCentroCosto,
                        cc.Porcentaje
                    FROM Contratos_CentroCostos cc
                    INNER JOIN CT_CentroCostos ccc ON cc.CentroCosto = ccc.Sec
                    WHERE cc.Contrato = c.Sec
                    FOR JSON PATH
                )) as CentrosCosto,
                JSON_QUERY((  -- Y aquí para Cargos
                    SELECT 
                        ccg.Sec,
                        ccg.Cargo,
                        cg.Denominacion as NombreCargo,
                        ccg.FechaInicio,
                        ccg.FechaFin
                    FROM Contrato_Cargos ccg
                    INNER JOIN cargos cg ON ccg.Cargo = cg.Sec
                    WHERE ccg.Contrato = c.Sec
                    FOR JSON PATH
                )) as Cargos
            FROM Contratos c
            INNER JOIN Empleados e ON c.Empleado = e.Sec
            WHERE c.Sec = @SecContratoResult
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        )) as Contrato  -- Cerrar JSON_QUERY
    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
SELECT (
    SELECT 
        'ERROR' as Estado,
        'ERROR' as Operacion,
        @ErrorMessage as Mensaje,
        @ErrorNumber as CodigoError,
        GETDATE() as FechaHoraServidor,
        JSON_QUERY(@Datos) as DatosEnviados  -- Ya está correcto aquí
    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
) AS JsonResponse;
            
        -- Re-lanzar el error para logging en el cliente si es necesario
        -- THROW;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertDescripVarPer]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertDescripVarPer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertDescripVarPer] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_UpsertDescripVarPer]
    @Datos NVARCHAR(MAX) -- JSON con toda la información del detalle
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    DECLARE @SecDetalle INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @FechaHoraInicio DATETIME;
    DECLARE @FechaHoraFin DATETIME;
    DECLARE @Cantidad INT;
    DECLARE @CodVarP INT;
    DECLARE @TipoDesc VARCHAR(10);
    DECLARE @NomTipo VARCHAR(200);
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @FechaHoraInicio = CONVERT(DATETIME, JSON_VALUE(@Datos, '$.FechaHoraInicio'), 103),
            @FechaHoraFin = CONVERT(DATETIME, JSON_VALUE(@Datos, '$.FechaHoraFin'), 103),
            @Cantidad = JSON_VALUE(@Datos, '$.Cantidad'),
            @CodVarP = JSON_VALUE(@Datos, '$.CodVarP'),
            @TipoDesc = JSON_VALUE(@Datos, '$.TipoDesc'),
            @NomTipo = JSON_VALUE(@Datos, '$.NomTipo'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN (siempre es inserción según lógica actual)
        SET @IsUpdate = 0;
        
        -- Generar nuevo Sec
        SELECT @SecDetalle = ISNULL(MAX(Sec), 0) + 1 
        FROM DescripVarPer;
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @FechaHoraInicio IS NULL
        BEGIN
            SET @ErrorMsg = 'La fecha de inicio es requerida';
            THROW 50001, @ErrorMsg, 1;
        END
        
        IF @FechaHoraFin IS NULL
        BEGIN
            SET @ErrorMsg = 'La fecha de fin es requerida';
            THROW 50002, @ErrorMsg, 1;
        END
        
        IF @Cantidad IS NULL OR @Cantidad <= 0
        BEGIN
            SET @ErrorMsg = 'La cantidad debe ser mayor a cero';
            THROW 50003, @ErrorMsg, 1;
        END
        
        IF @CodVarP IS NULL OR @CodVarP <= 0
        BEGIN
            SET @ErrorMsg = 'El código de variable personal es requerido';
            THROW 50004, @ErrorMsg, 1;
        END
        
        -- Validar que fecha fin sea mayor a fecha inicio
        IF @FechaHoraFin <= @FechaHoraInicio
        BEGIN
            SET @ErrorMsg = 'La fecha de fin debe ser mayor a la fecha de inicio';
            THROW 50005, @ErrorMsg, 1;
        END
        
        -- 5. VALIDAR DIFERENCIA DE FECHAS CON CANTIDAD
        -- Nota: Esta validación se hace en VB.NET según el tipo, aquí solo validamos lógica básica
        
        -- 6. VERIFICAR QUE EXISTE LA VARIABLE PERSONAL
        IF NOT EXISTS (SELECT 1 FROM NominaLiquidaVariables WHERE Sec = @CodVarP)
        BEGIN
            SET @ErrorMsg = 'La variable personal con Sec = ' + CAST(@CodVarP AS VARCHAR) + ' no existe';
            THROW 50006, @ErrorMsg, 1;
        END
        
        -- 7. INSERTAR EL DETALLE
        INSERT INTO DescripVarPer (
            Sec, 
            FechaHoraInicio, 
            FechaHoraFin, 
            Cantidad, 
            CodVarP, 
            TipoDesc, 
            NomTipo
        )
        VALUES (
            @SecDetalle,
            @FechaHoraInicio,
            @FechaHoraFin,
            @Cantidad,
            @CodVarP,
            @TipoDesc,
            @NomTipo
        );
        
        COMMIT TRANSACTION;
        
        -- 8. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                'INSERTED' as Operacion,
                'Detalle guardado exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY((
                    SELECT 
                        d.Sec,
                        d.FechaHoraInicio,
                        d.FechaHoraFin,
                        d.Cantidad,
                        d.CodVarP,
                        d.TipoDesc,
                        d.NomTipo,
                        vp.NomVariable,
                        (
                            SELECT SUM(Cantidad) 
                            FROM DescripVarPer 
                            WHERE CodVarP = d.CodVarP
                        ) as TotalAcumulado
                    FROM DescripVarPer d
                    LEFT JOIN VariablesPersonales vp ON d.CodVarP = vp.Sec
                    WHERE d.Sec = @SecDetalle
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as DetalleVariable
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertLiquidacionNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertLiquidacionNomina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertLiquidacionNomina] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_UpsertLiquidacionNomina]
    @Datos NVARCHAR(MAX) -- JSON con toda la información
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT YMD;
    
    DECLARE @SecNominaLiquida INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @ContratosCreados INT = 0;
    DECLARE @ContratosActualizados INT = 0;
    DECLARE @VariablesCreadas INT = 0;
    
    -- Variables del JSON
    DECLARE @Periodo INT;
    DECLARE @OfiNomina INT;
    DECLARE @OfiRegistra INT;
    DECLARE @Nomina INT;
    DECLARE @Año INT;
    DECLARE @NumPeriodo INT;
    DECLARE @NumMes INT;
    DECLARE @NumSemestre INT;
    DECLARE @BasarEnPeriodoAnterior BIT;
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    DECLARE @FechaSys DATETIME;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Periodo = JSON_VALUE(@Datos, '$.Periodo'),
            @OfiNomina = JSON_VALUE(@Datos, '$.OfiNomina'),
            @OfiRegistra = JSON_VALUE(@Datos, '$.OfiRegistra'),
            @Nomina = JSON_VALUE(@Datos, '$.Nomina'),
            @Año = JSON_VALUE(@Datos, '$.Anio'),
            @NumPeriodo = JSON_VALUE(@Datos, '$.NumPeriodo'),
            @NumMes = JSON_VALUE(@Datos, '$.NumMes'),
            @BasarEnPeriodoAnterior = JSON_VALUE(@Datos, '$.BasarEnPeriodoAnterior'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal'),
            @FechaSys = JSON_VALUE(@Datos, '$.FechaSys');
        
        -- Calcular semestre
        SET @NumSemestre = CASE WHEN @NumMes > 6 THEN 2 ELSE 1 END;
        
        -- 3. VALIDACIONES
        
        -- Validar que el periodo existe y no está liquidado
        IF NOT EXISTS (SELECT 1 FROM PeriodosLiquidacion WHERE Sec = @Periodo)
        BEGIN
            SET @ErrorMsg = 'El periodo especificado no existe';
            THROW 50001, @ErrorMsg, 1;
        END
        
        IF EXISTS (SELECT 1 FROM PeriodosLiquidacion WHERE Sec = @Periodo AND Estado = 'L')
        BEGIN
            SET @ErrorMsg = 'Este periodo ya ha sido liquidado';
            THROW 50002, @ErrorMsg, 1;
        END
        
        -- Validar que no hay periodos anteriores sin liquidar
        IF EXISTS (
            SELECT 1 FROM PeriodosLiquidacion 
            WHERE Sec < @Periodo 
            AND Estado = 'P' 
            AND Año = @Año 
            AND Nomina = @Nomina
            AND FechaFin < (SELECT FechaInicio FROM PeriodosLiquidacion WHERE Sec = @Periodo)
        )
        BEGIN
            SET @ErrorMsg = 'Hay periodos anteriores que aún no se han liquidado';
            THROW 50003, @ErrorMsg, 1;
        END
        
        -- 4. CREAR O ACTUALIZAR NOMINA LIQUIDA
        
        -- Verificar si ya existe un borrador
        IF EXISTS (SELECT 1 FROM NominaLiquida WHERE Periodo = @Periodo AND EsBorrador = 1)
        BEGIN
            SELECT @SecNominaLiquida = Sec FROM NominaLiquida WHERE Periodo = @Periodo AND EsBorrador = 1;
        END
        ELSE
        BEGIN
            -- Crear nueva NominaLiquida
            SELECT @SecNominaLiquida = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquida;
            
            INSERT INTO NominaLiquida (
                Sec, Periodo, OfiNomina, OfiRegistra, UsuCrea, 
                FechaCrea, TerminalCrea, FechaSys, EsBorrador
            ) VALUES (
                @SecNominaLiquida, @Periodo, @OfiNomina, @OfiRegistra, @Usuario,
                @FechaSys, @Terminal, @FechaSys, 1
            );
        END
        
        -- 5. PROCESAR CONTRATOS
        
        -- Tabla temporal para contratos del JSON
        CREATE TABLE #ContratosJSON (
            CodContrato INT,
            HorasMes INT,
            CargoActual INT,
            Asignacion MONEY
        );
        
        -- Insertar contratos del JSON
        INSERT INTO #ContratosJSON
        SELECT 
            JSON_VALUE(value, '$.CodContrato'),
            JSON_VALUE(value, '$.HorasMes'),
            JSON_VALUE(value, '$.CargoActual'),
            JSON_VALUE(value, '$.Asignacion')
        FROM OPENJSON(@Datos, '$.Contratos');
        
        -- Variables por defecto
        CREATE TABLE #VariablesDefecto (
            SecVariable INT,
            ValorDefecto DECIMAL(18,2)
        );
        
        INSERT INTO #VariablesDefecto
        SELECT 
            JSON_VALUE(value, '$.SecVariable'),
            JSON_VALUE(value, '$.ValorDefecto')
        FROM OPENJSON(@Datos, '$.VariablesDefecto');
        
        -- Procesar cada contrato
        DECLARE @CodContrato INT;
        DECLARE @HorasMes INT;
        DECLARE @CargoActual INT;
        DECLARE @Asignacion MONEY;
        DECLARE @SecNominaLiquidaContrato INT;
        
        DECLARE cur_contratos CURSOR FOR
            SELECT CodContrato, HorasMes, CargoActual, Asignacion
            FROM #ContratosJSON;
        
        OPEN cur_contratos;
        FETCH NEXT FROM cur_contratos INTO @CodContrato, @HorasMes, @CargoActual, @Asignacion;
        
        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Verificar si el contrato ya existe en la liquidación
            IF EXISTS (
                SELECT 1 FROM NominaLiquidaContratos 
                WHERE NominaLiquida = @SecNominaLiquida AND Contrato = @CodContrato
            )
            BEGIN
                -- Actualizar contrato existente
                UPDATE NominaLiquidaContratos
                SET HorasMes = @HorasMes,
                    CargoActual = @CargoActual,
                    Asignacion = @Asignacion
                WHERE NominaLiquida = @SecNominaLiquida AND Contrato = @CodContrato;
                
                SELECT @SecNominaLiquidaContrato = Sec 
                FROM NominaLiquidaContratos 
                WHERE NominaLiquida = @SecNominaLiquida AND Contrato = @CodContrato;
                
                SET @ContratosActualizados = @ContratosActualizados + 1;
            END
            ELSE
            BEGIN
                -- Crear nuevo contrato
                SELECT @SecNominaLiquidaContrato = ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidaContratos;
                
                INSERT INTO NominaLiquidaContratos (
                    Sec, Contrato, NominaLiquida, Total, HorasMes, CargoActual,
                    Asignacion, TotalProvisiones, TotalFondos, TotalIngresos,
                    TotalDeducciones, TotalDescuentosNomina
                ) VALUES (
                    @SecNominaLiquidaContrato, @CodContrato, @SecNominaLiquida, 0, @HorasMes, @CargoActual,
                    @Asignacion, 0, 0, 0, 0, 0
                );
                
                SET @ContratosCreados = @ContratosCreados + 1;
            END
            
            -- 6. PROCESAR VARIABLES PARA CADA CONTRATO

DECLARE @SecVariable INT;
DECLARE @ValorDefecto DECIMAL(18,2);
DECLARE @ValorAnterior DECIMAL(18,2);

DECLARE cur_variables CURSOR FOR
    SELECT SecVariable, ValorDefecto FROM #VariablesDefecto;

OPEN cur_variables;
FETCH NEXT FROM cur_variables INTO @SecVariable, @ValorDefecto;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Si no existe la variable para este contrato, crearla
    IF NOT EXISTS (
        SELECT 1 FROM NominaLiquidaVariables 
        WHERE SecLiquidaContrato = @SecNominaLiquidaContrato 
        AND Variable = @SecVariable
    )
    BEGIN
        -- IMPORTANTE: Reinicializar @ValorAnterior en cada iteración
        SET @ValorAnterior = NULL;
        
        -- Si se basa en periodo anterior, buscar valor
        IF @BasarEnPeriodoAnterior = 1
        BEGIN
            -- Buscar valor del periodo anterior
            SELECT TOP 1 @ValorAnterior = NLV.Cantidad
            FROM NominaLiquidadaVariables NLV
            INNER JOIN NominaLiquidadaContratos NLC ON NLV.SecLiquidadaContrato = NLC.Sec
            INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec
            INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec
            WHERE NLC.Contrato = @CodContrato
            AND NLV.Variable = @SecVariable  -- Buscar específicamente esta variable
            AND PL.Nomina = @Nomina
            AND PL.Año = @Año
            AND PL.NumPeriodoNom < (SELECT NumPeriodoNom FROM PeriodosLiquidacion WHERE Sec = @Periodo)
            ORDER BY PL.NumPeriodoNom DESC;
            
            -- Si no encontró valor anterior, usar el valor por defecto
            IF @ValorAnterior IS NULL
                SET @ValorAnterior = @ValorDefecto;
        END
        ELSE
        BEGIN
            -- Si no se basa en periodo anterior, usar directamente el valor por defecto
            SET @ValorAnterior = @ValorDefecto;
        END
        
        -- Insertar variable con el valor correcto
        INSERT INTO NominaLiquidaVariables (
            Sec, SecLiquidaContrato, Variable, Cantidad
        ) VALUES (
            (SELECT ISNULL(MAX(Sec), 0) + 1 FROM NominaLiquidaVariables),
            @SecNominaLiquidaContrato,
            @SecVariable,
            @ValorAnterior  -- Este valor ahora es específico para cada variable
        );
        
        SET @VariablesCreadas = @VariablesCreadas + 1;
    END
    
    FETCH NEXT FROM cur_variables INTO @SecVariable, @ValorDefecto;
END

CLOSE cur_variables;
DEALLOCATE cur_variables;
            
            FETCH NEXT FROM cur_contratos INTO @CodContrato, @HorasMes, @CargoActual, @Asignacion;
        END
        
        CLOSE cur_contratos;
        DEALLOCATE cur_contratos;
        
        -- Limpiar tablas temporales
        DROP TABLE #ContratosJSON;
        DROP TABLE #VariablesDefecto;
        
        COMMIT TRANSACTION;
        
        -- 7. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                'CREATED_OR_UPDATED' as Operacion,
                'Liquidación de nómina creada/actualizada exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                @SecNominaLiquida as SecNominaLiquida,
                @ContratosCreados as ContratosCreados,
                @ContratosActualizados as ContratosActualizados,
                @VariablesCreadas as VariablesCreadas
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        -- Limpiar tablas temporales si existen
        IF OBJECT_ID('tempdb..#ContratosJSON') IS NOT NULL
            DROP TABLE #ContratosJSON;
        IF OBJECT_ID('tempdb..#VariablesDefecto') IS NOT NULL
            DROP TABLE #VariablesDefecto;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertNomina]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertNomina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertNomina] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_UpsertNomina]
    @Datos NVARCHAR(MAX) -- JSON con toda la información de la nómina
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    DECLARE @SecNomina INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    DECLARE @ConceptosInsertados INT = 0;
    DECLARE @ProvisionesInsertadas INT = 0;
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @NomNomina VARCHAR(50);
    DECLARE @FormaLiquida SMALLINT;
    DECLARE @Fecha DATE;
    DECLARE @Oficina SMALLINT;
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @NomNomina = JSON_VALUE(@Datos, '$.NomNomina'),
            @FormaLiquida = JSON_VALUE(@Datos, '$.FormaLiquida'),
            @Fecha = JSON_VALUE(@Datos, '$.Fecha'),
            @Oficina = JSON_VALUE(@Datos, '$.Oficina'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN
        IF @Sec > 0
        BEGIN
            SET @IsUpdate = 1;
            SET @SecNomina = @Sec;
        END
        ELSE
        BEGIN
            SET @IsUpdate = 0;
            -- Para inserción: calcular el próximo Sec disponible
            SELECT @SecNomina = ISNULL(MAX(Sec), 0) + 1 
            FROM Nominas;
        END
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @NomNomina IS NULL OR @NomNomina = ''
        BEGIN
            SET @ErrorMsg = 'El nombre de la nómina es requerido';
            THROW 50001, @ErrorMsg, 1;
        END
        
        IF @Oficina IS NULL
        BEGIN
            SET @ErrorMsg = 'La oficina es requerida';
            THROW 50002, @ErrorMsg, 1;
        END
        
        IF @Usuario IS NULL OR @Usuario = ''
        BEGIN
            SET @ErrorMsg = 'El usuario es requerido';
            THROW 50003, @ErrorMsg, 1;
        END
        
        -- 5. VALIDACIONES ESPECÍFICAS SEGÚN OPERACIÓN
        
        IF @IsUpdate = 1
        BEGIN
            -- Para actualización: verificar que la nómina existe
            IF NOT EXISTS (SELECT 1 FROM Nominas WHERE Sec = @Sec)
            BEGIN
                SET @ErrorMsg = 'La nómina con Sec = ' + CAST(@Sec AS VARCHAR) + ' no existe';
                THROW 50004, @ErrorMsg, 1;
            END
        END
        
        -- 6. UPSERT DE LA NÓMINA
        
        IF @IsUpdate = 1
        BEGIN
            -- ACTUALIZACIÓN
            UPDATE Nominas SET
                NomNomina = @NomNomina,
                FormaLiquida = @FormaLiquida,
                Fecha = @Fecha,
                Oficina = @Oficina
            WHERE Sec = @Sec;
        END
        ELSE
        BEGIN
            -- INSERCIÓN con Sec calculado
            INSERT INTO Nominas (
                Sec, NomNomina, FormaLiquida, Fecha, Oficina
            )
            VALUES (
                @SecNomina, @NomNomina, @FormaLiquida, @Fecha, @Oficina
            );
        END
        
        -- 7. CREAR CONFIGURACIÓN DE CONCEPTOS PARA LA NÓMINA
        -- Insertar en ConfigConceptos todos los conceptos que no existan para esta nómina
        INSERT INTO ConfigConceptos (
            Sec, Nomina, Concepto, Formula, PeriodosLiquida, CuentaContable, ConceptoR, ContraPartida
        )
        SELECT 
            ROW_NUMBER() OVER (ORDER BY cn.Sec) + ISNULL((SELECT MAX(Sec) FROM ConfigConceptos), 0),
            @SecNomina,
            cn.Sec,
            cn.Formula,
            cn.PeriodosLiquida,
            NULL, -- CuentaContable se puede configurar después
            NULL, -- ConceptoR se puede configurar después
            NULL  -- ContraPartida se puede configurar después
        FROM ConceptosNomina cn
        WHERE cn.Vigente = '1'  -- Cambiado de 'V' a '1'
        AND NOT EXISTS (
            SELECT 1 FROM ConfigConceptos cc 
            WHERE cc.Nomina = @SecNomina 
            AND cc.Concepto = cn.Sec
        );
        
        SET @ConceptosInsertados = @@ROWCOUNT;
        
        -- 8. CREAR CONFIGURACIÓN DE PROVISIONES PARA LA NÓMINA
        -- Insertar en ConfigProvisiones todos los conceptos que no existan para esta nómina
        INSERT INTO ConfigProvisiones (
            Sec, Concepto, Formula, SemestresLiquida, CuentaContable, Nomina
        )
        SELECT 
            ROW_NUMBER() OVER (ORDER BY cn.Sec) + ISNULL((SELECT MAX(Sec) FROM ConfigProvisiones), 0),
            cn.Sec,
            cn.Formula,
            CASE 
                WHEN cn.Tipo IN (SELECT Sec FROM TiposConceptosNomina WHERE NomTipo LIKE '%PROVISION%') THEN '1'
                ELSE NULL
            END,
            NULL, -- CuentaContable se puede configurar después
            @SecNomina
        FROM ConceptosNomina cn
        WHERE cn.Vigente = '1'  -- Cambiado de 'V' a '1'
        AND NOT EXISTS (
            SELECT 1 FROM ConfigProvisiones cp 
            WHERE cp.Nomina = @SecNomina 
            AND cp.Concepto = cn.Sec
        );
        
        SET @ProvisionesInsertadas = @@ROWCOUNT;
        
        COMMIT TRANSACTION;
        
        -- 9. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                CASE WHEN @IsUpdate = 1 THEN 'UPDATED' ELSE 'INSERTED' END as Operacion,
                'Nómina guardada exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY((
                    SELECT 
                        n.Sec,
                        n.NomNomina,
                        n.FormaLiquida,
                        n.Fecha,
                        n.Oficina,
                        (
                            SELECT COUNT(*) 
                            FROM ConfigConceptos 
                            WHERE Nomina = n.Sec
                        ) as TotalConceptosConfigurados,
                        @ConceptosInsertados as ConceptosNuevos,
                        (
                            SELECT COUNT(*) 
                            FROM ConfigProvisiones 
                            WHERE Nomina = n.Sec
                        ) as TotalProvisionesConfiguradas,
                        @ProvisionesInsertadas as ProvisionesNuevas,
                        (
                            SELECT TOP 10
                                cc.Sec,
                                cc.Concepto,
                                cn.NomConcepto,
                                cc.Formula,
                                cc.PeriodosLiquida,
                                cc.CuentaContable,
                                cc.ContraPartida
                            FROM ConfigConceptos cc
                            INNER JOIN ConceptosNomina cn ON cc.Concepto = cn.Sec
                            WHERE cc.Nomina = n.Sec
                            ORDER BY cc.Sec DESC
                            FOR JSON PATH
                        ) as ConceptosConfigurados,
                        (
                            SELECT TOP 10
                                cp.Sec,
                                cp.Concepto,
                                cn.NomConcepto,
                                cp.Formula,
                                cp.SemestresLiquida,
                                cp.CuentaContable
                            FROM ConfigProvisiones cp
                            INNER JOIN ConceptosNomina cn ON cp.Concepto = cn.Sec
                            WHERE cp.Nomina = n.Sec
                            ORDER BY cp.Sec DESC
                            FOR JSON PATH
                        ) as ProvisionesConfiguradas
                    FROM Nominas n
                    WHERE n.Sec = @SecNomina
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as Nomina
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertPlantilla]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertPlantilla]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertPlantilla] AS' 
END
GO
ALTER   PROCEDURE [dbo].[SP_UpsertPlantilla]
    @Datos NVARCHAR(MAX) -- JSON con toda la información de la plantilla
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    DECLARE @SecPlantilla INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @NomPlantilla VARCHAR(50);
    DECLARE @Vigente CHAR(1);
    DECLARE @ValorMaxDescontar VARCHAR(2000);
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @NomPlantilla = JSON_VALUE(@Datos, '$.NomPlantilla'),
            @Vigente = JSON_VALUE(@Datos, '$.Vigente'),
            @ValorMaxDescontar = JSON_VALUE(@Datos, '$.ValorMaxDescontar'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN
        IF @Sec > 0
        BEGIN
            SET @IsUpdate = 1;
            SET @SecPlantilla = @Sec;
        END
        ELSE
        BEGIN
            SET @IsUpdate = 0;
        END
        
        -- 4. VALIDACIONES BÁSICAS
        IF @NomPlantilla IS NULL OR @NomPlantilla = ''
        BEGIN
            SET @ErrorMsg = 'El nombre de la plantilla es requerido';
            THROW 50001, @ErrorMsg, 1;
        END
        
        -- 5. VALIDACIONES ESPECÍFICAS SEGÚN OPERACIÓN
        IF @IsUpdate = 1
        BEGIN
            -- Para actualización: verificar que la plantilla existe
            IF NOT EXISTS (SELECT 1 FROM Plantillas WHERE Sec = @Sec)
            BEGIN
                SET @ErrorMsg = 'La plantilla con Sec = ' + CAST(@Sec AS VARCHAR) + ' no existe';
                THROW 50002, @ErrorMsg, 1;
            END
        END
        
        -- 6. UPSERT DE LA PLANTILLA
        IF @IsUpdate = 1
        BEGIN
            -- ACTUALIZACIÓN
            UPDATE Plantillas SET
                NomPlantilla = @NomPlantilla,
                Vigente = @Vigente,
                ValorMaxDescontar = @ValorMaxDescontar
            WHERE Sec = @Sec;
        END
        ELSE
        BEGIN
            -- INSERCIÓN - Calcular nuevo Sec
            SET @SecPlantilla = ISNULL((SELECT MAX(Sec) FROM Plantillas), 0) + 1;
            
            INSERT INTO Plantillas (Sec, NomPlantilla, Vigente, ValorMaxDescontar)
            VALUES (@SecPlantilla, @NomPlantilla, @Vigente, @ValorMaxDescontar);
        END
        
        -- 7. MANEJAR CONCEPTOS DE LA PLANTILLA
        
        -- Eliminar conceptos existentes
        DELETE FROM ConceptosPlantillas WHERE Plantilla = @SecPlantilla;
        
        -- Insertar nuevos conceptos si hay
        IF EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.Conceptos'))
        BEGIN
            -- Obtener el MAX Sec actual de ConceptosPlantillas
            DECLARE @MaxSecCP INT = ISNULL((SELECT MAX(Sec) FROM ConceptosPlantillas), 0);
            
            INSERT INTO ConceptosPlantillas (Sec, Plantilla, Concepto)
            SELECT 
                @MaxSecCP + ROW_NUMBER() OVER (ORDER BY CAST(JSON_VALUE(value, '$.Concepto') AS INT)),
                @SecPlantilla,
                CAST(JSON_VALUE(value, '$.Concepto') AS INT)
            FROM OPENJSON(@Datos, '$.Conceptos');
        END
        
        -- 8. MANEJAR CONCEPTOS DE PROVISIÓN
        
        -- Eliminar conceptos de provisión existentes
        DELETE FROM ConceptosProvisionesPlantillas WHERE Plantilla = @SecPlantilla;
        
        -- Insertar nuevos conceptos de provisión si hay
        IF EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.ConceptosProvisiones'))
        BEGIN
            -- Obtener el MAX Sec actual de ConceptosProvisionesPlantillas
            DECLARE @MaxSecCPP INT = ISNULL((SELECT MAX(Sec) FROM ConceptosProvisionesPlantillas), 0);
            
            INSERT INTO ConceptosProvisionesPlantillas (Sec, Plantilla, Concepto)
            SELECT 
                @MaxSecCPP + ROW_NUMBER() OVER (ORDER BY CAST(JSON_VALUE(value, '$.Concepto') AS INT)),
                @SecPlantilla,
                CAST(JSON_VALUE(value, '$.Concepto') AS INT)
            FROM OPENJSON(@Datos, '$.ConceptosProvisiones');
        END
        
        COMMIT TRANSACTION;
        
        -- 9. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                CASE WHEN @IsUpdate = 1 THEN 'UPDATED' ELSE 'INSERTED' END as Operacion,
                'Plantilla guardada exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY((
                    SELECT 
                        p.Sec,
                        p.NomPlantilla,
                        p.Vigente,
                        p.ValorMaxDescontar,
                        (
                            SELECT 
                                cp.Sec,
                                cp.Concepto,
                                cn.NomConcepto
                            FROM ConceptosPlantillas cp
                            INNER JOIN ConceptosNomina cn ON cp.Concepto = cn.Sec
                            WHERE cp.Plantilla = p.Sec
                            FOR JSON PATH
                        ) as Conceptos,
                        (
                            SELECT 
                                cpp.Sec,
                                cpp.Concepto,
                                cn.NomConcepto
                            FROM ConceptosProvisionesPlantillas cpp
                            INNER JOIN ConceptosNomina cn ON cpp.Concepto = cn.Sec
                            WHERE cpp.Plantilla = p.Sec
                            FOR JSON PATH
                        ) as ConceptosProvisiones,
                        (
                            SELECT COUNT(DISTINCT c.Sec) 
                            FROM Contratos c
                            WHERE c.Plantilla = p.Sec
                        ) as ContratosAfectados
                    FROM Plantillas p
                    WHERE p.Sec = @SecPlantilla
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as Plantilla
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertTipoContrato]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertTipoContrato]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertTipoContrato] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_UpsertTipoContrato]
    @Datos NVARCHAR(MAX) -- JSON con toda la información del tipo de contrato
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    DECLARE @SecTipoContrato INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    DECLARE @ConceptosCreados INT = 0;
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @NomTipo VARCHAR(50);
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @NomTipo = JSON_VALUE(@Datos, '$.NomTipo'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN
        IF @Sec > 0
        BEGIN
            SET @IsUpdate = 1;
            SET @SecTipoContrato = @Sec;
        END
        ELSE
        BEGIN
            SET @IsUpdate = 0;
            -- Para inserción: calcular el próximo Sec disponible
            SELECT @SecTipoContrato = ISNULL(MAX(Sec), 0) + 1 
            FROM CAT_TipoContratos;
        END
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @NomTipo IS NULL OR @NomTipo = ''
        BEGIN
            SET @ErrorMsg = 'El nombre del tipo de contrato es requerido';
            THROW 50001, @ErrorMsg, 1;
        END
        
        -- 5. VALIDACIONES ESPECÍFICAS SEGÚN OPERACIÓN
        
        IF @IsUpdate = 1
        BEGIN
            -- Para actualización: verificar que el tipo de contrato existe
            IF NOT EXISTS (SELECT 1 FROM CAT_TipoContratos WHERE Sec = @Sec)
            BEGIN
                SET @ErrorMsg = 'El tipo de contrato con Sec = ' + CAST(@Sec AS VARCHAR) + ' no existe';
                THROW 50002, @ErrorMsg, 1;
            END
        END
        
        -- 6. UPSERT DEL TIPO DE CONTRATO
        
        IF @IsUpdate = 1
        BEGIN
            -- ACTUALIZACIÓN
            UPDATE CAT_TipoContratos SET
                NomTipo = @NomTipo
            WHERE Sec = @Sec;
        END
        ELSE
        BEGIN
            -- INSERCIÓN con Sec calculado
            INSERT INTO CAT_TipoContratos (Sec, NomTipo)
            VALUES (@SecTipoContrato, @NomTipo);
        END
        
        -- 7. CREAR RELACIONES CON CONCEPTOS DE NÓMINA
        
        -- Tabla temporal para almacenar conceptos que se van a crear
        CREATE TABLE #ConceptosACrear (
            ConceptoSec SMALLINT,
            NomConcepto VARCHAR(200)
        );
        
        -- Identificar conceptos que no tienen relación con este tipo de contrato
        -- Nota: Ahora TipoContrato en TiposContratos_ConceptosNomina debe referenciar Sec
        INSERT INTO #ConceptosACrear (ConceptoSec, NomConcepto)
        SELECT cn.Sec, cn.NomConcepto
        FROM ConceptosNomina cn
        WHERE NOT EXISTS (
            SELECT 1 
            FROM TiposContratos_ConceptosNomina tc
            WHERE tc.TipoContrato = @SecTipoContrato 
            AND tc.Concepto = cn.Sec
        );
        
        -- Contar cuántos conceptos se van a crear
        SET @ConceptosCreados = @@ROWCOUNT;
        
        -- Insertar las nuevas relaciones
        IF @ConceptosCreados > 0
        BEGIN
            INSERT INTO TiposContratos_ConceptosNomina (
                Sec, Concepto, TipoContrato, Formula, BaseCalculo, 
                SeLiquida, CuentaContable
            )
            SELECT 
                ROW_NUMBER() OVER (ORDER BY ConceptoSec) + 
                ISNULL((SELECT MAX(Sec) FROM TiposContratos_ConceptosNomina), 0),
                ConceptoSec,
                @SecTipoContrato,
                NULL, -- Formula vacía por defecto
                NULL, -- BaseCalculo vacía por defecto
                0,    -- SeLiquida = false por defecto
                NULL  -- CuentaContable vacía por defecto
            FROM #ConceptosACrear;
        END
        
        DROP TABLE #ConceptosACrear;
        
        COMMIT TRANSACTION;
        
        -- 8. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                CASE WHEN @IsUpdate = 1 THEN 'UPDATED' ELSE 'INSERTED' END as Operacion,
                'Tipo de contrato guardado exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY((
                    SELECT 
                        tc.Sec,
                        tc.NomTipo,
                        @ConceptosCreados as ConceptosAsociados,
                        (
                            SELECT COUNT(*) 
                            FROM TiposContratos_ConceptosNomina tccn
                            WHERE tccn.TipoContrato = tc.Sec
                        ) as TotalConceptosRelacionados,
                        (
                            SELECT 
                                tccn.Sec,
                                tccn.Concepto,
                                cn.NomConcepto,
                                tccn.Formula,
                                tccn.BaseCalculo,
                                tccn.SeLiquida,
                                tccn.CuentaContable
                            FROM TiposContratos_ConceptosNomina tccn
                            INNER JOIN ConceptosNomina cn ON tccn.Concepto = cn.Sec
                            WHERE tccn.TipoContrato = tc.Sec
                            ORDER BY cn.Sec
                            FOR JSON PATH
                        ) as ConceptosNomina
                    FROM CAT_TipoContratos tc
                    WHERE tc.Sec = @SecTipoContrato
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as TipoContrato
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpsertVariablesGenerales]    Script Date: 9/7/2025 17:12:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_UpsertVariablesGenerales]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_UpsertVariablesGenerales] AS' 
END
GO
ALTER PROCEDURE [dbo].[SP_UpsertVariablesGenerales]
    @Datos NVARCHAR(MAX) -- JSON con toda la información
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET DATEFORMAT DMY;
    
    -- Variables para control
    DECLARE @SecVariable INT;
    DECLARE @ErrorMsg NVARCHAR(4000);
    DECLARE @IsUpdate BIT = 0;
    DECLARE @DetallesEliminados INT = 0;
    DECLARE @DetallesInsertados INT = 0;
    DECLARE @FormulasActualizadas INT = 0;
    
    -- Variables para extraer del JSON
    DECLARE @Sec INT;
    DECLARE @NomVariable VARCHAR(100);
    DECLARE @NomVariableAnterior VARCHAR(100);
    DECLARE @CodDian VARCHAR(10);
    DECLARE @Vigente VARCHAR(1);
    DECLARE @Usuario VARCHAR(20);
    DECLARE @Terminal VARCHAR(50);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- 1. VALIDAR JSON
        IF @Datos IS NULL OR @Datos = '' OR ISJSON(@Datos) = 0
        BEGIN
            SET @ErrorMsg = 'El parámetro @Datos debe ser un JSON válido';
            THROW 50000, @ErrorMsg, 1;
        END
        
        -- 2. EXTRAER DATOS DEL JSON
        SELECT 
            @Sec = JSON_VALUE(@Datos, '$.Sec'),
            @NomVariable = JSON_VALUE(@Datos, '$.NomVariable'),
            @NomVariableAnterior = JSON_VALUE(@Datos, '$.NomVariableAnterior'),
            @CodDian = JSON_VALUE(@Datos, '$.CodDian'),
            @Vigente = JSON_VALUE(@Datos, '$.Vigente'),
            @Usuario = JSON_VALUE(@Datos, '$.Usuario'),
            @Terminal = JSON_VALUE(@Datos, '$.Terminal');
        
        -- 3. DETERMINAR OPERACIÓN
        IF @Sec > 0
        BEGIN
            SET @IsUpdate = 1;
            SET @SecVariable = @Sec;
            
            -- Si es actualización y no se envió el nombre anterior, obtenerlo
            IF @NomVariableAnterior IS NULL OR @NomVariableAnterior = ''
            BEGIN
                SELECT @NomVariableAnterior = NomVariable 
                FROM VariablesGenerales 
                WHERE Sec = @SecVariable;
            END
        END
        ELSE
        BEGIN
            SET @IsUpdate = 0;
        END
        
        -- 4. VALIDACIONES BÁSICAS
        
        -- Validar campos requeridos
        IF @NomVariable IS NULL OR @NomVariable = ''
        BEGIN
            SET @ErrorMsg = 'El nombre de la variable es requerido';
            THROW 50001, @ErrorMsg, 1;
        END
        
        -- 5. VALIDAR UNICIDAD DE NOMBRE (ValidaNombresR)
        IF EXISTS (
            SELECT 1 FROM (
                SELECT NomBase AS Nombre, 'B' as tipo, Sec FROM BasesConceptos
                UNION SELECT NomConcepto AS Nombre, 'C' as tipo, Sec FROM ConceptosNomina
                UNION SELECT NomVariable AS Nombre, 'VG' as tipo, Sec FROM VariablesGenerales
                UNION SELECT NomVariable AS Nombre, 'VP' as tipo, Sec FROM VariablesPersonales
                UNION SELECT NomConcepto AS Nombre, 'CP' as tipo, Sec FROM ConceptosPersonales
                UNION SELECT 'HorasMes' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'Asignacion' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'RentaExenta' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'DescuentosPorNomina' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'SalarioPromedioPeriodo' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'SalarioPromedioMensualAnual' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'SalarioPromedioMensualSemestral' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'NetoAPagar' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'TotalPagadoMes' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'TotalIngresos' AS Nombre, 'VPP' AS tipo, 0 as Sec
                UNION SELECT 'TotalDeducciones' AS Nombre, 'VPP' AS tipo, 0 as Sec
            ) AS Consulta
            WHERE Consulta.Nombre = @NomVariable
            AND NOT (@IsUpdate = 1 AND tipo = 'VG' AND Sec = @SecVariable)
        )
        BEGIN
            SET @ErrorMsg = 'Ya existe un registro con este nombre (Los Conceptos, Variables Generales, Variables Personales y Bases no pueden coincidir en el nombre)';
            THROW 50002, @ErrorMsg, 1;
        END
        
        -- 6. VALIDAR SI ES VARIABLE PREDETERMINADA (para eliminación)
        IF @IsUpdate = 1 AND EXISTS (
            SELECT 1 FROM VariablesGenerales 
            WHERE Sec = @SecVariable AND ISNULL(EsPredeterminado, 0) = 1
        )
        BEGIN
            -- Si están intentando cambiar el nombre de una variable predeterminada
            IF @NomVariable <> @NomVariableAnterior
            BEGIN
                SET @ErrorMsg = 'No se puede cambiar el nombre de las variables predeterminadas del sistema';
                THROW 50003, @ErrorMsg, 1;
            END
        END
        
        -- 7. GUARDAR DATOS BÁSICOS
        IF @IsUpdate = 0
        BEGIN
            -- INSERCIÓN
            -- Obtener nuevo Sec
            SELECT @SecVariable = ISNULL(MAX(Sec), 0) + 1 FROM VariablesGenerales;
            
            INSERT INTO VariablesGenerales (Sec, NomVariable, CodDian, Vigente, EsPredeterminado)
            VALUES (@SecVariable, @NomVariable, @CodDian, @Vigente, 0);
        END
        ELSE
        BEGIN
            -- ACTUALIZACIÓN
            UPDATE VariablesGenerales
            SET NomVariable = @NomVariable,
                CodDian = @CodDian,
                Vigente = @Vigente
            WHERE Sec = @SecVariable;
        END
        
        -- 8. PROCESAR DETALLES (VALORES POR FECHA)
        -- Eliminar detalles existentes si hay detalles nuevos
        IF EXISTS (SELECT 1 FROM OPENJSON(@Datos, '$.Detalles'))
        BEGIN
            DELETE FROM DetallesVariablesGenerales 
            WHERE Variable = @SecVariable;
            
            SET @DetallesEliminados = @@ROWCOUNT;
            
            -- Insertar nuevos detalles
            INSERT INTO DetallesVariablesGenerales (Sec, Variable, Valor, Fecha)
            SELECT 
                CASE 
                    WHEN ISNULL(Sec, 0) = 0 
                    THEN ROW_NUMBER() OVER (ORDER BY Fecha) + ISNULL((SELECT MAX(Sec) FROM DetallesVariablesGenerales), 0)
                    ELSE Sec
                END,
                @SecVariable,
                CAST(Valor AS MONEY),
                CONVERT(DATE, Fecha, 103) -- Formato dd/MM/yyyy
            FROM OPENJSON(@Datos, '$.Detalles')
            WITH (
                Sec INT '$.Sec',
                Variable INT '$.Variable',
                Fecha VARCHAR(10) '$.Fecha',
                Valor DECIMAL(18,2) '$.Valor'
            )
            WHERE Fecha IS NOT NULL AND Valor IS NOT NULL;
            
            SET @DetallesInsertados = @@ROWCOUNT;
        END
        
        -- 9. ACTUALIZAR FÓRMULAS SI CAMBIÓ EL NOMBRE (ModNomFormulas)
        IF @IsUpdate = 1 AND @NomVariableAnterior <> @NomVariable
        BEGIN
            EXEC SP_ModNomFormulas @NomVariableAnterior, @NomVariable;
            
            -- Contar las fórmulas actualizadas
            SET @FormulasActualizadas = (
                SELECT COUNT(*) FROM (
                    SELECT 1 AS Actualizado FROM ConfigConceptos WHERE Formula LIKE '%[' + @NomVariable + ']%'
                    UNION ALL
                    SELECT 1 FROM ConceptosPersonales WHERE ValMaxDescuento LIKE '%[' + @NomVariable + ']%'
                    UNION ALL
                    SELECT 1 FROM BasesConceptos WHERE Formula LIKE '%[' + @NomVariable + ']%'
                    UNION ALL
                    SELECT 1 FROM Plantillas WHERE ValorMaxDescontar LIKE '%[' + @NomVariable + ']%'
                    UNION ALL
                    SELECT 1 FROM TiposContratos_ConceptosNomina WHERE Formula LIKE '%[' + @NomVariable + ']%'
                    UNION ALL
                    SELECT 1 FROM ConfigProvisiones WHERE Formula LIKE '%[' + @NomVariable + ']%'
                ) AS T
            );
        END
        
        COMMIT TRANSACTION;
        
        -- 10. RETORNAR RESPUESTA EN JSON
        SELECT (
            SELECT 
                'SUCCESS' as Estado,
                CASE WHEN @IsUpdate = 1 THEN 'UPDATED' ELSE 'INSERTED' END as Operacion,
                'Variable guardada exitosamente' as Mensaje,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY((
                    SELECT 
                        vg.Sec,
                        vg.NomVariable,
                        vg.CodDian,
                        vg.Vigente,
                        ISNULL(vg.EsPredeterminado, 0) as EsPredeterminado,
                        (
                            SELECT 
                                dvg.Sec,
                                dvg.Variable,
                                dvg.Valor,
                                CONVERT(VARCHAR, dvg.Fecha, 103) as Fecha
                            FROM DetallesVariablesGenerales dvg
                            WHERE dvg.Variable = vg.Sec
                            ORDER BY dvg.Fecha
                            FOR JSON PATH
                        ) as Detalles,
                        @DetallesInsertados as DetallesInsertados,
                        @DetallesEliminados as DetallesEliminados,
                        @FormulasActualizadas as FormulasActualizadas,
                        CASE 
                            WHEN @IsUpdate = 1 AND @NomVariableAnterior <> vg.NomVariable 
                            THEN @NomVariableAnterior 
                            ELSE NULL 
                        END as NombreAnterior
                    FROM VariablesGenerales vg
                    WHERE vg.Sec = @SecVariable
                    FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
                )) as Variable
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
        
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        DECLARE @ErrorNumber INT = ERROR_NUMBER();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        
        -- Retornar error en JSON
        SELECT (
            SELECT 
                'ERROR' as Estado,
                'ERROR' as Operacion,
                @ErrorMessage as Mensaje,
                @ErrorNumber as CodigoError,
                GETDATE() as FechaHoraServidor,
                JSON_QUERY(@Datos) as DatosEnviados
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        ) AS JsonResponse;
            
    END CATCH
END
GO
      ]]>
    </root>.Value
End Class
