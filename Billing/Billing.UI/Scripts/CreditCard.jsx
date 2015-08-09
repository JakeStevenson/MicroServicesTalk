var CreditCardBox = React.createClass({
    handleSubmit: function (e) {
        e.preventDefault();
        var creditCard = React.findDOMNode(this.refs.creditCard).value.trim();
        var data = { CCNumber: creditCard };
        $.ajax({
            url: "http://billing.cleanair4you.com/CollectBilling/",
            dataType: 'json',
            type: 'POST',
            data: data,
            success: function (data) {
                this.setState({ data: data });
            }.bind(this),
            error: function (xhr, status, err) {
                console.error(this.props.url, status, err.toString());
            }.bind(this)
        });
    },
    render: function () {
        return (
         <form class="creditCardForm" onSubmit={this.handleSubmit}>
                Credit Card: <input type="text" ref="creditCard" />
          <input type="submit" />
         </form>
    );
    }
});
React.render(
  <CreditCardBox />,
  document.getElementById('ca4u-billing')
);