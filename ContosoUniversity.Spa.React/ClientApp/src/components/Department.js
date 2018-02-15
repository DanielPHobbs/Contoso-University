import React, {Component} from 'react';

export class Department extends Component {
    constructor(props){
        super(props);
        this.state = { departments: [], loading: true};

        fetch('api/department/details')
            .then(response => response.json())
            .then(data => {
                this.setState({departments: data, loading: false});
            });
    }

    departmentTable(departments){
        return(
            <table className='table'>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Budget</th>
                        <th>Start Date</th>
                    </tr>
                </thead>
                <tbody>
                    {departments.map((department) => 
                        <tr key={department.id}>
                            <td>{department.name}</td>
                            <td>{department.budget}</td>
                            <td>{department.startDate}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading 
            ? <p><em>Loading...</em></p> 
            : this.departmentTable(this.state.departments)
        return (
            <div>
                <h1>Departments</h1>
                {contents}
            </div>
        );
    }
}