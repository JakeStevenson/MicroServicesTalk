var AccountInfoBox = React.createClass({
    getInitialState: function(){
        return { completed: false };
    },
    handleSubmit: function (e) {
        e.preventDefault();
        var email = React.findDOMNode(this.refs.userEmail).value;
        var data = {
            Email: email,
            Name: React.findDOMNode(this.refs.userName).value,
            Password: React.findDOMNode(this.refs.password).value
        };
        $.ajax({
            url: "http://www.cleanair4you.com/AccountManagement/Signup",
            dataType: 'json',
            type: 'POST',
            data: data,
            success: function (data) {
                this.setState({ completed: true });
                this.props.updateEmail(email)
            }.bind(this)
        });
    },
    render: function () {
        return (this.state.completed ? null : 
     <form class="ca4u-account-Form" onSubmit={this.handleSubmit}>
         Your Name: <input type="text" ref="userName" /><br/>
         Your Email: <input type="text" ref="userEmail" /><br/>
         Your Password: <input type="password" ref="password" /><br/>
      <input type="submit" />
     </form>
    );
    }
});
