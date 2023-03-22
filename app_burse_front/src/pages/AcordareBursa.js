//React
import React from 'react';
import { useState } from 'react';
import { useContext } from 'react';
import { useEffect } from 'react';
import { NavbarTitleContext } from '../App';

//Material UI
import { TextField, Typography } from '@mui/material';
import MenuItem from '@mui/material/MenuItem';
import Paper from '@mui/material/Paper';
import { Grid } from '@mui/material';
import Button from '@mui/material/Button';
import { DataGrid, GridToolbar } from '@mui/x-data-grid';

//Data
import { facultati, tipuriBursa, cicluDeStudii, anStudiu } from '../components/Filters';

const columns = [
    { field: "id", headerName: "CNP", width: 150, flex: 1 },
    { field: "Nume", headerName: "Nume", width: 150, flex: 1 },
    { field: "InitialaTatalui", headerName: "Inițiala tatălui", width: 150, flex: 1 },
    { field: "Prenume", headerName: "Prenume", width: 150, flex: 1 },
    { field: "Medie", headerName: "Medie", width: 150, flex: 1, type: 'number' },
    { field: "Bursa", headerName: "Bursa", width: 150, flex: 1, type: 'boolean' },
    {
        field: "actions",
        type: "actions",
        width: 150,
        flex: 1,
        renderCell: (params) => {
            return (
                <Button
                    {...(params.row.Bursa ? { variant: "outlined" } : { variant: "contained" })}
                    {...(params.row.Bursa ? { color: "secondary" } : { color: "primary" })}
                    onClick={() => { }}
                    sx={{ width: "9rem" }}
                >
                    {params.row.Bursa ? "Elimină bursă" : "Acordă bursă"}
                </Button>
            )
        }
    }
];
const rows = [
    { id: "7345901245678", Nume: "Popescu", Prenume: "Andreea", InitialaTatalui: "M D", Medie: 9.23, Bursa: true },
    { id: "8234567890123", Nume: "Ionescu", Prenume: "Mihai Alexandru George", InitialaTatalui: "C", Medie: 8.65, Bursa: true },
    { id: "9345678901234", Nume: "Georgescu", Prenume: "Alexandru", InitialaTatalui: "G M", Medie: 6.78, Bursa: false },
    { id: "2456789012345", Nume: "Dumitru", Prenume: "Cristina", InitialaTatalui: "D", Medie: 7.92, Bursa: false },
    { id: "3567890123456", Nume: "Constantinescu", Prenume: "Ionut", InitialaTatalui: "C S", Medie: 8.44, Bursa: true },
    { id: "4678901234567", Nume: "Popa", Prenume: "Maria", InitialaTatalui: "A I", Medie: 7.31, Bursa: false },
    { id: "5789012345678", Nume: "Munteanu", Prenume: "Andrei", InitialaTatalui: "M", Medie: 9.02, Bursa: true },
    { id: "6890123456789", Nume: "Stefanescu-Florescu", Prenume: "Diana", InitialaTatalui: "I", Medie: 8.16, Bursa: false },
    { id: "7901234567890", Nume: "Tudor", Prenume: "Razvan", InitialaTatalui: "D", Medie: 7.73, Bursa: false },
    { id: "9015345678901", Nume: "Voicu", Prenume: "Adina", InitialaTatalui: "V", Medie: 9.58, Bursa: true },
    { id: "1234567890123", Nume: "Popa", Prenume: "George", InitialaTatalui: "A C", Medie: 8.34, Bursa: true },
    { id: "2345678901234", Nume: "Mihai", Prenume: "Laura", InitialaTatalui: "M F", Medie: 7.21, Bursa: false },
    { id: "3456789012345", Nume: "Radu", Prenume: "Alin", InitialaTatalui: "R", Medie: 6.89, Bursa: false },
    { id: "4567890123456", Nume: "Diaconu", Prenume: "Andreea", InitialaTatalui: "D V", Medie: 9.02, Bursa: true },
    { id: "5678901234567", Nume: "Stancu", Prenume: "Maria", InitialaTatalui: "A", Medie: 8.76, Bursa: true },
    { id: "6789012345678", Nume: "Popescu", Prenume: "Alexandru", InitialaTatalui: "B", Medie: 7.84, Bursa: false },
    { id: "7890123456789", Nume: "Tanase", Prenume: "Cristina", InitialaTatalui: "L M", Medie: 6.78, Bursa: false },
    { id: "8901234567890", Nume: "Iancu", Prenume: "Andrei", InitialaTatalui: "D P", Medie: 8.44, Bursa: true },
    { id: "9012345678901", Nume: "Voiculescu", Prenume: "Diana", InitialaTatalui: "I", Medie: 7.31, Bursa: false },
    { id: "0123456789012", Nume: "Anton", Prenume: "Razvan", InitialaTatalui: "A", Medie: 8.97, Bursa: true },
    { id: "9876543210987", Nume: "Dinu", Prenume: "Andreea", InitialaTatalui: "D", Medie: 7.65, Bursa: false },
    { id: "8765432109876", Nume: "Badea", Prenume: "Mihai", InitialaTatalui: "G", Medie: 8.56, Bursa: true },
    { id: "7654321098765", Nume: "Popescu", Prenume: "Ana", InitialaTatalui: "M", Medie: 6.78, Bursa: false },
    { id: "6543210987654", Nume: "Tudorache", Prenume: "Ioan", InitialaTatalui: "A S", Medie: 7.92, Bursa: false },
    { id: "5432109876543", Nume: "Barbu", Prenume: "Maria", InitialaTatalui: "C", Medie: 8.44, Bursa: true },
    { id: "4321098765432", Nume: "Georgescu", Prenume: "Andrei", InitialaTatalui: "G A", Medie: 7.31, Bursa: false },
    { id: "3210987654321", Nume: "Munteanu", Prenume: "Diana", InitialaTatalui: "M C", Medie: 9.02, Bursa: true },
    { id: "2109876543210", Nume: "Popa", Prenume: "Radu", InitialaTatalui: "A", Medie: 8.16, Bursa: false },
    { id: "1098765432109", Nume: "Cristea", Prenume: "Roxana", InitialaTatalui: "C G", Medie: 7.73, Bursa: false },
    { id: "0987654321098", Nume: "Nistor", Prenume: "Adrian", InitialaTatalui: "A", Medie: 9.58, Bursa: true },
];

