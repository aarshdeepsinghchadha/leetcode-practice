with paginatedResults as (
    select employee_id, salary
    row_number() over (order by salary desc) as row_num
    from employees
)
select employee_id, salary
from paginatedResults
where row_num between 1 and 5;



--- top n employees by salary using row_number

with rankedEmployees as (
    select employee_id, salary,
    row_number() over (order by salary desc) as row_num
    from employees
)
select employee_id, salary
from rankedEmployees
where row_num < = n;


-- most recent order for each customer using row_number()

with RecentOrder as (
    select customer_id, order_id, order_data,
    row_number() over(partition by customer_id order by order_date desc )as row_nume
    from employeees
)
select customer_id, order_id, order_date
from RecentOrder
where row_nume = 1;


-- duplicate using row_number

with duplicateReords as (
    select employee_id, email,
    row_number() over (partition by email order by employee_id) as row_num
    from employees
)
select employee_id, email
from duplicateReords
where row_num > 1;