CREATE TABLE reqAssessment (
[id] int NOT NULL FOREIGN KEY REFERENCES employees(id),
form int NOT NULL,
TIN  int NOT NULL,
medical int NOT NULL,
NSO  int NOT NULL,
NSO_Mother int ,
NSO_Father int ,
Marriage_Contract int , 
dependents varchar(50),
NSO_child1 int ,
NSO_child2 int ,
NSO_child3 int 
)