import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import Home from './components/Home';
import Login from './components/User/Login';
import Register from './components/User/Register';
import ForgotPswd from './components/User/ForgotPswd';

export const routes = <Layout>
    <Route exact path='/' component={Home} />
    <Route exact path='/login' component={Login} />
    <Route exact path='/register' component={Register} />
    <Route exact path='/forgotPswd' component={ForgotPswd} />
</Layout>;
