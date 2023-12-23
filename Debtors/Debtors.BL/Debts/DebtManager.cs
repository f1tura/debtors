using AutoMapper;

using Debtors.BL.Debts.Entities;
using Debtors.DataAccess;
using Debtors.DataAccess.Entities;
using Debtors.DataAccess.Repository;

namespace Debtors.BL.Debts;

public class DebtManager(IRepository<DebtEntity> debtsRepository, IMapper mapper) : IManager<DebtModel, CreateDebtModel>
{
    private readonly IRepository<DebtEntity> _debtsRepository = debtsRepository;
    private readonly IMapper _mapper = mapper;

    public DebtModel Create(CreateDebtModel model)
    {
        var entity = _mapper.Map<DebtEntity>(model);

        _debtsRepository.Save(entity);

        return _mapper.Map<DebtModel>(entity);
    }

    public DebtModel Update(Guid id, DebtModel model)
    {
        var debt = Find(id);

        debt.Student.ExternalId = model.StudentId;
        debt.Subject.ExternalId = model.SubjectId;
        debt.DebtDay = model.DebtDay;
        
        _debtsRepository.Save(debt);

        return _mapper.Map<DebtModel>(debt);
    }

    public void Delete(Guid id)
    {
        _debtsRepository.Delete(Find(id));
    }

    private DebtEntity Find(Guid id)
    {
        return _debtsRepository.GetById(id) ?? throw new InvalidOperationException($"Debt with ID {id} not found.");
    }
}
