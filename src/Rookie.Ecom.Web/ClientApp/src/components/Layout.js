import React from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';
import Sidebar from './Sidebar';

export default props => (
  <div>
        <NavMenu />
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-1">
                    <Sidebar />
                </div>
                <div class="col">
                    <Container>
                        {props.children}
                    </Container>
                </div>
                
            </div>
        </div>
        
    
  </div>
);
