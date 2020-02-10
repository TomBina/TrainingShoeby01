using System;
using System.Diagnostics;

namespace TrainingShoeby01.GC
{
    public class GcExample
    {
        public static void Gc()
        {
            // Get total memory shows the total allocated bytes by this application.
            var allocatedBytes = System.GC.GetTotalMemory(true);
            Console.WriteLine($"Allocated: {allocatedBytes}.");

            var largeArray = new int[10000];

            allocatedBytes = System.GC.GetTotalMemory(true);
            Console.WriteLine($"Allocated: {allocatedBytes}.");

            var localVar = 10;

            allocatedBytes = System.GC.GetTotalMemory(true);
            Console.WriteLine($"Allocated: {allocatedBytes}.");

            // Generations
            // The heap is organized into generations so it can handle long-lived and short-lived objects. Garbage collection primarily occurs with the
            // reclamation of short-lived objects that typically occupy only a small part of the heap. There are three generations of objects on the heap:
            //
            // Generation 0. This is the youngest generation and contains short-lived objects. An example of a short-lived object is a temporary variable.
            // Garbage collection occurs most frequently in this generation. Newly allocated objects form a new generation of objects and are implicitly generation 0 collections.
            // However, if they are large objects, they go on the large object heap in a generation 2 collection.
            // Most objects are reclaimed for garbage collection in generation 0 and do not survive to the next generation.
            //
            // Generation 1. This generation contains short-lived objects and serves as a buffer between short-lived objects and long-lived objects.
            //
            // Generation 2. This generation contains long-lived objects. An example of a long-lived object is an object in a server application that contains static data that's live for the duration of the process.
            var smallArray = new int[10];
            Console.WriteLine($"GC Generation small array {System.GC.GetGeneration(smallArray)}");
            Console.WriteLine($"GC Generation large array {System.GC.GetGeneration(largeArray)}");

            // Collects where possible
            System.GC.Collect();
        }
    }
}