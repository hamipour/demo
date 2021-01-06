import React from 'react';
import { Button, Container, Menu } from 'semantic-ui-react';

interface IProps{
  openCreateFrom:  () => void;
}

const Navbar: React.FC<IProps> = ({openCreateFrom}) => {
    return (
        <Menu fixed="top" inverted>
            <Container>
                <Menu.Item header>
                  <img src="/assets/logo.png" alt="logo" style={{marginRight:10}}/>
                  Demo
                </Menu.Item>
                <Menu.Item name="messages" />
                <Menu.Item >
                  <Button onClick={openCreateFrom} positive content="create activity"/>
                </Menu.Item>
            </Container>
        </Menu>
    );
};
export default Navbar;
