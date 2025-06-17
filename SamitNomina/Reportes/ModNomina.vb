Imports DevExpress.XtraEditors
Imports SamitCtlNet

Module ModNomina
    Public Enum ImagenesSamit32X32
        Conectar = 0
        Desconectar = 1
        Agregar = 2
        GuardarTodo = 3
        BuacarEmpleado = 4
        Empleados = 5
    End Enum
    Public Function Imagen_boton32X32(NumImg As ImagenesSamit32X32) As Image
        Imagen_boton32X32 = FrmPrincipal.ImagenesSMT32X32.Images(NumImg)
    End Function
    Public Enum ImagenesSamit16X16
        'Icons Generales
        Opciones = 0
        Empleados = 1
        CambiaFecha = 2
        CambiaClave = 3
        ConsultarEmpleado = 4
        Editar = 5
        Eliminar = 6
        IconSamit = 7
        'Icons tabs de form Empleados
        DatosBasicos = 8
        Afiliaciones = 9
        Familiares = 10
        ExperienciaLaboral = 11
        InformacionAcademica = 12
        'Fin icons Form empleados
        'Icons Botones Form empleados
        Guardar = 13
        Limpiar = 14
        CargarImagen = 15
        AmpliarImagenes = 16
        EliminarGris = 17
        SalirCuadroConX = 18
        'Fin Icons Botones Empleados
        Agregar = 19
        SalirAtras = 20
        Imagen = 21
        Imprimir = 22
        Aplicar = 23
        CargarCertificado = 24
        Conectar = 25
        Desconectar = 26
        OpcionesEmpleados = 27
    End Enum

    Public Function Imagen_boton16X16(NumImg As ImagenesSamit16X16) As Image
        Imagen_boton16X16 = FrmPrincipal.ImagenesSMT16X16.Images(NumImg)
    End Function


    Public Sub CargaMesYaño(CodMuni As String, ByRef lkeDpto As LookUpEdit, ByRef lkePais As LookUpEdit)
        Try
            Dim sql As String
            Dim dt As DataTable
            Dim DepNac, PaisNac As String
            sql = String.Format("SELECT MN.Departamento FROM G_Municipio MN WHERE MN.IdMunicipio={0}", CodMuni)
            dt = SMT_AbrirTabla(Conexion, sql)
            If dt.Rows.Count > 0 Then
                DepNac = dt.Rows(0)(0).ToString
                sql = String.Format("SELECT TOP 1 DP.Pais FROM G_Departamento DP WHERE DP.CodDpto={0}", DepNac)
                dt = SMT_AbrirTabla(Conexion, sql)
                If dt.Rows.Count > 0 Then
                    PaisNac = dt.Rows(0)(0).ToString
                    lkePais.EditValue = PaisNac
                    lkeDpto.EditValue = DepNac
                End If
            Else
                lkePais.ItemIndex = 0
                lkeDpto.ItemIndex = 0
            End If

        Catch ex As Exception
            msgError(ex, ex.Message, "CargaMesYaño")
        End Try
    End Sub
    Public Function TraeDepartamentoConMunicipio(CodMuni As String, CodigoTrueNombreFalse As Boolean) As String
        Try
            Dim sql As String
            If CodigoTrueNombreFalse Then
                sql = String.Format("SELECT MN.Departamento FROM G_Municipio MN WHERE MN.IdMunicipio={0}", CodMuni)
            Else
                sql = String.Format("SELECT DP.NomDpto FROM G_Municipio MN " & _
                                    " INNER JOIN G_Departamento DP ON DP.CodDpto=MN.Departamento" & _
                                    " WHERE MN.IdMunicipio={0}", CodMuni)
            End If
            
            Dim dt = SMT_AbrirTabla(Conexion, sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return ""
            End If
        Catch ex As Exception
            msgError(ex, ex.Message, "TraeDepartamentoConMunicipio")
            Return ""
        End Try
    End Function
    Public Function TraePaisConDepartamento(CodDep As String, CodigoTrueNombreFalse As Boolean) As String
        Try
            Dim sql As String
            If CodigoTrueNombreFalse Then
                sql = String.Format("SELECT TOP 1 DP.Pais FROM G_Departamento DP WHERE DP.CodDpto={0}", CodDep)
            Else
                sql = String.Format("SELECT TOP 1 PS.NomPais FROM G_Departamento DP" & _
                                    " INNER JOIN G_Pais PS ON PS.CodPais= DP.Pais" & _
                                    " WHERE DP.CodDpto={0}", CodDep)
            End If

            Dim dt = SMT_AbrirTabla(Conexion, sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return ""
            End If
        Catch ex As Exception
            msgError(ex, ex.Message, "TraePaisConDepartamento")
            Return ""
        End Try
    End Function

End Module
