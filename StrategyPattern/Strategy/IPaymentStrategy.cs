using System;

namespace StrategyPattern.Strategy;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}
