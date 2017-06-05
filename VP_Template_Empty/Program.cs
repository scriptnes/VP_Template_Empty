using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace VP_demo_1
{
    class Program
    {
        private static IExit Exit;
        private static IFindVehicle FindVehicle;
        private static IPark Park;
        private static ISetupPark SetupPark;
        private static IStatus Status;
        private static IVehiclesByOwner VehiclesByOwner;

        static void Main()
        {
            //Engine engine = new Engine(SetupPark, Park, Exit, FindVehicle, VehiclesByOwner, Status);
            var container = new WindsorContainer();
            container.Register(Component.For<Engine>());
            container.Register(Component.For<ISetupPark>().ImplementedBy<SetupPark>());
            container.Register(Component.For<IStatus>().ImplementedBy<Status>());
            container.Register(Component.For<IExit>().ImplementedBy<Exit>());
            container.Register(Component.For<IFindVehicle>().ImplementedBy<FindVehicle>());
            container.Register(Component.For<IVehiclesByOwner>().ImplementedBy<VehiclesByOwner>());
            container.Register(Component.For<IPark>().ImplementedBy<Park>());


            var eng = container.Resolve<Engine>();
            eng.Run();



        }


    }

    public class VehiclesByOwner : IVehiclesByOwner
    {
        public string SomeObject { get; set; }

        public void LicensePlate()
        {
            throw new NotImplementedException();
        }

        public void Owner()
        {
            throw new NotImplementedException();
        }

        public void Place()
        {
            throw new NotImplementedException();
        }

        public void Sector()
        {
            throw new NotImplementedException();
        }

        public void Type()
        {
            throw new NotImplementedException();
        }
    }

    public class Status : IStatus
    {
        public string SomeObject { get; set; }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }
    }

    public class SetupPark : ISetupPark
    {
        public string SomeObject { get; set; }

        public void Created()
        {
            throw new NotImplementedException();
        }

        public void PlacesPerSectorPositive()
        {
            throw new NotImplementedException();
        }

        public void SectorsPositive()
        {
            throw new NotImplementedException();
        }

        public void TheVehicleParkHasNotBeenSetup()
        {
            throw new NotImplementedException();
        }
    }

    public class Park : IPark
    {
        public string SomeObject { get; set; }

        public void LicensePlate()
        {
            throw new NotImplementedException();
        }

        public void Place()
        {
            throw new NotImplementedException();
        }

        public void Sector()
        {
            throw new NotImplementedException();
        }

        public void Type()
        {
            throw new NotImplementedException();
        }
    }

    public class FindVehicle : IFindVehicle
    {
        public string SomeObject { get; set; }

        public void LicensePlate()
        {
            throw new NotImplementedException();
        }

        public void Owner()
        {
            throw new NotImplementedException();
        }

        public void Place()
        {
            throw new NotImplementedException();
        }

        public void Sector()
        {
            throw new NotImplementedException();
        }

        public void Type()
        {
            throw new NotImplementedException();
        }
    }

    public class Exit : IExit
    {
        public string SomeObject { get; set; }

        public void Change()
        {
            throw new NotImplementedException();
        }

        public void LicensePlate()
        {
            throw new NotImplementedException();
        }

        public void OverTimeRate()
        {
            throw new NotImplementedException();
        }

        public void Owner()
        {
            throw new NotImplementedException();
        }

        public void Paid()
        {
            throw new NotImplementedException();
        }

        public void Place()
        {
            throw new NotImplementedException();
        }

        public void Rate()
        {
            throw new NotImplementedException();
        }

        public void Sector()
        {
            throw new NotImplementedException();
        }

        public void ThereIsNoVehicleWithLicensePlate()
        {
            throw new NotImplementedException();
        }

        public void TotalAmount()
        {
            throw new NotImplementedException();
        }

        public void Type()
        {
            throw new NotImplementedException();
        }
    }



    public class Engine
    {
        private IExit exit;
        private IFindVehicle findVehicle;
        private IPark park;
        private ISetupPark setupPark;
        private IStatus status;
        private IVehiclesByOwner vehiclesByOwner;

        public Engine(ISetupPark setupPark, IPark park, IExit exit, IFindVehicle findVehicle, IVehiclesByOwner vehiclesByOwner, IStatus status)
        {
            this.setupPark = setupPark;
            this.park = park;
            this.exit = exit;
            this.findVehicle = findVehicle;
            this.vehiclesByOwner = vehiclesByOwner;
            this.status = status;
        }

        public void Run()
        {
            exit.SomeObject = "exit";
            findVehicle.SomeObject = "findVehicle";
            park.SomeObject = "park";
            setupPark.SomeObject = "setupPark";
            status.SomeObject = "status";
            vehiclesByOwner.SomeObject = "vehiclesByOwner";


        }
    }


    public interface IEngine
    {
        void Run();
    }

    public interface IVehiclesByOwner
    {
        string SomeObject { get; set; }
        void LicensePlate();
        void Owner();
        void Place();
        void Sector();
        void Type();
    }

    public interface IStatus
    {
        string SomeObject { get; set; }
        void Exit();
        void Park();
    }

    public interface ISetupPark
    {
        string SomeObject { get; set; }
        void Created();
        void PlacesPerSectorPositive();
        void SectorsPositive();
        void TheVehicleParkHasNotBeenSetup();
    }

    public interface IPark
    {
        string SomeObject { get; set; }
        void LicensePlate();
        void Place();
        void Sector();
        void Type();
    }

    public interface IFindVehicle
    {
        string SomeObject { get; set; }
        void LicensePlate();
        void Owner();
        void Place();
        void Sector();
        void Type();
    }

    public interface IExit
    {
        string SomeObject { get; set; }
        void Type();
        void LicensePlate();
        void Owner();
        void Sector();
        void Place();
        void Rate();
        void OverTimeRate();
        void TotalAmount();
        void Paid();
        void Change();
        void ThereIsNoVehicleWithLicensePlate();
    }
}