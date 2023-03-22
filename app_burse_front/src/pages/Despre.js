//React
import * as React from 'react';
import { useContext } from 'react';
import { useEffect } from 'react';

//Redux
import { useSelector } from 'react-redux';

//Material UI
import { Grid, Typography } from '@mui/material';
import Paper from '@mui/material/Paper';

//Navbar title
import { NavbarTitleContext } from '../App';

export const About = () => {
    //Redux store
    const username = useSelector((state) => state.username);
    const faculty = useSelector((state) => state.faculty);
    const isAdmin = useSelector((state) => state.isAdmin);

    //Navbar title
    const { setNavbarTitle } = useContext(NavbarTitleContext);
    useEffect(() => {
        setNavbarTitle("Despre");
    }, [setNavbarTitle]);

    return (
        <Grid item container direction="row" justifyContent="center" alignItems="flex-start" p={2} xs>
                <Grid item component={Paper} elevation={6} m={2} p={4} xs>
                    <Typography component="h1" variant="h4" color="primary" marginBottom="2rem"> Detalii utilizator </Typography>
                    <Typography>Nume utilizator: {username} </Typography>
                    <Typography>Facultate: {faculty} </Typography>
                    <Typography>Admin: {isAdmin ? "Da" : "Nu"} </Typography>
                </Grid>
                <Grid item component={Paper} elevation={6} m={2} p={4} xs>
                    <Typography component="h1" variant="h4" color="primary" marginBottom="2rem"> Detalii aplicație </Typography>
                    <Typography>Versiune: 1.0 </Typography>
                    <Typography>Ultima actualizare: 01.01.2023 </Typography>
                </Grid>
        </Grid>
    )
}