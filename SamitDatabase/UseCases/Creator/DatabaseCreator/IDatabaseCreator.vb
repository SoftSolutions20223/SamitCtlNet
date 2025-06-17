Imports SamitCoreApi

Public Interface IDatabaseCreator
    Function CrearBaseDatosNueva(token As TokenData, baseDatos As SqlDatabase, Optional conParametrosIniciales As Boolean = False) As ApiResponse
    Function CrearBaseDatosAñoNueva(token As TokenData, empresa As Integer, año As Integer, conParametrosIniciales As Boolean) As ApiResponse
    Function CrearBaseDatosGeneralNueva(token As TokenData, empresa As Integer, conParametrosIniciales As Boolean) As ApiResponse
    Function ActualizarBaseDatosSiNecesario(token As TokenData, baseDatos As SqlDatabase, Optional revalidarCampos As Boolean = False, Optional EsCloud As Boolean = False) As ApiResponse
    Function ActualizaTablaBaseDatos(token As TokenData, baseDatos As SqlDatabase, NombreTabla As String) As ApiResponse
End Interface
