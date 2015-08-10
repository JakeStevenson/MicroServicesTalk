var CreditCardBox = React.createClass({
    getInitialState: function(){
        return { display: false};
    },
    handleSubmit: function (e) {
        e.preventDefault();
        var creditCard = React.findDOMNode(this.refs.creditCard).value.trim();
        var data = { CCNumber: creditCard, Email: pageData.email };
        $.ajax({
            url: "http://billing.cleanair4you.com/CollectBilling/",
            dataType: 'json',
            type: 'POST',
            data: data,
            success: function (data) {
                this.setState({ display: false });
                dumbBus.updateAll("ccdone");
            }.bind(this)
        });
    },
    render: function () {
        var self = this;
        dumbBus.updaters.push(function (message) {
            if(message==="account"){
                self.setState({display: true});
            }
        });
        return ( this.state.display ? 
         <form class="creditCardForm" onSubmit={this.handleSubmit}>
                Credit Card: <input type="text" ref="creditCard" />
          <input type="submit" />
         </form>
         : null
    );
    }
});
React.render(
  <CreditCardBox />,
  document.getElementById('ca4u-billing')
);