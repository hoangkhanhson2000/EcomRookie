const requestProductType = 'REQUEST_PRODUCT';
const receiveProductType = 'RECEIVE_PRODUCT';
const initialState = { product: [], isLoading: false };

export const actionCreators = {
    requestProduct: page => async (dispatch, getState) => {
        if (page === getState().product.page) {
            // Don't issue a duplicate request (we already have or are loading the requested data)
            return;
        }

        dispatch({ type: requestProductType, page });

        const url = `api/Product/find?page=${page}`;
        const response = await fetch(url);
        const data = await response.json();
        const product = data.items;
        dispatch({ type: receiveProductType, page, product });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestProductType) {
        return {
            ...state,
            page: action.page,
            isLoading: true
        };
    }

    if (action.type === receiveProductType) {
        return {
            ...state,
            page: action.page,
            product: action.product,
            isLoading: false
        };
    }

    return state;
};
