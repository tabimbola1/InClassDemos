<Query Kind="Statements">
  <Connection>
    <ID>73570996-92ee-41be-a372-940f21dbe766</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

 var EmployeeYOECollection = from eachEmployee in Employees 
                          select new 
						  {
						   Name = eachEmployee.LastName + "" +
						    eachEmployee.FirstName , 
							YOE = eachEmployee.EmployeeSkills.Sum(eachEmployeeSkillrow => eachEmployeeSkillrow.YearsOfExperience) 
						  };
						
				EmployeeYOECollection.Dump();
				
				var MaxYOE= EmployeeYOECollection.Max(eachEYOECrow => eachEYOECrow.YOE);
				MaxYOE.Dump();
				
				//question 5 
				var finallist = from xxx in EmployeeYOECollection 
				where  condition 
				slect xxxx.nName;
				