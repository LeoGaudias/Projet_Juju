import * as React from 'react';
import { Link, RouteComponentProps, NavLink } from 'react-router-dom';

export default class Login extends React.Component<RouteComponentProps<{}>, {}>
{
    public render() {
        return <div className="signInUp">
            <h2>Login</h2>
            <h4>Use a local account to log in</h4>
            <hr></hr>
            <div className="row">
                <div className="col-md-12">
                    <form method="post">
                        <div className="form-group">
                            <label htmlFor="Email">Email</label>
                            <input htmlFor="Email" className="form-control" placeholder="Email" />
                        </div>
                        <div className="form-group">
                            <label htmlFor="Password">Password</label>
                            <input htmlFor="Password" className="form-control" placeholder="Password" />
                        </div>
                        <div className="form-group">
                            <div className="checkbox">
                                <label htmlFor="RememberMe">
                                    <input type="checkbox" htmlFor="RememberMe"/>
                                    Remember me?
                                </label>
                            </div>
                        </div>
                        <div className="form-group">
                            <button type="submit" className="btn btn-default">Log in</button>
                        </div>
                        <div className="form-group">
                            <p>
                                <NavLink exact to={'/forgotPswd'}>
                                    Forgot your password?
                                </NavLink>
                            </p>
                            <p>
                                <NavLink exact to={'/register'}>
                                    Register as a new user?
                                </NavLink>
                            </p>
                        </div>
                    </form>
                </div>
            </div>
        </div>;
    }
}