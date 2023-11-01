using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new ExportHelper();
exportHelper.ExportEstudent(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");