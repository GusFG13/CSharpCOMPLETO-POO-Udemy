namespace Section14.Aula210b.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
