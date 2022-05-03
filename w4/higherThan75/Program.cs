select Name
from students
where marks > 75
order by RIGHT(Name,3) ASC, ID ASC;