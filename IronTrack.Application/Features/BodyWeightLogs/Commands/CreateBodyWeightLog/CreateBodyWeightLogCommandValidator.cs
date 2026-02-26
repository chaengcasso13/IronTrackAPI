using FluentValidation;
using IronTrack.Application.Contracts.Persistence;

namespace IronTrack.Application.Features.BodyWeightLogs.Commands.CreateBodyWeightLog;

public class CreateBodyWeightLogCommandValidator : AbstractValidator<CreateBodyWeightLogCommand>
{
    private readonly IBodyWeightLogRepository _bodyWeightLogRepository;

    // start adding rules
    public CreateBodyWeightLogCommandValidator(IBodyWeightLogRepository bodyWeightLogRepository)
    {
        RuleFor(p => p.WeightKg)
            .NotEmpty()
            .WithMessage("{PropertyName} is required.")
            .NotNull();

        // NOTE: Placeholder for checking if exist in DB. Not Applicable for BodyWeightLog.
        RuleFor(q => q.WeightKg)
            .MustAsync(WeightKgUnique)
            .WithMessage("WeightKg already exist.");

        this._bodyWeightLogRepository = bodyWeightLogRepository;
    }

    // NOTE: placeholder for checking if exist in DB. Not Applicable for BodyWeightLog. 
    //      Must be if data to be added should be unique.
    private Task<bool> WeightKgUnique(decimal weightKg, CancellationToken token)
    {
        return _bodyWeightLogRepository.IsBodyWeightLogUnique(weightKg);
    }
    // TODO: Delete
    private Task<bool> WeightKgUnique(CreateBodyWeightLogCommand command, CancellationToken token)
    {
        return _bodyWeightLogRepository.IsBodyWeightLogUnique(command.WeightKg);
    }
}
