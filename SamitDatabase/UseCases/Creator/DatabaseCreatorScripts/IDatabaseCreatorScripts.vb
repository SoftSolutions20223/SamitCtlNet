Public Interface IDatabaseCreatorScripts
    Sub GenerarComandoCrearDB(Optional esCloud As Boolean = False)
    Sub GenerarComandoActualizaDB(Optional tablaOp As SqlTable = Nothing)
    Sub GenerarActualizarObjetosBaseDatos()
    Sub GenerarComandoActualizaLlavesForaneas(tabla As SqlTable, Optional esCloud As Boolean = False)
End Interface
