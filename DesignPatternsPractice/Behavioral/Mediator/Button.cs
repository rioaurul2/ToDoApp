namespace DesignPatternsPractice.Behavioral.Mediator
{
    public class Button
    {
        private IMediator _mediator;

        public Button(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }


        public void Click()
        {
            Console.WriteLine("🔘 Button clicked");
            _mediator.Notify(this, "Click");
        }
    }
}
