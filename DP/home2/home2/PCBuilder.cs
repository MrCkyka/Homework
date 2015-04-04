using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2
{
    abstract class PCBuilder
    {
        protected PC PC { get; private set; }
        public void CreateNewPC()
        {
            PC = new PC();
        }
        public PC GetMyPC()
        {
            return PC;
        }
        public abstract void SetMonitor();
        public abstract void SetProcessor();
        public abstract void SetMemory();
        public abstract void SetHDD();
        public abstract void SetVideo();


    }

    class GamePC : PCBuilder
    {
        public override void SetMonitor()
        {
            PC.Monitor = "1900x1200 3D";
        }
        public override void SetProcessor()
        {
            PC.Processor = " core 2 quad 3,4 GHz";
        }
        public override void SetMemory()
        {
            PC.Memory = "2 x (8 Gb)";
        }
        public override void SetHDD()
        {
            PC.HDD = " 10 TB";
        }
        public override void SetVideo()
        {
            PC.Video = " 2 x (2 Gb)";
        }

    }
    class OfficePC : PCBuilder
    {
        public override void SetMonitor()
        {
            PC.Monitor = "1900x1200 3D";
        }
        public override void SetProcessor()
        {
            PC.Processor = " core 2 duo 2,5 GHz";
        }
        public override void SetMemory()
        {
            PC.Memory = "4 Gb";
        }
        public override void SetHDD()
        {
            PC.HDD = " 1 TB";
        }
        public override void SetVideo()
        {
            PC.Video = " 1 Gb";
        }

    }

    class BuyPC
    {
        private PCBuilder PCBuilder;

        public void SetPCBuilder(PCBuilder PCBuilder)
        {
            this.PCBuilder = PCBuilder;
        }
        public PC GetPC()
        {
            return PCBuilder.GetMyPC();
        }
        public void ConstructPC()
        {
            PCBuilder.CreateNewPC();
            PCBuilder.SetMonitor();
            PCBuilder.SetProcessor();
            PCBuilder.SetMemory();
            PCBuilder.SetHDD();
            PCBuilder.SetVideo();
        }
    
    }

}
