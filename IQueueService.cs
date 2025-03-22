public interface IQueueService
{
    void Enqueue(string message);
    string Dequeue();
    int Count();
    void PrintQueue();
    bool IsEmpty();
}
