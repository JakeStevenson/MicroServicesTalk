var AccountInfoBox = React.createClass({
    getInitialState: function(){
        return { completed: false };
    },
    handleSubmit: function (e) {
        e.preventDefault();
        debugger;
        pageData.name = React.findDOMNode(this.refs.userName).value
        pageData.email = React.findDOMNode(this.refs.userEmail).value
        var password = React.findDOMNode(this.refs.password).value;
        var data = {
            Email: pageData.email,
            Name: pageData.name,
            Password: password
        };
        $.ajax({
            url: "http://www.cleanair4you.com/AccountManagement/Signup",
            dataType: 'json',
            type: 'POST',
            data: data,
            success: function (data) {
                this.setState({ completed: true });
            }.bind(this),
            error: function (xhr, status, err) {
                console.error(this.props.url, status, err.toString());
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
React.render(
  <AccountInfoBox />,
  document.getElementById('ca4u-account')
);