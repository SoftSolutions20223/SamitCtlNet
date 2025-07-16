Imports System.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports Newtonsoft.Json.Linq

Public Class ServiceEmpleados
    Public Property ListaErrores As New List(Of String)

    ''' <summary>
    ''' Valida manualmente los campos obligatorios y algunos rangos básicos.
    ''' </summary>
    Public Function ValidarCampos(emp As Empleados) As Boolean
        ListaErrores.Clear()

        ' TipoIdentificacion (string no vacío, longitud máxima 4)
        If String.IsNullOrWhiteSpace(emp.TipoIdentificacion) Then
            ListaErrores.Add("El campo TipoIdentificacion es obligatorio.")
        ElseIf emp.TipoIdentificacion.Length > 4 Then
            ListaErrores.Add("TipoIdentificacion no puede tener más de 4 caracteres.")
        End If

        ' Identificacion (debe ser > 0)
        If emp.Identificacion <= 0 Then
            ListaErrores.Add("El campo Identificacion debe ser un número mayor que cero.")
        End If

        ' PApellido y PNombre son obligatorios y longitud ≤ 50
        If String.IsNullOrWhiteSpace(emp.PApellido) Then
            ListaErrores.Add("El campo PApellido es obligatorio.")
        ElseIf emp.PApellido.Length > 50 Then
            ListaErrores.Add("PApellido no puede exceder 50 caracteres.")
        End If

        If String.IsNullOrWhiteSpace(emp.PNombre) Then
            ListaErrores.Add("El campo PNombre es obligatorio.")
        ElseIf emp.PNombre.Length > 50 Then
            ListaErrores.Add("PNombre no puede exceder 50 caracteres.")
        End If

        ' (Puedes añadir aquí más validaciones manuales de MaxLength, formatos, etc.)

        Return (ListaErrores.Count = 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza un empleado vía API, si pasa validación.
    ''' </summary>
    Public Function UpsertEmpleado(emp As Empleados) As DynamicUpsertResponseDto
        If Not ValidarCampos(emp) Then
            Return Nothing
        End If

        Dim fila As New JObject()
        fila("Sec") = emp.Sec
        fila("TipoIdentificacion") = emp.TipoIdentificacion
        fila("Identificacion") = emp.Identificacion
        fila("Dv") = If(emp.Dv, "")
        fila("PApellido") = emp.PApellido
        fila("SApellido") = emp.SApellido
        fila("PNombre") = emp.PNombre
        fila("SNombre") = emp.SNombre
        fila("Genero") = If(emp.Genero, "")

        ' Fechas (solo si tienen valor)
        If emp.FechaNacimiento.HasValue Then fila("FechaNacimiento") = emp.FechaNacimiento.Value.ToString("yyyy-MM-ddTHH:mm:ss")
        If emp.FechaExpDoc.HasValue Then fila("FechaExpDoc") = emp.FechaExpDoc.Value.ToString("yyyy-MM-ddTHH:mm:ss")
        If emp.FechaIngreso.HasValue Then fila("FechaIngreso") = emp.FechaIngreso.Value.ToString("yyyy-MM-ddTHH:mm:ss")
        If emp.FechaGen.HasValue Then fila("FechaGen") = emp.FechaGen.Value.ToString("yyyy-MM-ddTHH:mm:ss")
        If emp.FechaMod.HasValue Then fila("FechaMod") = emp.FechaMod.Value.ToString("yyyy-MM-ddTHH:mm:ss")

        ' Resto de campos sencillos
        fila("MunicipioNacimiento") = emp.MunicipioNacimiento
        fila("LugarExpDoc") = emp.LugarExpDoc
        fila("Direccion") = emp.Direccion
        fila("Barrio") = emp.Barrio
        fila("Municipio") = emp.Municipio
        fila("Email1") = emp.Email1
        fila("Email2") = emp.Email2
        fila("Profesion") = emp.Profesion.Value
        fila("PersonasaCargo") = emp.PersonasaCargo.Value
        fila("EstadoCivil") = emp.EstadoCivil.Value
        fila("Tel1") = emp.Tel1
        fila("Tel2") = emp.Tel2
        fila("NumCelular") = emp.NumCelular
        fila("WebPage") = emp.WebPage
        fila("LicConduccion") = emp.LicConduccion
        fila("LicCategoria") = emp.LicCategoria
        fila("ClaseLib") = emp.ClaseLib.Value
        fila("NumLib") = emp.NumLib
        fila("DistritoLib") = emp.DistritoLib
        fila("Comentario") = emp.Comentario
        fila("ActividadEco") = emp.ActividadEco
        fila("UsrGen") = emp.UsrGen
        fila("UsrMod") = emp.UsrMod
        fila("Pensionado") = If(emp.Pensionado.HasValue, emp.Pensionado.Value, False)
        fila("codBanco") = If(emp.codBanco.HasValue, emp.codBanco.Value, 0)
        fila("NumCuenta") = emp.NumCuenta
        fila("TipoCuenta") = If(emp.TipoCuenta.HasValue, emp.TipoCuenta.Value, 0)

        ' Foto en Base64
        If emp.Foto IsNot Nothing Then
            fila("Foto") = emp.Foto
        End If

        ' Envío a la API
        Dim datos As New JArray()
        datos.Add(fila)
        'Dim str = datos.ToString()
        Dim peticion As New ParametrosApi()
        Dim res = peticion.PostParametros("Empleados", datos)
        'Dim rs = res.Results(0).Record.ToString()
        Return res
    End Function

    ''' <summary>
    ''' Guarda imágenes asociadas a un empleado.
    ''' </summary>
    Public Function GuardaImagenesEmpleado(grupoImagenes As GalleryItemGroup,
                                          IdEmpleado As Integer,
                                          Tipo As Integer,
                                          SecTipo As Integer, Sec As Integer) As Boolean
        If grupoImagenes.Items.Count = 0 Then Return True

        Dim fotos As New List(Of Empleados_RegFot)
        For i As Integer = 0 To grupoImagenes.Items.Count - 1
            Dim img As Image = grupoImagenes.Items(i).Image
            Dim b64 As String
            Using ms As New IO.MemoryStream()
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                b64 = Convert.ToBase64String(ms.ToArray())
            End Using

            fotos.Add(New Empleados_RegFot With {
                .Sec = Sec,
                .IdEmpleado = IdEmpleado,
                .Item = CShort(i + 1),
                .Tipo = Tipo,
                .SecTipo = SecTipo,
                .Foto = b64,
                .Predeterminada = Nothing,
                .Descripcion = Nothing
            })
        Next

        Dim resultado As JArray = UpsertFotosEmpleado(fotos)
        Return (resultado IsNot Nothing AndAlso resultado.Count > 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza imágenes de empleado.
    ''' </summary>
    Public Function UpsertFotosEmpleado(fotos As IEnumerable(Of Empleados_RegFot)) As JArray
        Dim datos As New JArray()
        For Each f In fotos
            Dim fila As New JObject
            fila("IdEmpleado") = f.IdEmpleado 
                fila("Item") = f.Item
            fila("Tipo") = f.Tipo
            fila("SecTipo") = f.SecTipo
            fila("Foto") = f.Foto

            datos.Add(fila)
        Next

        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Empleados_RegFot", datos)
        Return datos
    End Function




    ''' <summary>
    ''' Inserta o actualiza una sola imagen de empleado.
    ''' </summary>
    Public Function GuardaImagenSola(img As Image,
                                     IdEmpleado As Integer,
                                     Tipo As Byte,
                                     SecTipo As Integer,
                                     Predeterminada As Boolean) As Boolean
        ' Convertir imagen a Base64
        Dim b64 As String
        Using ms As New IO.MemoryStream()
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            b64 = Convert.ToBase64String(ms.ToArray())
        End Using

        ' Construir JObject
        Dim fila As New JObject
        fila("IdEmpleado") = IdEmpleado 
            fila("Tipo") = Tipo
        fila("SecTipo") = SecTipo
        fila("Foto") = b64
        fila("Predeterminada") = If(Predeterminada, 1, 0)

        Dim datos As New JArray()
        ' Enviar a API
        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Empleados_RegFot", datos)

        Return (datos.Count > 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza la experiencia laboral de un empleado.
    ''' </summary>
    Public Function GuardaExperienciaLaboral(hist As Empleados_HistoriaLaboral) As DynamicUpsertResponseDto
        ' Construir JObject con los campos de experiencia laboral
        Dim fila As New JObject
        fila("Empleado") = hist.Empleado
        fila("Empresa") = hist.Empresa
        fila("Cargo") = hist.Cargo
        fila("FechaIngreso") = hist.FechaIngreso.Value.ToString("yyyy-MM-ddTHH:mm:ss")
        fila("FechaRetiro") = hist.FechaRetiro.Value.ToString("yyyy-MM-ddTHH:mm:ss")
        fila("TelEmpresa") = hist.TelEmpresa
        fila("Direccion") = hist.Direccion
        fila("JefeInmediato") = hist.JefeInmediato
        fila("Sec") = hist.Sec


        Dim datos As New JArray()
        datos.Add(fila)
        Dim peticion As New ParametrosApi()
        Dim res = peticion.PostParametros("Empleados_HistoriaLaboral", datos)
        Return res
    End Function

    ''' <summary>
    ''' Inserta o actualiza la información académica de un empleado.
    ''' </summary>
    Public Function GuardaInfAcademica(edu As Empleados_Educacion) As DynamicUpsertResponseDto
        Dim fila As New JObject
        fila("Sec") = edu.Sec
        fila("Empleado") = edu.Empleado
        fila("NivelEstudio") = edu.NivelEstudio
        fila("FechaGrado") = edu.FechaGrado.ToString("yyyy-MM-ddTHH:mm:ss")
        fila("Duracion") = edu.Duracion
        fila("TipoTiempo") = edu.TipoTiempo
        fila("IdTituloObtenido") = edu.IdTituloObtenido
        fila("NombreInstitucion") = edu.NombreInstitucion
        fila("MatriculaProfesional") = edu.MatriculaProfesional
        fila("LugarTitulo") = edu.LugarTitulo

        Dim datos As New JArray()
        datos.Add(fila)
        Dim peticion As New ParametrosApi()
        Dim res = peticion.PostParametros("Empleados_Educacion", datos)
        Return res
    End Function

    ''' <summary>
    ''' Inserta o actualiza un registro en tabla Familiares.
    ''' Campos de Familiares: SecIngreso, TipoIdentificacion, Identificacion,
    ''' Nombre, FechaNacimiento, Ocupacion, EmpresaWk, CargoActual,
    ''' Telefonos, Celular, Direccion, Ciudad.
    ''' </summary>
    Public Function UpsertFamiliar(fam As Familiares) As DynamicUpsertResponseDto
        Dim fila As New JObject
        fila("Sec") = fam.Sec
        fila("TipoIdentificacion") = fam.TipoIdentificacion
        fila("Identificacion") = fam.Identificacion
        fila("Nombre") = fam.Nombre
        fila("FechaNacimiento") = If(fam.FechaNacimiento.HasValue, fam.FechaNacimiento.Value.ToString("yyyy-MM-ddTHH:mm:ss"), Nothing)
        fila("Ocupacion") = fam.Ocupacion
        fila("EmpresaWk") = fam.EmpresaWk
        fila("CargoActual") = fam.CargoActual
        fila("Telefonos") = fam.Telefonos
        fila("Celular") = fam.Celular
        fila("Direccion") = fam.Direccion
        fila("Ciudad") = fam.Ciudad
        Dim datosFam As New JArray()
        datosFam.Add(fila)
        Dim peticion As New ParametrosApi()
        Dim res = peticion.PostParametros("Familiares", datosFam)
        Return res
    End Function

    ''' <summary>
    ''' Inserta o actualiza la relación entre empleado y familiar en RelFami.
    ''' Campos de RelFami: empleado, familiar, parentesco.
    ''' </summary>
    Public Function UpsertRelFamiliar(relfam As RelFami) As DynamicUpsertResponseDto
        Dim fila As New JObject
        fila("empleado") = relfam.empleado
        fila("familiar") = relfam.familiar
        fila("parentesco") = relfam.parentesco
        fila("Sec") = relfam.Sec
        Dim datosRel As New JArray()
        datosRel.Add(fila)
        Dim peticion As New ParametrosApi()
        Dim res = peticion.PostParametros("RelFami", datosRel)
        Return res
    End Function

    ''' <summary>
    ''' Inserta o actualiza la afiliación de seguridad social de un empleado.
    ''' Campos de EntesTercero: Sec, Empleado, FechaRegistro, FechaRetiro, Retirado, CausadeRetiro, SecEntesSSAP.
    ''' </summary>
    Public Function GuardaAfiliacion(af As EntesTercero) As DynamicUpsertResponseDto
        Dim fila As New JObject
        fila("Sec") = af.Sec
        fila("Empleado") = af.Empleado
        fila("FechaRegistro") = af.FechaRegistro.ToString("yyyy-MM-ddTHH:mm:ss")
        fila("FechaRetiro") = If(af.FechaRetiro.HasValue, af.FechaRetiro.Value.ToString("yyyy-MM-dd"), "1900-01-01")
        fila("Retirado") = af.Retirado
        fila("CausadeRetiro") = af.CausadeRetiro
        fila("SecEntesSSAP") = af.SecEntesSSAP

        Dim datos As New JArray()
        datos.Add(fila)
        Dim peticion As New ParametrosApi()
        Dim res = peticion.PostParametros("EntesTercero", datos)
        Return res
    End Function
End Class
