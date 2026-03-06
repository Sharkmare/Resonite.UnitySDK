using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public interface IResoniteLinkPostProcessor
{
    void PostProcessConversion(IConversionContext context);
}
