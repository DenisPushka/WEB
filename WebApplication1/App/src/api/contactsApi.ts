const URL = 'api/v1/auth'

function getContact(id: Guid): Promise<PersonTS> {
    return fetch(`${URL}/${id}`).then(x => x.json());
}

function Get(): Promise<PersonTS[]> {
    return fetch(URL)
        .then(response => {
            if (!response.ok) {
                throw new Error(response.statusText)
            }
            console.log(3)
            return response.json()
        })
}

function AddPerson(personTS: PersonTS): Promise<void> {
    return fetch(URL + "/addPerson", {
        method: 'POST',
        headers: {'content-type': 'application/json'},
        body: JSON.stringify(personTS)
    }).then();
}

function DeletePerson(id: Guid): Promise<void> {
    return fetch(`${URL + "/deletePerson"}/${id}`, {
        method: 'DELETE',
    }).then();
}

export const contactsApi = {
    getContact,
    getContacts: Get,
    postContact: AddPerson,
    deleteContact: DeletePerson,
} as const;

export interface PersonTS {
    id: Guid;
    Name: string;
    Age: number;
    IsMale: boolean;
    IsWeird: boolean;
    PostId: Guid;
}
/*
export interface Contact {
    id: Guid;
    title: string;
    phone: string;
    email: string;
}*/
