using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public sealed record BookingCompletedDomainEvent(Guid bookingId) : IDomainEvent;
