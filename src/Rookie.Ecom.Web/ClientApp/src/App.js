import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Category from './components/Category';

import Counter from './components/Counter';
import FetchData from './components/FetchData';
import Product from './components/Product';
import AddProduct from './components/AddProduct';

import CallbackPage from './components/callback/CallbackPage';
import ProfilePage from './components/profile/ProfilePage';
import "./App.css";


export default () => (
    <Layout>
        <Route exact path="/" component={Home} />
        <Route path="/counter" component={Counter} />
        <Route path="/category/:page?" component={Category} />
        <Route path="/product/:page?" component={Product} />
        <Route path="/addproduct/:page?" component={AddProduct} />
       
        <Route path="/fetch-data/:startDateIndex?" component={FetchData} />

        <Route path="/profile" component={ProfilePage} />
        <Route path="/callback" component={CallbackPage} />
    </Layout>
);
