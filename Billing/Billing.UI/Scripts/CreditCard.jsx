var CreditCardBox = React.createClass({
    getInitialState: function(){
        return{display: true}
    },
    handleSubmit: function (e) {
        e.preventDefault();
        var creditCard = React.findDOMNode(this.refs.creditCard).value.trim();
        var data = { CCNumber: creditCard, Email: this.props.email};
        $.ajax({
            url: "http://billing.cleanair4you.com/CollectBilling/",
            dataType: 'json',
            type: 'POST',
            data: data,
            success: function (data) {
                this.setState({ display: false });
                this.props.complete();
            }.bind(this)
        });
    },
    render: function () {
        var self = this;
        return ( 
            <div>
                {this.state.display===false ? null : 
         <form class="creditCardForm" onSubmit={this.handleSubmit}>
                Credit Card: <input type="text" ref="creditCard" />
          <input type="submit" />
         </form>
                }
         </div>
        );
    }
});
