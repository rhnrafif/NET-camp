

Rincian Tabel Tersebut, sebagai Berikut:
Table Name = murid
Column = id, names, parent_id

Query to display same result based on test :

SELECT m.id, m.names, s.names as parent_name FROM murid m
LEFT JOIN murid s ON m.parent_id = s.id