using AutoMapper;

using Debtors.BL.Students.Entities;
using Debtors.DataAccess.Entities;
using Debtors.DataAccess.Repository;

namespace Debtors.BL.Students;

public class StudentManager(IRepository<DebtEntity> studentsRepository, IMapper mapper) : IManager<UserModel, CreateUserModel>
{
    private readonly IRepository<DebtEntity> _studentsRepository = studentsRepository;
    private readonly IMapper _mapper = mapper;

    public StudentModel Create(CreateStudentModel model)
    {
        var entity = _mapper.Map<DebtEntity>(model);

        _studentsRepository.Save(entity);

        return _mapper.Map<StudentModel>(entity);
    }

    public StudentModel Update(Guid id, StudentModel model)
    {
        var student = Find(id);

        student.Name = model.Name;
        student.Course = model.Course;
        student.Email = model.Email;
        student.PasswordHash = model.PasswordHash;
        student.Debts = (ICollection<DebtEntity>?)model.Debts;

        _studentsRepository.Save(student);

        return _mapper.Map<StudentModel>(student);
    }

    public void Delete(Guid id)
    {
        _studentsRepository.Delete(Find(id));
    }

    private DebtEntity Find(Guid id)
    {
        return _studentsRepository.GetById(id) ?? throw new InvalidOperationException($"Student with ID {id} not found.");
    }
}
