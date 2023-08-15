using Bookify.Domain.Share;

namespace Bookify.Domain.Bookings;
public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);
