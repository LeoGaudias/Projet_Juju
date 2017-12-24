import * as React from 'react';
import { NavMenu } from './NavMenu';
import { Footer } from './Footer';

export class Layout extends React.Component<{}, {}> {
    public render() {
        return <div>
            <NavMenu />
            <div className="container">
                { this.props.children }
                <Footer />
            </div>
        </div>;
    }
}
