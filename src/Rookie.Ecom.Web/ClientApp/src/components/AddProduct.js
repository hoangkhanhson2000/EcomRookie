import React from 'react';
import { connect } from 'react-redux';
import "./AddProduct.css";


export default function AddProduct() {
    return (
        <div className="newProduct">
            <h1 className="addProductTitle">New Product</h1>
            <form className="addProductForm">
               
                <div className="addProductItem">
                    <label>ProductName</label>
                    <input type="text" placeholder="Apple Airpods,etc" />
                </div>
                <div className="addProductItem">
                    <label>Description</label>
                    <input type="text-area" placeholder="123" />
                </div>
              
                <div className="addProductItem">
                    <label>Product Image</label>
                    <input type="file" id="file" />
                </div>
                <div className="addProductItem">
                    <label>Price</label>
                    <input type="number" placeholder="" />
                </div>
                <div className="addProductItem">
                    <label>Stock/Cost</label>
                    <input type="text-area" placeholder="123" />
                </div>
                <div className="addProductItem">
                    <label>Active</label>
                    <select name="active" id="active">
                        <option value="yes">Yes</option>
                        <option value="no">No</option>
                    </select>


                </div>
                <button className="addProductButton">Create</button>
            </form>
        </div>
    );
}
