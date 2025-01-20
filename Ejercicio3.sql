DECLARE @contador INT = 1;

WHILE @contador <= 5000000
BEGIN
    INSERT INTO #TablaTemporal (Id, CampoTexto1, CampoTexto2, CampoTexto3, CampoTexto4, 
                                CampoNumerico1, CampoNumerico2, CampoNumerico3, CampoNumerico4, CampoNumerico5)
    VALUES (
        @contador,                            
        'Texto' + CAST(@contador AS NVARCHAR), 
        'Texto' + CAST(@contador AS NVARCHAR),
        'Texto' + CAST(@contador AS NVARCHAR),
        'Texto' + CAST(@contador AS NVARCHAR),
        RAND() * 1000,                       
        RAND() * 1000,
        RAND() * 1000,
        RAND() * 1000,
        RAND() * 1000
    );
    SET @contador += 1;
END

PRINT 'Registros totales en la tabla temporal:';
SELECT COUNT(*) AS TotalRegistros FROM #TablaTemporal;

SELECT TOP 10 * FROM #TablaTemporal order by id desc;
