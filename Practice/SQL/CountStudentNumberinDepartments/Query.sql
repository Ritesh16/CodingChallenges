SELECT
	d.dept_name,
	count(s.student_id) as student_number
FROM Department d
LEFT OUTER JOIN Student s on d.dept_id = s.dept_id
group by d.dept_name
order by count(s.student_id) desc, d.dept_name