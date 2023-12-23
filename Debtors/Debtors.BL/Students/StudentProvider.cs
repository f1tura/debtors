using AutoMapper;

using Debtors.BL.Students.Entities;
using Debtors.DataAccess.Entities;
using Debtors.DataAccess.Repository;

namespace Debtors.BL.Students;

public class StudentProvider(IRepository<DebtEntity> usersRepository, IMapper mapper) : IProvider<StudentModel, StudentsModelFilter>
{
    private readonly IRepository<DebtEntity> _repository = usersRepository;
    private readonly IMapper _mapper = mapper;

    public IEnumerable<StudentModel> Get(StudentsModelFilter? modelFilter)
    {
        string? name = modelFilter?.Name;
        string? email = modelFilter?.email;
        
        var students = _repository.GetAll(student => (
        (name == null || student.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
        (email == null || student.Email.Contains(email, StringComparison.OrdinalIgnoreCase))
        ));

        return _mapper.Map<IEnumerable<StudentModel>>(students);
    }

    public StudentModel GetInfo(Guid id)
    {
        return _mapper.Map<StudentModel>(Find(id));
    }

    private DebtEntity Find(Guid id)
    {
        return _repository.GetById(id) ?? throw new InvalidOperationException($"Student with ID {id} not found.");
    }
}