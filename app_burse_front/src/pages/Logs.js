//React
import * as React from 'react';
import { useContext } from 'react';
import { useEffect } from 'react';

//Material UI
import { DataGrid, GridToolbar } from '@mui/x-data-grid';

//Navbar title
import { NavbarTitleContext } from '../App';

export const Logs = () => {
    //Navbar title
    const { setNavbarTitle } = useContext(NavbarTitleContext);
    useEffect(() => {
        setNavbarTitle("Jurnal");
    }, [setNavbarTitle]);

    const columns = [
        { field: 'id', headerName: 'ID', width: 70 },
        { field: 'date', headerName: 'Data', width: 130 },
        { field: 'time', headerName: 'Ora', width: 130 },
        { field: 'username', headerName: 'Username', width: 130 },
        { field: 'action', headerName: 'Acțiune', width: 130, flex: 1 },
    ];

    const rows = [
        { id: 1, username: 'admin', action: 'Adăugare bursa', date: '2021-06-01', time: '12:00:00' },
        { id: 2, username: 'admin', action: 'Ștergere bursa', date: '2021-06-01', time: '12:00:00' },
        { id: 3, username: 'secretariat', action: 'Adăugare bursa', date: '2021-06-01', time: '12:00:00' },
        { id: 4, username: 'secretariat', action: 'Ștergere bursa', date: '2021-06-01', time: '12:00:00' },
    ];

    return (
        <DataGrid
            rows={rows}
            columns={columns}
            components={{ Toolbar: GridToolbar }}
            pagination
            sx={{ height: '100%', width: '100%' }}
            disableRowSelectionOnClick
            disableSelectionOnClick
            density='compact'
        />
    )
}