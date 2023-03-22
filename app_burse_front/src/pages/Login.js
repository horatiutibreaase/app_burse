//React
import { useContext } from 'react';
import { Navigate, useNavigate } from 'react-router-dom';

//Redux
import { useDispatch, useSelector } from 'react-redux';
import { setUsername, setFaculty, setIsAdmin, logIn } from '../redux/actions';

//Context
import { ColorModeContext } from '../App';

//Material UI
import Grid from '@mui/material/Grid';
import Box from '@mui/material/Box';
import Paper from '@mui/material/Paper';
import Typography from '@mui/material/Typography';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Avatar from '@mui/material/Avatar';
import Switch from '@mui/material/Switch';
import LockOutlinedIcon from '@mui/icons-material/LockOutlined';
import Brightness4Icon from '@mui/icons-material/Brightness4';

//Assets
import Logo from '../images/logo.svg';

export const Login = () => {
    //Redux store
    const dispatch = useDispatch();
    const loggedIn = useSelector((state) => state.loggedIn);

    //Color mode
    const { colorMode, toggleColorMode } = useContext(ColorModeContext);

    //Redirect
    const navigate = useNavigate();

    //Login
    const handleSubmit = (event) => {
        event.preventDefault();
        const data = new FormData(event.currentTarget);
        console.log({
            username: data.get('username'),
            password: data.get('password'),
        });

        if (data.get('username') === 'secretariat' && data.get('password') === 'secretariat') {
            dispatch(setUsername("secretariat"));
            dispatch(setFaculty("facultate test"));
            dispatch(logIn());
            navigate('/acordare-bursa');
        }
        if (data.get('username') === 'admin' && data.get('password') === 'admin') {
            dispatch(setUsername("admin"));
            dispatch(setFaculty("facultate test"));
            dispatch(setIsAdmin(true));
            dispatch(logIn());
            navigate('/acordare-bursa');
        }
    };

   
    if (loggedIn) return <Navigate to="/acordare-bursa" />
    
    return (
        <Grid container item direction="row" xs>
            <Grid container item alignItems="center" justifyContent="center" xs={7} sx={{ backgroundColor: (theme) => theme.palette.primary.main, }}>
                <div>
                    <img src={Logo} alt='logo' style={{ marginTop: "2rem" }} />
                    <Typography component="h1" variant="h4" color="white" marginTop="5rem" marginBottom="2rem">
                        Aplicația de burse
                    </Typography>
                </div>
            </Grid>
            <Grid item xs={5} component={Paper} elevation={6} square>
                <Box sx={{ my: 8, mx: 4, display: 'flex', flexDirection: 'column', alignItems: 'center', }}>
                    <Avatar sx={{ m: 1, bgcolor: 'secondary.main' }}>
                        <LockOutlinedIcon />
                    </Avatar>
                    <Typography component="h1" variant="h5"> Conectare </Typography>
                    <Box component="form" noValidate onSubmit={handleSubmit} sx={{ mt: 1 }}>
                        <TextField margin="normal" required fullWidth name="username" label="Utilizator" autoComplete="username" autoFocus/>
                        <TextField margin="normal" required fullWidth name="password" label="Parolă" type="password" autoComplete="current-password" />
                        <Button type="submit" fullWidth variant="contained" sx={{ mt: 3 }}>Autentificare</Button>
                        <Box sx={{ display: 'flex', alignItems: 'center', justifyContent: 'center', color: 'text.primary', p: 3, marginTop: '3rem', }} >
                            <Brightness4Icon sx={{ marginRight: "1rem" }} />
                            Modul întunecat
                            <Switch checked={colorMode === 'dark'} onChange={toggleColorMode} color="secondary" inputProps={{ 'aria-label': 'controlled' }}/>
                        </Box>
                    </Box>
                </Box>
            </Grid>
        </Grid>
    )
}