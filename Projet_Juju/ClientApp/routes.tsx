import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import Home from './components/Home';
import Login from './components/Login';
import Register from './components/Register';

export const routes = <Layout>
    <Route exact path='/' component={Home} />
    <Route exact path='/login' component={Login} />
    <Route exact path='/register' component={Register} />
</Layout>;
