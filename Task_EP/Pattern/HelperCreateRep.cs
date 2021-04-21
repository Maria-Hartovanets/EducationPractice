using System;
using System.Collections.Generic;
using System.Linq;
using Task_EP.Repository;
using System.Configuration;
namespace Task_EP.Pattern
{
    public class HelperCreateRep
    {
    public static AbstractFactoryPattern CreateRepositoryOfPattern()
        {
            var factory = ConfigurationManager.AppSettings["factoryType"];
            switch (factory.ToLower())
            {
                case "file":
                    return new RealizationPatternFile();

                default:
                    return new RealizationPattern();

            }
        }
    }
}
