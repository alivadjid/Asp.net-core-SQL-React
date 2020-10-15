import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';


interface StudentRecordState {
    studentListData: PeopleListData[];
    loading: boolean;
}

//here declaring the StudentList class. And this StudentList class inherits the abstract class React.Component
export class StudentList extends React.Component<RouteComponentProps<{}>, StudentRecordState> {

    //Declaring the constructor 
    constructor() {

        //here we are calling base class constructor using super()
        super();

        //here we are intializing the interface's fields using default values.
        this.state = { studentListData: [], loading: true };

        //this fetch method is responsible to get all the student record using web api.
        fetch('api/People/Index')
            .then(response => response.json() as Promise<PeopleListData[]>)
            .then(data => {
                debugger
                this.setState({ studentListData: data, loading: false });
            });
     
    }


    //render html onto the DOM.
    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderStudentTable(this.state.studentListData);//this renderStudentTable method will return the HTML table. This table will display all the record.
        return <div>
            <h1>SQL Data</h1>
            <p>
                <Link to="/addStudent">Create New</Link>
            </p>
            {contents}
        </div>;
    }
    

    //Метод возвращает данные.
    private renderStudentTable(studentListData: PeopleListData[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th>ФИО</th>
                    <th>Должность</th>
                    <th>Дата рождения</th>
                    <th>Текст</th>
                    <th>Декрет</th>
                </tr>
            </thead>
            <tbody>
                {studentListData.map(item =>
                    <tr key={item.Id}>
                        <td >{item.name}</td>
                        <td >{item.job}</td>
                        <td >{item.date}</td>
                        <td >{item.text}</td>
                        <td >{item.dekret}</td>
                          
                    </tr>
                )}
            </tbody>
        </table>;
    }
}

//here we are declaring a class which have the same properties as we have in model class.
export class PeopleListData {
    Id: number = 0;
    name: string = "";
    job: string = "";
    date: string = "";
    text: string = "";
    dekret: string = "";
}