Public Module SamitDefinitions

    Public Function RemoveNoCloudTables(listaTablas As List(Of SqlTable), esCloud As Boolean, tipoDb As DatabasesSamit) As List(Of SqlTable)
        If Not esCloud And tipoDb = DatabasesSamit.Seguridad Then
            Dim Lista = listaTablas.Where(Function(L) L.Nombre = "ClienteSamit" Or L.Nombre = "UsuariosClienteSamit").ToList()
            For Each Tabla In Lista
                listaTablas.Remove(Tabla)
            Next
        End If

        Return listaTablas
    End Function

    Public Function GetComandosAdicionalesActualizaDb() As List(Of String)
        Dim comandosSQL As New List(Of String) From {
            "
                IF (SELECT COUNT(*) FROM sysobjects WHERE (name = 'Catalogo_ITrig')) > 0
                    DROP TRIGGER [Catalogo_ITrig]
            ",
            "
                IF (SELECT COUNT(*) FROM sysobjects WHERE (name = 'Catalogo_UTrig')) > 0
                    DROP TRIGGER [Catalogo_UTrig]
            "
        }
        Return comandosSQL
    End Function

    Public Function GetComandosAdicionalesActualizaTabla(tabla As SqlTable) As List(Of String)
        Dim tableName = tabla.Nombre

        If tableName = "IN_Documento" Then
            Return New List(Of String) From {
                "
                    IF OBJECT_ID('dbo.[INX_DOCUMENTO_TIPODOC_PREFIJO]') IS NOT NULL 
                        DROP INDEX [INX_DOCUMENTO_TIPODOC_PREFIJO] ON [dbo].[IN_Documento]
                ",
                "
                    IF OBJECT_ID('dbo.[IX_IN_DocComprobante]') IS NOT NULL 
                        DROP INDEX [IX_IN_DocComprobante] ON [dbo].[IN_Documento]
                ",
                "
                    IF OBJECT_ID('dbo.[FK_IN_Documento_IN_Vendedor]') IS NOT NULL 
                        ALTER TABLE [dbo].[IN_Documento] DROP CONSTRAINT [FK_IN_Documento_IN_Vendedor]
                "
            }
            'ListadoComandosSQL.Add("DROP INDEX [INX_DOCUMENTO_TIPODOC_PREFIJO] ON [dbo].[IN_Documento]")
            'ListadoComandosSQL.Add("DROP INDEX [IX_IN_DocComprobante] ON [dbo].[IN_Documento]")
            'ListadoComandosSQL.Add("ALTER TABLE [dbo].[IN_Documento] DROP CONSTRAINT [FK_IN_Documento_IN_Vendedor]")
        End If
        If tableName = "IN_ListaCliente" Then
            Return New List(Of String) From {
                "
                    IF OBJECT_ID('dbo.[PKA_IN_ListaCliente]') IS NOT NULL 
                        ALTER TABLE dbo.[IN_ListaCliente] DROP CONSTRAINT PKA_IN_ListaCliente
                ",
                "
                    IF OBJECT_ID('dbo.[PK_IN_ListaCliente]') IS NOT NULL 
                        ALTER TABLE dbo.[IN_ListaCliente] DROP CONSTRAINT PK_IN_ListaCliente
                ",
                "
                    ALTER TABLE IN_ListaCliente ALTER COLUMN Cliente INT NULL
                ",
                "
                    ALTER TABLE IN_ListaCliente ADD ClienteDoc BIGINT NULL
                ",
                "
                    UPDATE IN_ListaCliente 
                    SET ClienteDoc = (SELECT TOP(1) G_Clientes.Identificacion FROM G_Clientes WHERE (G_Clientes.IdCliente = IN_ListaCliente.Cliente)) 
                    WHERE ClienteDoc IS NULL
                ",
                "
                    ALTER TABLE IN_ListaCliente ALTER COLUMN ClienteDoc BIGINT NOT NULL
                "
            }
        End If

        Return New List(Of String)
    End Function

End Module
