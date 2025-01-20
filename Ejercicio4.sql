EXEC xp_cmdshell 'bcp "SELECT 
    REPLACE(REPLACE(CampoTexto1, CHAR(13), ''''), CHAR(10), '''') AS CampoTexto1,
    REPLACE(REPLACE(CampoTexto2, CHAR(13), ''''), CHAR(10), '''') AS CampoTexto2,
    REPLACE(REPLACE(CampoTexto3, CHAR(13), ''''), CHAR(10), '''') AS CampoTexto3,
    REPLACE(REPLACE(CampoTexto4, CHAR(13), ''''), CHAR(10), '''') AS CampoTexto4,
    SUM(CampoNumerico1) AS TotalNumerico1,
    SUM(CampoNumerico2) AS TotalNumerico2,
    SUM(CampoNumerico3) AS TotalNumerico3,
    SUM(CampoNumerico4) AS TotalNumerico4,
    SUM(CampoNumerico5) AS TotalNumerico5
FROM #TablaTemporal
GROUP BY 
    CampoTexto1, CampoTexto2, CampoTexto3, CampoTexto4
HAVING 
    SUM(CampoNumerico1) > 10
ORDER BY 
    TotalNumerico5 DESC;" queryout "C:\archivo_reporte.csv" -c -t, -T -S localhost';
