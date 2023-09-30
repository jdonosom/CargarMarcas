
DROP table #tmp 

SELECT [IdHorario]
      ,[Descripcion]
      ,[Lunes]
      ,[L_EntradaMañana]
      ,[L_SalidaMañana]
      ,[L_EntradaTarde]
      ,[L_SalidaTarde]
      ,[L_ToleranciaEntrada]
      ,[L_ToleranciaSalida]
	  ,CASE WHEN L_EntradaMañana is not null and L_SalidaMañana is not null THEN DATEDIFF( hh, L_EntradaMañana, L_SalidaMañana ) END L_HorasTrabMañana
	  ,CASE WHEN L_EntradaTarde is not null and L_SalidaTarde is not null THEN DATEDIFF( hh, L_EntradaTarde, L_SalidaTarde) END L_HorasTrabTarde
      ,[Martes]
      ,[M_EntradaMañana]
      ,[M_SalidaMañana]
      ,[M_EntradaTarde]
      ,[M_SalidaTarde]
      ,[M_ToleranciaEntrada]
      ,[M_ToleranciaSalida]
	  ,CASE WHEN M_EntradaMañana is not null and M_SalidaMañana is not null THEN DATEDIFF( hh, M_EntradaMañana, M_SalidaMañana ) END M_HorasTrabMañana
	  ,CASE WHEN M_EntradaTarde is not null  and M_SalidaTarde is not null  THEN DATEDIFF( hh, M_EntradaTarde,  M_SalidaTarde)   END M_HorasTrabTarde
      ,[Miercoles]
      ,[X_EntradaMañana]
      ,[X_SalidaMañana]
      ,[X_EntradaTarde]
      ,[X_SalidaTarde]
      ,[X_ToleranciaEntrada]
      ,[X_ToleranciaSalida]
	  ,CASE WHEN X_EntradaMañana is not null and X_SalidaMañana is not null THEN DATEDIFF( hh, X_EntradaMañana, X_SalidaMañana ) END X_HorasTrabMañana
	  ,CASE WHEN X_EntradaTarde is not null  and X_SalidaTarde is not null  THEN DATEDIFF( hh, X_EntradaTarde,  X_SalidaTarde)   END X_HorasTrabTarde
      ,[Jueves]
      ,[J_EntradaMañana]
      ,[J_SalidaMañana]
      ,[J_EntradaTarde]
      ,[J_SalidaTarde]
      ,[J_ToleranciaEntrada]
      ,[J_ToleranciaSalida]
	  ,CASE WHEN J_EntradaMañana is not null and J_SalidaMañana is not null THEN DATEDIFF( hh, J_EntradaMañana, J_SalidaMañana ) END J_HorasTrabMañana
	  ,CASE WHEN J_EntradaTarde is not null  and J_SalidaTarde is not null  THEN DATEDIFF( hh, J_EntradaTarde,  J_SalidaTarde)   END J_HorasTrabTarde
      ,[Viernes]
      ,[V_EntradaMañana]
      ,[V_SalidaMañana]
      ,[V_EntradaTarde]
      ,[V_SalidaTarde]
      ,[V_ToleranciaEntrada]
      ,[V_ToleranciaSalida]
	  ,CASE WHEN V_EntradaMañana is not null and V_SalidaMañana is not null THEN DATEDIFF( hh, V_EntradaMañana, V_SalidaMañana ) END V_HorasTrabMañana
	  ,CASE WHEN V_EntradaTarde is not null  and V_SalidaTarde is not null  THEN DATEDIFF( hh, V_EntradaTarde,  V_SalidaTarde)   END V_HorasTrabTarde
      ,[Sabado]
      ,[S_EntradaMañana]
      ,[S_SalidaMañana]
      ,[S_EntradaTarde]
      ,[S_SalidaTarde]
      ,[S_ToleranciaEntrada]
      ,[S_ToleranciaSalida]
	  ,CASE WHEN S_EntradaMañana is not null and S_SalidaMañana is not null THEN DATEDIFF( hh, S_EntradaMañana, S_SalidaMañana ) END S_HorasTrabMañana
	  ,CASE WHEN S_EntradaTarde is not null  and S_SalidaTarde is not null  THEN DATEDIFF( hh, S_EntradaTarde,  S_SalidaTarde)   END S_HorasTrabTarde
      ,[Domingo]
      ,[D_EntradaMañana]
      ,[D_SalidaMañana]
      ,[D_EntradaTarde]
      ,[D_SalidaTarde]
      ,[D_ToleranciaEntrada]
      ,[D_ToleranciaSalida]
	  ,CASE WHEN D_EntradaMañana is not null and D_SalidaMañana is not null THEN DATEDIFF( hh, D_EntradaMañana, D_SalidaMañana ) END D_HorasTrabMañana
	  ,CASE WHEN D_EntradaTarde is not null  and D_SalidaTarde is not null  THEN DATEDIFF( hh, D_EntradaTarde,  D_SalidaTarde)   END D_HorasTrabTarde
      ,[TotalHorasSemanales]
      ,[Desde]
      ,[Hasta]
  INTO #tmp
  FROM [SGM].[dbo].[Horario] WHERE IdHorario = 4


  select *
        ,(IsNull(L_HorasTrabMañana, 0)+IsNull(L_HorasTrabTarde,0) + CASE WHEN L_HorasTrabMañana IS NULL OR L_HorasTrabTarde IS NULL THEN 0 ELSE 1 END) +
		 (IsNull(M_HorasTrabMañana, 0)+IsNull(M_HorasTrabTarde,0) + CASE WHEN M_HorasTrabMañana IS NULL OR M_HorasTrabMañana IS NULL THEN 0 ELSE 1 END) +
		 (IsNull(X_HorasTrabMañana, 0)+IsNull(X_HorasTrabTarde,0) + CASE WHEN X_HorasTrabMañana IS NULL OR X_HorasTrabMañana IS NULL THEN 0 ELSE 1 END) +
		 (IsNull(J_HorasTrabMañana, 0)+IsNull(J_HorasTrabTarde,0) + CASE WHEN J_HorasTrabMañana IS NULL OR J_HorasTrabMañana IS NULL THEN 0 ELSE 1 END) +
		 (IsNull(V_HorasTrabMañana, 0)+IsNull(V_HorasTrabTarde,0) + CASE WHEN V_HorasTrabMañana IS NULL OR V_HorasTrabMañana IS NULL THEN 0 ELSE 1 END) +
		 (IsNull(S_HorasTrabMañana, 0)+ISNULL(S_HorasTrabTarde,0) + CASE WHEN S_HorasTrabMañana is null or S_HorasTrabTarde is null THEN 0 ELSE 1 END) +
		 (IsNull(D_HorasTrabMañana, 0)+IsNull(D_HorasTrabTarde,0) + CASE WHEN D_HorasTrabMañana IS NULL OR D_HorasTrabTarde IS NULL THEN 0 ELSE 1 END) HorasSemanales from #tmp

--  [HorarioSelProc] 4