//React
import * as React from 'react';
import { useContext } from 'react';
import { useEffect } from 'react';
import { useState } from 'react';

//Navbar
import { NavbarTitleContext } from '../App';

//Material UI
import { Grid, TextField, Typography } from '@mui/material';
import Paper from '@mui/material/Paper';
import Button from '@mui/material/Button';

const Bursa = (props) => {
    const [value, setValue] = useState(props.initialCost);

    const handleKeyPress = (event) => {
        const keyCode = event.keyCode || event.which;
        const keyValue = String.fromCharCode(keyCode);
        const regex = /[0-9]/;
    
        if (!regex.test(keyValue)) {
          event.preventDefault();
        }

        setValue(event.target.value);
    };
      
    return (
        <Grid container item justifyContent="space-around" alignItems="center" pb={2}>
            <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
                {props.name}
            </Typography>
            <TextField required size='small' defaultValue={value} variant="outlined" InputProps={{ endAdornment: 'RON', onKeyPress: handleKeyPress, }} />
        </Grid>
    )
}

export const Cuantum = () => {
    //Navbar title
    const { setNavbarTitle } = useContext(NavbarTitleContext);
    useEffect(() => {
        setNavbarTitle("Cuantum burse");
    }, [setNavbarTitle]);

    return (
        <Grid container item direction="column" justifyContent="center" alignItems="center" xs>
            <Grid item component={Paper} elevation={6} square width="80%" padding={6}>
                <Bursa name="Bursă de merit" initialCost={800}/>
                <Bursa name="Bursă de performanță" initialCost={1000}/>
                <Bursa name="Bursă socială" initialCost={750}/>
                <Button variant="contained" color="primary" size="large" sx={{marginTop: 2}}>Salvare</Button>
            </Grid>
        </Grid>
    )
}