export const AcordareBursa = () => {
    //States
    const [selectedFacultate, setSelectedFacultate] = useState('');
    const [selectedSpecializare, setSelectedSpecializare] = useState('');
    const [selectedCicluStudii, setSelectedCicluStudii] = useState('');
    const [selectedAnStudiu, setSelectedAnStudiu] = useState('');
    const [selectedTipBursa, setSelectedTipBursa] = useState('');

    //Navbar title
    const { setNavbarTitle } = useContext(NavbarTitleContext);
    useEffect(() => {
        setNavbarTitle("Acordare bursă");
    }, [setNavbarTitle]);

    return (
        <Grid container item direction="column" justifyContent="flex-start" xs>
            <Grid container direction="row" component={Paper} elevation={3} alignItems="center" square sx={{ p: 2, width: "100%", '& .MuiTextField-root': { mr: 1, width: '25ch' } }}>
                <Typography ml={2} mr={4}>
                    Filtre:
                </Typography>
                <TextField id="facultate" select label="Facultate" variant="outlined" size="small" value={selectedFacultate} onChange={(e) => setSelectedFacultate(e.target.value)}>
                    {facultati.map((option) => (
                        <MenuItem key={option.value} value={option.value}>
                            {option.label}
                        </MenuItem>
                    ))}
                </TextField>
                <TextField id="specializare" select label="Specializare" variant="outlined" size="small" value={selectedSpecializare} onChange={(e) => setSelectedSpecializare(e.target.value)}>

                </TextField>
                <TextField id="ciclustudii" select label="Ciclu de studii" variant="outlined" size="small" value={selectedCicluStudii} onChange={(e) => setSelectedCicluStudii(e.target.value)}>
                    {cicluDeStudii.map((option) => (
                        <MenuItem key={option.value} value={option.value}>
                            {option.label}
                        </MenuItem>
                    ))}
                </TextField>
                <TextField id="anstudiu" select label="An studiu" variant="outlined" size="small" value={selectedAnStudiu} onChange={(e) => setSelectedAnStudiu(e.target.value)}>
                    {anStudiu.map((option) => (
                        <MenuItem key={option.value} value={option.value}>
                            {option.label}
                        </MenuItem>
                    ))}
                </TextField>
                <TextField id="tipbursa" select label="Tip bursa" variant="outlined" size="small" value={selectedTipBursa} onChange={(e) => setSelectedTipBursa(e.target.value)}>
                    {tipuriBursa.map((option) => (
                        <MenuItem key={option.value} value={option.value}>
                            {option.label}
                        </MenuItem>
                    ))}
                </TextField>
                <Button variant="contained" sx={{ mr: 1 }}>Aplică filtre</Button>
            </Grid>
            <Grid container direction="row" justifyContent="flex-end" alignItems="center" padding={2.2}>
                <Button variant="contained" sx={{ mr: 1.5 }}>Acordă bursă</Button>
                <Button variant="contained" color="secondary" sx={{ mr: 1.5 }}>Șterge bursă</Button>
                <Button variant="contained" color="neutral">Exportă PDF</Button>
            </Grid>
            <DataGrid
                rows={rows}
                columns={columns}
                components={{ Toolbar: GridToolbar }}
                sx={{ height: '100%', width: '100%' }}
                checkboxSelection
                disableRowSelectionOnClick
                disableSelectionOnClick
            />
        </Grid>
    )
}