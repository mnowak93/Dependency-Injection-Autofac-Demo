using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProccesData()
        {
            _logger.Log("Starting the processing of data");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Saving the data");
            _logger.Log("Finishing processing of the data");
        }
    }
}
