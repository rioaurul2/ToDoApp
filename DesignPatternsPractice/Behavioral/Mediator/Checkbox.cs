namespace DesignPatternsPractice.Behavioral.Mediator
{
    public class Checkbox
    {
        private IMediator _mediator;
        public bool IsChecked { get; private set; }

        public Checkbox(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }


        public void Toggle()
        {
            IsChecked = !IsChecked;
            Console.WriteLine($"☑️ Checkbox toggled to: {IsChecked}");
            _mediator.Notify(this, "Toggle");
        }
    }
}
