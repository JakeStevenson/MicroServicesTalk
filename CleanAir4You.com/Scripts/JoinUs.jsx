var JoinUsBox = React.createClass({
    getInitialState: function(){
        return{
            email: "",
            complete: false
        }
    },
    render: function () {
        return(
            <div>
                <AccountInfoBox updateEmail={this.updateEmail} />
                {this.state.email==="" ? null :
                    <CreditCardBox email={this.state.email} complete={this.completeSignup} />
                }
                {this.state.complete===false ? null : 
                    <div id="ca4u-success">Thanks, We'll be in touch!</div>
                }
            </div>
            )
    },
    updateEmail: function(email){
        this.setState({ email: email, complete: false });
    },
    completeSignup: function () {
        email = this.state.email;
        this.setState({complete: true, email: email})
    }
});
React.render(
    <JoinUsBox />,
    document.getElementById('ca4u-joinus')
);