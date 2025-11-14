
namespace Sorting;
public class program
{
    static void Main(string[] args)
    {
        Insertion insert = new Insertion();
        
        insert.RunSortAlgo();
        Utility utl= new Utility();
        utl.Clearnextsort();

        
        MergeAlgo merge = new MergeAlgo();
        merge.MergeAlgoPrint();
        utl.Clearnextsort();

        Bubble bub = new Bubble();
        bub.printtheBubble();
        utl.Clearnextsort();
        Select sel= new Select();

        sel.SelectToScreen();
        utl.Clearnextsort();

        Heap heap = new Heap();
        heap.HeapingItToScreen();
        utl.Clearnextsort();

        IAMSPEED speed  = new IAMSPEED();
        speed.SPEEDONSCREEN();
    }
  
}

