Imports SamitDatabase

<SqlTable(Nombre:="CT_PlandeCuentas", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CT_PlandeCuentas
    <SqlColumn(Nombre:="CodCuenta", LlavePrimaria:=True, TipoDato:=SqlType.VarChar, LargoColumna:=10, AceptaNull:=False)>
    Public Property CodCuenta As String
    <SqlColumn(Nombre:="NomCuenta", TipoDato:=SqlType.VarChar, LargoColumna:=100, AceptaNull:=False)>
    Public Property NomCuenta As String
    <SqlColumn(Nombre:="NatCuenta", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property NatCuenta As Boolean
    <SqlColumn(Nombre:="TerCuenta", TipoDato:=SqlType.VarChar, LargoColumna:=1, AceptaNull:=False)>
    Public Property TerCuenta As String
    <SqlColumn(Nombre:="TipoRetefuente", TipoDato:=SqlType.TinyInt)>
    Public Property TipoRetefuente As Byte?
    <SqlColumn(Nombre:="Detalla", TipoDato:=SqlType.VarChar, LargoColumna:=1, AceptaNull:=False)>
    Public Property Detalla As String
    <SqlColumn(Nombre:="ManejaCC", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property ManejaCC As Boolean
    <SqlColumn(Nombre:="SeAjusta", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property SeAjusta As String
    <SqlColumn(Nombre:="AjLlevaCuenta", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property AjLlevaCuenta As String
    <SqlColumn(Nombre:="AjContraCuenta", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property AjContraCuenta As String
    <SqlColumn(Nombre:="LlevaAOrden", TipoDato:=SqlType.Bit)>
    Public Property LlevaAOrden As Boolean?
    <SqlColumn(Nombre:="AjLlevaOrden", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property AjLlevaOrden As String
    <SqlColumn(Nombre:="AjContraOrden", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property AjContraOrden As String
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.VarChar, LargoColumna:=1, AceptaNull:=False)>
    Public Property Estado As String
    <SqlColumn(Nombre:="EsdeAjustes", TipoDato:=SqlType.Bit)>
    Public Property EsdeAjustes As Boolean?
    <SqlColumn(Nombre:="EsdeMovimiento", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property EsdeMovimiento As Boolean
    <SqlColumn(Nombre:="PermiteSaldoCNat", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property PermiteSaldoCNat As Boolean
    <SqlColumn(Nombre:="PermiteMovtoCNat", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property PermiteMovtoCNat As Boolean
    <SqlColumn(Nombre:="Nivel", TipoDato:=SqlType.TinyInt, AceptaNull:=False)>
    Public Property Nivel As Byte
    <SqlColumn(Nombre:="Corriente", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property Corriente As Boolean
    <SqlColumn(Nombre:="Disponible", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property Disponible As Boolean
    <SqlColumn(Nombre:="FechaMod", TipoDato:=SqlType.DateTime)>
    Public Property FechaMod As Date?
    <SqlColumn(Nombre:="UsrMod", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property UsrMod As String
    <SqlColumn(Nombre:="FechaGen", TipoDato:=SqlType.DateTime)>
    Public Property FechaGen As Date?
    <SqlColumn(Nombre:="UsrGen", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property UsrGen As String
    <SqlColumn(Nombre:="SecCuenta", TipoDato:=SqlType.Int)>
    Public Property SecCuenta As Integer?
    <SqlColumn(Nombre:="EsdeAportes", TipoDato:=SqlType.Bit)>
    Public Property EsdeAportes As Boolean?
    <SqlColumn(Nombre:="EsdeBancos", TipoDato:=SqlType.Bit)>
    Public Property EsdeBancos As Boolean?
    <SqlColumn(Nombre:="EsdeAnticipos", TipoDato:=SqlType.Bit)>
    Public Property EsdeAnticipos As Boolean?
    <SqlColumn(Nombre:="TerCierre", TipoDato:=SqlType.BigInt)>
    Public Property TerCierre As Long?
    <SqlColumn(Nombre:="CierraTer", TipoDato:=SqlType.Bit)>
    Public Property CierraTer As Boolean?
    <SqlColumn(Nombre:="CtrVehi", TipoDato:=SqlType.Bit)>
    Public Property CtrVehi As Boolean?
    <SqlColumn(Nombre:="ManejoNIIF", TipoDato:=SqlType.TinyInt, AceptaNull:=False)>
    Public Property ManejoNIIF As Byte
    <SqlColumn(Nombre:="CodCtaNIIF", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property CodCtaNIIF As String
    <SqlColumn(Nombre:="UtilizaCP", TipoDato:=SqlType.Bit)>
    Public Property UtilizaCP As Boolean?
    <SqlColumn(Nombre:="TipoCP", TipoDato:=SqlType.SmallInt)>
    Public Property TipoCP As Short?
    <SqlColumn(Nombre:="CodFEDB", TipoDato:=SqlType.SmallInt)>
    Public Property CodFEDB As Short?
    <SqlColumn(Nombre:="CodFECR", TipoDato:=SqlType.SmallInt)>
    Public Property CodFECR As Short?
End Class