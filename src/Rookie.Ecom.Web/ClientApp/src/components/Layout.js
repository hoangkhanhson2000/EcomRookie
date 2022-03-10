import React from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';
import Sidebar from './Sidebar';


export default props => (
  <div>
       
        <NavMenu />
        
            <div className="container-fluid">
            <Sidebar />
           
            <Container>
                {props.children}
            </Container>
                </div>
               
            
       
        
    
  </div>
);
