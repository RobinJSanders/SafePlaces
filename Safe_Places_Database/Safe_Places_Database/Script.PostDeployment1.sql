MERGE INTO Archive AS Target 
USING (VALUES 
        (1, 'None-Critical', '2013-09-01'), 
        (2, 'Critical', '2014-10-23'), 
        (3, 'None-Critical', '2015-11-28')
) 
AS Source (Archive_ID, Critical, Archive_Date) 
ON Target.Archive_ID = Source.Archive_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Archive_ID, Critical) 
VALUES (Archive_ID, Critical);

MERGE INTO Safe_Location AS Target
USING (VALUES 
        (1, 'Boots', '1001'), 
        (2, 'Game', '1022'), 
        (3, 'PoundLand', '1303')
)
AS Source (Location_ID, Busness_name, Pin)
ON Target.Location_ID = Source.Location_ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Location_ID, Busness_name, Pin)
VALUES (Location_ID, Busness_name, Pin);
