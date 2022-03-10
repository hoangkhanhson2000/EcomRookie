import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/Product';

class Product extends Component {
    componentDidMount() {
        // This method is called when the component is first added to the document
        this.ensureDataFetched();
    }

    componentDidUpdate() {
        // This method is called when the route parameters change
        this.ensureDataFetched();
    }

    ensureDataFetched() {
        console.log(this.props.match.params.page);
        const page = parseInt(this.props.match.params.page, 5) || 0;
        console.log(page);
        this.props.requestProduct(page);
    }

    render() {
        return (
            <div>
                <h1>Product</h1>
                <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
                {renderProductTable(this.props)}
                {renderPagination(this.props)}
            </div>
        );
    }
}

function renderProductTable(props) {
    console.log(props);
    return (
        <table className='table table-striped'>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Desc</th>
                    <th>ImageURL</th>
                    <th>Price</th>
                    <th>Cost</th>
                    <th>IsFeatured</th>
                    <th>Category</th>
                </tr>
            </thead>
            <tbody>
                {props.product.map(cat =>
                    <tr key={cat.id}>
                        <td>{cat.id}</td>
                        <td>{cat.name}</td>
                        <td>{cat.desc}</td>
                        <td>{cat.imageUrl}</td>
                        <td>{cat.price}</td>
                        <td>{cat.cost}</td>
                        <td>{cat.isFeatured + "" }</td>
                        <td>{cat.categoryid}</td>
                    </tr>
                )}
            </tbody>
        </table>
    );
}

function renderPagination(props) {
    const prevStartDateIndex = (props.page || 0) - 5;
    const nextStartDateIndex = (props.page || 0) + 5;

    return <p className='clearfix text-center'>
        <Link className='btn btn-default pull-left' to={`/product/${prevStartDateIndex}`}>Previous</Link>
        <Link className='btn btn-default pull-right' to={`/product/${nextStartDateIndex}`}>Next</Link>
        {props.isLoading ? <span>Loading...</span> : []}
    </p>;
}

export default connect(
    state => state.product,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Product);