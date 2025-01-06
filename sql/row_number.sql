with paginatedResults as (
    select employee_id, salary
    row_number() over (order by salary desc) as row_num
    from employees
)
select employee_id, salary
from paginatedResults
where row_num between 1 and 5;