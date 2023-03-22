//React
import React from 'react'
import { useContext, useEffect } from 'react'

//Material UI
import { Grid, Typography } from '@mui/material'
import { Button } from '@mui/material'

//Navbar title
import { NavbarTitleContext } from '../App';

export const Error404 = () => {
    //Navbar title
    const { setNavbarTitle } = useContext(NavbarTitleContext);
    useEffect(() => {
        setNavbarTitle("Eroare 404");
    }, [setNavbarTitle]);

    return (
        <Grid container item direction="column" justifyContent="center" alignItems="center" xs>
            <Typography variant="h1" component="h1" color="primary" sx={{fontSize:"15rem", fontWeight:"500"}}>404</Typography>
            <h2>Pagina nu a fost găsită.</h2>
            <Button variant="contained" color="primary" href="/">Înapoi la pagina principală</Button>
        </Grid>
    )
}