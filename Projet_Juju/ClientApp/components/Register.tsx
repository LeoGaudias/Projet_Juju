import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';

export default class Register extends React.Component<RouteComponentProps<{}>, {}>
{
    public render() {
        return <div className="signInUp">
            <h2>Registration</h2>
            <div className="row">
                <div className="col-md-12">
                    <form method="post">
                        <div className="form-group">
                            <label htmlFor="Email"></label>
                            <input htmlFor="Email" className="form-control" />
                        </div>
                        <div className="form-group">
                            <label htmlFor="Password"></label>
                            <input htmlFor="Password" className="form-control" />
                        </div>
                        <div className="form-group">
                            <button type="submit" className="btn btn-default">Continue</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>;
    }
}