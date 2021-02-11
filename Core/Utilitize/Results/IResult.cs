using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilitize.Results
{
  public interface IResult
    {
        bool Succes { get; }
        string Message { get; }
    }
}
