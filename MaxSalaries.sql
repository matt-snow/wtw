SELECT d.name as 'Department', e.name as 'Employee', e.salary from Employee e
INNER JOIN
(
  SELECT departmentId, MAX(salary) AS max_salary
  FROM Employee
  GROUP BY departmentId
) m
ON e.departmentId = m.departmentId AND e.salary = max_salary
INNER JOIN department d ON e.departmentId = d.departmentId;