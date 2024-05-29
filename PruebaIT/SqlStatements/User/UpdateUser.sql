Update Pacientes 
SET [Name] = @Name, [Date] = @Date,[Email] = @Email, [Gender] = @Gender, [Address] = @Address,[Phone] = @Phone, [DateA] = @DateA
WHERE [Id] =  @Id;