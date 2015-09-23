

var NavbarLeftMenuBar = React.createClass({
render: function() {
    return(<ul className="nav navbar-nav">
                <li><a data-toggle="modal" href="#myModal" id="help">Help</a></li>
                <li> <a href="" className="dropdown-toggle" data-toggle="dropdown">Menu <b className="caret"></b></a>
                    <ul className="dropdown-menu">
                        <li><a href="">Menu1</a></li>
                        <li><a href="">Menu2 </a></li>
                        <li><a href="">Menu3 </a></li>
                        <li><a href="">Menu4 </a></li>
                    </ul>
                </li>
           </ul>);
}
});

React.render(
  <NavbarLeftMenuBar />,
  document.getElementById('content')
);