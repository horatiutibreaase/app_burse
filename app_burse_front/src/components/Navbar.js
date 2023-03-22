//React
import * as React from 'react';
import { useContext } from 'react';
import { useNavigate } from 'react-router-dom';
import { useState } from 'react';

//Redux
import { useDispatch, useSelector } from 'react-redux';
import { setUsername, setFaculty, setIsAdmin, logOut } from '../redux/actions';

//Material UI
import AppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import { Switch } from '@mui/material';
import Brightness4Icon from '@mui/icons-material/Brightness4';
import Grid from '@mui/material/Grid';

//Context
import { ColorModeContext } from '../App';

//Menu
import Drawer from '@mui/material/Drawer';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import HomeIcon from '@mui/icons-material/Home';
import PaidIcon from '@mui/icons-material/Paid';
import TextSnippetIcon from '@mui/icons-material/TextSnippet';
import InfoIcon from '@mui/icons-material/Info';

export const Navbar = (p) => {
    //Redux store
    const dispatch = useDispatch();
    const usernamee = useSelector((state) => state.username);
    const isAdmin = useSelector((state) => state.isAdmin);

    //Color mode
    const { colorMode, toggleColorMode } = useContext(ColorModeContext);
    const navigate = useNavigate();

    //Drawer
    const [drawerOpen, setDrawerOpen] = useState(false);
    const toggleDrawer = (open) => (event) => {
        if (event && event.type === 'keydown' && (event.key === 'Tab' || event.key === 'Shift')) { return; }
        setDrawerOpen(open);
    };

    //Menu items
    const menuItems = [
        {
            text: 'Acordare bursă',
            icon: <HomeIcon />,
            forAdmin: false,
            onClick: () => {
                navigate("/acordare-bursa");
                setDrawerOpen(false);
            }
        },
        {
            text: "Cuantum",
            icon: <PaidIcon />,
            forAdmin: true,
            onClick: () => {
                navigate("/cuantum");
                setDrawerOpen(false);
            }
        },
        {
            text: 'Jurnal',
            icon: <TextSnippetIcon />,
            forAdmin: true,
            onClick: () => {
                navigate("/jurnal");
                setDrawerOpen(false);
            }
        },
        {
            text: 'Despre',
            icon: <InfoIcon />,
            forAdmin: false,
            onClick: () => {
                navigate("/despre");
                setDrawerOpen(false);
            }
        },
    ];

    return (
        <Grid container item>
            <AppBar position="static" enableColorOnDark>
                <Toolbar>
                    <IconButton size="large" edge="start" color="inherit" aria-label="menu" sx={{ mr: 2 }} onClick={toggleDrawer(true)} >
                        <MenuIcon />
                    </IconButton>
                    <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
                        {p.title}
                    </Typography>
                    <Brightness4Icon />
                    <Switch checked={colorMode === 'dark'} onChange={toggleColorMode} color="secondary" />
                    <Button color="inherit" onClick={() => {
                        dispatch(setUsername(""));
                        dispatch(setFaculty(""));
                        dispatch(setIsAdmin(false));
                        dispatch(logOut());
                        navigate("/")
                    }}>Log out</Button>
                </Toolbar>
                <Drawer open={drawerOpen} onClose={toggleDrawer(false)}>
                    <div role="presentation">
                        <Typography variant="h6" component="div" sx={{ flexGrow: 1, pt: 4, pb: 2, px: 2, fontSize: "1.2rem" }}>
                            👋&nbsp;&nbsp;&nbsp;Bună, {usernamee}
                        </Typography>
                        <List sx={{ width: "100%", minWidth: 300 }}>
                            {menuItems.map((item) => (
                                (item.forAdmin === isAdmin || item.forAdmin === false) &&
                                <ListItem button key={item.text} onClick={item.onClick}>
                                    <ListItemIcon>{item.icon}</ListItemIcon>
                                    <ListItemText primary={item.text} />
                                </ListItem>
                            ))}
                        </List>
                    </div>
                </Drawer>
            </AppBar >
        </Grid >
    );
}