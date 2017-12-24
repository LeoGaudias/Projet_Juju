import * as React from 'react';
import { NavLink, Link } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        return <nav className='navbar navbar-inverse navbar-fixed-top'>
                <div className="container">
                    <div className='navbar-header'>
                        <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                            <span className='sr-only'>Toggle navigation</span>
                            <span className='icon-bar'></span>
                            <span className='icon-bar'></span>
                            <span className='icon-bar'></span>
                        </button>
                        <Link className='navbar-brand' to={'/'}>RydenPronos</Link>
                    </div>
                    <div className='navbar-collapse collapse'>
                        <ul className='nav navbar-nav navbar-right'>
                            <li>
                                <NavLink exact to={'/login'} activeClassName='active'>
                                    <span className='glyphicon glyphicon-log-in'></span> Sign In
                                </NavLink>
                            </li>
                            <li>
                                <NavLink exact to={'/register'} activeClassName='active'>
                                    Sign Up
                                </NavLink>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>;
    }
}
