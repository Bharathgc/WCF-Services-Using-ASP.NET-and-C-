using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChickenFarm
{
    class MultiCellBuffer
    {
        // Create the buffer cells
        public String[] buffercells = new String[2];
        int CellCounter = 0;
      
        //number of cells = 2 as mentioned in assignment
        static int NumberofBuferCells = 2;
        // max number of cells = 5 as mentioned in the assignment
        static int MaxNumberOfCells = 5;
        static int waitInterval = 1000;
        // Initializing the semaphores
        static Semaphore writeLock = new Semaphore(NumberofBuferCells, MaxNumberOfCells);
        static Semaphore readLock = new Semaphore(NumberofBuferCells, MaxNumberOfCells);

        // Initialize the cells.
        public MultiCellBuffer()
        {
            buffercells[0] = null;
            buffercells[1] = null;
        }

        // function to read orders from the cell
        public string getOneCell()
        {
            readLock.WaitOne(waitInterval);
            string OrdersString = "";

            lock (this)
            {
                // If all the cells are full, the thread has to wait until
                while (CellCounter == 0) Monitor.Wait(this);
                //reading the order from the buffer
                bool release = false;
                for (int i = 0; i < NumberofBuferCells && !release; i++)
                {
                    if (buffercells[i] != null)
                    {
                        OrdersString = buffercells[i];
                        buffercells[i] = null;
                        CellCounter--;
                        release = true;
                    }
                }
                // Release the semaphore and all other locks.
                readLock.Release();
                Monitor.PulseAll(this);
            }
            return OrdersString;
        }
        //function to write order into Cell
        public void setOneCell(string order_string)
        {
            writeLock.WaitOne(waitInterval);
            lock (this)
            {
                // If all the cells are full, the thread has to wait until
                while (CellCounter == NumberofBuferCells) Monitor.Wait(this);
                //reading the order from the buffer
                bool release = false;
                for (int i = 0; i < NumberofBuferCells && !release; i++)
                {
                    if (buffercells[i] == null)
                    {
                        buffercells[i] = order_string;
                        CellCounter++;
                        release = true;
                    }
                }
                // Release the semaphore and all other locks.
                writeLock.Release();
                Monitor.PulseAll(this);
            }
        }
    }
}
