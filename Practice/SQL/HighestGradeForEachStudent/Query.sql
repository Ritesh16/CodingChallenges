SELECT sub.student_id, sub.course_id, sub.grade
FROM
(SELECT student_id, course_id, grade,
DENSE_RANK() OVER (PARTITION BY student_id ORDER BY grade DESC, course_id ASC) AS Rank
FROM enrollments) AS sub
WHERE sub.Rank = 1