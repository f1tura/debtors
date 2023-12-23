using AutoMapper;

using Debtors.BL.Debts.Entities;
using Debtors.DataAccess;
using Debtors.DataAccess.Entities;
using Debtors.DataAccess.Repository;

namespace Debtors.BL.Debts;

public class DebtProvider(IRepository<DebtEntity> debtsRepository, IMapper mapper) : IProvider<DebtModel, DebtsModelFilter>
{
    private readonly IRepository<DebtEntity> _repository = debtsRepository;
    private readonly IMapper _mapper = mapper;

    public IEnumerable<DebtModel> Get(DebtsModelFilter? modelFilter)
    {
        DateTime? DebtDay = modelFilter?.DebtDay;
        

        var debts = _repository.GetAll(debt => (
        (DebtDay == null )));

        return _mapper.Map<IEnumerable<DebtModel>>(debts);
    }

    public DebtModel GetInfo(Guid id)
    {
        return _mapper.Map<DebtModel>(Find(id));
    }

    private DebtEntity Find(Guid id)
    {
        return _repository.GetById(id) ?? throw new InvalidOperationException($"Debt with ID {id} not found.");
    }
}