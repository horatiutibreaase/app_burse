//React
import * as React from 'react';
import { useContext } from 'react';
import { useEffect } from 'react';

//Redux
import { useSelector } from 'react-redux';

//Material UI
import { Grid, Typography } from '@mui/material';
import Paper from '@mui/material/Paper';
import Button from '@mui/material/Button';

//Navbar title
import { NavbarTitleContext } from '../App';

import axios from 'axios';

function getWeather() {
    axios.get('http://localhost:5000/WeatherForecast/GetWeatherForecast')
        .then(response => {
            console.log(response.data);
        })
        .catch(error => {
            console.log(error);
        });
}

const data = {
    name: 'John',
    age: 30
};

function postWeather() {

    axios.post('http://localhost:5000/WeatherForecast/PostWheatherForecast', data)
        .then(response => {
            console.log(response.data);
        })
        .catch(error => {
            console.log(error);
        });
}

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
            <Grid item component={Paper} elevation={6} m={2} p={4} xs>
                <Typography component="h1" variant="h4" color="primary" marginBottom="2rem"> Test vreme </Typography>
                <Button variant="contained" color="primary" onClick={getWeather}>GET VREMEA</Button>
                <Button variant="contained" color="primary" onClick={postWeather}>POST VREMEA</Button>
            </Grid>
        </Grid>
    )
}