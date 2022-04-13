import React from 'react';
import styles from './App.scss';
import {PersonTS, contactsApi} from "../api/contactsApi";

export const App: React.FC = ({}) => {
    const [contacts, setContacts] = React.useState<ReadonlyArray<PersonTS>>([]);
    const [Name, setName] = React.useState('');
    const [Age, setAge] = React.useState(0);
    const [IsMale, setIsMale] = React.useState(true);
    const [IsWeird, setIsWeird] = React.useState(true);

    React.useEffect(() => {
        contactsApi.getContacts().then(setContacts);
        console.log(1)
    }, []);

    const onCreate = () => {
        console.log(2)
        const contact: PersonTS = {
            id: undefined,
            Name,
            Age,
            IsMale,
            IsWeird,
            PostId: undefined
        };
        contactsApi.postContact(contact);
        setContacts([...contacts, contact]);
    };
    
    console.log(4)
    console.log(contacts)
    return (
        <div className={styles.root}>
            <p>Hello, Leha 112212</p>

            <div className={styles.data}>
                <label>Имя</label>
                <input value={Name} onChange={e => setName(e.target.value)}/>
                <label>Возраст</label>
                <input value={Age} onChange={e => setAge(+e.target.value)}/>
                {/*<label>Странность</label>
                <input value={IsWeird} onChange={e => setIsWeird("true" == e.target.value)}/>*/}
                <button onClick={onCreate}>Добавить человека</button>
            </div>

            <div>
                <table>
                    <tbody>
                        {contacts.map((x) => (
                            <tr key={x.id}>
                                <td>{x.Name}</td>
                                <td>{x.Age}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        </div>
    );
};
