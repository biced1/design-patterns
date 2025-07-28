using System;

namespace Adapter.Blueprint;

public class LegacyService
{
    public SpecialResponse ServiceMethod(SpecialData data)
    {
        ///perform some complex business logic and return special model
        return new SpecialResponse();
    }
}
