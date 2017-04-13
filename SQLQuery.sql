--SELECT *
--FROM hodnoceni;

--SELECT *
--FROM student LEFT OUTER JOIN predmetstudent ON student.id = predmetstudent.id_student
--WHERE id_student IS NOT NULL;

SELECT prijmeni
FROM student
order by 
GROUP BY prijmeni;


SELECT zkratka, COUNT(id_student) as Pocet from predmet
left join predmetstudent on zkratka = id_predmet
GROUP BY zkratka HAVING COUNT(id_student) < 3;