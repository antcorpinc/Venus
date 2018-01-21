using System;
using System.Collections.Generic;
using System.Text;

namespace Venus.Core.Contracts
{
    public interface IIdentifiableModel<T>
    {
        T Id { get; set; }
    }
}
