import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';

export default class Register extends React.Component<RouteComponentProps<{}>, {}>
{
    public render() {
        return <div className="signInUp">
            <h2>Register</h2>
            <h4>Create a new account.</h4>
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
                            <input htmlFor="Password" className="form-control" placeholder="Password"/>
                        </div>
                        <div className="form-group">
                            <label htmlFor="ConfirmPswd">Confirm password</label>
                            <input htmlFor="ConfirmPswd" className="form-control" placeholder="Confirm password"/>
                        </div>
                        <div className="form-group">
                            <button type="submit" className="btn btn-default">Register</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>;
    }
}