-- employee_id salary Rank DenseRank
-- 1           100     1   1
-- 2           100     1   1
-- 3           200     3   2
-- 4           300     4   3     
-- 5           400     5   4

With RankedSalaries as (
    select employee_id, salary,
    Rank() over (order by salary desc) as rank
    from employees
)
select employee_id, salary
from RankedSalaries
where rank <= 5;


With DenseRankedSalaries as (
    select employee_id, salary,
    DENSE_RANK() over (order by salary desc) as dense_rank
    from employees
)
select employee_id, salary
from DenseRankedSalaries
where dense_rank <= 5;


-- second highest salary using dense_rank()

with RankedSalaries as (
    select salary,
    DENSE_RANK() OVER (ORDER by salary desc) as dense_rank
    from employees
)
select employee_id, salary
from RankedSalaries
where dense_rank = 2;


-- rank employees based on multiple columns using Rank()

select employee_id, department_id, salary,
RANK() over (partition by department_id order by salary desc) as rank
from employees


-- duplicate record

with duplicateData as (
    select employee_id, department_id,
    rank() over (PARTITION by department_id order by salary desc) as rank
    from employees
)
select employee_id, department_id
from duplicateData
where rank > 1;


-- top N employeees in each department using dense_rank()

with RankedEmployees as (
    select employee_id, department_id, salary, 
    Dense_Rank() over (partition by department_id order by salary desc) as rank
    from employees
)
select employee_id, department_id, salary
from RankedEmployees
where rank <= 3;





