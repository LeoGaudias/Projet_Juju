import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';

export default class ForgotPswd extends React.Component<RouteComponentProps<{}>, {}>
{
    public render() {
        return <div className="signInUp">
            <h2>Forgot your password?</h2>
            <h4>Enter your email</h4>
            <hr></hr>
            <div className="row">
                <div className="col-md-12">
                    <form method="post">
                        <div className="form-group">
                            <label htmlFor="Email">Email</label>
                            <input htmlFor="Email" className="form-control" placeholder="Email" />
                        </div>
                        <div className="form-group">
                            <button type="submit" className="btn btn-default">Submit</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>;
    }
}