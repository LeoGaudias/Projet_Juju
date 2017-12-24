import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';

export default class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div className="jumbotron">
            <h1>Welcome to RydenPronos</h1>
        </div>;
    }
}
